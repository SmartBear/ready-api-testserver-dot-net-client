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
    /// Data structure for &lt;a herf=\&quot;http://readyapi.smartbear.com/structure/sources/excel/introduction\&quot;&gt;Excel Data Source&lt;/a&gt;.
    /// </summary>
    [DataContract]
    public partial class ExcelDataSource :  IEquatable<ExcelDataSource>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExcelDataSource" /> class.
        /// </summary>
        public ExcelDataSource()
        {
            this.IgnoreEmpty = false;
            
        }

        
        /// <summary>
        /// The name of the file used for the data source.
        /// </summary>
        /// <value>The name of the file used for the data source.</value>
        [DataMember(Name="filePath", EmitDefaultValue=false)]
        public string FilePath { get; set; }
  
        
        /// <summary>
        /// The name of the excel worksheet the test step gets data from.
        /// </summary>
        /// <value>The name of the excel worksheet the test step gets data from.</value>
        [DataMember(Name="worksheet", EmitDefaultValue=false)]
        public string Worksheet { get; set; }
  
        
        /// <summary>
        /// The cell from which the iterator starts gathering data.
        /// </summary>
        /// <value>The cell from which the iterator starts gathering data.</value>
        [DataMember(Name="startAtCell", EmitDefaultValue=false)]
        public string StartAtCell { get; set; }
  
        
        /// <summary>
        /// If <code>true</code>, skips rows without data.
        /// </summary>
        /// <value>If <code>true</code>, skips rows without data.</value>
        [DataMember(Name="ignoreEmpty", EmitDefaultValue=false)]
        public bool? IgnoreEmpty { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExcelDataSource {\n");
            sb.Append("  FilePath: ").Append(FilePath).Append("\n");
            sb.Append("  Worksheet: ").Append(Worksheet).Append("\n");
            sb.Append("  StartAtCell: ").Append(StartAtCell).Append("\n");
            sb.Append("  IgnoreEmpty: ").Append(IgnoreEmpty).Append("\n");
            
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
            return this.Equals(obj as ExcelDataSource);
        }

        /// <summary>
        /// Returns true if ExcelDataSource instances are equal
        /// </summary>
        /// <param name="other">Instance of ExcelDataSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExcelDataSource other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FilePath == other.FilePath ||
                    this.FilePath != null &&
                    this.FilePath.Equals(other.FilePath)
                ) && 
                (
                    this.Worksheet == other.Worksheet ||
                    this.Worksheet != null &&
                    this.Worksheet.Equals(other.Worksheet)
                ) && 
                (
                    this.StartAtCell == other.StartAtCell ||
                    this.StartAtCell != null &&
                    this.StartAtCell.Equals(other.StartAtCell)
                ) && 
                (
                    this.IgnoreEmpty == other.IgnoreEmpty ||
                    this.IgnoreEmpty != null &&
                    this.IgnoreEmpty.Equals(other.IgnoreEmpty)
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
                
                if (this.FilePath != null)
                    hash = hash * 59 + this.FilePath.GetHashCode();
                
                if (this.Worksheet != null)
                    hash = hash * 59 + this.Worksheet.GetHashCode();
                
                if (this.StartAtCell != null)
                    hash = hash * 59 + this.StartAtCell.GetHashCode();
                
                if (this.IgnoreEmpty != null)
                    hash = hash * 59 + this.IgnoreEmpty.GetHashCode();
                
                return hash;
            }
        }

    }
}
