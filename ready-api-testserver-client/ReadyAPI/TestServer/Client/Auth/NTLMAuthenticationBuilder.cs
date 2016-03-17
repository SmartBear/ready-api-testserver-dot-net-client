using IO.Swagger.Model;

namespace ReadyAPI.TestServer.Client.Auth
{
    public class NTLMAuthenticationBuilder : BasicAuthenticationBuilder, AuthenticationBuilderWithDomain
    {
        public NTLMAuthenticationBuilder(string username, string password): base(username, password)
        {}

        public AuthenticationBuilderWithDomain SetDomain(string domain)
        {
            authentication.Domain = domain;
            return this;
        }

        public override Authentication Build()
        {
            Validator.ValidateNotEmpty(authentication.Username, "Missing username, it's a required parameter for NTLM Auth.");
            Validator.ValidateNotEmpty(authentication.Password, "Missing password, it's a required parameter for NTLM Auth.");
            authentication.Type = "NTLM";
            return authentication;
        }
    }
}
