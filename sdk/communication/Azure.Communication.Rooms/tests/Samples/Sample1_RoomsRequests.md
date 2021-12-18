# Room Service Requests

This sample demonstrates how to send requests to room service.

To get started you'll need a Communication Service Resource.  See [README] for prerequisites and instructions.

## Creating an `RoomsClient`

Rooms clients can be authenticated using the connection string acquired from an Azure Communication Resource in the Azure Portal. Alternatively, Rooms clients can also be authenticated using a valid token credential.

```C# Snippet:Azure_Communication_Rooms_Tests_UsingStatements
using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Communication.Rooms
```

## Create a new room

To create a new  ACS room, call the `CreateRoom` or `CreateRoomAsync` function from the RoomsClient. The returned value is `RoomResult` objects that contains the status and associated error codes in case of a failure.

```C# Snippet:Azure_Communication_Rooms_Tests_Samples_CreateRoomAsync
CreateRoomRequest createRoomRequest = new CreateRoomRequest();
Response<CommunicationRoom> createRoomResponse = await roomsClient.CreateRoomAsync(createRoomRequest);
CommunicationRoom createCommunicationRoom = createRoomResponse.Value;
```

## Update an existing room

To update an existing ACS room, call the `UpdateRoom` or `UpdateRoomAsync` function from the RoomsClient. The returned value is `RoomResult` objects that contains the status and associated error codes in case of a failure.

```C# Snippet:Azure_Communication_Rooms_Tests_Samples_UpdateRoomAsync
Response<CommunicationRoom> updateRoomResponse = await roomsClient.UpdateRoomAsync(createdRoomId, updateRoomRequest);
CommunicationRoom updateCommunicationRoom = updateRoomResponse.Value;
```


## Get an existing room

To create an existing ACS room, call the `GetRoom` or `GetRoomAsync` function from the RoomsClient. The returned value is `RoomResult` objects that contains the status and associated error codes in case of a failure.

```C# Snippet:Azure_Communication_Rooms_Tests_Samples_GetRoomAsync
Response<CommunicationRoom> getRoomResponse = await roomsClient.GetRoomAsync(
    createdRoomId: "existing room Id which is created already
CommunicationRoom getCommunicationRoom = getRoomResponse.Value;
```


## Delete an existing room

To delete an existing ACS room, call the `DeleteRoom` or `DeleteRoomAsync` function from the RoomsClient. The returned value is `RoomResult` objects that contains the status and associated error codes in case of a failure.

```C# Snippet:Azure_Communication_Rooms_Tests_Samples_DeleteRoomAsync
Response deleteRoomResponse = await roomsClient.DeleteRoomAsync(
    createdRoomId: "existing room Id which is created already
```
