
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum PhotoColorizerCreateImageResponseNextActionReason
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
    public static class PhotoColorizerCreateImageResponseNextActionReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PhotoColorizerCreateImageResponseNextActionReason value)
        {
            return value switch
            {
                PhotoColorizerCreateImageResponseNextActionReason.AutoReloadPending => "auto_reload_pending",
                PhotoColorizerCreateImageResponseNextActionReason.PaymentFailed => "payment_failed",
                PhotoColorizerCreateImageResponseNextActionReason.SpendingLimitReached => "spending_limit_reached",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PhotoColorizerCreateImageResponseNextActionReason? ToEnum(string value)
        {
            return value switch
            {
                "auto_reload_pending" => PhotoColorizerCreateImageResponseNextActionReason.AutoReloadPending,
                "payment_failed" => PhotoColorizerCreateImageResponseNextActionReason.PaymentFailed,
                "spending_limit_reached" => PhotoColorizerCreateImageResponseNextActionReason.SpendingLimitReached,
                _ => null,
            };
        }
    }
}