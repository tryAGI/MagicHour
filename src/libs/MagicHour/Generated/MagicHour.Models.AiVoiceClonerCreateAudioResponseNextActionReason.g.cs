
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum AiVoiceClonerCreateAudioResponseNextActionReason
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
    public static class AiVoiceClonerCreateAudioResponseNextActionReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiVoiceClonerCreateAudioResponseNextActionReason value)
        {
            return value switch
            {
                AiVoiceClonerCreateAudioResponseNextActionReason.AutoReloadPending => "auto_reload_pending",
                AiVoiceClonerCreateAudioResponseNextActionReason.PaymentFailed => "payment_failed",
                AiVoiceClonerCreateAudioResponseNextActionReason.SpendingLimitReached => "spending_limit_reached",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiVoiceClonerCreateAudioResponseNextActionReason? ToEnum(string value)
        {
            return value switch
            {
                "auto_reload_pending" => AiVoiceClonerCreateAudioResponseNextActionReason.AutoReloadPending,
                "payment_failed" => AiVoiceClonerCreateAudioResponseNextActionReason.PaymentFailed,
                "spending_limit_reached" => AiVoiceClonerCreateAudioResponseNextActionReason.SpendingLimitReached,
                _ => null,
            };
        }
    }
}