/* 
 * Square Connect API
 *
 * Client library for accessing the Square Connect APIs
 *
 * OpenAPI spec version: 2.0
 * Contact: developers@squareup.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Square.Connect.Model
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class ObtainTokenResponse :  IEquatable<ObtainTokenResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObtainTokenResponse" /> class.
        /// </summary>
        /// <param name="AccessToken">A valid OAuth access token. OAuth access tokens are 64 bytes long. Provide the access token in a header with every request to Connect API endpoints. See the [Build with OAuth](/authz/oauth/build-with-the-api) guide for more information..</param>
        /// <param name="TokenType">This value is always _bearer_..</param>
        /// <param name="ExpiresAt">The date when access_token expires, in [ISO 8601](http://www.iso.org/iso/home/standards/iso8601.htm) format..</param>
        /// <param name="MerchantId">The ID of the authorizing merchant&#39;s business..</param>
        /// <param name="SubscriptionId">__LEGACY FIELD__. The ID of a subscription plan the merchant signed up for. Only present if the merchant signed up for a subscription during authorization..</param>
        /// <param name="PlanId">__LEGACY FIELD__. The ID of the subscription plan the merchant signed up for. Only present if the merchant signed up for a subscription during authorization..</param>
        /// <param name="IdToken">Then OpenID token belonging to this this person. Only present if the OPENID scope is included in the authorize request..</param>
        /// <param name="RefreshToken">A refresh token. For more information, see [OAuth access token management](/authz/oauth/how-it-works#oauth-access-token-management)..</param>
        public ObtainTokenResponse(string AccessToken = default(string), string TokenType = default(string), string ExpiresAt = default(string), string MerchantId = default(string), string SubscriptionId = default(string), string PlanId = default(string), string IdToken = default(string), string RefreshToken = default(string))
        {
            this.AccessToken = AccessToken;
            this.TokenType = TokenType;
            this.ExpiresAt = ExpiresAt;
            this.MerchantId = MerchantId;
            this.SubscriptionId = SubscriptionId;
            this.PlanId = PlanId;
            this.IdToken = IdToken;
            this.RefreshToken = RefreshToken;
        }
        
        /// <summary>
        /// A valid OAuth access token. OAuth access tokens are 64 bytes long. Provide the access token in a header with every request to Connect API endpoints. See the [Build with OAuth](/authz/oauth/build-with-the-api) guide for more information.
        /// </summary>
        /// <value>A valid OAuth access token. OAuth access tokens are 64 bytes long. Provide the access token in a header with every request to Connect API endpoints. See the [Build with OAuth](/authz/oauth/build-with-the-api) guide for more information.</value>
        [DataMember(Name="access_token", EmitDefaultValue=false)]
        public string AccessToken { get; set; }
        /// <summary>
        /// This value is always _bearer_.
        /// </summary>
        /// <value>This value is always _bearer_.</value>
        [DataMember(Name="token_type", EmitDefaultValue=false)]
        public string TokenType { get; set; }
        /// <summary>
        /// The date when access_token expires, in [ISO 8601](http://www.iso.org/iso/home/standards/iso8601.htm) format.
        /// </summary>
        /// <value>The date when access_token expires, in [ISO 8601](http://www.iso.org/iso/home/standards/iso8601.htm) format.</value>
        [DataMember(Name="expires_at", EmitDefaultValue=false)]
        public string ExpiresAt { get; set; }
        /// <summary>
        /// The ID of the authorizing merchant&#39;s business.
        /// </summary>
        /// <value>The ID of the authorizing merchant&#39;s business.</value>
        [DataMember(Name="merchant_id", EmitDefaultValue=false)]
        public string MerchantId { get; set; }
        /// <summary>
        /// __LEGACY FIELD__. The ID of a subscription plan the merchant signed up for. Only present if the merchant signed up for a subscription during authorization.
        /// </summary>
        /// <value>__LEGACY FIELD__. The ID of a subscription plan the merchant signed up for. Only present if the merchant signed up for a subscription during authorization.</value>
        [DataMember(Name="subscription_id", EmitDefaultValue=false)]
        public string SubscriptionId { get; set; }
        /// <summary>
        /// __LEGACY FIELD__. The ID of the subscription plan the merchant signed up for. Only present if the merchant signed up for a subscription during authorization.
        /// </summary>
        /// <value>__LEGACY FIELD__. The ID of the subscription plan the merchant signed up for. Only present if the merchant signed up for a subscription during authorization.</value>
        [DataMember(Name="plan_id", EmitDefaultValue=false)]
        public string PlanId { get; set; }
        /// <summary>
        /// Then OpenID token belonging to this this person. Only present if the OPENID scope is included in the authorize request.
        /// </summary>
        /// <value>Then OpenID token belonging to this this person. Only present if the OPENID scope is included in the authorize request.</value>
        [DataMember(Name="id_token", EmitDefaultValue=false)]
        public string IdToken { get; set; }
        /// <summary>
        /// A refresh token. For more information, see [OAuth access token management](/authz/oauth/how-it-works#oauth-access-token-management).
        /// </summary>
        /// <value>A refresh token. For more information, see [OAuth access token management](/authz/oauth/how-it-works#oauth-access-token-management).</value>
        [DataMember(Name="refresh_token", EmitDefaultValue=false)]
        public string RefreshToken { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ObtainTokenResponse {\n");
            sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
            sb.Append("  TokenType: ").Append(TokenType).Append("\n");
            sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
            sb.Append("  MerchantId: ").Append(MerchantId).Append("\n");
            sb.Append("  SubscriptionId: ").Append(SubscriptionId).Append("\n");
            sb.Append("  PlanId: ").Append(PlanId).Append("\n");
            sb.Append("  IdToken: ").Append(IdToken).Append("\n");
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
            return this.Equals(obj as ObtainTokenResponse);
        }

        /// <summary>
        /// Returns true if ObtainTokenResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ObtainTokenResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ObtainTokenResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AccessToken == other.AccessToken ||
                    this.AccessToken != null &&
                    this.AccessToken.Equals(other.AccessToken)
                ) && 
                (
                    this.TokenType == other.TokenType ||
                    this.TokenType != null &&
                    this.TokenType.Equals(other.TokenType)
                ) && 
                (
                    this.ExpiresAt == other.ExpiresAt ||
                    this.ExpiresAt != null &&
                    this.ExpiresAt.Equals(other.ExpiresAt)
                ) && 
                (
                    this.MerchantId == other.MerchantId ||
                    this.MerchantId != null &&
                    this.MerchantId.Equals(other.MerchantId)
                ) && 
                (
                    this.SubscriptionId == other.SubscriptionId ||
                    this.SubscriptionId != null &&
                    this.SubscriptionId.Equals(other.SubscriptionId)
                ) && 
                (
                    this.PlanId == other.PlanId ||
                    this.PlanId != null &&
                    this.PlanId.Equals(other.PlanId)
                ) && 
                (
                    this.IdToken == other.IdToken ||
                    this.IdToken != null &&
                    this.IdToken.Equals(other.IdToken)
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
                if (this.AccessToken != null)
                    hash = hash * 59 + this.AccessToken.GetHashCode();
                if (this.TokenType != null)
                    hash = hash * 59 + this.TokenType.GetHashCode();
                if (this.ExpiresAt != null)
                    hash = hash * 59 + this.ExpiresAt.GetHashCode();
                if (this.MerchantId != null)
                    hash = hash * 59 + this.MerchantId.GetHashCode();
                if (this.SubscriptionId != null)
                    hash = hash * 59 + this.SubscriptionId.GetHashCode();
                if (this.PlanId != null)
                    hash = hash * 59 + this.PlanId.GetHashCode();
                if (this.IdToken != null)
                    hash = hash * 59 + this.IdToken.GetHashCode();
                if (this.RefreshToken != null)
                    hash = hash * 59 + this.RefreshToken.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
