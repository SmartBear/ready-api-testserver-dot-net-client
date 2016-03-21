namespace ReadyAPI.TestServer.Client.Execution
{
    public class Scheme
    {
        private static readonly string HTTP_SCHEME = "http";
        private static readonly string HTTPS_SCHEME = "https";

        string value;

        private Scheme(string value)
        {
            this.value = value;
        }

        public string Value
        {
            get
            {
                return value;
            }
        }

        public static Scheme HTTP
        {
            get { return new Scheme(HTTP_SCHEME); }
            private set {}
        }

        public static Scheme HTTPS
        {
            get { return new Scheme(HTTPS_SCHEME); }
            private set {}
        }
    }
}
