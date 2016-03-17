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
    /// Properties of the test recipe. Analogues of the &lt;a href=\&quot;http://readyapi.smartbear.com/structure/cases/options/basic\&quot;&gt;test case options&lt;/a&gt;.&lt;br/&gt;See also &lt;a href=\&quot;http://readyapi.smartbear.com/testserver/howto/text/modifying\&quot;&gt;Modifying Test Options&lt;/a&gt;.
    /// </summary>
    [DataContract]
    public partial class TestCase :  IEquatable<TestCase>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestCase" /> class.
        /// </summary>
        public TestCase()
        {
            this.SearchProperties = false;
            this.MaintainSession = false;
            this.AbortOnError = false;
            this.FailTestCaseOnError = false;
            this.DiscardOkResults = false;
            
        }

        
        /// <summary>
        /// ???
        /// </summary>
        /// <value>???</value>
        [DataMember(Name="searchProperties", EmitDefaultValue=false)]
        public bool? SearchProperties { get; set; }
  
        
        /// <summary>
        /// ???
        /// </summary>
        /// <value>???</value>
        [DataMember(Name="maintainSession", EmitDefaultValue=false)]
        public bool? MaintainSession { get; set; }
  
        
        /// <summary>
        /// Specifies if TestServer stops the recipe execution if an error occurs.
        /// </summary>
        /// <value>Specifies if TestServer stops the recipe execution if an error occurs.</value>
        [DataMember(Name="abortOnError", EmitDefaultValue=false)]
        public bool? AbortOnError { get; set; }
  
        
        /// <summary>
        /// Specifies if TestServer logs the test run as failed if an error occurs.
        /// </summary>
        /// <value>Specifies if TestServer logs the test run as failed if an error occurs.</value>
        [DataMember(Name="failTestCaseOnError", EmitDefaultValue=false)]
        public bool? FailTestCaseOnError { get; set; }
  
        
        /// <summary>
        /// Specifies if TestServer logs messages on successful test step execution (false) or not (true). Set this property to true to save memory.
        /// </summary>
        /// <value>Specifies if TestServer logs messages on successful test step execution (false) or not (true). Set this property to true to save memory.</value>
        [DataMember(Name="discardOkResults", EmitDefaultValue=false)]
        public bool? DiscardOkResults { get; set; }
  
        
        /// <summary>
        /// ???
        /// </summary>
        /// <value>???</value>
        [DataMember(Name="socketTimeout", EmitDefaultValue=false)]
        public string SocketTimeout { get; set; }
  
        
        /// <summary>
        /// Sets the maximum execution time for the test in milliseconds. Default: 0 = timeout is not set.
        /// </summary>
        /// <value>Sets the maximum execution time for the test in milliseconds. Default: 0 = timeout is not set.</value>
        [DataMember(Name="testCaseTimeout", EmitDefaultValue=false)]
        public int? TestCaseTimeout { get; set; }
  
        
        /// <summary>
        /// An array of test steps to be executed.
        /// </summary>
        /// <value>An array of test steps to be executed.</value>
        [DataMember(Name="testSteps", EmitDefaultValue=false)]
        public List<TestStep> TestSteps { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TestCase {\n");
            sb.Append("  SearchProperties: ").Append(SearchProperties).Append("\n");
            sb.Append("  MaintainSession: ").Append(MaintainSession).Append("\n");
            sb.Append("  AbortOnError: ").Append(AbortOnError).Append("\n");
            sb.Append("  FailTestCaseOnError: ").Append(FailTestCaseOnError).Append("\n");
            sb.Append("  DiscardOkResults: ").Append(DiscardOkResults).Append("\n");
            sb.Append("  SocketTimeout: ").Append(SocketTimeout).Append("\n");
            sb.Append("  TestCaseTimeout: ").Append(TestCaseTimeout).Append("\n");
            sb.Append("  TestSteps: ").Append(TestSteps).Append("\n");
            
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
            return this.Equals(obj as TestCase);
        }

        /// <summary>
        /// Returns true if TestCase instances are equal
        /// </summary>
        /// <param name="other">Instance of TestCase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TestCase other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SearchProperties == other.SearchProperties ||
                    this.SearchProperties != null &&
                    this.SearchProperties.Equals(other.SearchProperties)
                ) && 
                (
                    this.MaintainSession == other.MaintainSession ||
                    this.MaintainSession != null &&
                    this.MaintainSession.Equals(other.MaintainSession)
                ) && 
                (
                    this.AbortOnError == other.AbortOnError ||
                    this.AbortOnError != null &&
                    this.AbortOnError.Equals(other.AbortOnError)
                ) && 
                (
                    this.FailTestCaseOnError == other.FailTestCaseOnError ||
                    this.FailTestCaseOnError != null &&
                    this.FailTestCaseOnError.Equals(other.FailTestCaseOnError)
                ) && 
                (
                    this.DiscardOkResults == other.DiscardOkResults ||
                    this.DiscardOkResults != null &&
                    this.DiscardOkResults.Equals(other.DiscardOkResults)
                ) && 
                (
                    this.SocketTimeout == other.SocketTimeout ||
                    this.SocketTimeout != null &&
                    this.SocketTimeout.Equals(other.SocketTimeout)
                ) && 
                (
                    this.TestCaseTimeout == other.TestCaseTimeout ||
                    this.TestCaseTimeout != null &&
                    this.TestCaseTimeout.Equals(other.TestCaseTimeout)
                ) && 
                (
                    this.TestSteps == other.TestSteps ||
                    this.TestSteps != null &&
                    this.TestSteps.SequenceEqual(other.TestSteps)
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
                
                if (this.SearchProperties != null)
                    hash = hash * 59 + this.SearchProperties.GetHashCode();
                
                if (this.MaintainSession != null)
                    hash = hash * 59 + this.MaintainSession.GetHashCode();
                
                if (this.AbortOnError != null)
                    hash = hash * 59 + this.AbortOnError.GetHashCode();
                
                if (this.FailTestCaseOnError != null)
                    hash = hash * 59 + this.FailTestCaseOnError.GetHashCode();
                
                if (this.DiscardOkResults != null)
                    hash = hash * 59 + this.DiscardOkResults.GetHashCode();
                
                if (this.SocketTimeout != null)
                    hash = hash * 59 + this.SocketTimeout.GetHashCode();
                
                if (this.TestCaseTimeout != null)
                    hash = hash * 59 + this.TestCaseTimeout.GetHashCode();
                
                if (this.TestSteps != null)
                    hash = hash * 59 + this.TestSteps.GetHashCode();
                
                return hash;
            }
        }

    }
}
