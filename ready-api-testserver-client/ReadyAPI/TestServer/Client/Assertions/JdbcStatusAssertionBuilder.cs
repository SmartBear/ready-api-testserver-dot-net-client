using IO.Swagger.Model;

namespace ReadyAPI.TestServer.Client.Assertions
{
    public class JdbcStatusAssertionBuilder: AbstractAssertionBuilder {

    public override Assertion Build()
    {
        JdbcStatusAssertionStruct statusAssertion = new JdbcStatusAssertionStruct();
        statusAssertion.Type = "JDBC Status";
        return statusAssertion;
    }
}}
