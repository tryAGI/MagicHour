
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum AiImageEditorCreateImageResponseNextActionType
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
    public static class AiImageEditorCreateImageResponseNextActionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiImageEditorCreateImageResponseNextActionType value)
        {
            return value switch
            {
                AiImageEditorCreateImageResponseNextActionType.BuyCredits => "buy_credits",
                AiImageEditorCreateImageResponseNextActionType.CheckBalance => "check_balance",
                AiImageEditorCreateImageResponseNextActionType.UpdatePaymentMethod => "update_payment_method",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiImageEditorCreateImageResponseNextActionType? ToEnum(string value)
        {
            return value switch
            {
                "buy_credits" => AiImageEditorCreateImageResponseNextActionType.BuyCredits,
                "check_balance" => AiImageEditorCreateImageResponseNextActionType.CheckBalance,
                "update_payment_method" => AiImageEditorCreateImageResponseNextActionType.UpdatePaymentMethod,
                _ => null,
            };
        }
    }
}