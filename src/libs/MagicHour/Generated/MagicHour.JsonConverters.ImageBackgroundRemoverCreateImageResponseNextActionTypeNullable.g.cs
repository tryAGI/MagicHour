#nullable enable

namespace MagicHour.JsonConverters
{
    /// <inheritdoc />
    public sealed class ImageBackgroundRemoverCreateImageResponseNextActionTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::MagicHour.ImageBackgroundRemoverCreateImageResponseNextActionType?>
    {
        /// <inheritdoc />
        public override global::MagicHour.ImageBackgroundRemoverCreateImageResponseNextActionType? Read(
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
                        return global::MagicHour.ImageBackgroundRemoverCreateImageResponseNextActionTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::MagicHour.ImageBackgroundRemoverCreateImageResponseNextActionType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::MagicHour.ImageBackgroundRemoverCreateImageResponseNextActionType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::MagicHour.ImageBackgroundRemoverCreateImageResponseNextActionType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::MagicHour.ImageBackgroundRemoverCreateImageResponseNextActionTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
