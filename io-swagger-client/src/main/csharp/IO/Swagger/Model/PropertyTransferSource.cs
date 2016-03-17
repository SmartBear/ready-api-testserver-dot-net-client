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
    /// Data structure for specifying the source of the property transfer.
    /// </summary>
    [DataContract]
    public partial class PropertyTransferSource :  IEquatable<PropertyTransferSource>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyTransferSource" /> class.
        /// </summary>
        public PropertyTransferSource()
        {
            
        }

        
        /// <summary>
        /// The full name of the source test step.
        /// </summary>
        /// <value>The full name of the source test step.</value>
        [DataMember(Name="sourceName", EmitDefaultValue=false)]
        public string SourceName { get; set; }
  
        
        /// <summary>
        /// Property name to get the values from.
        /// </summary>
        /// <value>Property name to get the values from.</value>
        [DataMember(Name="property", EmitDefaultValue=false)]
        public string Property { get; set; }
  
        
        /// <summary>
        /// The language used to specify the path expression. Possible values: <ul><li>XPath</li><li>XQuery</li><li>JSONPath</li></ul>
        /// </summary>
        /// <value>The language used to specify the path expression. Possible values: <ul><li>XPath</li><li>XQuery</li><li>JSONPath</li></ul></value>
        [DataMember(Name="pathLanguage", EmitDefaultValue=false)]
        public string PathLanguage { get; set; }
  
        
        /// <summary>
        /// The expression in the specified language that specifies the exact element from which the data source gets the data.
        /// </summary>
        /// <value>The expression in the specified language that specifies the exact element from which the data source gets the data.</value>
        [DataMember(Name="path", EmitDefaultValue=false)]
        public string Path { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PropertyTransferSource {\n");
            sb.Append("  SourceName: ").Append(SourceName).Append("\n");
            sb.Append("  Property: ").Append(Property).Append("\n");
            sb.Append("  PathLanguage: ").Append(PathLanguage).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(obj as PropertyTransferSource);
        }

        /// <summary>
        /// Returns true if PropertyTransferSource instances are equal
        /// </summary>
        /// <param name="other">Instance of PropertyTransferSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PropertyTransferSource other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SourceName == other.SourceName ||
                    this.SourceName != null &&
                    this.SourceName.Equals(other.SourceName)
                ) && 
                (
                    this.Property == other.Property ||
                    this.Property != null &&
                    this.Property.Equals(other.Property)
                ) && 
                (
                    this.PathLanguage == other.PathLanguage ||
                    this.PathLanguage != null &&
                    this.PathLanguage.Equals(other.PathLanguage)
                ) && 
                (
                    this.Path == other.Path ||
                    this.Path != null &&
                    this.Path.Equals(other.Path)
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
                
                if (this.SourceName != null)
                    hash = hash * 59 + this.SourceName.GetHashCode();
                
                if (this.Property != null)
                    hash = hash * 59 + this.Property.GetHashCode();
                
                if (this.PathLanguage != null)
                    hash = hash * 59 + this.PathLanguage.GetHashCode();
                
                if (this.Path != null)
                    hash = hash * 59 + this.Path.GetHashCode();
                
                return hash;
            }
        }

    }
}
