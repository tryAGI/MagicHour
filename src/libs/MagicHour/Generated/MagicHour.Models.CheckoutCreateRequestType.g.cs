
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// What to buy. `credit_pack` is a one-time credit purchase.
    /// </summary>
    public enum CheckoutCreateRequestType
    {
        /// <summary>
        ///
        /// </summary>
        CreditPack,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CheckoutCreateRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CheckoutCreateRequestType value)
        {
            return value switch
            {
                CheckoutCreateRequestType.CreditPack => "credit_pack",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CheckoutCreateRequestType? ToEnum(string value)
        {
            return value switch
            {
                "credit_pack" => CheckoutCreateRequestType.CreditPack,
                _ => null,
            };
        }
    }
}