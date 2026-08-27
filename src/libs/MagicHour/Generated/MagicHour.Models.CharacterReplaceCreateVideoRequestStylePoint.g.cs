
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CharacterReplaceCreateVideoRequestStylePoint
    {
        /// <summary>
        /// Horizontal pixel coordinate in the source video frame at `time_seconds`, measured from the left edge.<br/>
        /// Example: 320
        /// </summary>
        /// <example>320</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("position_x")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PositionX { get; set; }

        /// <summary>
        /// Vertical pixel coordinate in the source video frame at `time_seconds`, measured from the top edge.<br/>
        /// Example: 180
        /// </summary>
        /// <example>180</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("position_y")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PositionY { get; set; }

        /// <summary>
        /// Timestamp on the source video timeline in seconds. Uses the same clock as `start_seconds` and `end_seconds`.<br/>
        /// Example: 2.5F
        /// </summary>
        /// <example>2.5F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float TimeSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterReplaceCreateVideoRequestStylePoint" /> class.
        /// </summary>
        /// <param name="positionX">
        /// Horizontal pixel coordinate in the source video frame at `time_seconds`, measured from the left edge.<br/>
        /// Example: 320
        /// </param>
        /// <param name="positionY">
        /// Vertical pixel coordinate in the source video frame at `time_seconds`, measured from the top edge.<br/>
        /// Example: 180
        /// </param>
        /// <param name="timeSeconds">
        /// Timestamp on the source video timeline in seconds. Uses the same clock as `start_seconds` and `end_seconds`.<br/>
        /// Example: 2.5F
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CharacterReplaceCreateVideoRequestStylePoint(
            int positionX,
            int positionY,
            float timeSeconds)
        {
            this.PositionX = positionX;
            this.PositionY = positionY;
            this.TimeSeconds = timeSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterReplaceCreateVideoRequestStylePoint" /> class.
        /// </summary>
        public CharacterReplaceCreateVideoRequestStylePoint()
        {
        }

    }
}