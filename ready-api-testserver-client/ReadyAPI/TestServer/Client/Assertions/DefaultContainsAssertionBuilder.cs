using IO.Swagger.Model;

namespace ReadyAPI.TestServer.Client.Assertions
{
    public class DefaultContainsAssertionBuilder : AbstractAssertionBuilder, ContainsAssertionBuilder 
    {
        protected SimpleContainsAssertion containsAssertion = new SimpleContainsAssertion();

        public DefaultContainsAssertionBuilder(string token)
        {
            containsAssertion.Token = token;
        }

        public ContainsAssertionBuilder UseRegEx()
        {
            containsAssertion.UseRegexp = true;
            return this;
        }

        public ContainsAssertionBuilder IgnoreCase()
        {
            containsAssertion.IgnoreCase = true;
            return this;
        }

        public override Assertion Build()
        {
            Validator.ValidateNotEmpty(containsAssertion.Token, "Missing token, it's a mandatory parameter for ContainsAssertion");
            containsAssertion.Type = "Contains";
            return containsAssertion;
        }
    }
}
