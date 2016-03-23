namespace ReadyAPI.TestServer.Client.Assertions
{
    public interface IHttpStatusCodeAssertionBuilder : IAssertionBuilder
    {
        IHttpStatusCodeAssertionBuilder AddStatusCode(int statusCode);

        IHttpStatusCodeAssertionBuilder AddStatusCodes(params int[] statusCodes);
    }
}
