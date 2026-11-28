
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum AiVideoTranslatorCreateVideoResponseNextActionReason
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
    public static class AiVideoTranslatorCreateVideoResponseNextActionReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiVideoTranslatorCreateVideoResponseNextActionReason value)
        {
            return value switch
            {
                AiVideoTranslatorCreateVideoResponseNextActionReason.AutoReloadPending => "auto_reload_pending",
                AiVideoTranslatorCreateVideoResponseNextActionReason.PaymentFailed => "payment_failed",
                AiVideoTranslatorCreateVideoResponseNextActionReason.SpendingLimitReached => "spending_limit_reached",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiVideoTranslatorCreateVideoResponseNextActionReason? ToEnum(string value)
        {
            return value switch
            {
                "auto_reload_pending" => AiVideoTranslatorCreateVideoResponseNextActionReason.AutoReloadPending,
                "payment_failed" => AiVideoTranslatorCreateVideoResponseNextActionReason.PaymentFailed,
                "spending_limit_reached" => AiVideoTranslatorCreateVideoResponseNextActionReason.SpendingLimitReached,
                _ => null,
            };
        }
    }
}