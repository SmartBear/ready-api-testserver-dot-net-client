namespace ReadyAPI.TestServer.Client.Assertions
{
    public interface XPathAssertionBuilder : AssertionBuilder
    {
        XPathAssertionBuilder AllowWildCards();

        XPathAssertionBuilder IgnoreComments();

        XPathContainsAssertionBuilder IgnoreNamespaces();
    }
}
