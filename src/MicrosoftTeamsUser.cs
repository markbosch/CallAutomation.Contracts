// Copyright (c) 2023 Jason Shave. All rights reserved.
// Licensed under the MIT License.

namespace CallAutomation.Contracts;

public sealed class MicrosoftTeamsUser : CommunicationId
{
    public string? UserId { get; set; }

    public bool IsAnonymous { get; set; } = default;

    public string? Cloud { get; set; }
}