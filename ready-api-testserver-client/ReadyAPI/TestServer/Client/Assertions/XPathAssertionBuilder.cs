namespace ReadyAPI.TestServer.Client.Assertions
{
    public interface IXPathAssertionBuilder : IAssertionBuilder
    {
        IXPathAssertionBuilder AllowWildCards();

        IXPathAssertionBuilder IgnoreComments();

        XPathContainsAssertionBuilder IgnoreNamespaces();
    }
}
