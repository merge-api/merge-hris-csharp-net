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
    /// # The Employee Object ### Description The &#x60;Employee&#x60; object is used to represent any person who has been employed by a company.  ### Usage Example Fetch from the &#x60;LIST Employee&#x60; endpoint and filter by &#x60;ID&#x60; to show all employees.
    /// </summary>
    [DataContract(Name = "Employee")]
    public partial class Employee : IEquatable<Employee>, IValidatableObject
    {

        /// <summary>
        /// The employee&#39;s gender.  * &#x60;MALE&#x60; - MALE * &#x60;FEMALE&#x60; - FEMALE * &#x60;NON-BINARY&#x60; - NON-BINARY * &#x60;OTHER&#x60; - OTHER * &#x60;PREFER_NOT_TO_DISCLOSE&#x60; - PREFER_NOT_TO_DISCLOSE
        /// </summary>
        /// <value>The employee&#39;s gender.  * &#x60;MALE&#x60; - MALE * &#x60;FEMALE&#x60; - FEMALE * &#x60;NON-BINARY&#x60; - NON-BINARY * &#x60;OTHER&#x60; - OTHER * &#x60;PREFER_NOT_TO_DISCLOSE&#x60; - PREFER_NOT_TO_DISCLOSE</value>
        [DataMember(Name = "gender", EmitDefaultValue = true)]
        public GenderEnum? Gender { get; set; }

        /// <summary>
        /// The employee&#39;s ethnicity.  * &#x60;AMERICAN_INDIAN_OR_ALASKA_NATIVE&#x60; - AMERICAN_INDIAN_OR_ALASKA_NATIVE * &#x60;ASIAN_OR_INDIAN_SUBCONTINENT&#x60; - ASIAN_OR_INDIAN_SUBCONTINENT * &#x60;BLACK_OR_AFRICAN_AMERICAN&#x60; - BLACK_OR_AFRICAN_AMERICAN * &#x60;HISPANIC_OR_LATINO&#x60; - HISPANIC_OR_LATINO * &#x60;NATIVE_HAWAIIAN_OR_OTHER_PACIFIC_ISLANDER&#x60; - NATIVE_HAWAIIAN_OR_OTHER_PACIFIC_ISLANDER * &#x60;TWO_OR_MORE_RACES&#x60; - TWO_OR_MORE_RACES * &#x60;WHITE&#x60; - WHITE * &#x60;PREFER_NOT_TO_DISCLOSE&#x60; - PREFER_NOT_TO_DISCLOSE
        /// </summary>
        /// <value>The employee&#39;s ethnicity.  * &#x60;AMERICAN_INDIAN_OR_ALASKA_NATIVE&#x60; - AMERICAN_INDIAN_OR_ALASKA_NATIVE * &#x60;ASIAN_OR_INDIAN_SUBCONTINENT&#x60; - ASIAN_OR_INDIAN_SUBCONTINENT * &#x60;BLACK_OR_AFRICAN_AMERICAN&#x60; - BLACK_OR_AFRICAN_AMERICAN * &#x60;HISPANIC_OR_LATINO&#x60; - HISPANIC_OR_LATINO * &#x60;NATIVE_HAWAIIAN_OR_OTHER_PACIFIC_ISLANDER&#x60; - NATIVE_HAWAIIAN_OR_OTHER_PACIFIC_ISLANDER * &#x60;TWO_OR_MORE_RACES&#x60; - TWO_OR_MORE_RACES * &#x60;WHITE&#x60; - WHITE * &#x60;PREFER_NOT_TO_DISCLOSE&#x60; - PREFER_NOT_TO_DISCLOSE</value>
        [DataMember(Name = "ethnicity", EmitDefaultValue = true)]
        public EthnicityEnum? Ethnicity { get; set; }

        /// <summary>
        /// The employee&#39;s filing status as related to marital status.  * &#x60;SINGLE&#x60; - SINGLE * &#x60;MARRIED_FILING_JOINTLY&#x60; - MARRIED_FILING_JOINTLY * &#x60;MARRIED_FILING_SEPARATELY&#x60; - MARRIED_FILING_SEPARATELY * &#x60;HEAD_OF_HOUSEHOLD&#x60; - HEAD_OF_HOUSEHOLD * &#x60;QUALIFYING_WIDOW_OR_WIDOWER_WITH_DEPENDENT_CHILD&#x60; - QUALIFYING_WIDOW_OR_WIDOWER_WITH_DEPENDENT_CHILD
        /// </summary>
        /// <value>The employee&#39;s filing status as related to marital status.  * &#x60;SINGLE&#x60; - SINGLE * &#x60;MARRIED_FILING_JOINTLY&#x60; - MARRIED_FILING_JOINTLY * &#x60;MARRIED_FILING_SEPARATELY&#x60; - MARRIED_FILING_SEPARATELY * &#x60;HEAD_OF_HOUSEHOLD&#x60; - HEAD_OF_HOUSEHOLD * &#x60;QUALIFYING_WIDOW_OR_WIDOWER_WITH_DEPENDENT_CHILD&#x60; - QUALIFYING_WIDOW_OR_WIDOWER_WITH_DEPENDENT_CHILD</value>
        [DataMember(Name = "marital_status", EmitDefaultValue = true)]
        public MaritalStatusEnum? MaritalStatus { get; set; }

        /// <summary>
        /// The employment status of the employee.  * &#x60;ACTIVE&#x60; - ACTIVE * &#x60;PENDING&#x60; - PENDING * &#x60;INACTIVE&#x60; - INACTIVE
        /// </summary>
        /// <value>The employment status of the employee.  * &#x60;ACTIVE&#x60; - ACTIVE * &#x60;PENDING&#x60; - PENDING * &#x60;INACTIVE&#x60; - INACTIVE</value>
        [DataMember(Name = "employment_status", EmitDefaultValue = true)]
        public EmploymentStatusEnum? EmploymentStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Employee" /> class.
        /// </summary>
        /// <param name="remoteId">The third-party API ID of the matching object..</param>
        /// <param name="employeeNumber">The employee&#39;s number that appears in the third-party integration&#39;s UI..</param>
        /// <param name="company">The ID of the employee&#39;s company..</param>
        /// <param name="firstName">The employee&#39;s first name..</param>
        /// <param name="lastName">The employee&#39;s last name..</param>
        /// <param name="displayFullName">The employee&#39;s full name, to use for display purposes. If a preferred first name is available, the full name will include the preferred first name..</param>
        /// <param name="username">The employee&#39;s username that appears in the remote UI..</param>
        /// <param name="groups">groups.</param>
        /// <param name="workEmail">The employee&#39;s work email..</param>
        /// <param name="personalEmail">The employee&#39;s personal email..</param>
        /// <param name="mobilePhoneNumber">The employee&#39;s mobile phone number..</param>
        /// <param name="employments">Array of &#x60;Employment&#x60; IDs for this Employee..</param>
        /// <param name="homeLocation">The employee&#39;s home address..</param>
        /// <param name="workLocation">The employee&#39;s work address..</param>
        /// <param name="manager">The employee ID of the employee&#39;s manager..</param>
        /// <param name="team">The employee&#39;s team..</param>
        /// <param name="payGroup">The employee&#39;s pay group.</param>
        /// <param name="ssn">The employee&#39;s social security number..</param>
        /// <param name="gender">The employee&#39;s gender.  * &#x60;MALE&#x60; - MALE * &#x60;FEMALE&#x60; - FEMALE * &#x60;NON-BINARY&#x60; - NON-BINARY * &#x60;OTHER&#x60; - OTHER * &#x60;PREFER_NOT_TO_DISCLOSE&#x60; - PREFER_NOT_TO_DISCLOSE.</param>
        /// <param name="ethnicity">The employee&#39;s ethnicity.  * &#x60;AMERICAN_INDIAN_OR_ALASKA_NATIVE&#x60; - AMERICAN_INDIAN_OR_ALASKA_NATIVE * &#x60;ASIAN_OR_INDIAN_SUBCONTINENT&#x60; - ASIAN_OR_INDIAN_SUBCONTINENT * &#x60;BLACK_OR_AFRICAN_AMERICAN&#x60; - BLACK_OR_AFRICAN_AMERICAN * &#x60;HISPANIC_OR_LATINO&#x60; - HISPANIC_OR_LATINO * &#x60;NATIVE_HAWAIIAN_OR_OTHER_PACIFIC_ISLANDER&#x60; - NATIVE_HAWAIIAN_OR_OTHER_PACIFIC_ISLANDER * &#x60;TWO_OR_MORE_RACES&#x60; - TWO_OR_MORE_RACES * &#x60;WHITE&#x60; - WHITE * &#x60;PREFER_NOT_TO_DISCLOSE&#x60; - PREFER_NOT_TO_DISCLOSE.</param>
        /// <param name="maritalStatus">The employee&#39;s filing status as related to marital status.  * &#x60;SINGLE&#x60; - SINGLE * &#x60;MARRIED_FILING_JOINTLY&#x60; - MARRIED_FILING_JOINTLY * &#x60;MARRIED_FILING_SEPARATELY&#x60; - MARRIED_FILING_SEPARATELY * &#x60;HEAD_OF_HOUSEHOLD&#x60; - HEAD_OF_HOUSEHOLD * &#x60;QUALIFYING_WIDOW_OR_WIDOWER_WITH_DEPENDENT_CHILD&#x60; - QUALIFYING_WIDOW_OR_WIDOWER_WITH_DEPENDENT_CHILD.</param>
        /// <param name="dateOfBirth">The employee&#39;s date of birth..</param>
        /// <param name="hireDate">The date that the employee was hired, usually the day that an offer letter is signed. If an employee has multiple hire dates from previous employments, this represents the most recent hire date. Note: If you&#39;re looking for the employee&#39;s start date, refer to the start_date field..</param>
        /// <param name="startDate">The date that the employee started working. If an employee was rehired, the most recent start date will be returned..</param>
        /// <param name="remoteCreatedAt">When the third party&#39;s employee was created..</param>
        /// <param name="employmentStatus">The employment status of the employee.  * &#x60;ACTIVE&#x60; - ACTIVE * &#x60;PENDING&#x60; - PENDING * &#x60;INACTIVE&#x60; - INACTIVE.</param>
        /// <param name="terminationDate">The employee&#39;s termination date..</param>
        /// <param name="avatar">The URL of the employee&#39;s avatar image..</param>
        /// <param name="customFields">Custom fields configured for a given model..</param>
        public Employee(string remoteId = default(string), string employeeNumber = default(string), Guid? company = default(Guid?), string firstName = default(string), string lastName = default(string), string displayFullName = default(string), string username = default(string), List<Guid?> groups = default(List<Guid?>), string workEmail = default(string), string personalEmail = default(string), string mobilePhoneNumber = default(string), List<Guid?> employments = default(List<Guid?>), Guid? homeLocation = default(Guid?), Guid? workLocation = default(Guid?), Guid? manager = default(Guid?), Guid? team = default(Guid?), Guid? payGroup = default(Guid?), string ssn = default(string), GenderEnum? gender = default(GenderEnum?), EthnicityEnum? ethnicity = default(EthnicityEnum?), MaritalStatusEnum? maritalStatus = default(MaritalStatusEnum?), DateTime? dateOfBirth = default(DateTime?), DateTime? hireDate = default(DateTime?), DateTime? startDate = default(DateTime?), DateTime? remoteCreatedAt = default(DateTime?), EmploymentStatusEnum? employmentStatus = default(EmploymentStatusEnum?), DateTime? terminationDate = default(DateTime?), string avatar = default(string), Dictionary<string, Object> customFields = default(Dictionary<string, Object>))
        {
            this.RemoteId = remoteId;
            this.EmployeeNumber = employeeNumber;
            this.Company = company;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DisplayFullName = displayFullName;
            this.Username = username;
            this.Groups = groups;
            this.WorkEmail = workEmail;
            this.PersonalEmail = personalEmail;
            this.MobilePhoneNumber = mobilePhoneNumber;
            this.Employments = employments;
            this.HomeLocation = homeLocation;
            this.WorkLocation = workLocation;
            this.Manager = manager;
            this.Team = team;
            this.PayGroup = payGroup;
            this.Ssn = ssn;
            this.Gender = gender;
            this.Ethnicity = ethnicity;
            this.MaritalStatus = maritalStatus;
            this.DateOfBirth = dateOfBirth;
            this.HireDate = hireDate;
            this.StartDate = startDate;
            this.RemoteCreatedAt = remoteCreatedAt;
            this.EmploymentStatus = employmentStatus;
            this.TerminationDate = terminationDate;
            this.Avatar = avatar;
            this.CustomFields = customFields;
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
        /// The employee&#39;s number that appears in the third-party integration&#39;s UI.
        /// </summary>
        /// <value>The employee&#39;s number that appears in the third-party integration&#39;s UI.</value>
        [DataMember(Name = "employee_number", EmitDefaultValue = true)]
        public string EmployeeNumber { get; set; }

        /// <summary>
        /// The ID of the employee&#39;s company.
        /// </summary>
        /// <value>The ID of the employee&#39;s company.</value>
        [DataMember(Name = "company", EmitDefaultValue = true)]
        public Guid? Company { get; set; }

        /// <summary>
        /// The employee&#39;s first name.
        /// </summary>
        /// <value>The employee&#39;s first name.</value>
        [DataMember(Name = "first_name", EmitDefaultValue = true)]
        public string FirstName { get; set; }

        /// <summary>
        /// The employee&#39;s last name.
        /// </summary>
        /// <value>The employee&#39;s last name.</value>
        [DataMember(Name = "last_name", EmitDefaultValue = true)]
        public string LastName { get; set; }

        /// <summary>
        /// The employee&#39;s full name, to use for display purposes. If a preferred first name is available, the full name will include the preferred first name.
        /// </summary>
        /// <value>The employee&#39;s full name, to use for display purposes. If a preferred first name is available, the full name will include the preferred first name.</value>
        [DataMember(Name = "display_full_name", EmitDefaultValue = true)]
        public string DisplayFullName { get; set; }

        /// <summary>
        /// The employee&#39;s username that appears in the remote UI.
        /// </summary>
        /// <value>The employee&#39;s username that appears in the remote UI.</value>
        [DataMember(Name = "username", EmitDefaultValue = true)]
        public string Username { get; set; }

        /// <summary>
        /// Gets or Sets Groups
        /// </summary>
        [DataMember(Name = "groups", EmitDefaultValue = false)]
        public List<Guid?> Groups { get; set; }

        /// <summary>
        /// The employee&#39;s work email.
        /// </summary>
        /// <value>The employee&#39;s work email.</value>
        [DataMember(Name = "work_email", EmitDefaultValue = true)]
        public string WorkEmail { get; set; }

        /// <summary>
        /// The employee&#39;s personal email.
        /// </summary>
        /// <value>The employee&#39;s personal email.</value>
        [DataMember(Name = "personal_email", EmitDefaultValue = true)]
        public string PersonalEmail { get; set; }

        /// <summary>
        /// The employee&#39;s mobile phone number.
        /// </summary>
        /// <value>The employee&#39;s mobile phone number.</value>
        [DataMember(Name = "mobile_phone_number", EmitDefaultValue = true)]
        public string MobilePhoneNumber { get; set; }

        /// <summary>
        /// Array of &#x60;Employment&#x60; IDs for this Employee.
        /// </summary>
        /// <value>Array of &#x60;Employment&#x60; IDs for this Employee.</value>
        [DataMember(Name = "employments", EmitDefaultValue = false)]
        public List<Guid?> Employments { get; set; }

        /// <summary>
        /// The employee&#39;s home address.
        /// </summary>
        /// <value>The employee&#39;s home address.</value>
        [DataMember(Name = "home_location", EmitDefaultValue = true)]
        public Guid? HomeLocation { get; set; }

        /// <summary>
        /// The employee&#39;s work address.
        /// </summary>
        /// <value>The employee&#39;s work address.</value>
        [DataMember(Name = "work_location", EmitDefaultValue = true)]
        public Guid? WorkLocation { get; set; }

        /// <summary>
        /// The employee ID of the employee&#39;s manager.
        /// </summary>
        /// <value>The employee ID of the employee&#39;s manager.</value>
        [DataMember(Name = "manager", EmitDefaultValue = true)]
        public Guid? Manager { get; set; }

        /// <summary>
        /// The employee&#39;s team.
        /// </summary>
        /// <value>The employee&#39;s team.</value>
        [DataMember(Name = "team", EmitDefaultValue = true)]
        public Guid? Team { get; set; }

        /// <summary>
        /// The employee&#39;s pay group
        /// </summary>
        /// <value>The employee&#39;s pay group</value>
        [DataMember(Name = "pay_group", EmitDefaultValue = true)]
        public Guid? PayGroup { get; set; }

        /// <summary>
        /// The employee&#39;s social security number.
        /// </summary>
        /// <value>The employee&#39;s social security number.</value>
        [DataMember(Name = "ssn", EmitDefaultValue = true)]
        public string Ssn { get; set; }

        /// <summary>
        /// The employee&#39;s date of birth.
        /// </summary>
        /// <value>The employee&#39;s date of birth.</value>
        [DataMember(Name = "date_of_birth", EmitDefaultValue = true)]
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// The date that the employee was hired, usually the day that an offer letter is signed. If an employee has multiple hire dates from previous employments, this represents the most recent hire date. Note: If you&#39;re looking for the employee&#39;s start date, refer to the start_date field.
        /// </summary>
        /// <value>The date that the employee was hired, usually the day that an offer letter is signed. If an employee has multiple hire dates from previous employments, this represents the most recent hire date. Note: If you&#39;re looking for the employee&#39;s start date, refer to the start_date field.</value>
        [DataMember(Name = "hire_date", EmitDefaultValue = true)]
        public DateTime? HireDate { get; set; }

        /// <summary>
        /// The date that the employee started working. If an employee was rehired, the most recent start date will be returned.
        /// </summary>
        /// <value>The date that the employee started working. If an employee was rehired, the most recent start date will be returned.</value>
        [DataMember(Name = "start_date", EmitDefaultValue = true)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// When the third party&#39;s employee was created.
        /// </summary>
        /// <value>When the third party&#39;s employee was created.</value>
        [DataMember(Name = "remote_created_at", EmitDefaultValue = true)]
        public DateTime? RemoteCreatedAt { get; set; }

        /// <summary>
        /// The employee&#39;s termination date.
        /// </summary>
        /// <value>The employee&#39;s termination date.</value>
        [DataMember(Name = "termination_date", EmitDefaultValue = true)]
        public DateTime? TerminationDate { get; set; }

        /// <summary>
        /// The URL of the employee&#39;s avatar image.
        /// </summary>
        /// <value>The URL of the employee&#39;s avatar image.</value>
        [DataMember(Name = "avatar", EmitDefaultValue = true)]
        public string Avatar { get; set; }

        /// <summary>
        /// Custom fields configured for a given model.
        /// </summary>
        /// <value>Custom fields configured for a given model.</value>
        [DataMember(Name = "custom_fields", EmitDefaultValue = true)]
        public Dictionary<string, Object> CustomFields { get; set; }

        /// <summary>
        /// Gets or Sets RemoteWasDeleted
        /// </summary>
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
            sb.Append("class Employee {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  RemoteId: ").Append(RemoteId).Append("\n");
            sb.Append("  EmployeeNumber: ").Append(EmployeeNumber).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  DisplayFullName: ").Append(DisplayFullName).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
            sb.Append("  WorkEmail: ").Append(WorkEmail).Append("\n");
            sb.Append("  PersonalEmail: ").Append(PersonalEmail).Append("\n");
            sb.Append("  MobilePhoneNumber: ").Append(MobilePhoneNumber).Append("\n");
            sb.Append("  Employments: ").Append(Employments).Append("\n");
            sb.Append("  HomeLocation: ").Append(HomeLocation).Append("\n");
            sb.Append("  WorkLocation: ").Append(WorkLocation).Append("\n");
            sb.Append("  Manager: ").Append(Manager).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  PayGroup: ").Append(PayGroup).Append("\n");
            sb.Append("  Ssn: ").Append(Ssn).Append("\n");
            sb.Append("  Gender: ").Append(Gender).Append("\n");
            sb.Append("  Ethnicity: ").Append(Ethnicity).Append("\n");
            sb.Append("  MaritalStatus: ").Append(MaritalStatus).Append("\n");
            sb.Append("  DateOfBirth: ").Append(DateOfBirth).Append("\n");
            sb.Append("  HireDate: ").Append(HireDate).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  RemoteCreatedAt: ").Append(RemoteCreatedAt).Append("\n");
            sb.Append("  EmploymentStatus: ").Append(EmploymentStatus).Append("\n");
            sb.Append("  TerminationDate: ").Append(TerminationDate).Append("\n");
            sb.Append("  Avatar: ").Append(Avatar).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
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
            return this.Equals(input as Employee);
        }

        /// <summary>
        /// Returns true if Employee instances are equal
        /// </summary>
        /// <param name="input">Instance of Employee to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Employee input)
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
                    this.EmployeeNumber == input.EmployeeNumber ||
                    (this.EmployeeNumber != null &&
                    this.EmployeeNumber.Equals(input.EmployeeNumber))
                ) && 
                (
                    this.Company == input.Company ||
                    (this.Company != null &&
                    this.Company.Equals(input.Company))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.DisplayFullName == input.DisplayFullName ||
                    (this.DisplayFullName != null &&
                    this.DisplayFullName.Equals(input.DisplayFullName))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.Groups == input.Groups ||
                    this.Groups != null &&
                    input.Groups != null &&
                    this.Groups.SequenceEqual(input.Groups)
                ) && 
                (
                    this.WorkEmail == input.WorkEmail ||
                    (this.WorkEmail != null &&
                    this.WorkEmail.Equals(input.WorkEmail))
                ) && 
                (
                    this.PersonalEmail == input.PersonalEmail ||
                    (this.PersonalEmail != null &&
                    this.PersonalEmail.Equals(input.PersonalEmail))
                ) && 
                (
                    this.MobilePhoneNumber == input.MobilePhoneNumber ||
                    (this.MobilePhoneNumber != null &&
                    this.MobilePhoneNumber.Equals(input.MobilePhoneNumber))
                ) && 
                (
                    this.Employments == input.Employments ||
                    this.Employments != null &&
                    input.Employments != null &&
                    this.Employments.SequenceEqual(input.Employments)
                ) && 
                (
                    this.HomeLocation == input.HomeLocation ||
                    (this.HomeLocation != null &&
                    this.HomeLocation.Equals(input.HomeLocation))
                ) && 
                (
                    this.WorkLocation == input.WorkLocation ||
                    (this.WorkLocation != null &&
                    this.WorkLocation.Equals(input.WorkLocation))
                ) && 
                (
                    this.Manager == input.Manager ||
                    (this.Manager != null &&
                    this.Manager.Equals(input.Manager))
                ) && 
                (
                    this.Team == input.Team ||
                    (this.Team != null &&
                    this.Team.Equals(input.Team))
                ) && 
                (
                    this.PayGroup == input.PayGroup ||
                    (this.PayGroup != null &&
                    this.PayGroup.Equals(input.PayGroup))
                ) && 
                (
                    this.Ssn == input.Ssn ||
                    (this.Ssn != null &&
                    this.Ssn.Equals(input.Ssn))
                ) && 
                (
                    this.Gender == input.Gender ||
                    this.Gender.Equals(input.Gender)
                ) && 
                (
                    this.Ethnicity == input.Ethnicity ||
                    this.Ethnicity.Equals(input.Ethnicity)
                ) && 
                (
                    this.MaritalStatus == input.MaritalStatus ||
                    this.MaritalStatus.Equals(input.MaritalStatus)
                ) && 
                (
                    this.DateOfBirth == input.DateOfBirth ||
                    (this.DateOfBirth != null &&
                    this.DateOfBirth.Equals(input.DateOfBirth))
                ) && 
                (
                    this.HireDate == input.HireDate ||
                    (this.HireDate != null &&
                    this.HireDate.Equals(input.HireDate))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.RemoteCreatedAt == input.RemoteCreatedAt ||
                    (this.RemoteCreatedAt != null &&
                    this.RemoteCreatedAt.Equals(input.RemoteCreatedAt))
                ) && 
                (
                    this.EmploymentStatus == input.EmploymentStatus ||
                    this.EmploymentStatus.Equals(input.EmploymentStatus)
                ) && 
                (
                    this.TerminationDate == input.TerminationDate ||
                    (this.TerminationDate != null &&
                    this.TerminationDate.Equals(input.TerminationDate))
                ) && 
                (
                    this.Avatar == input.Avatar ||
                    (this.Avatar != null &&
                    this.Avatar.Equals(input.Avatar))
                ) && 
                (
                    this.CustomFields == input.CustomFields ||
                    this.CustomFields != null &&
                    input.CustomFields != null &&
                    this.CustomFields.SequenceEqual(input.CustomFields)
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
                if (this.EmployeeNumber != null)
                    hashCode = hashCode * 59 + this.EmployeeNumber.GetHashCode();
                if (this.Company != null)
                    hashCode = hashCode * 59 + this.Company.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.DisplayFullName != null)
                    hashCode = hashCode * 59 + this.DisplayFullName.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.Groups != null)
                    hashCode = hashCode * 59 + this.Groups.GetHashCode();
                if (this.WorkEmail != null)
                    hashCode = hashCode * 59 + this.WorkEmail.GetHashCode();
                if (this.PersonalEmail != null)
                    hashCode = hashCode * 59 + this.PersonalEmail.GetHashCode();
                if (this.MobilePhoneNumber != null)
                    hashCode = hashCode * 59 + this.MobilePhoneNumber.GetHashCode();
                if (this.Employments != null)
                    hashCode = hashCode * 59 + this.Employments.GetHashCode();
                if (this.HomeLocation != null)
                    hashCode = hashCode * 59 + this.HomeLocation.GetHashCode();
                if (this.WorkLocation != null)
                    hashCode = hashCode * 59 + this.WorkLocation.GetHashCode();
                if (this.Manager != null)
                    hashCode = hashCode * 59 + this.Manager.GetHashCode();
                if (this.Team != null)
                    hashCode = hashCode * 59 + this.Team.GetHashCode();
                if (this.PayGroup != null)
                    hashCode = hashCode * 59 + this.PayGroup.GetHashCode();
                if (this.Ssn != null)
                    hashCode = hashCode * 59 + this.Ssn.GetHashCode();
                hashCode = hashCode * 59 + this.Gender.GetHashCode();
                hashCode = hashCode * 59 + this.Ethnicity.GetHashCode();
                hashCode = hashCode * 59 + this.MaritalStatus.GetHashCode();
                if (this.DateOfBirth != null)
                    hashCode = hashCode * 59 + this.DateOfBirth.GetHashCode();
                if (this.HireDate != null)
                    hashCode = hashCode * 59 + this.HireDate.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.RemoteCreatedAt != null)
                    hashCode = hashCode * 59 + this.RemoteCreatedAt.GetHashCode();
                hashCode = hashCode * 59 + this.EmploymentStatus.GetHashCode();
                if (this.TerminationDate != null)
                    hashCode = hashCode * 59 + this.TerminationDate.GetHashCode();
                if (this.Avatar != null)
                    hashCode = hashCode * 59 + this.Avatar.GetHashCode();
                if (this.CustomFields != null)
                    hashCode = hashCode * 59 + this.CustomFields.GetHashCode();
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
            // WorkEmail (string) maxLength
            if(this.WorkEmail != null && this.WorkEmail.Length > 254)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for WorkEmail, length must be less than 254.", new [] { "WorkEmail" });
            }

            // PersonalEmail (string) maxLength
            if(this.PersonalEmail != null && this.PersonalEmail.Length > 254)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PersonalEmail, length must be less than 254.", new [] { "PersonalEmail" });
            }

            // Ssn (string) maxLength
            if(this.Ssn != null && this.Ssn.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Ssn, length must be less than 100.", new [] { "Ssn" });
            }

            // Avatar (string) maxLength
            if(this.Avatar != null && this.Avatar.Length > 2000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Avatar, length must be less than 2000.", new [] { "Avatar" });
            }

            yield break;
        }
    }

}
