# Microsoft.Extensions.AI Integration

The MagicHour SDK provides `AIFunction` tools that can be used with any `IChatClient` from [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/ai-extensions).

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
