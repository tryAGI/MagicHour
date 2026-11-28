#nullable enable

namespace MagicHour.JsonConverters
{
    /// <inheritdoc />
    public sealed class ImageProjectsGetDetailsResponseNextActionReasonJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::MagicHour.ImageProjectsGetDetailsResponseNextActionReason>
    {
        /// <inheritdoc />
        public override global::MagicHour.ImageProjectsGetDetailsResponseNextActionReason Read(
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
                        return global::MagicHour.ImageProjectsGetDetailsResponseNextActionReasonExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::MagicHour.ImageProjectsGetDetailsResponseNextActionReason)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::MagicHour.ImageProjectsGetDetailsResponseNextActionReason);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::MagicHour.ImageProjectsGetDetailsResponseNextActionReason value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::MagicHour.ImageProjectsGetDetailsResponseNextActionReasonExtensions.ToValueString(value));
        }
    }
}
