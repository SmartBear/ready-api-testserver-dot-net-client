namespace ReadyAPI.TestServer.Client.TestSteps.RestRequest
{
    public class RestRequestNoBody : BaseRestRequest<IRestRequestBuilderNoBody>, IRestRequestBuilder<IRestRequestBuilderNoBody>, IRestRequestBuilderNoBody
    {
        public RestRequestNoBody(string uri, TestSteps.HttpMethod method) : base(uri, method)
        { }
    }
}
