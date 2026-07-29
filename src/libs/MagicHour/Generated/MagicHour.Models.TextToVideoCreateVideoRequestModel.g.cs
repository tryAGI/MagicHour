
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
                TextToVideoCreateVideoRequestModel.Seedance15 => "seedance-1.5",
                TextToVideoCreateVideoRequestModel.Seedance20 => "seedance-2.0",
                TextToVideoCreateVideoRequestModel.Seedance20Mini => "seedance-2.0-mini",
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
                "seedance-1.5" => TextToVideoCreateVideoRequestModel.Seedance15,
                "seedance-2.0" => TextToVideoCreateVideoRequestModel.Seedance20,
                "seedance-2.0-mini" => TextToVideoCreateVideoRequestModel.Seedance20Mini,
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