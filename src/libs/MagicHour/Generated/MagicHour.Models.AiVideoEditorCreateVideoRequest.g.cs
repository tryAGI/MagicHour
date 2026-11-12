
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Example: {"name":"My Video Editor video","start_seconds":0,"end_seconds":5,"model":"ltx-2.5","resolution":"480p","style":{"prompt":"Change the car color to blue"},"assets":{"video_file_path":"api-assets/id/1234.mp4"}}
    /// </summary>
    public sealed partial class AiVideoEditorCreateVideoRequest
    {
        /// <summary>
        /// Give your video a custom name for easy identification.<br/>
        /// Default Value: Video Editor - dateTime<br/>
        /// Example: My Video Editor video
        /// </summary>
        /// <example>My Video Editor video</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Start time of your clip (seconds). Must be ≥ 0.<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_seconds")]
        public float? StartSeconds { get; set; }

        /// <summary>
        /// End time of your clip in seconds. Must be greater than `start_seconds`. Allowed duration depends on model: `gemini-omni-1.2`: 3-15s, `wan-3.0`: 2-15s, `ltx-2.5`: 0.5-60s (30s at 1080p), `kling-4.0`: 3-30s.<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float EndSeconds { get; set; }

        /// <summary>
        /// The AI model to use for video editing. Defaults to `ltx-2.5` on free tiers and `gemini-omni-1.2` on paid tiers.<br/>
        /// * `gemini-omni-1.2`: Best for precise clips up to 15s, references, and high-resolution output. Requires a paid tier.<br/>
        /// * `wan-3.0`: High-quality video with native audio, long clips, and end-frame control. Requires a paid tier.<br/>
        /// * `ltx-2.5`: Fastest for general scenes, long clips, audio, and rapid iteration.<br/>
        /// * `kling-4.0`: Create cinematic videos with image and video references and optional audio. Requires a paid tier.<br/>
        /// Example: ltx-2.5
        /// </summary>
        /// <example>ltx-2.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.AiVideoEditorCreateVideoRequestModelJsonConverter))]
        public global::MagicHour.AiVideoEditorCreateVideoRequestModel? Model { get; set; }

        /// <summary>
        /// Output resolution. Defaults to `480p` for free tier and `720p` for paid. Supported per model: `gemini-omni-1.2`: 360p, 720p, 1080p, 4k; `wan-3.0`: 480p, 720p, 1080p; `ltx-2.5`: 480p, 720p, 1080p; `kling-4.0`: 720p, 1080p.<br/>
        /// Example: 480p
        /// </summary>
        /// <example>480p</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.AiVideoEditorCreateVideoRequestResolutionJsonConverter))]
        public global::MagicHour.AiVideoEditorCreateVideoRequestResolution? Resolution { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::MagicHour.AiVideoEditorCreateVideoRequestStyle Style { get; set; }

        /// <summary>
        /// Name references without @ and refer to them as @name in style.prompt. Names must be unique, ignoring case. Maximum 10 references total. Omit for no references.<br/>
        /// Reference images for gemini-omni-1.2, wan-3.0, kling-4.0.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("references")]
        public global::System.Collections.Generic.IList<global::MagicHour.AiVideoEditorCreateVideoRequestReference>? References { get; set; }

        /// <summary>
        /// Provide the assets for video editing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::MagicHour.AiVideoEditorCreateVideoRequestAssets Assets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AiVideoEditorCreateVideoRequest" /> class.
        /// </summary>
        /// <param name="endSeconds">
        /// End time of your clip in seconds. Must be greater than `start_seconds`. Allowed duration depends on model: `gemini-omni-1.2`: 3-15s, `wan-3.0`: 2-15s, `ltx-2.5`: 0.5-60s (30s at 1080p), `kling-4.0`: 3-30s.<br/>
        /// Example: 5
        /// </param>
        /// <param name="style"></param>
        /// <param name="assets">
        /// Provide the assets for video editing.
        /// </param>
        /// <param name="name">
        /// Give your video a custom name for easy identification.<br/>
        /// Default Value: Video Editor - dateTime<br/>
        /// Example: My Video Editor video
        /// </param>
        /// <param name="startSeconds">
        /// Start time of your clip (seconds). Must be ≥ 0.<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </param>
        /// <param name="model">
        /// The AI model to use for video editing. Defaults to `ltx-2.5` on free tiers and `gemini-omni-1.2` on paid tiers.<br/>
        /// * `gemini-omni-1.2`: Best for precise clips up to 15s, references, and high-resolution output. Requires a paid tier.<br/>
        /// * `wan-3.0`: High-quality video with native audio, long clips, and end-frame control. Requires a paid tier.<br/>
        /// * `ltx-2.5`: Fastest for general scenes, long clips, audio, and rapid iteration.<br/>
        /// * `kling-4.0`: Create cinematic videos with image and video references and optional audio. Requires a paid tier.<br/>
        /// Example: ltx-2.5
        /// </param>
        /// <param name="resolution">
        /// Output resolution. Defaults to `480p` for free tier and `720p` for paid. Supported per model: `gemini-omni-1.2`: 360p, 720p, 1080p, 4k; `wan-3.0`: 480p, 720p, 1080p; `ltx-2.5`: 480p, 720p, 1080p; `kling-4.0`: 720p, 1080p.<br/>
        /// Example: 480p
        /// </param>
        /// <param name="references">
        /// Name references without @ and refer to them as @name in style.prompt. Names must be unique, ignoring case. Maximum 10 references total. Omit for no references.<br/>
        /// Reference images for gemini-omni-1.2, wan-3.0, kling-4.0.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AiVideoEditorCreateVideoRequest(
            float endSeconds,
            global::MagicHour.AiVideoEditorCreateVideoRequestStyle style,
            global::MagicHour.AiVideoEditorCreateVideoRequestAssets assets,
            string? name,
            float? startSeconds,
            global::MagicHour.AiVideoEditorCreateVideoRequestModel? model,
            global::MagicHour.AiVideoEditorCreateVideoRequestResolution? resolution,
            global::System.Collections.Generic.IList<global::MagicHour.AiVideoEditorCreateVideoRequestReference>? references)
        {
            this.Name = name;
            this.StartSeconds = startSeconds;
            this.EndSeconds = endSeconds;
            this.Model = model;
            this.Resolution = resolution;
            this.Style = style ?? throw new global::System.ArgumentNullException(nameof(style));
            this.References = references;
            this.Assets = assets ?? throw new global::System.ArgumentNullException(nameof(assets));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiVideoEditorCreateVideoRequest" /> class.
        /// </summary>
        public AiVideoEditorCreateVideoRequest()
        {
        }

    }
}