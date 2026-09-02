
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Machine-readable error code.<br/>
    /// - `invalid_request`: Fix request syntax or validation errors before retrying.
    /// </summary>
    public enum AudioToVideoCreateVideoResponseCode
    {
        /// <summary>
        /// Fix request syntax or validation errors before retrying.
        /// </summary>
        InvalidRequest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudioToVideoCreateVideoResponseCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioToVideoCreateVideoResponseCode value)
        {
            return value switch
            {
                AudioToVideoCreateVideoResponseCode.InvalidRequest => "invalid_request",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioToVideoCreateVideoResponseCode? ToEnum(string value)
        {
            return value switch
            {
                "invalid_request" => AudioToVideoCreateVideoResponseCode.InvalidRequest,
                _ => null,
            };
        }
    }
}