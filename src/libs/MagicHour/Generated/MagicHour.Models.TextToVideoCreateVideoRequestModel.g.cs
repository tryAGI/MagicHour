
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// The AI model to use for video generation.<br/>
    /// * `default`: uses our currently recommended model for general use. For paid tiers, defaults to `kling-3.0`. For free tiers, it defaults to `ltx-2.3`.<br/>
    /// * `ltx-2.3`: Fast iteration with lip-sync &amp; end frame<br/>
    /// * `wan-2.2`: Fast, strong visuals with effects<br/>
    /// * `kling-2.5`: Motion, action, and camera control<br/>
    /// * `kling-3.0`: Cinematic, multi-scene storytelling<br/>
    /// * `veo3.1-lite`: Fast, affordable, high-quality<br/>
    /// * `veo3.1`: Realistic visuals and prompt adherence<br/>
    /// * `seedance`: Fast iteration<br/>
    /// * `seedance-2.0`: State-of-the-art quality and consistency<br/>
    /// * `sora-2`: Story-first concepts and creativity<br/>
    /// If you specify the deprecated model value that includes the `-audio` suffix, this will be the same as included `audio` as `true`.<br/>
    /// Default Value: default<br/>
    /// Example: kling-3.0
    /// </summary>
    public enum TextToVideoCreateVideoRequestModel
    {
        /// <summary>
        /// uses our currently recommended model for general use. For paid tiers, defaults to `kling-3.0`. For free tiers, it defaults to `ltx-2.3`.
        /// </summary>
        Default,
        /// <summary>
        /// 
        /// </summary>
        Kling16,
        /// <summary>
        /// Motion, action, and camera control
        /// </summary>
        Kling25,
        /// <summary>
        /// 
        /// </summary>
        Kling25Audio,
        /// <summary>
        /// uses our currently recommended model for general use. For paid tiers, defaults to `kling-3.0`. For free tiers, it defaults to `ltx-2.3`.
        /// </summary>
        Kling30,
        /// <summary>
        /// uses our currently recommended model for general use. For paid tiers, defaults to `kling-3.0`. For free tiers, it defaults to `ltx-2.3`.
        /// </summary>
        Ltx2,
        /// <summary>
        /// uses our currently recommended model for general use. For paid tiers, defaults to `kling-3.0`. For free tiers, it defaults to `ltx-2.3`.
        /// </summary>
        Ltx23,
        /// <summary>
        /// Fast iteration
        /// </summary>
        Seedance,
        /// <summary>
        /// State-of-the-art quality and consistency
        /// </summary>
        Seedance20,
        /// <summary>
        /// Story-first concepts and creativity
        /// </summary>
        Sora2,
        /// <summary>
        /// Fast, affordable, high-quality
        /// </summary>
        Veo31,
        /// <summary>
        /// 
        /// </summary>
        Veo31Audio,
        /// <summary>
        /// Fast, affordable, high-quality
        /// </summary>
        Veo31Lite,
        /// <summary>
        /// Fast, strong visuals with effects
        /// </summary>
        Wan22,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextToVideoCreateVideoRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextToVideoCreateVideoRequestModel value)
        {
            return value switch
            {
                TextToVideoCreateVideoRequestModel.Default => "default",
                TextToVideoCreateVideoRequestModel.Kling16 => "kling-1.6",
                TextToVideoCreateVideoRequestModel.Kling25 => "kling-2.5",
                TextToVideoCreateVideoRequestModel.Kling25Audio => "kling-2.5-audio",
                TextToVideoCreateVideoRequestModel.Kling30 => "kling-3.0",
                TextToVideoCreateVideoRequestModel.Ltx2 => "ltx-2",
                TextToVideoCreateVideoRequestModel.Ltx23 => "ltx-2.3",
                TextToVideoCreateVideoRequestModel.Seedance => "seedance",
                TextToVideoCreateVideoRequestModel.Seedance20 => "seedance-2.0",
                TextToVideoCreateVideoRequestModel.Sora2 => "sora-2",
                TextToVideoCreateVideoRequestModel.Veo31 => "veo3.1",
                TextToVideoCreateVideoRequestModel.Veo31Audio => "veo3.1-audio",
                TextToVideoCreateVideoRequestModel.Veo31Lite => "veo3.1-lite",
                TextToVideoCreateVideoRequestModel.Wan22 => "wan-2.2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextToVideoCreateVideoRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "default" => TextToVideoCreateVideoRequestModel.Default,
                "kling-1.6" => TextToVideoCreateVideoRequestModel.Kling16,
                "kling-2.5" => TextToVideoCreateVideoRequestModel.Kling25,
                "kling-2.5-audio" => TextToVideoCreateVideoRequestModel.Kling25Audio,
                "kling-3.0" => TextToVideoCreateVideoRequestModel.Kling30,
                "ltx-2" => TextToVideoCreateVideoRequestModel.Ltx2,
                "ltx-2.3" => TextToVideoCreateVideoRequestModel.Ltx23,
                "seedance" => TextToVideoCreateVideoRequestModel.Seedance,
                "seedance-2.0" => TextToVideoCreateVideoRequestModel.Seedance20,
                "sora-2" => TextToVideoCreateVideoRequestModel.Sora2,
                "veo3.1" => TextToVideoCreateVideoRequestModel.Veo31,
                "veo3.1-audio" => TextToVideoCreateVideoRequestModel.Veo31Audio,
                "veo3.1-lite" => TextToVideoCreateVideoRequestModel.Veo31Lite,
                "wan-2.2" => TextToVideoCreateVideoRequestModel.Wan22,
                _ => null,
            };
        }
    }
}