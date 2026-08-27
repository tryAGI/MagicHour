#nullable enable

namespace MagicHour.JsonConverters
{
    /// <inheritdoc />
    public sealed class AiImageGeneratorCreateImageRequestStyleToolNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::MagicHour.AiImageGeneratorCreateImageRequestStyleTool?>
    {
        /// <inheritdoc />
        public override global::MagicHour.AiImageGeneratorCreateImageRequestStyleTool? Read(
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
                        return global::MagicHour.AiImageGeneratorCreateImageRequestStyleToolExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::MagicHour.AiImageGeneratorCreateImageRequestStyleTool)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::MagicHour.AiImageGeneratorCreateImageRequestStyleTool?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::MagicHour.AiImageGeneratorCreateImageRequestStyleTool? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::MagicHour.AiImageGeneratorCreateImageRequestStyleToolExtensions.ToValueString(value.Value));
            }
        }
    }
}
