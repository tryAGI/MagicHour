
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum AudioProjectsDeleteResponseNextActionType
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
    public static class AudioProjectsDeleteResponseNextActionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioProjectsDeleteResponseNextActionType value)
        {
            return value switch
            {
                AudioProjectsDeleteResponseNextActionType.BuyCredits => "buy_credits",
                AudioProjectsDeleteResponseNextActionType.CheckBalance => "check_balance",
                AudioProjectsDeleteResponseNextActionType.UpdatePaymentMethod => "update_payment_method",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioProjectsDeleteResponseNextActionType? ToEnum(string value)
        {
            return value switch
            {
                "buy_credits" => AudioProjectsDeleteResponseNextActionType.BuyCredits,
                "check_balance" => AudioProjectsDeleteResponseNextActionType.CheckBalance,
                "update_payment_method" => AudioProjectsDeleteResponseNextActionType.UpdatePaymentMethod,
                _ => null,
            };
        }
    }
}