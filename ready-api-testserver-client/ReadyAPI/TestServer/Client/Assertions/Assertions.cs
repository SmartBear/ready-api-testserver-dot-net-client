using IO.Swagger.Model;

namespace ReadyAPI.TestServer.Client.Assertions
{
    public class Assertions <T> where T : Assertion
    {
        public static JsonPathAssertionBuilder JsonPathContent(string jsonPath, string expectedContent)
        {
            return (JsonPathAssertionBuilder)new JsonPathContentAssertionBuilder(jsonPath, expectedContent);
        }

        public static JsonPathAssertionBuilder JsonPathCount(string jsonPath, int expectedCount)
        {
            return (JsonPathAssertionBuilder)(new JsonPathCountAssertionBuilder(jsonPath, expectedCount));
        }

        public static ContainsAssertionBuilder Contains(string token)
        {
            return new DefaultContainsAssertionBuilder(token);
        }

        public static ContainsAssertionBuilder NotContains(string token)
        {
            return new NotContainsAssertionBuilder(token);
        }

        public static AssertionBuilder Script(string script)
        {
            return (AssertionBuilder)new DefaultGroovyScriptAssertionBuilder(script);
        }

        public static HttpStatusCodeAssertionBuilder ValidStatusCodes(params int[] statusCodes)
        {
            ValidHttpStatusCodesAssertionBuilder validHttpStatusCodesAssertionBuilder = new ValidHttpStatusCodesAssertionBuilder();
            return validHttpStatusCodesAssertionBuilder.AddStatusCodes(statusCodes);
        }

        public static InvalidHttpStatusCodesAssertionBuilder InvalidStatusCodes(params int[] statusCodes)
        {
            InvalidHttpStatusCodesAssertionBuilder invalidHttpStatusCodesAssertionBuilder = new InvalidHttpStatusCodesAssertionBuilder();
            invalidHttpStatusCodesAssertionBuilder.AddStatusCodes(statusCodes);
            return invalidHttpStatusCodesAssertionBuilder;
        }

        public static XPathAssertionBuilder XPathContains(string xPath, string expectedContent)
        {
            return new XPathContainsAssertionBuilder(xPath, expectedContent);
        }

        public static XQueryAssertionBuilder XQueryContains(string xQuery, string expectedContent)
        {
            return new XQueryContainsAssertionBuilder(xQuery, expectedContent);
        }

        public static AssertionBuilder ResponseSLA(int maxResponseTime)
        {
            return (AssertionBuilder)new DefaultResponseSLAAssertionBuilder(maxResponseTime);
        }

        public static AssertionBuilder JdbcRequestTimeout(long timeout)
        {
            return (AssertionBuilder)new JdbcTimeoutAssertionBuilder(timeout);
        }

        /**
         * This makes it possible to provide a property expansion that gives the timeout
         * @param timeout a String that should expand to a numeric
         * @return a builder that will construct the JDBC Timeout assertion
         */

        public static AssertionBuilder JdbcRequestTimeout(string timeout)
        {
            return (AssertionBuilder)new JdbcTimeoutAssertionBuilder(timeout);
        }

        public static AssertionBuilder JdbcRequestStatusOk()
        {
            return (AssertionBuilder)new JdbcStatusAssertionBuilder();
        }
    }
}
