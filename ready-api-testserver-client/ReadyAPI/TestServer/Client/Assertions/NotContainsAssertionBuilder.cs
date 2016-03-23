using IO.Swagger.Model;

namespace ReadyAPI.TestServer.Client.Assertions
{
    public class NotContainsAssertionBuilder : DefaultContainsAssertionBuilder
    {
        public NotContainsAssertionBuilder(string token) : base(token){}

        public override Assertion Build()
        {
            Validator.ValidateNotEmpty(_containsAssertion.Token, "Missing token, it's a mandatory parameter for NotContainsAssertion");
            _containsAssertion.Type = "Not Contains";
            return _containsAssertion;
        }
    }
}
