using IO.Swagger.Model;
using System.Collections.Generic;

namespace ReadyAPI.TestServer.Client.Assertions
{
    public class ValidHttpStatusCodesAssertionBuilder : AbstractAssertionBuilder, IHttpStatusCodeAssertionBuilder
    {
        protected List<int?> _statusCodes = new List<int?>();

        public IHttpStatusCodeAssertionBuilder AddStatusCode(int statusCode)
        {
            _statusCodes.Add(statusCode);
            return this;
        }

        public IHttpStatusCodeAssertionBuilder AddStatusCodes(params int[] statusCodes)
        {
            foreach (int? value in statusCodes)
            {
                this._statusCodes.Add(value);
            }
            return this;
        }

        public override Assertion Build()
        {
            Validator.ValidateNotEmpty(_statusCodes, "Missing status codes. Status codes are mandatory for ValidHttpStatusCodesAssertion");
            ValidHttpStatusCodesAssertion statusCodesAssertion = new ValidHttpStatusCodesAssertion();
            statusCodesAssertion.Type = "Valid HTTP Status Codes";
            statusCodesAssertion.ValidStatusCodes = _statusCodes;
            return statusCodesAssertion;
        }
    }
}
