using System;
using IO.Swagger.Model;

namespace ReadyAPI.TestServer.Client.Assertions
{
    public class XPathContainsAssertionBuilder: AbstractAssertionBuilder, XPathAssertionBuilder 
    {
        private XPathContainsAssertion xPathContainsAssertion = new XPathContainsAssertion();

        public XPathContainsAssertionBuilder(String xPath, String expectedContent)
        {
            xPathContainsAssertion.Xpath = xPath;
            xPathContainsAssertion.ExpectedContent = expectedContent;
        }

        public XPathAssertionBuilder AllowWildCards()//originally XPathContainsAssertionBuilder
        {
            xPathContainsAssertion.AllowWildcards = true;
            return this;
        }

        public XPathAssertionBuilder IgnoreComments()//originally XPathContainsAssertionBuilder
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
