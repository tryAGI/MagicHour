
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// The AI model to use for video editing. Defaults to `ltx-2.5` on free tiers and `gemini-omni-1.2` on paid tiers.<br/>
    /// * `gemini-omni-1.2`: Best for precise clips up to 15s, references, and high-resolution output. Requires a paid tier.<br/>
    /// * `wan-3.0`: High-quality video with native audio, long clips, and end-frame control. Requires a paid tier.<br/>
    /// * `ltx-2.5`: Fastest for general scenes, long clips, audio, and rapid iteration.<br/>
    /// * `kling-4.0`: Create cinematic videos with image and video references and optional audio. Requires a paid tier.<br/>
    /// Example: ltx-2.5
    /// </summary>
    public enum AiVideoEditorCreateVideoRequestModel
    {
        /// <summary>
        /// Best for precise clips up to 15s, references, and high-resolution output. Requires a paid tier.
        /// </summary>
        GeminiOmni,
        /// <summary>
        ///
        /// </summary>
        GeminiOmni11,
        /// <summary>
        /// Best for precise clips up to 15s, references, and high-resolution output. Requires a paid tier.
        /// </summary>
        GeminiOmni12,
        /// <summary>
        /// Create cinematic videos with image and video references and optional audio. Requires a paid tier.
        /// </summary>
        Kling40,
        /// <summary>
        ///
        /// </summary>
        Ltx23,
        /// <summary>
        /// Fastest for general scenes, long clips, audio, and rapid iteration.
        /// </summary>
        Ltx25,
        /// <summary>
        /// High-quality video with native audio, long clips, and end-frame control. Requires a paid tier.
        /// </summary>
        Wan30,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AiVideoEditorCreateVideoRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiVideoEditorCreateVideoRequestModel value)
        {
            return value switch
            {
                AiVideoEditorCreateVideoRequestModel.GeminiOmni => "gemini-omni",
                AiVideoEditorCreateVideoRequestModel.GeminiOmni11 => "gemini-omni-1.1",
                AiVideoEditorCreateVideoRequestModel.GeminiOmni12 => "gemini-omni-1.2",
                AiVideoEditorCreateVideoRequestModel.Kling40 => "kling-4.0",
                AiVideoEditorCreateVideoRequestModel.Ltx23 => "ltx-2.3",
                AiVideoEditorCreateVideoRequestModel.Ltx25 => "ltx-2.5",
                AiVideoEditorCreateVideoRequestModel.Wan30 => "wan-3.0",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiVideoEditorCreateVideoRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "gemini-omni" => AiVideoEditorCreateVideoRequestModel.GeminiOmni,
                "gemini-omni-1.1" => AiVideoEditorCreateVideoRequestModel.GeminiOmni11,
                "gemini-omni-1.2" => AiVideoEditorCreateVideoRequestModel.GeminiOmni12,
                "kling-4.0" => AiVideoEditorCreateVideoRequestModel.Kling40,
                "ltx-2.3" => AiVideoEditorCreateVideoRequestModel.Ltx23,
                "ltx-2.5" => AiVideoEditorCreateVideoRequestModel.Ltx25,
                "wan-3.0" => AiVideoEditorCreateVideoRequestModel.Wan30,
                _ => null,
            };
        }
    }
}