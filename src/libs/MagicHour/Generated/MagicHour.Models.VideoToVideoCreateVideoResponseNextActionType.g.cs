
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum VideoToVideoCreateVideoResponseNextActionType
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
    public static class VideoToVideoCreateVideoResponseNextActionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoToVideoCreateVideoResponseNextActionType value)
        {
            return value switch
            {
                VideoToVideoCreateVideoResponseNextActionType.BuyCredits => "buy_credits",
                VideoToVideoCreateVideoResponseNextActionType.CheckBalance => "check_balance",
                VideoToVideoCreateVideoResponseNextActionType.UpdatePaymentMethod => "update_payment_method",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoToVideoCreateVideoResponseNextActionType? ToEnum(string value)
        {
            return value switch
            {
                "buy_credits" => VideoToVideoCreateVideoResponseNextActionType.BuyCredits,
                "check_balance" => VideoToVideoCreateVideoResponseNextActionType.CheckBalance,
                "update_payment_method" => VideoToVideoCreateVideoResponseNextActionType.UpdatePaymentMethod,
                _ => null,
            };
        }
    }
}