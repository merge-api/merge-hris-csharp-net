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
    /// MetaResponse
    /// </summary>
    [DataContract(Name = "MetaResponse")]
    public partial class MetaResponse : IEquatable<MetaResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MetaResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MetaResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MetaResponse" /> class.
        /// </summary>
        /// <param name="requestSchema">requestSchema (required).</param>
        /// <param name="remoteFieldClasses">remoteFieldClasses.</param>
        /// <param name="status">status.</param>
        /// <param name="hasConditionalParams">hasConditionalParams (required).</param>
        /// <param name="hasRequiredLinkedAccountParams">hasRequiredLinkedAccountParams (required).</param>
        public MetaResponse(Dictionary<string, Object> requestSchema = default(Dictionary<string, Object>), Dictionary<string, Object> remoteFieldClasses = default(Dictionary<string, Object>), LinkedAccountStatus status = default(LinkedAccountStatus), bool hasConditionalParams = default(bool), bool hasRequiredLinkedAccountParams = default(bool))
        {
            // to ensure "requestSchema" is required (not null)
            this.RequestSchema = requestSchema ?? throw new ArgumentNullException("requestSchema is a required property for MetaResponse and cannot be null");
            this.HasConditionalParams = hasConditionalParams;
            this.HasRequiredLinkedAccountParams = hasRequiredLinkedAccountParams;
            this.RemoteFieldClasses = remoteFieldClasses;
            this.Status = status;
        }

        /// <summary>
        /// Gets or Sets RequestSchema
        /// </summary>
        [DataMember(Name = "request_schema", IsRequired = true, EmitDefaultValue = false)]
        public Dictionary<string, Object> RequestSchema { get; set; }

        /// <summary>
        /// Gets or Sets RemoteFieldClasses
        /// </summary>
        [DataMember(Name = "remote_field_classes", EmitDefaultValue = false)]
        public Dictionary<string, Object> RemoteFieldClasses { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public LinkedAccountStatus Status { get; set; }

        /// <summary>
        /// Gets or Sets HasConditionalParams
        /// </summary>
        [DataMember(Name = "has_conditional_params", IsRequired = true, EmitDefaultValue = true)]
        public bool HasConditionalParams { get; set; }

        /// <summary>
        /// Gets or Sets HasRequiredLinkedAccountParams
        /// </summary>
        [DataMember(Name = "has_required_linked_account_params", IsRequired = true, EmitDefaultValue = true)]
        public bool HasRequiredLinkedAccountParams { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MetaResponse {\n");
            sb.Append("  RequestSchema: ").Append(RequestSchema).Append("\n");
            sb.Append("  RemoteFieldClasses: ").Append(RemoteFieldClasses).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  HasConditionalParams: ").Append(HasConditionalParams).Append("\n");
            sb.Append("  HasRequiredLinkedAccountParams: ").Append(HasRequiredLinkedAccountParams).Append("\n");
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
            return this.Equals(input as MetaResponse);
        }

        /// <summary>
        /// Returns true if MetaResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of MetaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MetaResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RequestSchema == input.RequestSchema ||
                    this.RequestSchema != null &&
                    input.RequestSchema != null &&
                    this.RequestSchema.SequenceEqual(input.RequestSchema)
                ) && 
                (
                    this.RemoteFieldClasses == input.RemoteFieldClasses ||
                    this.RemoteFieldClasses != null &&
                    input.RemoteFieldClasses != null &&
                    this.RemoteFieldClasses.SequenceEqual(input.RemoteFieldClasses)
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.HasConditionalParams == input.HasConditionalParams ||
                    this.HasConditionalParams.Equals(input.HasConditionalParams)
                ) && 
                (
                    this.HasRequiredLinkedAccountParams == input.HasRequiredLinkedAccountParams ||
                    this.HasRequiredLinkedAccountParams.Equals(input.HasRequiredLinkedAccountParams)
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
                if (this.RequestSchema != null)
                    hashCode = hashCode * 59 + this.RequestSchema.GetHashCode();
                if (this.RemoteFieldClasses != null)
                    hashCode = hashCode * 59 + this.RemoteFieldClasses.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                hashCode = hashCode * 59 + this.HasConditionalParams.GetHashCode();
                hashCode = hashCode * 59 + this.HasRequiredLinkedAccountParams.GetHashCode();
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
