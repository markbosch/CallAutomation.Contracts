// Copyright (c) 2023 Jason Shave. All rights reserved.
// Licensed under the MIT License.

using System.Text.Json.Serialization;

namespace CallAutomation.Contracts;

public sealed class CustomContext
{
    [JsonPropertyName("sipHeaders")]
    public Dictionary<string, string>? SipHeaders { get; set; } = new ();


    [JsonPropertyName("voipHeaders")]
    public Dictionary<string, string>? VoIpHeaders { get; set; } = new ();
}