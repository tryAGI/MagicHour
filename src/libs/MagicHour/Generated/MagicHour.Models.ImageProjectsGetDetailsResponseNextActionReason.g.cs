
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum ImageProjectsGetDetailsResponseNextActionReason
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
    public static class ImageProjectsGetDetailsResponseNextActionReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageProjectsGetDetailsResponseNextActionReason value)
        {
            return value switch
            {
                ImageProjectsGetDetailsResponseNextActionReason.AutoReloadPending => "auto_reload_pending",
                ImageProjectsGetDetailsResponseNextActionReason.PaymentFailed => "payment_failed",
                ImageProjectsGetDetailsResponseNextActionReason.SpendingLimitReached => "spending_limit_reached",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageProjectsGetDetailsResponseNextActionReason? ToEnum(string value)
        {
            return value switch
            {
                "auto_reload_pending" => ImageProjectsGetDetailsResponseNextActionReason.AutoReloadPending,
                "payment_failed" => ImageProjectsGetDetailsResponseNextActionReason.PaymentFailed,
                "spending_limit_reached" => ImageProjectsGetDetailsResponseNextActionReason.SpendingLimitReached,
                _ => null,
            };
        }
    }
}