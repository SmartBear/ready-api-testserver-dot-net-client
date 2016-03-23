namespace ReadyAPI.TestServer.Client.TestSteps.RestRequest
{
    public class RestRequestTestStepBuilder
    {
        public IRestRequestBuilderNoBody Get(string uri)
        {
            return new RestRequestNoBody(uri, TestSteps.HttpMethod.GET);
        }
        
        public IRestRequestBuilderWithBody Post(string uri)
        {
            return new RestRequestWithBody(uri, TestSteps.HttpMethod.POST);
        }

        public IRestRequestBuilderWithBody Put(string uri)
        {
            return new RestRequestWithBody(uri, TestSteps.HttpMethod.PUT);
        }

        public IRestRequestBuilderNoBody Delete(string uri)
        {
            return new RestRequestNoBody(uri, TestSteps.HttpMethod.DELETE);
        }
    }
}
