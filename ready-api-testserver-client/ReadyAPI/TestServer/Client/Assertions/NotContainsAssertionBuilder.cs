using IO.Swagger.Model;

namespace ReadyAPI.TestServer.Client.Assertions
{
    public class NotContainsAssertionBuilder : DefaultContainsAssertionBuilder
    {
        public NotContainsAssertionBuilder(string token) : base(token){}

        public override Assertion Build()
        {
            Validator.ValidateNotEmpty(containsAssertion.Token, "Missing token, it's a mandatory parameter for NotContainsAssertion");
            containsAssertion.Type = "Not Contains";
            return containsAssertion;
        }
    }
}
