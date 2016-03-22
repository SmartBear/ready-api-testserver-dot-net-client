namespace ReadyAPI.TestServer.Client.Assertions
{
    public class Assertions
    {
        public static JsonPathContentAssertionBuilder JsonPathContent(string jsonPath, string expectedContent)
        {
            return new JsonPathContentAssertionBuilder(jsonPath, expectedContent);
        }

        public static JsonPathCountAssertionBuilder JsonPathCount(string jsonPath, int expectedCount)
        {
            return new JsonPathCountAssertionBuilder(jsonPath, expectedCount);
        }

        public static DefaultContainsAssertionBuilder Contains(string token)
        {
            return new DefaultContainsAssertionBuilder(token);
        }

        public static NotContainsAssertionBuilder NotContains(string token)
        {
            return new NotContainsAssertionBuilder(token);
        }

        public static DefaultGroovyScriptAssertionBuilder Script(string script)
        {
            return new DefaultGroovyScriptAssertionBuilder(script);
        }

        public static ValidHttpStatusCodesAssertionBuilder ValidStatusCodes(params int[] statusCodes)
        {
            ValidHttpStatusCodesAssertionBuilder validHttpStatusCodesAssertionBuilder = new ValidHttpStatusCodesAssertionBuilder();
            validHttpStatusCodesAssertionBuilder.AddStatusCodes(statusCodes);
            return validHttpStatusCodesAssertionBuilder;
        }

        public static InvalidHttpStatusCodesAssertionBuilder InvalidStatusCodes(params int[] statusCodes)
        {
            InvalidHttpStatusCodesAssertionBuilder invalidHttpStatusCodesAssertionBuilder = new InvalidHttpStatusCodesAssertionBuilder();
            invalidHttpStatusCodesAssertionBuilder.AddStatusCodes(statusCodes);
            return invalidHttpStatusCodesAssertionBuilder;
        }

        public static XPathContainsAssertionBuilder XPathContains(string xPath, string expectedContent)
        {
            return new XPathContainsAssertionBuilder(xPath, expectedContent);
        }

        public static XQueryAssertionBuilder XQueryContains(string xQuery, string expectedContent)
        {
            return new XQueryContainsAssertionBuilder(xQuery, expectedContent);
        }

        public static DefaultResponseSLAAssertionBuilder ResponseSLA(int maxResponseTime)
        {
            return new DefaultResponseSLAAssertionBuilder(maxResponseTime);
        }

        public static JdbcTimeoutAssertionBuilder JdbcRequestTimeout(long timeout)
        {
            return new JdbcTimeoutAssertionBuilder(timeout);
        }

        /**
         * This makes it possible to provide a property expansion that gives the timeout
         * @param timeout a String that should expand to a numeric
         * @return a builder that will construct the JDBC Timeout assertion
         */

        public static JdbcTimeoutAssertionBuilder JdbcRequestTimeout(string timeout)
        {
            return new JdbcTimeoutAssertionBuilder(timeout);
        }

        public static JdbcStatusAssertionBuilder JdbcRequestStatusOk()
        {
            return new JdbcStatusAssertionBuilder();
        }
    }
}
