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
    public partial class ValidHttpStatusCodesAssertion : Assertion,  IEquatable<ValidHttpStatusCodesAssertion>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidHttpStatusCodesAssertion" /> class.
        /// </summary>
        public ValidHttpStatusCodesAssertion()
        {
            
        }

        
        /// <summary>
        /// Assertion type. Possible values: <ul><li>AssertionStruct</li>  <li>Contains</li> <li>Invalid HTTP Status Codes</li> <li>JDBC Status</li> <li>JDBC Timeout</li> <li>JsonPath Count</li> <li>JsonPath Match</li> <li>Not Contains</li> <li>Response SLA</li> <li>Script Assertion</li> <li>Valid HTTP Status Codes</li> <li>XPath Match</li> <li>XQuery Match</li> </ul>
        /// </summary>
        /// <value>Assertion type. Possible values: <ul><li>AssertionStruct</li>  <li>Contains</li> <li>Invalid HTTP Status Codes</li> <li>JDBC Status</li> <li>JDBC Timeout</li> <li>JsonPath Count</li> <li>JsonPath Match</li> <li>Not Contains</li> <li>Response SLA</li> <li>Script Assertion</li> <li>Valid HTTP Status Codes</li> <li>XPath Match</li> <li>XQuery Match</li> </ul></value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
  
        
        /// <summary>
        /// An array of HTTP status codes which the assertion considers valid.
        /// </summary>
        /// <value>An array of HTTP status codes which the assertion considers valid.</value>
        [DataMember(Name="validStatusCodes", EmitDefaultValue=false)]
        public List<int?> ValidStatusCodes { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ValidHttpStatusCodesAssertion {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ValidStatusCodes: ").Append(ValidStatusCodes).Append("\n");
            
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
            return this.Equals(obj as ValidHttpStatusCodesAssertion);
        }

        /// <summary>
        /// Returns true if ValidHttpStatusCodesAssertion instances are equal
        /// </summary>
        /// <param name="other">Instance of ValidHttpStatusCodesAssertion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ValidHttpStatusCodesAssertion other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.ValidStatusCodes == other.ValidStatusCodes ||
                    this.ValidStatusCodes != null &&
                    this.ValidStatusCodes.SequenceEqual(other.ValidStatusCodes)
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
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                if (this.ValidStatusCodes != null)
                    hash = hash * 59 + this.ValidStatusCodes.GetHashCode();
                
                return hash;
            }
        }

    }
}
