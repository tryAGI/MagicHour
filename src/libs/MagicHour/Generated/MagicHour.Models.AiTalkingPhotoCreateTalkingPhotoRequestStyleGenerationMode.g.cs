
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Controls overall motion style.<br/>
    /// * `realistic` - Maintains likeness well, high quality, and reliable.<br/>
    /// * `prompted` - Slightly lower likeness; allows option to prompt scene.<br/>
    /// **Deprecated values (maintained for backward compatibility):**<br/>
    /// * `pro` - Deprecated: use `realistic`<br/>
    /// * `standard` - Deprecated: use `prompted`<br/>
    /// * `stable` - Deprecated: use `realistic`<br/>
    /// * `expressive` - Deprecated: use `prompted`<br/>
    /// Default Value: realistic<br/>
    /// Example: realistic
    /// </summary>
    public enum AiTalkingPhotoCreateTalkingPhotoRequestStyleGenerationMode
    {
        /// <summary>
        /// use `prompted`
        /// </summary>
        Expressive,
        /// <summary>
        /// use `realistic`
        /// </summary>
        Pro,
        /// <summary>
        /// use `prompted`
        /// </summary>
        Prompted,
        /// <summary>
        /// use `realistic`
        /// </summary>
        Realistic,
        /// <summary>
        /// use `realistic`
        /// </summary>
        Stable,
        /// <summary>
        /// use `prompted`
        /// </summary>
        Standard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AiTalkingPhotoCreateTalkingPhotoRequestStyleGenerationModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiTalkingPhotoCreateTalkingPhotoRequestStyleGenerationMode value)
        {
            return value switch
            {
                AiTalkingPhotoCreateTalkingPhotoRequestStyleGenerationMode.Expressive => "expressive",
                AiTalkingPhotoCreateTalkingPhotoRequestStyleGenerationMode.Pro => "pro",
                AiTalkingPhotoCreateTalkingPhotoRequestStyleGenerationMode.Prompted => "prompted",
                AiTalkingPhotoCreateTalkingPhotoRequestStyleGenerationMode.Realistic => "realistic",
                AiTalkingPhotoCreateTalkingPhotoRequestStyleGenerationMode.Stable => "stable",
                AiTalkingPhotoCreateTalkingPhotoRequestStyleGenerationMode.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiTalkingPhotoCreateTalkingPhotoRequestStyleGenerationMode? ToEnum(string value)
        {
            return value switch
            {
                "expressive" => AiTalkingPhotoCreateTalkingPhotoRequestStyleGenerationMode.Expressive,
                "pro" => AiTalkingPhotoCreateTalkingPhotoRequestStyleGenerationMode.Pro,
                "prompted" => AiTalkingPhotoCreateTalkingPhotoRequestStyleGenerationMode.Prompted,
                "realistic" => AiTalkingPhotoCreateTalkingPhotoRequestStyleGenerationMode.Realistic,
                "stable" => AiTalkingPhotoCreateTalkingPhotoRequestStyleGenerationMode.Stable,
                "standard" => AiTalkingPhotoCreateTalkingPhotoRequestStyleGenerationMode.Standard,
                _ => null,
            };
        }
    }
}