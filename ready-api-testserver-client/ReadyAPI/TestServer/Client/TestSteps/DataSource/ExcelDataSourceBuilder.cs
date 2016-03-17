using IO.Swagger.Model;
using System.Collections.Generic;

namespace ReadyAPI.TestServer.Client.TestSteps.DataSource
{
    public class ExcelDataSourceBuilder : DataSourceBuilder
    {
        private ExcelDataSource excelDataSource = new ExcelDataSource();
        private List<string> properties = new List<string>();

        public ExcelDataSourceBuilder AddProperty(string propertyName)
        {
            properties.Add(propertyName);
            return this;
        }

        public ExcelDataSourceBuilder WithFilePath(string filePath)
        {
            excelDataSource.FilePath = filePath;
            return this;
        }

        public ExcelDataSourceBuilder WithWorksheet(string worksheet)
        {
            excelDataSource.Worksheet = worksheet;
            return this;
        }

        public ExcelDataSourceBuilder StartAtCell(string cell)
        {
            excelDataSource.StartAtCell = cell;
            return this;
        }

        public ExcelDataSourceBuilder IgnoreEmpty()
        {
            excelDataSource.IgnoreEmpty = true;
            return this;
        }

        public IO.Swagger.Model.DataSource Build()
        {
            IO.Swagger.Model.DataSource dataSource = new IO.Swagger.Model.DataSource();
            dataSource.Properties = properties;
            dataSource.Excel = excelDataSource;
            return dataSource;
        }
    }
}
