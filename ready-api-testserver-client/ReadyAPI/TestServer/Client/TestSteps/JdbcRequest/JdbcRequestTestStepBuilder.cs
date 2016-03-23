using System;
using System.Collections.Generic;
using ReadyAPI.TestServer.Client.Assertions;
using IO.Swagger.Model;

namespace ReadyAPI.TestServer.Client.TestSteps.JdbcRequest
{
    public class JdbcRequestTestStepBuilder : ITestStepBuilder
    {
        private readonly string _driver;
        private readonly string _connectionString;
        private readonly bool _storedProcedure;
        private string _sqlQuery;
        private List<IAssertionBuilder> _assertionBuilders = new List<IAssertionBuilder>();
        private Dictionary<string, object> _properties = new Dictionary<string, object>();
        private string _name;

        public JdbcRequestTestStepBuilder(string driver, string connectionString, bool storedProcedure)
        {
            this._driver = driver;
            this._connectionString = connectionString;
            this._storedProcedure = storedProcedure;
        }

        public JdbcRequestTestStepBuilder WithSql(string sql)
        {
            this._sqlQuery = sql;
            return this;
        }

        public JdbcRequestTestStepBuilder Named(string name)
        {
            this._name = name;
            return this;
        }

        public JdbcRequestTestStepBuilder WithProperties(Dictionary<string, object> newProperties)
        {
            if (newProperties == null)
            {
                throw new NullReferenceException("Properties can't be null");
            }

            this._properties = newProperties;
            return this;
        }

        public JdbcRequestTestStepBuilder AddProperty(string propertyName, object value)
        {
            _properties.Add(propertyName, value);
            return this;
        }

        public JdbcRequestTestStepBuilder AddAssertion(IAssertionBuilder assertion)
        {
            _assertionBuilders.Add(assertion);
            return this;
        }

        public TestStep Build()
        {
            JdbcRequestTestStepStruct testStep = new JdbcRequestTestStepStruct();
            testStep.Type = TestStepTypes.JDBC_REQUEST;
            testStep.Driver = _driver;
            testStep.ConnectionString = _connectionString;
            testStep.StoredProcedure = _storedProcedure;
            testStep.SqlQuery = _sqlQuery;
            testStep.Properties = _properties;
            testStep.Name = _name;
            SetAssertions(testStep);
            return testStep;
        }

        private void SetAssertions(JdbcRequestTestStepStruct testStep)
        {
            List<Assertion> assertions = new List<Assertion>();
            foreach (IAssertionBuilder assertionBuilder in _assertionBuilders)
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
