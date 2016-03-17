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
    public partial class DataSourceTestStep : TestStep,  IEquatable<DataSourceTestStep>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataSourceTestStep" /> class.
        /// </summary>
        public DataSourceTestStep()
        {
            this.EntitizeValues = false;
            this.Shared = false;
            this.TrimValues = false;
            this.SkipLoopOnEmpty = false;
            this.Preload = false;
            this.RestartOnRun = false;
            this.ExpandProperties = false;
            this.FailOnEmpty = false;
            this.RestartShared = false;
            
        }

        
        /// <summary>
        /// If <code>true</code>, all HTML symbols are replaced with appropriate entities.
        /// </summary>
        /// <value>If <code>true</code>, all HTML symbols are replaced with appropriate entities.</value>
        [DataMember(Name="entitizeValues", EmitDefaultValue=false)]
        public bool? EntitizeValues { get; set; }
  
        
        /// <summary>
        /// If <code>true</code>, the data source iterator is used by all concurrent virtual users.
        /// </summary>
        /// <value>If <code>true</code>, the data source iterator is used by all concurrent virtual users.</value>
        [DataMember(Name="shared", EmitDefaultValue=false)]
        public bool? Shared { get; set; }
  
        
        /// <summary>
        /// Zero-based index of the initial row that the data source uses.
        /// </summary>
        /// <value>Zero-based index of the initial row that the data source uses.</value>
        [DataMember(Name="startRow", EmitDefaultValue=false)]
        public string StartRow { get; set; }
  
        
        /// <summary>
        /// If <code>true</code>, all leading and trailing spaces are removed.
        /// </summary>
        /// <value>If <code>true</code>, all leading and trailing spaces are removed.</value>
        [DataMember(Name="trimValues", EmitDefaultValue=false)]
        public bool? TrimValues { get; set; }
  
        
        /// <summary>
        /// Zero-based index of the last row that the data source uses
        /// </summary>
        /// <value>Zero-based index of the last row that the data source uses</value>
        [DataMember(Name="endRow", EmitDefaultValue=false)]
        public string EndRow { get; set; }
  
        
        /// <summary>
        /// Array of test steps using the data source and forming a data source loop.
        /// </summary>
        /// <value>Array of test steps using the data source and forming a data source loop.</value>
        [DataMember(Name="testSteps", EmitDefaultValue=false)]
        public List<TestStep> TestSteps { get; set; }
  
        
        /// <summary>
        /// Test step type. Possible values: <ul><li>DataSource</li><li>Groovy</li><li>JDBC Request</li><li>Property Transfer</li><li>REST Request</li><li>TestStepStruct</li></ul>
        /// </summary>
        /// <value>Test step type. Possible values: <ul><li>DataSource</li><li>Groovy</li><li>JDBC Request</li><li>Property Transfer</li><li>REST Request</li><li>TestStepStruct</li></ul></value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
  
        
        /// <summary>
        /// If <code>true</code>, skips the data source loop if the data source is empty.
        /// </summary>
        /// <value>If <code>true</code>, skips the data source loop if the data source is empty.</value>
        [DataMember(Name="skipLoopOnEmpty", EmitDefaultValue=false)]
        public bool? SkipLoopOnEmpty { get; set; }
  
        
        /// <summary>
        /// If <code>true</code>, the TestServer tries to preload the data before running the test.
        /// </summary>
        /// <value>If <code>true</code>, the TestServer tries to preload the data before running the test.</value>
        [DataMember(Name="preload", EmitDefaultValue=false)]
        public bool? Preload { get; set; }
  
        
        /// <summary>
        /// If <code>true</code>, the iterator is set to the first row each time the test reaches the DataSource test step.
        /// </summary>
        /// <value>If <code>true</code>, the iterator is set to the first row each time the test reaches the DataSource test step.</value>
        [DataMember(Name="restartOnRun", EmitDefaultValue=false)]
        public bool? RestartOnRun { get; set; }
  
        
        /// <summary>
        /// If <code>true</code>, TestServer expands property expansion expressions in retrieved values.
        /// </summary>
        /// <value>If <code>true</code>, TestServer expands property expansion expressions in retrieved values.</value>
        [DataMember(Name="expandProperties", EmitDefaultValue=false)]
        public bool? ExpandProperties { get; set; }
  
        
        /// <summary>
        /// If <code>true</code>, the test step fails if the data source is empty.
        /// </summary>
        /// <value>If <code>true</code>, the test step fails if the data source is empty.</value>
        [DataMember(Name="failOnEmpty", EmitDefaultValue=false)]
        public bool? FailOnEmpty { get; set; }
  
        
        /// <summary>
        /// If <code>true</code> and <code>shared</code> is also <code>true</code>, resets the iterator when it reaches the end of data source.
        /// </summary>
        /// <value>If <code>true</code> and <code>shared</code> is also <code>true</code>, resets the iterator when it reaches the end of data source.</value>
        [DataMember(Name="restartShared", EmitDefaultValue=false)]
        public bool? RestartShared { get; set; }
  
        
        /// <summary>
        /// Test step name. This name is used to refer to the test step in the test recipe.
        /// </summary>
        /// <value>Test step name. This name is used to refer to the test step in the test recipe.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
  
        
        /// <summary>
        /// Gets or Sets DataSource
        /// </summary>
        [DataMember(Name="dataSource", EmitDefaultValue=false)]
        public DataSource DataSource { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DataSourceTestStep {\n");
            sb.Append("  EntitizeValues: ").Append(EntitizeValues).Append("\n");
            sb.Append("  Shared: ").Append(Shared).Append("\n");
            sb.Append("  StartRow: ").Append(StartRow).Append("\n");
            sb.Append("  TrimValues: ").Append(TrimValues).Append("\n");
            sb.Append("  EndRow: ").Append(EndRow).Append("\n");
            sb.Append("  TestSteps: ").Append(TestSteps).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  SkipLoopOnEmpty: ").Append(SkipLoopOnEmpty).Append("\n");
            sb.Append("  Preload: ").Append(Preload).Append("\n");
            sb.Append("  RestartOnRun: ").Append(RestartOnRun).Append("\n");
            sb.Append("  ExpandProperties: ").Append(ExpandProperties).Append("\n");
            sb.Append("  FailOnEmpty: ").Append(FailOnEmpty).Append("\n");
            sb.Append("  RestartShared: ").Append(RestartShared).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DataSource: ").Append(DataSource).Append("\n");
            
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
            return this.Equals(obj as DataSourceTestStep);
        }

        /// <summary>
        /// Returns true if DataSourceTestStep instances are equal
        /// </summary>
        /// <param name="other">Instance of DataSourceTestStep to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataSourceTestStep other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.EntitizeValues == other.EntitizeValues ||
                    this.EntitizeValues != null &&
                    this.EntitizeValues.Equals(other.EntitizeValues)
                ) && 
                (
                    this.Shared == other.Shared ||
                    this.Shared != null &&
                    this.Shared.Equals(other.Shared)
                ) && 
                (
                    this.StartRow == other.StartRow ||
                    this.StartRow != null &&
                    this.StartRow.Equals(other.StartRow)
                ) && 
                (
                    this.TrimValues == other.TrimValues ||
                    this.TrimValues != null &&
                    this.TrimValues.Equals(other.TrimValues)
                ) && 
                (
                    this.EndRow == other.EndRow ||
                    this.EndRow != null &&
                    this.EndRow.Equals(other.EndRow)
                ) && 
                (
                    this.TestSteps == other.TestSteps ||
                    this.TestSteps != null &&
                    this.TestSteps.SequenceEqual(other.TestSteps)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.SkipLoopOnEmpty == other.SkipLoopOnEmpty ||
                    this.SkipLoopOnEmpty != null &&
                    this.SkipLoopOnEmpty.Equals(other.SkipLoopOnEmpty)
                ) && 
                (
                    this.Preload == other.Preload ||
                    this.Preload != null &&
                    this.Preload.Equals(other.Preload)
                ) && 
                (
                    this.RestartOnRun == other.RestartOnRun ||
                    this.RestartOnRun != null &&
                    this.RestartOnRun.Equals(other.RestartOnRun)
                ) && 
                (
                    this.ExpandProperties == other.ExpandProperties ||
                    this.ExpandProperties != null &&
                    this.ExpandProperties.Equals(other.ExpandProperties)
                ) && 
                (
                    this.FailOnEmpty == other.FailOnEmpty ||
                    this.FailOnEmpty != null &&
                    this.FailOnEmpty.Equals(other.FailOnEmpty)
                ) && 
                (
                    this.RestartShared == other.RestartShared ||
                    this.RestartShared != null &&
                    this.RestartShared.Equals(other.RestartShared)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.DataSource == other.DataSource ||
                    this.DataSource != null &&
                    this.DataSource.Equals(other.DataSource)
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
                
                if (this.EntitizeValues != null)
                    hash = hash * 59 + this.EntitizeValues.GetHashCode();
                
                if (this.Shared != null)
                    hash = hash * 59 + this.Shared.GetHashCode();
                
                if (this.StartRow != null)
                    hash = hash * 59 + this.StartRow.GetHashCode();
                
                if (this.TrimValues != null)
                    hash = hash * 59 + this.TrimValues.GetHashCode();
                
                if (this.EndRow != null)
                    hash = hash * 59 + this.EndRow.GetHashCode();
                
                if (this.TestSteps != null)
                    hash = hash * 59 + this.TestSteps.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                if (this.SkipLoopOnEmpty != null)
                    hash = hash * 59 + this.SkipLoopOnEmpty.GetHashCode();
                
                if (this.Preload != null)
                    hash = hash * 59 + this.Preload.GetHashCode();
                
                if (this.RestartOnRun != null)
                    hash = hash * 59 + this.RestartOnRun.GetHashCode();
                
                if (this.ExpandProperties != null)
                    hash = hash * 59 + this.ExpandProperties.GetHashCode();
                
                if (this.FailOnEmpty != null)
                    hash = hash * 59 + this.FailOnEmpty.GetHashCode();
                
                if (this.RestartShared != null)
                    hash = hash * 59 + this.RestartShared.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.DataSource != null)
                    hash = hash * 59 + this.DataSource.GetHashCode();
                
                return hash;
            }
        }

    }
}
