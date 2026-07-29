
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// The AI model to use for video generation.<br/>
    /// * `default`: uses our currently recommended model for general use. For paid tiers, defaults to `kling-3.0`. For free tiers, it defaults to `ltx-2.3`.<br/>
    /// * `ltx-2.3`: Fastest output. Best for rapid iteration.<br/>
    /// * `wan-2.2`: Strong physics, camera moves, and motion.<br/>
    /// * `kling-3.0`: Best overall quality for cinematic storytelling.<br/>
    /// * `veo3.1-lite`: Veo quality at a more accessible cost.<br/>
    /// * `veo3.1`: Google's model. Highest realism and detail.<br/>
    /// * `seedance-1.5`: Smooth, consistent motion with precision.<br/>
    /// * `seedance-2.0-mini`: Fast, consistent video with strong motion quality<br/>
    /// * `seedance-2.0`: Top quality with reference-to-video control.<br/>
    /// * `sora-2`: Open AI's model. Great for creativity and viral clips.<br/>
    /// If you specify the deprecated model value that includes the `-audio` suffix, this will be the same as included `audio` as `true`.<br/>
    /// Default Value: default<br/>
    /// Example: kling-3.0
    /// </summary>
    public enum ImageToVideoCreateVideoRequestModel
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
        /// 
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
        /// Smooth, consistent motion with precision.
        /// </summary>
        Seedance,
        /// <summary>
        /// Smooth, consistent motion with precision.
        /// </summary>
        Seedance15,
        /// <summary>
        /// Fast, consistent video with strong motion quality
        /// </summary>
        Seedance20,
        /// <summary>
        /// Fast, consistent video with strong motion quality
        /// </summary>
        Seedance20Mini,
        /// <summary>
        /// Open AI's model. Great for creativity and viral clips.
        /// </summary>
        Sora2,
        /// <summary>
        /// Veo quality at a more accessible cost.
        /// </summary>
        Veo31,
        /// <summary>
        /// 
        /// </summary>
        Veo31Audio,
        /// <summary>
        /// Veo quality at a more accessible cost.
        /// </summary>
        Veo31Lite,
        /// <summary>
        /// Strong physics, camera moves, and motion.
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
                ImageToVideoCreateVideoRequestModel.Ltx23 => "ltx-2.3",
                ImageToVideoCreateVideoRequestModel.Seedance => "seedance",
                ImageToVideoCreateVideoRequestModel.Seedance15 => "seedance-1.5",
                ImageToVideoCreateVideoRequestModel.Seedance20 => "seedance-2.0",
                ImageToVideoCreateVideoRequestModel.Seedance20Mini => "seedance-2.0-mini",
                ImageToVideoCreateVideoRequestModel.Sora2 => "sora-2",
                ImageToVideoCreateVideoRequestModel.Veo31 => "veo3.1",
                ImageToVideoCreateVideoRequestModel.Veo31Audio => "veo3.1-audio",
                ImageToVideoCreateVideoRequestModel.Veo31Lite => "veo3.1-lite",
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
                "ltx-2.3" => ImageToVideoCreateVideoRequestModel.Ltx23,
                "seedance" => ImageToVideoCreateVideoRequestModel.Seedance,
                "seedance-1.5" => ImageToVideoCreateVideoRequestModel.Seedance15,
                "seedance-2.0" => ImageToVideoCreateVideoRequestModel.Seedance20,
                "seedance-2.0-mini" => ImageToVideoCreateVideoRequestModel.Seedance20Mini,
                "sora-2" => ImageToVideoCreateVideoRequestModel.Sora2,
                "veo3.1" => ImageToVideoCreateVideoRequestModel.Veo31,
                "veo3.1-audio" => ImageToVideoCreateVideoRequestModel.Veo31Audio,
                "veo3.1-lite" => ImageToVideoCreateVideoRequestModel.Veo31Lite,
                "wan-2.2" => ImageToVideoCreateVideoRequestModel.Wan22,
                _ => null,
            };
        }
    }
}