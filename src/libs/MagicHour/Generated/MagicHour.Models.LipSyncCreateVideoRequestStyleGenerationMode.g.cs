
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// A specific version of our lip sync system, optimized for different needs.<br/>
    /// * `lite` -  Fast lip sync - best for simple videos. Costs 1 credit per frame of video.<br/>
    /// * `standard` -  Natural, accurate lip sync - best for most creators. Requires visible mouth movement in the opening seconds of the input video. Costs 1 credit per frame of video.<br/>
    /// * `pro` -  Premium fidelity with enhanced detail - best for professionals. Requires visible mouth movement in the opening seconds of the input video. Costs 2 credits per frame of video.<br/>
    /// If your source is a still image, including a still image saved as a static video, use [AI Talking Photo](https://docs.magichour.ai/api-reference/video-projects/ai-talking-photo) with the original image and your audio instead.<br/>
    /// Note: `pro` is only available for users on Creator, Pro, and Business tiers.<br/>
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
        /// //docs.magichour.ai/api-reference/video-projects/ai-talking-photo) with the original image and your audio instead.
        /// </summary>
        Pro,
        /// <summary>
        ///
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