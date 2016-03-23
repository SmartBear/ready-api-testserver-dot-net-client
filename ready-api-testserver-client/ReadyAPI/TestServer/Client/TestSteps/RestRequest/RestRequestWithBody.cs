namespace ReadyAPI.TestServer.Client.TestSteps.RestRequest
{
    public class RestRequestWithBody : BaseRestRequest<IRestRequestBuilderWithBody> , IRestRequestBuilder<IRestRequestBuilderWithBody>, IRestRequestBuilderWithBody
    {
        public RestRequestWithBody(string uri, TestSteps.HttpMethod post) : base(uri, post)
        {}

        public IRestRequestBuilderWithBody WithRequestBody(string requestBody)
        {
            testStep.RequestBody = requestBody;
            return this;
        }

        public IRestRequestBuilderWithBody WithMediaType(string mediaType)
        {
            testStep.MediaType = mediaType;
            return this;
        }

        public IRestRequestBuilderWithBody WithEncoding(string encoding)
        {
            testStep.Encoding = encoding;
            return this;
        }
    }
}
