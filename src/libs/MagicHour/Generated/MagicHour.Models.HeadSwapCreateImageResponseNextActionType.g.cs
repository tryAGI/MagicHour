
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum HeadSwapCreateImageResponseNextActionType
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
    public static class HeadSwapCreateImageResponseNextActionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HeadSwapCreateImageResponseNextActionType value)
        {
            return value switch
            {
                HeadSwapCreateImageResponseNextActionType.BuyCredits => "buy_credits",
                HeadSwapCreateImageResponseNextActionType.CheckBalance => "check_balance",
                HeadSwapCreateImageResponseNextActionType.UpdatePaymentMethod => "update_payment_method",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HeadSwapCreateImageResponseNextActionType? ToEnum(string value)
        {
            return value switch
            {
                "buy_credits" => HeadSwapCreateImageResponseNextActionType.BuyCredits,
                "check_balance" => HeadSwapCreateImageResponseNextActionType.CheckBalance,
                "update_payment_method" => HeadSwapCreateImageResponseNextActionType.UpdatePaymentMethod,
                _ => null,
            };
        }
    }
}