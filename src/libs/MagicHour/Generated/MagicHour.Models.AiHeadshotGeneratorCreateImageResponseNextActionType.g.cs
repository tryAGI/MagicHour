
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum AiHeadshotGeneratorCreateImageResponseNextActionType
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
    public static class AiHeadshotGeneratorCreateImageResponseNextActionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiHeadshotGeneratorCreateImageResponseNextActionType value)
        {
            return value switch
            {
                AiHeadshotGeneratorCreateImageResponseNextActionType.BuyCredits => "buy_credits",
                AiHeadshotGeneratorCreateImageResponseNextActionType.CheckBalance => "check_balance",
                AiHeadshotGeneratorCreateImageResponseNextActionType.UpdatePaymentMethod => "update_payment_method",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiHeadshotGeneratorCreateImageResponseNextActionType? ToEnum(string value)
        {
            return value switch
            {
                "buy_credits" => AiHeadshotGeneratorCreateImageResponseNextActionType.BuyCredits,
                "check_balance" => AiHeadshotGeneratorCreateImageResponseNextActionType.CheckBalance,
                "update_payment_method" => AiHeadshotGeneratorCreateImageResponseNextActionType.UpdatePaymentMethod,
                _ => null,
            };
        }
    }
}