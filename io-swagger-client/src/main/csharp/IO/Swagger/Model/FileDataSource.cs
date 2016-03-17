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
    /// Data structure for specifying &lt;a href=\&quot;http://readyapi.smartbear.com/structure/sources/file/introduction\&quot;&gt;File Data Source&lt;/a&gt; test step.
    /// </summary>
    [DataContract]
    public partial class FileDataSource :  IEquatable<FileDataSource>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileDataSource" /> class.
        /// </summary>
        public FileDataSource()
        {
            this.Trim = false;
            this.QuotedValues = false;
            
        }

        
        /// <summary>
        /// The name of the file used for the data source.
        /// </summary>
        /// <value>The name of the file used for the data source.</value>
        [DataMember(Name="filePath", EmitDefaultValue=false)]
        public string FilePath { get; set; }
  
        
        /// <summary>
        /// Character set used in the data file.
        /// </summary>
        /// <value>Character set used in the data file.</value>
        [DataMember(Name="charset", EmitDefaultValue=false)]
        public string Charset { get; set; }
  
        
        /// <summary>
        /// Character used in the file to separate the values.
        /// </summary>
        /// <value>Character used in the file to separate the values.</value>
        [DataMember(Name="separator", EmitDefaultValue=false)]
        public string Separator { get; set; }
  
        
        /// <summary>
        /// Removes excess blank spaces.
        /// </summary>
        /// <value>Removes excess blank spaces.</value>
        [DataMember(Name="trim", EmitDefaultValue=false)]
        public bool? Trim { get; set; }
  
        
        /// <summary>
        /// Set this to true if values are in quotes.
        /// </summary>
        /// <value>Set this to true if values are in quotes.</value>
        [DataMember(Name="quotedValues", EmitDefaultValue=false)]
        public bool? QuotedValues { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileDataSource {\n");
            sb.Append("  FilePath: ").Append(FilePath).Append("\n");
            sb.Append("  Charset: ").Append(Charset).Append("\n");
            sb.Append("  Separator: ").Append(Separator).Append("\n");
            sb.Append("  Trim: ").Append(Trim).Append("\n");
            sb.Append("  QuotedValues: ").Append(QuotedValues).Append("\n");
            
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
            return this.Equals(obj as FileDataSource);
        }

        /// <summary>
        /// Returns true if FileDataSource instances are equal
        /// </summary>
        /// <param name="other">Instance of FileDataSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileDataSource other)
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
                    this.Charset == other.Charset ||
                    this.Charset != null &&
                    this.Charset.Equals(other.Charset)
                ) && 
                (
                    this.Separator == other.Separator ||
                    this.Separator != null &&
                    this.Separator.Equals(other.Separator)
                ) && 
                (
                    this.Trim == other.Trim ||
                    this.Trim != null &&
                    this.Trim.Equals(other.Trim)
                ) && 
                (
                    this.QuotedValues == other.QuotedValues ||
                    this.QuotedValues != null &&
                    this.QuotedValues.Equals(other.QuotedValues)
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
                
                if (this.Charset != null)
                    hash = hash * 59 + this.Charset.GetHashCode();
                
                if (this.Separator != null)
                    hash = hash * 59 + this.Separator.GetHashCode();
                
                if (this.Trim != null)
                    hash = hash * 59 + this.Trim.GetHashCode();
                
                if (this.QuotedValues != null)
                    hash = hash * 59 + this.QuotedValues.GetHashCode();
                
                return hash;
            }
        }

    }
}
