
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum AiImageUpscalerCreateImageResponseNextActionReason
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
    public static class AiImageUpscalerCreateImageResponseNextActionReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiImageUpscalerCreateImageResponseNextActionReason value)
        {
            return value switch
            {
                AiImageUpscalerCreateImageResponseNextActionReason.AutoReloadPending => "auto_reload_pending",
                AiImageUpscalerCreateImageResponseNextActionReason.PaymentFailed => "payment_failed",
                AiImageUpscalerCreateImageResponseNextActionReason.SpendingLimitReached => "spending_limit_reached",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiImageUpscalerCreateImageResponseNextActionReason? ToEnum(string value)
        {
            return value switch
            {
                "auto_reload_pending" => AiImageUpscalerCreateImageResponseNextActionReason.AutoReloadPending,
                "payment_failed" => AiImageUpscalerCreateImageResponseNextActionReason.PaymentFailed,
                "spending_limit_reached" => AiImageUpscalerCreateImageResponseNextActionReason.SpendingLimitReached,
                _ => null,
            };
        }
    }
}