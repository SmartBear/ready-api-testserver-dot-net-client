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
    /// Data structure for specifying the target of the property transfer.
    /// </summary>
    [DataContract]
    public partial class PropertyTransferTarget :  IEquatable<PropertyTransferTarget>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyTransferTarget" /> class.
        /// </summary>
        public PropertyTransferTarget()
        {
            
        }

        
        /// <summary>
        /// The full name of the target test step.
        /// </summary>
        /// <value>The full name of the target test step.</value>
        [DataMember(Name="targetName", EmitDefaultValue=false)]
        public string TargetName { get; set; }
  
        
        /// <summary>
        /// Property name to transfer the values to.
        /// </summary>
        /// <value>Property name to transfer the values to.</value>
        [DataMember(Name="property", EmitDefaultValue=false)]
        public string Property { get; set; }
  
        
        /// <summary>
        /// The language used to specify the path expression. Possible values: <ul><li>XPath</li><li>XQuery</li><li>JSONPath</li></ul>
        /// </summary>
        /// <value>The language used to specify the path expression. Possible values: <ul><li>XPath</li><li>XQuery</li><li>JSONPath</li></ul></value>
        [DataMember(Name="pathLanguage", EmitDefaultValue=false)]
        public string PathLanguage { get; set; }
  
        
        /// <summary>
        /// The expression in the specified language that specifies the exact element to which the data is be written.
        /// </summary>
        /// <value>The expression in the specified language that specifies the exact element to which the data is be written.</value>
        [DataMember(Name="path", EmitDefaultValue=false)]
        public string Path { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PropertyTransferTarget {\n");
            sb.Append("  TargetName: ").Append(TargetName).Append("\n");
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
            return this.Equals(obj as PropertyTransferTarget);
        }

        /// <summary>
        /// Returns true if PropertyTransferTarget instances are equal
        /// </summary>
        /// <param name="other">Instance of PropertyTransferTarget to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PropertyTransferTarget other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TargetName == other.TargetName ||
                    this.TargetName != null &&
                    this.TargetName.Equals(other.TargetName)
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
                
                if (this.TargetName != null)
                    hash = hash * 59 + this.TargetName.GetHashCode();
                
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
