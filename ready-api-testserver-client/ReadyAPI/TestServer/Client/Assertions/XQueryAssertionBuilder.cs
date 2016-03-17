using IO.Swagger.Model;

namespace ReadyAPI.TestServer.Client.Assertions
{
    public interface XQueryAssertionBuilder : AssertionBuilder
    {
        XQueryAssertionBuilder AllowWildcards();
    }
}
