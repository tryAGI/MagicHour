
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Machine-readable error code.<br/>
    /// - `unauthorized`: Provide a valid API key before retrying.
    /// </summary>
    public enum AiFaceEditorEditImageResponseCode2
    {
        /// <summary>
        /// Provide a valid API key before retrying.
        /// </summary>
        Unauthorized,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AiFaceEditorEditImageResponseCode2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiFaceEditorEditImageResponseCode2 value)
        {
            return value switch
            {
                AiFaceEditorEditImageResponseCode2.Unauthorized => "unauthorized",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiFaceEditorEditImageResponseCode2? ToEnum(string value)
        {
            return value switch
            {
                "unauthorized" => AiFaceEditorEditImageResponseCode2.Unauthorized,
                _ => null,
            };
        }
    }
}