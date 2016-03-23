using IO.Swagger.Model;
using System.Collections.Generic;

namespace ReadyAPI.TestServer.Client.TestSteps.DataSource
{
    public class ExcelDataSourceBuilder : IDataSourceBuilder
    {
        private ExcelDataSource _excelDataSource = new ExcelDataSource();
        private List<string> _properties = new List<string>();

        public ExcelDataSourceBuilder AddProperty(string propertyName)
        {
            _properties.Add(propertyName);
            return this;
        }

        public ExcelDataSourceBuilder WithFilePath(string filePath)
        {
            _excelDataSource.FilePath = filePath;
            return this;
        }

        public ExcelDataSourceBuilder WithWorksheet(string worksheet)
        {
            _excelDataSource.Worksheet = worksheet;
            return this;
        }

        public ExcelDataSourceBuilder StartAtCell(string cell)
        {
            _excelDataSource.StartAtCell = cell;
            return this;
        }

        public ExcelDataSourceBuilder IgnoreEmpty()
        {
            _excelDataSource.IgnoreEmpty = true;
            return this;
        }

        public IO.Swagger.Model.DataSource Build()
        {
            IO.Swagger.Model.DataSource dataSource = new IO.Swagger.Model.DataSource();
            dataSource.Properties = _properties;
            dataSource.Excel = _excelDataSource;
            return dataSource;
        }
    }
}
