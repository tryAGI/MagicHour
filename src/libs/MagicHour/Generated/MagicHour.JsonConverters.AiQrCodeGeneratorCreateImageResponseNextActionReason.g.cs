#nullable enable

namespace MagicHour.JsonConverters
{
    /// <inheritdoc />
    public sealed class AiQrCodeGeneratorCreateImageResponseNextActionReasonJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::MagicHour.AiQrCodeGeneratorCreateImageResponseNextActionReason>
    {
        /// <inheritdoc />
        public override global::MagicHour.AiQrCodeGeneratorCreateImageResponseNextActionReason Read(
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
                        return global::MagicHour.AiQrCodeGeneratorCreateImageResponseNextActionReasonExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::MagicHour.AiQrCodeGeneratorCreateImageResponseNextActionReason)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::MagicHour.AiQrCodeGeneratorCreateImageResponseNextActionReason);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::MagicHour.AiQrCodeGeneratorCreateImageResponseNextActionReason value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::MagicHour.AiQrCodeGeneratorCreateImageResponseNextActionReasonExtensions.ToValueString(value));
        }
    }
}
