using System.Collections.Generic;
using ReadyAPI.TestServer.Client.Assertions;
using ReadyAPI.TestServer.Client.Auth;

namespace ReadyAPI.TestServer.Client.TestSteps.RestRequest
{
    public interface IRestRequestBuilder<TRestRequestBuilderType> : ITestStepBuilder
        where TRestRequestBuilderType : class, IRestRequestBuilder<TRestRequestBuilderType>
    {
        TRestRequestBuilderType Named(string name);

        TRestRequestBuilderType AddQueryParameter(string parameterName, string value);

        TRestRequestBuilderType AddPathParameter(string parameterName, string value);

        TRestRequestBuilderType AddMatrixParameter(string parameterName, string value);

        TRestRequestBuilderType AddHeaderParameter(string parameterName, string value);

        TRestRequestBuilderType AddAssertion(IAssertionBuilder assertionBuilder);

        TRestRequestBuilderType AddHeader(string name, List<string> values);

        TRestRequestBuilderType AddHeader(string name, string value);

        TRestRequestBuilderType SetTimeout(string timeout);

        TRestRequestBuilderType SetTimeout(int timeout);

        TRestRequestBuilderType FollowRedirects();

        TRestRequestBuilderType EntitizeParameters();

        TRestRequestBuilderType PostQuerystring();

        TRestRequestBuilderType SetAuthentication(IAuthenticationBuilder authenticationBuilder);

        TRestRequestBuilderType AssertJsonContent(string jsonPath, string expectedContent);

        TRestRequestBuilderType AssertJsonCount(string jsonPath, int expectedCount);

        TRestRequestBuilderType AssertContains(string content);

        TRestRequestBuilderType AssertNotContains(string content);

        TRestRequestBuilderType AssertScript(string script);

        TRestRequestBuilderType AssertXPath(string xpath, string expectedContent);

        TRestRequestBuilderType AssertXQuery(string xquery, string expectedContent);

        TRestRequestBuilderType AssertValidStatusCodes(params int[] statusCodes);

        TRestRequestBuilderType AssertInvalidStatusCodes(params int[] statusCodes);

        TRestRequestBuilderType AssertResponseTime(int timeInMillis);
    }
}
