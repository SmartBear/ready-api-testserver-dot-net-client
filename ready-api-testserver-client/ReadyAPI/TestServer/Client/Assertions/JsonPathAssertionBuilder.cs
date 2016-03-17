using IO.Swagger.Model;

namespace ReadyAPI.TestServer.Client.Assertions
{
    public interface JsonPathAssertionBuilder : AssertionBuilder
    {
        JsonPathAssertionBuilder AllowWildcards();
    }
}
