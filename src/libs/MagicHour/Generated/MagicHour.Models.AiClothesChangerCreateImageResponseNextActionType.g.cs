
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum AiClothesChangerCreateImageResponseNextActionType
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
    public static class AiClothesChangerCreateImageResponseNextActionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiClothesChangerCreateImageResponseNextActionType value)
        {
            return value switch
            {
                AiClothesChangerCreateImageResponseNextActionType.BuyCredits => "buy_credits",
                AiClothesChangerCreateImageResponseNextActionType.CheckBalance => "check_balance",
                AiClothesChangerCreateImageResponseNextActionType.UpdatePaymentMethod => "update_payment_method",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiClothesChangerCreateImageResponseNextActionType? ToEnum(string value)
        {
            return value switch
            {
                "buy_credits" => AiClothesChangerCreateImageResponseNextActionType.BuyCredits,
                "check_balance" => AiClothesChangerCreateImageResponseNextActionType.CheckBalance,
                "update_payment_method" => AiClothesChangerCreateImageResponseNextActionType.UpdatePaymentMethod,
                _ => null,
            };
        }
    }
}