
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum FaceSwapCreateVideoResponseNextActionReason
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
    public static class FaceSwapCreateVideoResponseNextActionReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FaceSwapCreateVideoResponseNextActionReason value)
        {
            return value switch
            {
                FaceSwapCreateVideoResponseNextActionReason.AutoReloadPending => "auto_reload_pending",
                FaceSwapCreateVideoResponseNextActionReason.PaymentFailed => "payment_failed",
                FaceSwapCreateVideoResponseNextActionReason.SpendingLimitReached => "spending_limit_reached",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FaceSwapCreateVideoResponseNextActionReason? ToEnum(string value)
        {
            return value switch
            {
                "auto_reload_pending" => FaceSwapCreateVideoResponseNextActionReason.AutoReloadPending,
                "payment_failed" => FaceSwapCreateVideoResponseNextActionReason.PaymentFailed,
                "spending_limit_reached" => FaceSwapCreateVideoResponseNextActionReason.SpendingLimitReached,
                _ => null,
            };
        }
    }
}