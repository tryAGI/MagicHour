#nullable enable

namespace MagicHour.JsonConverters
{
    /// <inheritdoc />
    public sealed class VideoToVideoCreateVideoRequestStyleArtStyleJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::MagicHour.VideoToVideoCreateVideoRequestStyleArtStyle>
    {
        /// <inheritdoc />
        public override global::MagicHour.VideoToVideoCreateVideoRequestStyleArtStyle Read(
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
                        return global::MagicHour.VideoToVideoCreateVideoRequestStyleArtStyleExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::MagicHour.VideoToVideoCreateVideoRequestStyleArtStyle)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::MagicHour.VideoToVideoCreateVideoRequestStyleArtStyle);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::MagicHour.VideoToVideoCreateVideoRequestStyleArtStyle value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::MagicHour.VideoToVideoCreateVideoRequestStyleArtStyleExtensions.ToValueString(value));
        }
    }
}
