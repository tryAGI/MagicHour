#nullable enable

namespace MagicHour.JsonConverters
{
    /// <inheritdoc />
    public sealed class AiVoiceGeneratorCreateAudioResponseNextActionTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::MagicHour.AiVoiceGeneratorCreateAudioResponseNextActionType?>
    {
        /// <inheritdoc />
        public override global::MagicHour.AiVoiceGeneratorCreateAudioResponseNextActionType? Read(
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
                        return global::MagicHour.AiVoiceGeneratorCreateAudioResponseNextActionTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::MagicHour.AiVoiceGeneratorCreateAudioResponseNextActionType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::MagicHour.AiVoiceGeneratorCreateAudioResponseNextActionType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::MagicHour.AiVoiceGeneratorCreateAudioResponseNextActionType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::MagicHour.AiVoiceGeneratorCreateAudioResponseNextActionTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
