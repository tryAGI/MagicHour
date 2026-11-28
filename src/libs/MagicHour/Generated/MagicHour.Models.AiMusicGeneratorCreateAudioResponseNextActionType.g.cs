
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum AiMusicGeneratorCreateAudioResponseNextActionType
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
    public static class AiMusicGeneratorCreateAudioResponseNextActionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiMusicGeneratorCreateAudioResponseNextActionType value)
        {
            return value switch
            {
                AiMusicGeneratorCreateAudioResponseNextActionType.BuyCredits => "buy_credits",
                AiMusicGeneratorCreateAudioResponseNextActionType.CheckBalance => "check_balance",
                AiMusicGeneratorCreateAudioResponseNextActionType.UpdatePaymentMethod => "update_payment_method",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiMusicGeneratorCreateAudioResponseNextActionType? ToEnum(string value)
        {
            return value switch
            {
                "buy_credits" => AiMusicGeneratorCreateAudioResponseNextActionType.BuyCredits,
                "check_balance" => AiMusicGeneratorCreateAudioResponseNextActionType.CheckBalance,
                "update_payment_method" => AiMusicGeneratorCreateAudioResponseNextActionType.UpdatePaymentMethod,
                _ => null,
            };
        }
    }
}