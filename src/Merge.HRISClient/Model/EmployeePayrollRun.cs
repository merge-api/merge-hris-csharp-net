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
    /// # The EmployeePayrollRun Object ### Description The &#x60;EmployeePayrollRun&#x60; object is used to represent a payroll run for a specific employee.  ### Usage Example Fetch from the &#x60;LIST EmployeePayrollRun&#x60; endpoint and filter by &#x60;ID&#x60; to show all employee payroll runs.
    /// </summary>
    [DataContract(Name = "EmployeePayrollRun")]
    public partial class EmployeePayrollRun : IEquatable<EmployeePayrollRun>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeePayrollRun" /> class.
        /// </summary>
        /// <param name="remoteId">The third-party API ID of the matching object..</param>
        /// <param name="employee">employee.</param>
        /// <param name="payrollRun">payrollRun.</param>
        /// <param name="grossPay">The gross pay from the run..</param>
        /// <param name="netPay">The net pay from the run..</param>
        /// <param name="startDate">The day and time the payroll run started..</param>
        /// <param name="endDate">The day and time the payroll run ended..</param>
        /// <param name="checkDate">The day and time the payroll run was checked..</param>
        public EmployeePayrollRun(string remoteId = default(string), Guid? employee = default(Guid?), Guid? payrollRun = default(Guid?), float? grossPay = default(float?), float? netPay = default(float?), DateTime? startDate = default(DateTime?), DateTime? endDate = default(DateTime?), DateTime? checkDate = default(DateTime?))
        {
            this.RemoteId = remoteId;
            this.Employee = employee;
            this.PayrollRun = payrollRun;
            this.GrossPay = grossPay;
            this.NetPay = netPay;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.CheckDate = checkDate;
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
        /// Gets or Sets PayrollRun
        /// </summary>
        [DataMember(Name = "payroll_run", EmitDefaultValue = true)]
        public Guid? PayrollRun { get; set; }

        /// <summary>
        /// The gross pay from the run.
        /// </summary>
        /// <value>The gross pay from the run.</value>
        [DataMember(Name = "gross_pay", EmitDefaultValue = true)]
        public float? GrossPay { get; set; }

        /// <summary>
        /// The net pay from the run.
        /// </summary>
        /// <value>The net pay from the run.</value>
        [DataMember(Name = "net_pay", EmitDefaultValue = true)]
        public float? NetPay { get; set; }

        /// <summary>
        /// The day and time the payroll run started.
        /// </summary>
        /// <value>The day and time the payroll run started.</value>
        [DataMember(Name = "start_date", EmitDefaultValue = true)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// The day and time the payroll run ended.
        /// </summary>
        /// <value>The day and time the payroll run ended.</value>
        [DataMember(Name = "end_date", EmitDefaultValue = true)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// The day and time the payroll run was checked.
        /// </summary>
        /// <value>The day and time the payroll run was checked.</value>
        [DataMember(Name = "check_date", EmitDefaultValue = true)]
        public DateTime? CheckDate { get; set; }

        /// <summary>
        /// Gets or Sets Earnings
        /// </summary>
        [DataMember(Name = "earnings", EmitDefaultValue = false)]
        public List<Earning> Earnings { get; private set; }

        /// <summary>
        /// Returns false as Earnings should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeEarnings()
        {
            return false;
        }

        /// <summary>
        /// Gets or Sets Deductions
        /// </summary>
        [DataMember(Name = "deductions", EmitDefaultValue = false)]
        public List<Deduction> Deductions { get; private set; }

        /// <summary>
        /// Returns false as Deductions should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDeductions()
        {
            return false;
        }

        /// <summary>
        /// Gets or Sets Taxes
        /// </summary>
        [DataMember(Name = "taxes", EmitDefaultValue = false)]
        public List<Tax> Taxes { get; private set; }

        /// <summary>
        /// Returns false as Taxes should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTaxes()
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
            sb.Append("class EmployeePayrollRun {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  RemoteId: ").Append(RemoteId).Append("\n");
            sb.Append("  Employee: ").Append(Employee).Append("\n");
            sb.Append("  PayrollRun: ").Append(PayrollRun).Append("\n");
            sb.Append("  GrossPay: ").Append(GrossPay).Append("\n");
            sb.Append("  NetPay: ").Append(NetPay).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  CheckDate: ").Append(CheckDate).Append("\n");
            sb.Append("  Earnings: ").Append(Earnings).Append("\n");
            sb.Append("  Deductions: ").Append(Deductions).Append("\n");
            sb.Append("  Taxes: ").Append(Taxes).Append("\n");
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
            return this.Equals(input as EmployeePayrollRun);
        }

        /// <summary>
        /// Returns true if EmployeePayrollRun instances are equal
        /// </summary>
        /// <param name="input">Instance of EmployeePayrollRun to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmployeePayrollRun input)
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
                    this.PayrollRun == input.PayrollRun ||
                    (this.PayrollRun != null &&
                    this.PayrollRun.Equals(input.PayrollRun))
                ) && 
                (
                    this.GrossPay == input.GrossPay ||
                    (this.GrossPay != null &&
                    this.GrossPay.Equals(input.GrossPay))
                ) && 
                (
                    this.NetPay == input.NetPay ||
                    (this.NetPay != null &&
                    this.NetPay.Equals(input.NetPay))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.CheckDate == input.CheckDate ||
                    (this.CheckDate != null &&
                    this.CheckDate.Equals(input.CheckDate))
                ) && 
                (
                    this.Earnings == input.Earnings ||
                    this.Earnings != null &&
                    input.Earnings != null &&
                    this.Earnings.SequenceEqual(input.Earnings)
                ) && 
                (
                    this.Deductions == input.Deductions ||
                    this.Deductions != null &&
                    input.Deductions != null &&
                    this.Deductions.SequenceEqual(input.Deductions)
                ) && 
                (
                    this.Taxes == input.Taxes ||
                    this.Taxes != null &&
                    input.Taxes != null &&
                    this.Taxes.SequenceEqual(input.Taxes)
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
                if (this.PayrollRun != null)
                    hashCode = hashCode * 59 + this.PayrollRun.GetHashCode();
                if (this.GrossPay != null)
                    hashCode = hashCode * 59 + this.GrossPay.GetHashCode();
                if (this.NetPay != null)
                    hashCode = hashCode * 59 + this.NetPay.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.CheckDate != null)
                    hashCode = hashCode * 59 + this.CheckDate.GetHashCode();
                if (this.Earnings != null)
                    hashCode = hashCode * 59 + this.Earnings.GetHashCode();
                if (this.Deductions != null)
                    hashCode = hashCode * 59 + this.Deductions.GetHashCode();
                if (this.Taxes != null)
                    hashCode = hashCode * 59 + this.Taxes.GetHashCode();
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
