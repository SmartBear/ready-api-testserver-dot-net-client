using IO.Swagger.Model;

namespace ReadyAPI.TestServer.Client.Auth
{
    public interface IAbstractAuthenticationBuilder : IAuthenticationBuilder
    {
        Authentication Build();
    }
}
