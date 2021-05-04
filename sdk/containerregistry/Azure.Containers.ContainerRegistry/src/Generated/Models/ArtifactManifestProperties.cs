// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry
{
    /// <summary> Manifest attributes details. </summary>
    public partial class ArtifactManifestProperties
    {
        /// <summary> Initializes a new instance of ArtifactManifestProperties. </summary>
        internal ArtifactManifestProperties()
        {
            References = new ChangeTrackingList<ManifestAttributesManifestReferences>();
            Tags = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of ArtifactManifestProperties. </summary>
        /// <param name="repositoryName"> Repository name. </param>
        /// <param name="digest"> Manifest. </param>
        /// <param name="size"> Image size. </param>
        /// <param name="createdOn"> Created time. </param>
        /// <param name="lastUpdatedOn"> Last update time. </param>
        /// <param name="architecture"> CPU architecture. </param>
        /// <param name="operatingSystem"> Operating system. </param>
        /// <param name="references"> List of manifest attributes details. </param>
        /// <param name="tags"> List of tags. </param>
        /// <param name="writeableProperties"> Writeable properties of the resource. </param>
        internal ArtifactManifestProperties(string repositoryName, string digest, long? size, DateTimeOffset? createdOn, DateTimeOffset? lastUpdatedOn, ArtifactArchitecture? architecture, ArtifactOperatingSystem? operatingSystem, IReadOnlyList<ManifestAttributesManifestReferences> references, IReadOnlyList<string> tags, ContentProperties writeableProperties)
        {
            RepositoryName = repositoryName;
            Digest = digest;
            Size = size;
            CreatedOn = createdOn;
            LastUpdatedOn = lastUpdatedOn;
            Architecture = architecture;
            OperatingSystem = operatingSystem;
            References = references;
            Tags = tags;
            WriteableProperties = writeableProperties;
        }

        /// <summary> Repository name. </summary>
        public string RepositoryName { get; }
        /// <summary> Manifest. </summary>
        public string Digest { get; }
        /// <summary> Image size. </summary>
        public long? Size { get; }
        /// <summary> Created time. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Last update time. </summary>
        public DateTimeOffset? LastUpdatedOn { get; }
        /// <summary> CPU architecture. </summary>
        public ArtifactArchitecture? Architecture { get; }
        /// <summary> Operating system. </summary>
        public ArtifactOperatingSystem? OperatingSystem { get; }
        /// <summary> List of tags. </summary>
        public IReadOnlyList<string> Tags { get; }
        /// <summary> Writeable properties of the resource. </summary>
        public ContentProperties WriteableProperties { get; }
    }
}