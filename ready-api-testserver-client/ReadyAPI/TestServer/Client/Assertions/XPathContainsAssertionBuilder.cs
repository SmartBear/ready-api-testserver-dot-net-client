using IO.Swagger.Model;

namespace ReadyAPI.TestServer.Client.Assertions
{
    public class XPathContainsAssertionBuilder : AbstractAssertionBuilder, IXPathAssertionBuilder 
    {
        private XPathContainsAssertion xPathContainsAssertion = new XPathContainsAssertion();

        public XPathContainsAssertionBuilder(string xPath, string expectedContent)
        {
            xPathContainsAssertion.Xpath = xPath;
            xPathContainsAssertion.ExpectedContent = expectedContent;
        }

        public IXPathAssertionBuilder AllowWildCards()//TODO: it should be XPathContainsAssertionBuilder
        {
            xPathContainsAssertion.AllowWildcards = true;
            return this;
        }

        public IXPathAssertionBuilder IgnoreComments()//TODO: it should be XPathContainsAssertionBuilder
        {
            xPathContainsAssertion.IgnoreComments = true;
            return this;
        }

        public XPathContainsAssertionBuilder IgnoreNamespaces()
        {
            xPathContainsAssertion.IgnoreNamespaces = true;
            return this;
        }

        public override Assertion Build()
        {
            Validator.ValidateNotEmpty(xPathContainsAssertion.Xpath, "Missing Xpath, it's a mandatory parameter for XPathContainsAssertion");
            Validator.ValidateNotEmpty(xPathContainsAssertion.ExpectedContent, "Missing expected content, it's a mandatory parameter for XPathContainsAssertion");
            xPathContainsAssertion.Type = "XPath Match";
            return xPathContainsAssertion;
        }
    }
}
