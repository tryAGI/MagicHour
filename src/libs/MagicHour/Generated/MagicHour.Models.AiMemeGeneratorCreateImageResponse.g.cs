
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Success
    /// </summary>
    public sealed partial class AiMemeGeneratorCreateImageResponse
    {
        /// <summary>
        /// Unique ID of the image. Use it with the [Get image Project API](https://docs.magichour.ai/api-reference/image-projects/get-image-details) to fetch status and downloads.<br/>
        /// Example: cuid-example
        /// </summary>
        /// <example>cuid-example</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The amount of credits deducted from your account to generate the image. We charge credits right when the request is made. <br/>
        /// If an error occurred while generating the image(s), credits will be refunded and this field will be updated to include the refund.<br/>
        /// Example: 10
        /// </summary>
        /// <example>10</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits_charged")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreditsCharged { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AiMemeGeneratorCreateImageResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique ID of the image. Use it with the [Get image Project API](https://docs.magichour.ai/api-reference/image-projects/get-image-details) to fetch status and downloads.<br/>
        /// Example: cuid-example
        /// </param>
        /// <param name="creditsCharged">
        /// The amount of credits deducted from your account to generate the image. We charge credits right when the request is made. <br/>
        /// If an error occurred while generating the image(s), credits will be refunded and this field will be updated to include the refund.<br/>
        /// Example: 10
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AiMemeGeneratorCreateImageResponse(
            string id,
            int creditsCharged)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreditsCharged = creditsCharged;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiMemeGeneratorCreateImageResponse" /> class.
        /// </summary>
        public AiMemeGeneratorCreateImageResponse()
        {
        }

    }
}