using System;
using IO.Swagger.Model;

namespace ReadyAPI.TestServer.Client.Assertions
{
    public class JdbcTimeoutAssertionBuilder : AbstractAssertionBuilder
    {
        private object _timeout;

        public JdbcTimeoutAssertionBuilder(long timeout)
        {
            this._timeout = timeout;
        }

        public JdbcTimeoutAssertionBuilder(string timeout)
        {
            if (timeout == null)
            {
                throw new NullReferenceException("Timeout cannot be null value.");
            }
            this._timeout = timeout;
        }

        public override Assertion Build()
        {
            int iTimeout;
            Int32.TryParse((string)_timeout, out iTimeout);
            JdbcTimeoutAssertionStruct timeoutAssertion = new JdbcTimeoutAssertionStruct();
            //timeoutAssertion.Timeout = iTimeout;
            timeoutAssertion.Type = "JDBC Timeout";
            return timeoutAssertion;
        }
    }
}
