using IO.Swagger.Client;
using System.Collections.Generic;

namespace ReadyAPI.TestServer.Client.Execution
{
    public class UsageLimitException : ApiException
    {
        public UsageLimitException(int statusCode, string responseBody, Dictionary<string, List<string>> headers) : base(statusCode, responseBody, headers){}
    }
}
