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
    /// # The LinkedAccount Object ### Description The &#x60;LinkedAccount&#x60; object is used to represent an end user&#39;s link with a specific integration.  ### Usage Example View a list of your organization&#39;s &#x60;LinkedAccount&#x60; objects.
    /// </summary>
    [DataContract(Name = "AccountDetailsAndActions")]
    public partial class AccountDetailsAndActions : IEquatable<AccountDetailsAndActions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountDetailsAndActions" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AccountDetailsAndActions() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountDetailsAndActions" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="category">category.</param>
        /// <param name="status">status (required).</param>
        /// <param name="statusDetail">statusDetail.</param>
        /// <param name="endUserOriginId">endUserOriginId.</param>
        /// <param name="endUserOrganizationName">endUserOrganizationName (required).</param>
        /// <param name="endUserEmailAddress">endUserEmailAddress (required).</param>
        /// <param name="integration">integration.</param>
        public AccountDetailsAndActions(string id = default(string), string category = default(string), string status = default(string), string statusDetail = default(string), string endUserOriginId = default(string), string endUserOrganizationName = default(string), string endUserEmailAddress = default(string), AccountDetailsAndActionsIntegration integration = default(AccountDetailsAndActionsIntegration))
        {
            // to ensure "id" is required (not null)
            this.Id = id ?? throw new ArgumentNullException("id is a required property for AccountDetailsAndActions and cannot be null");
            // to ensure "status" is required (not null)
            this.Status = status ?? throw new ArgumentNullException("status is a required property for AccountDetailsAndActions and cannot be null");
            // to ensure "endUserOrganizationName" is required (not null)
            this.EndUserOrganizationName = endUserOrganizationName ?? throw new ArgumentNullException("endUserOrganizationName is a required property for AccountDetailsAndActions and cannot be null");
            // to ensure "endUserEmailAddress" is required (not null)
            this.EndUserEmailAddress = endUserEmailAddress ?? throw new ArgumentNullException("endUserEmailAddress is a required property for AccountDetailsAndActions and cannot be null");
            this.Category = category;
            this.StatusDetail = statusDetail;
            this.EndUserOriginId = endUserOriginId;
            this.Integration = integration;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name = "category", EmitDefaultValue = false)]
        public string Category { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets StatusDetail
        /// </summary>
        [DataMember(Name = "status_detail", EmitDefaultValue = false)]
        public string StatusDetail { get; set; }

        /// <summary>
        /// Gets or Sets EndUserOriginId
        /// </summary>
        [DataMember(Name = "end_user_origin_id", EmitDefaultValue = false)]
        public string EndUserOriginId { get; set; }

        /// <summary>
        /// Gets or Sets EndUserOrganizationName
        /// </summary>
        [DataMember(Name = "end_user_organization_name", IsRequired = true, EmitDefaultValue = false)]
        public string EndUserOrganizationName { get; set; }

        /// <summary>
        /// Gets or Sets EndUserEmailAddress
        /// </summary>
        [DataMember(Name = "end_user_email_address", IsRequired = true, EmitDefaultValue = false)]
        public string EndUserEmailAddress { get; set; }

        /// <summary>
        /// Gets or Sets Integration
        /// </summary>
        [DataMember(Name = "integration", EmitDefaultValue = false)]
        public AccountDetailsAndActionsIntegration Integration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountDetailsAndActions {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusDetail: ").Append(StatusDetail).Append("\n");
            sb.Append("  EndUserOriginId: ").Append(EndUserOriginId).Append("\n");
            sb.Append("  EndUserOrganizationName: ").Append(EndUserOrganizationName).Append("\n");
            sb.Append("  EndUserEmailAddress: ").Append(EndUserEmailAddress).Append("\n");
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
            return this.Equals(input as AccountDetailsAndActions);
        }

        /// <summary>
        /// Returns true if AccountDetailsAndActions instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountDetailsAndActions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountDetailsAndActions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.StatusDetail == input.StatusDetail ||
                    (this.StatusDetail != null &&
                    this.StatusDetail.Equals(input.StatusDetail))
                ) && 
                (
                    this.EndUserOriginId == input.EndUserOriginId ||
                    (this.EndUserOriginId != null &&
                    this.EndUserOriginId.Equals(input.EndUserOriginId))
                ) && 
                (
                    this.EndUserOrganizationName == input.EndUserOrganizationName ||
                    (this.EndUserOrganizationName != null &&
                    this.EndUserOrganizationName.Equals(input.EndUserOrganizationName))
                ) && 
                (
                    this.EndUserEmailAddress == input.EndUserEmailAddress ||
                    (this.EndUserEmailAddress != null &&
                    this.EndUserEmailAddress.Equals(input.EndUserEmailAddress))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.StatusDetail != null)
                    hashCode = hashCode * 59 + this.StatusDetail.GetHashCode();
                if (this.EndUserOriginId != null)
                    hashCode = hashCode * 59 + this.EndUserOriginId.GetHashCode();
                if (this.EndUserOrganizationName != null)
                    hashCode = hashCode * 59 + this.EndUserOrganizationName.GetHashCode();
                if (this.EndUserEmailAddress != null)
                    hashCode = hashCode * 59 + this.EndUserEmailAddress.GetHashCode();
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
            yield break;
        }
    }

}
