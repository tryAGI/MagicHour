
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnimationCreateVideoRequest
    {
        /// <summary>
        /// Give your video a custom name for easy identification.<br/>
        /// Default Value: Animation - dateTime<br/>
        /// Example: My Animation video
        /// </summary>
        /// <example>My Animation video</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The desire output video frame rate<br/>
        /// Example: 12
        /// </summary>
        /// <example>12</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("fps")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Fps { get; set; }

        /// <summary>
        /// This value determines the duration of the output video.<br/>
        /// Example: 15
        /// </summary>
        /// <example>15</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float EndSeconds { get; set; }

        /// <summary>
        /// The height of the final output video. The maximum height depends on your subscription. Please refer to our [pricing page](https://magichour.ai/pricing) for more details<br/>
        /// Example: 960
        /// </summary>
        /// <example>960</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Height { get; set; }

        /// <summary>
        /// The width of the final output video. The maximum width depends on your subscription. Please refer to our [pricing page](https://magichour.ai/pricing) for more details<br/>
        /// Example: 512
        /// </summary>
        /// <example>512</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Width { get; set; }

        /// <summary>
        /// Defines the style of the output video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::MagicHour.AnimationCreateVideoRequestStyle Style { get; set; }

        /// <summary>
        /// Provide the assets for animation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::MagicHour.AnimationCreateVideoRequestAssets Assets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnimationCreateVideoRequest" /> class.
        /// </summary>
        /// <param name="fps">
        /// The desire output video frame rate<br/>
        /// Example: 12
        /// </param>
        /// <param name="endSeconds">
        /// This value determines the duration of the output video.<br/>
        /// Example: 15
        /// </param>
        /// <param name="height">
        /// The height of the final output video. The maximum height depends on your subscription. Please refer to our [pricing page](https://magichour.ai/pricing) for more details<br/>
        /// Example: 960
        /// </param>
        /// <param name="width">
        /// The width of the final output video. The maximum width depends on your subscription. Please refer to our [pricing page](https://magichour.ai/pricing) for more details<br/>
        /// Example: 512
        /// </param>
        /// <param name="style">
        /// Defines the style of the output video
        /// </param>
        /// <param name="assets">
        /// Provide the assets for animation.
        /// </param>
        /// <param name="name">
        /// Give your video a custom name for easy identification.<br/>
        /// Default Value: Animation - dateTime<br/>
        /// Example: My Animation video
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnimationCreateVideoRequest(
            double fps,
            float endSeconds,
            int height,
            int width,
            global::MagicHour.AnimationCreateVideoRequestStyle style,
            global::MagicHour.AnimationCreateVideoRequestAssets assets,
            string? name)
        {
            this.Name = name;
            this.Fps = fps;
            this.EndSeconds = endSeconds;
            this.Height = height;
            this.Width = width;
            this.Style = style ?? throw new global::System.ArgumentNullException(nameof(style));
            this.Assets = assets ?? throw new global::System.ArgumentNullException(nameof(assets));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnimationCreateVideoRequest" /> class.
        /// </summary>
        public AnimationCreateVideoRequest()
        {
        }

    }
}