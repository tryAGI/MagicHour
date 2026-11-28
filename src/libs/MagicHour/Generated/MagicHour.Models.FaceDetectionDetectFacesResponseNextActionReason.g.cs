
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum FaceDetectionDetectFacesResponseNextActionReason
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
    public static class FaceDetectionDetectFacesResponseNextActionReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FaceDetectionDetectFacesResponseNextActionReason value)
        {
            return value switch
            {
                FaceDetectionDetectFacesResponseNextActionReason.AutoReloadPending => "auto_reload_pending",
                FaceDetectionDetectFacesResponseNextActionReason.PaymentFailed => "payment_failed",
                FaceDetectionDetectFacesResponseNextActionReason.SpendingLimitReached => "spending_limit_reached",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FaceDetectionDetectFacesResponseNextActionReason? ToEnum(string value)
        {
            return value switch
            {
                "auto_reload_pending" => FaceDetectionDetectFacesResponseNextActionReason.AutoReloadPending,
                "payment_failed" => FaceDetectionDetectFacesResponseNextActionReason.PaymentFailed,
                "spending_limit_reached" => FaceDetectionDetectFacesResponseNextActionReason.SpendingLimitReached,
                _ => null,
            };
        }
    }
}