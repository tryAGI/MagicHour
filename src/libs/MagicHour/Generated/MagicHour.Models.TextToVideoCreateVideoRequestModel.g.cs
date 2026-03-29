
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// The AI model to use for video generation.<br/>
    /// * `default`: uses our currently recommended model for general use. For paid tiers, defaults to `kling-2.5`. For free tiers, it defaults to `ltx-2`.<br/>
    /// * `ltx-2`: Great for fast iteration with audio, lip-sync, and expressive faces<br/>
    /// * `seedance`: Great for fast iteration and start/end frame<br/>
    /// * `kling-2.5`: Great for motion, action, and camera control<br/>
    /// * `kling-3.0`: Great for cinematic, multi-scene storytelling with control<br/>
    /// * `sora-2`: Great for story-telling, dialogue &amp; creativity<br/>
    /// * `veo3.1`: Great for realism, polish, &amp; prompt adherence<br/>
    /// Legacy models:<br/>
    /// * `kling-1.6`: Great for dependable clips with smooth motion<br/>
    /// If you specify the deprecated model value that includes the `-audio` suffix, this will be the same as included `audio` as `true`.<br/>
    /// Default Value: default<br/>
    /// Example: kling-2.5-audio
    /// </summary>
    public enum TextToVideoCreateVideoRequestModel
    {
        /// <summary>
        /// uses our currently recommended model for general use. For paid tiers, defaults to `kling-2.5`. For free tiers, it defaults to `ltx-2`.
        /// </summary>
        Default,
        /// <summary>
        /// Great for dependable clips with smooth motion
        /// </summary>
        Kling16,
        /// <summary>
        /// uses our currently recommended model for general use. For paid tiers, defaults to `kling-2.5`. For free tiers, it defaults to `ltx-2`.
        /// </summary>
        Kling25,
        /// <summary>
        /// 
        /// </summary>
        Kling25Audio,
        /// <summary>
        /// Great for cinematic, multi-scene storytelling with control
        /// </summary>
        Kling30,
        /// <summary>
        /// uses our currently recommended model for general use. For paid tiers, defaults to `kling-2.5`. For free tiers, it defaults to `ltx-2`.
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
                TextToVideoCreateVideoRequestModel.Seedance => "seedance",
                TextToVideoCreateVideoRequestModel.Sora2 => "sora-2",
                TextToVideoCreateVideoRequestModel.Veo31 => "veo3.1",
                TextToVideoCreateVideoRequestModel.Veo31Audio => "veo3.1-audio",
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
                "seedance" => TextToVideoCreateVideoRequestModel.Seedance,
                "sora-2" => TextToVideoCreateVideoRequestModel.Sora2,
                "veo3.1" => TextToVideoCreateVideoRequestModel.Veo31,
                "veo3.1-audio" => TextToVideoCreateVideoRequestModel.Veo31Audio,
                _ => null,
            };
        }
    }
}