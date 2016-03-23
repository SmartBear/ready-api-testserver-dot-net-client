using IO.Swagger.Model;

namespace ReadyAPI.TestServer.Client.TestSteps.PropertyTransfer
{
    public class PropertyTransferSourceBuilder
    {

        private PropertyTransferSource _source = new PropertyTransferSource();

        public static PropertyTransferSourceBuilder aSource()
        {
            return new PropertyTransferSourceBuilder();
        }

        public PropertyTransferSourceBuilder WithSourceStep(string sourceStepName)
        {
            _source.SourceName = sourceStepName;
            return this;
        }

        public PropertyTransferSourceBuilder WithProperty(string property)
        {
            _source.Property = property;
            return this;
        }

        public PropertyTransferSourceBuilder WithPathLanguage(PathLanguage pathLanguage)
        {
            _source.PathLanguage = pathLanguage.ToString();//TODO: possible mistake is here, need to double check
            return this;
        }

        public PropertyTransferSourceBuilder WithPath(string path)
        {
            _source.Path = path;
            return this;
        }

        public PropertyTransferSource Build()
        {
            return _source;
        }
    }
}
