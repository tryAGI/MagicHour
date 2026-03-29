
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
        /// * **`ltx-2`**: 3, 4, 5, 6, 7, 8, 9, 10, 15, 20, 25, 30<br/>
        /// * **`seedance`**: 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12<br/>
        /// * **`kling-2.5`**: 5, 10<br/>
        /// * **`kling-3.0`**: 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15<br/>
        /// * **`sora-2`**: 4, 8, 12, 24, 36, 48, 60<br/>
        /// * **`veo3.1`**: 4, 6, 8, 16, 24, 32, 40, 48, 56<br/>
        /// Legacy models:<br/>
        /// * **`kling-1.6`**: 5, 10, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float EndSeconds { get; set; }

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
        /// <example>kling-2.5-audio</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.ImageToVideoCreateVideoRequestModelJsonConverter))]
        public global::MagicHour.ImageToVideoCreateVideoRequestModel? Model { get; set; }

        /// <summary>
        /// Controls the output video resolution. Defaults to `720p` on paid tiers and `480p` on free tiers.<br/>
        /// * **`ltx-2`**: Supports 480p, 720p, 1080p.<br/>
        /// * **`seedance`**: Supports 480p, 720p, 1080p.<br/>
        /// * **`kling-2.5`**: Supports 720p, 1080p.<br/>
        /// * **`kling-3.0`**: Supports 720p, 1080p.<br/>
        /// * **`sora-2`**: Supports 720p.<br/>
        /// * **`veo3.1`**: Supports 720p, 1080p.<br/>
        /// Legacy models:<br/>
        /// * **`kling-1.6`**: Supports 720p, 1080p.<br/>
        /// Example: 720p
        /// </summary>
        /// <example>720p</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.ImageToVideoCreateVideoRequestResolutionJsonConverter))]
        public global::MagicHour.ImageToVideoCreateVideoRequestResolution? Resolution { get; set; }

        /// <summary>
        /// Whether to include audio in the video. Defaults to `false` if not specified.<br/>
        /// Audio support varies by model:<br/>
        /// * **`ltx-2`**: Automatically included with no extra credits<br/>
        /// * **`seedance`**: Not supported<br/>
        /// * **`kling-2.5`**: Automatically included with no extra credits<br/>
        /// * **`kling-3.0`**: Toggle-able (can enable/disable)<br/>
        /// * **`sora-2`**: Automatically included with no extra credits<br/>
        /// * **`veo3.1`**: Toggle-able (can enable/disable)<br/>
        /// Legacy models:<br/>
        /// * **`kling-1.6`**: Not supported<br/>
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
        /// * **`ltx-2`**: 3, 4, 5, 6, 7, 8, 9, 10, 15, 20, 25, 30<br/>
        /// * **`seedance`**: 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12<br/>
        /// * **`kling-2.5`**: 5, 10<br/>
        /// * **`kling-3.0`**: 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15<br/>
        /// * **`sora-2`**: 4, 8, 12, 24, 36, 48, 60<br/>
        /// * **`veo3.1`**: 4, 6, 8, 16, 24, 32, 40, 48, 56<br/>
        /// Legacy models:<br/>
        /// * **`kling-1.6`**: 5, 10, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60<br/>
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
        /// </param>
        /// <param name="resolution">
        /// Controls the output video resolution. Defaults to `720p` on paid tiers and `480p` on free tiers.<br/>
        /// * **`ltx-2`**: Supports 480p, 720p, 1080p.<br/>
        /// * **`seedance`**: Supports 480p, 720p, 1080p.<br/>
        /// * **`kling-2.5`**: Supports 720p, 1080p.<br/>
        /// * **`kling-3.0`**: Supports 720p, 1080p.<br/>
        /// * **`sora-2`**: Supports 720p.<br/>
        /// * **`veo3.1`**: Supports 720p, 1080p.<br/>
        /// Legacy models:<br/>
        /// * **`kling-1.6`**: Supports 720p, 1080p.<br/>
        /// Example: 720p
        /// </param>
        /// <param name="audio">
        /// Whether to include audio in the video. Defaults to `false` if not specified.<br/>
        /// Audio support varies by model:<br/>
        /// * **`ltx-2`**: Automatically included with no extra credits<br/>
        /// * **`seedance`**: Not supported<br/>
        /// * **`kling-2.5`**: Automatically included with no extra credits<br/>
        /// * **`kling-3.0`**: Toggle-able (can enable/disable)<br/>
        /// * **`sora-2`**: Automatically included with no extra credits<br/>
        /// * **`veo3.1`**: Toggle-able (can enable/disable)<br/>
        /// Legacy models:<br/>
        /// * **`kling-1.6`**: Not supported<br/>
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