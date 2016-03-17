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
    /// Data structure for specifying a &lt;a href=\&quot;http://readyapi.smartbear.com/structure/steps/data/source/start\&quot;&gt;DataSource&lt;/a&gt;.
    /// </summary>
    [DataContract]
    public partial class DataSource :  IEquatable<DataSource>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataSource" /> class.
        /// </summary>
        public DataSource()
        {
            
        }

        
        /// <summary>
        /// The array of properties used to store retrieved data.
        /// </summary>
        /// <value>The array of properties used to store retrieved data.</value>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public List<string> Properties { get; set; }
  
        
        /// <summary>
        /// Data structure for <a href=\"http://readyapi.smartbear.com/structure/sources/grid/start\">Grid Data Source</a>.
        /// </summary>
        /// <value>Data structure for <a href=\"http://readyapi.smartbear.com/structure/sources/grid/start\">Grid Data Source</a>.</value>
        [DataMember(Name="grid", EmitDefaultValue=false)]
        public Dictionary<string, List<string>> Grid { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Excel
        /// </summary>
        [DataMember(Name="excel", EmitDefaultValue=false)]
        public ExcelDataSource Excel { get; set; }
  
        
        /// <summary>
        /// Gets or Sets File
        /// </summary>
        [DataMember(Name="file", EmitDefaultValue=false)]
        public FileDataSource File { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DataSource {\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  Grid: ").Append(Grid).Append("\n");
            sb.Append("  Excel: ").Append(Excel).Append("\n");
            sb.Append("  File: ").Append(File).Append("\n");
            
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
            return this.Equals(obj as DataSource);
        }

        /// <summary>
        /// Returns true if DataSource instances are equal
        /// </summary>
        /// <param name="other">Instance of DataSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataSource other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Properties == other.Properties ||
                    this.Properties != null &&
                    this.Properties.SequenceEqual(other.Properties)
                ) && 
                (
                    this.Grid == other.Grid ||
                    this.Grid != null &&
                    this.Grid.SequenceEqual(other.Grid)
                ) && 
                (
                    this.Excel == other.Excel ||
                    this.Excel != null &&
                    this.Excel.Equals(other.Excel)
                ) && 
                (
                    this.File == other.File ||
                    this.File != null &&
                    this.File.Equals(other.File)
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
                
                if (this.Properties != null)
                    hash = hash * 59 + this.Properties.GetHashCode();
                
                if (this.Grid != null)
                    hash = hash * 59 + this.Grid.GetHashCode();
                
                if (this.Excel != null)
                    hash = hash * 59 + this.Excel.GetHashCode();
                
                if (this.File != null)
                    hash = hash * 59 + this.File.GetHashCode();
                
                return hash;
            }
        }

    }
}
