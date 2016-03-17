using System;

namespace ReadyAPI.TestServer.Client.TestSteps.JdbcRequest
{
    public class JdbcConnection
    {
        private readonly string driver;
        private readonly string connectionString;

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

            this.driver = driver;
            this.connectionString = connectionString;
        }

        public JdbcRequestTestStepBuilder JdbcRequest(string sql)
        {
            return new JdbcRequestTestStepBuilder(driver, connectionString, false).WithSql(sql);
        }

        public JdbcRequestTestStepBuilder StoredProcedureCall(string sql)
        {
            return new JdbcRequestTestStepBuilder(driver, connectionString, true).WithSql(sql);
        }
    }
}
