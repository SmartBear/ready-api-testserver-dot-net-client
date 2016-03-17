using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IReadyapiApi
    {
        
        /// <summary>
        /// Returns test run results stored on the TestServer.
        /// </summary>
        /// <remarks>
        /// Use this operation to get results of the latest test runs stored on the TestServer.&lt;br/&gt; The number of stored results is [configurable](http://readyapi.smartbear.com/testserver/reference/server_properties).
        /// </remarks>
        /// <returns>ProjectResultReports</returns>
        ProjectResultReports GetExecutions ();
  
        /// <summary>
        /// Returns test run results stored on the TestServer.
        /// </summary>
        /// <remarks>
        /// Use this operation to get results of the latest test runs stored on the TestServer.&lt;br/&gt; The number of stored results is [configurable](http://readyapi.smartbear.com/testserver/reference/server_properties).
        /// </remarks>
        /// <returns>ApiResponse of ProjectResultReports</returns>
        ApiResponse<ProjectResultReports> GetExecutionsWithHttpInfo ();

        /// <summary>
        /// Returns test run results stored on the TestServer.
        /// </summary>
        /// <remarks>
        /// Use this operation to get results of the latest test runs stored on the TestServer.&lt;br/&gt; The number of stored results is [configurable](http://readyapi.smartbear.com/testserver/reference/server_properties).
        /// </remarks>
        /// <returns>Task of ProjectResultReports</returns>
        System.Threading.Tasks.Task<ProjectResultReports> GetExecutionsAsync ();

        /// <summary>
        /// Returns test run results stored on the TestServer.
        /// </summary>
        /// <remarks>
        /// Use this operation to get results of the latest test runs stored on the TestServer.&lt;br/&gt; The number of stored results is [configurable](http://readyapi.smartbear.com/testserver/reference/server_properties).
        /// </remarks>
        /// <returns>Task of ApiResponse (ProjectResultReports)</returns>
        System.Threading.Tasks.Task<ApiResponse<ProjectResultReports>> GetExecutionsAsyncWithHttpInfo ();
        
        /// <summary>
        /// Runs a test recipe.
        /// </summary>
        /// <remarks>
        /// Use this operation to send a test recipe to the TestServer. The recipe contents is passed in the request body (should be valid JSON contents).
        /// </remarks>
        /// <param name="body">JSON-based test recipe contents.</param>
        /// <param name="async">Specifies when the TestServer replies:&lt;br/&gt;`true` - Immediately.&lt;br/&gt;`false` - After the execution is over.</param>
        /// <param name="callback">The URL, to which the results will be posted.</param>
        /// <returns>ProjectResultReport</returns>
        ProjectResultReport PostRecipe (TestCase body = null, bool? async = null, string callback = null);
  
        /// <summary>
        /// Runs a test recipe.
        /// </summary>
        /// <remarks>
        /// Use this operation to send a test recipe to the TestServer. The recipe contents is passed in the request body (should be valid JSON contents).
        /// </remarks>
        /// <param name="body">JSON-based test recipe contents.</param>
        /// <param name="async">Specifies when the TestServer replies:&lt;br/&gt;`true` - Immediately.&lt;br/&gt;`false` - After the execution is over.</param>
        /// <param name="callback">The URL, to which the results will be posted.</param>
        /// <returns>ApiResponse of ProjectResultReport</returns>
        ApiResponse<ProjectResultReport> PostRecipeWithHttpInfo (TestCase body = null, bool? async = null, string callback = null);

        /// <summary>
        /// Runs a test recipe.
        /// </summary>
        /// <remarks>
        /// Use this operation to send a test recipe to the TestServer. The recipe contents is passed in the request body (should be valid JSON contents).
        /// </remarks>
        /// <param name="body">JSON-based test recipe contents.</param>
        /// <param name="async">Specifies when the TestServer replies:&lt;br/&gt;`true` - Immediately.&lt;br/&gt;`false` - After the execution is over.</param>
        /// <param name="callback">The URL, to which the results will be posted.</param>
        /// <returns>Task of ProjectResultReport</returns>
        System.Threading.Tasks.Task<ProjectResultReport> PostRecipeAsync (TestCase body = null, bool? async = null, string callback = null);

        /// <summary>
        /// Runs a test recipe.
        /// </summary>
        /// <remarks>
        /// Use this operation to send a test recipe to the TestServer. The recipe contents is passed in the request body (should be valid JSON contents).
        /// </remarks>
        /// <param name="body">JSON-based test recipe contents.</param>
        /// <param name="async">Specifies when the TestServer replies:&lt;br/&gt;`true` - Immediately.&lt;br/&gt;`false` - After the execution is over.</param>
        /// <param name="callback">The URL, to which the results will be posted.</param>
        /// <returns>Task of ApiResponse (ProjectResultReport)</returns>
        System.Threading.Tasks.Task<ApiResponse<ProjectResultReport>> PostRecipeAsyncWithHttpInfo (TestCase body = null, bool? async = null, string callback = null);
        
        /// <summary>
        /// Executes a Ready! API test project.
        /// </summary>
        /// <remarks>
        /// Use this operation to send a Ready! API test project to the TestServer. You command the TestServer to execute the entire project, or an individual test suite or test case in it. The recipe request should have a Ready! API project file (.xml) attached to it.
        /// </remarks>
        /// <param name="body">Ready! API XML project.</param>
        /// <param name="testCaseName">The name of the test case to run.</param>
        /// <param name="testSuiteName">The name of the test suite to run.</param>
        /// <param name="async">Specifies when TestServer replies:&lt;br/&gt;`true` - Immediately.&lt;br/&gt;`false` - After the execution is over.</param>
        /// <param name="callback">The URL, to which the results will be posted.</param>
        /// <returns>ProjectResultReport</returns>
        ProjectResultReport PostProjectExecution (InputStream body = null, string testCaseName = null, string testSuiteName = null, bool? async = null, string callback = null);
  
        /// <summary>
        /// Executes a Ready! API test project.
        /// </summary>
        /// <remarks>
        /// Use this operation to send a Ready! API test project to the TestServer. You command the TestServer to execute the entire project, or an individual test suite or test case in it. The recipe request should have a Ready! API project file (.xml) attached to it.
        /// </remarks>
        /// <param name="body">Ready! API XML project.</param>
        /// <param name="testCaseName">The name of the test case to run.</param>
        /// <param name="testSuiteName">The name of the test suite to run.</param>
        /// <param name="async">Specifies when TestServer replies:&lt;br/&gt;`true` - Immediately.&lt;br/&gt;`false` - After the execution is over.</param>
        /// <param name="callback">The URL, to which the results will be posted.</param>
        /// <returns>ApiResponse of ProjectResultReport</returns>
        ApiResponse<ProjectResultReport> PostProjectExecutionWithHttpInfo (InputStream body = null, string testCaseName = null, string testSuiteName = null, bool? async = null, string callback = null);

        /// <summary>
        /// Executes a Ready! API test project.
        /// </summary>
        /// <remarks>
        /// Use this operation to send a Ready! API test project to the TestServer. You command the TestServer to execute the entire project, or an individual test suite or test case in it. The recipe request should have a Ready! API project file (.xml) attached to it.
        /// </remarks>
        /// <param name="body">Ready! API XML project.</param>
        /// <param name="testCaseName">The name of the test case to run.</param>
        /// <param name="testSuiteName">The name of the test suite to run.</param>
        /// <param name="async">Specifies when TestServer replies:&lt;br/&gt;`true` - Immediately.&lt;br/&gt;`false` - After the execution is over.</param>
        /// <param name="callback">The URL, to which the results will be posted.</param>
        /// <returns>Task of ProjectResultReport</returns>
        System.Threading.Tasks.Task<ProjectResultReport> PostProjectExecutionAsync (InputStream body = null, string testCaseName = null, string testSuiteName = null, bool? async = null, string callback = null);

        /// <summary>
        /// Executes a Ready! API test project.
        /// </summary>
        /// <remarks>
        /// Use this operation to send a Ready! API test project to the TestServer. You command the TestServer to execute the entire project, or an individual test suite or test case in it. The recipe request should have a Ready! API project file (.xml) attached to it.
        /// </remarks>
        /// <param name="body">Ready! API XML project.</param>
        /// <param name="testCaseName">The name of the test case to run.</param>
        /// <param name="testSuiteName">The name of the test suite to run.</param>
        /// <param name="async">Specifies when TestServer replies:&lt;br/&gt;`true` - Immediately.&lt;br/&gt;`false` - After the execution is over.</param>
        /// <param name="callback">The URL, to which the results will be posted.</param>
        /// <returns>Task of ApiResponse (ProjectResultReport)</returns>
        System.Threading.Tasks.Task<ApiResponse<ProjectResultReport>> PostProjectExecutionAsyncWithHttpInfo (InputStream body = null, string testCaseName = null, string testSuiteName = null, bool? async = null, string callback = null);
        
        /// <summary>
        /// Cancels the specified recipe execution
        /// </summary>
        /// <remarks>
        /// Use this operation to stop the run specified by &lt;i&gt;executionID&lt;/i&gt;. You can find in the response to your execution request ([see how](http://readyapi.smartbear.com/testserver/tutorials/your_first_recipe/results)), or you can send a GET &lt;code&gt;/readyapi/executions&lt;/code&gt; request to the TestServer.
        /// </remarks>
        /// <param name="executionID">The id of the test run to stop.</param>
        /// <returns></returns>
        void CancelExecution (string executionID);
  
        /// <summary>
        /// Cancels the specified recipe execution
        /// </summary>
        /// <remarks>
        /// Use this operation to stop the run specified by &lt;i&gt;executionID&lt;/i&gt;. You can find in the response to your execution request ([see how](http://readyapi.smartbear.com/testserver/tutorials/your_first_recipe/results)), or you can send a GET &lt;code&gt;/readyapi/executions&lt;/code&gt; request to the TestServer.
        /// </remarks>
        /// <param name="executionID">The id of the test run to stop.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> CancelExecutionWithHttpInfo (string executionID);

        /// <summary>
        /// Cancels the specified recipe execution
        /// </summary>
        /// <remarks>
        /// Use this operation to stop the run specified by &lt;i&gt;executionID&lt;/i&gt;. You can find in the response to your execution request ([see how](http://readyapi.smartbear.com/testserver/tutorials/your_first_recipe/results)), or you can send a GET &lt;code&gt;/readyapi/executions&lt;/code&gt; request to the TestServer.
        /// </remarks>
        /// <param name="executionID">The id of the test run to stop.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task CancelExecutionAsync (string executionID);

        /// <summary>
        /// Cancels the specified recipe execution
        /// </summary>
        /// <remarks>
        /// Use this operation to stop the run specified by &lt;i&gt;executionID&lt;/i&gt;. You can find in the response to your execution request ([see how](http://readyapi.smartbear.com/testserver/tutorials/your_first_recipe/results)), or you can send a GET &lt;code&gt;/readyapi/executions&lt;/code&gt; request to the TestServer.
        /// </remarks>
        /// <param name="executionID">The id of the test run to stop.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> CancelExecutionAsyncWithHttpInfo (string executionID);
        
        /// <summary>
        /// Returns the status of the specified recipe execution.
        /// </summary>
        /// <remarks>
        /// Use this operation to get information on the recipe execution specified by &lt;i&gt;executionID&lt;/i&gt;.  You can find in the response to your execution request ([see how](http://readyapi.smartbear.com/testserver/tutorials/your_first_recipe/results)), or you can send a GET &lt;code&gt;/readyapi/executions&lt;/code&gt; request to the TestServer.
        /// </remarks>
        /// <param name="executionID">The id of the desired test run.</param>
        /// <returns>ProjectResultReport</returns>
        ProjectResultReport GetExecutionStatus (string executionID);
  
        /// <summary>
        /// Returns the status of the specified recipe execution.
        /// </summary>
        /// <remarks>
        /// Use this operation to get information on the recipe execution specified by &lt;i&gt;executionID&lt;/i&gt;.  You can find in the response to your execution request ([see how](http://readyapi.smartbear.com/testserver/tutorials/your_first_recipe/results)), or you can send a GET &lt;code&gt;/readyapi/executions&lt;/code&gt; request to the TestServer.
        /// </remarks>
        /// <param name="executionID">The id of the desired test run.</param>
        /// <returns>ApiResponse of ProjectResultReport</returns>
        ApiResponse<ProjectResultReport> GetExecutionStatusWithHttpInfo (string executionID);

        /// <summary>
        /// Returns the status of the specified recipe execution.
        /// </summary>
        /// <remarks>
        /// Use this operation to get information on the recipe execution specified by &lt;i&gt;executionID&lt;/i&gt;.  You can find in the response to your execution request ([see how](http://readyapi.smartbear.com/testserver/tutorials/your_first_recipe/results)), or you can send a GET &lt;code&gt;/readyapi/executions&lt;/code&gt; request to the TestServer.
        /// </remarks>
        /// <param name="executionID">The id of the desired test run.</param>
        /// <returns>Task of ProjectResultReport</returns>
        System.Threading.Tasks.Task<ProjectResultReport> GetExecutionStatusAsync (string executionID);

        /// <summary>
        /// Returns the status of the specified recipe execution.
        /// </summary>
        /// <remarks>
        /// Use this operation to get information on the recipe execution specified by &lt;i&gt;executionID&lt;/i&gt;.  You can find in the response to your execution request ([see how](http://readyapi.smartbear.com/testserver/tutorials/your_first_recipe/results)), or you can send a GET &lt;code&gt;/readyapi/executions&lt;/code&gt; request to the TestServer.
        /// </remarks>
        /// <param name="executionID">The id of the desired test run.</param>
        /// <returns>Task of ApiResponse (ProjectResultReport)</returns>
        System.Threading.Tasks.Task<ApiResponse<ProjectResultReport>> GetExecutionStatusAsyncWithHttpInfo (string executionID);
        
        /// <summary>
        /// Posts a file for the specified test run
        /// </summary>
        /// <remarks>
        /// Use this operation to send additional files required by the executed test recipes. For example, you may need to send an Excel file for your test recipe that uses an Excel data source. The test recipe will be in the \&quot;PENDING\&quot; status until it receives the required file. Use the &lt;code&gt;multipart/form-data&lt;/code&gt; media type for this request.
        /// </remarks>
        /// <param name="body">Required file as `form-data`.</param>
        /// <param name="executionId">The id of the test run that waits for the files. [See how you can get it](http://readyapi.smartbear.com/testserver/tutorials/your_first_recipe/results).</param>
        /// <param name="async">Specifies when the TestServer replies:&lt;br/&gt;`true` - Immediately.&lt;br/&gt;`false` - After the execution is over.</param>
        /// <returns>ProjectResultReport</returns>
        ProjectResultReport AddFile (FormDataMultiPart body, string executionId, bool? async = null);
  
        /// <summary>
        /// Posts a file for the specified test run
        /// </summary>
        /// <remarks>
        /// Use this operation to send additional files required by the executed test recipes. For example, you may need to send an Excel file for your test recipe that uses an Excel data source. The test recipe will be in the \&quot;PENDING\&quot; status until it receives the required file. Use the &lt;code&gt;multipart/form-data&lt;/code&gt; media type for this request.
        /// </remarks>
        /// <param name="body">Required file as `form-data`.</param>
        /// <param name="executionId">The id of the test run that waits for the files. [See how you can get it](http://readyapi.smartbear.com/testserver/tutorials/your_first_recipe/results).</param>
        /// <param name="async">Specifies when the TestServer replies:&lt;br/&gt;`true` - Immediately.&lt;br/&gt;`false` - After the execution is over.</param>
        /// <returns>ApiResponse of ProjectResultReport</returns>
        ApiResponse<ProjectResultReport> AddFileWithHttpInfo (FormDataMultiPart body, string executionId, bool? async = null);

        /// <summary>
        /// Posts a file for the specified test run
        /// </summary>
        /// <remarks>
        /// Use this operation to send additional files required by the executed test recipes. For example, you may need to send an Excel file for your test recipe that uses an Excel data source. The test recipe will be in the \&quot;PENDING\&quot; status until it receives the required file. Use the &lt;code&gt;multipart/form-data&lt;/code&gt; media type for this request.
        /// </remarks>
        /// <param name="body">Required file as `form-data`.</param>
        /// <param name="executionId">The id of the test run that waits for the files. [See how you can get it](http://readyapi.smartbear.com/testserver/tutorials/your_first_recipe/results).</param>
        /// <param name="async">Specifies when the TestServer replies:&lt;br/&gt;`true` - Immediately.&lt;br/&gt;`false` - After the execution is over.</param>
        /// <returns>Task of ProjectResultReport</returns>
        System.Threading.Tasks.Task<ProjectResultReport> AddFileAsync (FormDataMultiPart body, string executionId, bool? async = null);

        /// <summary>
        /// Posts a file for the specified test run
        /// </summary>
        /// <remarks>
        /// Use this operation to send additional files required by the executed test recipes. For example, you may need to send an Excel file for your test recipe that uses an Excel data source. The test recipe will be in the \&quot;PENDING\&quot; status until it receives the required file. Use the &lt;code&gt;multipart/form-data&lt;/code&gt; media type for this request.
        /// </remarks>
        /// <param name="body">Required file as `form-data`.</param>
        /// <param name="executionId">The id of the test run that waits for the files. [See how you can get it](http://readyapi.smartbear.com/testserver/tutorials/your_first_recipe/results).</param>
        /// <param name="async">Specifies when the TestServer replies:&lt;br/&gt;`true` - Immediately.&lt;br/&gt;`false` - After the execution is over.</param>
        /// <returns>Task of ApiResponse (ProjectResultReport)</returns>
        System.Threading.Tasks.Task<ApiResponse<ProjectResultReport>> AddFileAsyncWithHttpInfo (FormDataMultiPart body, string executionId, bool? async = null);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ReadyapiApi : IReadyapiApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReadyapiApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ReadyapiApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ReadyapiApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ReadyapiApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default; 
            else
                this.Configuration = configuration;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuraiton.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }
    
        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }
   
        
        /// <summary>
        /// Returns test run results stored on the TestServer. Use this operation to get results of the latest test runs stored on the TestServer.&lt;br/&gt; The number of stored results is [configurable](http://readyapi.smartbear.com/testserver/reference/server_properties).
        /// </summary>
        /// <returns>ProjectResultReports</returns>
        public ProjectResultReports GetExecutions ()
        {
             ApiResponse<ProjectResultReports> response = GetExecutionsWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Returns test run results stored on the TestServer. Use this operation to get results of the latest test runs stored on the TestServer.&lt;br/&gt; The number of stored results is [configurable](http://readyapi.smartbear.com/testserver/reference/server_properties).
        /// </summary>
        /// <returns>ApiResponse of ProjectResultReports</returns>
        public ApiResponse< ProjectResultReports > GetExecutionsWithHttpInfo ()
        {
            
    
            var path_ = "/readyapi/executions";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            

            // authentication (basicAuth) required
            
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetExecutions: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetExecutions: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ProjectResultReports>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ProjectResultReports) Configuration.ApiClient.Deserialize(response, typeof(ProjectResultReports)));
            
        }

        /// <summary>
        /// Returns test run results stored on the TestServer. Use this operation to get results of the latest test runs stored on the TestServer.&lt;br/&gt; The number of stored results is [configurable](http://readyapi.smartbear.com/testserver/reference/server_properties).
        /// </summary>
        /// <returns>Task of ProjectResultReports</returns>
        public async System.Threading.Tasks.Task<ProjectResultReports> GetExecutionsAsync ()
        {
             ApiResponse<ProjectResultReports> response = await GetExecutionsAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Returns test run results stored on the TestServer. Use this operation to get results of the latest test runs stored on the TestServer.&lt;br/&gt; The number of stored results is [configurable](http://readyapi.smartbear.com/testserver/reference/server_properties).
        /// </summary>
        /// <returns>Task of ApiResponse (ProjectResultReports)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ProjectResultReports>> GetExecutionsAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/readyapi/executions";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            

            
            // authentication (basicAuth) required
            
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetExecutions: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetExecutions: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ProjectResultReports>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ProjectResultReports) Configuration.ApiClient.Deserialize(response, typeof(ProjectResultReports)));
            
        }
        
        /// <summary>
        /// Runs a test recipe. Use this operation to send a test recipe to the TestServer. The recipe contents is passed in the request body (should be valid JSON contents).
        /// </summary>
        /// <param name="body">JSON-based test recipe contents.</param> 
        /// <param name="async">Specifies when the TestServer replies:&lt;br/&gt;`true` - Immediately.&lt;br/&gt;`false` - After the execution is over.</param> 
        /// <param name="callback">The URL, to which the results will be posted.</param> 
        /// <returns>ProjectResultReport</returns>
        public ProjectResultReport PostRecipe (TestCase body = null, bool? async = null, string callback = null)
        {
             ApiResponse<ProjectResultReport> response = PostRecipeWithHttpInfo(body, async, callback);
             return response.Data;
        }

        /// <summary>
        /// Runs a test recipe. Use this operation to send a test recipe to the TestServer. The recipe contents is passed in the request body (should be valid JSON contents).
        /// </summary>
        /// <param name="body">JSON-based test recipe contents.</param> 
        /// <param name="async">Specifies when the TestServer replies:&lt;br/&gt;`true` - Immediately.&lt;br/&gt;`false` - After the execution is over.</param> 
        /// <param name="callback">The URL, to which the results will be posted.</param> 
        /// <returns>ApiResponse of ProjectResultReport</returns>
        public ApiResponse< ProjectResultReport > PostRecipeWithHttpInfo (TestCase body = null, bool? async = null, string callback = null)
        {
            
    
            var path_ = "/readyapi/executions";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (async != null) queryParams.Add("async", Configuration.ApiClient.ParameterToString(async)); // query parameter
            if (callback != null) queryParams.Add("callback", Configuration.ApiClient.ParameterToString(callback)); // query parameter
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                postBody = body; // byte array
            }

            // authentication (basicAuth) required
            
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostRecipe: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostRecipe: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ProjectResultReport>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ProjectResultReport) Configuration.ApiClient.Deserialize(response, typeof(ProjectResultReport)));
            
        }
    
        /// <summary>
        /// Runs a test recipe. Use this operation to send a test recipe to the TestServer. The recipe contents is passed in the request body (should be valid JSON contents).
        /// </summary>
        /// <param name="body">JSON-based test recipe contents.</param>
        /// <param name="async">Specifies when the TestServer replies:&lt;br/&gt;`true` - Immediately.&lt;br/&gt;`false` - After the execution is over.</param>
        /// <param name="callback">The URL, to which the results will be posted.</param>
        /// <returns>Task of ProjectResultReport</returns>
        public async System.Threading.Tasks.Task<ProjectResultReport> PostRecipeAsync (TestCase body = null, bool? async = null, string callback = null)
        {
             ApiResponse<ProjectResultReport> response = await PostRecipeAsyncWithHttpInfo(body, async, callback);
             return response.Data;

        }

        /// <summary>
        /// Runs a test recipe. Use this operation to send a test recipe to the TestServer. The recipe contents is passed in the request body (should be valid JSON contents).
        /// </summary>
        /// <param name="body">JSON-based test recipe contents.</param>
        /// <param name="async">Specifies when the TestServer replies:&lt;br/&gt;`true` - Immediately.&lt;br/&gt;`false` - After the execution is over.</param>
        /// <param name="callback">The URL, to which the results will be posted.</param>
        /// <returns>Task of ApiResponse (ProjectResultReport)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ProjectResultReport>> PostRecipeAsyncWithHttpInfo (TestCase body = null, bool? async = null, string callback = null)
        {
            
    
            var path_ = "/readyapi/executions";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (async != null) queryParams.Add("async", Configuration.ApiClient.ParameterToString(async)); // query parameter
            if (callback != null) queryParams.Add("callback", Configuration.ApiClient.ParameterToString(callback)); // query parameter
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (basicAuth) required
            
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostRecipe: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostRecipe: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ProjectResultReport>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ProjectResultReport) Configuration.ApiClient.Deserialize(response, typeof(ProjectResultReport)));
            
        }
        
        /// <summary>
        /// Executes a Ready! API test project. Use this operation to send a Ready! API test project to the TestServer. You command the TestServer to execute the entire project, or an individual test suite or test case in it. The recipe request should have a Ready! API project file (.xml) attached to it.
        /// </summary>
        /// <param name="body">Ready! API XML project.</param> 
        /// <param name="testCaseName">The name of the test case to run.</param> 
        /// <param name="testSuiteName">The name of the test suite to run.</param> 
        /// <param name="async">Specifies when TestServer replies:&lt;br/&gt;`true` - Immediately.&lt;br/&gt;`false` - After the execution is over.</param> 
        /// <param name="callback">The URL, to which the results will be posted.</param> 
        /// <returns>ProjectResultReport</returns>
        public ProjectResultReport PostProjectExecution (InputStream body = null, string testCaseName = null, string testSuiteName = null, bool? async = null, string callback = null)
        {
             ApiResponse<ProjectResultReport> response = PostProjectExecutionWithHttpInfo(body, testCaseName, testSuiteName, async, callback);
             return response.Data;
        }

        /// <summary>
        /// Executes a Ready! API test project. Use this operation to send a Ready! API test project to the TestServer. You command the TestServer to execute the entire project, or an individual test suite or test case in it. The recipe request should have a Ready! API project file (.xml) attached to it.
        /// </summary>
        /// <param name="body">Ready! API XML project.</param> 
        /// <param name="testCaseName">The name of the test case to run.</param> 
        /// <param name="testSuiteName">The name of the test suite to run.</param> 
        /// <param name="async">Specifies when TestServer replies:&lt;br/&gt;`true` - Immediately.&lt;br/&gt;`false` - After the execution is over.</param> 
        /// <param name="callback">The URL, to which the results will be posted.</param> 
        /// <returns>ApiResponse of ProjectResultReport</returns>
        public ApiResponse< ProjectResultReport > PostProjectExecutionWithHttpInfo (InputStream body = null, string testCaseName = null, string testSuiteName = null, bool? async = null, string callback = null)
        {
            
    
            var path_ = "/readyapi/executions/xml";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/xml"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (testCaseName != null) queryParams.Add("testCaseName", Configuration.ApiClient.ParameterToString(testCaseName)); // query parameter
            if (testSuiteName != null) queryParams.Add("testSuiteName", Configuration.ApiClient.ParameterToString(testSuiteName)); // query parameter
            if (async != null) queryParams.Add("async", Configuration.ApiClient.ParameterToString(async)); // query parameter
            if (callback != null) queryParams.Add("callback", Configuration.ApiClient.ParameterToString(callback)); // query parameter
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                postBody = body; // byte array
            }

            // authentication (basicAuth) required
            
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostProjectExecution: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostProjectExecution: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ProjectResultReport>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ProjectResultReport) Configuration.ApiClient.Deserialize(response, typeof(ProjectResultReport)));
            
        }
    
        /// <summary>
        /// Executes a Ready! API test project. Use this operation to send a Ready! API test project to the TestServer. You command the TestServer to execute the entire project, or an individual test suite or test case in it. The recipe request should have a Ready! API project file (.xml) attached to it.
        /// </summary>
        /// <param name="body">Ready! API XML project.</param>
        /// <param name="testCaseName">The name of the test case to run.</param>
        /// <param name="testSuiteName">The name of the test suite to run.</param>
        /// <param name="async">Specifies when TestServer replies:&lt;br/&gt;`true` - Immediately.&lt;br/&gt;`false` - After the execution is over.</param>
        /// <param name="callback">The URL, to which the results will be posted.</param>
        /// <returns>Task of ProjectResultReport</returns>
        public async System.Threading.Tasks.Task<ProjectResultReport> PostProjectExecutionAsync (InputStream body = null, string testCaseName = null, string testSuiteName = null, bool? async = null, string callback = null)
        {
             ApiResponse<ProjectResultReport> response = await PostProjectExecutionAsyncWithHttpInfo(body, testCaseName, testSuiteName, async, callback);
             return response.Data;

        }

        /// <summary>
        /// Executes a Ready! API test project. Use this operation to send a Ready! API test project to the TestServer. You command the TestServer to execute the entire project, or an individual test suite or test case in it. The recipe request should have a Ready! API project file (.xml) attached to it.
        /// </summary>
        /// <param name="body">Ready! API XML project.</param>
        /// <param name="testCaseName">The name of the test case to run.</param>
        /// <param name="testSuiteName">The name of the test suite to run.</param>
        /// <param name="async">Specifies when TestServer replies:&lt;br/&gt;`true` - Immediately.&lt;br/&gt;`false` - After the execution is over.</param>
        /// <param name="callback">The URL, to which the results will be posted.</param>
        /// <returns>Task of ApiResponse (ProjectResultReport)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ProjectResultReport>> PostProjectExecutionAsyncWithHttpInfo (InputStream body = null, string testCaseName = null, string testSuiteName = null, bool? async = null, string callback = null)
        {
            
    
            var path_ = "/readyapi/executions/xml";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/xml"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (testCaseName != null) queryParams.Add("testCaseName", Configuration.ApiClient.ParameterToString(testCaseName)); // query parameter
            if (testSuiteName != null) queryParams.Add("testSuiteName", Configuration.ApiClient.ParameterToString(testSuiteName)); // query parameter
            if (async != null) queryParams.Add("async", Configuration.ApiClient.ParameterToString(async)); // query parameter
            if (callback != null) queryParams.Add("callback", Configuration.ApiClient.ParameterToString(callback)); // query parameter
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (basicAuth) required
            
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostProjectExecution: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostProjectExecution: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ProjectResultReport>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ProjectResultReport) Configuration.ApiClient.Deserialize(response, typeof(ProjectResultReport)));
            
        }
        
        /// <summary>
        /// Cancels the specified recipe execution Use this operation to stop the run specified by &lt;i&gt;executionID&lt;/i&gt;. You can find in the response to your execution request ([see how](http://readyapi.smartbear.com/testserver/tutorials/your_first_recipe/results)), or you can send a GET &lt;code&gt;/readyapi/executions&lt;/code&gt; request to the TestServer.
        /// </summary>
        /// <param name="executionID">The id of the test run to stop.</param> 
        /// <returns></returns>
        public void CancelExecution (string executionID)
        {
             CancelExecutionWithHttpInfo(executionID);
        }

        /// <summary>
        /// Cancels the specified recipe execution Use this operation to stop the run specified by &lt;i&gt;executionID&lt;/i&gt;. You can find in the response to your execution request ([see how](http://readyapi.smartbear.com/testserver/tutorials/your_first_recipe/results)), or you can send a GET &lt;code&gt;/readyapi/executions&lt;/code&gt; request to the TestServer.
        /// </summary>
        /// <param name="executionID">The id of the test run to stop.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> CancelExecutionWithHttpInfo (string executionID)
        {
            
            // verify the required parameter 'executionID' is set
            if (executionID == null)
                throw new ApiException(400, "Missing required parameter 'executionID' when calling ReadyapiApi->CancelExecution");
            
    
            var path_ = "/readyapi/executions/{executionID}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (executionID != null) pathParams.Add("executionID", Configuration.ApiClient.ParameterToString(executionID)); // path parameter
            
            
            
            
            

            // authentication (basicAuth) required
            
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CancelExecution: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CancelExecution: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Cancels the specified recipe execution Use this operation to stop the run specified by &lt;i&gt;executionID&lt;/i&gt;. You can find in the response to your execution request ([see how](http://readyapi.smartbear.com/testserver/tutorials/your_first_recipe/results)), or you can send a GET &lt;code&gt;/readyapi/executions&lt;/code&gt; request to the TestServer.
        /// </summary>
        /// <param name="executionID">The id of the test run to stop.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task CancelExecutionAsync (string executionID)
        {
             await CancelExecutionAsyncWithHttpInfo(executionID);

        }

        /// <summary>
        /// Cancels the specified recipe execution Use this operation to stop the run specified by &lt;i&gt;executionID&lt;/i&gt;. You can find in the response to your execution request ([see how](http://readyapi.smartbear.com/testserver/tutorials/your_first_recipe/results)), or you can send a GET &lt;code&gt;/readyapi/executions&lt;/code&gt; request to the TestServer.
        /// </summary>
        /// <param name="executionID">The id of the test run to stop.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> CancelExecutionAsyncWithHttpInfo (string executionID)
        {
            // verify the required parameter 'executionID' is set
            if (executionID == null) throw new ApiException(400, "Missing required parameter 'executionID' when calling CancelExecution");
            
    
            var path_ = "/readyapi/executions/{executionID}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (executionID != null) pathParams.Add("executionID", Configuration.ApiClient.ParameterToString(executionID)); // path parameter
            
            
            
            
            

            
            // authentication (basicAuth) required
            
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CancelExecution: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CancelExecution: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Returns the status of the specified recipe execution. Use this operation to get information on the recipe execution specified by &lt;i&gt;executionID&lt;/i&gt;.  You can find in the response to your execution request ([see how](http://readyapi.smartbear.com/testserver/tutorials/your_first_recipe/results)), or you can send a GET &lt;code&gt;/readyapi/executions&lt;/code&gt; request to the TestServer.
        /// </summary>
        /// <param name="executionID">The id of the desired test run.</param> 
        /// <returns>ProjectResultReport</returns>
        public ProjectResultReport GetExecutionStatus (string executionID)
        {
             ApiResponse<ProjectResultReport> response = GetExecutionStatusWithHttpInfo(executionID);
             return response.Data;
        }

        /// <summary>
        /// Returns the status of the specified recipe execution. Use this operation to get information on the recipe execution specified by &lt;i&gt;executionID&lt;/i&gt;.  You can find in the response to your execution request ([see how](http://readyapi.smartbear.com/testserver/tutorials/your_first_recipe/results)), or you can send a GET &lt;code&gt;/readyapi/executions&lt;/code&gt; request to the TestServer.
        /// </summary>
        /// <param name="executionID">The id of the desired test run.</param> 
        /// <returns>ApiResponse of ProjectResultReport</returns>
        public ApiResponse< ProjectResultReport > GetExecutionStatusWithHttpInfo (string executionID)
        {
            
            // verify the required parameter 'executionID' is set
            if (executionID == null)
                throw new ApiException(400, "Missing required parameter 'executionID' when calling ReadyapiApi->GetExecutionStatus");
            
    
            var path_ = "/readyapi/executions/{executionID}/status";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (executionID != null) pathParams.Add("executionID", Configuration.ApiClient.ParameterToString(executionID)); // path parameter
            
            
            
            
            

            // authentication (basicAuth) required
            
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetExecutionStatus: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetExecutionStatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ProjectResultReport>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ProjectResultReport) Configuration.ApiClient.Deserialize(response, typeof(ProjectResultReport)));
            
        }
    
        /// <summary>
        /// Returns the status of the specified recipe execution. Use this operation to get information on the recipe execution specified by &lt;i&gt;executionID&lt;/i&gt;.  You can find in the response to your execution request ([see how](http://readyapi.smartbear.com/testserver/tutorials/your_first_recipe/results)), or you can send a GET &lt;code&gt;/readyapi/executions&lt;/code&gt; request to the TestServer.
        /// </summary>
        /// <param name="executionID">The id of the desired test run.</param>
        /// <returns>Task of ProjectResultReport</returns>
        public async System.Threading.Tasks.Task<ProjectResultReport> GetExecutionStatusAsync (string executionID)
        {
             ApiResponse<ProjectResultReport> response = await GetExecutionStatusAsyncWithHttpInfo(executionID);
             return response.Data;

        }

        /// <summary>
        /// Returns the status of the specified recipe execution. Use this operation to get information on the recipe execution specified by &lt;i&gt;executionID&lt;/i&gt;.  You can find in the response to your execution request ([see how](http://readyapi.smartbear.com/testserver/tutorials/your_first_recipe/results)), or you can send a GET &lt;code&gt;/readyapi/executions&lt;/code&gt; request to the TestServer.
        /// </summary>
        /// <param name="executionID">The id of the desired test run.</param>
        /// <returns>Task of ApiResponse (ProjectResultReport)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ProjectResultReport>> GetExecutionStatusAsyncWithHttpInfo (string executionID)
        {
            // verify the required parameter 'executionID' is set
            if (executionID == null) throw new ApiException(400, "Missing required parameter 'executionID' when calling GetExecutionStatus");
            
    
            var path_ = "/readyapi/executions/{executionID}/status";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (executionID != null) pathParams.Add("executionID", Configuration.ApiClient.ParameterToString(executionID)); // path parameter
            
            
            
            
            

            
            // authentication (basicAuth) required
            
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetExecutionStatus: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetExecutionStatus: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ProjectResultReport>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ProjectResultReport) Configuration.ApiClient.Deserialize(response, typeof(ProjectResultReport)));
            
        }
        
        /// <summary>
        /// Posts a file for the specified test run Use this operation to send additional files required by the executed test recipes. For example, you may need to send an Excel file for your test recipe that uses an Excel data source. The test recipe will be in the \&quot;PENDING\&quot; status until it receives the required file. Use the &lt;code&gt;multipart/form-data&lt;/code&gt; media type for this request.
        /// </summary>
        /// <param name="body">Required file as `form-data`.</param> 
        /// <param name="executionId">The id of the test run that waits for the files. [See how you can get it](http://readyapi.smartbear.com/testserver/tutorials/your_first_recipe/results).</param> 
        /// <param name="async">Specifies when the TestServer replies:&lt;br/&gt;`true` - Immediately.&lt;br/&gt;`false` - After the execution is over.</param> 
        /// <returns>ProjectResultReport</returns>
        public ProjectResultReport AddFile (FormDataMultiPart body, string executionId, bool? async = null)
        {
             ApiResponse<ProjectResultReport> response = AddFileWithHttpInfo(body, executionId, async);
             return response.Data;
        }

        /// <summary>
        /// Posts a file for the specified test run Use this operation to send additional files required by the executed test recipes. For example, you may need to send an Excel file for your test recipe that uses an Excel data source. The test recipe will be in the \&quot;PENDING\&quot; status until it receives the required file. Use the &lt;code&gt;multipart/form-data&lt;/code&gt; media type for this request.
        /// </summary>
        /// <param name="body">Required file as `form-data`.</param> 
        /// <param name="executionId">The id of the test run that waits for the files. [See how you can get it](http://readyapi.smartbear.com/testserver/tutorials/your_first_recipe/results).</param> 
        /// <param name="async">Specifies when the TestServer replies:&lt;br/&gt;`true` - Immediately.&lt;br/&gt;`false` - After the execution is over.</param> 
        /// <returns>ApiResponse of ProjectResultReport</returns>
        public ApiResponse< ProjectResultReport > AddFileWithHttpInfo (FormDataMultiPart body, string executionId, bool? async = null)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ReadyapiApi->AddFile");
            
            // verify the required parameter 'executionId' is set
            if (executionId == null)
                throw new ApiException(400, "Missing required parameter 'executionId' when calling ReadyapiApi->AddFile");
            
    
            var path_ = "/readyapi/executions/{executionId}/files";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "multipart/form-data"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (executionId != null) pathParams.Add("executionId", Configuration.ApiClient.ParameterToString(executionId)); // path parameter
            
            if (async != null) queryParams.Add("async", Configuration.ApiClient.ParameterToString(async)); // query parameter
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                postBody = body; // byte array
            }

            // authentication (basicAuth) required
            
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AddFile: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AddFile: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ProjectResultReport>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ProjectResultReport) Configuration.ApiClient.Deserialize(response, typeof(ProjectResultReport)));
            
        }
    
        /// <summary>
        /// Posts a file for the specified test run Use this operation to send additional files required by the executed test recipes. For example, you may need to send an Excel file for your test recipe that uses an Excel data source. The test recipe will be in the \&quot;PENDING\&quot; status until it receives the required file. Use the &lt;code&gt;multipart/form-data&lt;/code&gt; media type for this request.
        /// </summary>
        /// <param name="body">Required file as `form-data`.</param>
        /// <param name="executionId">The id of the test run that waits for the files. [See how you can get it](http://readyapi.smartbear.com/testserver/tutorials/your_first_recipe/results).</param>
        /// <param name="async">Specifies when the TestServer replies:&lt;br/&gt;`true` - Immediately.&lt;br/&gt;`false` - After the execution is over.</param>
        /// <returns>Task of ProjectResultReport</returns>
        public async System.Threading.Tasks.Task<ProjectResultReport> AddFileAsync (FormDataMultiPart body, string executionId, bool? async = null)
        {
             ApiResponse<ProjectResultReport> response = await AddFileAsyncWithHttpInfo(body, executionId, async);
             return response.Data;

        }

        /// <summary>
        /// Posts a file for the specified test run Use this operation to send additional files required by the executed test recipes. For example, you may need to send an Excel file for your test recipe that uses an Excel data source. The test recipe will be in the \&quot;PENDING\&quot; status until it receives the required file. Use the &lt;code&gt;multipart/form-data&lt;/code&gt; media type for this request.
        /// </summary>
        /// <param name="body">Required file as `form-data`.</param>
        /// <param name="executionId">The id of the test run that waits for the files. [See how you can get it](http://readyapi.smartbear.com/testserver/tutorials/your_first_recipe/results).</param>
        /// <param name="async">Specifies when the TestServer replies:&lt;br/&gt;`true` - Immediately.&lt;br/&gt;`false` - After the execution is over.</param>
        /// <returns>Task of ApiResponse (ProjectResultReport)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ProjectResultReport>> AddFileAsyncWithHttpInfo (FormDataMultiPart body, string executionId, bool? async = null)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddFile");
            // verify the required parameter 'executionId' is set
            if (executionId == null) throw new ApiException(400, "Missing required parameter 'executionId' when calling AddFile");
            
    
            var path_ = "/readyapi/executions/{executionId}/files";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "multipart/form-data"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (executionId != null) pathParams.Add("executionId", Configuration.ApiClient.ParameterToString(executionId)); // path parameter
            
            if (async != null) queryParams.Add("async", Configuration.ApiClient.ParameterToString(async)); // query parameter
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (basicAuth) required
            
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AddFile: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AddFile: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ProjectResultReport>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ProjectResultReport) Configuration.ApiClient.Deserialize(response, typeof(ProjectResultReport)));
            
        }

        private static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

    }

}
