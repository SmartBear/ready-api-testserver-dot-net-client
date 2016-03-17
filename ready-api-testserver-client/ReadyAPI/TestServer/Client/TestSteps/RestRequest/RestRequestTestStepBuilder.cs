namespace ReadyAPI.TestServer.Client.TestSteps.RestRequest
{
    public class RestRequestTestStepBuilder
    {
        public RestRequestBuilderNoBody Get(string uri)
        {
            return new RestRequestNoBody(uri, TestSteps.HttpMethod.GET);
        }
        
        public RestRequestBuilderWithBody Post(string uri)
        {
            return new RestRequestWithBody(uri, TestSteps.HttpMethod.POST);
        }

        public RestRequestBuilderWithBody Put(string uri)
        {
            return new RestRequestWithBody(uri, TestSteps.HttpMethod.PUT);
        }

        public RestRequestBuilderNoBody Delete(string uri)
        {
            return new RestRequestNoBody(uri, TestSteps.HttpMethod.DELETE);
        }
    }
}
