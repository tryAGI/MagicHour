
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Determines whether the resulting video will have the same frame per second as the original video, or half.<br/>
    /// * `FULL` - the result video will have the same FPS as the input video<br/>
    /// * `HALF` - the result video will have half the FPS as the input video<br/>
    /// Default Value: HALF<br/>
    /// Example: HALF
    /// </summary>
    public enum VideoToVideoCreateVideoRequestFpsResolution
    {
        /// <summary>
        ///
        /// </summary>
        Full,
        /// <summary>
        ///
        /// </summary>
        Half,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoToVideoCreateVideoRequestFpsResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoToVideoCreateVideoRequestFpsResolution value)
        {
            return value switch
            {
                VideoToVideoCreateVideoRequestFpsResolution.Full => "FULL",
                VideoToVideoCreateVideoRequestFpsResolution.Half => "HALF",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoToVideoCreateVideoRequestFpsResolution? ToEnum(string value)
        {
            return value switch
            {
                "FULL" => VideoToVideoCreateVideoRequestFpsResolution.Full,
                "HALF" => VideoToVideoCreateVideoRequestFpsResolution.Half,
                _ => null,
            };
        }
    }
}