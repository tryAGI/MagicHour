
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum FaceDetectionGetDetailsResponseNextActionReason
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
    public static class FaceDetectionGetDetailsResponseNextActionReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FaceDetectionGetDetailsResponseNextActionReason value)
        {
            return value switch
            {
                FaceDetectionGetDetailsResponseNextActionReason.AutoReloadPending => "auto_reload_pending",
                FaceDetectionGetDetailsResponseNextActionReason.PaymentFailed => "payment_failed",
                FaceDetectionGetDetailsResponseNextActionReason.SpendingLimitReached => "spending_limit_reached",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FaceDetectionGetDetailsResponseNextActionReason? ToEnum(string value)
        {
            return value switch
            {
                "auto_reload_pending" => FaceDetectionGetDetailsResponseNextActionReason.AutoReloadPending,
                "payment_failed" => FaceDetectionGetDetailsResponseNextActionReason.PaymentFailed,
                "spending_limit_reached" => FaceDetectionGetDetailsResponseNextActionReason.SpendingLimitReached,
                _ => null,
            };
        }
    }
}