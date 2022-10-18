// Copyright (c) 2022 Jason Shave. All rights reserved.
// Licensed under the MIT License.

using System.Text.Json.Serialization;

namespace CallAutomation.Contracts;

public sealed class IncomingCall
{
    [JsonPropertyName("to")]
    public CommunicationId To { get; set; } = null!;

    [JsonPropertyName("from")]
    public CommunicationId From { get; set; } = null!;

    [JsonPropertyName("callerDisplayName")]
    public string CallerDisplayName { get; set; } = string.Empty;

    [JsonPropertyName("incomingCallContext")]
    public string IncomingCallContext { get; set; } = string.Empty;

    [JsonPropertyName("correlationId")]
    public string CorrelationId { get; set; } = string.Empty;

    [JsonPropertyName("serverCallId")]
    public string? ServerCallId { get; set; }
}