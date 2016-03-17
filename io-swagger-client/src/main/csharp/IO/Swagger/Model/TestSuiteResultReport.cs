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
    /// Results of a test suite execution.
    /// </summary>
    [DataContract]
    public partial class TestSuiteResultReport :  IEquatable<TestSuiteResultReport>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteResultReport" /> class.
        /// </summary>
        public TestSuiteResultReport()
        {
            
        }

        
        /// <summary>
        /// The test suite name.
        /// </summary>
        /// <value>The test suite name.</value>
        [DataMember(Name="testSuiteName", EmitDefaultValue=false)]
        public string TestSuiteName { get; set; }
  
        
        /// <summary>
        /// An array of test case execution results.
        /// </summary>
        /// <value>An array of test case execution results.</value>
        [DataMember(Name="testCaseResultReports", EmitDefaultValue=false)]
        public List<TestCaseResultReport> TestCaseResultReports { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TestSuiteResultReport {\n");
            sb.Append("  TestSuiteName: ").Append(TestSuiteName).Append("\n");
            sb.Append("  TestCaseResultReports: ").Append(TestCaseResultReports).Append("\n");
            
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
            return this.Equals(obj as TestSuiteResultReport);
        }

        /// <summary>
        /// Returns true if TestSuiteResultReport instances are equal
        /// </summary>
        /// <param name="other">Instance of TestSuiteResultReport to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TestSuiteResultReport other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TestSuiteName == other.TestSuiteName ||
                    this.TestSuiteName != null &&
                    this.TestSuiteName.Equals(other.TestSuiteName)
                ) && 
                (
                    this.TestCaseResultReports == other.TestCaseResultReports ||
                    this.TestCaseResultReports != null &&
                    this.TestCaseResultReports.SequenceEqual(other.TestCaseResultReports)
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
                
                if (this.TestSuiteName != null)
                    hash = hash * 59 + this.TestSuiteName.GetHashCode();
                
                if (this.TestCaseResultReports != null)
                    hash = hash * 59 + this.TestCaseResultReports.GetHashCode();
                
                return hash;
            }
        }

    }
}
