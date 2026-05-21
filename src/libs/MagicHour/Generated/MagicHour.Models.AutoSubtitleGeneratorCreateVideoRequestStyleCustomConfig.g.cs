
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Custom subtitle configuration.
    /// </summary>
    public sealed partial class AutoSubtitleGeneratorCreateVideoRequestStyleCustomConfig
    {
        /// <summary>
        /// Font name from Google Fonts. Not all fonts support all languages or character sets. <br/>
        /// We recommend verifying language support and appearance directly on https://fonts.google.com before use.<br/>
        /// Example: Noto Sans
        /// </summary>
        /// <example>Noto Sans</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("font")]
        public string? Font { get; set; }

        /// <summary>
        /// Font size in pixels. If not provided, the font size is automatically calculated based on the video resolution.<br/>
        /// Example: 24
        /// </summary>
        /// <example>24</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("font_size")]
        public double? FontSize { get; set; }

        /// <summary>
        /// Font style (e.g., normal, italic, bold)<br/>
        /// Example: normal
        /// </summary>
        /// <example>normal</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("font_style")]
        public string? FontStyle { get; set; }

        /// <summary>
        /// Primary text color in hex format<br/>
        /// Example: #FFFFFF
        /// </summary>
        /// <example>#FFFFFF</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_color")]
        public string? TextColor { get; set; }

        /// <summary>
        /// Color used to highlight the current spoken text<br/>
        /// Example: #FFD700
        /// </summary>
        /// <example>#FFD700</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("highlighted_text_color")]
        public string? HighlightedTextColor { get; set; }

        /// <summary>
        /// Stroke (outline) color of the text<br/>
        /// Example: #000000
        /// </summary>
        /// <example>#000000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("stroke_color")]
        public string? StrokeColor { get; set; }

        /// <summary>
        /// Width of the text stroke in pixels. If `stroke_color` is provided, but `stroke_width` is not, the `stroke_width` will be calculated automatically based on the font size.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("stroke_width")]
        public double? StrokeWidth { get; set; }

        /// <summary>
        /// Vertical alignment of the text (e.g., top, center, bottom)<br/>
        /// Example: bottom
        /// </summary>
        /// <example>bottom</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("vertical_position")]
        public string? VerticalPosition { get; set; }

        /// <summary>
        /// Horizontal alignment of the text (e.g., left, center, right)<br/>
        /// Example: center
        /// </summary>
        /// <example>center</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("horizontal_position")]
        public string? HorizontalPosition { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSubtitleGeneratorCreateVideoRequestStyleCustomConfig" /> class.
        /// </summary>
        /// <param name="font">
        /// Font name from Google Fonts. Not all fonts support all languages or character sets. <br/>
        /// We recommend verifying language support and appearance directly on https://fonts.google.com before use.<br/>
        /// Example: Noto Sans
        /// </param>
        /// <param name="fontSize">
        /// Font size in pixels. If not provided, the font size is automatically calculated based on the video resolution.<br/>
        /// Example: 24
        /// </param>
        /// <param name="fontStyle">
        /// Font style (e.g., normal, italic, bold)<br/>
        /// Example: normal
        /// </param>
        /// <param name="textColor">
        /// Primary text color in hex format<br/>
        /// Example: #FFFFFF
        /// </param>
        /// <param name="highlightedTextColor">
        /// Color used to highlight the current spoken text<br/>
        /// Example: #FFD700
        /// </param>
        /// <param name="strokeColor">
        /// Stroke (outline) color of the text<br/>
        /// Example: #000000
        /// </param>
        /// <param name="strokeWidth">
        /// Width of the text stroke in pixels. If `stroke_color` is provided, but `stroke_width` is not, the `stroke_width` will be calculated automatically based on the font size.<br/>
        /// Example: 1
        /// </param>
        /// <param name="verticalPosition">
        /// Vertical alignment of the text (e.g., top, center, bottom)<br/>
        /// Example: bottom
        /// </param>
        /// <param name="horizontalPosition">
        /// Horizontal alignment of the text (e.g., left, center, right)<br/>
        /// Example: center
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSubtitleGeneratorCreateVideoRequestStyleCustomConfig(
            string? font,
            double? fontSize,
            string? fontStyle,
            string? textColor,
            string? highlightedTextColor,
            string? strokeColor,
            double? strokeWidth,
            string? verticalPosition,
            string? horizontalPosition)
        {
            this.Font = font;
            this.FontSize = fontSize;
            this.FontStyle = fontStyle;
            this.TextColor = textColor;
            this.HighlightedTextColor = highlightedTextColor;
            this.StrokeColor = strokeColor;
            this.StrokeWidth = strokeWidth;
            this.VerticalPosition = verticalPosition;
            this.HorizontalPosition = horizontalPosition;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSubtitleGeneratorCreateVideoRequestStyleCustomConfig" /> class.
        /// </summary>
        public AutoSubtitleGeneratorCreateVideoRequestStyleCustomConfig()
        {
        }

    }
}