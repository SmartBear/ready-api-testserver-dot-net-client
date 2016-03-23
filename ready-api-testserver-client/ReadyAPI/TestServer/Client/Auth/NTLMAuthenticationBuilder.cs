using IO.Swagger.Model;

namespace ReadyAPI.TestServer.Client.Auth
{
    public class NTLMAuthenticationBuilder : BasicAuthenticationBuilder, IAuthenticationBuilderWithDomain
    {
        public NTLMAuthenticationBuilder(string username, string password): base(username, password)
        {}

        public IAuthenticationBuilderWithDomain SetDomain(string domain)
        {
            _authentication.Domain = domain;
            return this;
        }

        public override Authentication Build()
        {
            Validator.ValidateNotEmpty(_authentication.Username, "Missing username, it's a required parameter for NTLM Auth.");
            Validator.ValidateNotEmpty(_authentication.Password, "Missing password, it's a required parameter for NTLM Auth.");
            _authentication.Type = "NTLM";
            return _authentication;
        }
    }
}
