
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// The aspect ratio of the output image(s). If not specified, defaults to `auto`.<br/>
    /// Example: 1:1
    /// </summary>
    public enum AiImageEditorCreateImageRequestAspectRatio
    {
        /// <summary>
        /// 
        /// </summary>
        x16_9,
        /// <summary>
        /// 
        /// </summary>
        x1_1,
        /// <summary>
        /// 
        /// </summary>
        x2_3,
        /// <summary>
        /// 
        /// </summary>
        x3_2,
        /// <summary>
        /// 
        /// </summary>
        x4_3,
        /// <summary>
        /// 
        /// </summary>
        x4_5,
        /// <summary>
        /// 
        /// </summary>
        x9_16,
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AiImageEditorCreateImageRequestAspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiImageEditorCreateImageRequestAspectRatio value)
        {
            return value switch
            {
                AiImageEditorCreateImageRequestAspectRatio.x16_9 => "16:9",
                AiImageEditorCreateImageRequestAspectRatio.x1_1 => "1:1",
                AiImageEditorCreateImageRequestAspectRatio.x2_3 => "2:3",
                AiImageEditorCreateImageRequestAspectRatio.x3_2 => "3:2",
                AiImageEditorCreateImageRequestAspectRatio.x4_3 => "4:3",
                AiImageEditorCreateImageRequestAspectRatio.x4_5 => "4:5",
                AiImageEditorCreateImageRequestAspectRatio.x9_16 => "9:16",
                AiImageEditorCreateImageRequestAspectRatio.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiImageEditorCreateImageRequestAspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => AiImageEditorCreateImageRequestAspectRatio.x16_9,
                "1:1" => AiImageEditorCreateImageRequestAspectRatio.x1_1,
                "2:3" => AiImageEditorCreateImageRequestAspectRatio.x2_3,
                "3:2" => AiImageEditorCreateImageRequestAspectRatio.x3_2,
                "4:3" => AiImageEditorCreateImageRequestAspectRatio.x4_3,
                "4:5" => AiImageEditorCreateImageRequestAspectRatio.x4_5,
                "9:16" => AiImageEditorCreateImageRequestAspectRatio.x9_16,
                "auto" => AiImageEditorCreateImageRequestAspectRatio.Auto,
                _ => null,
            };
        }
    }
}