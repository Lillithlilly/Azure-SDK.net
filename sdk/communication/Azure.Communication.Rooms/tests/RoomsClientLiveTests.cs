// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#region Snippet:Azure_Communication_Rooms_Tests_UsingStatements
using System;
using System.Collections.Generic;
using System.Linq;
//@@ using Azure.Communication.Rooms
#endregion Snippet:Azure_Communication_Rooms_Tests_UsingStatements
using System.Threading.Tasks;
using Azure.Communication.Rooms.Models;
using NUnit.Framework;

namespace Azure.Communication.Rooms.Tests
{
    public class RoomsClientLiveTests : RoomsClientLiveTestBase
    {
        public RoomsClientLiveTests(bool isAsync) : base(isAsync)
        {
        }

        [Test]
        public async Task AcsRoomRequestLiveTest()
        {
            RoomsClient roomsClient = CreateInstrumentedRoomsClient();
            var communicationUser1 = "8:acs:71ec590b-cbad-490c-99c5-b578bdacde54_0000000e-3240-55cf-9806-113a0d001dd9";
            var communicationUser2 = "8:acs:71ec590b-cbad-490c-99c5-b578bdacde54_0000000e-322a-f9f7-740a-113a0d00ee19";
            var communicationUser3 = "8:acs:71ec590b-cbad-490c-99c5-b578bdacde54_0000000e-5609-f66d-defd-8b3a0d002749";
            var validFrom = new DateTime(2022, 05, 01, 00, 00, 00, DateTimeKind.Utc);
            var validUntil = validFrom.AddDays(1);

            try
            {
                CreateRoomRequest createRoomRequest = new CreateRoomRequest();
                createRoomRequest.ValidFrom = validFrom;
                createRoomRequest.ValidUntil = validUntil;
                createRoomRequest.Participants.Add(communicationUser1, new RoomParticipant());
                createRoomRequest.Participants.Add(communicationUser2, new RoomParticipant());

                Response<CommunicationRoom> createRoomResponse = await roomsClient.CreateRoomAsync(createRoomRequest);
                CommunicationRoom createCommunicationRoom = createRoomResponse.Value;
                Assert.IsFalse(string.IsNullOrWhiteSpace(createCommunicationRoom.Id));
                Assert.AreEqual(2, createCommunicationRoom.Participants.Count, "Expected CreateRoom participants count to be 2");
                Assert.IsTrue(createCommunicationRoom.Participants.ContainsKey(communicationUser1), "Expected CreateRoom to contain user1");
                Assert.IsTrue(createCommunicationRoom.Participants.ContainsKey(communicationUser2), "Expected CreateRoom to contain user2");

                var createdRoomId = createCommunicationRoom.Id;

                UpdateRoomRequest updateRoomRequest = new UpdateRoomRequest();
                updateRoomRequest.Participants.Add(communicationUser3, new RoomParticipant());
                updateRoomRequest.Participants.Add(communicationUser2, null);

                Response<CommunicationRoom> updateRoomResponse = await roomsClient.UpdateRoomAsync(createdRoomId, updateRoomRequest);
                CommunicationRoom updateCommunicationRoom = updateRoomResponse.Value;
                Assert.AreEqual(createdRoomId, updateCommunicationRoom.Id);
                Assert.AreEqual(2, updateCommunicationRoom.Participants.Count, "Expected UpdateRoom participants count to be 2");
                Assert.IsTrue(updateCommunicationRoom.Participants.ContainsKey(communicationUser1), "Expected UpdateRoom to contain user1");
                Assert.IsTrue(updateCommunicationRoom.Participants.ContainsKey(communicationUser3), "Expected UpdateRoom to contain user3");

                Response<CommunicationRoom> getRoomResponse = await roomsClient.GetRoomAsync(createdRoomId);
                CommunicationRoom getCommunicationRoom = getRoomResponse.Value;
                Assert.AreEqual(createdRoomId, getCommunicationRoom.Id);
                Assert.AreEqual(2, updateCommunicationRoom.Participants.Count, "Expected GetRoom participants count to be 2");
                Assert.IsTrue(updateCommunicationRoom.Participants.ContainsKey(communicationUser1), "Expected GetRoom to contain user1");
                Assert.IsTrue(updateCommunicationRoom.Participants.ContainsKey(communicationUser3), "Expected GetRooom to contain user3");

                Response deleteRoomResponse = await roomsClient.DeleteRoomAsync(createdRoomId);
                Assert.AreEqual(204, deleteRoomResponse.Status);
            }
            catch (RequestFailedException ex)
            {
                Console.WriteLine(ex.Message);
                Assert.Fail($"Unexpected error: {ex}");
            }
            catch (Exception ex)
            {
                Assert.Fail($"Unexpected error: {ex}");
            }
        }
    }
}
