
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Model to use. Defaults to `wan-animate`.<br/>
    /// * **`wan-animate`**: 480p, 720p. Supports `points` subject selection.<br/>
    /// * **`kling-3.0`**: 720p, 1080p. Clips of 3–10 seconds in `replace` mode or 3–30 seconds in `animate` mode. Picks the main person automatically, so `points` are rejected.<br/>
    /// * **`minimax-h3`**: 480p, 720p, 1080p. Clips of 1–60 seconds in `replace` mode or 1–60 seconds in `animate` mode. Subject `points` are `replace`-only; `animate` with `selection_mode` `point` returns 422, and with `auto` or no `selection_mode` the points are ignored.<br/>
    /// Default Value: wan-animate<br/>
    /// Example: wan-animate
    /// </summary>
    public enum CharacterReplaceCreateVideoRequestModel
    {
        /// <summary>
        /// 720p, 1080p. Clips of 3–10 seconds in `replace` mode or 3–30 seconds in `animate` mode. Picks the main person automatically, so `points` are rejected.
        /// </summary>
        Kling30,
        /// <summary>
        /// 480p, 720p, 1080p. Clips of 1–60 seconds in `replace` mode or 1–60 seconds in `animate` mode. Subject `points` are `replace`-only; `animate` with `selection_mode` `point` returns 422, and with `auto` or no `selection_mode` the points are ignored.
        /// </summary>
        MinimaxH3,
        /// <summary>
        /// 480p, 720p. Supports `points` subject selection.
        /// </summary>
        WanAnimate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CharacterReplaceCreateVideoRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CharacterReplaceCreateVideoRequestModel value)
        {
            return value switch
            {
                CharacterReplaceCreateVideoRequestModel.Kling30 => "kling-3.0",
                CharacterReplaceCreateVideoRequestModel.MinimaxH3 => "minimax-h3",
                CharacterReplaceCreateVideoRequestModel.WanAnimate => "wan-animate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CharacterReplaceCreateVideoRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "kling-3.0" => CharacterReplaceCreateVideoRequestModel.Kling30,
                "minimax-h3" => CharacterReplaceCreateVideoRequestModel.MinimaxH3,
                "wan-animate" => CharacterReplaceCreateVideoRequestModel.WanAnimate,
                _ => null,
            };
        }
    }
}