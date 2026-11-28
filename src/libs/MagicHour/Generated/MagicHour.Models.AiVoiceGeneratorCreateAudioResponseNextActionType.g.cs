
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum AiVoiceGeneratorCreateAudioResponseNextActionType
    {
        /// <summary>
        ///
        /// </summary>
        BuyCredits,
        /// <summary>
        ///
        /// </summary>
        CheckBalance,
        /// <summary>
        ///
        /// </summary>
        UpdatePaymentMethod,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AiVoiceGeneratorCreateAudioResponseNextActionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiVoiceGeneratorCreateAudioResponseNextActionType value)
        {
            return value switch
            {
                AiVoiceGeneratorCreateAudioResponseNextActionType.BuyCredits => "buy_credits",
                AiVoiceGeneratorCreateAudioResponseNextActionType.CheckBalance => "check_balance",
                AiVoiceGeneratorCreateAudioResponseNextActionType.UpdatePaymentMethod => "update_payment_method",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiVoiceGeneratorCreateAudioResponseNextActionType? ToEnum(string value)
        {
            return value switch
            {
                "buy_credits" => AiVoiceGeneratorCreateAudioResponseNextActionType.BuyCredits,
                "check_balance" => AiVoiceGeneratorCreateAudioResponseNextActionType.CheckBalance,
                "update_payment_method" => AiVoiceGeneratorCreateAudioResponseNextActionType.UpdatePaymentMethod,
                _ => null,
            };
        }
    }
}