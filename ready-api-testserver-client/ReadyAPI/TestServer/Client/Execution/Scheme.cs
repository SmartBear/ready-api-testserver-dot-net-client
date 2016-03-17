namespace ReadyAPI.TestServer.Client.Execution
{
    public class Scheme
    {
        public static readonly string HTTP = "http";
        public static readonly string HTTPS = "https";

        private string value;

        public Scheme(string value)
        {
            this.value = value;
        }

        public string getValue()
        {
            return value;
        }
    }
}
