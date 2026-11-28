
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum PhotoColorizerCreateImageResponseNextActionType
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
    public static class PhotoColorizerCreateImageResponseNextActionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PhotoColorizerCreateImageResponseNextActionType value)
        {
            return value switch
            {
                PhotoColorizerCreateImageResponseNextActionType.BuyCredits => "buy_credits",
                PhotoColorizerCreateImageResponseNextActionType.CheckBalance => "check_balance",
                PhotoColorizerCreateImageResponseNextActionType.UpdatePaymentMethod => "update_payment_method",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PhotoColorizerCreateImageResponseNextActionType? ToEnum(string value)
        {
            return value switch
            {
                "buy_credits" => PhotoColorizerCreateImageResponseNextActionType.BuyCredits,
                "check_balance" => PhotoColorizerCreateImageResponseNextActionType.CheckBalance,
                "update_payment_method" => PhotoColorizerCreateImageResponseNextActionType.UpdatePaymentMethod,
                _ => null,
            };
        }
    }
}