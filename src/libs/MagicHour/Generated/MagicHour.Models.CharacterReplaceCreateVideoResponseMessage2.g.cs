
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum CharacterReplaceCreateVideoResponseMessage2
    {
        /// <summary>
        ///
        /// </summary>
        NotFound,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CharacterReplaceCreateVideoResponseMessage2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CharacterReplaceCreateVideoResponseMessage2 value)
        {
            return value switch
            {
                CharacterReplaceCreateVideoResponseMessage2.NotFound => "Not Found",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CharacterReplaceCreateVideoResponseMessage2? ToEnum(string value)
        {
            return value switch
            {
                "Not Found" => CharacterReplaceCreateVideoResponseMessage2.NotFound,
                _ => null,
            };
        }
    }
}