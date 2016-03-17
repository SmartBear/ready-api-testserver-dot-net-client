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
    /// Data structure for the test results report of the test case execution.
    /// </summary>
    [DataContract]
    public partial class TestCaseResultReport :  IEquatable<TestCaseResultReport>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestCaseResultReport" /> class.
        /// </summary>
        public TestCaseResultReport()
        {
            
        }

        
        /// <summary>
        /// The name of the test case the report is for.
        /// </summary>
        /// <value>The name of the test case the report is for.</value>
        [DataMember(Name="testCaseName", EmitDefaultValue=false)]
        public string TestCaseName { get; set; }
  
        
        /// <summary>
        /// The array of test step result reports.
        /// </summary>
        /// <value>The array of test step result reports.</value>
        [DataMember(Name="testStepResultReports", EmitDefaultValue=false)]
        public List<TestStepResultReport> TestStepResultReports { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TestCaseResultReport {\n");
            sb.Append("  TestCaseName: ").Append(TestCaseName).Append("\n");
            sb.Append("  TestStepResultReports: ").Append(TestStepResultReports).Append("\n");
            
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
            return this.Equals(obj as TestCaseResultReport);
        }

        /// <summary>
        /// Returns true if TestCaseResultReport instances are equal
        /// </summary>
        /// <param name="other">Instance of TestCaseResultReport to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TestCaseResultReport other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TestCaseName == other.TestCaseName ||
                    this.TestCaseName != null &&
                    this.TestCaseName.Equals(other.TestCaseName)
                ) && 
                (
                    this.TestStepResultReports == other.TestStepResultReports ||
                    this.TestStepResultReports != null &&
                    this.TestStepResultReports.SequenceEqual(other.TestStepResultReports)
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
                
                if (this.TestCaseName != null)
                    hash = hash * 59 + this.TestCaseName.GetHashCode();
                
                if (this.TestStepResultReports != null)
                    hash = hash * 59 + this.TestStepResultReports.GetHashCode();
                
                return hash;
            }
        }

    }
}
