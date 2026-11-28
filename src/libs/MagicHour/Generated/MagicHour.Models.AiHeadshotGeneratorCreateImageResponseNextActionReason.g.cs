
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum AiHeadshotGeneratorCreateImageResponseNextActionReason
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
    public static class AiHeadshotGeneratorCreateImageResponseNextActionReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiHeadshotGeneratorCreateImageResponseNextActionReason value)
        {
            return value switch
            {
                AiHeadshotGeneratorCreateImageResponseNextActionReason.AutoReloadPending => "auto_reload_pending",
                AiHeadshotGeneratorCreateImageResponseNextActionReason.PaymentFailed => "payment_failed",
                AiHeadshotGeneratorCreateImageResponseNextActionReason.SpendingLimitReached => "spending_limit_reached",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiHeadshotGeneratorCreateImageResponseNextActionReason? ToEnum(string value)
        {
            return value switch
            {
                "auto_reload_pending" => AiHeadshotGeneratorCreateImageResponseNextActionReason.AutoReloadPending,
                "payment_failed" => AiHeadshotGeneratorCreateImageResponseNextActionReason.PaymentFailed,
                "spending_limit_reached" => AiHeadshotGeneratorCreateImageResponseNextActionReason.SpendingLimitReached,
                _ => null,
            };
        }
    }
}