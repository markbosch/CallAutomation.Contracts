// Copyright (c) 2022 Jason Shave. All rights reserved.
// Licensed under the MIT License.

namespace CallAutomation.Contracts;

public sealed class IncomingCall
{
    public CommunicationId To { get; set; } = default!;

    public CommunicationId From { get; set; } = default!;

    public string CallerDisplayName { get; set; } = default!;

    public string IncomingCallContext { get; set; } = default!;

    public string CorrelationId { get; set; } = default!;
}