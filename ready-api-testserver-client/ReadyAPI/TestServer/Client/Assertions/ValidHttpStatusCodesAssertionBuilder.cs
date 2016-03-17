using IO.Swagger.Model;
using System.Collections.Generic;

namespace ReadyAPI.TestServer.Client.Assertions
{
    public class ValidHttpStatusCodesAssertionBuilder : AbstractAssertionBuilder, HttpStatusCodeAssertionBuilder
    {
        protected List<int?> statusCodes = new List<int?>();

        public HttpStatusCodeAssertionBuilder AddStatusCode(int statusCode)
        {
            statusCodes.Add(statusCode);
            return this;
        }

        public HttpStatusCodeAssertionBuilder AddStatusCodes(params int[] statusCodes)
        {
            foreach (int? value in statusCodes)
            {
                this.statusCodes.Add(value);
            }
            return this;
        }

        public override Assertion Build()
        {
            Validator.ValidateNotEmpty(statusCodes, "Missing status codes. Status codes are mandatory for ValidHttpStatusCodesAssertion");
            ValidHttpStatusCodesAssertion statusCodesAssertion = new ValidHttpStatusCodesAssertion();
            statusCodesAssertion.Type = "Valid HTTP Status Codes";
            statusCodesAssertion.ValidStatusCodes = statusCodes;
            return statusCodesAssertion;
        }
    }
}
