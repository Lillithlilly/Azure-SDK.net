// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Batch.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Base certificate properties.
    /// </summary>
    public partial class CertificateBaseProperties
    {
        /// <summary>
        /// Initializes a new instance of the CertificateBaseProperties class.
        /// </summary>
        public CertificateBaseProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CertificateBaseProperties class.
        /// </summary>
        /// <param name="thumbprintAlgorithm">The algorithm of the certificate
        /// thumbprint.</param>
        /// <param name="thumbprint">The thumbprint of the certificate.</param>
        /// <param name="format">The format of the certificate - either Pfx or
        /// Cer. If omitted, the default is Pfx. Possible values include:
        /// 'Pfx', 'Cer'</param>
        public CertificateBaseProperties(string thumbprintAlgorithm = default(string), string thumbprint = default(string), CertificateFormat format = default(CertificateFormat))
        {
            ThumbprintAlgorithm = thumbprintAlgorithm;
            Thumbprint = thumbprint;
            Format = format;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the algorithm of the certificate thumbprint.
        /// </summary>
        /// <remarks>
        /// This must match the first portion of the certificate name.
        /// Currently required to be 'SHA1'.
        /// </remarks>
        [JsonProperty(PropertyName = "thumbprintAlgorithm")]
        public string ThumbprintAlgorithm { get; set; }

        /// <summary>
        /// Gets or sets the thumbprint of the certificate.
        /// </summary>
        /// <remarks>
        /// This must match the thumbprint from the name.
        /// </remarks>
        [JsonProperty(PropertyName = "thumbprint")]
        public string Thumbprint { get; set; }

        /// <summary>
        /// Gets or sets the format of the certificate - either Pfx or Cer. If
        /// omitted, the default is Pfx. Possible values include: 'Pfx', 'Cer'
        /// </summary>
        [JsonProperty(PropertyName = "format")]
        public CertificateFormat Format { get; set; }

    }
}
