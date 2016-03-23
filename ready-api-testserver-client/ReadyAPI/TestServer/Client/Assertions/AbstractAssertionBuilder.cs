using IO.Swagger.Model;

namespace ReadyAPI.TestServer.Client.Assertions
{
    public abstract class AbstractAssertionBuilder : IAssertionBuilder
    {
        public abstract Assertion Build();
    }
}
