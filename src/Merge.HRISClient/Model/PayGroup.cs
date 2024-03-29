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
    /// # The PayGroup Object ### Description The &#x60;PayGroup&#x60; object is used to represent a subset of employees that are put together for payroll processing purposes.  ### Usage Example Fetch from the &#x60;LIST PayGroup&#x60; endpoint and filter by &#x60;ID&#x60; to show all pay group information.
    /// </summary>
    [DataContract(Name = "PayGroup")]
    public partial class PayGroup : IEquatable<PayGroup>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PayGroup" /> class.
        /// </summary>
        /// <param name="remoteId">The third-party API ID of the matching object..</param>
        /// <param name="payGroupName">The pay group name..</param>
        public PayGroup(string remoteId = default(string), string payGroupName = default(string))
        {
            this.RemoteId = remoteId;
            this.PayGroupName = payGroupName;
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
        /// The pay group name.
        /// </summary>
        /// <value>The pay group name.</value>
        [DataMember(Name = "pay_group_name", EmitDefaultValue = true)]
        public string PayGroupName { get; set; }

        /// <summary>
        /// Indicates whether or not this object has been deleted by third party webhooks.
        /// </summary>
        /// <value>Indicates whether or not this object has been deleted by third party webhooks.</value>
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
            sb.Append("class PayGroup {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  RemoteId: ").Append(RemoteId).Append("\n");
            sb.Append("  PayGroupName: ").Append(PayGroupName).Append("\n");
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
            return this.Equals(input as PayGroup);
        }

        /// <summary>
        /// Returns true if PayGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of PayGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PayGroup input)
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
                    this.PayGroupName == input.PayGroupName ||
                    (this.PayGroupName != null &&
                    this.PayGroupName.Equals(input.PayGroupName))
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
                if (this.PayGroupName != null)
                    hashCode = hashCode * 59 + this.PayGroupName.GetHashCode();
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
            yield break;
        }
    }

}
