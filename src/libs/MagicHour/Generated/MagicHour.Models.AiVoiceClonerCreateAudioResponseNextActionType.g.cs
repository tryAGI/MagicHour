
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum AiVoiceClonerCreateAudioResponseNextActionType
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
    public static class AiVoiceClonerCreateAudioResponseNextActionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiVoiceClonerCreateAudioResponseNextActionType value)
        {
            return value switch
            {
                AiVoiceClonerCreateAudioResponseNextActionType.BuyCredits => "buy_credits",
                AiVoiceClonerCreateAudioResponseNextActionType.CheckBalance => "check_balance",
                AiVoiceClonerCreateAudioResponseNextActionType.UpdatePaymentMethod => "update_payment_method",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiVoiceClonerCreateAudioResponseNextActionType? ToEnum(string value)
        {
            return value switch
            {
                "buy_credits" => AiVoiceClonerCreateAudioResponseNextActionType.BuyCredits,
                "check_balance" => AiVoiceClonerCreateAudioResponseNextActionType.CheckBalance,
                "update_payment_method" => AiVoiceClonerCreateAudioResponseNextActionType.UpdatePaymentMethod,
                _ => null,
            };
        }
    }
}