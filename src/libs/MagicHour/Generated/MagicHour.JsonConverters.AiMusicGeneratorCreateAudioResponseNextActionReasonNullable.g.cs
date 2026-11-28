#nullable enable

namespace MagicHour.JsonConverters
{
    /// <inheritdoc />
    public sealed class AiMusicGeneratorCreateAudioResponseNextActionReasonNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::MagicHour.AiMusicGeneratorCreateAudioResponseNextActionReason?>
    {
        /// <inheritdoc />
        public override global::MagicHour.AiMusicGeneratorCreateAudioResponseNextActionReason? Read(
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
                        return global::MagicHour.AiMusicGeneratorCreateAudioResponseNextActionReasonExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::MagicHour.AiMusicGeneratorCreateAudioResponseNextActionReason)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::MagicHour.AiMusicGeneratorCreateAudioResponseNextActionReason?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::MagicHour.AiMusicGeneratorCreateAudioResponseNextActionReason? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::MagicHour.AiMusicGeneratorCreateAudioResponseNextActionReasonExtensions.ToValueString(value.Value));
            }
        }
    }
}
