#nullable enable

namespace MagicHour.JsonConverters
{
    /// <inheritdoc />
    public sealed class FaceSwapPhotoCreateImageRequestAssetsFaceSwapModeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::MagicHour.FaceSwapPhotoCreateImageRequestAssetsFaceSwapMode?>
    {
        /// <inheritdoc />
        public override global::MagicHour.FaceSwapPhotoCreateImageRequestAssetsFaceSwapMode? Read(
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
                        return global::MagicHour.FaceSwapPhotoCreateImageRequestAssetsFaceSwapModeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::MagicHour.FaceSwapPhotoCreateImageRequestAssetsFaceSwapMode)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::MagicHour.FaceSwapPhotoCreateImageRequestAssetsFaceSwapMode?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::MagicHour.FaceSwapPhotoCreateImageRequestAssetsFaceSwapMode? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::MagicHour.FaceSwapPhotoCreateImageRequestAssetsFaceSwapModeExtensions.ToValueString(value.Value));
            }
        }
    }
}
