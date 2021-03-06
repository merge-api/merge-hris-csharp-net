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
        /// <param name="endUserEmailAddress">endUserEmailAddress (required).</param>
        /// <param name="endUserOrganizationName">endUserOrganizationName (required).</param>
        /// <param name="endUserOriginId">endUserOriginId (required).</param>
        /// <param name="categories">categories.</param>
        /// <param name="integration">integration.</param>
        public EndUserDetailsRequest(string endUserEmailAddress = default(string), string endUserOrganizationName = default(string), string endUserOriginId = default(string), List<CategoriesEnum> categories = default(List<CategoriesEnum>), string integration = default(string))
        {
            // to ensure "endUserEmailAddress" is required (not null)
            this.EndUserEmailAddress = endUserEmailAddress ?? throw new ArgumentNullException("endUserEmailAddress is a required property for EndUserDetailsRequest and cannot be null");
            // to ensure "endUserOrganizationName" is required (not null)
            this.EndUserOrganizationName = endUserOrganizationName ?? throw new ArgumentNullException("endUserOrganizationName is a required property for EndUserDetailsRequest and cannot be null");
            // to ensure "endUserOriginId" is required (not null)
            this.EndUserOriginId = endUserOriginId ?? throw new ArgumentNullException("endUserOriginId is a required property for EndUserDetailsRequest and cannot be null");
            this.Categories = categories;
            this.Integration = integration;
        }

        /// <summary>
        /// Gets or Sets EndUserEmailAddress
        /// </summary>
        [DataMember(Name = "end_user_email_address", IsRequired = true, EmitDefaultValue = false)]
        public string EndUserEmailAddress { get; set; }

        /// <summary>
        /// Gets or Sets EndUserOrganizationName
        /// </summary>
        [DataMember(Name = "end_user_organization_name", IsRequired = true, EmitDefaultValue = false)]
        public string EndUserOrganizationName { get; set; }

        /// <summary>
        /// Gets or Sets EndUserOriginId
        /// </summary>
        [DataMember(Name = "end_user_origin_id", IsRequired = true, EmitDefaultValue = false)]
        public string EndUserOriginId { get; set; }

        /// <summary>
        /// Gets or Sets Categories
        /// </summary>
        [DataMember(Name = "categories", EmitDefaultValue = false)]
        public List<CategoriesEnum> Categories { get; set; }

        /// <summary>
        /// Gets or Sets Integration
        /// </summary>
        [DataMember(Name = "integration", EmitDefaultValue = true)]
        public string Integration { get; set; }

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
            // EndUserEmailAddress (string) minLength
            if(this.EndUserEmailAddress != null && this.EndUserEmailAddress.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EndUserEmailAddress, length must be greater than 1.", new [] { "EndUserEmailAddress" });
            }

            // EndUserOrganizationName (string) minLength
            if(this.EndUserOrganizationName != null && this.EndUserOrganizationName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EndUserOrganizationName, length must be greater than 1.", new [] { "EndUserOrganizationName" });
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

            yield break;
        }
    }

}
