using IO.Swagger.Model;

namespace ReadyAPI.TestServer.Client.Assertions
{
    public class JsonPathContentAssertionBuilder : AbstractAssertionBuilder, IJsonPathAssertionBuilder
    {
        private JsonPathContentAssertion _jsonPathContentAssertion = new JsonPathContentAssertion();

        public JsonPathContentAssertionBuilder(string jsonPath, string expectedContent)
        {
            _jsonPathContentAssertion.JsonPath = jsonPath;
            _jsonPathContentAssertion.ExpectedContent = expectedContent;
        }

        public IJsonPathAssertionBuilder AllowWildcards()
        {
            _jsonPathContentAssertion.AllowWildcards = true;
            return this as IJsonPathAssertionBuilder;
        }

        public override Assertion Build()
        {
            Validator.ValidateNotEmpty(_jsonPathContentAssertion.JsonPath, "Missing JSON path, it's a mandatory parameter for JsonPathContentAssertion");
            Validator.ValidateNotEmpty(_jsonPathContentAssertion.ExpectedContent, "Missing expected content, it's a mandatory parameter for JsonPathContentAssertion");
            _jsonPathContentAssertion.Type = "JsonPath Match";
            return _jsonPathContentAssertion;
        }
    }
}
