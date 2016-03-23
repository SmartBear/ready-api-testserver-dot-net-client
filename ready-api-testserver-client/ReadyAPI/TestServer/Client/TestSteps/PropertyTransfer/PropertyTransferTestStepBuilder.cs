using System.Collections.Generic;
using IO.Swagger.Model;

namespace ReadyAPI.TestServer.Client.TestSteps.PropertyTransfer
{
    public class PropertyTransferTestStepBuilder : ITestStepBuilder
    {
        private PropertyTransferTestStep _testStep = new PropertyTransferTestStep();
        private List<PropertyTransferBuilder> _propertyTransferBuilders = new List<PropertyTransferBuilder>();

        public PropertyTransferTestStepBuilder Named(string name)
        {
            _testStep.Name = name;
            return this;
        }

        public PropertyTransferTestStepBuilder AddTransfer(PropertyTransferBuilder propertyTransferBuilder)
        {
            this._propertyTransferBuilders.Add(propertyTransferBuilder);
            return this;
        }

        public TestStep Build()
        {
            _testStep.Type = TestStepTypes.PROPERTY_TRANSFER;
            List<IO.Swagger.Model.PropertyTransfer> transfers = new List<IO.Swagger.Model.PropertyTransfer>();
            foreach (PropertyTransferBuilder propertyTransferBuilder in _propertyTransferBuilders)
            {
                transfers.Add(propertyTransferBuilder.Build());
            }
            _testStep.Transfers = transfers;
            return _testStep;
        }
    }
}
