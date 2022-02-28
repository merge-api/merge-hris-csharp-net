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
    /// # The Benefit Object ### Description The &#x60;Benefit&#x60; object is used to represent a Benefit for an employee.  ### Usage Example Fetch from the &#x60;LIST Benefits&#x60; endpoint and filter by &#x60;ID&#x60; to show all benefits.
    /// </summary>
    [DataContract(Name = "Benefit")]
    public partial class Benefit : IEquatable<Benefit>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Benefit" /> class.
        /// </summary>
        /// <param name="remoteId">The third-party API ID of the matching object..</param>
        /// <param name="employee">employee.</param>
        /// <param name="providerName">The name of the benefit provider..</param>
        /// <param name="benefitPlanType">The type of benefit plan.</param>
        /// <param name="employeeContribution">The employee&#39;s contribution..</param>
        /// <param name="companyContribution">The company&#39;s contribution..</param>
        public Benefit(string remoteId = default(string), Guid? employee = default(Guid?), string providerName = default(string), string benefitPlanType = default(string), float? employeeContribution = default(float?), float? companyContribution = default(float?))
        {
            this.RemoteId = remoteId;
            this.Employee = employee;
            this.ProviderName = providerName;
            this.BenefitPlanType = benefitPlanType;
            this.EmployeeContribution = employeeContribution;
            this.CompanyContribution = companyContribution;
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
        /// The name of the benefit provider.
        /// </summary>
        /// <value>The name of the benefit provider.</value>
        [DataMember(Name = "provider_name", EmitDefaultValue = true)]
        public string ProviderName { get; set; }

        /// <summary>
        /// The type of benefit plan
        /// </summary>
        /// <value>The type of benefit plan</value>
        [DataMember(Name = "benefit_plan_type", EmitDefaultValue = true)]
        public string BenefitPlanType { get; set; }

        /// <summary>
        /// The employee&#39;s contribution.
        /// </summary>
        /// <value>The employee&#39;s contribution.</value>
        [DataMember(Name = "employee_contribution", EmitDefaultValue = true)]
        public float? EmployeeContribution { get; set; }

        /// <summary>
        /// The company&#39;s contribution.
        /// </summary>
        /// <value>The company&#39;s contribution.</value>
        [DataMember(Name = "company_contribution", EmitDefaultValue = true)]
        public float? CompanyContribution { get; set; }

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
            sb.Append("class Benefit {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  RemoteId: ").Append(RemoteId).Append("\n");
            sb.Append("  Employee: ").Append(Employee).Append("\n");
            sb.Append("  ProviderName: ").Append(ProviderName).Append("\n");
            sb.Append("  BenefitPlanType: ").Append(BenefitPlanType).Append("\n");
            sb.Append("  EmployeeContribution: ").Append(EmployeeContribution).Append("\n");
            sb.Append("  CompanyContribution: ").Append(CompanyContribution).Append("\n");
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
            return this.Equals(input as Benefit);
        }

        /// <summary>
        /// Returns true if Benefit instances are equal
        /// </summary>
        /// <param name="input">Instance of Benefit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Benefit input)
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
                    this.ProviderName == input.ProviderName ||
                    (this.ProviderName != null &&
                    this.ProviderName.Equals(input.ProviderName))
                ) && 
                (
                    this.BenefitPlanType == input.BenefitPlanType ||
                    (this.BenefitPlanType != null &&
                    this.BenefitPlanType.Equals(input.BenefitPlanType))
                ) && 
                (
                    this.EmployeeContribution == input.EmployeeContribution ||
                    (this.EmployeeContribution != null &&
                    this.EmployeeContribution.Equals(input.EmployeeContribution))
                ) && 
                (
                    this.CompanyContribution == input.CompanyContribution ||
                    (this.CompanyContribution != null &&
                    this.CompanyContribution.Equals(input.CompanyContribution))
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
                if (this.ProviderName != null)
                    hashCode = hashCode * 59 + this.ProviderName.GetHashCode();
                if (this.BenefitPlanType != null)
                    hashCode = hashCode * 59 + this.BenefitPlanType.GetHashCode();
                if (this.EmployeeContribution != null)
                    hashCode = hashCode * 59 + this.EmployeeContribution.GetHashCode();
                if (this.CompanyContribution != null)
                    hashCode = hashCode * 59 + this.CompanyContribution.GetHashCode();
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
