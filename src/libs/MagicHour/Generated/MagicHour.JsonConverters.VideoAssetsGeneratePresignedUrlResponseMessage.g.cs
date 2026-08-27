#nullable enable

namespace MagicHour.JsonConverters
{
    /// <inheritdoc />
    public sealed class VideoAssetsGeneratePresignedUrlResponseMessageJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::MagicHour.VideoAssetsGeneratePresignedUrlResponseMessage>
    {
        /// <inheritdoc />
        public override global::MagicHour.VideoAssetsGeneratePresignedUrlResponseMessage Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::MagicHour.VideoAssetsGeneratePresignedUrlResponseMessageExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::MagicHour.VideoAssetsGeneratePresignedUrlResponseMessage)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::MagicHour.VideoAssetsGeneratePresignedUrlResponseMessage);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::MagicHour.VideoAssetsGeneratePresignedUrlResponseMessage value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::MagicHour.VideoAssetsGeneratePresignedUrlResponseMessageExtensions.ToValueString(value));
        }
    }
}
