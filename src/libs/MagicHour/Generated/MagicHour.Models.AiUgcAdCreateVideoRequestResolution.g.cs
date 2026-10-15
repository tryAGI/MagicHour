
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Defaults to 720p on paid plans and 480p on free plans. Unsupported model/resolution combinations and resolutions unavailable for your plan are rejected.
    /// </summary>
    public enum AiUgcAdCreateVideoRequestResolution
    {
        /// <summary>
        ///
        /// </summary>
        x1080p,
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
    public static class AiUgcAdCreateVideoRequestResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiUgcAdCreateVideoRequestResolution value)
        {
            return value switch
            {
                AiUgcAdCreateVideoRequestResolution.x1080p => "1080p",
                AiUgcAdCreateVideoRequestResolution.x480p => "480p",
                AiUgcAdCreateVideoRequestResolution.x720p => "720p",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiUgcAdCreateVideoRequestResolution? ToEnum(string value)
        {
            return value switch
            {
                "1080p" => AiUgcAdCreateVideoRequestResolution.x1080p,
                "480p" => AiUgcAdCreateVideoRequestResolution.x480p,
                "720p" => AiUgcAdCreateVideoRequestResolution.x720p,
                _ => null,
            };
        }
    }
}