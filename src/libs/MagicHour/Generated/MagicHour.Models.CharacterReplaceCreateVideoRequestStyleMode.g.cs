
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Processing mode. `replace` swaps the detected subject with your reference character. `animate` transfers motion from the video onto your character image.<br/>
    /// Example: replace
    /// </summary>
    public enum CharacterReplaceCreateVideoRequestStyleMode
    {
        /// <summary>
        ///
        /// </summary>
        Animate,
        /// <summary>
        ///
        /// </summary>
        Replace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CharacterReplaceCreateVideoRequestStyleModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CharacterReplaceCreateVideoRequestStyleMode value)
        {
            return value switch
            {
                CharacterReplaceCreateVideoRequestStyleMode.Animate => "animate",
                CharacterReplaceCreateVideoRequestStyleMode.Replace => "replace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CharacterReplaceCreateVideoRequestStyleMode? ToEnum(string value)
        {
            return value switch
            {
                "animate" => CharacterReplaceCreateVideoRequestStyleMode.Animate,
                "replace" => CharacterReplaceCreateVideoRequestStyleMode.Replace,
                _ => null,
            };
        }
    }
}