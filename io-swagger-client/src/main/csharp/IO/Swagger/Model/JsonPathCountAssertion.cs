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
    public partial class JsonPathCountAssertion : Assertion,  IEquatable<JsonPathCountAssertion>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JsonPathCountAssertion" /> class.
        /// </summary>
        public JsonPathCountAssertion()
        {
            this.AllowWildcards = false;
            
        }

        
        /// <summary>
        /// JSONPath expression used to select content from the test step results.
        /// </summary>
        /// <value>JSONPath expression used to select content from the test step results.</value>
        [DataMember(Name="jsonPath", EmitDefaultValue=false)]
        public string JsonPath { get; set; }
  
        
        /// <summary>
        /// Treat <code>*</code> as wildcard in a match.
        /// </summary>
        /// <value>Treat <code>*</code> as wildcard in a match.</value>
        [DataMember(Name="allowWildcards", EmitDefaultValue=false)]
        public bool? AllowWildcards { get; set; }
  
        
        /// <summary>
        /// Expected number of matched results.
        /// </summary>
        /// <value>Expected number of matched results.</value>
        [DataMember(Name="expectedCount", EmitDefaultValue=false)]
        public int? ExpectedCount { get; set; }
  
        
        /// <summary>
        /// Assertion type. Possible values: <ul><li>AssertionStruct</li>  <li>Contains</li> <li>Invalid HTTP Status Codes</li> <li>JDBC Status</li> <li>JDBC Timeout</li> <li>JsonPath Count</li> <li>JsonPath Match</li> <li>Not Contains</li> <li>Response SLA</li> <li>Script Assertion</li> <li>Valid HTTP Status Codes</li> <li>XPath Match</li> <li>XQuery Match</li> </ul>
        /// </summary>
        /// <value>Assertion type. Possible values: <ul><li>AssertionStruct</li>  <li>Contains</li> <li>Invalid HTTP Status Codes</li> <li>JDBC Status</li> <li>JDBC Timeout</li> <li>JsonPath Count</li> <li>JsonPath Match</li> <li>Not Contains</li> <li>Response SLA</li> <li>Script Assertion</li> <li>Valid HTTP Status Codes</li> <li>XPath Match</li> <li>XQuery Match</li> </ul></value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JsonPathCountAssertion {\n");
            sb.Append("  JsonPath: ").Append(JsonPath).Append("\n");
            sb.Append("  AllowWildcards: ").Append(AllowWildcards).Append("\n");
            sb.Append("  ExpectedCount: ").Append(ExpectedCount).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            
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
            return this.Equals(obj as JsonPathCountAssertion);
        }

        /// <summary>
        /// Returns true if JsonPathCountAssertion instances are equal
        /// </summary>
        /// <param name="other">Instance of JsonPathCountAssertion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JsonPathCountAssertion other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.JsonPath == other.JsonPath ||
                    this.JsonPath != null &&
                    this.JsonPath.Equals(other.JsonPath)
                ) && 
                (
                    this.AllowWildcards == other.AllowWildcards ||
                    this.AllowWildcards != null &&
                    this.AllowWildcards.Equals(other.AllowWildcards)
                ) && 
                (
                    this.ExpectedCount == other.ExpectedCount ||
                    this.ExpectedCount != null &&
                    this.ExpectedCount.Equals(other.ExpectedCount)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                
                if (this.JsonPath != null)
                    hash = hash * 59 + this.JsonPath.GetHashCode();
                
                if (this.AllowWildcards != null)
                    hash = hash * 59 + this.AllowWildcards.GetHashCode();
                
                if (this.ExpectedCount != null)
                    hash = hash * 59 + this.ExpectedCount.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                return hash;
            }
        }

    }
}
