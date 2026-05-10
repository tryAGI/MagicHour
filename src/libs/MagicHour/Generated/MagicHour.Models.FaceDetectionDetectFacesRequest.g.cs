
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FaceDetectionDetectFacesRequest
    {
        /// <summary>
        /// Confidence threshold for filtering detected faces. <br/>
        /// * Higher values (e.g., 0.9) include only faces detected with high certainty, reducing false positives. <br/>
        /// * Lower values (e.g., 0.3) include more faces, but may increase the chance of incorrect detections.<br/>
        /// Default Value: 0.5F<br/>
        /// Example: 0.5F
        /// </summary>
        /// <example>0.5F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence_score")]
        public double? ConfidenceScore { get; set; }

        /// <summary>
        /// Provide the assets for face detection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::MagicHour.FaceDetectionDetectFacesRequestAssets Assets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FaceDetectionDetectFacesRequest" /> class.
        /// </summary>
        /// <param name="assets">
        /// Provide the assets for face detection
        /// </param>
        /// <param name="confidenceScore">
        /// Confidence threshold for filtering detected faces. <br/>
        /// * Higher values (e.g., 0.9) include only faces detected with high certainty, reducing false positives. <br/>
        /// * Lower values (e.g., 0.3) include more faces, but may increase the chance of incorrect detections.<br/>
        /// Default Value: 0.5F<br/>
        /// Example: 0.5F
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FaceDetectionDetectFacesRequest(
            global::MagicHour.FaceDetectionDetectFacesRequestAssets assets,
            double? confidenceScore)
        {
            this.ConfidenceScore = confidenceScore;
            this.Assets = assets ?? throw new global::System.ArgumentNullException(nameof(assets));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FaceDetectionDetectFacesRequest" /> class.
        /// </summary>
        public FaceDetectionDetectFacesRequest()
        {
        }

    }
}