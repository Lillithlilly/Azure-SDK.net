// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Operation parameters details.
    /// </summary>
    public partial class ParameterContract
    {
        /// <summary>
        /// Initializes a new instance of the ParameterContract class.
        /// </summary>
        public ParameterContract()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ParameterContract class.
        /// </summary>
        /// <param name="name">Parameter name.</param>
        /// <param name="type">Parameter type.</param>
        /// <param name="description">Parameter description.</param>
        /// <param name="defaultValue">Default parameter value.</param>
        /// <param name="required">Specifies whether parameter is required or
        /// not.</param>
        /// <param name="values">Parameter values.</param>
        /// <param name="schemaId">Schema identifier.</param>
        /// <param name="typeName">Type name defined by the schema.</param>
        /// <param name="examples">Exampled defined for the parameter.</param>
        public ParameterContract(string name, string type, string description = default(string), string defaultValue = default(string), bool? required = default(bool?), IList<string> values = default(IList<string>), string schemaId = default(string), string typeName = default(string), IDictionary<string, ParameterExampleContract> examples = default(IDictionary<string, ParameterExampleContract>))
        {
            Name = name;
            Description = description;
            Type = type;
            DefaultValue = defaultValue;
            Required = required;
            Values = values;
            SchemaId = schemaId;
            TypeName = typeName;
            Examples = examples;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets parameter name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets parameter description.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets parameter type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets default parameter value.
        /// </summary>
        [JsonProperty(PropertyName = "defaultValue")]
        public string DefaultValue { get; set; }

        /// <summary>
        /// Gets or sets specifies whether parameter is required or not.
        /// </summary>
        [JsonProperty(PropertyName = "required")]
        public bool? Required { get; set; }

        /// <summary>
        /// Gets or sets parameter values.
        /// </summary>
        [JsonProperty(PropertyName = "values")]
        public IList<string> Values { get; set; }

        /// <summary>
        /// Gets or sets schema identifier.
        /// </summary>
        [JsonProperty(PropertyName = "schemaId")]
        public string SchemaId { get; set; }

        /// <summary>
        /// Gets or sets type name defined by the schema.
        /// </summary>
        [JsonProperty(PropertyName = "typeName")]
        public string TypeName { get; set; }

        /// <summary>
        /// Gets or sets exampled defined for the parameter.
        /// </summary>
        [JsonProperty(PropertyName = "examples")]
        public IDictionary<string, ParameterExampleContract> Examples { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Type == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Type");
            }
        }
    }
}
