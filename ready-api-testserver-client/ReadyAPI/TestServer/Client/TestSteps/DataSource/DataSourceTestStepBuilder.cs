using IO.Swagger.Model;
using System.Collections.Generic;

namespace ReadyAPI.TestServer.Client.TestSteps.DataSource
{
    public class DataSourceTestStepBuilder<TDataSourceBuilderType> : ITestStepBuilder where TDataSourceBuilderType : IDataSourceBuilder
    {
        private DataSourceTestStep _testStep = new DataSourceTestStep();
        private TDataSourceBuilderType _dataSourceBuilder;
        private List<TestStep> _nestedTestSteps = new List<TestStep>();
        public DataSourceTestStepBuilder<TDataSourceBuilderType> Named(string name)
        {
            _testStep.Name = name;
            return this;
        }

        public DataSourceTestStepBuilder<TDataSourceBuilderType> AddDataSource(TDataSourceBuilderType dataSourceBuilder)
        {
            this._dataSourceBuilder = dataSourceBuilder;
            return this;
        }

        protected TDataSourceBuilderType GetDataSourceBuilder()
        {
            return _dataSourceBuilder;
        }

        public DataSourceTestStepBuilder<TDataSourceBuilderType> AddTestStep(ITestStepBuilder testStepBuilder)
        {
            this._nestedTestSteps.Add(testStepBuilder.Build());
            return this;
        }

        public TestStep Build()
        {
            _testStep.Type = new TestStepTypes(TestStepTypes.DATA_SOURCE).ToString();
            _testStep.DataSource = _dataSourceBuilder.Build();
            _testStep.TestSteps = _nestedTestSteps;
            return _testStep;
        }
    }
}
