
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum BodySwapCreateImageResponseNextActionType
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
    public static class BodySwapCreateImageResponseNextActionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodySwapCreateImageResponseNextActionType value)
        {
            return value switch
            {
                BodySwapCreateImageResponseNextActionType.BuyCredits => "buy_credits",
                BodySwapCreateImageResponseNextActionType.CheckBalance => "check_balance",
                BodySwapCreateImageResponseNextActionType.UpdatePaymentMethod => "update_payment_method",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodySwapCreateImageResponseNextActionType? ToEnum(string value)
        {
            return value switch
            {
                "buy_credits" => BodySwapCreateImageResponseNextActionType.BuyCredits,
                "check_balance" => BodySwapCreateImageResponseNextActionType.CheckBalance,
                "update_payment_method" => BodySwapCreateImageResponseNextActionType.UpdatePaymentMethod,
                _ => null,
            };
        }
    }
}