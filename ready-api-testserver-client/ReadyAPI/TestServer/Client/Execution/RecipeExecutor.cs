using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading;

namespace ReadyAPI.TestServer.Client.Execution
{
    /**
     * This class is responsible for execution test recipes on a Ready! API Server, synchronously or asynchronously.
     */
    public class RecipeExecutor
    {
        readonly ReadyapiApi testServerApi;
        string user;
        string password;
        readonly IList<IExecutionListener> executionListeners = new SynchronizedCollection<IExecutionListener>();

        public RecipeExecutor(Scheme scheme, string host, int port) : this(scheme, host, port, ServerDefaults.VERSION_PREFIX)
        { }

        public RecipeExecutor(string host, int port) : this(ServerDefaults.DEFAULT_SCHEME, host, port)
        { }

        public RecipeExecutor(string host) : this(host, ServerDefaults.DEFAULT_PORT)
        { }

        RecipeExecutor(Scheme scheme, string host, int port, string basePath)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;
            testServerApi = new ReadyapiApi(string.Format("{0}://{1}:{2}{3}", scheme.Value, host, port, basePath));
        }

        public ReadyapiApi TestServerApi
        {
            get
            {
                return testServerApi;
            }
        }

        public void AddExecutionListener(IExecutionListener listener)
        {
            executionListeners.Add(listener);
        }

        public void RemoveExecutionListener(IExecutionListener listener)
        {
            executionListeners.Remove(listener);
        }

        public Execution SubmitRecipe(TestRecipe recipe)
        {
            Execution execution = ExecuteTestCase(recipe.TestCase, true);
            if (execution != null)
            {
                foreach (IExecutionListener executionListener in executionListeners)
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
            testServerApi.CancelExecutionWithHttpInfo(execution.Id);
            ProjectResultReport report = testServerApi.GetExecutionStatus(execution.Id);
            execution.AddResultReport(report);
            return execution;
        }

        public List<Execution> Executions
        {
            get
            {
                List<Execution> executions = new List<Execution>();
                ProjectResultReports projectResultReport = testServerApi.GetExecutions();
                foreach (ProjectResultReport resultReport in projectResultReport._ProjectResultReports)
                {
                    executions.Add(new Execution(resultReport));
                }
                return executions;
            }
        }

        public void SetCredentials(string user, string password)
        {
            this.user = user;
            this.password = password;
        }

        private Execution ExecuteTestCase(TestCase testCase, bool async)
        {
            try
            {
                Configuration config = testServerApi.Configuration;
                config.Username = this.user;
                config.Password = this.password;
                testServerApi.Configuration = config;
                ProjectResultReport projectResultReport = testServerApi.PostRecipe(testCase, async);
                return new Execution(projectResultReport);
            }
            catch (Exception e)
            {
                foreach (IExecutionListener executionListener in executionListeners)
                {
                    executionListener.ErrorOccurred(e);
                }
                Console.Error.WriteLine("Error received when sending test recipe to server");
                Console.Error.WriteLine(e.Message);
                Console.Error.WriteLine(e.StackTrace.ToString());
            }
            return null;
        }

        private void NotifyExecutionFinished(ProjectResultReport executionStatus)
        {
            foreach (IExecutionListener executionListener in executionListeners)
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
