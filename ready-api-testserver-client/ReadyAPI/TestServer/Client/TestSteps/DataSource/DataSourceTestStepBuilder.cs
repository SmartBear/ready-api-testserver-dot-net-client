using IO.Swagger.Model;
using System.Collections.Generic;

namespace ReadyAPI.TestServer.Client.TestSteps.DataSource
{
    public class DataSourceTestStepBuilder<TDataSourceBuilderType> : ITestStepBuilder where TDataSourceBuilderType : IDataSourceBuilder
    {
        private DataSourceTestStep testStep = new DataSourceTestStep();
        private TDataSourceBuilderType dataSourceBuilder;
        private List<TestStep> nestedTestSteps = new List<TestStep>();
        public DataSourceTestStepBuilder<TDataSourceBuilderType> Named(string name)
        {
            testStep.Name = name;
            return this;
        }

        public DataSourceTestStepBuilder<TDataSourceBuilderType> AddDataSource(TDataSourceBuilderType dataSourceBuilder)
        {
            this.dataSourceBuilder = dataSourceBuilder;
            return this;
        }

        protected TDataSourceBuilderType GetDataSourceBuilder()
        {
            return dataSourceBuilder;
        }

        public DataSourceTestStepBuilder<TDataSourceBuilderType> AddTestStep(ITestStepBuilder testStepBuilder)
        {
            this.nestedTestSteps.Add(testStepBuilder.Build());
            return this;
        }

        public TestStep Build()
        {
            testStep.Type = new TestStepTypes(TestStepTypes.DATA_SOURCE).ToString();
            testStep.DataSource = dataSourceBuilder.Build();
            testStep.TestSteps = nestedTestSteps;
            return testStep;
        }
    }
}
