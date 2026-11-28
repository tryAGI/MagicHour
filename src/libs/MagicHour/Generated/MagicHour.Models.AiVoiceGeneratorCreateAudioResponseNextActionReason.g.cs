
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum AiVoiceGeneratorCreateAudioResponseNextActionReason
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
    public static class AiVoiceGeneratorCreateAudioResponseNextActionReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiVoiceGeneratorCreateAudioResponseNextActionReason value)
        {
            return value switch
            {
                AiVoiceGeneratorCreateAudioResponseNextActionReason.AutoReloadPending => "auto_reload_pending",
                AiVoiceGeneratorCreateAudioResponseNextActionReason.PaymentFailed => "payment_failed",
                AiVoiceGeneratorCreateAudioResponseNextActionReason.SpendingLimitReached => "spending_limit_reached",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiVoiceGeneratorCreateAudioResponseNextActionReason? ToEnum(string value)
        {
            return value switch
            {
                "auto_reload_pending" => AiVoiceGeneratorCreateAudioResponseNextActionReason.AutoReloadPending,
                "payment_failed" => AiVoiceGeneratorCreateAudioResponseNextActionReason.PaymentFailed,
                "spending_limit_reached" => AiVoiceGeneratorCreateAudioResponseNextActionReason.SpendingLimitReached,
                _ => null,
            };
        }
    }
}