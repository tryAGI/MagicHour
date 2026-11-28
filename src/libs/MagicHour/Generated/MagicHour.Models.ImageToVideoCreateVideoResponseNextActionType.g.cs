
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum ImageToVideoCreateVideoResponseNextActionType
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
    public static class ImageToVideoCreateVideoResponseNextActionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageToVideoCreateVideoResponseNextActionType value)
        {
            return value switch
            {
                ImageToVideoCreateVideoResponseNextActionType.BuyCredits => "buy_credits",
                ImageToVideoCreateVideoResponseNextActionType.CheckBalance => "check_balance",
                ImageToVideoCreateVideoResponseNextActionType.UpdatePaymentMethod => "update_payment_method",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageToVideoCreateVideoResponseNextActionType? ToEnum(string value)
        {
            return value switch
            {
                "buy_credits" => ImageToVideoCreateVideoResponseNextActionType.BuyCredits,
                "check_balance" => ImageToVideoCreateVideoResponseNextActionType.CheckBalance,
                "update_payment_method" => ImageToVideoCreateVideoResponseNextActionType.UpdatePaymentMethod,
                _ => null,
            };
        }
    }
}