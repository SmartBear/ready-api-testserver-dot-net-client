﻿using IO.Swagger.Model;

namespace ReadyAPI.TestServer.Client.Assertions
{
    public class InvalidHttpStatusCodesAssertionBuilder : ValidHttpStatusCodesAssertionBuilder
    {
        public InvalidHttpStatusCodesAssertionBuilder() {}

        public override Assertion Build()
        {
            Validator.ValidateNotEmpty(_statusCodes, "Missing status codes. Status codes are mandatory for InvalidHttpStatusCodesAssertion");
            InvalidHttpStatusCodesAssertion invalidHttpStatusCodesAssertion = new InvalidHttpStatusCodesAssertion();
            invalidHttpStatusCodesAssertion.Type = "Invalid HTTP Status Codes";
            invalidHttpStatusCodesAssertion.InvalidStatusCodes = _statusCodes;
            return invalidHttpStatusCodesAssertion;
        }
    }
}
