
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Machine-readable error code.<br/>
    /// - `unprocessable_entity`: Change the request values before retrying.
    /// </summary>
    public enum AiVideoTranslatorCreateVideoResponseCode5
    {
        /// <summary>
        /// Change the request values before retrying.
        /// </summary>
        UnprocessableEntity,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AiVideoTranslatorCreateVideoResponseCode5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiVideoTranslatorCreateVideoResponseCode5 value)
        {
            return value switch
            {
                AiVideoTranslatorCreateVideoResponseCode5.UnprocessableEntity => "unprocessable_entity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiVideoTranslatorCreateVideoResponseCode5? ToEnum(string value)
        {
            return value switch
            {
                "unprocessable_entity" => AiVideoTranslatorCreateVideoResponseCode5.UnprocessableEntity,
                _ => null,
            };
        }
    }
}