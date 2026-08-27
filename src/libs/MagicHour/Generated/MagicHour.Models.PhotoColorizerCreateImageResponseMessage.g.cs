
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum PhotoColorizerCreateImageResponseMessage
    {
        /// <summary>
        ///
        /// </summary>
        Unauthorized,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PhotoColorizerCreateImageResponseMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PhotoColorizerCreateImageResponseMessage value)
        {
            return value switch
            {
                PhotoColorizerCreateImageResponseMessage.Unauthorized => "Unauthorized",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PhotoColorizerCreateImageResponseMessage? ToEnum(string value)
        {
            return value switch
            {
                "Unauthorized" => PhotoColorizerCreateImageResponseMessage.Unauthorized,
                _ => null,
            };
        }
    }
}