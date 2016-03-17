using System;

namespace ReadyAPI.TestServer.Client.TestSteps.PropertyTransfer
{
    public class PropertyTransferBuilder
    {
        private IO.Swagger.Model.PropertyTransfer transfer = new IO.Swagger.Model.PropertyTransfer();
        private PropertyTransferSourceBuilder propertyTransferSourceBuilder;
        private PropertyTransferTargetBuilder propertyTransferTargetBuilder;

        public static PropertyTransferBuilder From(PropertyTransferSourceBuilder propertyTransferSourceBuilder)
        {
            return new PropertyTransferBuilder().WithSource(propertyTransferSourceBuilder);
        }

        public static PropertyTransferBuilder NewTransfer()
        {
            return new PropertyTransferBuilder();
        }

        public PropertyTransferBuilder WithSource(PropertyTransferSourceBuilder propertyTransferSourceBuilder)
        {
            this.propertyTransferSourceBuilder = propertyTransferSourceBuilder;
            return this;
        }

        public PropertyTransferBuilder WithTarget(PropertyTransferTargetBuilder propertyTransferTargetBuilder)
        {
            return To(propertyTransferTargetBuilder);
        }

        public PropertyTransferBuilder To(PropertyTransferTargetBuilder propertyTransferTargetBuilder)
        {
            this.propertyTransferTargetBuilder = propertyTransferTargetBuilder;
            return this;
        }
        
        public IO.Swagger.Model.PropertyTransfer Build()
        {
            if (propertyTransferSourceBuilder == null)
            {
                throw new InvalidOperationException("No source defined for property transfer");
            }
            if (propertyTransferTargetBuilder == null)
            {
                throw new InvalidOperationException("No target defined for property transfer");
            }
            transfer.Source = propertyTransferSourceBuilder.Build();
            transfer.Target = propertyTransferTargetBuilder.Build();
            return transfer;
        }
    }
}
