
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Example: image-to-video
    /// </summary>
    public enum EstimateVideoTool
    {
        /// <summary>
        ///
        /// </summary>
        AiUgcAd,
        /// <summary>
        ///
        /// </summary>
        AiVideoEditor,
        /// <summary>
        ///
        /// </summary>
        AiVideoTranslator,
        /// <summary>
        ///
        /// </summary>
        AiVideoUpscaler,
        /// <summary>
        ///
        /// </summary>
        AudioToVideo,
        /// <summary>
        ///
        /// </summary>
        AutoSubtitleGenerator,
        /// <summary>
        ///
        /// </summary>
        CharacterReplace,
        /// <summary>
        ///
        /// </summary>
        FaceSwap,
        /// <summary>
        ///
        /// </summary>
        ImageToVideo,
        /// <summary>
        ///
        /// </summary>
        TextToVideo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EstimateVideoToolExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EstimateVideoTool value)
        {
            return value switch
            {
                EstimateVideoTool.AiUgcAd => "ai-ugc-ad",
                EstimateVideoTool.AiVideoEditor => "ai-video-editor",
                EstimateVideoTool.AiVideoTranslator => "ai-video-translator",
                EstimateVideoTool.AiVideoUpscaler => "ai-video-upscaler",
                EstimateVideoTool.AudioToVideo => "audio-to-video",
                EstimateVideoTool.AutoSubtitleGenerator => "auto-subtitle-generator",
                EstimateVideoTool.CharacterReplace => "character-replace",
                EstimateVideoTool.FaceSwap => "face-swap",
                EstimateVideoTool.ImageToVideo => "image-to-video",
                EstimateVideoTool.TextToVideo => "text-to-video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EstimateVideoTool? ToEnum(string value)
        {
            return value switch
            {
                "ai-ugc-ad" => EstimateVideoTool.AiUgcAd,
                "ai-video-editor" => EstimateVideoTool.AiVideoEditor,
                "ai-video-translator" => EstimateVideoTool.AiVideoTranslator,
                "ai-video-upscaler" => EstimateVideoTool.AiVideoUpscaler,
                "audio-to-video" => EstimateVideoTool.AudioToVideo,
                "auto-subtitle-generator" => EstimateVideoTool.AutoSubtitleGenerator,
                "character-replace" => EstimateVideoTool.CharacterReplace,
                "face-swap" => EstimateVideoTool.FaceSwap,
                "image-to-video" => EstimateVideoTool.ImageToVideo,
                "text-to-video" => EstimateVideoTool.TextToVideo,
                _ => null,
            };
        }
    }
}