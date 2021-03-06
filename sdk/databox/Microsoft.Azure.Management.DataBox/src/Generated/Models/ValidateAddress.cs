// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBox.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The requirements to validate customer address where the device needs to
    /// be shipped.
    /// </summary>
    public partial class ValidateAddress : ValidationInputRequest
    {
        /// <summary>
        /// Initializes a new instance of the ValidateAddress class.
        /// </summary>
        public ValidateAddress()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ValidateAddress class.
        /// </summary>
        /// <param name="shippingAddress">Shipping address of the
        /// customer.</param>
        /// <param name="deviceType">Device type to be used for the job.
        /// Possible values include: 'DataBox', 'DataBoxDisk', 'DataBoxHeavy',
        /// 'DataBoxCustomerDisk'</param>
        /// <param name="transportPreferences">Preferences related to the
        /// shipment logistics of the sku.</param>
        public ValidateAddress(ShippingAddress shippingAddress, SkuName deviceType, TransportPreferences transportPreferences = default(TransportPreferences))
        {
            ShippingAddress = shippingAddress;
            DeviceType = deviceType;
            TransportPreferences = transportPreferences;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets shipping address of the customer.
        /// </summary>
        [JsonProperty(PropertyName = "shippingAddress")]
        public ShippingAddress ShippingAddress { get; set; }

        /// <summary>
        /// Gets or sets device type to be used for the job. Possible values
        /// include: 'DataBox', 'DataBoxDisk', 'DataBoxHeavy',
        /// 'DataBoxCustomerDisk'
        /// </summary>
        [JsonProperty(PropertyName = "deviceType")]
        public SkuName DeviceType { get; set; }

        /// <summary>
        /// Gets or sets preferences related to the shipment logistics of the
        /// sku.
        /// </summary>
        [JsonProperty(PropertyName = "transportPreferences")]
        public TransportPreferences TransportPreferences { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ShippingAddress == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ShippingAddress");
            }
            if (ShippingAddress != null)
            {
                ShippingAddress.Validate();
            }
            if (TransportPreferences != null)
            {
                TransportPreferences.Validate();
            }
        }
    }
}
