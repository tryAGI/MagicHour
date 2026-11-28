
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum VideoAssetsGeneratePresignedUrlResponseNextActionReason
    {
        /// <summary>
        ///
        /// </summary>
        AutoReloadPending,
        /// <summary>
        ///
        /// </summary>
        PaymentFailed,
        /// <summary>
        ///
        /// </summary>
        SpendingLimitReached,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoAssetsGeneratePresignedUrlResponseNextActionReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoAssetsGeneratePresignedUrlResponseNextActionReason value)
        {
            return value switch
            {
                VideoAssetsGeneratePresignedUrlResponseNextActionReason.AutoReloadPending => "auto_reload_pending",
                VideoAssetsGeneratePresignedUrlResponseNextActionReason.PaymentFailed => "payment_failed",
                VideoAssetsGeneratePresignedUrlResponseNextActionReason.SpendingLimitReached => "spending_limit_reached",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoAssetsGeneratePresignedUrlResponseNextActionReason? ToEnum(string value)
        {
            return value switch
            {
                "auto_reload_pending" => VideoAssetsGeneratePresignedUrlResponseNextActionReason.AutoReloadPending,
                "payment_failed" => VideoAssetsGeneratePresignedUrlResponseNextActionReason.PaymentFailed,
                "spending_limit_reached" => VideoAssetsGeneratePresignedUrlResponseNextActionReason.SpendingLimitReached,
                _ => null,
            };
        }
    }
}