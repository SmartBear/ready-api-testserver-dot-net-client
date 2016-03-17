using IO.Swagger.Model;

namespace ReadyAPI.TestServer.Client.Assertions
{
    public class DefaultResponseSLAAssertionBuilder: AbstractAssertionBuilder
    {
        private ResponseSLAAssertion responseSLAAssertion = new ResponseSLAAssertion();

        public DefaultResponseSLAAssertionBuilder(int maxResponseTime)
        {
            responseSLAAssertion.MaxResponseTime = maxResponseTime;
        }

        public override Assertion Build()
        {
            Validator.ValidateNotEmpty(responseSLAAssertion.MaxResponseTime, "Missing max response time, it's a mandatory parameter for ResponseSLAAssertion");
            responseSLAAssertion.Type = "Response SLA";
            return responseSLAAssertion;
        }
    }
}
