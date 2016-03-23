using IO.Swagger.Model;

namespace ReadyAPI.TestServer.Client.TestSteps.PropertyTransfer
{
    public class PropertyTransferTargetBuilder
    {
        private PropertyTransferTarget _target = new PropertyTransferTarget();

        public static PropertyTransferTargetBuilder aTarget()
        {
            return new PropertyTransferTargetBuilder();
        }

        public PropertyTransferTargetBuilder WithTargetStep(string targetStepName)
        {
            _target.TargetName = targetStepName;
            return this;
        }

        public PropertyTransferTargetBuilder WithProperty(string property)
        {
            _target.Property = property;
            return this;
        }

        public PropertyTransferTargetBuilder WithPathLanguage(PathLanguage pathLanguage)
        {
            _target.PathLanguage = pathLanguage.ToString();
            return this;
        }

        public PropertyTransferTargetBuilder WithPath(string path)
        {
            _target.Path = path;
            return this;
        }

        public PropertyTransferTarget Build()
        {
            return _target;
        }
    }
}
