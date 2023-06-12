/*
 * Merge HRIS API
 *
 * The unified API for building rich integrations with multiple HR Information System platforms.
 *
 * The version of the OpenAPI document: 1.0
 * Contact: hello@merge.dev
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Merge.HRISClient.Client.OpenAPIDateConverter;

namespace Merge.HRISClient.Model
{
    /// <summary>
    /// EndUserDetailsRequest
    /// </summary>
    [DataContract(Name = "EndUserDetailsRequest")]
    public partial class EndUserDetailsRequest : IEquatable<EndUserDetailsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EndUserDetailsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EndUserDetailsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EndUserDetailsRequest" /> class.
        /// </summary>
        /// <param name="endUserEmailAddress">Your end user&#39;s email address. This is purely for identification purposes - setting this value will not cause any emails to be sent. (required).</param>
        /// <param name="endUserOrganizationName">Your end user&#39;s organization. (required).</param>
        /// <param name="endUserOriginId">This unique identifier typically represents the ID for your end user in your product&#39;s database. This value must be distinct from other Linked Accounts&#39; unique identifiers. (required).</param>
        /// <param name="categories">The integration categories to show in Merge Link. (required).</param>
        /// <param name="integration">The slug of a specific pre-selected integration for this linking flow token. For examples of slugs, see https://www.merge.dev/docs/basics/integration-metadata/..</param>
        /// <param name="linkExpiryMins">An integer number of minutes between [30, 720 or 10080 if for a Magic Link URL] for how long this token is valid. Defaults to 30. (default to 30).</param>
        /// <param name="shouldCreateMagicLinkUrl">Whether to generate a Magic Link URL. Defaults to false. For more information on Magic Link, see https://merge.dev/blog/product/integrations,-fast.-say-hello-to-magic-link/. (default to false).</param>
        /// <param name="commonModels">An array of objects to specify the models and fields that will be disabled for a given Linked Account. Each object uses model_id, enabled_actions, and disabled_fields to specify the model, method, and fields that are scoped for a given Linked Account..</param>
        public EndUserDetailsRequest(string endUserEmailAddress = default(string), string endUserOrganizationName = default(string), string endUserOriginId = default(string), List<CategoriesEnum> categories = default(List<CategoriesEnum>), string integration = default(string), int linkExpiryMins = 30, bool? shouldCreateMagicLinkUrl = false, List<CommonModelScopesBodyRequest> commonModels = default(List<CommonModelScopesBodyRequest>))
        {
            // to ensure "endUserEmailAddress" is required (not null)
            this.EndUserEmailAddress = endUserEmailAddress ?? throw new ArgumentNullException("endUserEmailAddress is a required property for EndUserDetailsRequest and cannot be null");
            // to ensure "endUserOrganizationName" is required (not null)
            this.EndUserOrganizationName = endUserOrganizationName ?? throw new ArgumentNullException("endUserOrganizationName is a required property for EndUserDetailsRequest and cannot be null");
            // to ensure "endUserOriginId" is required (not null)
            this.EndUserOriginId = endUserOriginId ?? throw new ArgumentNullException("endUserOriginId is a required property for EndUserDetailsRequest and cannot be null");
            // to ensure "categories" is required (not null)
            this.Categories = categories ?? throw new ArgumentNullException("categories is a required property for EndUserDetailsRequest and cannot be null");
            this.Integration = integration;
            this.LinkExpiryMins = linkExpiryMins;
            // use default value if no "shouldCreateMagicLinkUrl" provided
            this.ShouldCreateMagicLinkUrl = shouldCreateMagicLinkUrl ?? false;
            this.CommonModels = commonModels;
        }

        /// <summary>
        /// Your end user&#39;s email address. This is purely for identification purposes - setting this value will not cause any emails to be sent.
        /// </summary>
        /// <value>Your end user&#39;s email address. This is purely for identification purposes - setting this value will not cause any emails to be sent.</value>
        [DataMember(Name = "end_user_email_address", IsRequired = true, EmitDefaultValue = false)]
        public string EndUserEmailAddress { get; set; }

        /// <summary>
        /// Your end user&#39;s organization.
        /// </summary>
        /// <value>Your end user&#39;s organization.</value>
        [DataMember(Name = "end_user_organization_name", IsRequired = true, EmitDefaultValue = false)]
        public string EndUserOrganizationName { get; set; }

        /// <summary>
        /// This unique identifier typically represents the ID for your end user in your product&#39;s database. This value must be distinct from other Linked Accounts&#39; unique identifiers.
        /// </summary>
        /// <value>This unique identifier typically represents the ID for your end user in your product&#39;s database. This value must be distinct from other Linked Accounts&#39; unique identifiers.</value>
        [DataMember(Name = "end_user_origin_id", IsRequired = true, EmitDefaultValue = false)]
        public string EndUserOriginId { get; set; }

        /// <summary>
        /// The integration categories to show in Merge Link.
        /// </summary>
        /// <value>The integration categories to show in Merge Link.</value>
        [DataMember(Name = "categories", IsRequired = true, EmitDefaultValue = false)]
        public List<CategoriesEnum> Categories { get; set; }

        /// <summary>
        /// The slug of a specific pre-selected integration for this linking flow token. For examples of slugs, see https://www.merge.dev/docs/basics/integration-metadata/.
        /// </summary>
        /// <value>The slug of a specific pre-selected integration for this linking flow token. For examples of slugs, see https://www.merge.dev/docs/basics/integration-metadata/.</value>
        [DataMember(Name = "integration", EmitDefaultValue = true)]
        public string Integration { get; set; }

        /// <summary>
        /// An integer number of minutes between [30, 720 or 10080 if for a Magic Link URL] for how long this token is valid. Defaults to 30.
        /// </summary>
        /// <value>An integer number of minutes between [30, 720 or 10080 if for a Magic Link URL] for how long this token is valid. Defaults to 30.</value>
        [DataMember(Name = "link_expiry_mins", EmitDefaultValue = false)]
        public int LinkExpiryMins { get; set; }

        /// <summary>
        /// Whether to generate a Magic Link URL. Defaults to false. For more information on Magic Link, see https://merge.dev/blog/product/integrations,-fast.-say-hello-to-magic-link/.
        /// </summary>
        /// <value>Whether to generate a Magic Link URL. Defaults to false. For more information on Magic Link, see https://merge.dev/blog/product/integrations,-fast.-say-hello-to-magic-link/.</value>
        [DataMember(Name = "should_create_magic_link_url", EmitDefaultValue = true)]
        public bool? ShouldCreateMagicLinkUrl { get; set; }

        /// <summary>
        /// An array of objects to specify the models and fields that will be disabled for a given Linked Account. Each object uses model_id, enabled_actions, and disabled_fields to specify the model, method, and fields that are scoped for a given Linked Account.
        /// </summary>
        /// <value>An array of objects to specify the models and fields that will be disabled for a given Linked Account. Each object uses model_id, enabled_actions, and disabled_fields to specify the model, method, and fields that are scoped for a given Linked Account.</value>
        [DataMember(Name = "common_models", EmitDefaultValue = true)]
        public List<CommonModelScopesBodyRequest> CommonModels { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EndUserDetailsRequest {\n");
            sb.Append("  EndUserEmailAddress: ").Append(EndUserEmailAddress).Append("\n");
            sb.Append("  EndUserOrganizationName: ").Append(EndUserOrganizationName).Append("\n");
            sb.Append("  EndUserOriginId: ").Append(EndUserOriginId).Append("\n");
            sb.Append("  Categories: ").Append(Categories).Append("\n");
            sb.Append("  Integration: ").Append(Integration).Append("\n");
            sb.Append("  LinkExpiryMins: ").Append(LinkExpiryMins).Append("\n");
            sb.Append("  ShouldCreateMagicLinkUrl: ").Append(ShouldCreateMagicLinkUrl).Append("\n");
            sb.Append("  CommonModels: ").Append(CommonModels).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as EndUserDetailsRequest);
        }

        /// <summary>
        /// Returns true if EndUserDetailsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of EndUserDetailsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EndUserDetailsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EndUserEmailAddress == input.EndUserEmailAddress ||
                    (this.EndUserEmailAddress != null &&
                    this.EndUserEmailAddress.Equals(input.EndUserEmailAddress))
                ) && 
                (
                    this.EndUserOrganizationName == input.EndUserOrganizationName ||
                    (this.EndUserOrganizationName != null &&
                    this.EndUserOrganizationName.Equals(input.EndUserOrganizationName))
                ) && 
                (
                    this.EndUserOriginId == input.EndUserOriginId ||
                    (this.EndUserOriginId != null &&
                    this.EndUserOriginId.Equals(input.EndUserOriginId))
                ) && 
                (
                    this.Categories == input.Categories ||
                    this.Categories != null &&
                    input.Categories != null &&
                    this.Categories.SequenceEqual(input.Categories)
                ) && 
                (
                    this.Integration == input.Integration ||
                    (this.Integration != null &&
                    this.Integration.Equals(input.Integration))
                ) && 
                (
                    this.LinkExpiryMins == input.LinkExpiryMins ||
                    this.LinkExpiryMins.Equals(input.LinkExpiryMins)
                ) && 
                (
                    this.ShouldCreateMagicLinkUrl == input.ShouldCreateMagicLinkUrl ||
                    (this.ShouldCreateMagicLinkUrl != null &&
                    this.ShouldCreateMagicLinkUrl.Equals(input.ShouldCreateMagicLinkUrl))
                ) && 
                (
                    this.CommonModels == input.CommonModels ||
                    this.CommonModels != null &&
                    input.CommonModels != null &&
                    this.CommonModels.SequenceEqual(input.CommonModels)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.EndUserEmailAddress != null)
                    hashCode = hashCode * 59 + this.EndUserEmailAddress.GetHashCode();
                if (this.EndUserOrganizationName != null)
                    hashCode = hashCode * 59 + this.EndUserOrganizationName.GetHashCode();
                if (this.EndUserOriginId != null)
                    hashCode = hashCode * 59 + this.EndUserOriginId.GetHashCode();
                if (this.Categories != null)
                    hashCode = hashCode * 59 + this.Categories.GetHashCode();
                if (this.Integration != null)
                    hashCode = hashCode * 59 + this.Integration.GetHashCode();
                hashCode = hashCode * 59 + this.LinkExpiryMins.GetHashCode();
                if (this.ShouldCreateMagicLinkUrl != null)
                    hashCode = hashCode * 59 + this.ShouldCreateMagicLinkUrl.GetHashCode();
                if (this.CommonModels != null)
                    hashCode = hashCode * 59 + this.CommonModels.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // EndUserEmailAddress (string) maxLength
            if(this.EndUserEmailAddress != null && this.EndUserEmailAddress.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EndUserEmailAddress, length must be less than 100.", new [] { "EndUserEmailAddress" });
            }

            // EndUserEmailAddress (string) minLength
            if(this.EndUserEmailAddress != null && this.EndUserEmailAddress.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EndUserEmailAddress, length must be greater than 1.", new [] { "EndUserEmailAddress" });
            }

            // EndUserOrganizationName (string) maxLength
            if(this.EndUserOrganizationName != null && this.EndUserOrganizationName.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EndUserOrganizationName, length must be less than 100.", new [] { "EndUserOrganizationName" });
            }

            // EndUserOrganizationName (string) minLength
            if(this.EndUserOrganizationName != null && this.EndUserOrganizationName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EndUserOrganizationName, length must be greater than 1.", new [] { "EndUserOrganizationName" });
            }

            // EndUserOriginId (string) maxLength
            if(this.EndUserOriginId != null && this.EndUserOriginId.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EndUserOriginId, length must be less than 100.", new [] { "EndUserOriginId" });
            }

            // EndUserOriginId (string) minLength
            if(this.EndUserOriginId != null && this.EndUserOriginId.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EndUserOriginId, length must be greater than 1.", new [] { "EndUserOriginId" });
            }

            // Integration (string) minLength
            if(this.Integration != null && this.Integration.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Integration, length must be greater than 1.", new [] { "Integration" });
            }

            // LinkExpiryMins (int) maximum
            if(this.LinkExpiryMins > (int)10080)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LinkExpiryMins, must be a value less than or equal to 10080.", new [] { "LinkExpiryMins" });
            }

            // LinkExpiryMins (int) minimum
            if(this.LinkExpiryMins < (int)30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LinkExpiryMins, must be a value greater than or equal to 30.", new [] { "LinkExpiryMins" });
            }

            yield break;
        }
    }

}
