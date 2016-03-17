using IO.Swagger.Model;

namespace ReadyAPI.TestServer.Client.Auth
{
    public class BasicAuthenticationBuilder : AbstractAuthenticationBuilder
    {
        protected Authentication authentication = new Authentication();

        public BasicAuthenticationBuilder(string username, string password)
        {
            authentication.Username = username;
            authentication.Password = password;
        }

        public virtual Authentication Build()
        {
            Validator.ValidateNotEmpty(authentication.Username, "Missing username, it's a required parameter for Basic Auth.");
            Validator.ValidateNotEmpty(authentication.Password, "Missing password, it's a required parameter for Basic Auth.");
            authentication.Type = "Basic";
            return authentication;
        }
    }
}
