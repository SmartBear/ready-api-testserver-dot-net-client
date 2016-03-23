namespace ReadyAPI.TestServer.Client.Auth
{ 
    public interface IAuthenticationBuilderWithDomain : IAuthenticationBuilder
    {
        IAuthenticationBuilderWithDomain SetDomain(string domain);
    }
}
