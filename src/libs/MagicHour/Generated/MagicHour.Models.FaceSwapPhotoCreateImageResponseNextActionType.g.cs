
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum FaceSwapPhotoCreateImageResponseNextActionType
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
    public static class FaceSwapPhotoCreateImageResponseNextActionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FaceSwapPhotoCreateImageResponseNextActionType value)
        {
            return value switch
            {
                FaceSwapPhotoCreateImageResponseNextActionType.BuyCredits => "buy_credits",
                FaceSwapPhotoCreateImageResponseNextActionType.CheckBalance => "check_balance",
                FaceSwapPhotoCreateImageResponseNextActionType.UpdatePaymentMethod => "update_payment_method",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FaceSwapPhotoCreateImageResponseNextActionType? ToEnum(string value)
        {
            return value switch
            {
                "buy_credits" => FaceSwapPhotoCreateImageResponseNextActionType.BuyCredits,
                "check_balance" => FaceSwapPhotoCreateImageResponseNextActionType.CheckBalance,
                "update_payment_method" => FaceSwapPhotoCreateImageResponseNextActionType.UpdatePaymentMethod,
                _ => null,
            };
        }
    }
}