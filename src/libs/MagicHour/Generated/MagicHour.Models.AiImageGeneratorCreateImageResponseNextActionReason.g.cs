
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum AiImageGeneratorCreateImageResponseNextActionReason
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
    public static class AiImageGeneratorCreateImageResponseNextActionReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiImageGeneratorCreateImageResponseNextActionReason value)
        {
            return value switch
            {
                AiImageGeneratorCreateImageResponseNextActionReason.AutoReloadPending => "auto_reload_pending",
                AiImageGeneratorCreateImageResponseNextActionReason.PaymentFailed => "payment_failed",
                AiImageGeneratorCreateImageResponseNextActionReason.SpendingLimitReached => "spending_limit_reached",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiImageGeneratorCreateImageResponseNextActionReason? ToEnum(string value)
        {
            return value switch
            {
                "auto_reload_pending" => AiImageGeneratorCreateImageResponseNextActionReason.AutoReloadPending,
                "payment_failed" => AiImageGeneratorCreateImageResponseNextActionReason.PaymentFailed,
                "spending_limit_reached" => AiImageGeneratorCreateImageResponseNextActionReason.SpendingLimitReached,
                _ => null,
            };
        }
    }
}