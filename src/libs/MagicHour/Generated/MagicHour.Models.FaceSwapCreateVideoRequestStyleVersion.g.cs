
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// * `v1` - May preserve skin detail and texture better, but weaker identity preservation.<br/>
    /// * `v2` - Faster, sharper, better handling of hair and glasses. stronger identity preservation.<br/>
    /// * `default` - Use the version we recommend, which will change over time. This is recommended unless you need a specific earlier version. This is the default behavior.<br/>
    /// Example: default
    /// </summary>
    public enum FaceSwapCreateVideoRequestStyleVersion
    {
        /// <summary>
        /// 
        /// </summary>
        Default,
        /// <summary>
        /// 
        /// </summary>
        V1,
        /// <summary>
        /// 
        /// </summary>
        V2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FaceSwapCreateVideoRequestStyleVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FaceSwapCreateVideoRequestStyleVersion value)
        {
            return value switch
            {
                FaceSwapCreateVideoRequestStyleVersion.Default => "default",
                FaceSwapCreateVideoRequestStyleVersion.V1 => "v1",
                FaceSwapCreateVideoRequestStyleVersion.V2 => "v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FaceSwapCreateVideoRequestStyleVersion? ToEnum(string value)
        {
            return value switch
            {
                "default" => FaceSwapCreateVideoRequestStyleVersion.Default,
                "v1" => FaceSwapCreateVideoRequestStyleVersion.V1,
                "v2" => FaceSwapCreateVideoRequestStyleVersion.V2,
                _ => null,
            };
        }
    }
}