// Copyright (c) 2022 Jason Shave. All rights reserved.
// Licensed under the MIT License.

using System.Text.Json.Serialization;

namespace JasonShave.CallAutomation.Contracts;

[Serializable]
public class CommunicationIdentifier
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public CommunicationIdentifierKind Kind { get; set; }

    public string? RawId { get; set; } = string.Empty;

    public CommunicationUserIdentifier? CommunicationUser { get; set; }

    public PhoneNumberIdentifier? PhoneNumber { get; set; }

    public MicrosoftTeamsUserIdentifier? MicrosoftTeamsUser { get; set; }
}