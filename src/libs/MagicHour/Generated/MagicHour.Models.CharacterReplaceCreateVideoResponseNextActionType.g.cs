
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum CharacterReplaceCreateVideoResponseNextActionType
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
    public static class CharacterReplaceCreateVideoResponseNextActionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CharacterReplaceCreateVideoResponseNextActionType value)
        {
            return value switch
            {
                CharacterReplaceCreateVideoResponseNextActionType.BuyCredits => "buy_credits",
                CharacterReplaceCreateVideoResponseNextActionType.CheckBalance => "check_balance",
                CharacterReplaceCreateVideoResponseNextActionType.UpdatePaymentMethod => "update_payment_method",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CharacterReplaceCreateVideoResponseNextActionType? ToEnum(string value)
        {
            return value switch
            {
                "buy_credits" => CharacterReplaceCreateVideoResponseNextActionType.BuyCredits,
                "check_balance" => CharacterReplaceCreateVideoResponseNextActionType.CheckBalance,
                "update_payment_method" => CharacterReplaceCreateVideoResponseNextActionType.UpdatePaymentMethod,
                _ => null,
            };
        }
    }
}