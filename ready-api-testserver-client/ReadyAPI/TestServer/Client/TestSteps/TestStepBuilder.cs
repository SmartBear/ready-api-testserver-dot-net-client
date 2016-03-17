using IO.Swagger.Model;

namespace ReadyAPI.TestServer.Client.TestSteps
{
    public interface TestStepBuilder<TestStepType> where TestStepType : TestStep
    {
        TestStepType Build();
    }
}
