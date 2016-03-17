namespace ReadyAPI.TestServer.Client.TestSteps
{
    public class TestStepTypes
    {
        public static readonly string REST_REQUEST = "REST Request";
        public static readonly string PROPERTY_TRANSFER = "Property Transfer";
        public static readonly string DATA_SOURCE = "DataSource";
        public static readonly string GROOVY_SCRIPT = "Groovy";
        public static readonly string JDBC_REQUEST = "JDBC Request";

        private string type;

        public TestStepTypes(string type)
        {
            this.type = type;
        }

        public override string ToString()
        {
            return type;
        }
    }
}
