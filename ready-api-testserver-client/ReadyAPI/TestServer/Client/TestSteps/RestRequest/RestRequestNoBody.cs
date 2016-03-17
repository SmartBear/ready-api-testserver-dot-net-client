namespace ReadyAPI.TestServer.Client.TestSteps.RestRequest
{
    public class RestRequestNoBody : BaseRestRequest<RestRequestBuilderNoBody>, RestRequestBuilder<RestRequestBuilderNoBody>, RestRequestBuilderNoBody
    {
        public RestRequestNoBody(string uri, TestSteps.HttpMethod method) : base(uri, method)
        { }
    }
}
