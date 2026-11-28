
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum AiImageGeneratorCreateImageResponseNextActionType
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
    public static class AiImageGeneratorCreateImageResponseNextActionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiImageGeneratorCreateImageResponseNextActionType value)
        {
            return value switch
            {
                AiImageGeneratorCreateImageResponseNextActionType.BuyCredits => "buy_credits",
                AiImageGeneratorCreateImageResponseNextActionType.CheckBalance => "check_balance",
                AiImageGeneratorCreateImageResponseNextActionType.UpdatePaymentMethod => "update_payment_method",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiImageGeneratorCreateImageResponseNextActionType? ToEnum(string value)
        {
            return value switch
            {
                "buy_credits" => AiImageGeneratorCreateImageResponseNextActionType.BuyCredits,
                "check_balance" => AiImageGeneratorCreateImageResponseNextActionType.CheckBalance,
                "update_payment_method" => AiImageGeneratorCreateImageResponseNextActionType.UpdatePaymentMethod,
                _ => null,
            };
        }
    }
}