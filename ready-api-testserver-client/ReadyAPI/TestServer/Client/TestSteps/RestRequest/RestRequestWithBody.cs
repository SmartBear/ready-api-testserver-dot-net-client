namespace ReadyAPI.TestServer.Client.TestSteps.RestRequest
{
    public class RestRequestWithBody : BaseRestRequest<IRestRequestBuilderWithBody> , IRestRequestBuilder<IRestRequestBuilderWithBody>, IRestRequestBuilderWithBody
    {
        public RestRequestWithBody(string uri, TestSteps.HttpMethod post) : base(uri, post)
        {}

        public IRestRequestBuilderWithBody WithRequestBody(string requestBody)
        {
            _testStep.RequestBody = requestBody;
            return this;
        }

        public IRestRequestBuilderWithBody WithMediaType(string mediaType)
        {
            _testStep.MediaType = mediaType;
            return this;
        }

        public IRestRequestBuilderWithBody WithEncoding(string encoding)
        {
            _testStep.Encoding = encoding;
            return this;
        }
    }
}
