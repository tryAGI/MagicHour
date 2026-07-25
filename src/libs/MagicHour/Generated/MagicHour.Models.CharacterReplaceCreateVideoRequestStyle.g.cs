
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Optional style controls for replace vs animate mode and subject selection.<br/>
    /// Example: {"mode":"replace","selection_mode":"auto"}
    /// </summary>
    public sealed partial class CharacterReplaceCreateVideoRequestStyle
    {
        /// <summary>
        /// Processing mode. `replace` swaps the detected subject with your reference character. `animate` transfers motion from the video onto your character image.<br/>
        /// Example: replace
        /// </summary>
        /// <example>replace</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.CharacterReplaceCreateVideoRequestStyleModeJsonConverter))]
        public global::MagicHour.CharacterReplaceCreateVideoRequestStyleMode? Mode { get; set; }

        /// <summary>
        /// How to locate the subject in the source video. `auto` detects a person automatically. `point` uses your `points` to mark the subject. Defaults to `auto`.<br/>
        /// Example: auto
        /// </summary>
        /// <example>auto</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("selection_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.CharacterReplaceCreateVideoRequestStyleSelectionModeJsonConverter))]
        public global::MagicHour.CharacterReplaceCreateVideoRequestStyleSelectionMode? SelectionMode { get; set; }

        /// <summary>
        /// On-frame markers for manual subject selection. Required when `selection_mode` is `point`. Ignored when `selection_mode` is `auto` or omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("points")]
        public global::System.Collections.Generic.IList<global::MagicHour.CharacterReplaceCreateVideoRequestStylePoint>? Points { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterReplaceCreateVideoRequestStyle" /> class.
        /// </summary>
        /// <param name="mode">
        /// Processing mode. `replace` swaps the detected subject with your reference character. `animate` transfers motion from the video onto your character image.<br/>
        /// Example: replace
        /// </param>
        /// <param name="selectionMode">
        /// How to locate the subject in the source video. `auto` detects a person automatically. `point` uses your `points` to mark the subject. Defaults to `auto`.<br/>
        /// Example: auto
        /// </param>
        /// <param name="points">
        /// On-frame markers for manual subject selection. Required when `selection_mode` is `point`. Ignored when `selection_mode` is `auto` or omitted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CharacterReplaceCreateVideoRequestStyle(
            global::MagicHour.CharacterReplaceCreateVideoRequestStyleMode? mode,
            global::MagicHour.CharacterReplaceCreateVideoRequestStyleSelectionMode? selectionMode,
            global::System.Collections.Generic.IList<global::MagicHour.CharacterReplaceCreateVideoRequestStylePoint>? points)
        {
            this.Mode = mode;
            this.SelectionMode = selectionMode;
            this.Points = points;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterReplaceCreateVideoRequestStyle" /> class.
        /// </summary>
        public CharacterReplaceCreateVideoRequestStyle()
        {
        }

    }
}