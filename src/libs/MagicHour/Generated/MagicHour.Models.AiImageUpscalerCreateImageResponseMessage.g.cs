
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// 
    /// </summary>
    public enum AiImageUpscalerCreateImageResponseMessage
    {
        /// <summary>
        /// 
        /// </summary>
        Unauthorized,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AiImageUpscalerCreateImageResponseMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiImageUpscalerCreateImageResponseMessage value)
        {
            return value switch
            {
                AiImageUpscalerCreateImageResponseMessage.Unauthorized => "Unauthorized",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiImageUpscalerCreateImageResponseMessage? ToEnum(string value)
        {
            return value switch
            {
                "Unauthorized" => AiImageUpscalerCreateImageResponseMessage.Unauthorized,
                _ => null,
            };
        }
    }
}