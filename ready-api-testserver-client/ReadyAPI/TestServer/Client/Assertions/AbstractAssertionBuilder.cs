using IO.Swagger.Model;

namespace ReadyAPI.TestServer.Client.Assertions
{
    public abstract class AbstractAssertionBuilder : AssertionBuilder
    {
        public abstract Assertion Build();
    }
}
