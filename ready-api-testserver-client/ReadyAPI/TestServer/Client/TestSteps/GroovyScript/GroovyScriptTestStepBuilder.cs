using IO.Swagger.Model;

namespace ReadyAPI.TestServer.Client.TestSteps.GroovyScript
{
    public class GroovyScriptTestStepBuilder : ITestStepBuilder
    {
        private readonly string _scriptText;
        private string _name;

        public GroovyScriptTestStepBuilder(string scriptText)
        {
            this._scriptText = scriptText;
        }

        public GroovyScriptTestStepBuilder Named(string name)
        {
            this._name = name;
            return this;
        }

        public TestStep Build()
        {
            GroovyScriptTestStep scriptTestStep = new GroovyScriptTestStep();
            scriptTestStep.Type = TestStepTypes.GROOVY_SCRIPT;
            scriptTestStep.Script = _scriptText;
            scriptTestStep.Name = _name;
            return scriptTestStep;
        }
    }
}
