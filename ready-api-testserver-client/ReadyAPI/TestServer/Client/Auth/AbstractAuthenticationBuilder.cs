using IO.Swagger.Model;

namespace ReadyAPI.TestServer.Client.Auth
{
    public interface AbstractAuthenticationBuilder : AuthenticationBuilder
    {
        Authentication Build();
    }
}
