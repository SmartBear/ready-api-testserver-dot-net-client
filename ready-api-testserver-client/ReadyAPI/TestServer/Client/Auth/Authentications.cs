namespace ReadyAPI.TestServer.Client.Auth
{
    public class Authentications
    {
        public static IAuthenticationBuilder Basic(string username, string password)
        {
            return new BasicAuthenticationBuilder(username, password);
        }

        public static IAuthenticationBuilderWithDomain NTLM(string username, string password)
        {
            return new NTLMAuthenticationBuilder(username, password);
        }

        public static IAuthenticationBuilderWithDomain Kerberos(string username, string password)
        {
            return new KerberosAuthenticationBuilder(username, password);
        }
    }
}
