
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum AudioProjectsGetDetailsResponseMessage2
    {
        /// <summary>
        ///
        /// </summary>
        NotFound,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudioProjectsGetDetailsResponseMessage2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioProjectsGetDetailsResponseMessage2 value)
        {
            return value switch
            {
                AudioProjectsGetDetailsResponseMessage2.NotFound => "Not Found",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioProjectsGetDetailsResponseMessage2? ToEnum(string value)
        {
            return value switch
            {
                "Not Found" => AudioProjectsGetDetailsResponseMessage2.NotFound,
                _ => null,
            };
        }
    }
}