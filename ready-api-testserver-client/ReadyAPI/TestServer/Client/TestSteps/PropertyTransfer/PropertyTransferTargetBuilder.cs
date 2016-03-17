using IO.Swagger.Model;

namespace ReadyAPI.TestServer.Client.TestSteps.PropertyTransfer
{
    public class PropertyTransferTargetBuilder
    {
        private PropertyTransferTarget target = new PropertyTransferTarget();

        public static PropertyTransferTargetBuilder aTarget()
        {
            return new PropertyTransferTargetBuilder();
        }

        public PropertyTransferTargetBuilder WithTargetStep(string targetStepName)
        {
            target.TargetName = targetStepName;
            return this;
        }

        public PropertyTransferTargetBuilder WithProperty(string property)
        {
            target.Property = property;
            return this;
        }

        public PropertyTransferTargetBuilder WithPathLanguage(PathLanguage pathLanguage)
        {
            target.PathLanguage = pathLanguage.ToString();
            return this;
        }

        public PropertyTransferTargetBuilder WithPath(string path)
        {
            target.Path = path;
            return this;
        }

        public PropertyTransferTarget Build()
        {
            return target;
        }
    }
}
