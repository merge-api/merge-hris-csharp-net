# Merge.HRISClient.Model.Employee
# The Employee Object ### Description The `Employee` object is used to represent an Employee for a company.  ### Usage Example Fetch from the `LIST Employee` endpoint and filter by `ID` to show all employees.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] [readonly] 
**RemoteId** | **string** | The third-party API ID of the matching object. | [optional] 
**EmployeeNumber** | **string** | The employee&#39;s number that appears in the remote UI. Note: This is distinct from the remote_id field, which is a unique identifier for the employee set by the remote API, and is not exposed to the user. | [optional] 
**Company** | **Guid?** | The ID of the employee&#39;s company. | [optional] 
**FirstName** | **string** | The employee&#39;s first name. | [optional] 
**LastName** | **string** | The employee&#39;s last name. | [optional] 
**DisplayFullName** | **string** | The employee&#39;s full name, to use for display purposes. If a preferred first name is available, the full name will include the preferred first name. | [optional] 
**WorkEmail** | **string** | The employee&#39;s work email. | [optional] 
**PersonalEmail** | **string** | The employee&#39;s personal email. | [optional] 
**MobilePhoneNumber** | **string** | The employee&#39;s mobile phone number. | [optional] 
**Employments** | **List&lt;Guid&gt;** | Array of &#x60;Employment&#x60; IDs for this Employee. | [optional] [readonly] 
**HomeLocation** | **Guid?** | The employee&#39;s home address. | [optional] 
**WorkLocation** | **Guid?** | The employee&#39;s work address. | [optional] 
**Manager** | **Guid?** | The employee ID of the employee&#39;s manager. | [optional] 
**Team** | **Guid?** | The employee&#39;s team. | [optional] 
**PayGroup** | **Guid?** | The employee&#39;s pay group | [optional] 
**Ssn** | **string** | The employee&#39;s social security number. | [optional] 
**Gender** | **string** |  | [optional] [readonly] 
**Ethnicity** | **string** |  | [optional] [readonly] 
**MaritalStatus** | **string** |  | [optional] [readonly] 
**DateOfBirth** | **DateTime?** | The employee&#39;s date of birth. | [optional] 
**HireDate** | **DateTime?** | The date that the employee was hired, usually the day that an offer letter is signed. If an employee has multiple hire dates from previous employments, this represents the most recent hire date. Note: If you&#39;re looking for the employee&#39;s start date, refer to the start_date field. | [optional] 
**StartDate** | **DateTime?** | The date that the employee started working. If an employee has multiple start dates from previous employments, this represents the most recent start date. | [optional] 
**EmploymentStatus** | **string** |  | [optional] [readonly] 
**TerminationDate** | **DateTime?** | The employee&#39;s termination date. | [optional] 
**Avatar** | **string** | The URL of the employee&#39;s avatar image. | [optional] 
**RemoteData** | [**List&lt;RemoteData&gt;**](RemoteData.md) |  | [optional] [readonly] 
**CustomFields** | **Dictionary&lt;string, Object&gt;** | Custom fields configured for a given model. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

