
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum FaceSwapCreateVideoResponseMessage
    {
        /// <summary>
        ///
        /// </summary>
        Unauthorized,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FaceSwapCreateVideoResponseMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FaceSwapCreateVideoResponseMessage value)
        {
            return value switch
            {
                FaceSwapCreateVideoResponseMessage.Unauthorized => "Unauthorized",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FaceSwapCreateVideoResponseMessage? ToEnum(string value)
        {
            return value switch
            {
                "Unauthorized" => FaceSwapCreateVideoResponseMessage.Unauthorized,
                _ => null,
            };
        }
    }
}