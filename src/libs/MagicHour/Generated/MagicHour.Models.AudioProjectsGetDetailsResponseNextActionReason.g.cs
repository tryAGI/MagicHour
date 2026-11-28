
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum AudioProjectsGetDetailsResponseNextActionReason
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
    public static class AudioProjectsGetDetailsResponseNextActionReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioProjectsGetDetailsResponseNextActionReason value)
        {
            return value switch
            {
                AudioProjectsGetDetailsResponseNextActionReason.AutoReloadPending => "auto_reload_pending",
                AudioProjectsGetDetailsResponseNextActionReason.PaymentFailed => "payment_failed",
                AudioProjectsGetDetailsResponseNextActionReason.SpendingLimitReached => "spending_limit_reached",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioProjectsGetDetailsResponseNextActionReason? ToEnum(string value)
        {
            return value switch
            {
                "auto_reload_pending" => AudioProjectsGetDetailsResponseNextActionReason.AutoReloadPending,
                "payment_failed" => AudioProjectsGetDetailsResponseNextActionReason.PaymentFailed,
                "spending_limit_reached" => AudioProjectsGetDetailsResponseNextActionReason.SpendingLimitReached,
                _ => null,
            };
        }
    }
}