using IO.Swagger.Model;

namespace ReadyAPI.TestServer.Client.TestSteps.GroovyScript
{
    public class GroovyScriptTestStepBuilder : TestStepBuilder
    {
        private readonly string scriptText;
        private string name;

        public GroovyScriptTestStepBuilder(string scriptText)
        {
            this.scriptText = scriptText;
        }

        public GroovyScriptTestStepBuilder Named(string name)
        {
            this.name = name;
            return this;
        }

        public TestStep Build()
        {
            GroovyScriptTestStep scriptTestStep = new GroovyScriptTestStep();
            scriptTestStep.Type = TestStepTypes.GROOVY_SCRIPT;
            scriptTestStep.Script = scriptText;
            scriptTestStep.Name = name;
            return scriptTestStep;
        }
    }
}
