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
    /// Data structure for the &lt;a herf=\&quot;http://readyapi.smartbear.com/structure/steps/property/transfer/intro/step\&quot;&gt;Property Transfer&lt;/a&gt; test step.
    /// </summary>
    [DataContract]
    public partial class PropertyTransfer :  IEquatable<PropertyTransfer>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyTransfer" /> class.
        /// </summary>
        public PropertyTransfer()
        {
            this.FailTransferOnError = false;
            this.SetNullOnMissingSource = false;
            this.TransferTextContent = false;
            this.IgnoreEmptyValue = false;
            this.TransferToAll = false;
            this.TransferChildNodes = false;
            this.EntitizeTransferredValues = false;
            
        }

        
        /// <summary>
        /// The name of the property transfer test step.
        /// </summary>
        /// <value>The name of the property transfer test step.</value>
        [DataMember(Name="transferName", EmitDefaultValue=false)]
        public string TransferName { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public PropertyTransferSource Source { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Target
        /// </summary>
        [DataMember(Name="target", EmitDefaultValue=false)]
        public PropertyTransferTarget Target { get; set; }
  
        
        /// <summary>
        /// If <code>true</code>, the property transfer test step fails when an error occurs.
        /// </summary>
        /// <value>If <code>true</code>, the property transfer test step fails when an error occurs.</value>
        [DataMember(Name="failTransferOnError", EmitDefaultValue=false)]
        public bool? FailTransferOnError { get; set; }
  
        
        /// <summary>
        /// If <code>true</code>, sets target to <code>null</code> if the source is missing.
        /// </summary>
        /// <value>If <code>true</code>, sets target to <code>null</code> if the source is missing.</value>
        [DataMember(Name="setNullOnMissingSource", EmitDefaultValue=false)]
        public bool? SetNullOnMissingSource { get; set; }
  
        
        /// <summary>
        /// If <code>true</code>, only transfers text content.
        /// </summary>
        /// <value>If <code>true</code>, only transfers text content.</value>
        [DataMember(Name="transferTextContent", EmitDefaultValue=false)]
        public bool? TransferTextContent { get; set; }
  
        
        /// <summary>
        /// If <code>true</code>, does not transfer empty or missing values.
        /// </summary>
        /// <value>If <code>true</code>, does not transfer empty or missing values.</value>
        [DataMember(Name="ignoreEmptyValue", EmitDefaultValue=false)]
        public bool? IgnoreEmptyValue { get; set; }
  
        
        /// <summary>
        /// If <code>true</code>, transfers to all matching transfer selections.
        /// </summary>
        /// <value>If <code>true</code>, transfers to all matching transfer selections.</value>
        [DataMember(Name="transferToAll", EmitDefaultValue=false)]
        public bool? TransferToAll { get; set; }
  
        
        /// <summary>
        /// If <code>true</code>, transfers child nodes of the source node as children of the target node.
        /// </summary>
        /// <value>If <code>true</code>, transfers child nodes of the source node as children of the target node.</value>
        [DataMember(Name="transferChildNodes", EmitDefaultValue=false)]
        public bool? TransferChildNodes { get; set; }
  
        
        /// <summary>
        /// If <code>true</code>, all HTML symbols are replaced with appropriate entities.
        /// </summary>
        /// <value>If <code>true</code>, all HTML symbols are replaced with appropriate entities.</value>
        [DataMember(Name="entitizeTransferredValues", EmitDefaultValue=false)]
        public bool? EntitizeTransferredValues { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PropertyTransfer {\n");
            sb.Append("  TransferName: ").Append(TransferName).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Target: ").Append(Target).Append("\n");
            sb.Append("  FailTransferOnError: ").Append(FailTransferOnError).Append("\n");
            sb.Append("  SetNullOnMissingSource: ").Append(SetNullOnMissingSource).Append("\n");
            sb.Append("  TransferTextContent: ").Append(TransferTextContent).Append("\n");
            sb.Append("  IgnoreEmptyValue: ").Append(IgnoreEmptyValue).Append("\n");
            sb.Append("  TransferToAll: ").Append(TransferToAll).Append("\n");
            sb.Append("  TransferChildNodes: ").Append(TransferChildNodes).Append("\n");
            sb.Append("  EntitizeTransferredValues: ").Append(EntitizeTransferredValues).Append("\n");
            
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
            return this.Equals(obj as PropertyTransfer);
        }

        /// <summary>
        /// Returns true if PropertyTransfer instances are equal
        /// </summary>
        /// <param name="other">Instance of PropertyTransfer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PropertyTransfer other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TransferName == other.TransferName ||
                    this.TransferName != null &&
                    this.TransferName.Equals(other.TransferName)
                ) && 
                (
                    this.Source == other.Source ||
                    this.Source != null &&
                    this.Source.Equals(other.Source)
                ) && 
                (
                    this.Target == other.Target ||
                    this.Target != null &&
                    this.Target.Equals(other.Target)
                ) && 
                (
                    this.FailTransferOnError == other.FailTransferOnError ||
                    this.FailTransferOnError != null &&
                    this.FailTransferOnError.Equals(other.FailTransferOnError)
                ) && 
                (
                    this.SetNullOnMissingSource == other.SetNullOnMissingSource ||
                    this.SetNullOnMissingSource != null &&
                    this.SetNullOnMissingSource.Equals(other.SetNullOnMissingSource)
                ) && 
                (
                    this.TransferTextContent == other.TransferTextContent ||
                    this.TransferTextContent != null &&
                    this.TransferTextContent.Equals(other.TransferTextContent)
                ) && 
                (
                    this.IgnoreEmptyValue == other.IgnoreEmptyValue ||
                    this.IgnoreEmptyValue != null &&
                    this.IgnoreEmptyValue.Equals(other.IgnoreEmptyValue)
                ) && 
                (
                    this.TransferToAll == other.TransferToAll ||
                    this.TransferToAll != null &&
                    this.TransferToAll.Equals(other.TransferToAll)
                ) && 
                (
                    this.TransferChildNodes == other.TransferChildNodes ||
                    this.TransferChildNodes != null &&
                    this.TransferChildNodes.Equals(other.TransferChildNodes)
                ) && 
                (
                    this.EntitizeTransferredValues == other.EntitizeTransferredValues ||
                    this.EntitizeTransferredValues != null &&
                    this.EntitizeTransferredValues.Equals(other.EntitizeTransferredValues)
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
                
                if (this.TransferName != null)
                    hash = hash * 59 + this.TransferName.GetHashCode();
                
                if (this.Source != null)
                    hash = hash * 59 + this.Source.GetHashCode();
                
                if (this.Target != null)
                    hash = hash * 59 + this.Target.GetHashCode();
                
                if (this.FailTransferOnError != null)
                    hash = hash * 59 + this.FailTransferOnError.GetHashCode();
                
                if (this.SetNullOnMissingSource != null)
                    hash = hash * 59 + this.SetNullOnMissingSource.GetHashCode();
                
                if (this.TransferTextContent != null)
                    hash = hash * 59 + this.TransferTextContent.GetHashCode();
                
                if (this.IgnoreEmptyValue != null)
                    hash = hash * 59 + this.IgnoreEmptyValue.GetHashCode();
                
                if (this.TransferToAll != null)
                    hash = hash * 59 + this.TransferToAll.GetHashCode();
                
                if (this.TransferChildNodes != null)
                    hash = hash * 59 + this.TransferChildNodes.GetHashCode();
                
                if (this.EntitizeTransferredValues != null)
                    hash = hash * 59 + this.EntitizeTransferredValues.GetHashCode();
                
                return hash;
            }
        }

    }
}
