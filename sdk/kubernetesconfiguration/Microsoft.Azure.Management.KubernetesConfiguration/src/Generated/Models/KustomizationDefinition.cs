// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.KubernetesConfiguration.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The Kustomization defining how to reconcile the artifact pulled by the
    /// source type on the cluster.
    /// </summary>
    public partial class KustomizationDefinition
    {
        /// <summary>
        /// Initializes a new instance of the KustomizationDefinition class.
        /// </summary>
        public KustomizationDefinition()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the KustomizationDefinition class.
        /// </summary>
        /// <param name="name">Name of the Kustomization, matching the key in
        /// the Kustomizations object map.</param>
        /// <param name="path">The path in the source reference to reconcile on
        /// the cluster.</param>
        /// <param name="dependsOn">Specifies other Kustomizations that this
        /// Kustomization depends on. This Kustomization will not reconcile
        /// until all dependencies have completed their reconciliation.</param>
        /// <param name="timeoutInSeconds">The maximum time to attempt to
        /// reconcile the Kustomization on the cluster.</param>
        /// <param name="syncIntervalInSeconds">The interval at which to
        /// re-reconcile the Kustomization on the cluster.</param>
        /// <param name="retryIntervalInSeconds">The interval at which to
        /// re-reconcile the Kustomization on the cluster in the event of
        /// failure on reconciliation.</param>
        /// <param name="prune">Enable/disable garbage collections of
        /// Kubernetes objects created by this Kustomization.</param>
        /// <param name="force">Enable/disable re-creating Kubernetes resources
        /// on the cluster when patching fails due to an immutable field
        /// change.</param>
        public KustomizationDefinition(string name = default(string), string path = default(string), IList<string> dependsOn = default(IList<string>), long? timeoutInSeconds = default(long?), long? syncIntervalInSeconds = default(long?), long? retryIntervalInSeconds = default(long?), bool? prune = default(bool?), bool? force = default(bool?))
        {
            Name = name;
            Path = path;
            DependsOn = dependsOn;
            TimeoutInSeconds = timeoutInSeconds;
            SyncIntervalInSeconds = syncIntervalInSeconds;
            RetryIntervalInSeconds = retryIntervalInSeconds;
            Prune = prune;
            Force = force;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets name of the Kustomization, matching the key in the
        /// Kustomizations object map.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets or sets the path in the source reference to reconcile on the
        /// cluster.
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets specifies other Kustomizations that this Kustomization
        /// depends on. This Kustomization will not reconcile until all
        /// dependencies have completed their reconciliation.
        /// </summary>
        [JsonProperty(PropertyName = "dependsOn")]
        public IList<string> DependsOn { get; set; }

        /// <summary>
        /// Gets or sets the maximum time to attempt to reconcile the
        /// Kustomization on the cluster.
        /// </summary>
        [JsonProperty(PropertyName = "timeoutInSeconds")]
        public long? TimeoutInSeconds { get; set; }

        /// <summary>
        /// Gets or sets the interval at which to re-reconcile the
        /// Kustomization on the cluster.
        /// </summary>
        [JsonProperty(PropertyName = "syncIntervalInSeconds")]
        public long? SyncIntervalInSeconds { get; set; }

        /// <summary>
        /// Gets or sets the interval at which to re-reconcile the
        /// Kustomization on the cluster in the event of failure on
        /// reconciliation.
        /// </summary>
        [JsonProperty(PropertyName = "retryIntervalInSeconds")]
        public long? RetryIntervalInSeconds { get; set; }

        /// <summary>
        /// Gets or sets enable/disable garbage collections of Kubernetes
        /// objects created by this Kustomization.
        /// </summary>
        [JsonProperty(PropertyName = "prune")]
        public bool? Prune { get; set; }

        /// <summary>
        /// Gets or sets enable/disable re-creating Kubernetes resources on the
        /// cluster when patching fails due to an immutable field change.
        /// </summary>
        [JsonProperty(PropertyName = "force")]
        public bool? Force { get; set; }

    }
}
