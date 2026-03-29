# CLAUDE.md -- MagicHour SDK

## Overview

Auto-generated C# SDK for [Magic Hour](https://magichour.ai/) -- AI video generation platform with face swap, lip sync, text-to-video, image-to-video, animation, and 20+ image/audio tools.
OpenAPI spec from `https://docs.magichour.ai/api-reference/openapi.json` (3.0.2).

## Build & Test

```bash
dotnet build MagicHour.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Standard HTTP Bearer token. Get your API key from [Developer Hub](https://magichour.ai/developer?tab=api-keys).

```csharp
var client = new MagicHourClient(apiKey); // MAGICHOUR_API_KEY env var
```

## Key Files

- `src/libs/MagicHour/openapi.yaml` -- Source OpenAPI spec (downloaded from docs.magichour.ai)
- `src/libs/MagicHour/generate.sh` -- Regeneration script
- `src/libs/MagicHour/Generated/` -- **Never edit** -- auto-generated code (909 files)
- `src/libs/MagicHour/Extensions/MagicHourClient.Tools.cs` -- MEAI `AIFunction` tools
- `src/tests/IntegrationTests/Examples/` -- Example tests (also generate docs)

## Sub-client Pattern

```csharp
var client = new MagicHourClient(apiKey);

// Video Projects
client.VideoProjects.TextToVideoCreateVideoAsync(...)       // Text-to-video
client.VideoProjects.ImageToVideoCreateVideoAsync(...)      // Image-to-video
client.VideoProjects.FaceSwapCreateVideoAsync(...)          // Face swap video
client.VideoProjects.LipSyncCreateVideoAsync(...)           // Lip sync
client.VideoProjects.AnimationCreateVideoAsync(...)         // Animation
client.VideoProjects.VideoToVideoCreateVideoAsync(...)      // Video-to-video
client.VideoProjects.AiTalkingPhotoCreateTalkingPhotoAsync(...)  // AI talking photo
client.VideoProjects.AutoSubtitleGeneratorCreateVideoAsync(...)  // Auto subtitles
client.VideoProjects.VideoProjectsGetDetailsAsync(id)       // Get video status
client.VideoProjects.VideoProjectsDeleteAsync(id)           // Delete video

// Image Projects
client.ImageProjects.AiImageGeneratorCreateImageAsync(...)  // AI image generation
client.ImageProjects.FaceSwapPhotoCreateImageAsync(...)     // Face swap photo
client.ImageProjects.AiClothesChangerCreateImageAsync(...)  // AI clothes changer
client.ImageProjects.AiFaceEditorEditImageAsync(...)        // AI face editor
client.ImageProjects.AiHeadshotGeneratorCreateImageAsync(...) // AI headshot
client.ImageProjects.AiImageEditorCreateImageAsync(...)     // AI image editor
client.ImageProjects.AiImageUpscalerCreateImageAsync(...)   // Image upscaler
client.ImageProjects.AiMemeGeneratorCreateImageAsync(...)   // Meme generator
client.ImageProjects.AiQrCodeGeneratorCreateImageAsync(...) // QR code generator
client.ImageProjects.HeadSwapCreateImageAsync(...)          // Head swap
client.ImageProjects.ImageBackgroundRemoverCreateImageAsync(...) // Background remover
client.ImageProjects.PhotoColorizerCreateImageAsync(...)    // Photo colorizer
client.ImageProjects.AiGifGeneratorCreateImageAsync(...)    // GIF generator
client.ImageProjects.ImageProjectsGetDetailsAsync(id)       // Get image status
client.ImageProjects.ImageProjectsDeleteAsync(id)           // Delete image

// Audio Projects
client.AudioProjects.AiVoiceGeneratorCreateAudioAsync(...)  // AI voice generation
client.AudioProjects.AiVoiceClonerCreateAudioAsync(...)     // Voice cloning
client.AudioProjects.AudioProjectsGetDetailsAsync(id)       // Get audio status
client.AudioProjects.AudioProjectsDeleteAsync(id)           // Delete audio

// Files
client.Files.VideoAssetsGeneratePresignedUrlAsync(...)      // Upload URLs
client.Files.FaceDetectionDetectFacesAsync(...)             // Face detection
client.Files.FaceDetectionGetDetailsAsync(id)               // Get face detection
```

## MEAI Integration

AIFunction tools for use with any `IChatClient`:
- `AsTextToVideoTool()` -- Generate video from text prompt
- `AsImageToVideoTool()` -- Generate video from image + prompt
- `AsGetVideoStatusTool()` -- Get video project status and download URLs
- `AsGetImageStatusTool()` -- Get image project status and download URLs
- `AsGenerateImageTool()` -- Generate AI images from text prompt
- `AsFaceSwapVideoTool()` -- Create face swap video
- `AsLipSyncTool()` -- Create lip sync video

## API Pattern

All generation endpoints follow an async task pattern:
1. Upload assets via `Files.VideoAssetsGeneratePresignedUrlAsync()`
2. Create a generation job (returns project ID + estimated credits)
3. Poll status via `VideoProjectsGetDetailsAsync()` / `ImageProjectsGetDetailsAsync()`
4. Statuses: `queued` -> `rendering` -> `complete` (or `error` / `canceled`)
5. When `complete`, download URLs are available in the `Downloads` field
