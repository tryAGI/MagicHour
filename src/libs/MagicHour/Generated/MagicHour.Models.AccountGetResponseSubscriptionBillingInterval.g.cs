
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// How often the subscription is billed. `null` if unknown.<br/>
    /// Example: month
    /// </summary>
    public enum AccountGetResponseSubscriptionBillingInterval
    {
        /// <summary>
        ///
        /// </summary>
        Month,
        /// <summary>
        ///
        /// </summary>
        Year,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AccountGetResponseSubscriptionBillingIntervalExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AccountGetResponseSubscriptionBillingInterval value)
        {
            return value switch
            {
                AccountGetResponseSubscriptionBillingInterval.Month => "month",
                AccountGetResponseSubscriptionBillingInterval.Year => "year",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AccountGetResponseSubscriptionBillingInterval? ToEnum(string value)
        {
            return value switch
            {
                "month" => AccountGetResponseSubscriptionBillingInterval.Month,
                "year" => AccountGetResponseSubscriptionBillingInterval.Year,
                _ => null,
            };
        }
    }
}