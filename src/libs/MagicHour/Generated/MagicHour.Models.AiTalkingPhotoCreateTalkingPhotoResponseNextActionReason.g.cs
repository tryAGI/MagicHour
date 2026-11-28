
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum AiTalkingPhotoCreateTalkingPhotoResponseNextActionReason
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
    public static class AiTalkingPhotoCreateTalkingPhotoResponseNextActionReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiTalkingPhotoCreateTalkingPhotoResponseNextActionReason value)
        {
            return value switch
            {
                AiTalkingPhotoCreateTalkingPhotoResponseNextActionReason.AutoReloadPending => "auto_reload_pending",
                AiTalkingPhotoCreateTalkingPhotoResponseNextActionReason.PaymentFailed => "payment_failed",
                AiTalkingPhotoCreateTalkingPhotoResponseNextActionReason.SpendingLimitReached => "spending_limit_reached",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiTalkingPhotoCreateTalkingPhotoResponseNextActionReason? ToEnum(string value)
        {
            return value switch
            {
                "auto_reload_pending" => AiTalkingPhotoCreateTalkingPhotoResponseNextActionReason.AutoReloadPending,
                "payment_failed" => AiTalkingPhotoCreateTalkingPhotoResponseNextActionReason.PaymentFailed,
                "spending_limit_reached" => AiTalkingPhotoCreateTalkingPhotoResponseNextActionReason.SpendingLimitReached,
                _ => null,
            };
        }
    }
}