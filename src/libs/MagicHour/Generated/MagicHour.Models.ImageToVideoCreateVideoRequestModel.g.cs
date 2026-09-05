
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// The AI model to use for video generation.<br/>
    /// * `default`: uses our currently recommended model for general use. For paid tiers, defaults to `kling-3.0`. For free tiers, it defaults to `ltx-2.5`.<br/>
    /// * `gemini-omni-1.1`: Best for precise short clips, first/last frames, and high-resolution output.<br/>
    /// * `kling-2.6`: Best for action, motion blur, and controlled camera moves.<br/>
    /// * `kling-3.0`: Best for cinematic stories, references, and optional audio.<br/>
    /// * `ltx-2.3`: Fastest for general scenes, long clips, audio, and rapid iteration.<br/>
    /// * `ltx-2.5`: Fastest for general scenes, long clips, audio, and rapid iteration.<br/>
    /// * `minimax-h3`: Great for reference-driven clips with native audio and longer durations.<br/>
    /// * `seedance-1.5`: Best for smooth, consistent motion with an end frame.<br/>
    /// * `seedance-2.0`: Best for reference-led clips with precise subject control.<br/>
    /// * `seedance-2.0-mini`: Faster reference-led clips with consistent motion and audio.<br/>
    /// * `seedance-2.5`: Best for premium realism, detail, and natural motion.<br/>
    /// * `sora-2`: Best for creative concepts and longer clips with audio.<br/>
    /// * `veo3.1`: Best for romantic interactions and expressive action, with realistic detail.<br/>
    /// * `veo3.1-lite`: Balanced realism and audio at a lower cost than Veo 3.1.<br/>
    /// * `wan-2.2`: Best for physical motion, action, and camera movement.<br/>
    /// If you specify the deprecated model value that includes the `-audio` suffix, this will be the same as included `audio` as `true`.<br/>
    /// Default Value: default<br/>
    /// Example: kling-3.0
    /// </summary>
    public enum ImageToVideoCreateVideoRequestModel
    {
        /// <summary>
        /// uses our currently recommended model for general use. For paid tiers, defaults to `kling-3.0`. For free tiers, it defaults to `ltx-2.5`.
        /// </summary>
        Default,
        /// <summary>
        /// Best for precise short clips, first/last frames, and high-resolution output.
        /// </summary>
        GeminiOmni11,
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
        /// Best for action, motion blur, and controlled camera moves.
        /// </summary>
        Kling26,
        /// <summary>
        /// uses our currently recommended model for general use. For paid tiers, defaults to `kling-3.0`. For free tiers, it defaults to `ltx-2.5`.
        /// </summary>
        Kling30,
        /// <summary>
        /// uses our currently recommended model for general use. For paid tiers, defaults to `kling-3.0`. For free tiers, it defaults to `ltx-2.5`.
        /// </summary>
        Ltx2,
        /// <summary>
        /// Fastest for general scenes, long clips, audio, and rapid iteration.
        /// </summary>
        Ltx23,
        /// <summary>
        /// uses our currently recommended model for general use. For paid tiers, defaults to `kling-3.0`. For free tiers, it defaults to `ltx-2.5`.
        /// </summary>
        Ltx25,
        /// <summary>
        /// Great for reference-driven clips with native audio and longer durations.
        /// </summary>
        MinimaxH3,
        /// <summary>
        /// Best for smooth, consistent motion with an end frame.
        /// </summary>
        Seedance,
        /// <summary>
        /// Best for smooth, consistent motion with an end frame.
        /// </summary>
        Seedance15,
        /// <summary>
        /// Best for reference-led clips with precise subject control.
        /// </summary>
        Seedance20,
        /// <summary>
        /// Faster reference-led clips with consistent motion and audio.
        /// </summary>
        Seedance20Mini,
        /// <summary>
        /// Best for premium realism, detail, and natural motion.
        /// </summary>
        Seedance25,
        /// <summary>
        /// Best for creative concepts and longer clips with audio.
        /// </summary>
        Sora2,
        /// <summary>
        /// Best for romantic interactions and expressive action, with realistic detail.
        /// </summary>
        Veo31,
        /// <summary>
        ///
        /// </summary>
        Veo31Audio,
        /// <summary>
        /// Balanced realism and audio at a lower cost than Veo 3.1.
        /// </summary>
        Veo31Lite,
        /// <summary>
        /// Best for physical motion, action, and camera movement.
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
                ImageToVideoCreateVideoRequestModel.GeminiOmni11 => "gemini-omni-1.1",
                ImageToVideoCreateVideoRequestModel.Kling16 => "kling-1.6",
                ImageToVideoCreateVideoRequestModel.Kling25 => "kling-2.5",
                ImageToVideoCreateVideoRequestModel.Kling25Audio => "kling-2.5-audio",
                ImageToVideoCreateVideoRequestModel.Kling26 => "kling-2.6",
                ImageToVideoCreateVideoRequestModel.Kling30 => "kling-3.0",
                ImageToVideoCreateVideoRequestModel.Ltx2 => "ltx-2",
                ImageToVideoCreateVideoRequestModel.Ltx23 => "ltx-2.3",
                ImageToVideoCreateVideoRequestModel.Ltx25 => "ltx-2.5",
                ImageToVideoCreateVideoRequestModel.MinimaxH3 => "minimax-h3",
                ImageToVideoCreateVideoRequestModel.Seedance => "seedance",
                ImageToVideoCreateVideoRequestModel.Seedance15 => "seedance-1.5",
                ImageToVideoCreateVideoRequestModel.Seedance20 => "seedance-2.0",
                ImageToVideoCreateVideoRequestModel.Seedance20Mini => "seedance-2.0-mini",
                ImageToVideoCreateVideoRequestModel.Seedance25 => "seedance-2.5",
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
                "gemini-omni-1.1" => ImageToVideoCreateVideoRequestModel.GeminiOmni11,
                "kling-1.6" => ImageToVideoCreateVideoRequestModel.Kling16,
                "kling-2.5" => ImageToVideoCreateVideoRequestModel.Kling25,
                "kling-2.5-audio" => ImageToVideoCreateVideoRequestModel.Kling25Audio,
                "kling-2.6" => ImageToVideoCreateVideoRequestModel.Kling26,
                "kling-3.0" => ImageToVideoCreateVideoRequestModel.Kling30,
                "ltx-2" => ImageToVideoCreateVideoRequestModel.Ltx2,
                "ltx-2.3" => ImageToVideoCreateVideoRequestModel.Ltx23,
                "ltx-2.5" => ImageToVideoCreateVideoRequestModel.Ltx25,
                "minimax-h3" => ImageToVideoCreateVideoRequestModel.MinimaxH3,
                "seedance" => ImageToVideoCreateVideoRequestModel.Seedance,
                "seedance-1.5" => ImageToVideoCreateVideoRequestModel.Seedance15,
                "seedance-2.0" => ImageToVideoCreateVideoRequestModel.Seedance20,
                "seedance-2.0-mini" => ImageToVideoCreateVideoRequestModel.Seedance20Mini,
                "seedance-2.5" => ImageToVideoCreateVideoRequestModel.Seedance25,
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