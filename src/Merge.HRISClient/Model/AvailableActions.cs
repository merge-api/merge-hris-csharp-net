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
    /// # The AvailableActions Object ### Description The &#x60;Activity&#x60; object is used to see all available model/operation combinations for an integration.  ### Usage Example Fetch all the actions available for the &#x60;Zenefits&#x60; integration.
    /// </summary>
    [DataContract(Name = "AvailableActions")]
    public partial class AvailableActions : IEquatable<AvailableActions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AvailableActions" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AvailableActions() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AvailableActions" /> class.
        /// </summary>
        /// <param name="integration">integration (required).</param>
        /// <param name="passthroughAvailable">passthroughAvailable (required).</param>
        /// <param name="availableModelOperations">availableModelOperations.</param>
        public AvailableActions(AccountIntegration integration = default(AccountIntegration), bool passthroughAvailable = default(bool), List<ModelOperation> availableModelOperations = default(List<ModelOperation>))
        {
            // to ensure "integration" is required (not null)
            this.Integration = integration ?? throw new ArgumentNullException("integration is a required property for AvailableActions and cannot be null");
            this.PassthroughAvailable = passthroughAvailable;
            this.AvailableModelOperations = availableModelOperations;
        }

        /// <summary>
        /// Gets or Sets Integration
        /// </summary>
        [DataMember(Name = "integration", IsRequired = true, EmitDefaultValue = false)]
        public AccountIntegration Integration { get; set; }

        /// <summary>
        /// Gets or Sets PassthroughAvailable
        /// </summary>
        [DataMember(Name = "passthrough_available", IsRequired = true, EmitDefaultValue = true)]
        public bool PassthroughAvailable { get; set; }

        /// <summary>
        /// Gets or Sets AvailableModelOperations
        /// </summary>
        [DataMember(Name = "available_model_operations", EmitDefaultValue = false)]
        public List<ModelOperation> AvailableModelOperations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AvailableActions {\n");
            sb.Append("  Integration: ").Append(Integration).Append("\n");
            sb.Append("  PassthroughAvailable: ").Append(PassthroughAvailable).Append("\n");
            sb.Append("  AvailableModelOperations: ").Append(AvailableModelOperations).Append("\n");
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
            return this.Equals(input as AvailableActions);
        }

        /// <summary>
        /// Returns true if AvailableActions instances are equal
        /// </summary>
        /// <param name="input">Instance of AvailableActions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AvailableActions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Integration == input.Integration ||
                    (this.Integration != null &&
                    this.Integration.Equals(input.Integration))
                ) && 
                (
                    this.PassthroughAvailable == input.PassthroughAvailable ||
                    this.PassthroughAvailable.Equals(input.PassthroughAvailable)
                ) && 
                (
                    this.AvailableModelOperations == input.AvailableModelOperations ||
                    this.AvailableModelOperations != null &&
                    input.AvailableModelOperations != null &&
                    this.AvailableModelOperations.SequenceEqual(input.AvailableModelOperations)
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
                if (this.Integration != null)
                    hashCode = hashCode * 59 + this.Integration.GetHashCode();
                hashCode = hashCode * 59 + this.PassthroughAvailable.GetHashCode();
                if (this.AvailableModelOperations != null)
                    hashCode = hashCode * 59 + this.AvailableModelOperations.GetHashCode();
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
