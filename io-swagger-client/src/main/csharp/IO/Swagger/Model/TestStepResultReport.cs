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
    /// Data structure for test step results in the report.
    /// </summary>
    [DataContract]
    public partial class TestStepResultReport :  IEquatable<TestStepResultReport>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestStepResultReport" /> class.
        /// </summary>
        public TestStepResultReport()
        {
            
        }

        
        /// <summary>
        /// The name of the test step
        /// </summary>
        /// <value>The name of the test step</value>
        [DataMember(Name="testStepName", EmitDefaultValue=false)]
        public string TestStepName { get; set; }
  
        
        /// <summary>
        /// Specifies if the assertions failed or succeeded.
        /// </summary>
        /// <value>Specifies if the assertions failed or succeeded.</value>
        [DataMember(Name="assertionStatus", EmitDefaultValue=false)]
        public string AssertionStatus { get; set; }
  
        
        /// <summary>
        /// The number of milliseconds it took the TestServer to run the test step.
        /// </summary>
        /// <value>The number of milliseconds it took the TestServer to run the test step.</value>
        [DataMember(Name="timeTaken", EmitDefaultValue=false)]
        public long? TimeTaken { get; set; }
  
        
        /// <summary>
        /// Error messages returned by the assertions.
        /// </summary>
        /// <value>Error messages returned by the assertions.</value>
        [DataMember(Name="messages", EmitDefaultValue=false)]
        public List<string> Messages { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TestStepResultReport {\n");
            sb.Append("  TestStepName: ").Append(TestStepName).Append("\n");
            sb.Append("  AssertionStatus: ").Append(AssertionStatus).Append("\n");
            sb.Append("  TimeTaken: ").Append(TimeTaken).Append("\n");
            sb.Append("  Messages: ").Append(Messages).Append("\n");
            
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
            return this.Equals(obj as TestStepResultReport);
        }

        /// <summary>
        /// Returns true if TestStepResultReport instances are equal
        /// </summary>
        /// <param name="other">Instance of TestStepResultReport to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TestStepResultReport other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TestStepName == other.TestStepName ||
                    this.TestStepName != null &&
                    this.TestStepName.Equals(other.TestStepName)
                ) && 
                (
                    this.AssertionStatus == other.AssertionStatus ||
                    this.AssertionStatus != null &&
                    this.AssertionStatus.Equals(other.AssertionStatus)
                ) && 
                (
                    this.TimeTaken == other.TimeTaken ||
                    this.TimeTaken != null &&
                    this.TimeTaken.Equals(other.TimeTaken)
                ) && 
                (
                    this.Messages == other.Messages ||
                    this.Messages != null &&
                    this.Messages.SequenceEqual(other.Messages)
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
                
                if (this.TestStepName != null)
                    hash = hash * 59 + this.TestStepName.GetHashCode();
                
                if (this.AssertionStatus != null)
                    hash = hash * 59 + this.AssertionStatus.GetHashCode();
                
                if (this.TimeTaken != null)
                    hash = hash * 59 + this.TimeTaken.GetHashCode();
                
                if (this.Messages != null)
                    hash = hash * 59 + this.Messages.GetHashCode();
                
                return hash;
            }
        }

    }
}
