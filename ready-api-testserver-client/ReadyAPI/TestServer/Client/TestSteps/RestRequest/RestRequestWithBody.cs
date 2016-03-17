namespace ReadyAPI.TestServer.Client.TestSteps.RestRequest
{
    public class RestRequestWithBody : BaseRestRequest<RestRequestBuilderWithBody> , RestRequestBuilder<RestRequestBuilderWithBody>, RestRequestBuilderWithBody
    {
        public RestRequestWithBody(string uri, TestSteps.HttpMethod post) : base(uri, post)
        {}

        public RestRequestBuilderWithBody WithRequestBody(string requestBody)
        {
            testStep.RequestBody = requestBody;
            return this;
        }

        public RestRequestBuilderWithBody WithMediaType(string mediaType)
        {
            testStep.MediaType = mediaType;
            return this;
        }

        public RestRequestBuilderWithBody WithEncoding(string encoding)
        {
            testStep.Encoding = encoding;
            return this;
        }
    }
}
