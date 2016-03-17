using System.Collections.Generic;

namespace ReadyAPI.TestServer.Client.TestSteps.DataSource
{
    public class GridDataSourceTestStepBuilder : DataSourceTestStepBuilder<GridDataSourceBuilder> 
    {
        public GridDataSourceTestStepBuilder()
        {
            AddDataSource(new GridDataSourceBuilder());
        }

        public GridDataSourceTestStepBuilder AddProperty(string property, List<string> propertyValues)
        {
            GetDataSourceBuilder().AddProperty(property, propertyValues);
            return this;
        }
    }
}
