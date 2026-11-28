
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum ImageProjectsGetDetailsResponseNextActionType
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
    public static class ImageProjectsGetDetailsResponseNextActionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageProjectsGetDetailsResponseNextActionType value)
        {
            return value switch
            {
                ImageProjectsGetDetailsResponseNextActionType.BuyCredits => "buy_credits",
                ImageProjectsGetDetailsResponseNextActionType.CheckBalance => "check_balance",
                ImageProjectsGetDetailsResponseNextActionType.UpdatePaymentMethod => "update_payment_method",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageProjectsGetDetailsResponseNextActionType? ToEnum(string value)
        {
            return value switch
            {
                "buy_credits" => ImageProjectsGetDetailsResponseNextActionType.BuyCredits,
                "check_balance" => ImageProjectsGetDetailsResponseNextActionType.CheckBalance,
                "update_payment_method" => ImageProjectsGetDetailsResponseNextActionType.UpdatePaymentMethod,
                _ => null,
            };
        }
    }
}