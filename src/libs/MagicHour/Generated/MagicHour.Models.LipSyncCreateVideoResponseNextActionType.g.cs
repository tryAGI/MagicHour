
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum LipSyncCreateVideoResponseNextActionType
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
    public static class LipSyncCreateVideoResponseNextActionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LipSyncCreateVideoResponseNextActionType value)
        {
            return value switch
            {
                LipSyncCreateVideoResponseNextActionType.BuyCredits => "buy_credits",
                LipSyncCreateVideoResponseNextActionType.CheckBalance => "check_balance",
                LipSyncCreateVideoResponseNextActionType.UpdatePaymentMethod => "update_payment_method",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LipSyncCreateVideoResponseNextActionType? ToEnum(string value)
        {
            return value switch
            {
                "buy_credits" => LipSyncCreateVideoResponseNextActionType.BuyCredits,
                "check_balance" => LipSyncCreateVideoResponseNextActionType.CheckBalance,
                "update_payment_method" => LipSyncCreateVideoResponseNextActionType.UpdatePaymentMethod,
                _ => null,
            };
        }
    }
}