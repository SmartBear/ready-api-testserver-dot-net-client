using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;
using System;
using System.Collections.Generic;

namespace ReadyAPI.TestServer.Client.Execution
{
    /**
     * This class is responsible for execution test recipes on a Ready! API Server, synchronously or asynchronously.
     */
    public class RecipeExecutor
    {
        //private static readonly int NUMBER_OF_RETRIES_IN_CASE_OF_ERRORS = 3;
        private readonly ReadyapiApi testServerApi;
        private string user;
        private string password;
        private readonly IList<ExecutionListener> executionListeners = new SynchronizedCollection<ExecutionListener>();

        public RecipeExecutor(Scheme scheme, string host, int port) : this(scheme, host, port, ServerDefaults.VERSION_PREFIX)
        {}

        public RecipeExecutor(string host, int port) : this(ServerDefaults.DEFAULT_SCHEME, host, port)
        {}

        public RecipeExecutor(string host) : this(host, ServerDefaults.DEFAULT_PORT)
        {}

        RecipeExecutor(Scheme scheme, string host, int port, string basePath)
        {
            testServerApi = new ReadyapiApi(string.Format("{0}://{1}:{2}{3}", scheme.getValue(), host, port, basePath));
        }

        public void AddExecutionListener(ExecutionListener listener)
        {
            executionListeners.Add(listener);
        }

        public void RemoveExecutionListener(ExecutionListener listener)
        {
            executionListeners.Remove(listener);
        }

        public Execution SubmitRecipe(TestRecipe recipe)
        {
            Execution execution = ExecuteTestCase(recipe.TestCase, true);
            if (execution != null)
            {
                foreach (ExecutionListener executionListener in executionListeners)
                {
                    executionListener.RequestSent(execution.CurrentReport);
                }
                //new ExecutionStatusChecker(execution).start(); TODO uncomment this
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

        public void SetCredentials (string user, string password)
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
                foreach (ExecutionListener executionListener in executionListeners)
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
            foreach (ExecutionListener executionListener in executionListeners)
            {
                executionListener.ExecutionFinished(executionStatus);
            }
        }
        //TODO need to improve this
        /*
        private class ExecutionStatusChecker
        {
            private readonly Timer timer;

            private readonly Execution execution;

            private int errorCount = 0;

            public ExecutionStatusChecker(Execution execution)
            {
                this.execution = execution;
                timer = new Timer();
            }

            public void start()
            {
                timer.schedule(new CheckingExpireDateTask(), 0, 1000);
            }

            class CheckingExpireDateTask : TimerTask
            {
                public void run()
                {
                    try
                    {
                        ProjectResultReport executionStatus = testServerApi.getExecutionStatus(execution.Id, authentication);
                        execution.AddResultReport(executionStatus);
                        if (!ProjectResultReport.StatusEnum.RUNNING.equals(executionStatus.getStatus()))
                        {
                            NotifyExecutionFinished(executionStatus);
                            timer.cancel();
                        }
                        errorCount = 0;
                    }
                    catch (Exception e)
                    {
                        if (errorCount > NUMBER_OF_RETRIES_IN_CASE_OF_ERRORS)
                        {
                            timer.cancel();
                        }
                        Console.Error.WriteLine(e.Message);
                        Console.Error.WriteLine(e.StackTrace.ToString());
                        errorCount++;
                    }
                }
            }
        }*/
    }
}
