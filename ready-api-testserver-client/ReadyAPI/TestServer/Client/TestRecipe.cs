using IO.Swagger.Model;
using Newtonsoft.Json;

namespace ReadyAPI.TestServer.Client
{
    public class TestRecipe
    {
        public TestCase TestCase { get; private set;}

        public TestRecipe(TestCase testCase)
        {
            this.TestCase = testCase;
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(TestCase);
        }
    }
}
