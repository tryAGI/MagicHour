
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum AudioToVideoCreateVideoResponseNextActionReason
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
    public static class AudioToVideoCreateVideoResponseNextActionReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioToVideoCreateVideoResponseNextActionReason value)
        {
            return value switch
            {
                AudioToVideoCreateVideoResponseNextActionReason.AutoReloadPending => "auto_reload_pending",
                AudioToVideoCreateVideoResponseNextActionReason.PaymentFailed => "payment_failed",
                AudioToVideoCreateVideoResponseNextActionReason.SpendingLimitReached => "spending_limit_reached",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioToVideoCreateVideoResponseNextActionReason? ToEnum(string value)
        {
            return value switch
            {
                "auto_reload_pending" => AudioToVideoCreateVideoResponseNextActionReason.AutoReloadPending,
                "payment_failed" => AudioToVideoCreateVideoResponseNextActionReason.PaymentFailed,
                "spending_limit_reached" => AudioToVideoCreateVideoResponseNextActionReason.SpendingLimitReached,
                _ => null,
            };
        }
    }
}