
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum AnimationCreateVideoResponseNextActionReason
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
    public static class AnimationCreateVideoResponseNextActionReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnimationCreateVideoResponseNextActionReason value)
        {
            return value switch
            {
                AnimationCreateVideoResponseNextActionReason.AutoReloadPending => "auto_reload_pending",
                AnimationCreateVideoResponseNextActionReason.PaymentFailed => "payment_failed",
                AnimationCreateVideoResponseNextActionReason.SpendingLimitReached => "spending_limit_reached",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnimationCreateVideoResponseNextActionReason? ToEnum(string value)
        {
            return value switch
            {
                "auto_reload_pending" => AnimationCreateVideoResponseNextActionReason.AutoReloadPending,
                "payment_failed" => AnimationCreateVideoResponseNextActionReason.PaymentFailed,
                "spending_limit_reached" => AnimationCreateVideoResponseNextActionReason.SpendingLimitReached,
                _ => null,
            };
        }
    }
}