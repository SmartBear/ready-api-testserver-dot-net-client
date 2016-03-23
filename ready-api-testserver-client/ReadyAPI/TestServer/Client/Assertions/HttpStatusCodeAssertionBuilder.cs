namespace ReadyAPI.TestServer.Client.Assertions
{
    public interface HttpStatusCodeAssertionBuilder : AssertionBuilder
    {
        HttpStatusCodeAssertionBuilder AddStatusCode(int statusCode);

        HttpStatusCodeAssertionBuilder AddStatusCodes(params int[] statusCodes);
    }
}
