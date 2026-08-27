#nullable enable

namespace MagicHour.JsonConverters
{
    /// <inheritdoc />
    public sealed class CharacterReplaceCreateVideoRequestStyleModeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::MagicHour.CharacterReplaceCreateVideoRequestStyleMode?>
    {
        /// <inheritdoc />
        public override global::MagicHour.CharacterReplaceCreateVideoRequestStyleMode? Read(
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
                        return global::MagicHour.CharacterReplaceCreateVideoRequestStyleModeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::MagicHour.CharacterReplaceCreateVideoRequestStyleMode)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::MagicHour.CharacterReplaceCreateVideoRequestStyleMode?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::MagicHour.CharacterReplaceCreateVideoRequestStyleMode? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::MagicHour.CharacterReplaceCreateVideoRequestStyleModeExtensions.ToValueString(value.Value));
            }
        }
    }
}
