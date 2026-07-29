
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageToVideoCreateVideoRequest
    {
        /// <summary>
        /// Give your video a custom name for easy identification.<br/>
        /// Default Value: Image To Video - dateTime<br/>
        /// Example: My Image To Video video
        /// </summary>
        /// <example>My Image To Video video</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The total duration of the output video in seconds. Supported durations depend on the chosen model:<br/>
        /// * **`ltx-2.3`**: 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 15, 20, 25, 30<br/>
        /// * **`wan-2.2`**: 3, 4, 5, 6, 7, 8, 9, 10, 15<br/>
        /// * **`kling-3.0`**: 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15<br/>
        /// * **`veo3.1-lite`**: 4, 6, 8, 16, 24, 32, 40, 48, 56<br/>
        /// * **`veo3.1`**: 4, 6, 8, 16, 24, 32, 40, 48, 56<br/>
        /// * **`seedance-1.5`**: 4, 5, 6, 7, 8, 9, 10, 11, 12<br/>
        /// * **`seedance-2.0-mini`**: 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15<br/>
        /// * **`seedance-2.0`**: 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15<br/>
        /// * **`sora-2`**: 4, 8, 12, 24, 36, 48, 60<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float EndSeconds { get; set; }

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
        /// <example>kling-3.0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.ImageToVideoCreateVideoRequestModelJsonConverter))]
        public global::MagicHour.ImageToVideoCreateVideoRequestModel? Model { get; set; }

        /// <summary>
        /// Controls the output video resolution. Defaults to `720p` on paid tiers and `480p` on free tiers.<br/>
        /// * **`ltx-2.3`**: Supports 480p, 720p, 1080p.<br/>
        /// * **`wan-2.2`**: Supports 480p, 720p, 1080p.<br/>
        /// * **`kling-3.0`**: Supports 720p, 1080p, 4k.<br/>
        /// * **`veo3.1-lite`**: Supports 720p, 1080p.<br/>
        /// * **`veo3.1`**: Supports 720p, 1080p.<br/>
        /// * **`seedance-1.5`**: Supports 480p, 720p, 1080p.<br/>
        /// * **`seedance-2.0-mini`**: Supports 480p, 720p.<br/>
        /// * **`seedance-2.0`**: Supports 480p, 720p.<br/>
        /// * **`sora-2`**: Supports 720p.<br/>
        /// Example: 720p
        /// </summary>
        /// <example>720p</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.ImageToVideoCreateVideoRequestResolutionJsonConverter))]
        public global::MagicHour.ImageToVideoCreateVideoRequestResolution? Resolution { get; set; }

        /// <summary>
        /// Whether to include audio in the video. Defaults to `false` if not specified.<br/>
        /// Audio support varies by model:<br/>
        /// * **`ltx-2.3`**: Toggle-able: no additional credits for audio<br/>
        /// * **`wan-2.2`**: Not supported<br/>
        /// * **`kling-3.0`**: Toggle-able: audio adds extra credits when enabled<br/>
        /// * **`veo3.1-lite`**: Toggle-able: audio adds extra credits when enabled<br/>
        /// * **`veo3.1`**: Toggle-able: audio adds extra credits when enabled<br/>
        /// * **`seedance-1.5`**: Toggle-able: audio adds extra credits when enabled<br/>
        /// * **`seedance-2.0-mini`**: Toggle-able: no additional credits for audio<br/>
        /// * **`seedance-2.0`**: Toggle-able: no additional credits for audio<br/>
        /// * **`sora-2`**: Toggle-able: no additional credits for audio<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public bool? Audio { get; set; }

        /// <summary>
        /// Attributed used to dictate the style of the output
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style")]
        public global::MagicHour.ImageToVideoCreateVideoRequestStyle? Style { get; set; }

        /// <summary>
        /// Provide the assets for image-to-video. Sora 2 only supports images with an aspect ratio of `9:16` or `16:9`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::MagicHour.ImageToVideoCreateVideoRequestAssets Assets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageToVideoCreateVideoRequest" /> class.
        /// </summary>
        /// <param name="endSeconds">
        /// The total duration of the output video in seconds. Supported durations depend on the chosen model:<br/>
        /// * **`ltx-2.3`**: 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 15, 20, 25, 30<br/>
        /// * **`wan-2.2`**: 3, 4, 5, 6, 7, 8, 9, 10, 15<br/>
        /// * **`kling-3.0`**: 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15<br/>
        /// * **`veo3.1-lite`**: 4, 6, 8, 16, 24, 32, 40, 48, 56<br/>
        /// * **`veo3.1`**: 4, 6, 8, 16, 24, 32, 40, 48, 56<br/>
        /// * **`seedance-1.5`**: 4, 5, 6, 7, 8, 9, 10, 11, 12<br/>
        /// * **`seedance-2.0-mini`**: 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15<br/>
        /// * **`seedance-2.0`**: 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15<br/>
        /// * **`sora-2`**: 4, 8, 12, 24, 36, 48, 60<br/>
        /// Example: 5
        /// </param>
        /// <param name="assets">
        /// Provide the assets for image-to-video. Sora 2 only supports images with an aspect ratio of `9:16` or `16:9`.
        /// </param>
        /// <param name="name">
        /// Give your video a custom name for easy identification.<br/>
        /// Default Value: Image To Video - dateTime<br/>
        /// Example: My Image To Video video
        /// </param>
        /// <param name="model">
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
        /// </param>
        /// <param name="resolution">
        /// Controls the output video resolution. Defaults to `720p` on paid tiers and `480p` on free tiers.<br/>
        /// * **`ltx-2.3`**: Supports 480p, 720p, 1080p.<br/>
        /// * **`wan-2.2`**: Supports 480p, 720p, 1080p.<br/>
        /// * **`kling-3.0`**: Supports 720p, 1080p, 4k.<br/>
        /// * **`veo3.1-lite`**: Supports 720p, 1080p.<br/>
        /// * **`veo3.1`**: Supports 720p, 1080p.<br/>
        /// * **`seedance-1.5`**: Supports 480p, 720p, 1080p.<br/>
        /// * **`seedance-2.0-mini`**: Supports 480p, 720p.<br/>
        /// * **`seedance-2.0`**: Supports 480p, 720p.<br/>
        /// * **`sora-2`**: Supports 720p.<br/>
        /// Example: 720p
        /// </param>
        /// <param name="audio">
        /// Whether to include audio in the video. Defaults to `false` if not specified.<br/>
        /// Audio support varies by model:<br/>
        /// * **`ltx-2.3`**: Toggle-able: no additional credits for audio<br/>
        /// * **`wan-2.2`**: Not supported<br/>
        /// * **`kling-3.0`**: Toggle-able: audio adds extra credits when enabled<br/>
        /// * **`veo3.1-lite`**: Toggle-able: audio adds extra credits when enabled<br/>
        /// * **`veo3.1`**: Toggle-able: audio adds extra credits when enabled<br/>
        /// * **`seedance-1.5`**: Toggle-able: audio adds extra credits when enabled<br/>
        /// * **`seedance-2.0-mini`**: Toggle-able: no additional credits for audio<br/>
        /// * **`seedance-2.0`**: Toggle-able: no additional credits for audio<br/>
        /// * **`sora-2`**: Toggle-able: no additional credits for audio<br/>
        /// Example: true
        /// </param>
        /// <param name="style">
        /// Attributed used to dictate the style of the output
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageToVideoCreateVideoRequest(
            float endSeconds,
            global::MagicHour.ImageToVideoCreateVideoRequestAssets assets,
            string? name,
            global::MagicHour.ImageToVideoCreateVideoRequestModel? model,
            global::MagicHour.ImageToVideoCreateVideoRequestResolution? resolution,
            bool? audio,
            global::MagicHour.ImageToVideoCreateVideoRequestStyle? style)
        {
            this.Name = name;
            this.EndSeconds = endSeconds;
            this.Model = model;
            this.Resolution = resolution;
            this.Audio = audio;
            this.Style = style;
            this.Assets = assets ?? throw new global::System.ArgumentNullException(nameof(assets));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageToVideoCreateVideoRequest" /> class.
        /// </summary>
        public ImageToVideoCreateVideoRequest()
        {
        }

    }
}