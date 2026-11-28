
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum VideoProjectsGetDetailsResponseNextActionType
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
    public static class VideoProjectsGetDetailsResponseNextActionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoProjectsGetDetailsResponseNextActionType value)
        {
            return value switch
            {
                VideoProjectsGetDetailsResponseNextActionType.BuyCredits => "buy_credits",
                VideoProjectsGetDetailsResponseNextActionType.CheckBalance => "check_balance",
                VideoProjectsGetDetailsResponseNextActionType.UpdatePaymentMethod => "update_payment_method",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoProjectsGetDetailsResponseNextActionType? ToEnum(string value)
        {
            return value switch
            {
                "buy_credits" => VideoProjectsGetDetailsResponseNextActionType.BuyCredits,
                "check_balance" => VideoProjectsGetDetailsResponseNextActionType.CheckBalance,
                "update_payment_method" => VideoProjectsGetDetailsResponseNextActionType.UpdatePaymentMethod,
                _ => null,
            };
        }
    }
}