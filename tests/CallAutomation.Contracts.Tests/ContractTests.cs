// Copyright (c) 2022 Jason Shave. All rights reserved.
// Licensed under the MIT License.

using FluentAssertions;
using System.Text.Json;

namespace CallAutomation.Contracts.Tests
{
    public class ContractTests
    {
        [Fact]
        public void IncomingCall_Can_Deserialize()
        {
            // arrange
            var incomingCallJson =
                "{\r\n\t\t\"to\": {\r\n\t\t\t\"rawId\": \"8:acs:0a420b29-555c-4f6b-841e-de8059893bb9_d267c332-e2d1-45c0-91a9-0133573ab7ac\",\r\n\t\t\t\"kind\": \"communicationUser\",\r\n\t\t\t\"id\": \"8:acs:0a420b29-555c-4f6b-841e-de8059893bb9_d267c332-e2d1-45c0-91a9-0133573ab7ac\"\r\n\t\t},\r\n\t\t\"from\": {\r\n\t\t\t\"rawId\": \"4:+14255551212\",\r\n\t\t\t\"kind\": \"phoneNumber\",\r\n\t\t\t\"value\": \"+14255551212\"\r\n\t\t},\r\n\t\t\"callerDisplayName\": \"\",\r\n\t\t\"incomingCallContext\": \"\",\r\n\t\t\"correlationId\": \"f1e2d730-2ed4-4b6f-bf7f-1a8714155e8e\"\r\n\t}";

            // act
            var result = JsonSerializer.Deserialize(incomingCallJson, typeof(IncomingCall), new JsonSerializerOptions()
            {
                AllowTrailingCommas = true,
                PropertyNameCaseInsensitive = true,
            }) as IncomingCall;

            // assert
            result.To.Kind.Should().Be(CommunicationIdentifierKind.CommunicationUser);
            result.From.Kind.Should().Be(CommunicationIdentifierKind.PhoneNumber);
        }
    }
}