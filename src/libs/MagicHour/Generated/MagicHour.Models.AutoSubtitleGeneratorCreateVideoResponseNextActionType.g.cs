
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSubtitleGeneratorCreateVideoResponseNextActionType
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
    public static class AutoSubtitleGeneratorCreateVideoResponseNextActionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSubtitleGeneratorCreateVideoResponseNextActionType value)
        {
            return value switch
            {
                AutoSubtitleGeneratorCreateVideoResponseNextActionType.BuyCredits => "buy_credits",
                AutoSubtitleGeneratorCreateVideoResponseNextActionType.CheckBalance => "check_balance",
                AutoSubtitleGeneratorCreateVideoResponseNextActionType.UpdatePaymentMethod => "update_payment_method",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSubtitleGeneratorCreateVideoResponseNextActionType? ToEnum(string value)
        {
            return value switch
            {
                "buy_credits" => AutoSubtitleGeneratorCreateVideoResponseNextActionType.BuyCredits,
                "check_balance" => AutoSubtitleGeneratorCreateVideoResponseNextActionType.CheckBalance,
                "update_payment_method" => AutoSubtitleGeneratorCreateVideoResponseNextActionType.UpdatePaymentMethod,
                _ => null,
            };
        }
    }
}