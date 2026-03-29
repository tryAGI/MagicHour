# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The MagicHour SDK provides `AIFunction` tool wrappers compatible with [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai). These tools can be used with any `IChatClient` to give AI models access to Magic Hour's AI video generation, face swap, lip sync, and image generation capabilities.

## Available Tools

| Tool | Description |
|------|-------------|
| `AsTextToVideoTool()` | Generate video from a text prompt |
| `AsImageToVideoTool()` | Generate video from an image and text prompt |
| `AsGetVideoStatusTool()` | Get video project status and download URLs |
| `AsGetImageStatusTool()` | Get image project status and download URLs |
| `AsGenerateImageTool()` | Generate AI images from a text prompt |
| `AsFaceSwapVideoTool()` | Create a face swap video |
| `AsLipSyncTool()` | Create a lip sync video |

## Usage

```csharp
using MagicHour;
using Microsoft.Extensions.AI;

var client = new MagicHourClient(apiKey);

// Get tools for use with any IChatClient
IList<AITool> tools =
[
    client.AsTextToVideoTool(),
    client.AsImageToVideoTool(),
    client.AsGetVideoStatusTool(),
    client.AsGetImageStatusTool(),
    client.AsGenerateImageTool(),
    client.AsFaceSwapVideoTool(),
    client.AsLipSyncTool(),
];

// Pass tools to any IChatClient
var response = await chatClient.GetResponseAsync(
    "Generate a 5-second video of a dog running through a meadow",
    new ChatOptions { Tools = tools });
```
