
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum VideoAssetsGeneratePresignedUrlResponseNextActionType
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
    public static class VideoAssetsGeneratePresignedUrlResponseNextActionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoAssetsGeneratePresignedUrlResponseNextActionType value)
        {
            return value switch
            {
                VideoAssetsGeneratePresignedUrlResponseNextActionType.BuyCredits => "buy_credits",
                VideoAssetsGeneratePresignedUrlResponseNextActionType.CheckBalance => "check_balance",
                VideoAssetsGeneratePresignedUrlResponseNextActionType.UpdatePaymentMethod => "update_payment_method",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoAssetsGeneratePresignedUrlResponseNextActionType? ToEnum(string value)
        {
            return value switch
            {
                "buy_credits" => VideoAssetsGeneratePresignedUrlResponseNextActionType.BuyCredits,
                "check_balance" => VideoAssetsGeneratePresignedUrlResponseNextActionType.CheckBalance,
                "update_payment_method" => VideoAssetsGeneratePresignedUrlResponseNextActionType.UpdatePaymentMethod,
                _ => null,
            };
        }
    }
}