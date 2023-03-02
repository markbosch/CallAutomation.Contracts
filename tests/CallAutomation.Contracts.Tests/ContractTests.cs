// Copyright (c) 2023 Jason Shave. All rights reserved.
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
                "{\r\n\t\t\"to\": {\r\n\t\t\t\"rawId\": \"8:acs:fake_fake\",\r\n\t\t\t\"kind\": \"communicationUser\",\r\n\t\t\t\"id\": \"8:acs:fake_fake\"\r\n\t\t},\r\n\t\t\"from\": {\r\n\t\t\t\"rawId\": \"4:+14255551212\",\r\n\t\t\t\"kind\": \"phoneNumber\",\r\n\t\t\t\"value\": \"+14255551212\"\r\n\t\t},\r\n\t\t\"callerDisplayName\": \"\",\r\n\t\t\"incomingCallContext\": \"\",\r\n\t\t\"correlationId\": \"f1e2d730-2ed4-4b6f-bf7f-1a8714155e8e\"\r\n\t}";

            // act
            var result = JsonSerializer.Deserialize<IncomingCall>(incomingCallJson);

            // assert
            result.To.Kind.Should().Be(CommunicationIdentifierKind.CommunicationUser);
            result.From.Kind.Should().Be(CommunicationIdentifierKind.PhoneNumber);
        }

        [Fact]
        public void IncomingCall_WithContext_Deserializes()
        {
            // arrange
            var incomingCallJson =
                "{\r\n\t\"to\": {\r\n\t\t\"kind\": \"communicationUser\",\r\n\t\t\"rawId\": \"8:acs:fake_fake\",\r\n\t\t\"communicationUser\": {\r\n\t\t\t\"id\": \"8:acs:fake_fake\"\r\n\t\t}\r\n\t},\r\n\t\"from\": {\r\n\t\t\"kind\": \"communicationUser\",\r\n\t\t\"rawId\": \"8:acs:fake_fake\",\r\n\t\t\"communicationUser\": {\r\n\t\t\t\"id\": \"8:acs:fake_fake\"\r\n\t\t}\r\n\t},\r\n\t\"serverCallId\": \"fakeId\",\r\n\t\"callerDisplayName\": \"\",\r\n\t\"customContext\": {\r\n\t\t\"sipHeaders\": {\r\n\t\t\t\"userToUser\": \"616d617a6f6e5f6368696;encoding=hex\",\r\n\t\t\t\"X-MS-Custom-Header1\": \"8675309\",\r\n\t\t\t\"X-MS-Custom-a1234567890123456789\": \"abc\"\r\n\t\t},\r\n\t\t\"voipHeaders\": {\r\n\t\t\t\"customHeader\": \"123\"\r\n\t\t}\r\n\t}\r\n}";

            // act
            var result = JsonSerializer.Deserialize<IncomingCall>(incomingCallJson);

            // assert
            result.To.Kind.Should().Be(CommunicationIdentifierKind.CommunicationUser);
            result.From.Kind.Should().Be(CommunicationIdentifierKind.CommunicationUser);
            result.CustomContext.Should().NotBeNull();

            result.CustomContext.SipHeaders.Should().NotBeNull();
            result.CustomContext.SipHeaders.ContainsKey("userToUser");
            result.CustomContext.SipHeaders["userToUser"].Should().Be("616d617a6f6e5f6368696;encoding=hex");
            result.CustomContext.SipHeaders.ContainsKey("X-MS-CustomMyHeader");
            result.CustomContext.SipHeaders["X-MS-Custom-Header1"].Should().Be("8675309");

            result.CustomContext.VoIpHeaders.Should().NotBeNull();
            result.CustomContext.VoIpHeaders.ContainsKey("customHeader");
            result.CustomContext.VoIpHeaders["customHeader"].Should().Be("123");
        }
    }
}