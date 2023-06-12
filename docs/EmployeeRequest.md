# Merge.HRISClient.Model.EmployeeRequest
# The Employee Object ### Description The `Employee` object is used to represent any person who has been employed by a company.  ### Usage Example Fetch from the `LIST Employee` endpoint and filter by `ID` to show all employees.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EmployeeNumber** | **string** | The employee&#39;s number that appears in the third-party integration&#39;s UI. | [optional] 
**Company** | **Guid?** | The ID of the employee&#39;s company. | [optional] 
**FirstName** | **string** | The employee&#39;s first name. | [optional] 
**LastName** | **string** | The employee&#39;s last name. | [optional] 
**DisplayFullName** | **string** | The employee&#39;s full name, to use for display purposes. If a preferred first name is available, the full name will include the preferred first name. | [optional] 
**Username** | **string** | The employee&#39;s username that appears in the remote UI. | [optional] 
**Groups** | **List&lt;Guid?&gt;** |  | [optional] 
**WorkEmail** | **string** | The employee&#39;s work email. | [optional] 
**PersonalEmail** | **string** | The employee&#39;s personal email. | [optional] 
**MobilePhoneNumber** | **string** | The employee&#39;s mobile phone number. | [optional] 
**Employments** | **List&lt;Guid?&gt;** | Array of &#x60;Employment&#x60; IDs for this Employee. | [optional] 
**HomeLocation** | **Guid?** | The employee&#39;s home address. | [optional] 
**WorkLocation** | **Guid?** | The employee&#39;s work address. | [optional] 
**Manager** | **Guid?** | The employee ID of the employee&#39;s manager. | [optional] 
**Team** | **Guid?** | The employee&#39;s team. | [optional] 
**PayGroup** | **Guid?** | The employee&#39;s pay group | [optional] 
**Ssn** | **string** | The employee&#39;s social security number. | [optional] 
**Gender** | **GenderEnum** | The employee&#39;s gender.  * &#x60;MALE&#x60; - MALE * &#x60;FEMALE&#x60; - FEMALE * &#x60;NON-BINARY&#x60; - NON-BINARY * &#x60;OTHER&#x60; - OTHER * &#x60;PREFER_NOT_TO_DISCLOSE&#x60; - PREFER_NOT_TO_DISCLOSE | [optional] 
**Ethnicity** | **EthnicityEnum** | The employee&#39;s ethnicity.  * &#x60;AMERICAN_INDIAN_OR_ALASKA_NATIVE&#x60; - AMERICAN_INDIAN_OR_ALASKA_NATIVE * &#x60;ASIAN_OR_INDIAN_SUBCONTINENT&#x60; - ASIAN_OR_INDIAN_SUBCONTINENT * &#x60;BLACK_OR_AFRICAN_AMERICAN&#x60; - BLACK_OR_AFRICAN_AMERICAN * &#x60;HISPANIC_OR_LATINO&#x60; - HISPANIC_OR_LATINO * &#x60;NATIVE_HAWAIIAN_OR_OTHER_PACIFIC_ISLANDER&#x60; - NATIVE_HAWAIIAN_OR_OTHER_PACIFIC_ISLANDER * &#x60;TWO_OR_MORE_RACES&#x60; - TWO_OR_MORE_RACES * &#x60;WHITE&#x60; - WHITE * &#x60;PREFER_NOT_TO_DISCLOSE&#x60; - PREFER_NOT_TO_DISCLOSE | [optional] 
**MaritalStatus** | **MaritalStatusEnum** | The employee&#39;s filing status as related to marital status.  * &#x60;SINGLE&#x60; - SINGLE * &#x60;MARRIED_FILING_JOINTLY&#x60; - MARRIED_FILING_JOINTLY * &#x60;MARRIED_FILING_SEPARATELY&#x60; - MARRIED_FILING_SEPARATELY * &#x60;HEAD_OF_HOUSEHOLD&#x60; - HEAD_OF_HOUSEHOLD * &#x60;QUALIFYING_WIDOW_OR_WIDOWER_WITH_DEPENDENT_CHILD&#x60; - QUALIFYING_WIDOW_OR_WIDOWER_WITH_DEPENDENT_CHILD | [optional] 
**DateOfBirth** | **DateTime?** | The employee&#39;s date of birth. | [optional] 
**HireDate** | **DateTime?** | The date that the employee was hired, usually the day that an offer letter is signed. If an employee has multiple hire dates from previous employments, this represents the most recent hire date. Note: If you&#39;re looking for the employee&#39;s start date, refer to the start_date field. | [optional] 
**StartDate** | **DateTime?** | The date that the employee started working. If an employee was rehired, the most recent start date will be returned. | [optional] 
**EmploymentStatus** | **EmploymentStatusEnum** | The employment status of the employee.  * &#x60;ACTIVE&#x60; - ACTIVE * &#x60;PENDING&#x60; - PENDING * &#x60;INACTIVE&#x60; - INACTIVE | [optional] 
**TerminationDate** | **DateTime?** | The employee&#39;s termination date. | [optional] 
**Avatar** | **string** | The URL of the employee&#39;s avatar image. | [optional] 
**IntegrationParams** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**LinkedAccountParams** | **Dictionary&lt;string, Object&gt;** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

