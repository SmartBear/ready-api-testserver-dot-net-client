using IO.Swagger.Model;

namespace ReadyAPI.TestServer.Client.Assertions
{
    public class JsonPathCountAssertionBuilder : AbstractAssertionBuilder, IJsonPathAssertionBuilder
    {
        private JsonPathCountAssertion _jsonPathCountAssertion = new JsonPathCountAssertion();

        public JsonPathCountAssertionBuilder(string jsonPath, int expectedCount)
        {
            _jsonPathCountAssertion.JsonPath = jsonPath;
            _jsonPathCountAssertion.ExpectedCount = expectedCount;
        }

        public IJsonPathAssertionBuilder AllowWildcards()
        {
            _jsonPathCountAssertion.AllowWildcards = true;
            return this;
        }

        public override Assertion Build()
        {
            Validator.ValidateNotEmpty(_jsonPathCountAssertion.JsonPath, "Missing JSON path, it's a mandatory parameter for JsonPathCountAssertion");
            Validator.ValidateNotEmpty(_jsonPathCountAssertion.ExpectedCount, "Missing expected count, it's a mandatory parameter for JsonPathCountAssertion");
            _jsonPathCountAssertion.Type = "JsonPath Count";
            return _jsonPathCountAssertion;
        }
    }
}
