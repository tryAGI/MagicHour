
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum FaceDetectionDetectFacesResponseNextActionType
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
    public static class FaceDetectionDetectFacesResponseNextActionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FaceDetectionDetectFacesResponseNextActionType value)
        {
            return value switch
            {
                FaceDetectionDetectFacesResponseNextActionType.BuyCredits => "buy_credits",
                FaceDetectionDetectFacesResponseNextActionType.CheckBalance => "check_balance",
                FaceDetectionDetectFacesResponseNextActionType.UpdatePaymentMethod => "update_payment_method",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FaceDetectionDetectFacesResponseNextActionType? ToEnum(string value)
        {
            return value switch
            {
                "buy_credits" => FaceDetectionDetectFacesResponseNextActionType.BuyCredits,
                "check_balance" => FaceDetectionDetectFacesResponseNextActionType.CheckBalance,
                "update_payment_method" => FaceDetectionDetectFacesResponseNextActionType.UpdatePaymentMethod,
                _ => null,
            };
        }
    }
}