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
    public partial class SimpleContainsAssertion : Assertion,  IEquatable<SimpleContainsAssertion>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleContainsAssertion" /> class.
        /// </summary>
        public SimpleContainsAssertion()
        {
            this.UseRegexp = false;
            this.IgnoreCase = false;
            
        }

        
        /// <summary>
        /// Specifies if the token property is a regular expression (true) or plain text (false).
        /// </summary>
        /// <value>Specifies if the token property is a regular expression (true) or plain text (false).</value>
        [DataMember(Name="useRegexp", EmitDefaultValue=false)]
        public bool? UseRegexp { get; set; }
  
        
        /// <summary>
        /// Assertion type. Possible values: <ul><li>AssertionStruct</li>  <li>Contains</li> <li>Invalid HTTP Status Codes</li> <li>JDBC Status</li> <li>JDBC Timeout</li> <li>JsonPath Count</li> <li>JsonPath Match</li> <li>Not Contains</li> <li>Response SLA</li> <li>Script Assertion</li> <li>Valid HTTP Status Codes</li> <li>XPath Match</li> <li>XQuery Match</li> </ul>
        /// </summary>
        /// <value>Assertion type. Possible values: <ul><li>AssertionStruct</li>  <li>Contains</li> <li>Invalid HTTP Status Codes</li> <li>JDBC Status</li> <li>JDBC Timeout</li> <li>JsonPath Count</li> <li>JsonPath Match</li> <li>Not Contains</li> <li>Response SLA</li> <li>Script Assertion</li> <li>Valid HTTP Status Codes</li> <li>XPath Match</li> <li>XQuery Match</li> </ul></value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
  
        
        /// <summary>
        /// Specifies if the search is case-sensitive (false) or not (true). Ignored, if you search with a regular expressions.
        /// </summary>
        /// <value>Specifies if the search is case-sensitive (false) or not (true). Ignored, if you search with a regular expressions.</value>
        [DataMember(Name="ignoreCase", EmitDefaultValue=false)]
        public bool? IgnoreCase { get; set; }
  
        
        /// <summary>
        /// The sought-for text or regular expression.
        /// </summary>
        /// <value>The sought-for text or regular expression.</value>
        [DataMember(Name="token", EmitDefaultValue=false)]
        public string Token { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SimpleContainsAssertion {\n");
            sb.Append("  UseRegexp: ").Append(UseRegexp).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  IgnoreCase: ").Append(IgnoreCase).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            
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
            return this.Equals(obj as SimpleContainsAssertion);
        }

        /// <summary>
        /// Returns true if SimpleContainsAssertion instances are equal
        /// </summary>
        /// <param name="other">Instance of SimpleContainsAssertion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SimpleContainsAssertion other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.UseRegexp == other.UseRegexp ||
                    this.UseRegexp != null &&
                    this.UseRegexp.Equals(other.UseRegexp)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.IgnoreCase == other.IgnoreCase ||
                    this.IgnoreCase != null &&
                    this.IgnoreCase.Equals(other.IgnoreCase)
                ) && 
                (
                    this.Token == other.Token ||
                    this.Token != null &&
                    this.Token.Equals(other.Token)
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
                
                if (this.UseRegexp != null)
                    hash = hash * 59 + this.UseRegexp.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                if (this.IgnoreCase != null)
                    hash = hash * 59 + this.IgnoreCase.GetHashCode();
                
                if (this.Token != null)
                    hash = hash * 59 + this.Token.GetHashCode();
                
                return hash;
            }
        }

    }
}
