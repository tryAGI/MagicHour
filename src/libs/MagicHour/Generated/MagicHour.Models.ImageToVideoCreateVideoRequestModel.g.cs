
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// The AI model to use for video generation.<br/>
    /// * `default`: uses our currently recommended model for general use. For paid tiers, defaults to `kling-3.0`. For free tiers, it defaults to `ltx-2`.<br/>
    /// * `ltx-2`: Great for fast iteration with audio, lip-sync, and expressive faces<br/>
    /// * `wan-2.2`: Fast, medium-quality model with strong visuals and effect support.<br/>
    /// * `seedance`: Great for fast iteration and start/end frame<br/>
    /// * `kling-2.5`: Great for motion, action, and camera control<br/>
    /// * `kling-3.0`: Great for cinematic, multi-scene storytelling with control<br/>
    /// * `sora-2`: Great for story-telling, dialogue &amp; creativity<br/>
    /// * `veo3.1`: Great for realism, polish, &amp; prompt adherence<br/>
    /// Legacy models:<br/>
    /// * `kling-1.6`: Great for dependable clips with smooth motion<br/>
    /// If you specify the deprecated model value that includes the `-audio` suffix, this will be the same as included `audio` as `true`.<br/>
    /// Default Value: default<br/>
    /// Example: kling-3.0
    /// </summary>
    public enum ImageToVideoCreateVideoRequestModel
    {
        /// <summary>
        /// uses our currently recommended model for general use. For paid tiers, defaults to `kling-3.0`. For free tiers, it defaults to `ltx-2`.
        /// </summary>
        Default,
        /// <summary>
        /// Great for dependable clips with smooth motion
        /// </summary>
        Kling16,
        /// <summary>
        /// Great for motion, action, and camera control
        /// </summary>
        Kling25,
        /// <summary>
        /// 
        /// </summary>
        Kling25Audio,
        /// <summary>
        /// uses our currently recommended model for general use. For paid tiers, defaults to `kling-3.0`. For free tiers, it defaults to `ltx-2`.
        /// </summary>
        Kling30,
        /// <summary>
        /// uses our currently recommended model for general use. For paid tiers, defaults to `kling-3.0`. For free tiers, it defaults to `ltx-2`.
        /// </summary>
        Ltx2,
        /// <summary>
        /// Great for fast iteration and start/end frame
        /// </summary>
        Seedance,
        /// <summary>
        /// Great for story-telling, dialogue &amp; creativity
        /// </summary>
        Sora2,
        /// <summary>
        /// Great for realism, polish, &amp; prompt adherence
        /// </summary>
        Veo31,
        /// <summary>
        /// 
        /// </summary>
        Veo31Audio,
        /// <summary>
        /// Fast, medium-quality model with strong visuals and effect support.
        /// </summary>
        Wan22,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageToVideoCreateVideoRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageToVideoCreateVideoRequestModel value)
        {
            return value switch
            {
                ImageToVideoCreateVideoRequestModel.Default => "default",
                ImageToVideoCreateVideoRequestModel.Kling16 => "kling-1.6",
                ImageToVideoCreateVideoRequestModel.Kling25 => "kling-2.5",
                ImageToVideoCreateVideoRequestModel.Kling25Audio => "kling-2.5-audio",
                ImageToVideoCreateVideoRequestModel.Kling30 => "kling-3.0",
                ImageToVideoCreateVideoRequestModel.Ltx2 => "ltx-2",
                ImageToVideoCreateVideoRequestModel.Seedance => "seedance",
                ImageToVideoCreateVideoRequestModel.Sora2 => "sora-2",
                ImageToVideoCreateVideoRequestModel.Veo31 => "veo3.1",
                ImageToVideoCreateVideoRequestModel.Veo31Audio => "veo3.1-audio",
                ImageToVideoCreateVideoRequestModel.Wan22 => "wan-2.2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageToVideoCreateVideoRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "default" => ImageToVideoCreateVideoRequestModel.Default,
                "kling-1.6" => ImageToVideoCreateVideoRequestModel.Kling16,
                "kling-2.5" => ImageToVideoCreateVideoRequestModel.Kling25,
                "kling-2.5-audio" => ImageToVideoCreateVideoRequestModel.Kling25Audio,
                "kling-3.0" => ImageToVideoCreateVideoRequestModel.Kling30,
                "ltx-2" => ImageToVideoCreateVideoRequestModel.Ltx2,
                "seedance" => ImageToVideoCreateVideoRequestModel.Seedance,
                "sora-2" => ImageToVideoCreateVideoRequestModel.Sora2,
                "veo3.1" => ImageToVideoCreateVideoRequestModel.Veo31,
                "veo3.1-audio" => ImageToVideoCreateVideoRequestModel.Veo31Audio,
                "wan-2.2" => ImageToVideoCreateVideoRequestModel.Wan22,
                _ => null,
            };
        }
    }
}