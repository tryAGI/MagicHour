
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum AudioToVideoCreateVideoResponseNextActionType
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
    public static class AudioToVideoCreateVideoResponseNextActionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioToVideoCreateVideoResponseNextActionType value)
        {
            return value switch
            {
                AudioToVideoCreateVideoResponseNextActionType.BuyCredits => "buy_credits",
                AudioToVideoCreateVideoResponseNextActionType.CheckBalance => "check_balance",
                AudioToVideoCreateVideoResponseNextActionType.UpdatePaymentMethod => "update_payment_method",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioToVideoCreateVideoResponseNextActionType? ToEnum(string value)
        {
            return value switch
            {
                "buy_credits" => AudioToVideoCreateVideoResponseNextActionType.BuyCredits,
                "check_balance" => AudioToVideoCreateVideoResponseNextActionType.CheckBalance,
                "update_payment_method" => AudioToVideoCreateVideoResponseNextActionType.UpdatePaymentMethod,
                _ => null,
            };
        }
    }
}