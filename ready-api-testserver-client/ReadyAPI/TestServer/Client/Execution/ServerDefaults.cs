namespace ReadyAPI.TestServer.Client.Execution
{
    /**
     * Holds constants with default server configuration for the Ready! API Runtime Service.
     */
    public class ServerDefaults
    {
        public static readonly string SERVICE_BASE_PATH = "/readyapi";

        public static readonly int DEFAULT_PORT = 8443;
        public static readonly Scheme DEFAULT_SCHEME = Scheme.HTTPS;

        public static readonly string VERSION_PREFIX = "/v1";
        private ServerDefaults(){}
    }
}
