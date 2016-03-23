using IO.Swagger.Model;

namespace ReadyAPI.TestServer.Client.Assertions
{
    public class DefaultGroovyScriptAssertionBuilder : AbstractAssertionBuilder
    {
        private GroovyScriptAssertion scriptAssertion = new GroovyScriptAssertion();

        public DefaultGroovyScriptAssertionBuilder(string script)
        {
            scriptAssertion.Script = script;
        }

        public override Assertion Build()
        {
            Validator.ValidateNotEmpty(scriptAssertion.Script, "Missing script. Script is a mandatory parameter for ScriptAssertion");
            scriptAssertion.Type = "Script Assertion";
            return scriptAssertion;
        }
    }
}
