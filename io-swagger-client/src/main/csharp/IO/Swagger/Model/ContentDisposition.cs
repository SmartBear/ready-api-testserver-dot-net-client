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
    public partial class ContentDisposition :  IEquatable<ContentDisposition>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentDisposition" /> class.
        /// </summary>
        public ContentDisposition()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Parameters
        /// </summary>
        [DataMember(Name="parameters", EmitDefaultValue=false)]
        public Dictionary<string, string> Parameters { get; set; }
  
        
        /// <summary>
        /// Gets or Sets FileName
        /// </summary>
        [DataMember(Name="fileName", EmitDefaultValue=false)]
        public string FileName { get; set; }
  
        
        /// <summary>
        /// Gets or Sets CreationDate
        /// </summary>
        [DataMember(Name="creationDate", EmitDefaultValue=false)]
        public DateTime? CreationDate { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ModificationDate
        /// </summary>
        [DataMember(Name="modificationDate", EmitDefaultValue=false)]
        public DateTime? ModificationDate { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ReadDate
        /// </summary>
        [DataMember(Name="readDate", EmitDefaultValue=false)]
        public DateTime? ReadDate { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public long? Size { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContentDisposition {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
            sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  ModificationDate: ").Append(ModificationDate).Append("\n");
            sb.Append("  ReadDate: ").Append(ReadDate).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            
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
            return this.Equals(obj as ContentDisposition);
        }

        /// <summary>
        /// Returns true if ContentDisposition instances are equal
        /// </summary>
        /// <param name="other">Instance of ContentDisposition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContentDisposition other)
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
                    this.Parameters == other.Parameters ||
                    this.Parameters != null &&
                    this.Parameters.SequenceEqual(other.Parameters)
                ) && 
                (
                    this.FileName == other.FileName ||
                    this.FileName != null &&
                    this.FileName.Equals(other.FileName)
                ) && 
                (
                    this.CreationDate == other.CreationDate ||
                    this.CreationDate != null &&
                    this.CreationDate.Equals(other.CreationDate)
                ) && 
                (
                    this.ModificationDate == other.ModificationDate ||
                    this.ModificationDate != null &&
                    this.ModificationDate.Equals(other.ModificationDate)
                ) && 
                (
                    this.ReadDate == other.ReadDate ||
                    this.ReadDate != null &&
                    this.ReadDate.Equals(other.ReadDate)
                ) && 
                (
                    this.Size == other.Size ||
                    this.Size != null &&
                    this.Size.Equals(other.Size)
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
                
                if (this.Parameters != null)
                    hash = hash * 59 + this.Parameters.GetHashCode();
                
                if (this.FileName != null)
                    hash = hash * 59 + this.FileName.GetHashCode();
                
                if (this.CreationDate != null)
                    hash = hash * 59 + this.CreationDate.GetHashCode();
                
                if (this.ModificationDate != null)
                    hash = hash * 59 + this.ModificationDate.GetHashCode();
                
                if (this.ReadDate != null)
                    hash = hash * 59 + this.ReadDate.GetHashCode();
                
                if (this.Size != null)
                    hash = hash * 59 + this.Size.GetHashCode();
                
                return hash;
            }
        }

    }
}
