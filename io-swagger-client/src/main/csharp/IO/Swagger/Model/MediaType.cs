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
    public partial class MediaType :  IEquatable<MediaType>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaType" /> class.
        /// </summary>
        public MediaType()
        {
            this.WildcardType = false;
            this.WildcardSubtype = false;
            
        }

        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Subtype
        /// </summary>
        [DataMember(Name="subtype", EmitDefaultValue=false)]
        public string Subtype { get; set; }
  
        
        /// <summary>
        /// Request parameters.
        /// </summary>
        /// <value>Request parameters.</value>
        [DataMember(Name="parameters", EmitDefaultValue=false)]
        public Dictionary<string, string> Parameters { get; set; }
  
        
        /// <summary>
        /// Gets or Sets WildcardType
        /// </summary>
        [DataMember(Name="wildcardType", EmitDefaultValue=false)]
        public bool? WildcardType { get; set; }
  
        
        /// <summary>
        /// Gets or Sets WildcardSubtype
        /// </summary>
        [DataMember(Name="wildcardSubtype", EmitDefaultValue=false)]
        public bool? WildcardSubtype { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MediaType {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Subtype: ").Append(Subtype).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("  WildcardType: ").Append(WildcardType).Append("\n");
            sb.Append("  WildcardSubtype: ").Append(WildcardSubtype).Append("\n");
            
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
            return this.Equals(obj as MediaType);
        }

        /// <summary>
        /// Returns true if MediaType instances are equal
        /// </summary>
        /// <param name="other">Instance of MediaType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MediaType other)
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
                    this.Subtype == other.Subtype ||
                    this.Subtype != null &&
                    this.Subtype.Equals(other.Subtype)
                ) && 
                (
                    this.Parameters == other.Parameters ||
                    this.Parameters != null &&
                    this.Parameters.SequenceEqual(other.Parameters)
                ) && 
                (
                    this.WildcardType == other.WildcardType ||
                    this.WildcardType != null &&
                    this.WildcardType.Equals(other.WildcardType)
                ) && 
                (
                    this.WildcardSubtype == other.WildcardSubtype ||
                    this.WildcardSubtype != null &&
                    this.WildcardSubtype.Equals(other.WildcardSubtype)
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
                
                if (this.Subtype != null)
                    hash = hash * 59 + this.Subtype.GetHashCode();
                
                if (this.Parameters != null)
                    hash = hash * 59 + this.Parameters.GetHashCode();
                
                if (this.WildcardType != null)
                    hash = hash * 59 + this.WildcardType.GetHashCode();
                
                if (this.WildcardSubtype != null)
                    hash = hash * 59 + this.WildcardSubtype.GetHashCode();
                
                return hash;
            }
        }

    }
}
