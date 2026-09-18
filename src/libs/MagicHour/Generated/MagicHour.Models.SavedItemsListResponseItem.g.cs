
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SavedItemsListResponseItem
    {
        /// <summary>
        /// Unique ID of the saved item.<br/>
        /// Example: cuid-example
        /// </summary>
        /// <example>cuid-example</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Saved item type.<br/>
        /// Example: character
        /// </summary>
        /// <example>character</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.SavedItemsListResponseItemTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::MagicHour.SavedItemsListResponseItemType Type { get; set; }

        /// <summary>
        /// User-provided name of the saved item.<br/>
        /// Example: Alex
        /// </summary>
        /// <example>Alex</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::MagicHour.SavedItemsListResponseItemAsset> Assets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SavedItemsListResponseItem" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique ID of the saved item.<br/>
        /// Example: cuid-example
        /// </param>
        /// <param name="type">
        /// Saved item type.<br/>
        /// Example: character
        /// </param>
        /// <param name="assets"></param>
        /// <param name="name">
        /// User-provided name of the saved item.<br/>
        /// Example: Alex
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SavedItemsListResponseItem(
            string id,
            global::MagicHour.SavedItemsListResponseItemType type,
            global::System.Collections.Generic.IList<global::MagicHour.SavedItemsListResponseItemAsset> assets,
            string? name)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
            this.Name = name;
            this.Assets = assets ?? throw new global::System.ArgumentNullException(nameof(assets));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SavedItemsListResponseItem" /> class.
        /// </summary>
        public SavedItemsListResponseItem()
        {
        }

    }
}