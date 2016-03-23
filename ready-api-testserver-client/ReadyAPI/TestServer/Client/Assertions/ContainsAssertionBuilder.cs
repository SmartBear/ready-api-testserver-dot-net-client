namespace ReadyAPI.TestServer.Client.Assertions
{
    public interface IContainsAssertionBuilder : IAssertionBuilder
    {
        IContainsAssertionBuilder UseRegEx();

        IContainsAssertionBuilder IgnoreCase();
    }
}
