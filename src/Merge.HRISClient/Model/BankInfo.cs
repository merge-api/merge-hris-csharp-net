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
    /// # The BankInfo Object ### Description The &#x60;BankInfo&#x60; object is used to represent the Bank Account information for an Employee.  ### Usage Example Fetch from the &#x60;LIST BankInfo&#x60; endpoint and filter by &#x60;ID&#x60; to show all bank information.
    /// </summary>
    [DataContract(Name = "BankInfo")]
    public partial class BankInfo : IEquatable<BankInfo>, IValidatableObject
    {

        /// <summary>
        /// The bank account type  * &#x60;SAVINGS&#x60; - SAVINGS * &#x60;CHECKING&#x60; - CHECKING
        /// </summary>
        /// <value>The bank account type  * &#x60;SAVINGS&#x60; - SAVINGS * &#x60;CHECKING&#x60; - CHECKING</value>
        [DataMember(Name = "account_type", EmitDefaultValue = true)]
        public AccountTypeEnum? AccountType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BankInfo" /> class.
        /// </summary>
        /// <param name="remoteId">The third-party API ID of the matching object..</param>
        /// <param name="employee">The employee with this bank account..</param>
        /// <param name="accountNumber">The account number..</param>
        /// <param name="routingNumber">The routing number..</param>
        /// <param name="bankName">The bank name..</param>
        /// <param name="accountType">The bank account type  * &#x60;SAVINGS&#x60; - SAVINGS * &#x60;CHECKING&#x60; - CHECKING.</param>
        /// <param name="remoteCreatedAt">When the matching bank object was created in the third party system..</param>
        public BankInfo(string remoteId = default(string), Guid? employee = default(Guid?), string accountNumber = default(string), string routingNumber = default(string), string bankName = default(string), AccountTypeEnum? accountType = default(AccountTypeEnum?), DateTime? remoteCreatedAt = default(DateTime?))
        {
            this.RemoteId = remoteId;
            this.Employee = employee;
            this.AccountNumber = accountNumber;
            this.RoutingNumber = routingNumber;
            this.BankName = bankName;
            this.AccountType = accountType;
            this.RemoteCreatedAt = remoteCreatedAt;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; private set; }

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return false;
        }

        /// <summary>
        /// The third-party API ID of the matching object.
        /// </summary>
        /// <value>The third-party API ID of the matching object.</value>
        [DataMember(Name = "remote_id", EmitDefaultValue = true)]
        public string RemoteId { get; set; }

        /// <summary>
        /// The employee with this bank account.
        /// </summary>
        /// <value>The employee with this bank account.</value>
        [DataMember(Name = "employee", EmitDefaultValue = true)]
        public Guid? Employee { get; set; }

        /// <summary>
        /// The account number.
        /// </summary>
        /// <value>The account number.</value>
        [DataMember(Name = "account_number", EmitDefaultValue = true)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// The routing number.
        /// </summary>
        /// <value>The routing number.</value>
        [DataMember(Name = "routing_number", EmitDefaultValue = true)]
        public string RoutingNumber { get; set; }

        /// <summary>
        /// The bank name.
        /// </summary>
        /// <value>The bank name.</value>
        [DataMember(Name = "bank_name", EmitDefaultValue = true)]
        public string BankName { get; set; }

        /// <summary>
        /// When the matching bank object was created in the third party system.
        /// </summary>
        /// <value>When the matching bank object was created in the third party system.</value>
        [DataMember(Name = "remote_created_at", EmitDefaultValue = true)]
        public DateTime? RemoteCreatedAt { get; set; }

        /// <summary>
        /// Indicates whether or not this object has been deleted by third party webhooks.
        /// </summary>
        /// <value>Indicates whether or not this object has been deleted by third party webhooks.</value>
        [DataMember(Name = "remote_was_deleted", EmitDefaultValue = true)]
        public bool RemoteWasDeleted { get; private set; }

        /// <summary>
        /// Returns false as RemoteWasDeleted should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRemoteWasDeleted()
        {
            return false;
        }

        /// <summary>
        /// Gets or Sets FieldMappings
        /// </summary>
        [DataMember(Name = "field_mappings", EmitDefaultValue = true)]
        public Dictionary<string, Object> FieldMappings { get; private set; }

        /// <summary>
        /// Returns false as FieldMappings should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFieldMappings()
        {
            return false;
        }

        /// <summary>
        /// This is the datetime that this object was last updated by Merge
        /// </summary>
        /// <value>This is the datetime that this object was last updated by Merge</value>
        [DataMember(Name = "modified_at", EmitDefaultValue = false)]
        public DateTime ModifiedAt { get; private set; }

        /// <summary>
        /// Returns false as ModifiedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeModifiedAt()
        {
            return false;
        }

        /// <summary>
        /// Gets or Sets RemoteData
        /// </summary>
        [DataMember(Name = "remote_data", EmitDefaultValue = true)]
        public List<RemoteData> RemoteData { get; private set; }

        /// <summary>
        /// Returns false as RemoteData should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRemoteData()
        {
            return false;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BankInfo {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  RemoteId: ").Append(RemoteId).Append("\n");
            sb.Append("  Employee: ").Append(Employee).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  RoutingNumber: ").Append(RoutingNumber).Append("\n");
            sb.Append("  BankName: ").Append(BankName).Append("\n");
            sb.Append("  AccountType: ").Append(AccountType).Append("\n");
            sb.Append("  RemoteCreatedAt: ").Append(RemoteCreatedAt).Append("\n");
            sb.Append("  RemoteWasDeleted: ").Append(RemoteWasDeleted).Append("\n");
            sb.Append("  FieldMappings: ").Append(FieldMappings).Append("\n");
            sb.Append("  ModifiedAt: ").Append(ModifiedAt).Append("\n");
            sb.Append("  RemoteData: ").Append(RemoteData).Append("\n");
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
            return this.Equals(input as BankInfo);
        }

        /// <summary>
        /// Returns true if BankInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of BankInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BankInfo input)
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
                    this.RemoteId == input.RemoteId ||
                    (this.RemoteId != null &&
                    this.RemoteId.Equals(input.RemoteId))
                ) && 
                (
                    this.Employee == input.Employee ||
                    (this.Employee != null &&
                    this.Employee.Equals(input.Employee))
                ) && 
                (
                    this.AccountNumber == input.AccountNumber ||
                    (this.AccountNumber != null &&
                    this.AccountNumber.Equals(input.AccountNumber))
                ) && 
                (
                    this.RoutingNumber == input.RoutingNumber ||
                    (this.RoutingNumber != null &&
                    this.RoutingNumber.Equals(input.RoutingNumber))
                ) && 
                (
                    this.BankName == input.BankName ||
                    (this.BankName != null &&
                    this.BankName.Equals(input.BankName))
                ) && 
                (
                    this.AccountType == input.AccountType ||
                    this.AccountType.Equals(input.AccountType)
                ) && 
                (
                    this.RemoteCreatedAt == input.RemoteCreatedAt ||
                    (this.RemoteCreatedAt != null &&
                    this.RemoteCreatedAt.Equals(input.RemoteCreatedAt))
                ) && 
                (
                    this.RemoteWasDeleted == input.RemoteWasDeleted ||
                    this.RemoteWasDeleted.Equals(input.RemoteWasDeleted)
                ) && 
                (
                    this.FieldMappings == input.FieldMappings ||
                    this.FieldMappings != null &&
                    input.FieldMappings != null &&
                    this.FieldMappings.SequenceEqual(input.FieldMappings)
                ) && 
                (
                    this.ModifiedAt == input.ModifiedAt ||
                    (this.ModifiedAt != null &&
                    this.ModifiedAt.Equals(input.ModifiedAt))
                ) && 
                (
                    this.RemoteData == input.RemoteData ||
                    this.RemoteData != null &&
                    input.RemoteData != null &&
                    this.RemoteData.SequenceEqual(input.RemoteData)
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
                if (this.RemoteId != null)
                    hashCode = hashCode * 59 + this.RemoteId.GetHashCode();
                if (this.Employee != null)
                    hashCode = hashCode * 59 + this.Employee.GetHashCode();
                if (this.AccountNumber != null)
                    hashCode = hashCode * 59 + this.AccountNumber.GetHashCode();
                if (this.RoutingNumber != null)
                    hashCode = hashCode * 59 + this.RoutingNumber.GetHashCode();
                if (this.BankName != null)
                    hashCode = hashCode * 59 + this.BankName.GetHashCode();
                hashCode = hashCode * 59 + this.AccountType.GetHashCode();
                if (this.RemoteCreatedAt != null)
                    hashCode = hashCode * 59 + this.RemoteCreatedAt.GetHashCode();
                hashCode = hashCode * 59 + this.RemoteWasDeleted.GetHashCode();
                if (this.FieldMappings != null)
                    hashCode = hashCode * 59 + this.FieldMappings.GetHashCode();
                if (this.ModifiedAt != null)
                    hashCode = hashCode * 59 + this.ModifiedAt.GetHashCode();
                if (this.RemoteData != null)
                    hashCode = hashCode * 59 + this.RemoteData.GetHashCode();
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
            // AccountNumber (string) maxLength
            if(this.AccountNumber != null && this.AccountNumber.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AccountNumber, length must be less than 100.", new [] { "AccountNumber" });
            }

            yield break;
        }
    }

}
