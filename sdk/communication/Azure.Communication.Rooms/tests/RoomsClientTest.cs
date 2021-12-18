// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure.Communication.Rooms.Models;
using Moq;
using NUnit.Framework;

namespace Azure.Communication.Rooms.Tests
{
    public class RoomsClientTest
    {
        [Test]
        public async Task CreateRoomAsyncShouldSucceed()
        {
            Mock<RoomsClient> mockRoomsClient = new Mock<RoomsClient>();
            CreateRoomRequest createRoomRequest = new CreateRoomRequest();
            Response<CommunicationRoom>? expectedRoomResult = default;
            CancellationToken cancellationToken = new CancellationTokenSource().Token;

            mockRoomsClient
                .Setup(roomsClient => roomsClient.CreateRoomAsync(createRoomRequest, cancellationToken))
                .ReturnsAsync(expectedRoomResult);

            Response<CommunicationRoom> actualResponse = await mockRoomsClient.Object.CreateRoomAsync(createRoomRequest, cancellationToken);

            mockRoomsClient.Verify(roomsClient => roomsClient.CreateRoomAsync(createRoomRequest, cancellationToken), Times.Once());
            Assert.AreEqual(expectedRoomResult, actualResponse);
        }

        [Test]
        public async Task UpdateRoomAsyncShouldSucceed()
        {
            var roomId = "123";
            Mock<RoomsClient> mockRoomsClient = new Mock<RoomsClient>();
            UpdateRoomRequest updateRoomRequest = new UpdateRoomRequest();
            Response<CommunicationRoom>? expectedRoomResult = default;
            CancellationToken cancellationToken = new CancellationTokenSource().Token;

            mockRoomsClient
                .Setup(roomsClient => roomsClient.UpdateRoomAsync(roomId, updateRoomRequest, cancellationToken))
                .ReturnsAsync(expectedRoomResult);

            Response<CommunicationRoom> actualResponse = await mockRoomsClient.Object.UpdateRoomAsync(roomId, updateRoomRequest, cancellationToken);

            mockRoomsClient.Verify(roomsClient => roomsClient.UpdateRoomAsync(roomId, updateRoomRequest, cancellationToken), Times.Once());
            Assert.AreEqual(expectedRoomResult, actualResponse);
        }

        [Test]
        public async Task GetRoomAsyncShouldSucceed()
        {
            var roomId = "123";
            Mock<RoomsClient> mockRoomsClient = new Mock<RoomsClient>();
            Response<CommunicationRoom>? expectedRoomResult = default;
            CancellationToken cancellationToken = new CancellationTokenSource().Token;

            mockRoomsClient
                .Setup(roomsClient => roomsClient.GetRoomAsync(roomId, cancellationToken))
                .ReturnsAsync(expectedRoomResult);

            Response<CommunicationRoom> actualResponse = await mockRoomsClient.Object.GetRoomAsync(roomId, cancellationToken);

            mockRoomsClient.Verify(roomsClient => roomsClient.GetRoomAsync(roomId, cancellationToken), Times.Once());
            Assert.AreEqual(expectedRoomResult, actualResponse);
        }

        [Test]
        public async Task DeleteRoomAsyncShouldSucceed()
        {
            var roomId = "123";
            Mock<RoomsClient> mockRoomsClient = new Mock<RoomsClient>();
            Response? expectedRoomResult = default;
            CancellationToken cancellationToken = new CancellationTokenSource().Token;

            mockRoomsClient
                .Setup(roomsClient => roomsClient.DeleteRoomAsync(roomId, cancellationToken))
                .ReturnsAsync(expectedRoomResult);

            Response actualResponse = await mockRoomsClient.Object.DeleteRoomAsync(roomId, cancellationToken);

            mockRoomsClient.Verify(roomsClient => roomsClient.DeleteRoomAsync(roomId, cancellationToken), Times.Once());
            Assert.AreEqual(expectedRoomResult, actualResponse);
        }

        [Test]
        public void CreateRoomShouldSucceed()
        {
            Mock<RoomsClient> mockRoomsClient = new Mock<RoomsClient>();
            CreateRoomRequest createRoomRequest = new CreateRoomRequest();
            Response<CommunicationRoom>? expectedRoomResult = new Mock<Response<CommunicationRoom>>().Object;
            CancellationToken cancellationToken = new CancellationTokenSource().Token;

            mockRoomsClient
                .Setup(roomsClient => roomsClient.CreateRoom(createRoomRequest, cancellationToken))
                .Returns(expectedRoomResult);

            Response<CommunicationRoom> actualResponse = mockRoomsClient.Object.CreateRoom(createRoomRequest, cancellationToken);

            mockRoomsClient.Verify(roomsClient => roomsClient.CreateRoom(createRoomRequest, cancellationToken), Times.Once());
            Assert.AreEqual(expectedRoomResult, actualResponse);
        }

        [Test]
        public void UpdateRoomShouldSucceed()
        {
            Mock<RoomsClient> mockRoomsClient = new Mock<RoomsClient>();
            string roomId = "123";
            UpdateRoomRequest updateRoomRequest = new UpdateRoomRequest();
            Response<CommunicationRoom>? expectedRoomResult = new Mock<Response<CommunicationRoom>>().Object;
            CancellationToken cancellationToken = new CancellationTokenSource().Token;

            mockRoomsClient
                .Setup(roomsClient => roomsClient.UpdateRoom(roomId, updateRoomRequest, cancellationToken))
                .Returns(expectedRoomResult);

            Response<CommunicationRoom> actualResponse = mockRoomsClient.Object.UpdateRoom(roomId, updateRoomRequest, cancellationToken);

            mockRoomsClient.Verify(roomsClient => roomsClient.UpdateRoom(roomId, updateRoomRequest, cancellationToken), Times.Once());
            Assert.AreEqual(expectedRoomResult, actualResponse);
        }

        [Test]
        public void GetRoomShouldSucceed()
        {
            Mock<RoomsClient> mockRoomsClient = new Mock<RoomsClient>();
            string roomId = "123";
            Response<CommunicationRoom>? expectedRoomResult = new Mock<Response<CommunicationRoom>>().Object;
            CancellationToken cancellationToken = new CancellationTokenSource().Token;

            mockRoomsClient
                .Setup(roomsClient => roomsClient.GetRoom(roomId, cancellationToken))
                .Returns(expectedRoomResult);

            Response<CommunicationRoom> actualResponse = mockRoomsClient.Object.GetRoom(roomId, cancellationToken);

            mockRoomsClient.Verify(roomsClient => roomsClient.GetRoom(roomId, cancellationToken), Times.Once());
            Assert.AreEqual(expectedRoomResult, actualResponse);
        }

        [Test]
        public void DeleteRoomShouldSucceed()
        {
            Mock<RoomsClient> mockRoomsClient = new Mock<RoomsClient>();
            string roomId = "123";
            Response? expectedRoomResult = new Mock<Response>().Object;
            CancellationToken cancellationToken = new CancellationTokenSource().Token;

            mockRoomsClient
                .Setup(roomsClient => roomsClient.DeleteRoom(roomId, cancellationToken))
                .Returns(expectedRoomResult);

            Response actualResponse = mockRoomsClient.Object.DeleteRoom(roomId, cancellationToken);

            mockRoomsClient.Verify(roomsClient => roomsClient.DeleteRoom(roomId, cancellationToken), Times.Once());
            Assert.AreEqual(expectedRoomResult, actualResponse);
        }
    }
}
