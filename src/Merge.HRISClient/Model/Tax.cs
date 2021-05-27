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
    /// # The Tax Object ### Description The &#x60;Tax&#x60; object is used to represent a tax for a given employee&#39;s payroll run. One run could include several taxes.  ### Usage Example Fetch from the &#x60;LIST Taxes&#x60; endpoint and filter by &#x60;ID&#x60; to show all taxes.
    /// </summary>
    [DataContract(Name = "Tax")]
    public partial class Tax : IEquatable<Tax>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Tax" /> class.
        /// </summary>
        /// <param name="employeePayrollRun">The tax&#39;s employee payroll run..</param>
        /// <param name="name">The tax&#39;s name..</param>
        /// <param name="amount">The tax amount..</param>
        /// <param name="employerTax">Whether or not the employer is responsible for paying the tax..</param>
        /// <param name="remoteData">remoteData.</param>
        public Tax(Guid? employeePayrollRun = default(Guid?), string name = default(string), float? amount = default(float?), bool? employerTax = default(bool?), List<Dictionary<string, Object>> remoteData = default(List<Dictionary<string, Object>>))
        {
            this.EmployeePayrollRun = employeePayrollRun;
            this.Name = name;
            this.Amount = amount;
            this.EmployerTax = employerTax;
            this.RemoteData = remoteData;
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
        /// The tax&#39;s employee payroll run.
        /// </summary>
        /// <value>The tax&#39;s employee payroll run.</value>
        [DataMember(Name = "employee_payroll_run", EmitDefaultValue = true)]
        public Guid? EmployeePayrollRun { get; set; }

        /// <summary>
        /// The tax&#39;s name.
        /// </summary>
        /// <value>The tax&#39;s name.</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The tax amount.
        /// </summary>
        /// <value>The tax amount.</value>
        [DataMember(Name = "amount", EmitDefaultValue = true)]
        public float? Amount { get; set; }

        /// <summary>
        /// Whether or not the employer is responsible for paying the tax.
        /// </summary>
        /// <value>Whether or not the employer is responsible for paying the tax.</value>
        [DataMember(Name = "employer_tax", EmitDefaultValue = true)]
        public bool? EmployerTax { get; set; }

        /// <summary>
        /// Gets or Sets RemoteData
        /// </summary>
        [DataMember(Name = "remote_data", EmitDefaultValue = true)]
        public List<Dictionary<string, Object>> RemoteData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Tax {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EmployeePayrollRun: ").Append(EmployeePayrollRun).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  EmployerTax: ").Append(EmployerTax).Append("\n");
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
            return this.Equals(input as Tax);
        }

        /// <summary>
        /// Returns true if Tax instances are equal
        /// </summary>
        /// <param name="input">Instance of Tax to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Tax input)
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
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.EmployerTax == input.EmployerTax ||
                    (this.EmployerTax != null &&
                    this.EmployerTax.Equals(input.EmployerTax))
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
                if (this.EmployeePayrollRun != null)
                    hashCode = hashCode * 59 + this.EmployeePayrollRun.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.EmployerTax != null)
                    hashCode = hashCode * 59 + this.EmployerTax.GetHashCode();
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
