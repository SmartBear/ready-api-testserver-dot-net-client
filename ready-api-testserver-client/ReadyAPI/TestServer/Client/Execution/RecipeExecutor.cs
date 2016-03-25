using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading;
using System.Linq;
using System.Text;

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
        private bool? _async = null;
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
            _async = true;
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
            _async = false;
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

        private static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        private ProjectResultReport SendFilesForDataSources(TestCase body, ProjectResultReport projectResultReport)
        {
            Configuration configuration = _testServerApi.Configuration;
            string executionId = projectResultReport.ExecutionID;

            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ReadyapiApi->AddFile");

            // verify the required parameter 'executionId' is set
            if (executionId == null)
                throw new ApiException(400, "Missing required parameter 'executionId' when calling ReadyapiApi->AddFile");
            
            var path_ = "/readyapi/executions/{executionId}/files";

            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            string boundary = Guid.NewGuid().ToString().Replace('-', 'A');
            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "multipart/form-data; boundary=" + boundary

            };
            String httpContentType = configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (executionId != null) pathParams.Add("executionId", configuration.ApiClient.ParameterToString(executionId)); // path parameter

            if (_async != null)
            {
                queryParams.Add("async", configuration.ApiClient.ParameterToString(_async)); // query parameter
            }

            Dictionary<string, string> filesToSend = BuildFormParameters(body);
            string postBodyStr = "";
            byte[] resultArray = new byte[] { };
            foreach (KeyValuePair<string, string> item in filesToSend)
            {
                string fileName = item.Key;
                byte [] fileContent = File.ReadAllBytes(item.Value);
                postBodyStr = "\n--" + boundary + "\nContent-Type: application/octet-stream\nContent-Disposition: form-data; filename=\"" + fileName + "\"; modification-date=\"Wed, 16 Oct 2013 12:54:29 GMT\"; size=10967; name=\"" + fileName + "\"\n\n";
                resultArray = resultArray.Concat(EncodeString(postBodyStr)).ToArray();
                resultArray = resultArray.Concat(fileContent).ToArray();
                resultArray = resultArray.Concat(EncodeString("\n--" + boundary + "--")).ToArray();
            }

            /*
            if (body.GetType() != typeof(byte[]))
            {
                postBody = configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                postBody = body; // byte array
            }
            */

            // authentication (basicAuth) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(configuration.Username) || !String.IsNullOrEmpty(configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + Base64Encode(configuration.Username + ":" + configuration.Password);
            }


            // make the HTTP request
            IRestResponse response = (IRestResponse)configuration.ApiClient.CallApi(path_,
                Method.POST, queryParams, resultArray, headerParams, formParams, fileParams,
                pathParams, httpContentType);
            _async = null;

            int statusCode = (int)response.StatusCode;

            if (statusCode >= 400)
                throw new ApiException(statusCode, "Error calling AddFile: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException(statusCode, "Error calling AddFile: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ProjectResultReport>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ProjectResultReport)configuration.ApiClient.Deserialize(response, typeof(ProjectResultReport))).Data;



            /*            Dictionary<string, string> formParams = BuildFormParameters(body);
                        if (formParams.Count == 0)
                        {
                            return projectResultReport;
                        }
                        FormDataMultiPart formDataMultiPart = new FormDataMultiPart();
                        formDataMultiPart.MediaType = new MediaType();
                        formDataMultiPart.MediaType.Type = "application";
                        formDataMultiPart.MediaType.Subtype = "octet-stream";
                        List<BodyPart> bodyParts = new List<BodyPart>();
                        foreach (KeyValuePair<string, string> item in formParams)
                        {
                            BodyPart bodyPart = new BodyPart();
                            bodyPart.ContentDisposition = new ContentDisposition();
                            bodyPart.MediaType = new MediaType();

                            bodyPart.MediaType.Type = "application";
                            bodyPart.MediaType.Subtype = "octet-stream";

                            bodyPart.ContentDisposition.FileName = item.Key;

                            bodyPart.Entity = item.Value;

                            bodyParts.Add(bodyPart);
                        }
                        formDataMultiPart.BodyParts = bodyParts;
                        return _testServerApi.AddFile(formDataMultiPart, projectResultReport.ExecutionID);
                        */
        }

        static byte[] EncodeString(string input)
        {
            Encoding asciiEncoding = Encoding.ASCII;
            return asciiEncoding.GetBytes(input);
        }

        static byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
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
