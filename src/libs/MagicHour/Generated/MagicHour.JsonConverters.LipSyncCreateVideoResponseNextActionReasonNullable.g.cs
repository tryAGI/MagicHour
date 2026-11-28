#nullable enable

namespace MagicHour.JsonConverters
{
    /// <inheritdoc />
    public sealed class LipSyncCreateVideoResponseNextActionReasonNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::MagicHour.LipSyncCreateVideoResponseNextActionReason?>
    {
        /// <inheritdoc />
        public override global::MagicHour.LipSyncCreateVideoResponseNextActionReason? Read(
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
                        return global::MagicHour.LipSyncCreateVideoResponseNextActionReasonExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::MagicHour.LipSyncCreateVideoResponseNextActionReason)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::MagicHour.LipSyncCreateVideoResponseNextActionReason?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::MagicHour.LipSyncCreateVideoResponseNextActionReason? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::MagicHour.LipSyncCreateVideoResponseNextActionReasonExtensions.ToValueString(value.Value));
            }
        }
    }
}
