
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSubtitleGeneratorCreateVideoResponseNextActionReason
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
    public static class AutoSubtitleGeneratorCreateVideoResponseNextActionReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSubtitleGeneratorCreateVideoResponseNextActionReason value)
        {
            return value switch
            {
                AutoSubtitleGeneratorCreateVideoResponseNextActionReason.AutoReloadPending => "auto_reload_pending",
                AutoSubtitleGeneratorCreateVideoResponseNextActionReason.PaymentFailed => "payment_failed",
                AutoSubtitleGeneratorCreateVideoResponseNextActionReason.SpendingLimitReached => "spending_limit_reached",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSubtitleGeneratorCreateVideoResponseNextActionReason? ToEnum(string value)
        {
            return value switch
            {
                "auto_reload_pending" => AutoSubtitleGeneratorCreateVideoResponseNextActionReason.AutoReloadPending,
                "payment_failed" => AutoSubtitleGeneratorCreateVideoResponseNextActionReason.PaymentFailed,
                "spending_limit_reached" => AutoSubtitleGeneratorCreateVideoResponseNextActionReason.SpendingLimitReached,
                _ => null,
            };
        }
    }
}