#nullable enable

namespace MagicHour.JsonConverters
{
    /// <inheritdoc />
    public sealed class ImageBackgroundRemoverCreateImageResponseNextActionReasonNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::MagicHour.ImageBackgroundRemoverCreateImageResponseNextActionReason?>
    {
        /// <inheritdoc />
        public override global::MagicHour.ImageBackgroundRemoverCreateImageResponseNextActionReason? Read(
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
                        return global::MagicHour.ImageBackgroundRemoverCreateImageResponseNextActionReasonExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::MagicHour.ImageBackgroundRemoverCreateImageResponseNextActionReason)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::MagicHour.ImageBackgroundRemoverCreateImageResponseNextActionReason?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::MagicHour.ImageBackgroundRemoverCreateImageResponseNextActionReason? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::MagicHour.ImageBackgroundRemoverCreateImageResponseNextActionReasonExtensions.ToValueString(value.Value));
            }
        }
    }
}
