
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Machine-readable error code.<br/>
    /// - `unprocessable_entity`: Change the request values before retrying.
    /// </summary>
    public enum AiHeadshotGeneratorCreateImageResponseCode5
    {
        /// <summary>
        /// Change the request values before retrying.
        /// </summary>
        UnprocessableEntity,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AiHeadshotGeneratorCreateImageResponseCode5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiHeadshotGeneratorCreateImageResponseCode5 value)
        {
            return value switch
            {
                AiHeadshotGeneratorCreateImageResponseCode5.UnprocessableEntity => "unprocessable_entity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiHeadshotGeneratorCreateImageResponseCode5? ToEnum(string value)
        {
            return value switch
            {
                "unprocessable_entity" => AiHeadshotGeneratorCreateImageResponseCode5.UnprocessableEntity,
                _ => null,
            };
        }
    }
}