
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum AiMemeGeneratorCreateImageResponseNextActionReason
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
    public static class AiMemeGeneratorCreateImageResponseNextActionReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiMemeGeneratorCreateImageResponseNextActionReason value)
        {
            return value switch
            {
                AiMemeGeneratorCreateImageResponseNextActionReason.AutoReloadPending => "auto_reload_pending",
                AiMemeGeneratorCreateImageResponseNextActionReason.PaymentFailed => "payment_failed",
                AiMemeGeneratorCreateImageResponseNextActionReason.SpendingLimitReached => "spending_limit_reached",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiMemeGeneratorCreateImageResponseNextActionReason? ToEnum(string value)
        {
            return value switch
            {
                "auto_reload_pending" => AiMemeGeneratorCreateImageResponseNextActionReason.AutoReloadPending,
                "payment_failed" => AiMemeGeneratorCreateImageResponseNextActionReason.PaymentFailed,
                "spending_limit_reached" => AiMemeGeneratorCreateImageResponseNextActionReason.SpendingLimitReached,
                _ => null,
            };
        }
    }
}