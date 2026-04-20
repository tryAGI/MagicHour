
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextToVideoCreateVideoRequest
    {
        /// <summary>
        /// Give your video a custom name for easy identification.<br/>
        /// Default Value: Text To Video - dateTime<br/>
        /// Example: My Text To Video video
        /// </summary>
        /// <example>My Text To Video video</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The total duration of the output video in seconds. Supported durations depend on the chosen model:<br/>
        /// * **`ltx-2`**: 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 15, 20, 25, 30<br/>
        /// * **`wan-2.2`**: 3, 4, 5, 6, 7, 8, 9, 10, 15<br/>
        /// * **`seedance`**: 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12<br/>
        /// * **`seedance-2.0`**: 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15<br/>
        /// * **`kling-2.5`**: 5, 10<br/>
        /// * **`kling-3.0`**: 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15<br/>
        /// * **`sora-2`**: 4, 8, 12, 24, 36, 48, 60<br/>
        /// * **`veo3.1`**: 4, 6, 8, 16, 24, 32, 40, 48, 56<br/>
        /// * **`veo3.1-lite`**: 8, 16, 24, 32, 40, 48, 56<br/>
        /// Legacy models:<br/>
        /// * **`kling-1.6`**: 5, 10, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float EndSeconds { get; set; }

        /// <summary>
        /// Determines the aspect ratio of the output video.<br/>
        /// * **`ltx-2`**: Supports 9:16, 16:9, 1:1.<br/>
        /// * **`wan-2.2`**: Supports 9:16, 16:9, 1:1.<br/>
        /// * **`seedance`**: Supports 9:16, 16:9, 1:1.<br/>
        /// * **`seedance-2.0`**: Supports 9:16, 16:9, 1:1.<br/>
        /// * **`kling-2.5`**: Supports 9:16, 16:9, 1:1.<br/>
        /// * **`kling-3.0`**: Supports 9:16, 16:9, 1:1.<br/>
        /// * **`sora-2`**: Supports 9:16, 16:9.<br/>
        /// * **`veo3.1`**: Supports 9:16, 16:9.<br/>
        /// * **`veo3.1-lite`**: Supports 9:16, 16:9.<br/>
        /// Legacy models:<br/>
        /// * **`kling-1.6`**: Supports 9:16, 16:9, 1:1.<br/>
        /// Example: 16:9
        /// </summary>
        /// <example>16:9</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.TextToVideoCreateVideoRequestAspectRatioJsonConverter))]
        public global::MagicHour.TextToVideoCreateVideoRequestAspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// Controls the output video resolution. Defaults to `720p` on paid tiers and `480p` on free tiers.<br/>
        /// * **`ltx-2`**: Supports 480p, 720p, 1080p.<br/>
        /// * **`wan-2.2`**: Supports 480p, 720p, 1080p.<br/>
        /// * **`seedance`**: Supports 480p, 720p, 1080p.<br/>
        /// * **`seedance-2.0`**: Supports 480p, 720p.<br/>
        /// * **`kling-2.5`**: Supports 720p, 1080p.<br/>
        /// * **`kling-3.0`**: Supports 720p, 1080p.<br/>
        /// * **`sora-2`**: Supports 720p.<br/>
        /// * **`veo3.1`**: Supports 720p, 1080p.<br/>
        /// * **`veo3.1-lite`**: Supports 720p, 1080p.<br/>
        /// Legacy models:<br/>
        /// * **`kling-1.6`**: Supports 720p, 1080p.<br/>
        /// Example: 720p
        /// </summary>
        /// <example>720p</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.TextToVideoCreateVideoRequestResolutionJsonConverter))]
        public global::MagicHour.TextToVideoCreateVideoRequestResolution? Resolution { get; set; }

        /// <summary>
        /// The AI model to use for video generation.<br/>
        /// * `default`: uses our currently recommended model for general use. For paid tiers, defaults to `kling-3.0`. For free tiers, it defaults to `ltx-2`.<br/>
        /// * `ltx-2`: Fast iteration with audio and lip-sync<br/>
        /// * `wan-2.2`: Fast, strong visuals with effects<br/>
        /// * `seedance`: Fast iteration and start/end frames<br/>
        /// * `seedance-2.0`: State-of-the-art quality and consistency<br/>
        /// * `kling-2.5`: Motion, action, and camera control<br/>
        /// * `kling-3.0`: Cinematic, multi-scene storytelling<br/>
        /// * `sora-2`: Story-first concepts and creativity<br/>
        /// * `veo3.1`: Realistic visuals and prompt adherence<br/>
        /// * `veo3.1-lite`: Good for fast, affordable, high-quality daily generation.<br/>
        /// Legacy models:<br/>
        /// * `kling-1.6`: Reliable baseline with smooth motion<br/>
        /// If you specify the deprecated model value that includes the `-audio` suffix, this will be the same as included `audio` as `true`.<br/>
        /// Default Value: default<br/>
        /// Example: kling-3.0
        /// </summary>
        /// <example>kling-3.0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.TextToVideoCreateVideoRequestModelJsonConverter))]
        public global::MagicHour.TextToVideoCreateVideoRequestModel? Model { get; set; }

        /// <summary>
        /// Whether to include audio in the video. Defaults to `false` if not specified.<br/>
        /// Audio support varies by model:<br/>
        /// * **`ltx-2`**: Toggle-able: no additional credits for audio<br/>
        /// * **`wan-2.2`**: Not supported<br/>
        /// * **`seedance`**: Not supported<br/>
        /// * **`seedance-2.0`**: Toggle-able: no additional credits for audio<br/>
        /// * **`kling-2.5`**: Toggle-able: no additional credits for audio<br/>
        /// * **`kling-3.0`**: Toggle-able: audio adds extra credits when enabled<br/>
        /// * **`sora-2`**: Toggle-able: no additional credits for audio<br/>
        /// * **`veo3.1`**: Toggle-able: audio adds extra credits when enabled<br/>
        /// * **`veo3.1-lite`**: Toggle-able: audio adds extra credits when enabled<br/>
        /// Legacy models:<br/>
        /// * **`kling-1.6`**: Not supported<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public bool? Audio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::MagicHour.TextToVideoCreateVideoRequestStyle Style { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToVideoCreateVideoRequest" /> class.
        /// </summary>
        /// <param name="endSeconds">
        /// The total duration of the output video in seconds. Supported durations depend on the chosen model:<br/>
        /// * **`ltx-2`**: 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 15, 20, 25, 30<br/>
        /// * **`wan-2.2`**: 3, 4, 5, 6, 7, 8, 9, 10, 15<br/>
        /// * **`seedance`**: 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12<br/>
        /// * **`seedance-2.0`**: 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15<br/>
        /// * **`kling-2.5`**: 5, 10<br/>
        /// * **`kling-3.0`**: 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15<br/>
        /// * **`sora-2`**: 4, 8, 12, 24, 36, 48, 60<br/>
        /// * **`veo3.1`**: 4, 6, 8, 16, 24, 32, 40, 48, 56<br/>
        /// * **`veo3.1-lite`**: 8, 16, 24, 32, 40, 48, 56<br/>
        /// Legacy models:<br/>
        /// * **`kling-1.6`**: 5, 10, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60<br/>
        /// Example: 5
        /// </param>
        /// <param name="style"></param>
        /// <param name="name">
        /// Give your video a custom name for easy identification.<br/>
        /// Default Value: Text To Video - dateTime<br/>
        /// Example: My Text To Video video
        /// </param>
        /// <param name="aspectRatio">
        /// Determines the aspect ratio of the output video.<br/>
        /// * **`ltx-2`**: Supports 9:16, 16:9, 1:1.<br/>
        /// * **`wan-2.2`**: Supports 9:16, 16:9, 1:1.<br/>
        /// * **`seedance`**: Supports 9:16, 16:9, 1:1.<br/>
        /// * **`seedance-2.0`**: Supports 9:16, 16:9, 1:1.<br/>
        /// * **`kling-2.5`**: Supports 9:16, 16:9, 1:1.<br/>
        /// * **`kling-3.0`**: Supports 9:16, 16:9, 1:1.<br/>
        /// * **`sora-2`**: Supports 9:16, 16:9.<br/>
        /// * **`veo3.1`**: Supports 9:16, 16:9.<br/>
        /// * **`veo3.1-lite`**: Supports 9:16, 16:9.<br/>
        /// Legacy models:<br/>
        /// * **`kling-1.6`**: Supports 9:16, 16:9, 1:1.<br/>
        /// Example: 16:9
        /// </param>
        /// <param name="resolution">
        /// Controls the output video resolution. Defaults to `720p` on paid tiers and `480p` on free tiers.<br/>
        /// * **`ltx-2`**: Supports 480p, 720p, 1080p.<br/>
        /// * **`wan-2.2`**: Supports 480p, 720p, 1080p.<br/>
        /// * **`seedance`**: Supports 480p, 720p, 1080p.<br/>
        /// * **`seedance-2.0`**: Supports 480p, 720p.<br/>
        /// * **`kling-2.5`**: Supports 720p, 1080p.<br/>
        /// * **`kling-3.0`**: Supports 720p, 1080p.<br/>
        /// * **`sora-2`**: Supports 720p.<br/>
        /// * **`veo3.1`**: Supports 720p, 1080p.<br/>
        /// * **`veo3.1-lite`**: Supports 720p, 1080p.<br/>
        /// Legacy models:<br/>
        /// * **`kling-1.6`**: Supports 720p, 1080p.<br/>
        /// Example: 720p
        /// </param>
        /// <param name="model">
        /// The AI model to use for video generation.<br/>
        /// * `default`: uses our currently recommended model for general use. For paid tiers, defaults to `kling-3.0`. For free tiers, it defaults to `ltx-2`.<br/>
        /// * `ltx-2`: Fast iteration with audio and lip-sync<br/>
        /// * `wan-2.2`: Fast, strong visuals with effects<br/>
        /// * `seedance`: Fast iteration and start/end frames<br/>
        /// * `seedance-2.0`: State-of-the-art quality and consistency<br/>
        /// * `kling-2.5`: Motion, action, and camera control<br/>
        /// * `kling-3.0`: Cinematic, multi-scene storytelling<br/>
        /// * `sora-2`: Story-first concepts and creativity<br/>
        /// * `veo3.1`: Realistic visuals and prompt adherence<br/>
        /// * `veo3.1-lite`: Good for fast, affordable, high-quality daily generation.<br/>
        /// Legacy models:<br/>
        /// * `kling-1.6`: Reliable baseline with smooth motion<br/>
        /// If you specify the deprecated model value that includes the `-audio` suffix, this will be the same as included `audio` as `true`.<br/>
        /// Default Value: default<br/>
        /// Example: kling-3.0
        /// </param>
        /// <param name="audio">
        /// Whether to include audio in the video. Defaults to `false` if not specified.<br/>
        /// Audio support varies by model:<br/>
        /// * **`ltx-2`**: Toggle-able: no additional credits for audio<br/>
        /// * **`wan-2.2`**: Not supported<br/>
        /// * **`seedance`**: Not supported<br/>
        /// * **`seedance-2.0`**: Toggle-able: no additional credits for audio<br/>
        /// * **`kling-2.5`**: Toggle-able: no additional credits for audio<br/>
        /// * **`kling-3.0`**: Toggle-able: audio adds extra credits when enabled<br/>
        /// * **`sora-2`**: Toggle-able: no additional credits for audio<br/>
        /// * **`veo3.1`**: Toggle-able: audio adds extra credits when enabled<br/>
        /// * **`veo3.1-lite`**: Toggle-able: audio adds extra credits when enabled<br/>
        /// Legacy models:<br/>
        /// * **`kling-1.6`**: Not supported<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextToVideoCreateVideoRequest(
            float endSeconds,
            global::MagicHour.TextToVideoCreateVideoRequestStyle style,
            string? name,
            global::MagicHour.TextToVideoCreateVideoRequestAspectRatio? aspectRatio,
            global::MagicHour.TextToVideoCreateVideoRequestResolution? resolution,
            global::MagicHour.TextToVideoCreateVideoRequestModel? model,
            bool? audio)
        {
            this.Name = name;
            this.EndSeconds = endSeconds;
            this.AspectRatio = aspectRatio;
            this.Resolution = resolution;
            this.Model = model;
            this.Audio = audio;
            this.Style = style ?? throw new global::System.ArgumentNullException(nameof(style));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToVideoCreateVideoRequest" /> class.
        /// </summary>
        public TextToVideoCreateVideoRequest()
        {
        }
    }
}