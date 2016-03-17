using IO.Swagger.Model;

namespace ReadyAPI.TestServer.Client.Assertions
{
    public interface ContainsAssertionBuilder : AssertionBuilder
    {
        ContainsAssertionBuilder UseRegEx();

        ContainsAssertionBuilder IgnoreCase();
    }
}
