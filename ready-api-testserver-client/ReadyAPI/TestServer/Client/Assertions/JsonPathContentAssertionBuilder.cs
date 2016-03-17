using System;
using IO.Swagger.Model;

namespace ReadyAPI.TestServer.Client.Assertions
{
    public class JsonPathContentAssertionBuilder : AbstractAssertionBuilder, JsonPathAssertionBuilder
    {
        private JsonPathContentAssertion jsonPathContentAssertion = new JsonPathContentAssertion();

        public JsonPathContentAssertionBuilder(String jsonPath, String expectedContent)
        {
            jsonPathContentAssertion.JsonPath = jsonPath;
            jsonPathContentAssertion.ExpectedContent = expectedContent;
        }

        public JsonPathAssertionBuilder AllowWildcards()
        {
            jsonPathContentAssertion.AllowWildcards = true;
            return this as JsonPathAssertionBuilder;
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
