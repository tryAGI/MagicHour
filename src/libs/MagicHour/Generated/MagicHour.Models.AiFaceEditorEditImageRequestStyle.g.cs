
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Face editing parameters
    /// </summary>
    public sealed partial class AiFaceEditorEditImageRequestStyle
    {
        /// <summary>
        /// Enhance face features<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enhance_face")]
        public bool? EnhanceFace { get; set; }

        /// <summary>
        /// Eyebrow direction (-100 to 100), in increments of 5<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("eyebrow_direction")]
        public double? EyebrowDirection { get; set; }

        /// <summary>
        /// Horizontal eye gaze (-100 to 100), in increments of 5<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("eye_gaze_horizontal")]
        public double? EyeGazeHorizontal { get; set; }

        /// <summary>
        /// Vertical eye gaze (-100 to 100), in increments of 5<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("eye_gaze_vertical")]
        public double? EyeGazeVertical { get; set; }

        /// <summary>
        /// Eye open ratio (-100 to 100), in increments of 5<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("eye_open_ratio")]
        public double? EyeOpenRatio { get; set; }

        /// <summary>
        /// Lip open ratio (-100 to 100), in increments of 5<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("lip_open_ratio")]
        public double? LipOpenRatio { get; set; }

        /// <summary>
        /// Head roll (-100 to 100), in increments of 5<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("head_roll")]
        public double? HeadRoll { get; set; }

        /// <summary>
        /// Mouth grim (-100 to 100), in increments of 5<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("mouth_grim")]
        public double? MouthGrim { get; set; }

        /// <summary>
        /// Mouth pout (-100 to 100), in increments of 5<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("mouth_pout")]
        public double? MouthPout { get; set; }

        /// <summary>
        /// Mouth purse (-100 to 100), in increments of 5<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("mouth_purse")]
        public double? MouthPurse { get; set; }

        /// <summary>
        /// Mouth smile (-100 to 100), in increments of 5<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("mouth_smile")]
        public double? MouthSmile { get; set; }

        /// <summary>
        /// Horizontal mouth position (-100 to 100), in increments of 5<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("mouth_position_horizontal")]
        public double? MouthPositionHorizontal { get; set; }

        /// <summary>
        /// Vertical mouth position (-100 to 100), in increments of 5<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("mouth_position_vertical")]
        public double? MouthPositionVertical { get; set; }

        /// <summary>
        /// Head pitch (-100 to 100), in increments of 5<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("head_pitch")]
        public double? HeadPitch { get; set; }

        /// <summary>
        /// Head yaw (-100 to 100), in increments of 5<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("head_yaw")]
        public double? HeadYaw { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AiFaceEditorEditImageRequestStyle" /> class.
        /// </summary>
        /// <param name="enhanceFace">
        /// Enhance face features<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </param>
        /// <param name="eyebrowDirection">
        /// Eyebrow direction (-100 to 100), in increments of 5<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </param>
        /// <param name="eyeGazeHorizontal">
        /// Horizontal eye gaze (-100 to 100), in increments of 5<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </param>
        /// <param name="eyeGazeVertical">
        /// Vertical eye gaze (-100 to 100), in increments of 5<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </param>
        /// <param name="eyeOpenRatio">
        /// Eye open ratio (-100 to 100), in increments of 5<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </param>
        /// <param name="lipOpenRatio">
        /// Lip open ratio (-100 to 100), in increments of 5<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </param>
        /// <param name="headRoll">
        /// Head roll (-100 to 100), in increments of 5<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </param>
        /// <param name="mouthGrim">
        /// Mouth grim (-100 to 100), in increments of 5<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </param>
        /// <param name="mouthPout">
        /// Mouth pout (-100 to 100), in increments of 5<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </param>
        /// <param name="mouthPurse">
        /// Mouth purse (-100 to 100), in increments of 5<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </param>
        /// <param name="mouthSmile">
        /// Mouth smile (-100 to 100), in increments of 5<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </param>
        /// <param name="mouthPositionHorizontal">
        /// Horizontal mouth position (-100 to 100), in increments of 5<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </param>
        /// <param name="mouthPositionVertical">
        /// Vertical mouth position (-100 to 100), in increments of 5<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </param>
        /// <param name="headPitch">
        /// Head pitch (-100 to 100), in increments of 5<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </param>
        /// <param name="headYaw">
        /// Head yaw (-100 to 100), in increments of 5<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AiFaceEditorEditImageRequestStyle(
            bool? enhanceFace,
            double? eyebrowDirection,
            double? eyeGazeHorizontal,
            double? eyeGazeVertical,
            double? eyeOpenRatio,
            double? lipOpenRatio,
            double? headRoll,
            double? mouthGrim,
            double? mouthPout,
            double? mouthPurse,
            double? mouthSmile,
            double? mouthPositionHorizontal,
            double? mouthPositionVertical,
            double? headPitch,
            double? headYaw)
        {
            this.EnhanceFace = enhanceFace;
            this.EyebrowDirection = eyebrowDirection;
            this.EyeGazeHorizontal = eyeGazeHorizontal;
            this.EyeGazeVertical = eyeGazeVertical;
            this.EyeOpenRatio = eyeOpenRatio;
            this.LipOpenRatio = lipOpenRatio;
            this.HeadRoll = headRoll;
            this.MouthGrim = mouthGrim;
            this.MouthPout = mouthPout;
            this.MouthPurse = mouthPurse;
            this.MouthSmile = mouthSmile;
            this.MouthPositionHorizontal = mouthPositionHorizontal;
            this.MouthPositionVertical = mouthPositionVertical;
            this.HeadPitch = headPitch;
            this.HeadYaw = headYaw;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiFaceEditorEditImageRequestStyle" /> class.
        /// </summary>
        public AiFaceEditorEditImageRequestStyle()
        {
        }
    }
}