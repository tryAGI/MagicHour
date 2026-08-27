
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum CharacterReplaceCreateVideoResponseMessage
    {
        /// <summary>
        ///
        /// </summary>
        Unauthorized,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CharacterReplaceCreateVideoResponseMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CharacterReplaceCreateVideoResponseMessage value)
        {
            return value switch
            {
                CharacterReplaceCreateVideoResponseMessage.Unauthorized => "Unauthorized",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CharacterReplaceCreateVideoResponseMessage? ToEnum(string value)
        {
            return value switch
            {
                "Unauthorized" => CharacterReplaceCreateVideoResponseMessage.Unauthorized,
                _ => null,
            };
        }
    }
}