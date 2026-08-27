#nullable enable

namespace MagicHour.JsonConverters
{
    /// <inheritdoc />
    public sealed class ImageBackgroundRemoverCreateImageResponseMessageJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::MagicHour.ImageBackgroundRemoverCreateImageResponseMessage>
    {
        /// <inheritdoc />
        public override global::MagicHour.ImageBackgroundRemoverCreateImageResponseMessage Read(
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
                        return global::MagicHour.ImageBackgroundRemoverCreateImageResponseMessageExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::MagicHour.ImageBackgroundRemoverCreateImageResponseMessage)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::MagicHour.ImageBackgroundRemoverCreateImageResponseMessage);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::MagicHour.ImageBackgroundRemoverCreateImageResponseMessage value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::MagicHour.ImageBackgroundRemoverCreateImageResponseMessageExtensions.ToValueString(value));
        }
    }
}
