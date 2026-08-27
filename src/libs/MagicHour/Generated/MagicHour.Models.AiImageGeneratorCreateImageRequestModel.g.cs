
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// The AI model to use for image generation. Each model has different capabilities and costs.<br/>
    /// **Models:**<br/>
    /// - `default` - Use the model we recommend, which will change over time. This is recommended unless you need a specific model. This is the default behavior.<br/>
    /// - `flux-2-klein` - from 5 credits/image<br/>
    ///   - Supported resolutions: 640px, 1k, 2k<br/>
    ///   - Available for tiers: free, creator, pro, business<br/>
    ///   - Image count allowed: 1<br/>
    /// - `flux-schnell` - from 5 credits/image<br/>
    ///   - Supported resolutions: 640px, 1k, 2k<br/>
    ///   - Available for tiers: free, creator, pro, business<br/>
    ///   - Image count allowed: 1, 2, 3, 4<br/>
    /// - `gpt-image-2` - from 50 credits/image<br/>
    ///   - Supported resolutions: 640px, 1k, 2k, 4k<br/>
    ///   - Available for tiers: creator, pro, business<br/>
    ///   - Image count allowed: 1, 2, 3, 4<br/>
    /// - `nano-banana` - from 50 credits/image<br/>
    ///   - Supported resolutions: 640px, 1k<br/>
    ///   - Available for tiers: creator, pro, business<br/>
    ///   - Image count allowed: 1, 2, 3, 4<br/>
    /// - `nano-banana-2` - from 100 credits/image<br/>
    ///   - Supported resolutions: 640px, 1k, 2k, 4k<br/>
    ///   - Available for tiers: creator, pro, business<br/>
    ///   - Image count allowed: 1, 4, 9, 16<br/>
    /// - `nano-banana-2-lite` - from 50 credits/image<br/>
    ///   - Supported resolutions: 640px, 1k<br/>
    ///   - Available for tiers: creator, pro, business<br/>
    ///   - Image count allowed: 1, 2, 3, 4<br/>
    /// - `nano-banana-pro` - from 150 credits/image<br/>
    ///   - Supported resolutions: 1k, 2k, 4k<br/>
    ///   - Available for tiers: creator, pro, business<br/>
    ///   - Image count allowed: 1, 4, 9, 16<br/>
    /// - `seedream-v4` - from 40 credits/image<br/>
    ///   - Supported resolutions: 640px, 1k, 2k, 4k<br/>
    ///   - Available for tiers: creator, pro, business<br/>
    ///   - Image count allowed: 1, 2, 3, 4<br/>
    /// - `seedream-v5-pro` - from 75 credits/image<br/>
    ///   - Supported resolutions: 640px, 1k, 2k<br/>
    ///   - Available for tiers: creator, pro, business<br/>
    ///   - Image count allowed: 1, 2, 3, 4<br/>
    /// - `z-image-turbo` - from 5 credits/image<br/>
    ///   - Supported resolutions: 640px, 1k, 2k<br/>
    ///   - Available for tiers: free, creator, pro, business<br/>
    ///   - Image count allowed: 1, 2, 3, 4<br/>
    /// **Deprecated Enum Values:**<br/>
    /// - `seedream` - Use `seedream-v4` instead.<br/>
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
        Flux2Klein,
        /// <summary>
        ///
        /// </summary>
        FluxSchnell,
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
        Seedream,
        /// <summary>
        ///
        /// </summary>
        SeedreamV4,
        /// <summary>
        ///
        /// </summary>
        SeedreamV5Pro,
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
                AiImageGeneratorCreateImageRequestModel.Flux2Klein => "flux-2-klein",
                AiImageGeneratorCreateImageRequestModel.FluxSchnell => "flux-schnell",
                AiImageGeneratorCreateImageRequestModel.GptImage2 => "gpt-image-2",
                AiImageGeneratorCreateImageRequestModel.NanoBanana => "nano-banana",
                AiImageGeneratorCreateImageRequestModel.NanoBanana2 => "nano-banana-2",
                AiImageGeneratorCreateImageRequestModel.NanoBanana2Lite => "nano-banana-2-lite",
                AiImageGeneratorCreateImageRequestModel.NanoBananaPro => "nano-banana-pro",
                AiImageGeneratorCreateImageRequestModel.Seedream => "seedream",
                AiImageGeneratorCreateImageRequestModel.SeedreamV4 => "seedream-v4",
                AiImageGeneratorCreateImageRequestModel.SeedreamV5Pro => "seedream-v5-pro",
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
                "flux-2-klein" => AiImageGeneratorCreateImageRequestModel.Flux2Klein,
                "flux-schnell" => AiImageGeneratorCreateImageRequestModel.FluxSchnell,
                "gpt-image-2" => AiImageGeneratorCreateImageRequestModel.GptImage2,
                "nano-banana" => AiImageGeneratorCreateImageRequestModel.NanoBanana,
                "nano-banana-2" => AiImageGeneratorCreateImageRequestModel.NanoBanana2,
                "nano-banana-2-lite" => AiImageGeneratorCreateImageRequestModel.NanoBanana2Lite,
                "nano-banana-pro" => AiImageGeneratorCreateImageRequestModel.NanoBananaPro,
                "seedream" => AiImageGeneratorCreateImageRequestModel.Seedream,
                "seedream-v4" => AiImageGeneratorCreateImageRequestModel.SeedreamV4,
                "seedream-v5-pro" => AiImageGeneratorCreateImageRequestModel.SeedreamV5Pro,
                "z-image-turbo" => AiImageGeneratorCreateImageRequestModel.ZImageTurbo,
                _ => null,
            };
        }
    }
}