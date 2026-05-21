
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Defines the style of the output video
    /// </summary>
    public sealed partial class AnimationCreateVideoRequestStyle
    {
        /// <summary>
        /// The art style used to create the output video<br/>
        /// Example: Painterly Illustration
        /// </summary>
        /// <example>Painterly Illustration</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("art_style")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.AnimationCreateVideoRequestStyleArtStyleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::MagicHour.AnimationCreateVideoRequestStyleArtStyle ArtStyle { get; set; }

        /// <summary>
        /// Describe custom art style. This field is required if `art_style` is `Custom`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("art_style_custom")]
        public string? ArtStyleCustom { get; set; }

        /// <summary>
        /// The camera effect used to create the output video<br/>
        /// Example: Simple Zoom In
        /// </summary>
        /// <example>Simple Zoom In</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("camera_effect")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.AnimationCreateVideoRequestStyleCameraEffectJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::MagicHour.AnimationCreateVideoRequestStyleCameraEffect CameraEffect { get; set; }

        /// <summary>
        /// * `custom` - Use your own prompt for the video.<br/>
        /// * `use_lyrics` - Use the lyrics of the audio to create the prompt. If this option is selected, then `assets.audio_source` must be `file` or `youtube`.<br/>
        /// * `ai_choose` - Let AI write the prompt. If this option is selected, then `assets.audio_source` must be `file` or `youtube`.<br/>
        /// Example: custom
        /// </summary>
        /// <example>custom</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.AnimationCreateVideoRequestStylePromptTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::MagicHour.AnimationCreateVideoRequestStylePromptType PromptType { get; set; }

        /// <summary>
        /// The prompt used for the video. Prompt is required if `prompt_type` is `custom`. Otherwise this value is ignored<br/>
        /// Example: Cyberpunk city
        /// </summary>
        /// <example>Cyberpunk city</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Change determines how quickly the video's content changes across frames. <br/>
        /// * Higher = more rapid transitions.<br/>
        /// * Lower = more stable visual experience.<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("transition_speed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TransitionSpeed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnimationCreateVideoRequestStyle" /> class.
        /// </summary>
        /// <param name="artStyle">
        /// The art style used to create the output video<br/>
        /// Example: Painterly Illustration
        /// </param>
        /// <param name="cameraEffect">
        /// The camera effect used to create the output video<br/>
        /// Example: Simple Zoom In
        /// </param>
        /// <param name="promptType">
        /// * `custom` - Use your own prompt for the video.<br/>
        /// * `use_lyrics` - Use the lyrics of the audio to create the prompt. If this option is selected, then `assets.audio_source` must be `file` or `youtube`.<br/>
        /// * `ai_choose` - Let AI write the prompt. If this option is selected, then `assets.audio_source` must be `file` or `youtube`.<br/>
        /// Example: custom
        /// </param>
        /// <param name="transitionSpeed">
        /// Change determines how quickly the video's content changes across frames. <br/>
        /// * Higher = more rapid transitions.<br/>
        /// * Lower = more stable visual experience.<br/>
        /// Example: 5
        /// </param>
        /// <param name="artStyleCustom">
        /// Describe custom art style. This field is required if `art_style` is `Custom`
        /// </param>
        /// <param name="prompt">
        /// The prompt used for the video. Prompt is required if `prompt_type` is `custom`. Otherwise this value is ignored<br/>
        /// Example: Cyberpunk city
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnimationCreateVideoRequestStyle(
            global::MagicHour.AnimationCreateVideoRequestStyleArtStyle artStyle,
            global::MagicHour.AnimationCreateVideoRequestStyleCameraEffect cameraEffect,
            global::MagicHour.AnimationCreateVideoRequestStylePromptType promptType,
            int transitionSpeed,
            string? artStyleCustom,
            string? prompt)
        {
            this.ArtStyle = artStyle;
            this.ArtStyleCustom = artStyleCustom;
            this.CameraEffect = cameraEffect;
            this.PromptType = promptType;
            this.Prompt = prompt;
            this.TransitionSpeed = transitionSpeed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnimationCreateVideoRequestStyle" /> class.
        /// </summary>
        public AnimationCreateVideoRequestStyle()
        {
        }

    }
}