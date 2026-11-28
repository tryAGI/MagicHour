
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum AiImageUpscalerCreateImageResponseNextActionType
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
    public static class AiImageUpscalerCreateImageResponseNextActionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiImageUpscalerCreateImageResponseNextActionType value)
        {
            return value switch
            {
                AiImageUpscalerCreateImageResponseNextActionType.BuyCredits => "buy_credits",
                AiImageUpscalerCreateImageResponseNextActionType.CheckBalance => "check_balance",
                AiImageUpscalerCreateImageResponseNextActionType.UpdatePaymentMethod => "update_payment_method",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiImageUpscalerCreateImageResponseNextActionType? ToEnum(string value)
        {
            return value switch
            {
                "buy_credits" => AiImageUpscalerCreateImageResponseNextActionType.BuyCredits,
                "check_balance" => AiImageUpscalerCreateImageResponseNextActionType.CheckBalance,
                "update_payment_method" => AiImageUpscalerCreateImageResponseNextActionType.UpdatePaymentMethod,
                _ => null,
            };
        }
    }
}