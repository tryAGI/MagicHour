
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum AiImageEditorCreateImageResponseMessage2
    {
        /// <summary>
        ///
        /// </summary>
        NotFound,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AiImageEditorCreateImageResponseMessage2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiImageEditorCreateImageResponseMessage2 value)
        {
            return value switch
            {
                AiImageEditorCreateImageResponseMessage2.NotFound => "Not Found",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiImageEditorCreateImageResponseMessage2? ToEnum(string value)
        {
            return value switch
            {
                "Not Found" => AiImageEditorCreateImageResponseMessage2.NotFound,
                _ => null,
            };
        }
    }
}