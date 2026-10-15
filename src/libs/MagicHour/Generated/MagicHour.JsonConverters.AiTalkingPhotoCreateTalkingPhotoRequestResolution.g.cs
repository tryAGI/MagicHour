#nullable enable

namespace MagicHour.JsonConverters
{
    /// <inheritdoc />
    public sealed class AiTalkingPhotoCreateTalkingPhotoRequestResolutionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::MagicHour.AiTalkingPhotoCreateTalkingPhotoRequestResolution>
    {
        /// <inheritdoc />
        public override global::MagicHour.AiTalkingPhotoCreateTalkingPhotoRequestResolution Read(
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
                        return global::MagicHour.AiTalkingPhotoCreateTalkingPhotoRequestResolutionExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::MagicHour.AiTalkingPhotoCreateTalkingPhotoRequestResolution)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::MagicHour.AiTalkingPhotoCreateTalkingPhotoRequestResolution);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::MagicHour.AiTalkingPhotoCreateTalkingPhotoRequestResolution value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::MagicHour.AiTalkingPhotoCreateTalkingPhotoRequestResolutionExtensions.ToValueString(value));
        }
    }
}
