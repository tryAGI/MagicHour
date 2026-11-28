
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum AiMusicGeneratorCreateAudioResponseNextActionReason
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
    public static class AiMusicGeneratorCreateAudioResponseNextActionReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiMusicGeneratorCreateAudioResponseNextActionReason value)
        {
            return value switch
            {
                AiMusicGeneratorCreateAudioResponseNextActionReason.AutoReloadPending => "auto_reload_pending",
                AiMusicGeneratorCreateAudioResponseNextActionReason.PaymentFailed => "payment_failed",
                AiMusicGeneratorCreateAudioResponseNextActionReason.SpendingLimitReached => "spending_limit_reached",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiMusicGeneratorCreateAudioResponseNextActionReason? ToEnum(string value)
        {
            return value switch
            {
                "auto_reload_pending" => AiMusicGeneratorCreateAudioResponseNextActionReason.AutoReloadPending,
                "payment_failed" => AiMusicGeneratorCreateAudioResponseNextActionReason.PaymentFailed,
                "spending_limit_reached" => AiMusicGeneratorCreateAudioResponseNextActionReason.SpendingLimitReached,
                _ => null,
            };
        }
    }
}