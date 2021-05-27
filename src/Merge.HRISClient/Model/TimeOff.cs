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
    /// # The TimeOff Object ### Description The &#x60;TimeOff&#x60; object is used to represent a Time Off Request filed by an employee.  ### Usage Example Fetch from the &#x60;LIST TimeOffs&#x60; endpoint and filter by &#x60;ID&#x60; to show all time off requests.
    /// </summary>
    [DataContract(Name = "TimeOff")]
    public partial class TimeOff : IEquatable<TimeOff>, IValidatableObject
    {

        /// <summary>
        /// The status of this time off request.
        /// </summary>
        /// <value>The status of this time off request.</value>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public TimeOffStatusEnum? Status { get; set; }

        /// <summary>
        /// The unit of time requested.
        /// </summary>
        /// <value>The unit of time requested.</value>
        [DataMember(Name = "units", EmitDefaultValue = true)]
        public UnitsEnum? Units { get; set; }

        /// <summary>
        /// The type of time off request.
        /// </summary>
        /// <value>The type of time off request.</value>
        [DataMember(Name = "request_type", EmitDefaultValue = true)]
        public RequestTypeEnum? RequestType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeOff" /> class.
        /// </summary>
        /// <param name="remoteId">The third-party API ID of the matching object..</param>
        /// <param name="employee">The employee requesting time off..</param>
        /// <param name="approver">The employee approving the time off request..</param>
        /// <param name="status">The status of this time off request..</param>
        /// <param name="employeeNote">The employee note for this time off request..</param>
        /// <param name="units">The unit of time requested..</param>
        /// <param name="amount">The number of time off units requested..</param>
        /// <param name="requestType">The type of time off request..</param>
        /// <param name="startTime">The day and time of the start of the time requested off..</param>
        /// <param name="endTime">The day and time of the end of the time requested off..</param>
        public TimeOff(string remoteId = default(string), Guid? employee = default(Guid?), Guid? approver = default(Guid?), TimeOffStatusEnum? status = default(TimeOffStatusEnum?), string employeeNote = default(string), UnitsEnum? units = default(UnitsEnum?), float? amount = default(float?), RequestTypeEnum? requestType = default(RequestTypeEnum?), DateTime? startTime = default(DateTime?), DateTime? endTime = default(DateTime?))
        {
            this.RemoteId = remoteId;
            this.Employee = employee;
            this.Approver = approver;
            this.Status = status;
            this.EmployeeNote = employeeNote;
            this.Units = units;
            this.Amount = amount;
            this.RequestType = requestType;
            this.StartTime = startTime;
            this.EndTime = endTime;
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
        /// The employee requesting time off.
        /// </summary>
        /// <value>The employee requesting time off.</value>
        [DataMember(Name = "employee", EmitDefaultValue = true)]
        public Guid? Employee { get; set; }

        /// <summary>
        /// The employee approving the time off request.
        /// </summary>
        /// <value>The employee approving the time off request.</value>
        [DataMember(Name = "approver", EmitDefaultValue = true)]
        public Guid? Approver { get; set; }

        /// <summary>
        /// The employee note for this time off request.
        /// </summary>
        /// <value>The employee note for this time off request.</value>
        [DataMember(Name = "employee_note", EmitDefaultValue = true)]
        public string EmployeeNote { get; set; }

        /// <summary>
        /// The number of time off units requested.
        /// </summary>
        /// <value>The number of time off units requested.</value>
        [DataMember(Name = "amount", EmitDefaultValue = true)]
        public float? Amount { get; set; }

        /// <summary>
        /// The day and time of the start of the time requested off.
        /// </summary>
        /// <value>The day and time of the start of the time requested off.</value>
        [DataMember(Name = "start_time", EmitDefaultValue = true)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// The day and time of the end of the time requested off.
        /// </summary>
        /// <value>The day and time of the end of the time requested off.</value>
        [DataMember(Name = "end_time", EmitDefaultValue = true)]
        public DateTime? EndTime { get; set; }

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
            sb.Append("class TimeOff {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  RemoteId: ").Append(RemoteId).Append("\n");
            sb.Append("  Employee: ").Append(Employee).Append("\n");
            sb.Append("  Approver: ").Append(Approver).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  EmployeeNote: ").Append(EmployeeNote).Append("\n");
            sb.Append("  Units: ").Append(Units).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  RequestType: ").Append(RequestType).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
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
            return this.Equals(input as TimeOff);
        }

        /// <summary>
        /// Returns true if TimeOff instances are equal
        /// </summary>
        /// <param name="input">Instance of TimeOff to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimeOff input)
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
                    this.Approver == input.Approver ||
                    (this.Approver != null &&
                    this.Approver.Equals(input.Approver))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.EmployeeNote == input.EmployeeNote ||
                    (this.EmployeeNote != null &&
                    this.EmployeeNote.Equals(input.EmployeeNote))
                ) && 
                (
                    this.Units == input.Units ||
                    this.Units.Equals(input.Units)
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.RequestType == input.RequestType ||
                    this.RequestType.Equals(input.RequestType)
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
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
                if (this.Approver != null)
                    hashCode = hashCode * 59 + this.Approver.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.EmployeeNote != null)
                    hashCode = hashCode * 59 + this.EmployeeNote.GetHashCode();
                hashCode = hashCode * 59 + this.Units.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                hashCode = hashCode * 59 + this.RequestType.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
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
