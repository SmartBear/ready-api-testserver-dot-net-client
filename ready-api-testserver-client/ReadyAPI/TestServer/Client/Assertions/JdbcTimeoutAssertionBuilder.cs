using System;
using IO.Swagger.Model;

namespace ReadyAPI.TestServer.Client.Assertions
{
    public class JdbcTimeoutAssertionBuilder : AbstractAssertionBuilder
    {
        private object timeout;

        public JdbcTimeoutAssertionBuilder(long timeout)
        {
            this.timeout = timeout;
        }

        public JdbcTimeoutAssertionBuilder(string timeout)
        {
            if (timeout == null)
            {
                throw new NullReferenceException("Timeout cannot be null value.");
            }
            this.timeout = timeout;
        }

        public override Assertion Build()
        {
            int iTimeout;
            Int32.TryParse((string)timeout, out iTimeout);
            JdbcTimeoutAssertionStruct timeoutAssertion = new JdbcTimeoutAssertionStruct();
            //timeoutAssertion.Timeout = iTimeout;
            timeoutAssertion.Type = "JDBC Timeout";
            return timeoutAssertion;
        }
    }
}
