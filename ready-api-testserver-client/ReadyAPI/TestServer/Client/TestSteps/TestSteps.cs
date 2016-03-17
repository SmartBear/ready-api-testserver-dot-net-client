using ReadyAPI.TestServer.Client.TestSteps.RestRequest;
using ReadyAPI.TestServer.Client.TestSteps.PropertyTransfer;
using ReadyAPI.TestServer.Client.TestSteps.JdbcRequest;
using ReadyAPI.TestServer.Client.TestSteps.GroovyScript;
using ReadyAPI.TestServer.Client.TestSteps.DataSource;

namespace ReadyAPI.TestServer.Client.TestSteps
{
    public class TestSteps
    {
        public enum HttpMethod { GET, POST, PUT, DELETE, HEAD, OPTIONS, TRACE, PATCH };

        public static RestRequestTestStepBuilder RestRequest()
        {
            return new RestRequestTestStepBuilder();
        }

        public static RestRequestBuilderNoBody GetRequest(string uri)
        {
            return new RestRequestTestStepBuilder().Get(uri);
        }

        public static RestRequestBuilderWithBody PostRequest(string uri)
        {
            return new RestRequestTestStepBuilder().Post(uri);
        }

        public static RestRequestBuilderWithBody PutRequest(string uri)
        {
            return new RestRequestTestStepBuilder().Put(uri);
        }

        public static RestRequestBuilderNoBody DeleteRequest(string uri)
        {
            return new RestRequestTestStepBuilder().Delete(uri);
        }

        public static PropertyTransferTestStepBuilder PropertyTransfer()
        {
            return new PropertyTransferTestStepBuilder();
        }

        public static DataSourceTestStepBuilder<T> DataSource<T>() where T : DataSourceBuilder
        {
            return new DataSourceTestStepBuilder<T>();
        }

        public static GridDataSourceTestStepBuilder GridDataSource()
        {
            return new GridDataSourceTestStepBuilder();
        }

        public static ExcelDataSourceTestStepBuilder ExcelDataSource()
        {
            return new ExcelDataSourceTestStepBuilder();
        }

        public static FileDataSourceTestStepBuilder FileDataSource()
        {
            return new FileDataSourceTestStepBuilder();
        }

        public static GridDataSourceTestStepBuilder FridDataSource(string name)
        {
            return (GridDataSourceTestStepBuilder) new GridDataSourceTestStepBuilder().Named(name);
        }

        public static ExcelDataSourceTestStepBuilder ExcelDataSource(string name)
        {
            return (ExcelDataSourceTestStepBuilder) new ExcelDataSourceTestStepBuilder().Named(name);
        }

        public static FileDataSourceTestStepBuilder FileDataSource(string name)
        {
            return (FileDataSourceTestStepBuilder) new FileDataSourceTestStepBuilder().Named(name);
        }
        
        public static GroovyScriptTestStepBuilder GroovyScriptStep(string scriptText)
        {
            return new GroovyScriptTestStepBuilder(scriptText);
        }

        public static JdbcConnection JdbcConnection(string driver, string connectionString)
        {
            return new JdbcConnection(driver, connectionString);
        }
    }
}
