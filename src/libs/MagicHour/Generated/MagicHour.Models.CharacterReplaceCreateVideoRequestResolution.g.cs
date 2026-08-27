
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Output video resolution. Defaults to 480p, the lowest resolution available on your plan.<br/>
    /// Example: 720p
    /// </summary>
    public enum CharacterReplaceCreateVideoRequestResolution
    {
        /// <summary>
        ///
        /// </summary>
        x480p,
        /// <summary>
        ///
        /// </summary>
        x720p,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CharacterReplaceCreateVideoRequestResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CharacterReplaceCreateVideoRequestResolution value)
        {
            return value switch
            {
                CharacterReplaceCreateVideoRequestResolution.x480p => "480p",
                CharacterReplaceCreateVideoRequestResolution.x720p => "720p",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CharacterReplaceCreateVideoRequestResolution? ToEnum(string value)
        {
            return value switch
            {
                "480p" => CharacterReplaceCreateVideoRequestResolution.x480p,
                "720p" => CharacterReplaceCreateVideoRequestResolution.x720p,
                _ => null,
            };
        }
    }
}