
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// The AI model to use for image editing. Each model has different capabilities and costs.<br/>
    /// **Models:**<br/>
    /// - `default` - Use the model we recommend, which will change over time. This is recommended unless you need a specific model. This is the default behavior.<br/>
    /// - `qwen-edit` - from 10 credits/image<br/>
    ///   - Supported resolutions: 640px, 1k, 2k<br/>
    ///   - Available for tiers: free, creator, pro, business<br/>
    ///   - Max additional input images: 2<br/>
    /// - `flux-2-klein` - from 5 credits/image<br/>
    ///   - Supported resolutions: 640px, 1k, 2k<br/>
    ///   - Available for tiers: free, creator, pro, business<br/>
    ///   - Max additional input images: 5<br/>
    /// - `nano-banana` - from 50 credits/image<br/>
    ///   - Supported resolutions: 640px, 1k<br/>
    ///   - Available for tiers: creator, pro, business<br/>
    ///   - Max additional input images: 9<br/>
    /// - `nano-banana-2` - from 100 credits/image<br/>
    ///   - Supported resolutions: 640px, 1k, 2k, 4k<br/>
    ///   - Available for tiers: creator, pro, business<br/>
    ///   - Max additional input images: 9<br/>
    /// - `nano-banana-2-lite` - from 50 credits/image<br/>
    ///   - Supported resolutions: 640px, 1k<br/>
    ///   - Available for tiers: creator, pro, business<br/>
    ///   - Max additional input images: 9<br/>
    /// - `seedream-v4` - from 40 credits/image<br/>
    ///   - Supported resolutions: 640px, 1k, 2k, 4k<br/>
    ///   - Available for tiers: creator, pro, business<br/>
    ///   - Max additional input images: 9<br/>
    /// - `nano-banana-pro` - from 150 credits/image<br/>
    ///   - Supported resolutions: 1k, 2k, 4k<br/>
    ///   - Available for tiers: creator, pro, business<br/>
    ///   - Max additional input images: 9<br/>
    /// - `seedream-v4.5` - from 50 credits/image<br/>
    ///   - Supported resolutions: 640px, 1k, 2k, 4k<br/>
    ///   - Available for tiers: creator, pro, business<br/>
    ///   - Max additional input images: 9<br/>
    /// - `gpt-image-2` - from 50 credits/image<br/>
    ///   - Supported resolutions: 640px, 1k, 2k, 4k<br/>
    ///   - Available for tiers: creator, pro, business<br/>
    ///   - Max additional input images: 9<br/>
    /// Example: default
    /// </summary>
    public enum AiImageEditorCreateImageRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        Default,
        /// <summary>
        /// 
        /// </summary>
        Flux2Klein,
        /// <summary>
        /// 
        /// </summary>
        GptImage2,
        /// <summary>
        /// 
        /// </summary>
        NanoBanana,
        /// <summary>
        /// 
        /// </summary>
        NanoBanana2,
        /// <summary>
        /// 
        /// </summary>
        NanoBanana2Lite,
        /// <summary>
        /// 
        /// </summary>
        NanoBananaPro,
        /// <summary>
        /// 
        /// </summary>
        QwenEdit,
        /// <summary>
        /// 
        /// </summary>
        SeedreamV4,
        /// <summary>
        /// 
        /// </summary>
        SeedreamV45,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AiImageEditorCreateImageRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiImageEditorCreateImageRequestModel value)
        {
            return value switch
            {
                AiImageEditorCreateImageRequestModel.Default => "default",
                AiImageEditorCreateImageRequestModel.Flux2Klein => "flux-2-klein",
                AiImageEditorCreateImageRequestModel.GptImage2 => "gpt-image-2",
                AiImageEditorCreateImageRequestModel.NanoBanana => "nano-banana",
                AiImageEditorCreateImageRequestModel.NanoBanana2 => "nano-banana-2",
                AiImageEditorCreateImageRequestModel.NanoBanana2Lite => "nano-banana-2-lite",
                AiImageEditorCreateImageRequestModel.NanoBananaPro => "nano-banana-pro",
                AiImageEditorCreateImageRequestModel.QwenEdit => "qwen-edit",
                AiImageEditorCreateImageRequestModel.SeedreamV4 => "seedream-v4",
                AiImageEditorCreateImageRequestModel.SeedreamV45 => "seedream-v4.5",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiImageEditorCreateImageRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "default" => AiImageEditorCreateImageRequestModel.Default,
                "flux-2-klein" => AiImageEditorCreateImageRequestModel.Flux2Klein,
                "gpt-image-2" => AiImageEditorCreateImageRequestModel.GptImage2,
                "nano-banana" => AiImageEditorCreateImageRequestModel.NanoBanana,
                "nano-banana-2" => AiImageEditorCreateImageRequestModel.NanoBanana2,
                "nano-banana-2-lite" => AiImageEditorCreateImageRequestModel.NanoBanana2Lite,
                "nano-banana-pro" => AiImageEditorCreateImageRequestModel.NanoBananaPro,
                "qwen-edit" => AiImageEditorCreateImageRequestModel.QwenEdit,
                "seedream-v4" => AiImageEditorCreateImageRequestModel.SeedreamV4,
                "seedream-v4.5" => AiImageEditorCreateImageRequestModel.SeedreamV45,
                _ => null,
            };
        }
    }
}