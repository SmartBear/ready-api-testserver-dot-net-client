using IO.Swagger.Model;

namespace ReadyAPI.TestServer.Client.Assertions
{
    public class XPathContainsAssertionBuilder : AbstractAssertionBuilder, IXPathAssertionBuilder 
    {
        private XPathContainsAssertion _xPathContainsAssertion = new XPathContainsAssertion();

        public XPathContainsAssertionBuilder(string xPath, string expectedContent)
        {
            _xPathContainsAssertion.Xpath = xPath;
            _xPathContainsAssertion.ExpectedContent = expectedContent;
        }

        public IXPathAssertionBuilder AllowWildCards()//TODO: it should be XPathContainsAssertionBuilder
        {
            _xPathContainsAssertion.AllowWildcards = true;
            return this;
        }

        public IXPathAssertionBuilder IgnoreComments()//TODO: it should be XPathContainsAssertionBuilder
        {
            _xPathContainsAssertion.IgnoreComments = true;
            return this;
        }

        public XPathContainsAssertionBuilder IgnoreNamespaces()
        {
            _xPathContainsAssertion.IgnoreNamespaces = true;
            return this;
        }

        public override Assertion Build()
        {
            Validator.ValidateNotEmpty(_xPathContainsAssertion.Xpath, "Missing Xpath, it's a mandatory parameter for XPathContainsAssertion");
            Validator.ValidateNotEmpty(_xPathContainsAssertion.ExpectedContent, "Missing expected content, it's a mandatory parameter for XPathContainsAssertion");
            _xPathContainsAssertion.Type = "XPath Match";
            return _xPathContainsAssertion;
        }
    }
}
