#nullable enable

namespace MagicHour.JsonConverters
{
    /// <inheritdoc />
    public sealed class PhotoColorizerCreateImageResponseNextActionTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::MagicHour.PhotoColorizerCreateImageResponseNextActionType?>
    {
        /// <inheritdoc />
        public override global::MagicHour.PhotoColorizerCreateImageResponseNextActionType? Read(
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
                        return global::MagicHour.PhotoColorizerCreateImageResponseNextActionTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::MagicHour.PhotoColorizerCreateImageResponseNextActionType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::MagicHour.PhotoColorizerCreateImageResponseNextActionType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::MagicHour.PhotoColorizerCreateImageResponseNextActionType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::MagicHour.PhotoColorizerCreateImageResponseNextActionTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
