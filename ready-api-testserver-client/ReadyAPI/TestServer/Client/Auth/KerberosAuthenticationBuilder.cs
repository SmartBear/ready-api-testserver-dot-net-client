using IO.Swagger.Model;

namespace ReadyAPI.TestServer.Client.Auth
{
    public class KerberosAuthenticationBuilder : NTLMAuthenticationBuilder
    {
        public KerberosAuthenticationBuilder(string username, string password): base (username, password)
        {}

        public override Authentication Build()
        {
            Validator.ValidateNotEmpty(_authentication.Username, "Missing username, it's a required parameter for SPNEGO/Kerberos Auth.");
            Validator.ValidateNotEmpty(_authentication.Password, "Missing password, it's a required parameter for SPNEGO/Kerberos Auth.");
            _authentication.Type = "SPNEGO/Kerberos";
            return _authentication as Authentication;
        }
    }
}
