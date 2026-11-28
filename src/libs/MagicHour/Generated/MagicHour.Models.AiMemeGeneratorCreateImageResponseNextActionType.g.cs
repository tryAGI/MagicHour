
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum AiMemeGeneratorCreateImageResponseNextActionType
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
    public static class AiMemeGeneratorCreateImageResponseNextActionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiMemeGeneratorCreateImageResponseNextActionType value)
        {
            return value switch
            {
                AiMemeGeneratorCreateImageResponseNextActionType.BuyCredits => "buy_credits",
                AiMemeGeneratorCreateImageResponseNextActionType.CheckBalance => "check_balance",
                AiMemeGeneratorCreateImageResponseNextActionType.UpdatePaymentMethod => "update_payment_method",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiMemeGeneratorCreateImageResponseNextActionType? ToEnum(string value)
        {
            return value switch
            {
                "buy_credits" => AiMemeGeneratorCreateImageResponseNextActionType.BuyCredits,
                "check_balance" => AiMemeGeneratorCreateImageResponseNextActionType.CheckBalance,
                "update_payment_method" => AiMemeGeneratorCreateImageResponseNextActionType.UpdatePaymentMethod,
                _ => null,
            };
        }
    }
}