// Copyright (c) 2023 Jason Shave. All rights reserved.
// Licensed under the MIT License.

namespace CallAutomation.Contracts;

public sealed class PhoneNumber : CommunicationId
{
    public string Value { get; set; } = string.Empty;
}