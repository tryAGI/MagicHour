
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Editing model. Defaults to `ltx-2.3` for free tier and `gemini-omni` for paid. Use `ltx-2.3` for LTX video edit.<br/>
    /// Example: gemini-omni
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
                "ltx-2.3" => AiVideoEditorCreateVideoRequestModel.Ltx23,
                _ => null,
            };
        }
    }
}