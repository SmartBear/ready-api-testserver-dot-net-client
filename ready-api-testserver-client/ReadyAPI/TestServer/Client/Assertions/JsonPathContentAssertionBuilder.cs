using IO.Swagger.Model;

namespace ReadyAPI.TestServer.Client.Assertions
{
    public class JsonPathContentAssertionBuilder : AbstractAssertionBuilder, IJsonPathAssertionBuilder
    {
        private JsonPathContentAssertion jsonPathContentAssertion = new JsonPathContentAssertion();

        public JsonPathContentAssertionBuilder(string jsonPath, string expectedContent)
        {
            jsonPathContentAssertion.JsonPath = jsonPath;
            jsonPathContentAssertion.ExpectedContent = expectedContent;
        }

        public IJsonPathAssertionBuilder AllowWildcards()
        {
            jsonPathContentAssertion.AllowWildcards = true;
            return this as IJsonPathAssertionBuilder;
        }

        public override Assertion Build()
        {
            Validator.ValidateNotEmpty(jsonPathContentAssertion.JsonPath, "Missing JSON path, it's a mandatory parameter for JsonPathContentAssertion");
            Validator.ValidateNotEmpty(jsonPathContentAssertion.ExpectedContent, "Missing expected content, it's a mandatory parameter for JsonPathContentAssertion");
            jsonPathContentAssertion.Type = "JsonPath Match";
            return jsonPathContentAssertion;
        }
    }
}
