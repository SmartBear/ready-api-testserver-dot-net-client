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
    /// Data structure for recipe execution results.
    /// </summary>
    [DataContract]
    public partial class ProjectResultReport :  IEquatable<ProjectResultReport>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectResultReport" /> class.
        /// </summary>
        public ProjectResultReport()
        {
            
        }

        
        /// <summary>
        /// The name of the executed project.
        /// </summary>
        /// <value>The name of the executed project.</value>
        [DataMember(Name="projectName", EmitDefaultValue=false)]
        public string ProjectName { get; set; }
  
        
        /// <summary>
        /// Current execution status. If the assertion fail, the test is also FAILED.
        /// </summary>
        /// <value>Current execution status. If the assertion fail, the test is also FAILED.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
  
        
        /// <summary>
        /// The array of reports for test suites in the test recipe.
        /// </summary>
        /// <value>The array of reports for test suites in the test recipe.</value>
        [DataMember(Name="testSuiteResultReports", EmitDefaultValue=false)]
        public List<TestSuiteResultReport> TestSuiteResultReports { get; set; }
  
        
        /// <summary>
        /// The number of milliseconds it took the TestServer to run the recipe.
        /// </summary>
        /// <value>The number of milliseconds it took the TestServer to run the recipe.</value>
        [DataMember(Name="timeTaken", EmitDefaultValue=false)]
        public long? TimeTaken { get; set; }
  
        
        /// <summary>
        /// The timestamp of the execution start.
        /// </summary>
        /// <value>The timestamp of the execution start.</value>
        [DataMember(Name="startTime", EmitDefaultValue=false)]
        public long? StartTime { get; set; }
  
        
        /// <summary>
        /// The identifier of the test run.
        /// </summary>
        /// <value>The identifier of the test run.</value>
        [DataMember(Name="executionID", EmitDefaultValue=false)]
        public string ExecutionID { get; set; }
  
        
        /// <summary>
        /// To resolve data sources in your test, you need to send the data source file as an extra request.
        /// </summary>
        /// <value>To resolve data sources in your test, you need to send the data source file as an extra request.</value>
        [DataMember(Name="unresolvedDataSources", EmitDefaultValue=false)]
        public List<DataSource> UnresolvedDataSources { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProjectResultReport {\n");
            sb.Append("  ProjectName: ").Append(ProjectName).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TestSuiteResultReports: ").Append(TestSuiteResultReports).Append("\n");
            sb.Append("  TimeTaken: ").Append(TimeTaken).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  ExecutionID: ").Append(ExecutionID).Append("\n");
            sb.Append("  UnresolvedDataSources: ").Append(UnresolvedDataSources).Append("\n");
            
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
            return this.Equals(obj as ProjectResultReport);
        }

        /// <summary>
        /// Returns true if ProjectResultReport instances are equal
        /// </summary>
        /// <param name="other">Instance of ProjectResultReport to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectResultReport other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ProjectName == other.ProjectName ||
                    this.ProjectName != null &&
                    this.ProjectName.Equals(other.ProjectName)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.TestSuiteResultReports == other.TestSuiteResultReports ||
                    this.TestSuiteResultReports != null &&
                    this.TestSuiteResultReports.SequenceEqual(other.TestSuiteResultReports)
                ) && 
                (
                    this.TimeTaken == other.TimeTaken ||
                    this.TimeTaken != null &&
                    this.TimeTaken.Equals(other.TimeTaken)
                ) && 
                (
                    this.StartTime == other.StartTime ||
                    this.StartTime != null &&
                    this.StartTime.Equals(other.StartTime)
                ) && 
                (
                    this.ExecutionID == other.ExecutionID ||
                    this.ExecutionID != null &&
                    this.ExecutionID.Equals(other.ExecutionID)
                ) && 
                (
                    this.UnresolvedDataSources == other.UnresolvedDataSources ||
                    this.UnresolvedDataSources != null &&
                    this.UnresolvedDataSources.SequenceEqual(other.UnresolvedDataSources)
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
                
                if (this.ProjectName != null)
                    hash = hash * 59 + this.ProjectName.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.TestSuiteResultReports != null)
                    hash = hash * 59 + this.TestSuiteResultReports.GetHashCode();
                
                if (this.TimeTaken != null)
                    hash = hash * 59 + this.TimeTaken.GetHashCode();
                
                if (this.StartTime != null)
                    hash = hash * 59 + this.StartTime.GetHashCode();
                
                if (this.ExecutionID != null)
                    hash = hash * 59 + this.ExecutionID.GetHashCode();
                
                if (this.UnresolvedDataSources != null)
                    hash = hash * 59 + this.UnresolvedDataSources.GetHashCode();
                
                return hash;
            }
        }

    }
}
