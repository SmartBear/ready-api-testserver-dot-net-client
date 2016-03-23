namespace ReadyAPI.TestServer.Client.TestSteps.RestRequest
{
    public interface IRestRequestBuilderWithBody : IRestRequestBuilder<IRestRequestBuilderWithBody>
    {
        IRestRequestBuilderWithBody WithRequestBody(string requestBody);

        IRestRequestBuilderWithBody WithMediaType(string mediaType);

        IRestRequestBuilderWithBody WithEncoding(string encoding);
    }
}
