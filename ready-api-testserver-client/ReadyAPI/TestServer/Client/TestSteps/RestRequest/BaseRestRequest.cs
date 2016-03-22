using System.Collections.Generic;
using IO.Swagger.Model;
using ReadyAPI.TestServer.Client.Assertions;
using ReadyAPI.TestServer.Client.Auth;

namespace ReadyAPI.TestServer.Client.TestSteps.RestRequest
{
    public class BaseRestRequest<TRestRequestBuilderType> :
        RestRequestBuilder<TRestRequestBuilderType>, TestStepBuilder
        where 
        TRestRequestBuilderType : class, RestRequestBuilder<TRestRequestBuilderType>
    {
        protected RestTestRequestStep testStep = new RestTestRequestStep();
        private List<Parameter> parameters = new List<Parameter>();
        private List<AssertionBuilder> assertionBuilders = new List<Assertions.AssertionBuilder>();
        private Dictionary<string, object> headers = new Dictionary<string, object>();

        public enum ParameterType { MATRIX, HEADER, QUERY, PATH };

        public BaseRestRequest (string uri, TestSteps.HttpMethod method)
        {
            testStep.URI = uri;
            testStep.Method = method.ToString();
        }

        TestStep TestStepBuilder.Build()
        {
            Validator.ValidateNotEmpty(testStep.URI, "No URI set, it's a mandatory parameter for REST Request");
            Validator.ValidateNotEmpty(testStep.Method, "No HTTP method set, it's a mandatory parameter for REST Request");
            testStep.Type = new TestStepTypes(TestStepTypes.REST_REQUEST).ToString();
            testStep.Headers = headers;
            SetAssertions(testStep);
            testStep.Parameters = parameters;

            return testStep;
        }
        
        private void SetAssertions(RestTestRequestStep testStep)
        {
            List<Assertion> assertions = new List<Assertion>();
            foreach (AssertionBuilder assertionBuilder in assertionBuilders)
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
            parameters.Add(parameter);
            return this as TRequestBuilderType;
        }

        public TRestRequestBuilderType Named(string name)
        {
            testStep.Name = name;
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

        public TRestRequestBuilderType AddAssertion(AssertionBuilder assertionBuilder)
        {
            assertionBuilders.Add(assertionBuilder);
            return this as TRestRequestBuilderType;
        }

        public TRestRequestBuilderType AddHeader(string name, List<string> values)
        {
            object headerValues;
            headers.TryGetValue(name, out headerValues);
            if (headerValues == null)
            {
                headerValues = new List<string>();
                headers.Add(name, headerValues);
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
            testStep.Timeout = timeout;
            return this as TRestRequestBuilderType; 
        }

        public TRestRequestBuilderType SetTimeout(int timeout)
        {
            testStep.Timeout = timeout.ToString();
            return this as TRestRequestBuilderType;
        }

        public TRestRequestBuilderType FollowRedirects()
        {
            testStep.FollowRedirects = true;
            return this as TRestRequestBuilderType;
        }

        public TRestRequestBuilderType EntitizeParameters()
        {
            testStep.EntitizeParameters = true;
            return this as TRestRequestBuilderType;
        }

        public TRestRequestBuilderType PostQuerystring()
        {
            testStep.PostQueryString = true;
            return this as TRestRequestBuilderType;
        }

        public TRestRequestBuilderType SetAuthentication(AuthenticationBuilder authenticationBuilder)
        {
            testStep.Authentication = (((AbstractAuthenticationBuilder)authenticationBuilder).Build());
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
            return AddAssertion(Assertions.Assertions.Contains(content) as AssertionBuilder);
        }

        public TRestRequestBuilderType AssertNotContains(string content)
        {
            return AddAssertion(Assertions.Assertions.NotContains(content) as AssertionBuilder);
        }

        public TRestRequestBuilderType AssertScript(string script)
        {
            return AddAssertion(Assertions.Assertions.Script(script));
        }

        public TRestRequestBuilderType AssertXPath(string xpath, string expectedContent)
        {
            return AddAssertion(Assertions.Assertions.XPathContains(xpath, expectedContent) as AssertionBuilder);
        }

        public TRestRequestBuilderType AssertXQuery(string xquery, string expectedContent)
        {
            return AddAssertion(Assertions.Assertions.XQueryContains(xquery, expectedContent) as AssertionBuilder);
        }

        public TRestRequestBuilderType AssertValidStatusCodes(params int[] statusCodes)
        {
            return AddAssertion(Assertions.Assertions.ValidStatusCodes(statusCodes) as AssertionBuilder);
        }

        public TRestRequestBuilderType AssertInvalidStatusCodes(params int[] statusCodes)
        {
            return AddAssertion(Assertions.Assertions.InvalidStatusCodes(statusCodes) as AssertionBuilder);
        }

        public TRestRequestBuilderType AssertResponseTime(int timeInMillis)
        {
            return AddAssertion(Assertions.Assertions.ResponseSLA(timeInMillis));
        }

        protected TRestRequestBuilderType WithURI(string uri)
        {
            testStep.URI = uri;
            return this as TRestRequestBuilderType;
        }
    }
}
