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
    public partial class JdbcRequestTestStepStruct : TestStep,  IEquatable<JdbcRequestTestStepStruct>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JdbcRequestTestStepStruct" /> class.
        /// </summary>
        public JdbcRequestTestStepStruct()
        {
            this.StoredProcedure = false;
            
        }

        
        /// <summary>
        /// Full database URI including username and password as query parameters.
        /// </summary>
        /// <value>Full database URI including username and password as query parameters.</value>
        [DataMember(Name="connectionString", EmitDefaultValue=false)]
        public string ConnectionString { get; set; }
  
        
        /// <summary>
        /// Specifies if the sqlQuery refers to the stored procedure.
        /// </summary>
        /// <value>Specifies if the sqlQuery refers to the stored procedure.</value>
        [DataMember(Name="storedProcedure", EmitDefaultValue=false)]
        public bool? StoredProcedure { get; set; }
  
        
        /// <summary>
        /// Password used to connect to the database.
        /// </summary>
        /// <value>Password used to connect to the database.</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }
  
        
        /// <summary>
        /// The name of the driver used to connect to the database.
        /// </summary>
        /// <value>The name of the driver used to connect to the database.</value>
        [DataMember(Name="driver", EmitDefaultValue=false)]
        public string Driver { get; set; }
  
        
        /// <summary>
        /// Query used to search the database.
        /// </summary>
        /// <value>Query used to search the database.</value>
        [DataMember(Name="sqlQuery", EmitDefaultValue=false)]
        public string SqlQuery { get; set; }
  
        
        /// <summary>
        /// Test step name. This name is used to refer to the test step in the test recipe.
        /// </summary>
        /// <value>Test step name. This name is used to refer to the test step in the test recipe.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
  
        
        /// <summary>
        /// Array of assertions used to verify test step results.
        /// </summary>
        /// <value>Array of assertions used to verify test step results.</value>
        [DataMember(Name="assertions", EmitDefaultValue=false)]
        public List<Assertion> Assertions { get; set; }
  
        
        /// <summary>
        /// Test step type. Possible values: <ul><li>DataSource</li><li>Groovy</li><li>JDBC Request</li><li>Property Transfer</li><li>REST Request</li><li>TestStepStruct</li></ul>
        /// </summary>
        /// <value>Test step type. Possible values: <ul><li>DataSource</li><li>Groovy</li><li>JDBC Request</li><li>Property Transfer</li><li>REST Request</li><li>TestStepStruct</li></ul></value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
  
        
        /// <summary>
        /// Properties used to store received query results.
        /// </summary>
        /// <value>Properties used to store received query results.</value>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public Dictionary<string, Object> Properties { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JdbcRequestTestStepStruct {\n");
            sb.Append("  ConnectionString: ").Append(ConnectionString).Append("\n");
            sb.Append("  StoredProcedure: ").Append(StoredProcedure).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Driver: ").Append(Driver).Append("\n");
            sb.Append("  SqlQuery: ").Append(SqlQuery).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Assertions: ").Append(Assertions).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            
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
            return this.Equals(obj as JdbcRequestTestStepStruct);
        }

        /// <summary>
        /// Returns true if JdbcRequestTestStepStruct instances are equal
        /// </summary>
        /// <param name="other">Instance of JdbcRequestTestStepStruct to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JdbcRequestTestStepStruct other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ConnectionString == other.ConnectionString ||
                    this.ConnectionString != null &&
                    this.ConnectionString.Equals(other.ConnectionString)
                ) && 
                (
                    this.StoredProcedure == other.StoredProcedure ||
                    this.StoredProcedure != null &&
                    this.StoredProcedure.Equals(other.StoredProcedure)
                ) && 
                (
                    this.Password == other.Password ||
                    this.Password != null &&
                    this.Password.Equals(other.Password)
                ) && 
                (
                    this.Driver == other.Driver ||
                    this.Driver != null &&
                    this.Driver.Equals(other.Driver)
                ) && 
                (
                    this.SqlQuery == other.SqlQuery ||
                    this.SqlQuery != null &&
                    this.SqlQuery.Equals(other.SqlQuery)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Assertions == other.Assertions ||
                    this.Assertions != null &&
                    this.Assertions.SequenceEqual(other.Assertions)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Properties == other.Properties ||
                    this.Properties != null &&
                    this.Properties.SequenceEqual(other.Properties)
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
                
                if (this.ConnectionString != null)
                    hash = hash * 59 + this.ConnectionString.GetHashCode();
                
                if (this.StoredProcedure != null)
                    hash = hash * 59 + this.StoredProcedure.GetHashCode();
                
                if (this.Password != null)
                    hash = hash * 59 + this.Password.GetHashCode();
                
                if (this.Driver != null)
                    hash = hash * 59 + this.Driver.GetHashCode();
                
                if (this.SqlQuery != null)
                    hash = hash * 59 + this.SqlQuery.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Assertions != null)
                    hash = hash * 59 + this.Assertions.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                if (this.Properties != null)
                    hash = hash * 59 + this.Properties.GetHashCode();
                
                return hash;
            }
        }

    }
}
