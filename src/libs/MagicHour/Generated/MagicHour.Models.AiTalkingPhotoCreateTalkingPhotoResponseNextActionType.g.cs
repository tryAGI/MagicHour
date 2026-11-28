
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum AiTalkingPhotoCreateTalkingPhotoResponseNextActionType
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
    public static class AiTalkingPhotoCreateTalkingPhotoResponseNextActionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiTalkingPhotoCreateTalkingPhotoResponseNextActionType value)
        {
            return value switch
            {
                AiTalkingPhotoCreateTalkingPhotoResponseNextActionType.BuyCredits => "buy_credits",
                AiTalkingPhotoCreateTalkingPhotoResponseNextActionType.CheckBalance => "check_balance",
                AiTalkingPhotoCreateTalkingPhotoResponseNextActionType.UpdatePaymentMethod => "update_payment_method",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiTalkingPhotoCreateTalkingPhotoResponseNextActionType? ToEnum(string value)
        {
            return value switch
            {
                "buy_credits" => AiTalkingPhotoCreateTalkingPhotoResponseNextActionType.BuyCredits,
                "check_balance" => AiTalkingPhotoCreateTalkingPhotoResponseNextActionType.CheckBalance,
                "update_payment_method" => AiTalkingPhotoCreateTalkingPhotoResponseNextActionType.UpdatePaymentMethod,
                _ => null,
            };
        }
    }
}