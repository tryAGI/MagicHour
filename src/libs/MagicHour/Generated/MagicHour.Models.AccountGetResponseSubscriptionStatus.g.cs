
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Status of the subscription.<br/>
    /// - `active`: payments are up to date.<br/>
    /// - `past_due`: the latest payment failed. `tier` is `free` until payment succeeds. The subscription is canceled if payment keeps failing.<br/>
    /// Example: active
    /// </summary>
    public enum AccountGetResponseSubscriptionStatus
    {
        /// <summary>
        /// payments are up to date.
        /// </summary>
        Active,
        /// <summary>
        /// the latest payment failed. `tier` is `free` until payment succeeds. The subscription is canceled if payment keeps failing.
        /// </summary>
        PastDue,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AccountGetResponseSubscriptionStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AccountGetResponseSubscriptionStatus value)
        {
            return value switch
            {
                AccountGetResponseSubscriptionStatus.Active => "active",
                AccountGetResponseSubscriptionStatus.PastDue => "past_due",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AccountGetResponseSubscriptionStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => AccountGetResponseSubscriptionStatus.Active,
                "past_due" => AccountGetResponseSubscriptionStatus.PastDue,
                _ => null,
            };
        }
    }
}