
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum ImageProjectsDeleteResponseNextActionType
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
    public static class ImageProjectsDeleteResponseNextActionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageProjectsDeleteResponseNextActionType value)
        {
            return value switch
            {
                ImageProjectsDeleteResponseNextActionType.BuyCredits => "buy_credits",
                ImageProjectsDeleteResponseNextActionType.CheckBalance => "check_balance",
                ImageProjectsDeleteResponseNextActionType.UpdatePaymentMethod => "update_payment_method",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageProjectsDeleteResponseNextActionType? ToEnum(string value)
        {
            return value switch
            {
                "buy_credits" => ImageProjectsDeleteResponseNextActionType.BuyCredits,
                "check_balance" => ImageProjectsDeleteResponseNextActionType.CheckBalance,
                "update_payment_method" => ImageProjectsDeleteResponseNextActionType.UpdatePaymentMethod,
                _ => null,
            };
        }
    }
}