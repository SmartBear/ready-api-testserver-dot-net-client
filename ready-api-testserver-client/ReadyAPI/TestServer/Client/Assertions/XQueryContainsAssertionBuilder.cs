using IO.Swagger.Model;

namespace ReadyAPI.TestServer.Client.Assertions
{
    public class XQueryContainsAssertionBuilder : AbstractAssertionBuilder, IXQueryAssertionBuilder 
    {
        private XQueryContainsAssertion xQueryContainsAssertion = new XQueryContainsAssertion();

        public XQueryContainsAssertionBuilder(string xQuery, string expectedContent)
        {
            xQueryContainsAssertion.Xquery = xQuery;
            xQueryContainsAssertion.ExpectedContent = expectedContent;
        }

        public IXQueryAssertionBuilder AllowWildcards()//TODO: XQueryContainsAssertionBuilder
        {
            xQueryContainsAssertion.AllowWildcards = true;
            return this;
        }

        public override Assertion Build()
        {
            Validator.ValidateNotEmpty(xQueryContainsAssertion.Xquery, "Missing XQuery, it's a mandatory parameter for XQueryContainsAssertion");
            Validator.ValidateNotEmpty(xQueryContainsAssertion.ExpectedContent, "Missing expected content, it's a mandatory parameter for XQueryContainsAssertion");
            xQueryContainsAssertion.Type = "XQuery Match";
            return xQueryContainsAssertion;
        }

    }
}
