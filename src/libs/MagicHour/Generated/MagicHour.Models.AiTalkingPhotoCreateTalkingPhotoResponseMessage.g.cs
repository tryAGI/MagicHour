
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// 
    /// </summary>
    public enum AiTalkingPhotoCreateTalkingPhotoResponseMessage
    {
        /// <summary>
        /// 
        /// </summary>
        Unauthorized,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AiTalkingPhotoCreateTalkingPhotoResponseMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiTalkingPhotoCreateTalkingPhotoResponseMessage value)
        {
            return value switch
            {
                AiTalkingPhotoCreateTalkingPhotoResponseMessage.Unauthorized => "Unauthorized",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiTalkingPhotoCreateTalkingPhotoResponseMessage? ToEnum(string value)
        {
            return value switch
            {
                "Unauthorized" => AiTalkingPhotoCreateTalkingPhotoResponseMessage.Unauthorized,
                _ => null,
            };
        }
    }
}