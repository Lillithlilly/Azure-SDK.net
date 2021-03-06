// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for TracksOperations.
    /// </summary>
    public static partial class TracksOperationsExtensions
    {
            /// <summary>
            /// List Tracks in the Asset
            /// </summary>
            /// <remarks>
            /// Lists the Tracks in the asset
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the Azure subscription.
            /// </param>
            /// <param name='accountName'>
            /// The Media Services account name.
            /// </param>
            /// <param name='assetName'>
            /// The Asset name.
            /// </param>
            public static IEnumerable<AssetTrack> List(this ITracksOperations operations, string resourceGroupName, string accountName, string assetName)
            {
                return operations.ListAsync(resourceGroupName, accountName, assetName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List Tracks in the Asset
            /// </summary>
            /// <remarks>
            /// Lists the Tracks in the asset
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the Azure subscription.
            /// </param>
            /// <param name='accountName'>
            /// The Media Services account name.
            /// </param>
            /// <param name='assetName'>
            /// The Asset name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<AssetTrack>> ListAsync(this ITracksOperations operations, string resourceGroupName, string accountName, string assetName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, accountName, assetName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a Track
            /// </summary>
            /// <remarks>
            /// Get the details of a Track in the Asset
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the Azure subscription.
            /// </param>
            /// <param name='accountName'>
            /// The Media Services account name.
            /// </param>
            /// <param name='assetName'>
            /// The Asset name.
            /// </param>
            /// <param name='trackName'>
            /// The Asset Track name.
            /// </param>
            public static AssetTrack Get(this ITracksOperations operations, string resourceGroupName, string accountName, string assetName, string trackName)
            {
                return operations.GetAsync(resourceGroupName, accountName, assetName, trackName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a Track
            /// </summary>
            /// <remarks>
            /// Get the details of a Track in the Asset
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the Azure subscription.
            /// </param>
            /// <param name='accountName'>
            /// The Media Services account name.
            /// </param>
            /// <param name='assetName'>
            /// The Asset name.
            /// </param>
            /// <param name='trackName'>
            /// The Asset Track name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AssetTrack> GetAsync(this ITracksOperations operations, string resourceGroupName, string accountName, string assetName, string trackName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, accountName, assetName, trackName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update a Track
            /// </summary>
            /// <remarks>
            /// Create or update a Track in the asset
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the Azure subscription.
            /// </param>
            /// <param name='accountName'>
            /// The Media Services account name.
            /// </param>
            /// <param name='assetName'>
            /// The Asset name.
            /// </param>
            /// <param name='trackName'>
            /// The Asset Track name.
            /// </param>
            /// <param name='track'>
            /// Detailed information about a track in the asset.
            /// </param>
            public static AssetTrack CreateOrUpdate(this ITracksOperations operations, string resourceGroupName, string accountName, string assetName, string trackName, TrackBase track = default(TrackBase))
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, accountName, assetName, trackName, track).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update a Track
            /// </summary>
            /// <remarks>
            /// Create or update a Track in the asset
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the Azure subscription.
            /// </param>
            /// <param name='accountName'>
            /// The Media Services account name.
            /// </param>
            /// <param name='assetName'>
            /// The Asset name.
            /// </param>
            /// <param name='trackName'>
            /// The Asset Track name.
            /// </param>
            /// <param name='track'>
            /// Detailed information about a track in the asset.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AssetTrack> CreateOrUpdateAsync(this ITracksOperations operations, string resourceGroupName, string accountName, string assetName, string trackName, TrackBase track = default(TrackBase), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, accountName, assetName, trackName, track, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a Track
            /// </summary>
            /// <remarks>
            /// Deletes a Track in the asset
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the Azure subscription.
            /// </param>
            /// <param name='accountName'>
            /// The Media Services account name.
            /// </param>
            /// <param name='assetName'>
            /// The Asset name.
            /// </param>
            /// <param name='trackName'>
            /// The Asset Track name.
            /// </param>
            public static TracksDeleteHeaders Delete(this ITracksOperations operations, string resourceGroupName, string accountName, string assetName, string trackName)
            {
                return operations.DeleteAsync(resourceGroupName, accountName, assetName, trackName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a Track
            /// </summary>
            /// <remarks>
            /// Deletes a Track in the asset
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the Azure subscription.
            /// </param>
            /// <param name='accountName'>
            /// The Media Services account name.
            /// </param>
            /// <param name='assetName'>
            /// The Asset name.
            /// </param>
            /// <param name='trackName'>
            /// The Asset Track name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TracksDeleteHeaders> DeleteAsync(this ITracksOperations operations, string resourceGroupName, string accountName, string assetName, string trackName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(resourceGroupName, accountName, assetName, trackName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Update an Track
            /// </summary>
            /// <remarks>
            /// Updates an existing Track in the asset
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the Azure subscription.
            /// </param>
            /// <param name='accountName'>
            /// The Media Services account name.
            /// </param>
            /// <param name='assetName'>
            /// The Asset name.
            /// </param>
            /// <param name='trackName'>
            /// The Asset Track name.
            /// </param>
            /// <param name='track'>
            /// Detailed information about a track in the asset.
            /// </param>
            public static AssetTrack Update(this ITracksOperations operations, string resourceGroupName, string accountName, string assetName, string trackName, TrackBase track = default(TrackBase))
            {
                return operations.UpdateAsync(resourceGroupName, accountName, assetName, trackName, track).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update an Track
            /// </summary>
            /// <remarks>
            /// Updates an existing Track in the asset
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the Azure subscription.
            /// </param>
            /// <param name='accountName'>
            /// The Media Services account name.
            /// </param>
            /// <param name='assetName'>
            /// The Asset name.
            /// </param>
            /// <param name='trackName'>
            /// The Asset Track name.
            /// </param>
            /// <param name='track'>
            /// Detailed information about a track in the asset.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AssetTrack> UpdateAsync(this ITracksOperations operations, string resourceGroupName, string accountName, string assetName, string trackName, TrackBase track = default(TrackBase), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, accountName, assetName, trackName, track, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update the track data
            /// </summary>
            /// <remarks>
            /// Update the track data. Call this API after any changes are made to the
            /// track data stored in the asset container. For example, you have modified
            /// the WebVTT captions file in the Azure blob storage container for the asset,
            /// viewers will not see the new version of the captions unless this API is
            /// called. Note, the changes may not be reflected immediately. CDN cache may
            /// also need to be purged if applicable.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the Azure subscription.
            /// </param>
            /// <param name='accountName'>
            /// The Media Services account name.
            /// </param>
            /// <param name='assetName'>
            /// The Asset name.
            /// </param>
            /// <param name='trackName'>
            /// The Asset Track name.
            /// </param>
            public static TracksUpdateTrackDataHeaders UpdateTrackData(this ITracksOperations operations, string resourceGroupName, string accountName, string assetName, string trackName)
            {
                return operations.UpdateTrackDataAsync(resourceGroupName, accountName, assetName, trackName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update the track data
            /// </summary>
            /// <remarks>
            /// Update the track data. Call this API after any changes are made to the
            /// track data stored in the asset container. For example, you have modified
            /// the WebVTT captions file in the Azure blob storage container for the asset,
            /// viewers will not see the new version of the captions unless this API is
            /// called. Note, the changes may not be reflected immediately. CDN cache may
            /// also need to be purged if applicable.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the Azure subscription.
            /// </param>
            /// <param name='accountName'>
            /// The Media Services account name.
            /// </param>
            /// <param name='assetName'>
            /// The Asset name.
            /// </param>
            /// <param name='trackName'>
            /// The Asset Track name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TracksUpdateTrackDataHeaders> UpdateTrackDataAsync(this ITracksOperations operations, string resourceGroupName, string accountName, string assetName, string trackName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateTrackDataWithHttpMessagesAsync(resourceGroupName, accountName, assetName, trackName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Create or update a Track
            /// </summary>
            /// <remarks>
            /// Create or update a Track in the asset
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the Azure subscription.
            /// </param>
            /// <param name='accountName'>
            /// The Media Services account name.
            /// </param>
            /// <param name='assetName'>
            /// The Asset name.
            /// </param>
            /// <param name='trackName'>
            /// The Asset Track name.
            /// </param>
            /// <param name='track'>
            /// Detailed information about a track in the asset.
            /// </param>
            public static AssetTrack BeginCreateOrUpdate(this ITracksOperations operations, string resourceGroupName, string accountName, string assetName, string trackName, TrackBase track = default(TrackBase))
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, accountName, assetName, trackName, track).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update a Track
            /// </summary>
            /// <remarks>
            /// Create or update a Track in the asset
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the Azure subscription.
            /// </param>
            /// <param name='accountName'>
            /// The Media Services account name.
            /// </param>
            /// <param name='assetName'>
            /// The Asset name.
            /// </param>
            /// <param name='trackName'>
            /// The Asset Track name.
            /// </param>
            /// <param name='track'>
            /// Detailed information about a track in the asset.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AssetTrack> BeginCreateOrUpdateAsync(this ITracksOperations operations, string resourceGroupName, string accountName, string assetName, string trackName, TrackBase track = default(TrackBase), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, accountName, assetName, trackName, track, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a Track
            /// </summary>
            /// <remarks>
            /// Deletes a Track in the asset
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the Azure subscription.
            /// </param>
            /// <param name='accountName'>
            /// The Media Services account name.
            /// </param>
            /// <param name='assetName'>
            /// The Asset name.
            /// </param>
            /// <param name='trackName'>
            /// The Asset Track name.
            /// </param>
            public static TracksDeleteHeaders BeginDelete(this ITracksOperations operations, string resourceGroupName, string accountName, string assetName, string trackName)
            {
                return operations.BeginDeleteAsync(resourceGroupName, accountName, assetName, trackName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a Track
            /// </summary>
            /// <remarks>
            /// Deletes a Track in the asset
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the Azure subscription.
            /// </param>
            /// <param name='accountName'>
            /// The Media Services account name.
            /// </param>
            /// <param name='assetName'>
            /// The Asset name.
            /// </param>
            /// <param name='trackName'>
            /// The Asset Track name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TracksDeleteHeaders> BeginDeleteAsync(this ITracksOperations operations, string resourceGroupName, string accountName, string assetName, string trackName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, accountName, assetName, trackName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Update an Track
            /// </summary>
            /// <remarks>
            /// Updates an existing Track in the asset
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the Azure subscription.
            /// </param>
            /// <param name='accountName'>
            /// The Media Services account name.
            /// </param>
            /// <param name='assetName'>
            /// The Asset name.
            /// </param>
            /// <param name='trackName'>
            /// The Asset Track name.
            /// </param>
            /// <param name='track'>
            /// Detailed information about a track in the asset.
            /// </param>
            public static AssetTrack BeginUpdate(this ITracksOperations operations, string resourceGroupName, string accountName, string assetName, string trackName, TrackBase track = default(TrackBase))
            {
                return operations.BeginUpdateAsync(resourceGroupName, accountName, assetName, trackName, track).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update an Track
            /// </summary>
            /// <remarks>
            /// Updates an existing Track in the asset
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the Azure subscription.
            /// </param>
            /// <param name='accountName'>
            /// The Media Services account name.
            /// </param>
            /// <param name='assetName'>
            /// The Asset name.
            /// </param>
            /// <param name='trackName'>
            /// The Asset Track name.
            /// </param>
            /// <param name='track'>
            /// Detailed information about a track in the asset.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AssetTrack> BeginUpdateAsync(this ITracksOperations operations, string resourceGroupName, string accountName, string assetName, string trackName, TrackBase track = default(TrackBase), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, accountName, assetName, trackName, track, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update the track data
            /// </summary>
            /// <remarks>
            /// Update the track data. Call this API after any changes are made to the
            /// track data stored in the asset container. For example, you have modified
            /// the WebVTT captions file in the Azure blob storage container for the asset,
            /// viewers will not see the new version of the captions unless this API is
            /// called. Note, the changes may not be reflected immediately. CDN cache may
            /// also need to be purged if applicable.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the Azure subscription.
            /// </param>
            /// <param name='accountName'>
            /// The Media Services account name.
            /// </param>
            /// <param name='assetName'>
            /// The Asset name.
            /// </param>
            /// <param name='trackName'>
            /// The Asset Track name.
            /// </param>
            public static TracksUpdateTrackDataHeaders BeginUpdateTrackData(this ITracksOperations operations, string resourceGroupName, string accountName, string assetName, string trackName)
            {
                return operations.BeginUpdateTrackDataAsync(resourceGroupName, accountName, assetName, trackName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update the track data
            /// </summary>
            /// <remarks>
            /// Update the track data. Call this API after any changes are made to the
            /// track data stored in the asset container. For example, you have modified
            /// the WebVTT captions file in the Azure blob storage container for the asset,
            /// viewers will not see the new version of the captions unless this API is
            /// called. Note, the changes may not be reflected immediately. CDN cache may
            /// also need to be purged if applicable.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the Azure subscription.
            /// </param>
            /// <param name='accountName'>
            /// The Media Services account name.
            /// </param>
            /// <param name='assetName'>
            /// The Asset name.
            /// </param>
            /// <param name='trackName'>
            /// The Asset Track name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TracksUpdateTrackDataHeaders> BeginUpdateTrackDataAsync(this ITracksOperations operations, string resourceGroupName, string accountName, string assetName, string trackName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateTrackDataWithHttpMessagesAsync(resourceGroupName, accountName, assetName, trackName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

    }
}
