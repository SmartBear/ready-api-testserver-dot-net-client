using System.Collections.Generic;
using IO.Swagger.Model;

namespace ReadyAPI.TestServer.Client.TestSteps.PropertyTransfer
{
    public class PropertyTransferTestStepBuilder : ITestStepBuilder
    {
        private PropertyTransferTestStep testStep = new PropertyTransferTestStep();
        private List<PropertyTransferBuilder> propertyTransferBuilders = new List<PropertyTransferBuilder>();

        public PropertyTransferTestStepBuilder Named(string name)
        {
            testStep.Name = name;
            return this;
        }

        public PropertyTransferTestStepBuilder AddTransfer(PropertyTransferBuilder propertyTransferBuilder)
        {
            this.propertyTransferBuilders.Add(propertyTransferBuilder);
            return this;
        }

        public TestStep Build()
        {
            testStep.Type = TestStepTypes.PROPERTY_TRANSFER;
            List<IO.Swagger.Model.PropertyTransfer> transfers = new List<IO.Swagger.Model.PropertyTransfer>();
            foreach (PropertyTransferBuilder propertyTransferBuilder in propertyTransferBuilders)
            {
                transfers.Add(propertyTransferBuilder.Build());
            }
            testStep.Transfers = transfers;
            return testStep;
        }
    }
}
