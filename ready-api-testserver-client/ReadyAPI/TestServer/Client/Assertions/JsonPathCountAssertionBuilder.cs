using IO.Swagger.Model;

namespace ReadyAPI.TestServer.Client.Assertions
{
    public class JsonPathCountAssertionBuilder : AbstractAssertionBuilder, JsonPathAssertionBuilder
    {
        private JsonPathCountAssertion jsonPathCountAssertion = new JsonPathCountAssertion();

        public JsonPathCountAssertionBuilder(string jsonPath, int expectedCount)
        {
            jsonPathCountAssertion.JsonPath = jsonPath;
            jsonPathCountAssertion.ExpectedCount = expectedCount;
        }

        public JsonPathAssertionBuilder AllowWildcards()
        {
            jsonPathCountAssertion.AllowWildcards = true;
            return this;
        }

        public override Assertion Build()
        {
            Validator.ValidateNotEmpty(jsonPathCountAssertion.JsonPath, "Missing JSON path, it's a mandatory parameter for JsonPathCountAssertion");
            Validator.ValidateNotEmpty(jsonPathCountAssertion.ExpectedCount, "Missing expected count, it's a mandatory parameter for JsonPathCountAssertion");
            jsonPathCountAssertion.Type = "JsonPath Count";
            return jsonPathCountAssertion;
        }
    }
}
