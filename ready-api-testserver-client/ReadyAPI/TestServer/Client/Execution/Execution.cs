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

        private ProjectResultReport GetProjectResultReport()
        {
            ProjectResultReport projectResultReport;
            executionStatusReports.TryPeek(out projectResultReport);
            return projectResultReport;
        }

        //public ProjectResultReport.StatusEnum getCurrentStatus() TODO: doublecheck this
        public string CurrentStatus
        {
            get
            {
                return GetProjectResultReport().Status;
            }
        }

        public ProjectResultReport CurrentReport
        {
            get
            {
                return GetProjectResultReport();
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
                executionStatusReports.TryPeek(out projectResultReport);

                if (projectResultReport != null)
                {
                    ProjectResultReport executionStatusReport;
                    executionStatusReports.TryPeek(out executionStatusReport);

                    foreach (TestSuiteResultReport testSuiteReport in executionStatusReport.TestSuiteResultReports)
                    {
                        foreach (TestCaseResultReport testCaseResultReport in testSuiteReport.TestCaseResultReports)
                        {
                            foreach (TestStepResultReport testStepResultReport in testCaseResultReport.TestStepResultReports)
                            {
                                if (testStepResultReport.AssertionStatus == "FAILED")
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
