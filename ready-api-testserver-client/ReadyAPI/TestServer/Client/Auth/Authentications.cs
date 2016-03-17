namespace ReadyAPI.TestServer.Client.Auth
{
    public class Authentications
    {
        public static AuthenticationBuilder Basic(string username, string password)
        {
            return new BasicAuthenticationBuilder(username, password);
        }

        public static AuthenticationBuilderWithDomain NTLM(string username, string password)
        {
            return new NTLMAuthenticationBuilder(username, password);
        }

        public static AuthenticationBuilderWithDomain Kerberos(string username, string password)
        {
            return new KerberosAuthenticationBuilder(username, password);
        }
    }
}
