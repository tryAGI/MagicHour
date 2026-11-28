
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum AiFaceEditorEditImageResponseNextActionType
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
    public static class AiFaceEditorEditImageResponseNextActionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiFaceEditorEditImageResponseNextActionType value)
        {
            return value switch
            {
                AiFaceEditorEditImageResponseNextActionType.BuyCredits => "buy_credits",
                AiFaceEditorEditImageResponseNextActionType.CheckBalance => "check_balance",
                AiFaceEditorEditImageResponseNextActionType.UpdatePaymentMethod => "update_payment_method",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiFaceEditorEditImageResponseNextActionType? ToEnum(string value)
        {
            return value switch
            {
                "buy_credits" => AiFaceEditorEditImageResponseNextActionType.BuyCredits,
                "check_balance" => AiFaceEditorEditImageResponseNextActionType.CheckBalance,
                "update_payment_method" => AiFaceEditorEditImageResponseNextActionType.UpdatePaymentMethod,
                _ => null,
            };
        }
    }
}