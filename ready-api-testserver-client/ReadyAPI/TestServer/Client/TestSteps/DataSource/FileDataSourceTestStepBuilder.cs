namespace ReadyAPI.TestServer.Client.TestSteps.DataSource
{
    public class FileDataSourceTestStepBuilder : DataSourceTestStepBuilder<FileDataSourceBuilder>
    {
        public FileDataSourceTestStepBuilder()
        {
            AddDataSource(new FileDataSourceBuilder());
        }

        public FileDataSourceTestStepBuilder AddProperty(string propertyName)
        {
            GetDataSourceBuilder().AddProperty(propertyName);
            return this;
        }

        public FileDataSourceTestStepBuilder Trim()
        {
            GetDataSourceBuilder().Trim();
            return this;
        }

        public FileDataSourceTestStepBuilder WithCharSet(string charSet)
        {
            GetDataSourceBuilder().WithCharSet(charSet);
            return this;
        }

        public FileDataSourceTestStepBuilder WithSeparator(string separator)
        {
            GetDataSourceBuilder().WithSeparator(separator);
            return this;
        }

        public FileDataSourceTestStepBuilder WithFilePath(string filePath)
        {
            GetDataSourceBuilder().WithFilePath(filePath);
            return this;
        }

        public FileDataSourceTestStepBuilder QuotedValues()
        {
            GetDataSourceBuilder().QuotedValues();
            return this;
        }
    }
}
