using System;

namespace ReadyAPI.TestServer.Client.TestSteps.PropertyTransfer
{
    public class PropertyTransferBuilder
    {
        private IO.Swagger.Model.PropertyTransfer _transfer = new IO.Swagger.Model.PropertyTransfer();
        private PropertyTransferSourceBuilder _propertyTransferSourceBuilder;
        private PropertyTransferTargetBuilder _propertyTransferTargetBuilder;

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
            this._propertyTransferSourceBuilder = propertyTransferSourceBuilder;
            return this;
        }

        public PropertyTransferBuilder WithTarget(PropertyTransferTargetBuilder propertyTransferTargetBuilder)
        {
            return To(propertyTransferTargetBuilder);
        }

        public PropertyTransferBuilder To(PropertyTransferTargetBuilder propertyTransferTargetBuilder)
        {
            this._propertyTransferTargetBuilder = propertyTransferTargetBuilder;
            return this;
        }
        
        public IO.Swagger.Model.PropertyTransfer Build()
        {
            if (_propertyTransferSourceBuilder == null)
            {
                throw new InvalidOperationException("No source defined for property transfer");
            }
            if (_propertyTransferTargetBuilder == null)
            {
                throw new InvalidOperationException("No target defined for property transfer");
            }
            _transfer.Source = _propertyTransferSourceBuilder.Build();
            _transfer.Target = _propertyTransferTargetBuilder.Build();
            return _transfer;
        }
    }
}
