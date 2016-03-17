using ReadyAPI.TestServer.Client.TestSteps.DataSource;

namespace ReadyAPI.TestServer.Client.TestSteps
{
    public class ExcelDataSourceTestStepBuilder : ReadyAPI.TestServer.Client.TestSteps.DataSource.DataSourceTestStepBuilder<ExcelDataSourceBuilder>
    {
        public ExcelDataSourceTestStepBuilder()
        {
            AddDataSource(new ExcelDataSourceBuilder());
        }

        public ExcelDataSourceTestStepBuilder AddProperty(string propertyName)
        {
            GetDataSourceBuilder().AddProperty(propertyName);
            return this;
        }

        public ExcelDataSourceTestStepBuilder StartAtCell(string cell)
        {
            GetDataSourceBuilder().StartAtCell(cell);
            return this;
        }

        public ExcelDataSourceTestStepBuilder WithWorksheet(string worksheet)
        {
            GetDataSourceBuilder().WithWorksheet(worksheet);
            return this;
        }

        public ExcelDataSourceTestStepBuilder WithFilePath(string filePath)
        {
            GetDataSourceBuilder().WithFilePath(filePath);
            return this;
        }

        public ExcelDataSourceTestStepBuilder IgnoreEmpty()
        {
            GetDataSourceBuilder().IgnoreEmpty();
            return this;
        }
    }
}