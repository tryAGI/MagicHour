
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum AiGifGeneratorCreateImageResponseNextActionType
    {
        /// <summary>
        ///
        /// </summary>
        BuyCredits,
        /// <summary>
        ///
        /// </summary>
        CheckBalance,
        /// <summary>
        ///
        /// </summary>
        UpdatePaymentMethod,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AiGifGeneratorCreateImageResponseNextActionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiGifGeneratorCreateImageResponseNextActionType value)
        {
            return value switch
            {
                AiGifGeneratorCreateImageResponseNextActionType.BuyCredits => "buy_credits",
                AiGifGeneratorCreateImageResponseNextActionType.CheckBalance => "check_balance",
                AiGifGeneratorCreateImageResponseNextActionType.UpdatePaymentMethod => "update_payment_method",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiGifGeneratorCreateImageResponseNextActionType? ToEnum(string value)
        {
            return value switch
            {
                "buy_credits" => AiGifGeneratorCreateImageResponseNextActionType.BuyCredits,
                "check_balance" => AiGifGeneratorCreateImageResponseNextActionType.CheckBalance,
                "update_payment_method" => AiGifGeneratorCreateImageResponseNextActionType.UpdatePaymentMethod,
                _ => null,
            };
        }
    }
}