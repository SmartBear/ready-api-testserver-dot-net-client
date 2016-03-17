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
    public partial class PropertyTransferTestStep : TestStep,  IEquatable<PropertyTransferTestStep>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyTransferTestStep" /> class.
        /// </summary>
        public PropertyTransferTestStep()
        {
            
        }

        
        /// <summary>
        /// Test step type. Possible values: <ul><li>DataSource</li><li>Groovy</li><li>JDBC Request</li><li>Property Transfer</li><li>REST Request</li><li>TestStepStruct</li></ul>
        /// </summary>
        /// <value>Test step type. Possible values: <ul><li>DataSource</li><li>Groovy</li><li>JDBC Request</li><li>Property Transfer</li><li>REST Request</li><li>TestStepStruct</li></ul></value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
  
        
        /// <summary>
        /// Test step name. This name is used to refer to the test step in the test recipe.
        /// </summary>
        /// <value>Test step name. This name is used to refer to the test step in the test recipe.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Transfers
        /// </summary>
        [DataMember(Name="transfers", EmitDefaultValue=false)]
        public List<PropertyTransfer> Transfers { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PropertyTransferTestStep {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Transfers: ").Append(Transfers).Append("\n");
            
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
            return this.Equals(obj as PropertyTransferTestStep);
        }

        /// <summary>
        /// Returns true if PropertyTransferTestStep instances are equal
        /// </summary>
        /// <param name="other">Instance of PropertyTransferTestStep to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PropertyTransferTestStep other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Transfers == other.Transfers ||
                    this.Transfers != null &&
                    this.Transfers.SequenceEqual(other.Transfers)
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
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Transfers != null)
                    hash = hash * 59 + this.Transfers.GetHashCode();
                
                return hash;
            }
        }

    }
}
