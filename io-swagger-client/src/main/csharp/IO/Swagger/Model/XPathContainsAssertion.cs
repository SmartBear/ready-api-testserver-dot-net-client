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
    public partial class XPathContainsAssertion : Assertion,  IEquatable<XPathContainsAssertion>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XPathContainsAssertion" /> class.
        /// </summary>
        public XPathContainsAssertion()
        {
            this.AllowWildcards = false;
            this.IgnoreComments = false;
            this.IgnoreNamespaces = false;
            
        }

        
        /// <summary>
        /// XPath expression used to select content from the test step results.
        /// </summary>
        /// <value>XPath expression used to select content from the test step results.</value>
        [DataMember(Name="xpath", EmitDefaultValue=false)]
        public string Xpath { get; set; }
  
        
        /// <summary>
        /// Treat <code>*</code> as wildcard in a match.
        /// </summary>
        /// <value>Treat <code>*</code> as wildcard in a match.</value>
        [DataMember(Name="allowWildcards", EmitDefaultValue=false)]
        public bool? AllowWildcards { get; set; }
  
        
        /// <summary>
        /// Skip XML comments when matching.
        /// </summary>
        /// <value>Skip XML comments when matching.</value>
        [DataMember(Name="ignoreComments", EmitDefaultValue=false)]
        public bool? IgnoreComments { get; set; }
  
        
        /// <summary>
        /// Assertion type. Possible values: <ul><li>AssertionStruct</li>  <li>Contains</li> <li>Invalid HTTP Status Codes</li> <li>JDBC Status</li> <li>JDBC Timeout</li> <li>JsonPath Count</li> <li>JsonPath Match</li> <li>Not Contains</li> <li>Response SLA</li> <li>Script Assertion</li> <li>Valid HTTP Status Codes</li> <li>XPath Match</li> <li>XQuery Match</li> </ul>
        /// </summary>
        /// <value>Assertion type. Possible values: <ul><li>AssertionStruct</li>  <li>Contains</li> <li>Invalid HTTP Status Codes</li> <li>JDBC Status</li> <li>JDBC Timeout</li> <li>JsonPath Count</li> <li>JsonPath Match</li> <li>Not Contains</li> <li>Response SLA</li> <li>Script Assertion</li> <li>Valid HTTP Status Codes</li> <li>XPath Match</li> <li>XQuery Match</li> </ul></value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
  
        
        /// <summary>
        /// Match in all namespaces.
        /// </summary>
        /// <value>Match in all namespaces.</value>
        [DataMember(Name="ignoreNamespaces", EmitDefaultValue=false)]
        public bool? IgnoreNamespaces { get; set; }
  
        
        /// <summary>
        /// Expected match results.
        /// </summary>
        /// <value>Expected match results.</value>
        [DataMember(Name="expectedContent", EmitDefaultValue=false)]
        public string ExpectedContent { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class XPathContainsAssertion {\n");
            sb.Append("  Xpath: ").Append(Xpath).Append("\n");
            sb.Append("  AllowWildcards: ").Append(AllowWildcards).Append("\n");
            sb.Append("  IgnoreComments: ").Append(IgnoreComments).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  IgnoreNamespaces: ").Append(IgnoreNamespaces).Append("\n");
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
            return this.Equals(obj as XPathContainsAssertion);
        }

        /// <summary>
        /// Returns true if XPathContainsAssertion instances are equal
        /// </summary>
        /// <param name="other">Instance of XPathContainsAssertion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(XPathContainsAssertion other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Xpath == other.Xpath ||
                    this.Xpath != null &&
                    this.Xpath.Equals(other.Xpath)
                ) && 
                (
                    this.AllowWildcards == other.AllowWildcards ||
                    this.AllowWildcards != null &&
                    this.AllowWildcards.Equals(other.AllowWildcards)
                ) && 
                (
                    this.IgnoreComments == other.IgnoreComments ||
                    this.IgnoreComments != null &&
                    this.IgnoreComments.Equals(other.IgnoreComments)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.IgnoreNamespaces == other.IgnoreNamespaces ||
                    this.IgnoreNamespaces != null &&
                    this.IgnoreNamespaces.Equals(other.IgnoreNamespaces)
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
                
                if (this.Xpath != null)
                    hash = hash * 59 + this.Xpath.GetHashCode();
                
                if (this.AllowWildcards != null)
                    hash = hash * 59 + this.AllowWildcards.GetHashCode();
                
                if (this.IgnoreComments != null)
                    hash = hash * 59 + this.IgnoreComments.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                if (this.IgnoreNamespaces != null)
                    hash = hash * 59 + this.IgnoreNamespaces.GetHashCode();
                
                if (this.ExpectedContent != null)
                    hash = hash * 59 + this.ExpectedContent.GetHashCode();
                
                return hash;
            }
        }

    }
}
