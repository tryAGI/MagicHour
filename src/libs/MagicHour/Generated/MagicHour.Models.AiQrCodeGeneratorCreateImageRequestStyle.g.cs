
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AiQrCodeGeneratorCreateImageRequestStyle
    {
        /// <summary>
        /// To use our templates, pass in one of Watercolor, Cyberpunk City, Ink Landscape, Interior Painting, Japanese Street, Mech, Minecraft, Picasso Painting, Game Map, Spaceship, Chinese Painting, Winter Village, or pass any custom art style.<br/>
        /// Example: Watercolor
        /// </summary>
        /// <example>Watercolor</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("art_style")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ArtStyle { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AiQrCodeGeneratorCreateImageRequestStyle" /> class.
        /// </summary>
        /// <param name="artStyle">
        /// To use our templates, pass in one of Watercolor, Cyberpunk City, Ink Landscape, Interior Painting, Japanese Street, Mech, Minecraft, Picasso Painting, Game Map, Spaceship, Chinese Painting, Winter Village, or pass any custom art style.<br/>
        /// Example: Watercolor
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AiQrCodeGeneratorCreateImageRequestStyle(
            string artStyle)
        {
            this.ArtStyle = artStyle ?? throw new global::System.ArgumentNullException(nameof(artStyle));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiQrCodeGeneratorCreateImageRequestStyle" /> class.
        /// </summary>
        public AiQrCodeGeneratorCreateImageRequestStyle()
        {
        }
    }
}