
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// The AI model to use for image generation. Each model has different capabilities and costs.<br/>
    /// **Models:**<br/>
    /// - `default` - Use the model we recommend, which will change over time. This is recommended unless you need a specific model. This is the default behavior.<br/>
    /// - `flux-schnell` - 5 credits/image<br/>
    ///   - Supported resolutions: auto<br/>
    ///   - Available for tiers: free, creator, pro, business<br/>
    ///   - Image count allowed: 1, 2, 3, 4<br/>
    /// - `z-image-turbo` - 5 credits/image<br/>
    ///   - Supported resolutions: auto, 2k<br/>
    ///   - Available for tiers: free, creator, pro, business<br/>
    ///   - Image count allowed: 1, 2, 3, 4<br/>
    /// - `seedream` - 30 credits/image<br/>
    ///   - Supported resolutions: auto, 2k, 4k<br/>
    ///   - Available for tiers: free, creator, pro, business<br/>
    ///   - Image count allowed: 1, 2, 3, 4<br/>
    /// - `nano-banana` - 50 credits/image<br/>
    ///   - Supported resolutions: auto<br/>
    ///   - Available for tiers: free, creator, pro, business<br/>
    ///   - Image count allowed: 1, 2, 3, 4<br/>
    /// - `nano-banana-2` - 100 credits/image<br/>
    ///   - Supported resolutions: auto, 2k, 4k<br/>
    ///   - Available for tiers: free, creator, pro, business<br/>
    ///   - Image count allowed: 1, 2, 3, 4<br/>
    /// - `nano-banana-pro` - 150 credits/image<br/>
    ///   - Supported resolutions: auto, 2k, 4k<br/>
    ///   - Available for tiers: creator, pro, business<br/>
    ///   - Image count allowed: 1, 4, 9, 16<br/>
    /// Example: default
    /// </summary>
    public enum AiImageGeneratorCreateImageRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        Default,
        /// <summary>
        /// 
        /// </summary>
        FluxSchnell,
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
        NanoBananaPro,
        /// <summary>
        /// 
        /// </summary>
        Seedream,
        /// <summary>
        /// 
        /// </summary>
        ZImageTurbo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AiImageGeneratorCreateImageRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiImageGeneratorCreateImageRequestModel value)
        {
            return value switch
            {
                AiImageGeneratorCreateImageRequestModel.Default => "default",
                AiImageGeneratorCreateImageRequestModel.FluxSchnell => "flux-schnell",
                AiImageGeneratorCreateImageRequestModel.NanoBanana => "nano-banana",
                AiImageGeneratorCreateImageRequestModel.NanoBanana2 => "nano-banana-2",
                AiImageGeneratorCreateImageRequestModel.NanoBananaPro => "nano-banana-pro",
                AiImageGeneratorCreateImageRequestModel.Seedream => "seedream",
                AiImageGeneratorCreateImageRequestModel.ZImageTurbo => "z-image-turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiImageGeneratorCreateImageRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "default" => AiImageGeneratorCreateImageRequestModel.Default,
                "flux-schnell" => AiImageGeneratorCreateImageRequestModel.FluxSchnell,
                "nano-banana" => AiImageGeneratorCreateImageRequestModel.NanoBanana,
                "nano-banana-2" => AiImageGeneratorCreateImageRequestModel.NanoBanana2,
                "nano-banana-pro" => AiImageGeneratorCreateImageRequestModel.NanoBananaPro,
                "seedream" => AiImageGeneratorCreateImageRequestModel.Seedream,
                "z-image-turbo" => AiImageGeneratorCreateImageRequestModel.ZImageTurbo,
                _ => null,
            };
        }
    }
}