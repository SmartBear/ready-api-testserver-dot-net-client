using IO.Swagger.Model;

namespace ReadyAPI.TestServer.Client.Assertions
{
    public class DefaultResponseSLAAssertionBuilder: AbstractAssertionBuilder
    {
        private ResponseSLAAssertion _responseSLAAssertion = new ResponseSLAAssertion();

        public DefaultResponseSLAAssertionBuilder(int maxResponseTime)
        {
            _responseSLAAssertion.MaxResponseTime = maxResponseTime;
        }

        public override Assertion Build()
        {
            Validator.ValidateNotEmpty(_responseSLAAssertion.MaxResponseTime, "Missing max response time, it's a mandatory parameter for ResponseSLAAssertion");
            _responseSLAAssertion.Type = "Response SLA";
            return _responseSLAAssertion;
        }
    }
}
