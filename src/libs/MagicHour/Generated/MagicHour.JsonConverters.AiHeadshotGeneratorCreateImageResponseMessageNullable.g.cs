#nullable enable

namespace MagicHour.JsonConverters
{
    /// <inheritdoc />
    public sealed class AiHeadshotGeneratorCreateImageResponseMessageNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::MagicHour.AiHeadshotGeneratorCreateImageResponseMessage?>
    {
        /// <inheritdoc />
        public override global::MagicHour.AiHeadshotGeneratorCreateImageResponseMessage? Read(
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
                        return global::MagicHour.AiHeadshotGeneratorCreateImageResponseMessageExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::MagicHour.AiHeadshotGeneratorCreateImageResponseMessage)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::MagicHour.AiHeadshotGeneratorCreateImageResponseMessage?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::MagicHour.AiHeadshotGeneratorCreateImageResponseMessage? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::MagicHour.AiHeadshotGeneratorCreateImageResponseMessageExtensions.ToValueString(value.Value));
            }
        }
    }
}
