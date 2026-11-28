
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum VideoProjectsDeleteResponseNextActionType
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
    public static class VideoProjectsDeleteResponseNextActionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoProjectsDeleteResponseNextActionType value)
        {
            return value switch
            {
                VideoProjectsDeleteResponseNextActionType.BuyCredits => "buy_credits",
                VideoProjectsDeleteResponseNextActionType.CheckBalance => "check_balance",
                VideoProjectsDeleteResponseNextActionType.UpdatePaymentMethod => "update_payment_method",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoProjectsDeleteResponseNextActionType? ToEnum(string value)
        {
            return value switch
            {
                "buy_credits" => VideoProjectsDeleteResponseNextActionType.BuyCredits,
                "check_balance" => VideoProjectsDeleteResponseNextActionType.CheckBalance,
                "update_payment_method" => VideoProjectsDeleteResponseNextActionType.UpdatePaymentMethod,
                _ => null,
            };
        }
    }
}