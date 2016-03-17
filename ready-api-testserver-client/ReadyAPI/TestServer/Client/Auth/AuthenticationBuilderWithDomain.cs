namespace ReadyAPI.TestServer.Client.Auth
{ 
    public interface AuthenticationBuilderWithDomain : AuthenticationBuilder
    {
        AuthenticationBuilderWithDomain SetDomain(string domain);
    }
}
