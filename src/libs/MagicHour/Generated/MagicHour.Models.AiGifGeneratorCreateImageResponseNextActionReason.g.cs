
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum AiGifGeneratorCreateImageResponseNextActionReason
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
    public static class AiGifGeneratorCreateImageResponseNextActionReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiGifGeneratorCreateImageResponseNextActionReason value)
        {
            return value switch
            {
                AiGifGeneratorCreateImageResponseNextActionReason.AutoReloadPending => "auto_reload_pending",
                AiGifGeneratorCreateImageResponseNextActionReason.PaymentFailed => "payment_failed",
                AiGifGeneratorCreateImageResponseNextActionReason.SpendingLimitReached => "spending_limit_reached",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiGifGeneratorCreateImageResponseNextActionReason? ToEnum(string value)
        {
            return value switch
            {
                "auto_reload_pending" => AiGifGeneratorCreateImageResponseNextActionReason.AutoReloadPending,
                "payment_failed" => AiGifGeneratorCreateImageResponseNextActionReason.PaymentFailed,
                "spending_limit_reached" => AiGifGeneratorCreateImageResponseNextActionReason.SpendingLimitReached,
                _ => null,
            };
        }
    }
}