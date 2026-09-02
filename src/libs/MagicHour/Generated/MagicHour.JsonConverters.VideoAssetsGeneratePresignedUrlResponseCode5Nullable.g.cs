#nullable enable

namespace MagicHour.JsonConverters
{
    /// <inheritdoc />
    public sealed class VideoAssetsGeneratePresignedUrlResponseCode5NullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::MagicHour.VideoAssetsGeneratePresignedUrlResponseCode5?>
    {
        /// <inheritdoc />
        public override global::MagicHour.VideoAssetsGeneratePresignedUrlResponseCode5? Read(
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
                        return global::MagicHour.VideoAssetsGeneratePresignedUrlResponseCode5Extensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::MagicHour.VideoAssetsGeneratePresignedUrlResponseCode5)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::MagicHour.VideoAssetsGeneratePresignedUrlResponseCode5?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::MagicHour.VideoAssetsGeneratePresignedUrlResponseCode5? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::MagicHour.VideoAssetsGeneratePresignedUrlResponseCode5Extensions.ToValueString(value.Value));
            }
        }
    }
}
