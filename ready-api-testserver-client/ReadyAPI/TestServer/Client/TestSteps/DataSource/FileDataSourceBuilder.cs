using IO.Swagger.Model;
using System.Collections.Generic;

namespace ReadyAPI.TestServer.Client.TestSteps.DataSource
{
    public class FileDataSourceBuilder : DataSourceBuilder
    {
        private FileDataSource fileDataSource = new FileDataSource();
        private List<string> properties = new List<string>();

        public FileDataSourceBuilder AddProperty(string propertyName)
        {
            properties.Add(propertyName);
            return this;
        }

        public FileDataSourceBuilder WithFilePath(string filePath)
        {
            fileDataSource.FilePath = filePath;
            return this;
        }

        public FileDataSourceBuilder WithCharSet(string charSet)
        {
            fileDataSource.Charset = charSet;
            return this;
        }

        public FileDataSourceBuilder WithSeparator(string separator)
        {
            fileDataSource.Separator = separator;
            return this;
        }

        public FileDataSourceBuilder Trim()
        {
            fileDataSource.Trim = true;
            return this;
        }

        public FileDataSourceBuilder QuotedValues()
        {
            fileDataSource.QuotedValues = true;
            return this;
        }

        public IO.Swagger.Model.DataSource Build()
        {
            IO.Swagger.Model.DataSource dataSource = new IO.Swagger.Model.DataSource();
            dataSource.Properties = properties;
            dataSource.File = fileDataSource;
            return dataSource;
        }
    }
}
