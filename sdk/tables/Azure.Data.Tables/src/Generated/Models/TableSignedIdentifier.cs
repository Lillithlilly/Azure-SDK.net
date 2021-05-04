// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Data.Tables.Models;

namespace Azure.Data.Tables
{
    /// <summary> A signed identifier. </summary>
    public partial class TableSignedIdentifier
    {
        /// <summary> Initializes a new instance of TableSignedIdentifier. </summary>
        /// <param name="id"> A unique id. </param>
        /// <param name="accessPolicy"> The access policy. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="accessPolicy"/> is null. </exception>
        public TableSignedIdentifier(string id, TableAccessPolicy accessPolicy)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (accessPolicy == null)
            {
                throw new ArgumentNullException(nameof(accessPolicy));
            }

            Id = id;
            AccessPolicy = accessPolicy;
        }

        /// <summary> A unique id. </summary>
        public string Id { get; set; }
        /// <summary> The access policy. </summary>
        public TableAccessPolicy AccessPolicy { get; set; }
    }
}