
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum AiVideoTranslatorCreateVideoResponseNextActionType
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
    public static class AiVideoTranslatorCreateVideoResponseNextActionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiVideoTranslatorCreateVideoResponseNextActionType value)
        {
            return value switch
            {
                AiVideoTranslatorCreateVideoResponseNextActionType.BuyCredits => "buy_credits",
                AiVideoTranslatorCreateVideoResponseNextActionType.CheckBalance => "check_balance",
                AiVideoTranslatorCreateVideoResponseNextActionType.UpdatePaymentMethod => "update_payment_method",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiVideoTranslatorCreateVideoResponseNextActionType? ToEnum(string value)
        {
            return value switch
            {
                "buy_credits" => AiVideoTranslatorCreateVideoResponseNextActionType.BuyCredits,
                "check_balance" => AiVideoTranslatorCreateVideoResponseNextActionType.CheckBalance,
                "update_payment_method" => AiVideoTranslatorCreateVideoResponseNextActionType.UpdatePaymentMethod,
                _ => null,
            };
        }
    }
}