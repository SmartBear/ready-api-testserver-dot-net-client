using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class RestTestRequestStep : TestStep,  IEquatable<RestTestRequestStep>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestTestRequestStep" /> class.
        /// </summary>
        public RestTestRequestStep()
        {
            this.EntitizeParameters = false;
            this.FollowRedirects = false;
            this.PostQueryString = false;
            
        }

        
        /// <summary>
        /// Custom headers to be added to the request.
        /// </summary>
        /// <value>Custom headers to be added to the request.</value>
        [DataMember(Name="headers", EmitDefaultValue=false)]
        public Dictionary<string, Object> Headers { get; set; }
  
        
        /// <summary>
        /// The request type: GET, POST, DELETE, PUT and so on.
        /// </summary>
        /// <value>The request type: GET, POST, DELETE, PUT and so on.</value>
        [DataMember(Name="method", EmitDefaultValue=false)]
        public string Method { get; set; }
  
        
        /// <summary>
        /// Specifies if TestServer escapes special characters like > or & in the request body. Set this property to false if data is already escaped.
        /// </summary>
        /// <value>Specifies if TestServer escapes special characters like > or & in the request body. Set this property to false if data is already escaped.</value>
        [DataMember(Name="entitizeParameters", EmitDefaultValue=false)]
        public bool? EntitizeParameters { get; set; }
  
        
        /// <summary>
        /// The request data media type, for example, multipart/form-data.
        /// </summary>
        /// <value>The request data media type, for example, multipart/form-data.</value>
        [DataMember(Name="mediaType", EmitDefaultValue=false)]
        public string MediaType { get; set; }
  
        
        /// <summary>
        /// Test step type. Possible values: <ul><li>DataSource</li><li>Groovy</li><li>JDBC Request</li><li>Property Transfer</li><li>REST Request</li><li>TestStepStruct</li></ul>
        /// </summary>
        /// <value>Test step type. Possible values: <ul><li>DataSource</li><li>Groovy</li><li>JDBC Request</li><li>Property Transfer</li><li>REST Request</li><li>TestStepStruct</li></ul></value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
  
        
        /// <summary>
        /// The request data encoding, for example, utf-8.
        /// </summary>
        /// <value>The request data encoding, for example, utf-8.</value>
        [DataMember(Name="encoding", EmitDefaultValue=false)]
        public string Encoding { get; set; }
  
        
        /// <summary>
        /// The URL, to which TestServer send the request.
        /// </summary>
        /// <value>The URL, to which TestServer send the request.</value>
        [DataMember(Name="URI", EmitDefaultValue=false)]
        public string URI { get; set; }
  
        
        /// <summary>
        /// The maximum allowed execution time for the request in milliseconds.
        /// </summary>
        /// <value>The maximum allowed execution time for the request in milliseconds.</value>
        [DataMember(Name="timeout", EmitDefaultValue=false)]
        public string Timeout { get; set; }
  
        
        /// <summary>
        /// The request body contents.
        /// </summary>
        /// <value>The request body contents.</value>
        [DataMember(Name="requestBody", EmitDefaultValue=false)]
        public string RequestBody { get; set; }
  
        
        /// <summary>
        /// Specifies how TestServer handles redirects. If this property is false and a redirect occurs, TestServer processes the response as it is. If the property is true, it waits for the response from the new location.
        /// </summary>
        /// <value>Specifies how TestServer handles redirects. If this property is false and a redirect occurs, TestServer processes the response as it is. If the property is true, it waits for the response from the new location.</value>
        [DataMember(Name="followRedirects", EmitDefaultValue=false)]
        public bool? FollowRedirects { get; set; }
  
        
        /// <summary>
        /// Test step name. This name is used to refer to the test step in the test recipe.
        /// </summary>
        /// <value>Test step name. This name is used to refer to the test step in the test recipe.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
  
        
        /// <summary>
        /// Specifies if the TestServer includes the query string parameters to the request body or not.
        /// </summary>
        /// <value>Specifies if the TestServer includes the query string parameters to the request body or not.</value>
        [DataMember(Name="postQueryString", EmitDefaultValue=false)]
        public bool? PostQueryString { get; set; }
  
        
        /// <summary>
        /// An array of assertions that verify the response to the request.
        /// </summary>
        /// <value>An array of assertions that verify the response to the request.</value>
        [DataMember(Name="assertions", EmitDefaultValue=false)]
        public List<Assertion> Assertions { get; set; }
  
        
        /// <summary>
        /// An array of request parameters.
        /// </summary>
        /// <value>An array of request parameters.</value>
        [DataMember(Name="parameters", EmitDefaultValue=false)]
        public List<Parameter> Parameters { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Authentication
        /// </summary>
        [DataMember(Name="authentication", EmitDefaultValue=false)]
        public Authentication Authentication { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestTestRequestStep {\n");
            sb.Append("  Headers: ").Append(Headers).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  EntitizeParameters: ").Append(EntitizeParameters).Append("\n");
            sb.Append("  MediaType: ").Append(MediaType).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Encoding: ").Append(Encoding).Append("\n");
            sb.Append("  URI: ").Append(URI).Append("\n");
            sb.Append("  Timeout: ").Append(Timeout).Append("\n");
            sb.Append("  RequestBody: ").Append(RequestBody).Append("\n");
            sb.Append("  FollowRedirects: ").Append(FollowRedirects).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PostQueryString: ").Append(PostQueryString).Append("\n");
            sb.Append("  Assertions: ").Append(Assertions).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("  Authentication: ").Append(Authentication).Append("\n");
            
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public  new string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as RestTestRequestStep);
        }

        /// <summary>
        /// Returns true if RestTestRequestStep instances are equal
        /// </summary>
        /// <param name="other">Instance of RestTestRequestStep to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestTestRequestStep other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Headers == other.Headers ||
                    this.Headers != null &&
                    this.Headers.SequenceEqual(other.Headers)
                ) && 
                (
                    this.Method == other.Method ||
                    this.Method != null &&
                    this.Method.Equals(other.Method)
                ) && 
                (
                    this.EntitizeParameters == other.EntitizeParameters ||
                    this.EntitizeParameters != null &&
                    this.EntitizeParameters.Equals(other.EntitizeParameters)
                ) && 
                (
                    this.MediaType == other.MediaType ||
                    this.MediaType != null &&
                    this.MediaType.Equals(other.MediaType)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Encoding == other.Encoding ||
                    this.Encoding != null &&
                    this.Encoding.Equals(other.Encoding)
                ) && 
                (
                    this.URI == other.URI ||
                    this.URI != null &&
                    this.URI.Equals(other.URI)
                ) && 
                (
                    this.Timeout == other.Timeout ||
                    this.Timeout != null &&
                    this.Timeout.Equals(other.Timeout)
                ) && 
                (
                    this.RequestBody == other.RequestBody ||
                    this.RequestBody != null &&
                    this.RequestBody.Equals(other.RequestBody)
                ) && 
                (
                    this.FollowRedirects == other.FollowRedirects ||
                    this.FollowRedirects != null &&
                    this.FollowRedirects.Equals(other.FollowRedirects)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.PostQueryString == other.PostQueryString ||
                    this.PostQueryString != null &&
                    this.PostQueryString.Equals(other.PostQueryString)
                ) && 
                (
                    this.Assertions == other.Assertions ||
                    this.Assertions != null &&
                    this.Assertions.SequenceEqual(other.Assertions)
                ) && 
                (
                    this.Parameters == other.Parameters ||
                    this.Parameters != null &&
                    this.Parameters.SequenceEqual(other.Parameters)
                ) && 
                (
                    this.Authentication == other.Authentication ||
                    this.Authentication != null &&
                    this.Authentication.Equals(other.Authentication)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                
                if (this.Headers != null)
                    hash = hash * 59 + this.Headers.GetHashCode();
                
                if (this.Method != null)
                    hash = hash * 59 + this.Method.GetHashCode();
                
                if (this.EntitizeParameters != null)
                    hash = hash * 59 + this.EntitizeParameters.GetHashCode();
                
                if (this.MediaType != null)
                    hash = hash * 59 + this.MediaType.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                if (this.Encoding != null)
                    hash = hash * 59 + this.Encoding.GetHashCode();
                
                if (this.URI != null)
                    hash = hash * 59 + this.URI.GetHashCode();
                
                if (this.Timeout != null)
                    hash = hash * 59 + this.Timeout.GetHashCode();
                
                if (this.RequestBody != null)
                    hash = hash * 59 + this.RequestBody.GetHashCode();
                
                if (this.FollowRedirects != null)
                    hash = hash * 59 + this.FollowRedirects.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.PostQueryString != null)
                    hash = hash * 59 + this.PostQueryString.GetHashCode();
                
                if (this.Assertions != null)
                    hash = hash * 59 + this.Assertions.GetHashCode();
                
                if (this.Parameters != null)
                    hash = hash * 59 + this.Parameters.GetHashCode();
                
                if (this.Authentication != null)
                    hash = hash * 59 + this.Authentication.GetHashCode();
                
                return hash;
            }
        }

    }
}
