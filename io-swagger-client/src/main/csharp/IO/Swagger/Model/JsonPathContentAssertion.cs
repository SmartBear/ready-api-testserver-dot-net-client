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
    public partial class JsonPathContentAssertion : Assertion,  IEquatable<JsonPathContentAssertion>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JsonPathContentAssertion" /> class.
        /// </summary>
        public JsonPathContentAssertion()
        {
            this.AllowWildcards = false;
            
        }

        
        /// <summary>
        /// The path expression to use in matching.
        /// </summary>
        /// <value>The path expression to use in matching.</value>
        [DataMember(Name="jsonPath", EmitDefaultValue=false)]
        public string JsonPath { get; set; }
  
        
        /// <summary>
        /// Specifies if asterisks  (<code>*</code>) in expectedContent are handled as wildcards.
        /// </summary>
        /// <value>Specifies if asterisks  (<code>*</code>) in expectedContent are handled as wildcards.</value>
        [DataMember(Name="allowWildcards", EmitDefaultValue=false)]
        public bool? AllowWildcards { get; set; }
  
        
        /// <summary>
        /// Assertion type. Possible values: <ul><li>AssertionStruct</li>  <li>Contains</li> <li>Invalid HTTP Status Codes</li> <li>JDBC Status</li> <li>JDBC Timeout</li> <li>JsonPath Count</li> <li>JsonPath Match</li> <li>Not Contains</li> <li>Response SLA</li> <li>Script Assertion</li> <li>Valid HTTP Status Codes</li> <li>XPath Match</li> <li>XQuery Match</li> </ul>
        /// </summary>
        /// <value>Assertion type. Possible values: <ul><li>AssertionStruct</li>  <li>Contains</li> <li>Invalid HTTP Status Codes</li> <li>JDBC Status</li> <li>JDBC Timeout</li> <li>JsonPath Count</li> <li>JsonPath Match</li> <li>Not Contains</li> <li>Response SLA</li> <li>Script Assertion</li> <li>Valid HTTP Status Codes</li> <li>XPath Match</li> <li>XQuery Match</li> </ul></value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
  
        
        /// <summary>
        /// Expected result.
        /// </summary>
        /// <value>Expected result.</value>
        [DataMember(Name="expectedContent", EmitDefaultValue=false)]
        public string ExpectedContent { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JsonPathContentAssertion {\n");
            sb.Append("  JsonPath: ").Append(JsonPath).Append("\n");
            sb.Append("  AllowWildcards: ").Append(AllowWildcards).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ExpectedContent: ").Append(ExpectedContent).Append("\n");
            
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
            return this.Equals(obj as JsonPathContentAssertion);
        }

        /// <summary>
        /// Returns true if JsonPathContentAssertion instances are equal
        /// </summary>
        /// <param name="other">Instance of JsonPathContentAssertion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JsonPathContentAssertion other)
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
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.ExpectedContent == other.ExpectedContent ||
                    this.ExpectedContent != null &&
                    this.ExpectedContent.Equals(other.ExpectedContent)
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
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                if (this.ExpectedContent != null)
                    hash = hash * 59 + this.ExpectedContent.GetHashCode();
                
                return hash;
            }
        }

    }
}
