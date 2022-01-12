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
    /// # The Employment Object ### Description The &#x60;Employment&#x60; object is used to represent an employment position at a company. These are associated with the employee filling the role.  ### Usage Example Fetch from the &#x60;LIST Employments&#x60; endpoint and filter by &#x60;ID&#x60; to show all employees.
    /// </summary>
    [DataContract(Name = "Employment")]
    public partial class Employment : IEquatable<Employment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Employment" /> class.
        /// </summary>
        /// <param name="remoteId">The third-party API ID of the matching object..</param>
        /// <param name="employee">The employee holding this position..</param>
        /// <param name="jobTitle">The position&#39;s title..</param>
        /// <param name="payRate">The position&#39;s pay rate in dollars..</param>
        /// <param name="effectiveDate">The position&#39;s effective date..</param>
        public Employment(string remoteId = default(string), Guid? employee = default(Guid?), string jobTitle = default(string), float? payRate = default(float?), DateTime? effectiveDate = default(DateTime?))
        {
            this.RemoteId = remoteId;
            this.Employee = employee;
            this.JobTitle = jobTitle;
            this.PayRate = payRate;
            this.EffectiveDate = effectiveDate;
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
        /// The employee holding this position.
        /// </summary>
        /// <value>The employee holding this position.</value>
        [DataMember(Name = "employee", EmitDefaultValue = true)]
        public Guid? Employee { get; set; }

        /// <summary>
        /// The position&#39;s title.
        /// </summary>
        /// <value>The position&#39;s title.</value>
        [DataMember(Name = "job_title", EmitDefaultValue = true)]
        public string JobTitle { get; set; }

        /// <summary>
        /// The position&#39;s pay rate in dollars.
        /// </summary>
        /// <value>The position&#39;s pay rate in dollars.</value>
        [DataMember(Name = "pay_rate", EmitDefaultValue = true)]
        public float? PayRate { get; set; }

        /// <summary>
        /// Gets or Sets PayPeriod
        /// </summary>
        [DataMember(Name = "pay_period", EmitDefaultValue = false)]
        public string PayPeriod { get; private set; }

        /// <summary>
        /// Returns false as PayPeriod should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePayPeriod()
        {
            return false;
        }

        /// <summary>
        /// Gets or Sets PayFrequency
        /// </summary>
        [DataMember(Name = "pay_frequency", EmitDefaultValue = false)]
        public string PayFrequency { get; private set; }

        /// <summary>
        /// Returns false as PayFrequency should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePayFrequency()
        {
            return false;
        }

        /// <summary>
        /// Gets or Sets PayCurrency
        /// </summary>
        [DataMember(Name = "pay_currency", EmitDefaultValue = false)]
        public string PayCurrency { get; private set; }

        /// <summary>
        /// Returns false as PayCurrency should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePayCurrency()
        {
            return false;
        }

        /// <summary>
        /// Gets or Sets FlsaStatus
        /// </summary>
        [DataMember(Name = "flsa_status", EmitDefaultValue = false)]
        public string FlsaStatus { get; private set; }

        /// <summary>
        /// Returns false as FlsaStatus should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFlsaStatus()
        {
            return false;
        }

        /// <summary>
        /// The position&#39;s effective date.
        /// </summary>
        /// <value>The position&#39;s effective date.</value>
        [DataMember(Name = "effective_date", EmitDefaultValue = true)]
        public DateTime? EffectiveDate { get; set; }

        /// <summary>
        /// Gets or Sets EmploymentType
        /// </summary>
        [DataMember(Name = "employment_type", EmitDefaultValue = false)]
        public string EmploymentType { get; private set; }

        /// <summary>
        /// Returns false as EmploymentType should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeEmploymentType()
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
            sb.Append("class Employment {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  RemoteId: ").Append(RemoteId).Append("\n");
            sb.Append("  Employee: ").Append(Employee).Append("\n");
            sb.Append("  JobTitle: ").Append(JobTitle).Append("\n");
            sb.Append("  PayRate: ").Append(PayRate).Append("\n");
            sb.Append("  PayPeriod: ").Append(PayPeriod).Append("\n");
            sb.Append("  PayFrequency: ").Append(PayFrequency).Append("\n");
            sb.Append("  PayCurrency: ").Append(PayCurrency).Append("\n");
            sb.Append("  FlsaStatus: ").Append(FlsaStatus).Append("\n");
            sb.Append("  EffectiveDate: ").Append(EffectiveDate).Append("\n");
            sb.Append("  EmploymentType: ").Append(EmploymentType).Append("\n");
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
            return this.Equals(input as Employment);
        }

        /// <summary>
        /// Returns true if Employment instances are equal
        /// </summary>
        /// <param name="input">Instance of Employment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Employment input)
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
                    this.JobTitle == input.JobTitle ||
                    (this.JobTitle != null &&
                    this.JobTitle.Equals(input.JobTitle))
                ) && 
                (
                    this.PayRate == input.PayRate ||
                    (this.PayRate != null &&
                    this.PayRate.Equals(input.PayRate))
                ) && 
                (
                    this.PayPeriod == input.PayPeriod ||
                    (this.PayPeriod != null &&
                    this.PayPeriod.Equals(input.PayPeriod))
                ) && 
                (
                    this.PayFrequency == input.PayFrequency ||
                    (this.PayFrequency != null &&
                    this.PayFrequency.Equals(input.PayFrequency))
                ) && 
                (
                    this.PayCurrency == input.PayCurrency ||
                    (this.PayCurrency != null &&
                    this.PayCurrency.Equals(input.PayCurrency))
                ) && 
                (
                    this.FlsaStatus == input.FlsaStatus ||
                    (this.FlsaStatus != null &&
                    this.FlsaStatus.Equals(input.FlsaStatus))
                ) && 
                (
                    this.EffectiveDate == input.EffectiveDate ||
                    (this.EffectiveDate != null &&
                    this.EffectiveDate.Equals(input.EffectiveDate))
                ) && 
                (
                    this.EmploymentType == input.EmploymentType ||
                    (this.EmploymentType != null &&
                    this.EmploymentType.Equals(input.EmploymentType))
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
                if (this.JobTitle != null)
                    hashCode = hashCode * 59 + this.JobTitle.GetHashCode();
                if (this.PayRate != null)
                    hashCode = hashCode * 59 + this.PayRate.GetHashCode();
                if (this.PayPeriod != null)
                    hashCode = hashCode * 59 + this.PayPeriod.GetHashCode();
                if (this.PayFrequency != null)
                    hashCode = hashCode * 59 + this.PayFrequency.GetHashCode();
                if (this.PayCurrency != null)
                    hashCode = hashCode * 59 + this.PayCurrency.GetHashCode();
                if (this.FlsaStatus != null)
                    hashCode = hashCode * 59 + this.FlsaStatus.GetHashCode();
                if (this.EffectiveDate != null)
                    hashCode = hashCode * 59 + this.EffectiveDate.GetHashCode();
                if (this.EmploymentType != null)
                    hashCode = hashCode * 59 + this.EmploymentType.GetHashCode();
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
