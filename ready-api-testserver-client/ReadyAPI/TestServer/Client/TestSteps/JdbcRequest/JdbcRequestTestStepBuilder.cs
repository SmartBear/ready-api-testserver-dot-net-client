using System;
using System.Collections.Generic;
using ReadyAPI.TestServer.Client.Assertions;
using IO.Swagger.Model;

namespace ReadyAPI.TestServer.Client.TestSteps.JdbcRequest
{
    public class JdbcRequestTestStepBuilder : TestStepBuilder
    {
        private readonly string driver;
        private readonly string connectionString;
        private readonly bool storedProcedure;
        private string sqlQuery;
        private List<AssertionBuilder> assertionBuilders = new List<AssertionBuilder>();
        private Dictionary<string, object> properties = new Dictionary<string, object>();
        private string name;

        public JdbcRequestTestStepBuilder(string driver, string connectionString, bool storedProcedure)
        {
            this.driver = driver;
            this.connectionString = connectionString;
            this.storedProcedure = storedProcedure;
        }

        public JdbcRequestTestStepBuilder WithSql(string sql)
        {
            this.sqlQuery = sql;
            return this;
        }

        public JdbcRequestTestStepBuilder Named(string name)
        {
            this.name = name;
            return this;
        }

        public JdbcRequestTestStepBuilder WithProperties(Dictionary<string, object> newProperties)
        {
            if (newProperties == null)
            {
                throw new NullReferenceException("Properties can't be null");
            }

            this.properties = newProperties;
            return this;
        }

        public JdbcRequestTestStepBuilder AddProperty(string propertyName, object value)
        {
            properties.Add(propertyName, value);
            return this;
        }

        public JdbcRequestTestStepBuilder AddAssertion(AssertionBuilder assertion)
        {
            assertionBuilders.Add(assertion);
            return this;
        }

        public TestStep Build()
        {
            JdbcRequestTestStepStruct testStep = new JdbcRequestTestStepStruct();
            testStep.Type = TestStepTypes.JDBC_REQUEST;
            testStep.Driver = driver;
            testStep.ConnectionString = connectionString;
            testStep.StoredProcedure = storedProcedure;
            testStep.SqlQuery = sqlQuery;
            testStep.Properties = properties;
            testStep.Name = name;
            SetAssertions(testStep);
            return testStep;
        }

        private void SetAssertions(JdbcRequestTestStepStruct testStep)
        {
            List<Assertion> assertions = new List<Assertion>();
            foreach (AssertionBuilder assertionBuilder in assertionBuilders)
            {
                assertions.Add(((AbstractAssertionBuilder)assertionBuilder).Build());
            }
            testStep.Assertions = assertions;
        }

        public JdbcRequestTestStepBuilder AssertTimeout(long timeout)
        {
            return AddAssertion(Assertions.Assertions.JdbcRequestTimeout(timeout));
        }

        public JdbcRequestTestStepBuilder AssertStatus()
        {
            return AddAssertion(Assertions.Assertions.JdbcRequestStatusOk());
        }
    }
}
