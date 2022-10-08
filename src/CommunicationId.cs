// Copyright (c) 2022 Jason Shave. All rights reserved.
// Licensed under the MIT License.

using System.Text.Json.Serialization;

namespace CallAutomation.Contracts;

public class CommunicationId
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public CommunicationIdentifierKind Kind { get; set; }

    public string? RawId { get; set; } = string.Empty;
}