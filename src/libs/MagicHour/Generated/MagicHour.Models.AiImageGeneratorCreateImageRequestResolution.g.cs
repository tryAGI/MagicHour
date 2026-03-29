
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Maximum resolution for the generated image.<br/>
    /// **Options:**<br/>
    /// - `auto` - Automatic resolution (all tiers, default)<br/>
    /// - `2k` - Up to 2048px (requires Pro or Business tier)<br/>
    /// - `4k` - Up to 4096px (requires Business tier)<br/>
    /// Note: Resolution availability depends on the model and your subscription tier. See `model` field for which resolutions each model supports. Defaults to `auto` if not specified.<br/>
    /// Default Value: auto<br/>
    /// Example: auto
    /// </summary>
    public enum AiImageGeneratorCreateImageRequestResolution
    {
        /// <summary>
        /// 
        /// </summary>
        x2k,
        /// <summary>
        /// 
        /// </summary>
        x4k,
        /// <summary>
        /// Resolution availability depends on the model and your subscription tier. See `model` field for which resolutions each model supports. Defaults to `auto` if not specified.
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AiImageGeneratorCreateImageRequestResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiImageGeneratorCreateImageRequestResolution value)
        {
            return value switch
            {
                AiImageGeneratorCreateImageRequestResolution.x2k => "2k",
                AiImageGeneratorCreateImageRequestResolution.x4k => "4k",
                AiImageGeneratorCreateImageRequestResolution.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiImageGeneratorCreateImageRequestResolution? ToEnum(string value)
        {
            return value switch
            {
                "2k" => AiImageGeneratorCreateImageRequestResolution.x2k,
                "4k" => AiImageGeneratorCreateImageRequestResolution.x4k,
                "auto" => AiImageGeneratorCreateImageRequestResolution.Auto,
                _ => null,
            };
        }
    }
}