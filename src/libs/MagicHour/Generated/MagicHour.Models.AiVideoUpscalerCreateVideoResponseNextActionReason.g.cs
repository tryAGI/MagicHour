
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum AiVideoUpscalerCreateVideoResponseNextActionReason
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
    public static class AiVideoUpscalerCreateVideoResponseNextActionReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiVideoUpscalerCreateVideoResponseNextActionReason value)
        {
            return value switch
            {
                AiVideoUpscalerCreateVideoResponseNextActionReason.AutoReloadPending => "auto_reload_pending",
                AiVideoUpscalerCreateVideoResponseNextActionReason.PaymentFailed => "payment_failed",
                AiVideoUpscalerCreateVideoResponseNextActionReason.SpendingLimitReached => "spending_limit_reached",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiVideoUpscalerCreateVideoResponseNextActionReason? ToEnum(string value)
        {
            return value switch
            {
                "auto_reload_pending" => AiVideoUpscalerCreateVideoResponseNextActionReason.AutoReloadPending,
                "payment_failed" => AiVideoUpscalerCreateVideoResponseNextActionReason.PaymentFailed,
                "spending_limit_reached" => AiVideoUpscalerCreateVideoResponseNextActionReason.SpendingLimitReached,
                _ => null,
            };
        }
    }
}