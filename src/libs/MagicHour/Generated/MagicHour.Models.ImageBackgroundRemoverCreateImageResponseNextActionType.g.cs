
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum ImageBackgroundRemoverCreateImageResponseNextActionType
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
    public static class ImageBackgroundRemoverCreateImageResponseNextActionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageBackgroundRemoverCreateImageResponseNextActionType value)
        {
            return value switch
            {
                ImageBackgroundRemoverCreateImageResponseNextActionType.BuyCredits => "buy_credits",
                ImageBackgroundRemoverCreateImageResponseNextActionType.CheckBalance => "check_balance",
                ImageBackgroundRemoverCreateImageResponseNextActionType.UpdatePaymentMethod => "update_payment_method",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageBackgroundRemoverCreateImageResponseNextActionType? ToEnum(string value)
        {
            return value switch
            {
                "buy_credits" => ImageBackgroundRemoverCreateImageResponseNextActionType.BuyCredits,
                "check_balance" => ImageBackgroundRemoverCreateImageResponseNextActionType.CheckBalance,
                "update_payment_method" => ImageBackgroundRemoverCreateImageResponseNextActionType.UpdatePaymentMethod,
                _ => null,
            };
        }
    }
}