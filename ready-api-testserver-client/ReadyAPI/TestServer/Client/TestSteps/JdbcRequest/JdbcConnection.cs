using System;

namespace ReadyAPI.TestServer.Client.TestSteps.JdbcRequest
{
    public class JdbcConnection
    {
        private readonly string _driver;
        private readonly string _connectionString;

        public JdbcConnection(string driver, string connectionString)
        {
            if (driver == null)
            {
                throw new NullReferenceException("Driver class name required");
            }
            if (connectionString == null)
            {
                throw new NullReferenceException("Connection string required");
            }

            this._driver = driver;
            this._connectionString = connectionString;
        }

        public JdbcRequestTestStepBuilder JdbcRequest(string sql)
        {
            return new JdbcRequestTestStepBuilder(_driver, _connectionString, false).WithSql(sql);
        }

        public JdbcRequestTestStepBuilder StoredProcedureCall(string sql)
        {
            return new JdbcRequestTestStepBuilder(_driver, _connectionString, true).WithSql(sql);
        }
    }
}
