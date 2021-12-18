// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading.Tasks;
using Azure.Communication.Rooms.Models;
using Azure.Core.TestFramework;
using NUnit.Framework;

namespace Azure.Communication.Rooms.Tests.samples
{
    /// <summary>
    /// Samples that are used in the README.md file.
    /// </summary>
    ///
    public partial class Sample1_RoomsClient : RoomsClientLiveTestBase
    {
        public Sample1_RoomsClient(bool isAsync) : base(isAsync)
        {
        }

        [Test]
        public async Task AcsRoomRequestSample()
        {
            RoomsClient roomsClient = CreateInstrumentedRoomsClient();

            #region Snippet:Azure_Communication_Rooms_Tests_Samples_CreateRoomAsync
            CreateRoomRequest createRoomRequest = new CreateRoomRequest();
            Response<CommunicationRoom> createRoomResponse = await roomsClient.CreateRoomAsync(createRoomRequest);
            CommunicationRoom createCommunicationRoom = createRoomResponse.Value;
            #endregion Snippet:Azure_Communication_Rooms_Tests_Samples_CreateRoomAsync

            Assert.IsFalse(string.IsNullOrWhiteSpace(createCommunicationRoom.Id));

            var createdRoomId = createCommunicationRoom.Id;

            UpdateRoomRequest updateRoomRequest = new UpdateRoomRequest()
            {
                ValidFrom = new DateTimeOffset(2021, 8, 1, 8, 6, 32,
                             new TimeSpan(1, 0, 0)),
                ValidUntil = new DateTimeOffset(2021, 8, 2, 8, 6, 32,
                             new TimeSpan(1, 0, 0)),
            };

            #region Snippet:Azure_Communication_Rooms_Tests_Samples_UpdateRoomAsync
            Response<CommunicationRoom> updateRoomResponse = await roomsClient.UpdateRoomAsync(createdRoomId, updateRoomRequest);
            CommunicationRoom updateCommunicationRoom = updateRoomResponse.Value;
            #endregion Snippet:Azure_Communication_Rooms_Tests_Samples_UpdateRoomAsync

            Assert.IsFalse(string.IsNullOrWhiteSpace(updateCommunicationRoom.Id));

            #region Snippet:Azure_Communication_Rooms_Tests_Samples_GetRoomAsync
            Response<CommunicationRoom> getRoomResponse = await roomsClient.GetRoomAsync(
                //@@ createdRoomId: "existing room Id which is created already
                /*@@*/ createdRoomId);
            CommunicationRoom getCommunicationRoom = getRoomResponse.Value;
            #endregion Snippet:Azure_Communication_Rooms_Tests_Samples_GetRoomAsync

            Assert.IsFalse(string.IsNullOrWhiteSpace(getCommunicationRoom.Id));

            #region Snippet:Azure_Communication_Rooms_Tests_Samples_DeleteRoomAsync
            Response deleteRoomResponse = await roomsClient.DeleteRoomAsync(
                //@@ createdRoomId: "existing room Id which is created already
                /*@@*/ createdRoomId);
            #endregion Snippet:Azure_Communication_Rooms_Tests_Samples_DeleteRoomAsync

            Assert.AreEqual(204, deleteRoomResponse.Status);
        }

        [Test]
        public async Task RoomRequestsTroubleShooting()
        {
            RoomsClient roomsClient = CreateInstrumentedRoomsClient();
            #region Snippet:Azure_Communication_RoomsClient_Tests_Troubleshooting
            try
            {
                CreateRoomRequest createRoomRequest = new CreateRoomRequest();
                Response<CommunicationRoom> createRoomResponse = await roomsClient.CreateRoomAsync(createRoomRequest);
                CommunicationRoom createRoomResult = createRoomResponse.Value;
            }
            catch (RequestFailedException ex)
            {
                Console.WriteLine(ex.Message);
            }
            #endregion Snippet:Azure_Communication_RoomsClient_Tests_Troubleshooting
        }
    }
}
