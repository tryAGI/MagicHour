
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum AiVideoEditorCreateVideoResponseNextActionReason
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
    public static class AiVideoEditorCreateVideoResponseNextActionReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiVideoEditorCreateVideoResponseNextActionReason value)
        {
            return value switch
            {
                AiVideoEditorCreateVideoResponseNextActionReason.AutoReloadPending => "auto_reload_pending",
                AiVideoEditorCreateVideoResponseNextActionReason.PaymentFailed => "payment_failed",
                AiVideoEditorCreateVideoResponseNextActionReason.SpendingLimitReached => "spending_limit_reached",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiVideoEditorCreateVideoResponseNextActionReason? ToEnum(string value)
        {
            return value switch
            {
                "auto_reload_pending" => AiVideoEditorCreateVideoResponseNextActionReason.AutoReloadPending,
                "payment_failed" => AiVideoEditorCreateVideoResponseNextActionReason.PaymentFailed,
                "spending_limit_reached" => AiVideoEditorCreateVideoResponseNextActionReason.SpendingLimitReached,
                _ => null,
            };
        }
    }
}