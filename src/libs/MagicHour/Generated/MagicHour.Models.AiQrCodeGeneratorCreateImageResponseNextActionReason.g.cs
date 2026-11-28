
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum AiQrCodeGeneratorCreateImageResponseNextActionReason
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
    public static class AiQrCodeGeneratorCreateImageResponseNextActionReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiQrCodeGeneratorCreateImageResponseNextActionReason value)
        {
            return value switch
            {
                AiQrCodeGeneratorCreateImageResponseNextActionReason.AutoReloadPending => "auto_reload_pending",
                AiQrCodeGeneratorCreateImageResponseNextActionReason.PaymentFailed => "payment_failed",
                AiQrCodeGeneratorCreateImageResponseNextActionReason.SpendingLimitReached => "spending_limit_reached",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiQrCodeGeneratorCreateImageResponseNextActionReason? ToEnum(string value)
        {
            return value switch
            {
                "auto_reload_pending" => AiQrCodeGeneratorCreateImageResponseNextActionReason.AutoReloadPending,
                "payment_failed" => AiQrCodeGeneratorCreateImageResponseNextActionReason.PaymentFailed,
                "spending_limit_reached" => AiQrCodeGeneratorCreateImageResponseNextActionReason.SpendingLimitReached,
                _ => null,
            };
        }
    }
}