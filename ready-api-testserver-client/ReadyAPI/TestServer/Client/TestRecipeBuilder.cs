using System.Collections.Generic;
using ReadyAPI.TestServer.Client.TestSteps;
using IO.Swagger.Model;

namespace ReadyAPI.TestServer.Client
{
    public class TestRecipeBuilder
    {
        private List<ITestStepBuilder> testStepBuilders = new List<ITestStepBuilder>();

        public TestRecipeBuilder AddStep(ITestStepBuilder testStepBuilder)
        {
            this.testStepBuilders.Add(testStepBuilder);
            return this;
        }

        public TestRecipe BuildTestRecipe()
        {
            TestCase testCase = new TestCase();
            testCase.FailTestCaseOnError = true;
            AddTestSteps(testCase);
            return new TestRecipe(testCase);
        }

        private void AddTestSteps(TestCase testCase)
        {
            List<TestStep> testSteps = new List<TestStep>();
            foreach (ITestStepBuilder testStepBuilder in testStepBuilders)
            {
                testSteps.Add(testStepBuilder.Build());
            }
            testCase.TestSteps = testSteps;
        }

        public static TestRecipeBuilder NewTestRecipe()
        {
            return new TestRecipeBuilder();
        }

    }
}
