
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Example: ai-image-editor
    /// </summary>
    public enum EstimateImageTool
    {
        /// <summary>
        ///
        /// </summary>
        AiClothesChanger,
        /// <summary>
        ///
        /// </summary>
        AiFaceEditor,
        /// <summary>
        ///
        /// </summary>
        AiGifGenerator,
        /// <summary>
        ///
        /// </summary>
        AiHeadshotGenerator,
        /// <summary>
        ///
        /// </summary>
        AiImageEditor,
        /// <summary>
        ///
        /// </summary>
        AiImageGenerator,
        /// <summary>
        ///
        /// </summary>
        AiImageUpscaler,
        /// <summary>
        ///
        /// </summary>
        AiMemeGenerator,
        /// <summary>
        ///
        /// </summary>
        AiQrCodeGenerator,
        /// <summary>
        ///
        /// </summary>
        BodySwap,
        /// <summary>
        ///
        /// </summary>
        FaceSwapPhoto,
        /// <summary>
        ///
        /// </summary>
        HeadSwap,
        /// <summary>
        ///
        /// </summary>
        ImageBackgroundRemover,
        /// <summary>
        ///
        /// </summary>
        PhotoColorizer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EstimateImageToolExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EstimateImageTool value)
        {
            return value switch
            {
                EstimateImageTool.AiClothesChanger => "ai-clothes-changer",
                EstimateImageTool.AiFaceEditor => "ai-face-editor",
                EstimateImageTool.AiGifGenerator => "ai-gif-generator",
                EstimateImageTool.AiHeadshotGenerator => "ai-headshot-generator",
                EstimateImageTool.AiImageEditor => "ai-image-editor",
                EstimateImageTool.AiImageGenerator => "ai-image-generator",
                EstimateImageTool.AiImageUpscaler => "ai-image-upscaler",
                EstimateImageTool.AiMemeGenerator => "ai-meme-generator",
                EstimateImageTool.AiQrCodeGenerator => "ai-qr-code-generator",
                EstimateImageTool.BodySwap => "body-swap",
                EstimateImageTool.FaceSwapPhoto => "face-swap-photo",
                EstimateImageTool.HeadSwap => "head-swap",
                EstimateImageTool.ImageBackgroundRemover => "image-background-remover",
                EstimateImageTool.PhotoColorizer => "photo-colorizer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EstimateImageTool? ToEnum(string value)
        {
            return value switch
            {
                "ai-clothes-changer" => EstimateImageTool.AiClothesChanger,
                "ai-face-editor" => EstimateImageTool.AiFaceEditor,
                "ai-gif-generator" => EstimateImageTool.AiGifGenerator,
                "ai-headshot-generator" => EstimateImageTool.AiHeadshotGenerator,
                "ai-image-editor" => EstimateImageTool.AiImageEditor,
                "ai-image-generator" => EstimateImageTool.AiImageGenerator,
                "ai-image-upscaler" => EstimateImageTool.AiImageUpscaler,
                "ai-meme-generator" => EstimateImageTool.AiMemeGenerator,
                "ai-qr-code-generator" => EstimateImageTool.AiQrCodeGenerator,
                "body-swap" => EstimateImageTool.BodySwap,
                "face-swap-photo" => EstimateImageTool.FaceSwapPhoto,
                "head-swap" => EstimateImageTool.HeadSwap,
                "image-background-remover" => EstimateImageTool.ImageBackgroundRemover,
                "photo-colorizer" => EstimateImageTool.PhotoColorizer,
                _ => null,
            };
        }
    }
}