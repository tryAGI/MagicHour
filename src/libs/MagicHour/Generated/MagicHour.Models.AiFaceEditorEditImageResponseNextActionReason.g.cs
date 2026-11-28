
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum AiFaceEditorEditImageResponseNextActionReason
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
    public static class AiFaceEditorEditImageResponseNextActionReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiFaceEditorEditImageResponseNextActionReason value)
        {
            return value switch
            {
                AiFaceEditorEditImageResponseNextActionReason.AutoReloadPending => "auto_reload_pending",
                AiFaceEditorEditImageResponseNextActionReason.PaymentFailed => "payment_failed",
                AiFaceEditorEditImageResponseNextActionReason.SpendingLimitReached => "spending_limit_reached",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiFaceEditorEditImageResponseNextActionReason? ToEnum(string value)
        {
            return value switch
            {
                "auto_reload_pending" => AiFaceEditorEditImageResponseNextActionReason.AutoReloadPending,
                "payment_failed" => AiFaceEditorEditImageResponseNextActionReason.PaymentFailed,
                "spending_limit_reached" => AiFaceEditorEditImageResponseNextActionReason.SpendingLimitReached,
                _ => null,
            };
        }
    }
}