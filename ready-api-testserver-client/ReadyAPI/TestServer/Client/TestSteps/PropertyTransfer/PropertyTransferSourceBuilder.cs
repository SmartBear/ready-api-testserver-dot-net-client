using IO.Swagger.Model;

namespace ReadyAPI.TestServer.Client.TestSteps.PropertyTransfer
{
    public class PropertyTransferSourceBuilder
    {

        private PropertyTransferSource source = new PropertyTransferSource();

        public static PropertyTransferSourceBuilder aSource()
        {
            return new PropertyTransferSourceBuilder();
        }

        public PropertyTransferSourceBuilder WithSourceStep(string sourceStepName)
        {
            source.SourceName = sourceStepName;
            return this;
        }

        public PropertyTransferSourceBuilder WithProperty(string property)
        {
            source.Property = property;
            return this;
        }

        public PropertyTransferSourceBuilder WithPathLanguage(PathLanguage pathLanguage)
        {
            source.PathLanguage = pathLanguage.ToString();//possible mistake is here, need to double check
            return this;
        }

        public PropertyTransferSourceBuilder WithPath(string path)
        {
            source.Path = path;
            return this;
        }

        public PropertyTransferSource Build()
        {
            return source;
        }
    }
}
