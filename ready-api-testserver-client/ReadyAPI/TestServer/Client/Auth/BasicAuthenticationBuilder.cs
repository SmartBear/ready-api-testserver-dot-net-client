using IO.Swagger.Model;

namespace ReadyAPI.TestServer.Client.Auth
{
    public class BasicAuthenticationBuilder : IAbstractAuthenticationBuilder
    {
        protected Authentication _authentication = new Authentication();

        public BasicAuthenticationBuilder(string username, string password)
        {
            _authentication.Username = username;
            _authentication.Password = password;
        }

        public virtual Authentication Build()
        {
            Validator.ValidateNotEmpty(_authentication.Username, "Missing username, it's a required parameter for Basic Auth.");
            Validator.ValidateNotEmpty(_authentication.Password, "Missing password, it's a required parameter for Basic Auth.");
            _authentication.Type = "Basic";
            return _authentication;
        }
    }
}
