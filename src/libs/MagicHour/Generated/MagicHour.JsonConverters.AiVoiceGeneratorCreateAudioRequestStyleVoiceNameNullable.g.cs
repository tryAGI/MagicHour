#nullable enable

namespace MagicHour.JsonConverters
{
    /// <inheritdoc />
    public sealed class AiVoiceGeneratorCreateAudioRequestStyleVoiceNameNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::MagicHour.AiVoiceGeneratorCreateAudioRequestStyleVoiceName?>
    {
        /// <inheritdoc />
        public override global::MagicHour.AiVoiceGeneratorCreateAudioRequestStyleVoiceName? Read(
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
                        return global::MagicHour.AiVoiceGeneratorCreateAudioRequestStyleVoiceNameExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::MagicHour.AiVoiceGeneratorCreateAudioRequestStyleVoiceName)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::MagicHour.AiVoiceGeneratorCreateAudioRequestStyleVoiceName?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::MagicHour.AiVoiceGeneratorCreateAudioRequestStyleVoiceName? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::MagicHour.AiVoiceGeneratorCreateAudioRequestStyleVoiceNameExtensions.ToValueString(value.Value));
            }
        }
    }
}
