
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum AnimationCreateVideoResponseMessage
    {
        /// <summary>
        ///
        /// </summary>
        Unauthorized,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnimationCreateVideoResponseMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnimationCreateVideoResponseMessage value)
        {
            return value switch
            {
                AnimationCreateVideoResponseMessage.Unauthorized => "Unauthorized",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnimationCreateVideoResponseMessage? ToEnum(string value)
        {
            return value switch
            {
                "Unauthorized" => AnimationCreateVideoResponseMessage.Unauthorized,
                _ => null,
            };
        }
    }
}