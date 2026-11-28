
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum AiVideoUpscalerCreateVideoResponseNextActionType
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
    public static class AiVideoUpscalerCreateVideoResponseNextActionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiVideoUpscalerCreateVideoResponseNextActionType value)
        {
            return value switch
            {
                AiVideoUpscalerCreateVideoResponseNextActionType.BuyCredits => "buy_credits",
                AiVideoUpscalerCreateVideoResponseNextActionType.CheckBalance => "check_balance",
                AiVideoUpscalerCreateVideoResponseNextActionType.UpdatePaymentMethod => "update_payment_method",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiVideoUpscalerCreateVideoResponseNextActionType? ToEnum(string value)
        {
            return value switch
            {
                "buy_credits" => AiVideoUpscalerCreateVideoResponseNextActionType.BuyCredits,
                "check_balance" => AiVideoUpscalerCreateVideoResponseNextActionType.CheckBalance,
                "update_payment_method" => AiVideoUpscalerCreateVideoResponseNextActionType.UpdatePaymentMethod,
                _ => null,
            };
        }
    }
}