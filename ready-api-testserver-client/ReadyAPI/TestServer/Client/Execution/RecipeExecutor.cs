using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading;

namespace ReadyAPI.TestServer.Client.Execution
{
    /**
     * This class is responsible for execution test recipes on a Ready! API Server, synchronously or asynchronously.
     */
    public class RecipeExecutor
    {
        private readonly ReadyapiApi _testServerApi;
        private string _user;
        private string _password;
        private readonly IList<IExecutionListener> _executionListeners = new SynchronizedCollection<IExecutionListener>();

        public RecipeExecutor(Scheme scheme, string host, int port) : this(scheme, host, port, ServerDefaults.VERSION_PREFIX)
        { }

        public RecipeExecutor(string host, int port) : this(ServerDefaults.DEFAULT_SCHEME, host, port)
        { }

        public RecipeExecutor(string host) : this(host, ServerDefaults.DEFAULT_PORT)
        { }

        RecipeExecutor(Scheme scheme, string host, int port, string basePath)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;
            _testServerApi = new ReadyapiApi(string.Format("{0}://{1}:{2}{3}", scheme.Value, host, port, basePath));
        }

        public ReadyapiApi TestServerApi
        {
            get
            {
                return _testServerApi;
            }
        }

        public void AddExecutionListener(IExecutionListener listener)
        {
            _executionListeners.Add(listener);
        }

        public void RemoveExecutionListener(IExecutionListener listener)
        {
            _executionListeners.Remove(listener);
        }

        public Execution SubmitRecipe(TestRecipe recipe)
        {
            Execution execution = ExecuteTestCase(recipe.TestCase, true);
            if (execution != null)
            {
                foreach (IExecutionListener executionListener in _executionListeners)
                {
                    executionListener.RequestSent(execution.CurrentReport);
                }
                new ExecutionStatusChecker(execution, 1000).Start(this);
            }
            return execution;
        }

        public Execution ExecuteRecipe(TestRecipe recipe)
        {
            Execution execution = ExecuteTestCase(recipe.TestCase, false);
            if (execution != null)
            {
                NotifyExecutionFinished(execution.CurrentReport);
            }
            return execution;
        }

        public Execution CancelExecution(Execution execution)
        {
            _testServerApi.CancelExecutionWithHttpInfo(execution.Id);
            ProjectResultReport report = _testServerApi.GetExecutionStatus(execution.Id);
            execution.AddResultReport(report);
            return execution;
        }

        public List<Execution> Executions
        {
            get
            {
                List<Execution> executions = new List<Execution>();
                ProjectResultReports projectResultReport = _testServerApi.GetExecutions();
                foreach (ProjectResultReport resultReport in projectResultReport._ProjectResultReports)
                {
                    executions.Add(new Execution(resultReport));
                }
                return executions;
            }
        }

        public void SetCredentials(string user, string password)
        {
            this._user = user;
            this._password = password;
        }

        private Execution ExecuteTestCase(TestCase testCase, bool async)
        {
            VerifyDataSourceFilesExist(testCase);

            try
            {
                Configuration config = _testServerApi.Configuration;
                config.Username = this._user;
                config.Password = this._password;
                _testServerApi.Configuration = config;
                ProjectResultReport projectResultReport = _testServerApi.PostRecipe(testCase, async);
                projectResultReport = SendFilesForDataSources(testCase, projectResultReport);
                return new Execution(projectResultReport);
            }
            catch (Exception e)
            {
                foreach (IExecutionListener executionListener in _executionListeners)
                {
                    executionListener.ErrorOccurred(e);
                }
                Console.Error.WriteLine("Error received when sending test recipe to server");
                Console.Error.WriteLine(e.Message);
                Console.Error.WriteLine(e.StackTrace.ToString());
            }
            return null;
        }

        private void VerifyDataSourceFilesExist(TestCase testCase)
        {
            foreach (TestStep testStep in testCase.TestSteps)
            {
                if (testStep is DataSourceTestStep) 
                {
                    DataSource dataSource = ((DataSourceTestStep)testStep).DataSource;
                    if (dataSource.Excel != null)
                    {
                        verifyFileExists(dataSource.Excel.File);
                    }
                    if (dataSource.File != null)
                    {
                        verifyFileExists(dataSource.File.FilePath);
                    }
                }
            }
        }

        private void verifyFileExists(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new InvalidOperationException("Data source file not found: " + filePath);
            }
        }

        private ProjectResultReport SendFilesForDataSources(TestCase body, ProjectResultReport projectResultReport)
        {
            Dictionary<string, string> formParams = BuildFormParameters(body);
            if (formParams.Count == 0)
            {
                return projectResultReport;
            }
            Console.WriteLine(1);
            FormDataMultiPart formDataMultiPart = new FormDataMultiPart();
            List<BodyPart> bodyParts = new List<BodyPart>();
            Console.WriteLine(2);
            foreach (KeyValuePair<string, string> item in formParams)
            {
                //FormDataBodyPart bodyPart = new FormDataBodyPart();
                BodyPart bodyPart = new BodyPart();
                Console.WriteLine(2.1);
                //bodyPart.Name = item.Key;
                bodyPart.MediaType = new MediaType();
                bodyPart.MediaType.Type = "application";
                Console.WriteLine(2.2);
                bodyPart.MediaType.Subtype = "octet-stream";
                Console.WriteLine(2.3);
                bodyPart.ContentDisposition = new ContentDisposition();
                bodyPart.ContentDisposition.FileName = item.Value;
                Console.WriteLine(2.4);
                bodyParts.Add(bodyPart);
                Console.WriteLine(2.5);
            }
            Console.WriteLine(3);
            formDataMultiPart.BodyParts = bodyParts;
            return _testServerApi.AddFile(formDataMultiPart, projectResultReport.ExecutionID);
        }

        private Dictionary<string, string> BuildFormParameters(TestCase testCase)
        {
            Dictionary<string, string> formParams = new Dictionary<string, string>();
            foreach (TestStep testStep in testCase.TestSteps)
            {
                if (testStep is DataSourceTestStep)
                {
                    DataSource dataSource = ((DataSourceTestStep)testStep).DataSource;
                    AddDataSourceFile(formParams, dataSource.Excel);
                    AddDataSourceFile(formParams, dataSource.File);
                }
            }
            return formParams;
        }

        private void AddDataSourceFile(Dictionary<string, string> formParams, FileDataSource fileDataSource)
        {
            if (fileDataSource != null)
            {
                formParams.Add(Path.GetFileName(fileDataSource.FilePath), fileDataSource.FilePath);
            }
        }

        private void AddDataSourceFile(Dictionary<string, string> formParams, ExcelDataSource excelDataSource)
        {
            if (excelDataSource != null)
            {
                formParams.Add(Path.GetFileName(excelDataSource.File), excelDataSource.File);
            }
        }

        private void NotifyExecutionFinished(ProjectResultReport executionStatus)
        {
            foreach (IExecutionListener executionListener in _executionListeners)
            {
                executionListener.ExecutionFinished(executionStatus);
            }
        }

        private class ExecutionStatusChecker
        {
            static readonly int NUMBER_OF_RETRIES_IN_CASE_OF_ERRORS = 3;
            Timer timer;
            readonly Execution execution;
            readonly int timeInterval;
            int errorCount = 0;

            public ExecutionStatusChecker(Execution execution, int timeInterval)
            {
                this.execution = execution;
                this.timeInterval = timeInterval;
            }

            public void Start(object state)
            {
                timer = new Timer(this.TimerProc, state, 0, timeInterval);
            }

            private void TimerProc(object state)
            {
                if (state == null)
                {
                    return;
                }

                RecipeExecutor executor = (RecipeExecutor)state;
                try
                {
                    ProjectResultReport executionStatus = executor.TestServerApi.GetExecutionStatus(execution.Id);
                    execution.AddResultReport(executionStatus);
                    if (executionStatus.Status != "RUNNING")//TODO check available statuses 
                    {
                        executor.NotifyExecutionFinished(executionStatus);
                        timer.Dispose();
                    }
                    errorCount = 0;
                }
                catch (Exception e)
                {
                    if (errorCount > NUMBER_OF_RETRIES_IN_CASE_OF_ERRORS)
                    {
                        timer.Dispose();
                    }
                    Console.Error.WriteLine(e.Message);
                    Console.Error.WriteLine(e.StackTrace.ToString());
                    errorCount++;
                }
            }
        }
    }
}
