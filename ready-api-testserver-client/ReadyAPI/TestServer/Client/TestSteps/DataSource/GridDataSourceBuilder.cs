using System.Collections.Generic;

namespace ReadyAPI.TestServer.Client.TestSteps.DataSource
{
    public class GridDataSourceBuilder : IDataSourceBuilder
    {
        private Dictionary<string, List<string>> propertyValues = new Dictionary<string, List<string>>();

        public GridDataSourceBuilder AddProperty(string property, List<string> values)
        {
            propertyValues.Add(property, values);
            return this;
        }

        public IO.Swagger.Model.DataSource Build()
        {
            IO.Swagger.Model.DataSource dataSource = new IO.Swagger.Model.DataSource();
            dataSource.Grid = propertyValues;
            return dataSource;
        }
    }
}
