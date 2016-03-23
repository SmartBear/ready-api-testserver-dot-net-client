using System.Collections.Generic;
using IO.Swagger.Model;
using ReadyAPI.TestServer.Client.Assertions;
using ReadyAPI.TestServer.Client.Auth;

namespace ReadyAPI.TestServer.Client.TestSteps.RestRequest
{
    public class BaseRestRequest<TRestRequestBuilderType> :
        IRestRequestBuilder<TRestRequestBuilderType>, ITestStepBuilder
        where 
        TRestRequestBuilderType : class, IRestRequestBuilder<TRestRequestBuilderType>
    {
        protected RestTestRequestStep _testStep = new RestTestRequestStep();
        private List<Parameter> _parameters = new List<Parameter>();
        private List<IAssertionBuilder> _assertionBuilders = new List<Assertions.IAssertionBuilder>();
        private Dictionary<string, object> _headers = new Dictionary<string, object>();

        public enum ParameterType { MATRIX, HEADER, QUERY, PATH };

        public BaseRestRequest (string uri, TestSteps.HttpMethod method)
        {
            _testStep.URI = uri;
            _testStep.Method = method.ToString();
        }

        TestStep ITestStepBuilder.Build()
        {
            Validator.ValidateNotEmpty(_testStep.URI, "No URI set, it's a mandatory parameter for REST Request");
            Validator.ValidateNotEmpty(_testStep.Method, "No HTTP method set, it's a mandatory parameter for REST Request");
            _testStep.Type = new TestStepTypes(TestStepTypes.REST_REQUEST).ToString();
            _testStep.Headers = _headers;
            SetAssertions(_testStep);
            _testStep.Parameters = _parameters;

            return _testStep;
        }
        
        private void SetAssertions(RestTestRequestStep testStep)
        {
            List<Assertion> assertions = new List<Assertion>();
            foreach (IAssertionBuilder assertionBuilder in _assertionBuilders)
            {
                assertions.Add(((AbstractAssertionBuilder)assertionBuilder).Build());
            }
            testStep.Assertions = assertions;
        }

        private TRequestBuilderType AddParameter<TRequestBuilderType>(string parameterName, string value, ParameterType type) where TRequestBuilderType : class
        {
            Parameter parameter = new Parameter();
            parameter.Name = parameterName;
            parameter.Value = value;
            parameter.Type = (type == ParameterType.PATH ? "TEMPLATE" : type.ToString());
            _parameters.Add(parameter);
            return this as TRequestBuilderType;
        }

        public TRestRequestBuilderType Named(string name)
        {
            _testStep.Name = name;
            return this as TRestRequestBuilderType;
        }

        public TRestRequestBuilderType AddQueryParameter(string parameterName, string value)
        {
            return AddParameter<TRestRequestBuilderType>(parameterName, value, ParameterType.QUERY);
        }

        public TRestRequestBuilderType AddPathParameter(string parameterName, string value)
        {
            return AddParameter<TRestRequestBuilderType>(parameterName, value, ParameterType.PATH);
        }

        public TRestRequestBuilderType AddMatrixParameter(string parameterName, string value)
        {
            return AddParameter<TRestRequestBuilderType>(parameterName, value, ParameterType.MATRIX);
        }

        public TRestRequestBuilderType AddHeaderParameter(string parameterName, string value)
        {
            return AddParameter<TRestRequestBuilderType>(parameterName, value, ParameterType.HEADER);
        }

        public TRestRequestBuilderType AddAssertion(IAssertionBuilder assertionBuilder)
        {
            _assertionBuilders.Add(assertionBuilder);
            return this as TRestRequestBuilderType;
        }

        public TRestRequestBuilderType AddHeader(string name, List<string> values)
        {
            object headerValues;
            _headers.TryGetValue(name, out headerValues);
            if (headerValues == null)
            {
                headerValues = new List<string>();
                _headers.Add(name, headerValues);
            }

            (headerValues as List<string>).AddRange(values);
            return this as TRestRequestBuilderType;

        }

        public TRestRequestBuilderType AddHeader(string name, string value)
        {
            return AddHeader(name, new List<string>() { value });
        }

        public TRestRequestBuilderType SetTimeout(string timeout)
        {
            _testStep.Timeout = timeout;
            return this as TRestRequestBuilderType; 
        }

        public TRestRequestBuilderType SetTimeout(int timeout)
        {
            _testStep.Timeout = timeout.ToString();
            return this as TRestRequestBuilderType;
        }

        public TRestRequestBuilderType FollowRedirects()
        {
            _testStep.FollowRedirects = true;
            return this as TRestRequestBuilderType;
        }

        public TRestRequestBuilderType EntitizeParameters()
        {
            _testStep.EntitizeParameters = true;
            return this as TRestRequestBuilderType;
        }

        public TRestRequestBuilderType PostQuerystring()
        {
            _testStep.PostQueryString = true;
            return this as TRestRequestBuilderType;
        }

        public TRestRequestBuilderType SetAuthentication(IAuthenticationBuilder authenticationBuilder)
        {
            _testStep.Authentication = (((IAbstractAuthenticationBuilder)authenticationBuilder).Build());
            return this as TRestRequestBuilderType;

        }

        public TRestRequestBuilderType AssertJsonContent(string jsonPath, string expectedContent)
        {
            return AddAssertion(Assertions.Assertions.JsonPathContent(jsonPath, expectedContent).AllowWildcards());
        }

        public TRestRequestBuilderType AssertJsonCount(string jsonPath, int expectedCount)
        {
            return AddAssertion(Assertions.Assertions.JsonPathCount(jsonPath, expectedCount).AllowWildcards());
        }

        public TRestRequestBuilderType AssertContains(string content)
        {
            return AddAssertion(Assertions.Assertions.Contains(content) as IAssertionBuilder);
        }

        public TRestRequestBuilderType AssertNotContains(string content)
        {
            return AddAssertion(Assertions.Assertions.NotContains(content) as IAssertionBuilder);
        }

        public TRestRequestBuilderType AssertScript(string script)
        {
            return AddAssertion(Assertions.Assertions.Script(script));
        }

        public TRestRequestBuilderType AssertXPath(string xpath, string expectedContent)
        {
            return AddAssertion(Assertions.Assertions.XPathContains(xpath, expectedContent) as IAssertionBuilder);
        }

        public TRestRequestBuilderType AssertXQuery(string xquery, string expectedContent)
        {
            return AddAssertion(Assertions.Assertions.XQueryContains(xquery, expectedContent) as IAssertionBuilder);
        }

        public TRestRequestBuilderType AssertValidStatusCodes(params int[] statusCodes)
        {
            return AddAssertion(Assertions.Assertions.ValidStatusCodes(statusCodes) as IAssertionBuilder);
        }

        public TRestRequestBuilderType AssertInvalidStatusCodes(params int[] statusCodes)
        {
            return AddAssertion(Assertions.Assertions.InvalidStatusCodes(statusCodes) as IAssertionBuilder);
        }

        public TRestRequestBuilderType AssertResponseTime(int timeInMillis)
        {
            return AddAssertion(Assertions.Assertions.ResponseSLA(timeInMillis));
        }

        protected TRestRequestBuilderType WithURI(string uri)
        {
            _testStep.URI = uri;
            return this as TRestRequestBuilderType;
        }
    }
}
