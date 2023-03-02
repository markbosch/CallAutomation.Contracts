# CallAutomation.Contracts

[![.NET](https://github.com/jasonshave/CallAutomation.Contracts/actions/workflows/dotnet.yml/badge.svg)](https://github.com/jasonshave/CallAutomation.Contracts/actions/workflows/dotnet.yml) [![Nuget](https://img.shields.io/nuget/v/CallAutomation.Contracts.svg?style=flat)](https://www.nuget.org/packages/CallAutomation.Contracts/)

This repository contains key models used to help developers serialize and deserialize contracts for the Call Automation platform in Azure Communication Services.

## IncomingCall event deserialization

Currently the Azure Communication Services Call Automation platform is in preview which results in certain contracts not being available in public SDKs. Specifically, the `IncomingCall` event sent through Event Grid is not published in that SDK. You can use this package to easily deserialize this event type when receiving the payload from an Event Grid subscription.

For reference, you can stay up to date with the [current schema](https://learn.microsoft.com/en-us/azure/event-grid/communication-services-voice-video-events) on the Azure Communication Services documentation site.

### 3/1/2023

- Added custom context support
  - SIP UUI and X- headers
  - VoIP headers
