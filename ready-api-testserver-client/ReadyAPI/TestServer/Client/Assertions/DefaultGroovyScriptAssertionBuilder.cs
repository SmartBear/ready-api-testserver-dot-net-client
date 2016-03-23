using IO.Swagger.Model;

namespace ReadyAPI.TestServer.Client.Assertions
{
    public class DefaultGroovyScriptAssertionBuilder : AbstractAssertionBuilder
    {
        private GroovyScriptAssertion _scriptAssertion = new GroovyScriptAssertion();

        public DefaultGroovyScriptAssertionBuilder(string script)
        {
            _scriptAssertion.Script = script;
        }

        public override Assertion Build()
        {
            Validator.ValidateNotEmpty(_scriptAssertion.Script, "Missing script. Script is a mandatory parameter for ScriptAssertion");
            _scriptAssertion.Type = "Script Assertion";
            return _scriptAssertion;
        }
    }
}
