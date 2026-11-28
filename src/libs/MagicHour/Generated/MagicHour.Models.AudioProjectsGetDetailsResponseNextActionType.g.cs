
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum AudioProjectsGetDetailsResponseNextActionType
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
    public static class AudioProjectsGetDetailsResponseNextActionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioProjectsGetDetailsResponseNextActionType value)
        {
            return value switch
            {
                AudioProjectsGetDetailsResponseNextActionType.BuyCredits => "buy_credits",
                AudioProjectsGetDetailsResponseNextActionType.CheckBalance => "check_balance",
                AudioProjectsGetDetailsResponseNextActionType.UpdatePaymentMethod => "update_payment_method",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioProjectsGetDetailsResponseNextActionType? ToEnum(string value)
        {
            return value switch
            {
                "buy_credits" => AudioProjectsGetDetailsResponseNextActionType.BuyCredits,
                "check_balance" => AudioProjectsGetDetailsResponseNextActionType.CheckBalance,
                "update_payment_method" => AudioProjectsGetDetailsResponseNextActionType.UpdatePaymentMethod,
                _ => null,
            };
        }
    }
}