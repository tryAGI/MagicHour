#nullable enable

namespace MagicHour.JsonConverters
{
    /// <inheritdoc />
    public sealed class EstimateAudioResponseCodeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::MagicHour.EstimateAudioResponseCode>
    {
        /// <inheritdoc />
        public override global::MagicHour.EstimateAudioResponseCode Read(
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
                        return global::MagicHour.EstimateAudioResponseCodeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::MagicHour.EstimateAudioResponseCode)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::MagicHour.EstimateAudioResponseCode);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::MagicHour.EstimateAudioResponseCode value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::MagicHour.EstimateAudioResponseCodeExtensions.ToValueString(value));
        }
    }
}
