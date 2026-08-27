
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// How to locate the subject in the source video. `auto` detects a person automatically. `point` uses your `points` to mark the subject. Defaults to `auto`.<br/>
    /// Example: auto
    /// </summary>
    public enum CharacterReplaceCreateVideoRequestStyleSelectionMode
    {
        /// <summary>
        ///
        /// </summary>
        Auto,
        /// <summary>
        ///
        /// </summary>
        Point,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CharacterReplaceCreateVideoRequestStyleSelectionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CharacterReplaceCreateVideoRequestStyleSelectionMode value)
        {
            return value switch
            {
                CharacterReplaceCreateVideoRequestStyleSelectionMode.Auto => "auto",
                CharacterReplaceCreateVideoRequestStyleSelectionMode.Point => "point",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CharacterReplaceCreateVideoRequestStyleSelectionMode? ToEnum(string value)
        {
            return value switch
            {
                "auto" => CharacterReplaceCreateVideoRequestStyleSelectionMode.Auto,
                "point" => CharacterReplaceCreateVideoRequestStyleSelectionMode.Point,
                _ => null,
            };
        }
    }
}