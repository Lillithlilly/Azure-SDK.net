// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.CallingServer
{
    /// <summary> The response payload of get call recording state operation. </summary>
    public partial class GetCallRecordingStateResponse
    {
        /// <summary> Initializes a new instance of GetCallRecordingStateResponse. </summary>
        internal GetCallRecordingStateResponse()
        {
        }

        /// <summary> Initializes a new instance of GetCallRecordingStateResponse. </summary>
        /// <param name="recordingState"> The recording state of the recording. </param>
        internal GetCallRecordingStateResponse(CallRecordingState? recordingState)
        {
            RecordingState = recordingState;
        }

        /// <summary> The recording state of the recording. </summary>
        public CallRecordingState? RecordingState { get; }
    }
}