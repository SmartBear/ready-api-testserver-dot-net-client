using IO.Swagger.Model;

namespace ReadyAPI.TestServer.Client.TestSteps
{
    public interface TestStepBuilder<T> where T : TestStep
    {
        T Build();
    }
}
