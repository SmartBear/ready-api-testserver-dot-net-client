using IO.Swagger.Model;
using System.Collections.Generic;

namespace ReadyAPI.TestServer.Client.TestSteps.DataSource
{
    public class FileDataSourceBuilder : IDataSourceBuilder
    {
        private FileDataSource _fileDataSource = new FileDataSource();
        private List<string> _properties = new List<string>();

        public FileDataSourceBuilder AddProperty(string propertyName)
        {
            _properties.Add(propertyName);
            return this;
        }

        public FileDataSourceBuilder WithFilePath(string filePath)
        {
            _fileDataSource.FilePath = filePath;
            return this;
        }

        public FileDataSourceBuilder WithCharSet(string charSet)
        {
            _fileDataSource.Charset = charSet;
            return this;
        }

        public FileDataSourceBuilder WithSeparator(string separator)
        {
            _fileDataSource.Separator = separator;
            return this;
        }

        public FileDataSourceBuilder Trim()
        {
            _fileDataSource.Trim = true;
            return this;
        }

        public FileDataSourceBuilder QuotedValues()
        {
            _fileDataSource.QuotedValues = true;
            return this;
        }

        public IO.Swagger.Model.DataSource Build()
        {
            IO.Swagger.Model.DataSource dataSource = new IO.Swagger.Model.DataSource();
            dataSource.Properties = _properties;
            dataSource.File = _fileDataSource;
            return dataSource;
        }
    }
}
