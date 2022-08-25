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
    /// LinkedAccountStatus
    /// </summary>
    [DataContract(Name = "LinkedAccountStatus")]
    public partial class LinkedAccountStatus : IEquatable<LinkedAccountStatus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkedAccountStatus" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LinkedAccountStatus() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkedAccountStatus" /> class.
        /// </summary>
        /// <param name="linkedAccountStatus">linkedAccountStatus (required).</param>
        /// <param name="canMakeRequest">canMakeRequest (required).</param>
        public LinkedAccountStatus(string linkedAccountStatus = default(string), bool canMakeRequest = default(bool))
        {
            // to ensure "linkedAccountStatus" is required (not null)
            this._LinkedAccountStatus = linkedAccountStatus ?? throw new ArgumentNullException("linkedAccountStatus is a required property for LinkedAccountStatus and cannot be null");
            this.CanMakeRequest = canMakeRequest;
        }

        /// <summary>
        /// Gets or Sets _LinkedAccountStatus
        /// </summary>
        [DataMember(Name = "linked_account_status", IsRequired = true, EmitDefaultValue = false)]
        public string _LinkedAccountStatus { get; set; }

        /// <summary>
        /// Gets or Sets CanMakeRequest
        /// </summary>
        [DataMember(Name = "can_make_request", IsRequired = true, EmitDefaultValue = true)]
        public bool CanMakeRequest { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LinkedAccountStatus {\n");
            sb.Append("  _LinkedAccountStatus: ").Append(_LinkedAccountStatus).Append("\n");
            sb.Append("  CanMakeRequest: ").Append(CanMakeRequest).Append("\n");
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
            return this.Equals(input as LinkedAccountStatus);
        }

        /// <summary>
        /// Returns true if LinkedAccountStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of LinkedAccountStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LinkedAccountStatus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._LinkedAccountStatus == input._LinkedAccountStatus ||
                    (this._LinkedAccountStatus != null &&
                    this._LinkedAccountStatus.Equals(input._LinkedAccountStatus))
                ) && 
                (
                    this.CanMakeRequest == input.CanMakeRequest ||
                    this.CanMakeRequest.Equals(input.CanMakeRequest)
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
                if (this._LinkedAccountStatus != null)
                    hashCode = hashCode * 59 + this._LinkedAccountStatus.GetHashCode();
                hashCode = hashCode * 59 + this.CanMakeRequest.GetHashCode();
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
