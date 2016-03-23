using IO.Swagger.Model;

namespace ReadyAPI.TestServer.Client.Assertions
{
    public class DefaultContainsAssertionBuilder : AbstractAssertionBuilder, IContainsAssertionBuilder 
    {
        protected SimpleContainsAssertion containsAssertion = new SimpleContainsAssertion();

        public DefaultContainsAssertionBuilder(string token)
        {
            containsAssertion.Token = token;
        }

        public IContainsAssertionBuilder UseRegEx()
        {
            containsAssertion.UseRegexp = true;
            return this;
        }

        public IContainsAssertionBuilder IgnoreCase()
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
