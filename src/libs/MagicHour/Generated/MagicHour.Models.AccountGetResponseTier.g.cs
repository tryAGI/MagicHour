
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Subscription tier in effect for the account. `free` if there is no active subscription, including while a subscription is `past_due`.<br/>
    /// Example: pro
    /// </summary>
    public enum AccountGetResponseTier
    {
        /// <summary>
        ///
        /// </summary>
        Business,
        /// <summary>
        ///
        /// </summary>
        Creator,
        /// <summary>
        ///
        /// </summary>
        Free,
        /// <summary>
        ///
        /// </summary>
        Pro,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AccountGetResponseTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AccountGetResponseTier value)
        {
            return value switch
            {
                AccountGetResponseTier.Business => "business",
                AccountGetResponseTier.Creator => "creator",
                AccountGetResponseTier.Free => "free",
                AccountGetResponseTier.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AccountGetResponseTier? ToEnum(string value)
        {
            return value switch
            {
                "business" => AccountGetResponseTier.Business,
                "creator" => AccountGetResponseTier.Creator,
                "free" => AccountGetResponseTier.Free,
                "pro" => AccountGetResponseTier.Pro,
                _ => null,
            };
        }
    }
}