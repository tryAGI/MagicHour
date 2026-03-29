
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// 
    /// </summary>
    public enum ImageProjectsGetDetailsResponseMessage
    {
        /// <summary>
        /// 
        /// </summary>
        Unauthorized,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageProjectsGetDetailsResponseMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageProjectsGetDetailsResponseMessage value)
        {
            return value switch
            {
                ImageProjectsGetDetailsResponseMessage.Unauthorized => "Unauthorized",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageProjectsGetDetailsResponseMessage? ToEnum(string value)
        {
            return value switch
            {
                "Unauthorized" => ImageProjectsGetDetailsResponseMessage.Unauthorized,
                _ => null,
            };
        }
    }
}