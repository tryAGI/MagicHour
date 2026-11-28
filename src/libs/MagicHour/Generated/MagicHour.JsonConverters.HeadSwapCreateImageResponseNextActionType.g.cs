#nullable enable

namespace MagicHour.JsonConverters
{
    /// <inheritdoc />
    public sealed class HeadSwapCreateImageResponseNextActionTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::MagicHour.HeadSwapCreateImageResponseNextActionType>
    {
        /// <inheritdoc />
        public override global::MagicHour.HeadSwapCreateImageResponseNextActionType Read(
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
                        return global::MagicHour.HeadSwapCreateImageResponseNextActionTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::MagicHour.HeadSwapCreateImageResponseNextActionType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::MagicHour.HeadSwapCreateImageResponseNextActionType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::MagicHour.HeadSwapCreateImageResponseNextActionType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::MagicHour.HeadSwapCreateImageResponseNextActionTypeExtensions.ToValueString(value));
        }
    }
}
