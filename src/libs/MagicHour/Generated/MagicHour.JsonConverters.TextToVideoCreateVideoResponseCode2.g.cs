#nullable enable

namespace MagicHour.JsonConverters
{
    /// <inheritdoc />
    public sealed class TextToVideoCreateVideoResponseCode2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::MagicHour.TextToVideoCreateVideoResponseCode2>
    {
        /// <inheritdoc />
        public override global::MagicHour.TextToVideoCreateVideoResponseCode2 Read(
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
                        return global::MagicHour.TextToVideoCreateVideoResponseCode2Extensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::MagicHour.TextToVideoCreateVideoResponseCode2)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::MagicHour.TextToVideoCreateVideoResponseCode2);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::MagicHour.TextToVideoCreateVideoResponseCode2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::MagicHour.TextToVideoCreateVideoResponseCode2Extensions.ToValueString(value));
        }
    }
}
