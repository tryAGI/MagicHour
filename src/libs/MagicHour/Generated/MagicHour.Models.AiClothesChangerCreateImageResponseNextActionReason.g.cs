
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum AiClothesChangerCreateImageResponseNextActionReason
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
    public static class AiClothesChangerCreateImageResponseNextActionReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiClothesChangerCreateImageResponseNextActionReason value)
        {
            return value switch
            {
                AiClothesChangerCreateImageResponseNextActionReason.AutoReloadPending => "auto_reload_pending",
                AiClothesChangerCreateImageResponseNextActionReason.PaymentFailed => "payment_failed",
                AiClothesChangerCreateImageResponseNextActionReason.SpendingLimitReached => "spending_limit_reached",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiClothesChangerCreateImageResponseNextActionReason? ToEnum(string value)
        {
            return value switch
            {
                "auto_reload_pending" => AiClothesChangerCreateImageResponseNextActionReason.AutoReloadPending,
                "payment_failed" => AiClothesChangerCreateImageResponseNextActionReason.PaymentFailed,
                "spending_limit_reached" => AiClothesChangerCreateImageResponseNextActionReason.SpendingLimitReached,
                _ => null,
            };
        }
    }
}