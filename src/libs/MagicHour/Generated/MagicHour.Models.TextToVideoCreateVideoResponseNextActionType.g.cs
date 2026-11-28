
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum TextToVideoCreateVideoResponseNextActionType
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
    public static class TextToVideoCreateVideoResponseNextActionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextToVideoCreateVideoResponseNextActionType value)
        {
            return value switch
            {
                TextToVideoCreateVideoResponseNextActionType.BuyCredits => "buy_credits",
                TextToVideoCreateVideoResponseNextActionType.CheckBalance => "check_balance",
                TextToVideoCreateVideoResponseNextActionType.UpdatePaymentMethod => "update_payment_method",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextToVideoCreateVideoResponseNextActionType? ToEnum(string value)
        {
            return value switch
            {
                "buy_credits" => TextToVideoCreateVideoResponseNextActionType.BuyCredits,
                "check_balance" => TextToVideoCreateVideoResponseNextActionType.CheckBalance,
                "update_payment_method" => TextToVideoCreateVideoResponseNextActionType.UpdatePaymentMethod,
                _ => null,
            };
        }
    }
}