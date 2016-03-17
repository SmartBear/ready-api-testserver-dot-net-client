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
    /// Data structure for authentication in test recipes.
    /// </summary>
    [DataContract]
    public partial class Authentication :  IEquatable<Authentication>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Authentication" /> class.
        /// </summary>
        public Authentication()
        {
            
        }

        
        /// <summary>
        /// Authentication type. Possible values: <ul><li>Basic</li><li>SPNEGO/Kerberos</li><li>OAuth 2.0</li></ul>
        /// </summary>
        /// <value>Authentication type. Possible values: <ul><li>Basic</li><li>SPNEGO/Kerberos</li><li>OAuth 2.0</li></ul></value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
  
        
        /// <summary>
        /// Username used for authentication.
        /// </summary>
        /// <value>Username used for authentication.</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }
  
        
        /// <summary>
        /// Password used for authentication.
        /// </summary>
        /// <value>Password used for authentication.</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }
  
        
        /// <summary>
        /// Domain the user belongs to. Required for Kerberos authentication.
        /// </summary>
        /// <value>Domain the user belongs to. Required for Kerberos authentication.</value>
        [DataMember(Name="domain", EmitDefaultValue=false)]
        public string Domain { get; set; }
  
        
        /// <summary>
        /// For OAuth 2.0 only. Access token attached to the user.
        /// </summary>
        /// <value>For OAuth 2.0 only. Access token attached to the user.</value>
        [DataMember(Name="accessToken", EmitDefaultValue=false)]
        public string AccessToken { get; set; }
  
        
        /// <summary>
        /// For OAuth 2.0 only. The position of the access token.
        /// </summary>
        /// <value>For OAuth 2.0 only. The position of the access token.</value>
        [DataMember(Name="accessTokenPosition", EmitDefaultValue=false)]
        public string AccessTokenPosition { get; set; }
  
        
        /// <summary>
        /// For OAuth 2.0 only. The URI used to retrieve the access token.
        /// </summary>
        /// <value>For OAuth 2.0 only. The URI used to retrieve the access token.</value>
        [DataMember(Name="accessTokenUri", EmitDefaultValue=false)]
        public string AccessTokenUri { get; set; }
  
        
        /// <summary>
        /// For OAuth 2.0 only. The client ID attached to the user.
        /// </summary>
        /// <value>For OAuth 2.0 only. The client ID attached to the user.</value>
        [DataMember(Name="clientId", EmitDefaultValue=false)]
        public string ClientId { get; set; }
  
        
        /// <summary>
        /// For OAuth 2.0 only. The client secret key attached to the user.
        /// </summary>
        /// <value>For OAuth 2.0 only. The client secret key attached to the user.</value>
        [DataMember(Name="clientSecret", EmitDefaultValue=false)]
        public string ClientSecret { get; set; }
  
        
        /// <summary>
        /// For OAuth 2.0 only. Specifies the refresh token used.
        /// </summary>
        /// <value>For OAuth 2.0 only. Specifies the refresh token used.</value>
        [DataMember(Name="refreshToken", EmitDefaultValue=false)]
        public string RefreshToken { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Authentication {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
            sb.Append("  AccessTokenPosition: ").Append(AccessTokenPosition).Append("\n");
            sb.Append("  AccessTokenUri: ").Append(AccessTokenUri).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  ClientSecret: ").Append(ClientSecret).Append("\n");
            sb.Append("  RefreshToken: ").Append(RefreshToken).Append("\n");
            
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
            return this.Equals(obj as Authentication);
        }

        /// <summary>
        /// Returns true if Authentication instances are equal
        /// </summary>
        /// <param name="other">Instance of Authentication to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Authentication other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Username == other.Username ||
                    this.Username != null &&
                    this.Username.Equals(other.Username)
                ) && 
                (
                    this.Password == other.Password ||
                    this.Password != null &&
                    this.Password.Equals(other.Password)
                ) && 
                (
                    this.Domain == other.Domain ||
                    this.Domain != null &&
                    this.Domain.Equals(other.Domain)
                ) && 
                (
                    this.AccessToken == other.AccessToken ||
                    this.AccessToken != null &&
                    this.AccessToken.Equals(other.AccessToken)
                ) && 
                (
                    this.AccessTokenPosition == other.AccessTokenPosition ||
                    this.AccessTokenPosition != null &&
                    this.AccessTokenPosition.Equals(other.AccessTokenPosition)
                ) && 
                (
                    this.AccessTokenUri == other.AccessTokenUri ||
                    this.AccessTokenUri != null &&
                    this.AccessTokenUri.Equals(other.AccessTokenUri)
                ) && 
                (
                    this.ClientId == other.ClientId ||
                    this.ClientId != null &&
                    this.ClientId.Equals(other.ClientId)
                ) && 
                (
                    this.ClientSecret == other.ClientSecret ||
                    this.ClientSecret != null &&
                    this.ClientSecret.Equals(other.ClientSecret)
                ) && 
                (
                    this.RefreshToken == other.RefreshToken ||
                    this.RefreshToken != null &&
                    this.RefreshToken.Equals(other.RefreshToken)
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
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                if (this.Username != null)
                    hash = hash * 59 + this.Username.GetHashCode();
                
                if (this.Password != null)
                    hash = hash * 59 + this.Password.GetHashCode();
                
                if (this.Domain != null)
                    hash = hash * 59 + this.Domain.GetHashCode();
                
                if (this.AccessToken != null)
                    hash = hash * 59 + this.AccessToken.GetHashCode();
                
                if (this.AccessTokenPosition != null)
                    hash = hash * 59 + this.AccessTokenPosition.GetHashCode();
                
                if (this.AccessTokenUri != null)
                    hash = hash * 59 + this.AccessTokenUri.GetHashCode();
                
                if (this.ClientId != null)
                    hash = hash * 59 + this.ClientId.GetHashCode();
                
                if (this.ClientSecret != null)
                    hash = hash * 59 + this.ClientSecret.GetHashCode();
                
                if (this.RefreshToken != null)
                    hash = hash * 59 + this.RefreshToken.GetHashCode();
                
                return hash;
            }
        }

    }
}
