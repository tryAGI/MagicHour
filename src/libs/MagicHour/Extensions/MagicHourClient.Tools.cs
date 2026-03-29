#nullable enable

using System.ComponentModel;
using Microsoft.Extensions.AI;

namespace MagicHour;

public static class MagicHourClientTools
{
    /// <summary>
    /// Creates an AIFunction tool that generates a text-to-video using Magic Hour.
    /// </summary>
    public static AIFunction AsTextToVideoTool(this MagicHourClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("Text prompt describing the video to generate")] string prompt,
                   [Description("Duration of the video in seconds (e.g. 5, 10)")] float endSeconds,
                   [Description("Aspect ratio: '16:9', '9:16', or '1:1'")] string? aspectRatio,
                   [Description("AI model to use: 'default', 'ltx-2', 'seedance', 'kling-2.5', 'kling-3.0', 'sora-2', 'veo3.1'")] string? model,
                   [Description("Resolution: '480p', '720p', or '1080p'")] string? resolution,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.VideoProjects.TextToVideoCreateVideoAsync(
                    request: new TextToVideoCreateVideoRequest
                    {
                        EndSeconds = endSeconds,
                        AspectRatio = aspectRatio switch
                        {
                            "9:16" => TextToVideoCreateVideoRequestAspectRatio.x9_16,
                            "1:1" => TextToVideoCreateVideoRequestAspectRatio.x1_1,
                            _ => TextToVideoCreateVideoRequestAspectRatio.x16_9,
                        },
                        Resolution = resolution switch
                        {
                            "480p" => TextToVideoCreateVideoRequestResolution.x480p,
                            "1080p" => TextToVideoCreateVideoRequestResolution.x1080p,
                            _ => TextToVideoCreateVideoRequestResolution.x720p,
                        },
                        Model = model switch
                        {
                            "ltx-2" => TextToVideoCreateVideoRequestModel.Ltx2,
                            "seedance" => TextToVideoCreateVideoRequestModel.Seedance,
                            "kling-2.5" => TextToVideoCreateVideoRequestModel.Kling25,
                            "kling-3.0" => TextToVideoCreateVideoRequestModel.Kling30,
                            "sora-2" => TextToVideoCreateVideoRequestModel.Sora2,
                            "veo3.1" => TextToVideoCreateVideoRequestModel.Veo31,
                            _ => TextToVideoCreateVideoRequestModel.Default,
                        },
                        Style = new TextToVideoCreateVideoRequestStyle
                        {
                            Prompt = prompt,
                        },
                    },
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    response.Id,
                    response.CreditsCharged,
                };
            },
            name: "MagicHour_TextToVideo",
            description: "Generate a video from a text prompt using Magic Hour AI. Returns a project ID that can be used to check status.");
    }

    /// <summary>
    /// Creates an AIFunction tool that generates a video from an image using Magic Hour.
    /// </summary>
    public static AIFunction AsImageToVideoTool(this MagicHourClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("File path of the uploaded image (from upload-urls API)")] string imageFilePath,
                   [Description("Text prompt describing the motion/animation")] string prompt,
                   [Description("Duration of the video in seconds (e.g. 5, 10)")] float endSeconds,
                   [Description("AI model to use: 'default', 'ltx-2', 'seedance', 'kling-2.5', 'kling-3.0', 'sora-2', 'veo3.1'")] string? model,
                   [Description("Resolution: '480p', '720p', or '1080p'")] string? resolution,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.VideoProjects.ImageToVideoCreateVideoAsync(
                    request: new ImageToVideoCreateVideoRequest
                    {
                        EndSeconds = endSeconds,
                        Resolution = resolution switch
                        {
                            "480p" => ImageToVideoCreateVideoRequestResolution.x480p,
                            "1080p" => ImageToVideoCreateVideoRequestResolution.x1080p,
                            _ => ImageToVideoCreateVideoRequestResolution.x720p,
                        },
                        Model = model switch
                        {
                            "ltx-2" => ImageToVideoCreateVideoRequestModel.Ltx2,
                            "seedance" => ImageToVideoCreateVideoRequestModel.Seedance,
                            "kling-2.5" => ImageToVideoCreateVideoRequestModel.Kling25,
                            "kling-3.0" => ImageToVideoCreateVideoRequestModel.Kling30,
                            "sora-2" => ImageToVideoCreateVideoRequestModel.Sora2,
                            "veo3.1" => ImageToVideoCreateVideoRequestModel.Veo31,
                            _ => ImageToVideoCreateVideoRequestModel.Default,
                        },
                        Style = new ImageToVideoCreateVideoRequestStyle
                        {
                            Prompt = prompt,
                        },
                        Assets = new ImageToVideoCreateVideoRequestAssets
                        {
                            ImageFilePath = imageFilePath,
                        },
                    },
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    response.Id,
                    response.CreditsCharged,
                };
            },
            name: "MagicHour_ImageToVideo",
            description: "Generate a video from an image and text prompt using Magic Hour AI. Upload the image first via the upload-urls API. Returns a project ID to check status.");
    }

    /// <summary>
    /// Creates an AIFunction tool that gets the status and details of a video project.
    /// </summary>
    public static AIFunction AsGetVideoStatusTool(this MagicHourClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("The video project ID to check status for")] string projectId,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.VideoProjects.VideoProjectsGetDetailsAsync(
                    id: projectId,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    response.Id,
                    response.Name,
                    Status = response.Status.ToString(),
                    response.Type,
                    response.Width,
                    response.Height,
                    response.Fps,
                    response.CreditsCharged,
                    Downloads = response.Downloads.Select(d => new { d.Url, d.ExpiresAt }).ToArray(),
                    Error = response.Error,
                };
            },
            name: "MagicHour_GetVideoStatus",
            description: "Get the status and details of a Magic Hour video project. Statuses: queued, rendering, complete, error, canceled. When complete, the downloads field contains output URLs.");
    }

    /// <summary>
    /// Creates an AIFunction tool that gets the status and details of an image project.
    /// </summary>
    public static AIFunction AsGetImageStatusTool(this MagicHourClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("The image project ID to check status for")] string projectId,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.ImageProjects.ImageProjectsGetDetailsAsync(
                    id: projectId,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    response.Id,
                    response.Name,
                    Status = response.Status.ToString(),
                    response.Type,
                    response.ImageCount,
                    response.CreditsCharged,
                    Downloads = response.Downloads.Select(d => new { d.Url, d.ExpiresAt }).ToArray(),
                    Error = response.Error,
                };
            },
            name: "MagicHour_GetImageStatus",
            description: "Get the status and details of a Magic Hour image project. Statuses: queued, rendering, complete, error, canceled. When complete, the downloads field contains output URLs.");
    }

    /// <summary>
    /// Creates an AIFunction tool that generates an AI image.
    /// </summary>
    public static AIFunction AsGenerateImageTool(this MagicHourClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("Text prompt describing the image to generate")] string prompt,
                   [Description("Number of images to generate (1-4)")] int? imageCount,
                   [Description("Aspect ratio: '16:9' (landscape), '9:16' (portrait), or '1:1' (square)")] string? aspectRatio,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.ImageProjects.AiImageGeneratorCreateImageAsync(
                    request: new AiImageGeneratorCreateImageRequest
                    {
                        ImageCount = imageCount ?? 1,
                        AspectRatio = aspectRatio switch
                        {
                            "16:9" => AiImageGeneratorCreateImageRequestAspectRatio.x16_9,
                            "9:16" => AiImageGeneratorCreateImageRequestAspectRatio.x9_16,
                            _ => AiImageGeneratorCreateImageRequestAspectRatio.x1_1,
                        },
                        Style = new AiImageGeneratorCreateImageRequestStyle
                        {
                            Prompt = prompt,
                        },
                    },
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    response.Id,
                    response.CreditsCharged,
                };
            },
            name: "MagicHour_GenerateImage",
            description: "Generate AI images from a text prompt using Magic Hour. Returns a project ID that can be used to check status and get download URLs.");
    }

    /// <summary>
    /// Creates an AIFunction tool that creates a face swap video.
    /// </summary>
    public static AIFunction AsFaceSwapVideoTool(this MagicHourClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("File path of the uploaded video (from upload-urls API)")] string videoFilePath,
                   [Description("Start time in seconds")] float startSeconds,
                   [Description("End time in seconds")] float endSeconds,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.VideoProjects.FaceSwapCreateVideoAsync(
                    request: new FaceSwapCreateVideoRequest
                    {
                        StartSeconds = startSeconds,
                        EndSeconds = endSeconds,
                        Assets = new FaceSwapCreateVideoRequestAssets
                        {
                            VideoSource = FaceSwapCreateVideoRequestAssetsVideoSource.File,
                            VideoFilePath = videoFilePath,
                            FaceSwapMode = FaceSwapCreateVideoRequestAssetsFaceSwapMode.AllFaces,
                        },
                    },
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    response.Id,
                    response.CreditsCharged,
                };
            },
            name: "MagicHour_FaceSwapVideo",
            description: "Create a face swap video using Magic Hour AI. Upload video first via the upload-urls API. Returns a project ID to check status.");
    }

    /// <summary>
    /// Creates an AIFunction tool that creates a lip sync video.
    /// </summary>
    public static AIFunction AsLipSyncTool(this MagicHourClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("File path of the uploaded video (from upload-urls API)")] string videoFilePath,
                   [Description("File path of the uploaded audio (from upload-urls API)")] string audioFilePath,
                   [Description("Start time in seconds")] float startSeconds,
                   [Description("End time in seconds")] float endSeconds,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.VideoProjects.LipSyncCreateVideoAsync(
                    request: new LipSyncCreateVideoRequest
                    {
                        StartSeconds = startSeconds,
                        EndSeconds = endSeconds,
                        Assets = new LipSyncCreateVideoRequestAssets
                        {
                            AudioFilePath = audioFilePath,
                            VideoSource = LipSyncCreateVideoRequestAssetsVideoSource.File,
                            VideoFilePath = videoFilePath,
                        },
                    },
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    response.Id,
                    response.CreditsCharged,
                };
            },
            name: "MagicHour_LipSync",
            description: "Create a lip sync video using Magic Hour AI. Upload video and audio first via the upload-urls API. Returns a project ID to check status.");
    }
}
