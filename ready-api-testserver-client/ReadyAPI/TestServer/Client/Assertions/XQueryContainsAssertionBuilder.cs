using IO.Swagger.Model;

namespace ReadyAPI.TestServer.Client.Assertions
{
    public class XQueryContainsAssertionBuilder : AbstractAssertionBuilder, IXQueryAssertionBuilder 
    {
        private XQueryContainsAssertion _xQueryContainsAssertion = new XQueryContainsAssertion();

        public XQueryContainsAssertionBuilder(string xQuery, string expectedContent)
        {
            _xQueryContainsAssertion.Xquery = xQuery;
            _xQueryContainsAssertion.ExpectedContent = expectedContent;
        }

        public IXQueryAssertionBuilder AllowWildcards()//TODO: XQueryContainsAssertionBuilder
        {
            _xQueryContainsAssertion.AllowWildcards = true;
            return this;
        }

        public override Assertion Build()
        {
            Validator.ValidateNotEmpty(_xQueryContainsAssertion.Xquery, "Missing XQuery, it's a mandatory parameter for XQueryContainsAssertion");
            Validator.ValidateNotEmpty(_xQueryContainsAssertion.ExpectedContent, "Missing expected content, it's a mandatory parameter for XQueryContainsAssertion");
            _xQueryContainsAssertion.Type = "XQuery Match";
            return _xQueryContainsAssertion;
        }

    }
}
