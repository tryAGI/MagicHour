
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Editing model. Defaults to `ltx-2.3` for free tier and `gemini-omni-1.1` for paid. `gemini-omni` is deprecated; use `gemini-omni-1.1` instead.<br/>
    /// Example: gemini-omni-1.1
    /// </summary>
    public enum AiVideoEditorCreateVideoRequestModel
    {
        /// <summary>
        ///
        /// </summary>
        GeminiOmni,
        /// <summary>
        ///
        /// </summary>
        GeminiOmni11,
        /// <summary>
        ///
        /// </summary>
        Ltx23,
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
                AiVideoEditorCreateVideoRequestModel.Ltx23 => "ltx-2.3",
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
                "ltx-2.3" => AiVideoEditorCreateVideoRequestModel.Ltx23,
                _ => null,
            };
        }
    }
}