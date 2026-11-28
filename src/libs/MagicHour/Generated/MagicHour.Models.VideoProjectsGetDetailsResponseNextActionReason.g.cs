
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum VideoProjectsGetDetailsResponseNextActionReason
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
    public static class VideoProjectsGetDetailsResponseNextActionReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoProjectsGetDetailsResponseNextActionReason value)
        {
            return value switch
            {
                VideoProjectsGetDetailsResponseNextActionReason.AutoReloadPending => "auto_reload_pending",
                VideoProjectsGetDetailsResponseNextActionReason.PaymentFailed => "payment_failed",
                VideoProjectsGetDetailsResponseNextActionReason.SpendingLimitReached => "spending_limit_reached",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoProjectsGetDetailsResponseNextActionReason? ToEnum(string value)
        {
            return value switch
            {
                "auto_reload_pending" => VideoProjectsGetDetailsResponseNextActionReason.AutoReloadPending,
                "payment_failed" => VideoProjectsGetDetailsResponseNextActionReason.PaymentFailed,
                "spending_limit_reached" => VideoProjectsGetDetailsResponseNextActionReason.SpendingLimitReached,
                _ => null,
            };
        }
    }
}