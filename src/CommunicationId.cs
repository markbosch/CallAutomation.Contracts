// Copyright (c) 2023 Jason Shave. All rights reserved.
// Licensed under the MIT License.

using System.Text.Json.Serialization;

namespace CallAutomation.Contracts;

public class CommunicationId
{
    [JsonPropertyName("kind")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public CommunicationIdentifierKind Kind { get; set; }

    [JsonPropertyName("rawId")]
    public string? RawId { get; set; } = string.Empty;
}