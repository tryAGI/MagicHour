#nullable enable

namespace MagicHour.JsonConverters
{
    /// <inheritdoc />
    public sealed class AiImageGeneratorCreateImageResponseCode6JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::MagicHour.AiImageGeneratorCreateImageResponseCode6>
    {
        /// <inheritdoc />
        public override global::MagicHour.AiImageGeneratorCreateImageResponseCode6 Read(
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
                        return global::MagicHour.AiImageGeneratorCreateImageResponseCode6Extensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::MagicHour.AiImageGeneratorCreateImageResponseCode6)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::MagicHour.AiImageGeneratorCreateImageResponseCode6);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::MagicHour.AiImageGeneratorCreateImageResponseCode6 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::MagicHour.AiImageGeneratorCreateImageResponseCode6Extensions.ToValueString(value));
        }
    }
}
