using System.Collections.Concurrent;
using System.Collections.Generic;
using IO.Swagger.Model;

namespace ReadyAPI.TestServer.Client.Execution
{
    /**
     * Represents an execution, synchronous or asynchronous, and encapsulates all available information about the execution.
     */
    public class Execution
    {
        private readonly ConcurrentQueue<ProjectResultReport> executionStatusReports = new ConcurrentQueue<ProjectResultReport>();
        private readonly string id;

        public Execution(ProjectResultReport projectResultReport)
        {
            executionStatusReports.Enqueue(projectResultReport);
            this.id = projectResultReport.ExecutionID;
        }

        public string Id
        {
            get
            { 
                return id;
            }
        }

        //public ProjectResultReport.StatusEnum getCurrentStatus() TODO: doublecheck this
        public string CurrentStatus
        {
            get
            {
                ProjectResultReport projectResultReport;
                executionStatusReports.TryDequeue(out projectResultReport);
                return projectResultReport.Status;

            }
        }

        public ProjectResultReport CurrentReport
        {
            get
            {
                ProjectResultReport projectResultReport;
                executionStatusReports.TryDequeue(out projectResultReport);
                return projectResultReport;
            }
        }

        public void AddResultReport(ProjectResultReport newReport)
        {
            executionStatusReports.Enqueue(newReport);
        }

        public List<string> ErrorMessages
        {
            get
            {
                List<string> result = new List<string>();

                ProjectResultReport projectResultReport;
                executionStatusReports.TryDequeue(out projectResultReport);

                if (projectResultReport != null)
                {
                    ProjectResultReport executionStatusReport;
                    executionStatusReports.TryDequeue(out executionStatusReport);

                    foreach (TestSuiteResultReport testSuiteReport in executionStatusReport.TestSuiteResultReports)
                    {
                        foreach (TestCaseResultReport testCaseResultReport in testSuiteReport.TestCaseResultReports)
                        {
                            foreach (TestStepResultReport testStepResultReport in testCaseResultReport.TestStepResultReports)
                            {
                                if (testStepResultReport.AssertionStatus == "FAILED")
                                //if (testStepResultReport.AssertionStatus == TestStepResultReport.AssertionStatusEnum.FAILED) TODO: doublecheck this
                                {
                                    result.AddRange(testStepResultReport.Messages);
                                }
                            }
                        }
                    }
                }

                return result;
            }
        }
    }
}
