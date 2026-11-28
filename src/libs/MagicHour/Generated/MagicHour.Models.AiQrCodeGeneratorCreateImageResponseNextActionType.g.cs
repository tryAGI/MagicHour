
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum AiQrCodeGeneratorCreateImageResponseNextActionType
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
    public static class AiQrCodeGeneratorCreateImageResponseNextActionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiQrCodeGeneratorCreateImageResponseNextActionType value)
        {
            return value switch
            {
                AiQrCodeGeneratorCreateImageResponseNextActionType.BuyCredits => "buy_credits",
                AiQrCodeGeneratorCreateImageResponseNextActionType.CheckBalance => "check_balance",
                AiQrCodeGeneratorCreateImageResponseNextActionType.UpdatePaymentMethod => "update_payment_method",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiQrCodeGeneratorCreateImageResponseNextActionType? ToEnum(string value)
        {
            return value switch
            {
                "buy_credits" => AiQrCodeGeneratorCreateImageResponseNextActionType.BuyCredits,
                "check_balance" => AiQrCodeGeneratorCreateImageResponseNextActionType.CheckBalance,
                "update_payment_method" => AiQrCodeGeneratorCreateImageResponseNextActionType.UpdatePaymentMethod,
                _ => null,
            };
        }
    }
}