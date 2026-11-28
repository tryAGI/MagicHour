
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum AiImageEditorCreateImageResponseNextActionReason
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
    public static class AiImageEditorCreateImageResponseNextActionReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiImageEditorCreateImageResponseNextActionReason value)
        {
            return value switch
            {
                AiImageEditorCreateImageResponseNextActionReason.AutoReloadPending => "auto_reload_pending",
                AiImageEditorCreateImageResponseNextActionReason.PaymentFailed => "payment_failed",
                AiImageEditorCreateImageResponseNextActionReason.SpendingLimitReached => "spending_limit_reached",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiImageEditorCreateImageResponseNextActionReason? ToEnum(string value)
        {
            return value switch
            {
                "auto_reload_pending" => AiImageEditorCreateImageResponseNextActionReason.AutoReloadPending,
                "payment_failed" => AiImageEditorCreateImageResponseNextActionReason.PaymentFailed,
                "spending_limit_reached" => AiImageEditorCreateImageResponseNextActionReason.SpendingLimitReached,
                _ => null,
            };
        }
    }
}