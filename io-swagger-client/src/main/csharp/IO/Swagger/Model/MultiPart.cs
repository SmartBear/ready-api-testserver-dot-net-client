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
    public partial class MultiPart :  IEquatable<MultiPart>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MultiPart" /> class.
        /// </summary>
        public MultiPart()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets ContentDisposition
        /// </summary>
        [DataMember(Name="contentDisposition", EmitDefaultValue=false)]
        public ContentDisposition ContentDisposition { get; set; }
  
        
        /// <summary>
        /// Entity items.
        /// </summary>
        /// <value>Entity items.</value>
        [DataMember(Name="entity", EmitDefaultValue=false)]
        public Object Entity { get; set; }
  
        
        /// <summary>
        /// Headers array.
        /// </summary>
        /// <value>Headers array.</value>
        [DataMember(Name="headers", EmitDefaultValue=false)]
        public Dictionary<string, List<string>> Headers { get; set; }
  
        
        /// <summary>
        /// Gets or Sets MediaType
        /// </summary>
        [DataMember(Name="mediaType", EmitDefaultValue=false)]
        public MediaType MediaType { get; set; }
  
        
        /// <summary>
        /// Gets or Sets MessageBodyWorkers
        /// </summary>
        [DataMember(Name="messageBodyWorkers", EmitDefaultValue=false)]
        public MessageBodyWorkers MessageBodyWorkers { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Parent
        /// </summary>
        [DataMember(Name="parent", EmitDefaultValue=false)]
        public MultiPart Parent { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Providers
        /// </summary>
        [DataMember(Name="providers", EmitDefaultValue=false)]
        public Providers Providers { get; set; }
  
        
        /// <summary>
        /// Gets or Sets BodyParts
        /// </summary>
        [DataMember(Name="bodyParts", EmitDefaultValue=false)]
        public List<BodyPart> BodyParts { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ParameterizedHeaders
        /// </summary>
        [DataMember(Name="parameterizedHeaders", EmitDefaultValue=false)]
        public Dictionary<string, List<ParameterizedHeader>> ParameterizedHeaders { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MultiPart {\n");
            sb.Append("  ContentDisposition: ").Append(ContentDisposition).Append("\n");
            sb.Append("  Entity: ").Append(Entity).Append("\n");
            sb.Append("  Headers: ").Append(Headers).Append("\n");
            sb.Append("  MediaType: ").Append(MediaType).Append("\n");
            sb.Append("  MessageBodyWorkers: ").Append(MessageBodyWorkers).Append("\n");
            sb.Append("  Parent: ").Append(Parent).Append("\n");
            sb.Append("  Providers: ").Append(Providers).Append("\n");
            sb.Append("  BodyParts: ").Append(BodyParts).Append("\n");
            sb.Append("  ParameterizedHeaders: ").Append(ParameterizedHeaders).Append("\n");
            
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
            return this.Equals(obj as MultiPart);
        }

        /// <summary>
        /// Returns true if MultiPart instances are equal
        /// </summary>
        /// <param name="other">Instance of MultiPart to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MultiPart other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ContentDisposition == other.ContentDisposition ||
                    this.ContentDisposition != null &&
                    this.ContentDisposition.Equals(other.ContentDisposition)
                ) && 
                (
                    this.Entity == other.Entity ||
                    this.Entity != null &&
                    this.Entity.Equals(other.Entity)
                ) && 
                (
                    this.Headers == other.Headers ||
                    this.Headers != null &&
                    this.Headers.SequenceEqual(other.Headers)
                ) && 
                (
                    this.MediaType == other.MediaType ||
                    this.MediaType != null &&
                    this.MediaType.Equals(other.MediaType)
                ) && 
                (
                    this.MessageBodyWorkers == other.MessageBodyWorkers ||
                    this.MessageBodyWorkers != null &&
                    this.MessageBodyWorkers.Equals(other.MessageBodyWorkers)
                ) && 
                (
                    this.Parent == other.Parent ||
                    this.Parent != null &&
                    this.Parent.Equals(other.Parent)
                ) && 
                (
                    this.Providers == other.Providers ||
                    this.Providers != null &&
                    this.Providers.Equals(other.Providers)
                ) && 
                (
                    this.BodyParts == other.BodyParts ||
                    this.BodyParts != null &&
                    this.BodyParts.SequenceEqual(other.BodyParts)
                ) && 
                (
                    this.ParameterizedHeaders == other.ParameterizedHeaders ||
                    this.ParameterizedHeaders != null &&
                    this.ParameterizedHeaders.SequenceEqual(other.ParameterizedHeaders)
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
                
                if (this.ContentDisposition != null)
                    hash = hash * 59 + this.ContentDisposition.GetHashCode();
                
                if (this.Entity != null)
                    hash = hash * 59 + this.Entity.GetHashCode();
                
                if (this.Headers != null)
                    hash = hash * 59 + this.Headers.GetHashCode();
                
                if (this.MediaType != null)
                    hash = hash * 59 + this.MediaType.GetHashCode();
                
                if (this.MessageBodyWorkers != null)
                    hash = hash * 59 + this.MessageBodyWorkers.GetHashCode();
                
                if (this.Parent != null)
                    hash = hash * 59 + this.Parent.GetHashCode();
                
                if (this.Providers != null)
                    hash = hash * 59 + this.Providers.GetHashCode();
                
                if (this.BodyParts != null)
                    hash = hash * 59 + this.BodyParts.GetHashCode();
                
                if (this.ParameterizedHeaders != null)
                    hash = hash * 59 + this.ParameterizedHeaders.GetHashCode();
                
                return hash;
            }
        }

    }
}
