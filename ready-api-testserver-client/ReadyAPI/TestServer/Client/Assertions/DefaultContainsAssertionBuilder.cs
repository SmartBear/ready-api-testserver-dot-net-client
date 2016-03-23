using IO.Swagger.Model;

namespace ReadyAPI.TestServer.Client.Assertions
{
    public class DefaultContainsAssertionBuilder : AbstractAssertionBuilder, IContainsAssertionBuilder 
    {
        protected SimpleContainsAssertion _containsAssertion = new SimpleContainsAssertion();

        public DefaultContainsAssertionBuilder(string token)
        {
            _containsAssertion.Token = token;
        }

        public IContainsAssertionBuilder UseRegEx()
        {
            _containsAssertion.UseRegexp = true;
            return this;
        }

        public IContainsAssertionBuilder IgnoreCase()
        {
            _containsAssertion.IgnoreCase = true;
            return this;
        }

        public override Assertion Build()
        {
            Validator.ValidateNotEmpty(_containsAssertion.Token, "Missing token, it's a mandatory parameter for ContainsAssertion");
            _containsAssertion.Type = "Contains";
            return _containsAssertion;
        }
    }
}
