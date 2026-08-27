
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// A specific version of our lip sync system, optimized for different needs.<br/>
    /// * `lite` -  Fast and affordable lip sync - best for simple videos. Costs 1 credit per frame of video.<br/>
    /// * `standard` -  Natural, accurate lip sync - best for most creators. Costs 1 credit per frame of video.<br/>
    /// * `pro` -  Premium fidelity with enhanced detail - best for professionals. Costs 2 credits per frame of video.<br/>
    /// Note: `standard` and `pro` are only available for users on Creator, Pro, and Business tiers.<br/>
    ///               <br/>
    /// Default Value: lite<br/>
    /// Example: lite
    /// </summary>
    public enum LipSyncCreateVideoRequestStyleGenerationMode
    {
        /// <summary>
        ///
        /// </summary>
        Lite,
        /// <summary>
        /// `standard` and `pro` are only available for users on Creator, Pro, and Business tiers.
        /// </summary>
        Pro,
        /// <summary>
        /// `standard` and `pro` are only available for users on Creator, Pro, and Business tiers.
        /// </summary>
        Standard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LipSyncCreateVideoRequestStyleGenerationModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LipSyncCreateVideoRequestStyleGenerationMode value)
        {
            return value switch
            {
                LipSyncCreateVideoRequestStyleGenerationMode.Lite => "lite",
                LipSyncCreateVideoRequestStyleGenerationMode.Pro => "pro",
                LipSyncCreateVideoRequestStyleGenerationMode.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LipSyncCreateVideoRequestStyleGenerationMode? ToEnum(string value)
        {
            return value switch
            {
                "lite" => LipSyncCreateVideoRequestStyleGenerationMode.Lite,
                "pro" => LipSyncCreateVideoRequestStyleGenerationMode.Pro,
                "standard" => LipSyncCreateVideoRequestStyleGenerationMode.Standard,
                _ => null,
            };
        }
    }
}