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
    /// # The TimeOffBalance Object ### Description The &#x60;TimeOffBalance&#x60; object is used to represent a Time Off Balance for an employee.  ### Usage Example Fetch from the &#x60;LIST TimeOffBalances&#x60; endpoint and filter by &#x60;ID&#x60; to show all time off balances.
    /// </summary>
    [DataContract(Name = "TimeOffBalance")]
    public partial class TimeOffBalance : IEquatable<TimeOffBalance>, IValidatableObject
    {

        /// <summary>
        /// The policy type of this time off balance.
        /// </summary>
        /// <value>The policy type of this time off balance.</value>
        [DataMember(Name = "policy_type", EmitDefaultValue = true)]
        public PolicyTypeEnum? PolicyType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeOffBalance" /> class.
        /// </summary>
        /// <param name="remoteId">The third-party API ID of the matching object..</param>
        /// <param name="employee">employee.</param>
        /// <param name="balance">The current PTO balance in terms of hours..</param>
        /// <param name="used">The amount of PTO used in terms of hours..</param>
        /// <param name="policyType">The policy type of this time off balance..</param>
        public TimeOffBalance(string remoteId = default(string), Guid? employee = default(Guid?), float? balance = default(float?), float? used = default(float?), PolicyTypeEnum? policyType = default(PolicyTypeEnum?))
        {
            this.RemoteId = remoteId;
            this.Employee = employee;
            this.Balance = balance;
            this.Used = used;
            this.PolicyType = policyType;
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
        /// Gets or Sets Employee
        /// </summary>
        [DataMember(Name = "employee", EmitDefaultValue = true)]
        public Guid? Employee { get; set; }

        /// <summary>
        /// The current PTO balance in terms of hours.
        /// </summary>
        /// <value>The current PTO balance in terms of hours.</value>
        [DataMember(Name = "balance", EmitDefaultValue = true)]
        public float? Balance { get; set; }

        /// <summary>
        /// The amount of PTO used in terms of hours.
        /// </summary>
        /// <value>The amount of PTO used in terms of hours.</value>
        [DataMember(Name = "used", EmitDefaultValue = true)]
        public float? Used { get; set; }

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
            sb.Append("class TimeOffBalance {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  RemoteId: ").Append(RemoteId).Append("\n");
            sb.Append("  Employee: ").Append(Employee).Append("\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
            sb.Append("  Used: ").Append(Used).Append("\n");
            sb.Append("  PolicyType: ").Append(PolicyType).Append("\n");
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
            return this.Equals(input as TimeOffBalance);
        }

        /// <summary>
        /// Returns true if TimeOffBalance instances are equal
        /// </summary>
        /// <param name="input">Instance of TimeOffBalance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimeOffBalance input)
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
                    this.Balance == input.Balance ||
                    (this.Balance != null &&
                    this.Balance.Equals(input.Balance))
                ) && 
                (
                    this.Used == input.Used ||
                    (this.Used != null &&
                    this.Used.Equals(input.Used))
                ) && 
                (
                    this.PolicyType == input.PolicyType ||
                    this.PolicyType.Equals(input.PolicyType)
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
                if (this.Balance != null)
                    hashCode = hashCode * 59 + this.Balance.GetHashCode();
                if (this.Used != null)
                    hashCode = hashCode * 59 + this.Used.GetHashCode();
                hashCode = hashCode * 59 + this.PolicyType.GetHashCode();
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
            yield break;
        }
    }

}
