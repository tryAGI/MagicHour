
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// 
    /// </summary>
    public enum PhotoColorizerCreateImageResponseMessage2
    {
        /// <summary>
        /// 
        /// </summary>
        NotFound,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PhotoColorizerCreateImageResponseMessage2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PhotoColorizerCreateImageResponseMessage2 value)
        {
            return value switch
            {
                PhotoColorizerCreateImageResponseMessage2.NotFound => "Not Found",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PhotoColorizerCreateImageResponseMessage2? ToEnum(string value)
        {
            return value switch
            {
                "Not Found" => PhotoColorizerCreateImageResponseMessage2.NotFound,
                _ => null,
            };
        }
    }
}