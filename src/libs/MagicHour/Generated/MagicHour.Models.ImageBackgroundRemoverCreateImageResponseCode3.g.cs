
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Machine-readable error code.<br/>
    /// - `insufficient_credits`: Purchase credits before retrying.<br/>
    /// - `subscription_required`: Start a subscription before retrying.<br/>
    /// - `plan_upgrade_required`: Upgrade the subscription plan before retrying.
    /// </summary>
    public enum ImageBackgroundRemoverCreateImageResponseCode3
    {
        /// <summary>
        /// Purchase credits before retrying.
        /// </summary>
        InsufficientCredits,
        /// <summary>
        /// Upgrade the subscription plan before retrying.
        /// </summary>
        PlanUpgradeRequired,
        /// <summary>
        /// Start a subscription before retrying.
        /// </summary>
        SubscriptionRequired,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageBackgroundRemoverCreateImageResponseCode3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageBackgroundRemoverCreateImageResponseCode3 value)
        {
            return value switch
            {
                ImageBackgroundRemoverCreateImageResponseCode3.InsufficientCredits => "insufficient_credits",
                ImageBackgroundRemoverCreateImageResponseCode3.PlanUpgradeRequired => "plan_upgrade_required",
                ImageBackgroundRemoverCreateImageResponseCode3.SubscriptionRequired => "subscription_required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageBackgroundRemoverCreateImageResponseCode3? ToEnum(string value)
        {
            return value switch
            {
                "insufficient_credits" => ImageBackgroundRemoverCreateImageResponseCode3.InsufficientCredits,
                "plan_upgrade_required" => ImageBackgroundRemoverCreateImageResponseCode3.PlanUpgradeRequired,
                "subscription_required" => ImageBackgroundRemoverCreateImageResponseCode3.SubscriptionRequired,
                _ => null,
            };
        }
    }
}