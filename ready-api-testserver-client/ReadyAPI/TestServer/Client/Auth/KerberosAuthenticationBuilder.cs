using IO.Swagger.Model;

namespace ReadyAPI.TestServer.Client.Auth
{
    public class KerberosAuthenticationBuilder : NTLMAuthenticationBuilder
    {
        public KerberosAuthenticationBuilder(string username, string password): base (username, password)
        {}

        public override Authentication Build()
        {
            Validator.ValidateNotEmpty(authentication.Username, "Missing username, it's a required parameter for SPNEGO/Kerberos Auth.");
            Validator.ValidateNotEmpty(authentication.Password, "Missing password, it's a required parameter for SPNEGO/Kerberos Auth.");
            authentication.Type = "SPNEGO/Kerberos";
            return authentication as Authentication;
        }
    }
}
