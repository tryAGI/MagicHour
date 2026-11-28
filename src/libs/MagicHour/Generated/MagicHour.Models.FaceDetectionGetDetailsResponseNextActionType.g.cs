
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum FaceDetectionGetDetailsResponseNextActionType
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
    public static class FaceDetectionGetDetailsResponseNextActionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FaceDetectionGetDetailsResponseNextActionType value)
        {
            return value switch
            {
                FaceDetectionGetDetailsResponseNextActionType.BuyCredits => "buy_credits",
                FaceDetectionGetDetailsResponseNextActionType.CheckBalance => "check_balance",
                FaceDetectionGetDetailsResponseNextActionType.UpdatePaymentMethod => "update_payment_method",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FaceDetectionGetDetailsResponseNextActionType? ToEnum(string value)
        {
            return value switch
            {
                "buy_credits" => FaceDetectionGetDetailsResponseNextActionType.BuyCredits,
                "check_balance" => FaceDetectionGetDetailsResponseNextActionType.CheckBalance,
                "update_payment_method" => FaceDetectionGetDetailsResponseNextActionType.UpdatePaymentMethod,
                _ => null,
            };
        }
    }
}