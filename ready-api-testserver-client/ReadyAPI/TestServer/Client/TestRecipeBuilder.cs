using System.Collections.Generic;
using ReadyAPI.TestServer.Client.TestSteps;
using IO.Swagger.Model;

namespace ReadyAPI.TestServer.Client
{
    public class TestRecipeBuilder<T> where T : TestStep
    {
        private List<TestStepBuilder<T>> testStepBuilders = new List<TestStepBuilder<T>>();

        public TestRecipeBuilder<T> AddStep(TestStepBuilder<T> testStepBuilder)
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
            foreach (TestStepBuilder<T> testStepBuilder in testStepBuilders)
            {
                testSteps.Add(testStepBuilder.Build());
            }
            testCase.TestSteps = testSteps;
        }

        public static TestRecipeBuilder<T> NewTestRecipe()
        {
            return new TestRecipeBuilder<T>();
        }

    }
}
