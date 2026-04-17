
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Output resolution. Determines credits charged for the run.<br/>
    /// Example: 1k
    /// </summary>
    public enum BodySwapCreateImageRequestResolution
    {
        /// <summary>
        /// 
        /// </summary>
        x1k,
        /// <summary>
        /// 
        /// </summary>
        x2k,
        /// <summary>
        /// 
        /// </summary>
        x4k,
        /// <summary>
        /// 
        /// </summary>
        x640px,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodySwapCreateImageRequestResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodySwapCreateImageRequestResolution value)
        {
            return value switch
            {
                BodySwapCreateImageRequestResolution.x1k => "1k",
                BodySwapCreateImageRequestResolution.x2k => "2k",
                BodySwapCreateImageRequestResolution.x4k => "4k",
                BodySwapCreateImageRequestResolution.x640px => "640px",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodySwapCreateImageRequestResolution? ToEnum(string value)
        {
            return value switch
            {
                "1k" => BodySwapCreateImageRequestResolution.x1k,
                "2k" => BodySwapCreateImageRequestResolution.x2k,
                "4k" => BodySwapCreateImageRequestResolution.x4k,
                "640px" => BodySwapCreateImageRequestResolution.x640px,
                _ => null,
            };
        }
    }
}