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
    /// Data structure for a project level report.
    /// </summary>
    [DataContract]
    public partial class ProjectResultReports :  IEquatable<ProjectResultReports>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectResultReports" /> class.
        /// </summary>
        public ProjectResultReports()
        {
            
        }

        
        /// <summary>
        /// The array of executed test recipes.
        /// </summary>
        /// <value>The array of executed test recipes.</value>
        [DataMember(Name="projectResultReports", EmitDefaultValue=false)]
        public List<ProjectResultReport> _ProjectResultReports { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProjectResultReports {\n");
            sb.Append("  _ProjectResultReports: ").Append(_ProjectResultReports).Append("\n");
            
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
            return this.Equals(obj as ProjectResultReports);
        }

        /// <summary>
        /// Returns true if ProjectResultReports instances are equal
        /// </summary>
        /// <param name="other">Instance of ProjectResultReports to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectResultReports other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this._ProjectResultReports == other._ProjectResultReports ||
                    this._ProjectResultReports != null &&
                    this._ProjectResultReports.SequenceEqual(other._ProjectResultReports)
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
                
                if (this._ProjectResultReports != null)
                    hash = hash * 59 + this._ProjectResultReports.GetHashCode();
                
                return hash;
            }
        }

    }
}
