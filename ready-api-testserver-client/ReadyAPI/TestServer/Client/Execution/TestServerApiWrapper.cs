using IO.Swagger.Model;

namespace ReadyAPI.TestServer.Client.Execution
{
    /**
     * Defines an API stub that can communicate with the Ready! API Server.
     */
    public interface TestServerApiWrapper
    {
        ProjectResultReport PostTestRecipe(TestCase body, bool async);

        ProjectResultReport GetExecutionStatus(string executionID);

        ProjectResultReports GetExecutions();

        ProjectResultReport CancelExecution(string executionID);

        string BasePath { set; }
    }
}
