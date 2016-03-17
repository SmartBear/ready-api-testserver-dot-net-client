namespace ReadyAPI.TestServer.Client.TestSteps.RestRequest
{
    public interface RestRequestBuilderWithBody : RestRequestBuilder<RestRequestBuilderWithBody>
    {
        RestRequestBuilderWithBody WithRequestBody(string requestBody);

        RestRequestBuilderWithBody WithMediaType(string mediaType);

        RestRequestBuilderWithBody WithEncoding(string encoding);
    }
}
