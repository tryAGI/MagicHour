#nullable enable

namespace MagicHour.JsonConverters
{
    /// <inheritdoc />
    public sealed class EstimateVideoResponseCode3NullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::MagicHour.EstimateVideoResponseCode3?>
    {
        /// <inheritdoc />
        public override global::MagicHour.EstimateVideoResponseCode3? Read(
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
                        return global::MagicHour.EstimateVideoResponseCode3Extensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::MagicHour.EstimateVideoResponseCode3)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::MagicHour.EstimateVideoResponseCode3?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::MagicHour.EstimateVideoResponseCode3? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::MagicHour.EstimateVideoResponseCode3Extensions.ToValueString(value.Value));
            }
        }
    }
}
