namespace ReadyAPI.TestServer.Client.TestSteps.DataSource
{
    public class DataSources
    {
        public static ExcelDataSourceBuilder Excel()
        {
            return new ExcelDataSourceBuilder();
        }

        public static GridDataSourceBuilder Grid()
        {
            return new GridDataSourceBuilder();
        }

        public static FileDataSourceBuilder File()
        {
            return new FileDataSourceBuilder();
        }
    }
}
