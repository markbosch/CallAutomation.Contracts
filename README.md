# CallAutomation.Contracts

This repository contains key models used to help developers serialize and deserialize contracts for the Call Automation platform in Azure Communication Services.

## IncomingCall event payload

Currently the Azure Communication Services Call Automation platform is in preview which results in certain contracts not being available in public SDKs. Specifically, the `IncomingCall` event sent through Event Grid is not published in that SDK. You can use this package to easily deserialize the event when receiving the payload from an Event Grid subscription.
