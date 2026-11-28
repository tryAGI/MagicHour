
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum FaceSwapPhotoCreateImageResponseNextActionReason
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
    public static class FaceSwapPhotoCreateImageResponseNextActionReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FaceSwapPhotoCreateImageResponseNextActionReason value)
        {
            return value switch
            {
                FaceSwapPhotoCreateImageResponseNextActionReason.AutoReloadPending => "auto_reload_pending",
                FaceSwapPhotoCreateImageResponseNextActionReason.PaymentFailed => "payment_failed",
                FaceSwapPhotoCreateImageResponseNextActionReason.SpendingLimitReached => "spending_limit_reached",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FaceSwapPhotoCreateImageResponseNextActionReason? ToEnum(string value)
        {
            return value switch
            {
                "auto_reload_pending" => FaceSwapPhotoCreateImageResponseNextActionReason.AutoReloadPending,
                "payment_failed" => FaceSwapPhotoCreateImageResponseNextActionReason.PaymentFailed,
                "spending_limit_reached" => FaceSwapPhotoCreateImageResponseNextActionReason.SpendingLimitReached,
                _ => null,
            };
        }
    }
}