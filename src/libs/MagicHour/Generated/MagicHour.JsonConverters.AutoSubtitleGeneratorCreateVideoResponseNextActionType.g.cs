#nullable enable

namespace MagicHour.JsonConverters
{
    /// <inheritdoc />
    public sealed class AutoSubtitleGeneratorCreateVideoResponseNextActionTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::MagicHour.AutoSubtitleGeneratorCreateVideoResponseNextActionType>
    {
        /// <inheritdoc />
        public override global::MagicHour.AutoSubtitleGeneratorCreateVideoResponseNextActionType Read(
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
                        return global::MagicHour.AutoSubtitleGeneratorCreateVideoResponseNextActionTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::MagicHour.AutoSubtitleGeneratorCreateVideoResponseNextActionType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::MagicHour.AutoSubtitleGeneratorCreateVideoResponseNextActionType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::MagicHour.AutoSubtitleGeneratorCreateVideoResponseNextActionType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::MagicHour.AutoSubtitleGeneratorCreateVideoResponseNextActionTypeExtensions.ToValueString(value));
        }
    }
}
