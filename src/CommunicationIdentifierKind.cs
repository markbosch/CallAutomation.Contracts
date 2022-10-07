// Copyright (c) 2022 Jason Shave. All rights reserved.
// Licensed under the MIT License.

using System.Runtime.Serialization;

namespace CallAutomation.Contracts;

public enum CommunicationIdentifierKind
{
    [EnumMember(Value= "unknown")]
    Unknown,
    [EnumMember(Value= "communicationUser")]
    CommunicationUser,
    [EnumMember(Value = "phoneNumber")]
    PhoneNumber,
    [EnumMember(Value = "microsoftTeamsUser")]
    MicrosoftTeamsUser,
}