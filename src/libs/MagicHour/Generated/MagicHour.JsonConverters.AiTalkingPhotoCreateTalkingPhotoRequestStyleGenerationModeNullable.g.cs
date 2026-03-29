#nullable enable

namespace MagicHour.JsonConverters
{
    /// <inheritdoc />
    public sealed class AiTalkingPhotoCreateTalkingPhotoRequestStyleGenerationModeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::MagicHour.AiTalkingPhotoCreateTalkingPhotoRequestStyleGenerationMode?>
    {
        /// <inheritdoc />
        public override global::MagicHour.AiTalkingPhotoCreateTalkingPhotoRequestStyleGenerationMode? Read(
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
                        return global::MagicHour.AiTalkingPhotoCreateTalkingPhotoRequestStyleGenerationModeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::MagicHour.AiTalkingPhotoCreateTalkingPhotoRequestStyleGenerationMode)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::MagicHour.AiTalkingPhotoCreateTalkingPhotoRequestStyleGenerationMode?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::MagicHour.AiTalkingPhotoCreateTalkingPhotoRequestStyleGenerationMode? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::MagicHour.AiTalkingPhotoCreateTalkingPhotoRequestStyleGenerationModeExtensions.ToValueString(value.Value));
            }
        }
    }
}
