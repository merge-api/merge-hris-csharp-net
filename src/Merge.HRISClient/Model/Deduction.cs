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
    /// # The Deduction Object ### Description The &#x60;Deduction&#x60; object is used to represent a deduction for a given employee&#39;s payroll run. One run could include several deductions.  ### Usage Example Fetch from the &#x60;LIST Deductions&#x60; endpoint and filter by &#x60;ID&#x60; to show all deductions.
    /// </summary>
    [DataContract(Name = "Deduction")]
    public partial class Deduction : IEquatable<Deduction>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Deduction" /> class.
        /// </summary>
        /// <param name="employeePayrollRun">employeePayrollRun.</param>
        /// <param name="name">The deduction&#39;s name..</param>
        /// <param name="employeeDeduction">The amount the employee is deducting..</param>
        /// <param name="companyDeduction">The amount the company is deducting..</param>
        /// <param name="remoteWasDeleted">Indicates whether or not this object has been deleted by third party webhooks..</param>
        public Deduction(Guid? employeePayrollRun = default(Guid?), string name = default(string), float? employeeDeduction = default(float?), float? companyDeduction = default(float?), bool remoteWasDeleted = default(bool))
        {
            this.EmployeePayrollRun = employeePayrollRun;
            this.Name = name;
            this.EmployeeDeduction = employeeDeduction;
            this.CompanyDeduction = companyDeduction;
            this.RemoteWasDeleted = remoteWasDeleted;
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
        /// Gets or Sets EmployeePayrollRun
        /// </summary>
        [DataMember(Name = "employee_payroll_run", EmitDefaultValue = true)]
        public Guid? EmployeePayrollRun { get; set; }

        /// <summary>
        /// The deduction&#39;s name.
        /// </summary>
        /// <value>The deduction&#39;s name.</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The amount the employee is deducting.
        /// </summary>
        /// <value>The amount the employee is deducting.</value>
        [DataMember(Name = "employee_deduction", EmitDefaultValue = true)]
        public float? EmployeeDeduction { get; set; }

        /// <summary>
        /// The amount the company is deducting.
        /// </summary>
        /// <value>The amount the company is deducting.</value>
        [DataMember(Name = "company_deduction", EmitDefaultValue = true)]
        public float? CompanyDeduction { get; set; }

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
        /// Indicates whether or not this object has been deleted by third party webhooks.
        /// </summary>
        /// <value>Indicates whether or not this object has been deleted by third party webhooks.</value>
        [DataMember(Name = "remote_was_deleted", EmitDefaultValue = true)]
        public bool RemoteWasDeleted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Deduction {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EmployeePayrollRun: ").Append(EmployeePayrollRun).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  EmployeeDeduction: ").Append(EmployeeDeduction).Append("\n");
            sb.Append("  CompanyDeduction: ").Append(CompanyDeduction).Append("\n");
            sb.Append("  RemoteData: ").Append(RemoteData).Append("\n");
            sb.Append("  RemoteWasDeleted: ").Append(RemoteWasDeleted).Append("\n");
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
            return this.Equals(input as Deduction);
        }

        /// <summary>
        /// Returns true if Deduction instances are equal
        /// </summary>
        /// <param name="input">Instance of Deduction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Deduction input)
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
                    this.EmployeePayrollRun == input.EmployeePayrollRun ||
                    (this.EmployeePayrollRun != null &&
                    this.EmployeePayrollRun.Equals(input.EmployeePayrollRun))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.EmployeeDeduction == input.EmployeeDeduction ||
                    (this.EmployeeDeduction != null &&
                    this.EmployeeDeduction.Equals(input.EmployeeDeduction))
                ) && 
                (
                    this.CompanyDeduction == input.CompanyDeduction ||
                    (this.CompanyDeduction != null &&
                    this.CompanyDeduction.Equals(input.CompanyDeduction))
                ) && 
                (
                    this.RemoteData == input.RemoteData ||
                    this.RemoteData != null &&
                    input.RemoteData != null &&
                    this.RemoteData.SequenceEqual(input.RemoteData)
                ) && 
                (
                    this.RemoteWasDeleted == input.RemoteWasDeleted ||
                    this.RemoteWasDeleted.Equals(input.RemoteWasDeleted)
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
                if (this.EmployeePayrollRun != null)
                    hashCode = hashCode * 59 + this.EmployeePayrollRun.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.EmployeeDeduction != null)
                    hashCode = hashCode * 59 + this.EmployeeDeduction.GetHashCode();
                if (this.CompanyDeduction != null)
                    hashCode = hashCode * 59 + this.CompanyDeduction.GetHashCode();
                if (this.RemoteData != null)
                    hashCode = hashCode * 59 + this.RemoteData.GetHashCode();
                hashCode = hashCode * 59 + this.RemoteWasDeleted.GetHashCode();
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
