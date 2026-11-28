
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum CharacterReplaceCreateVideoResponseNextActionReason
    {
        /// <summary>
        ///
        /// </summary>
        AutoReloadPending,
        /// <summary>
        ///
        /// </summary>
        PaymentFailed,
        /// <summary>
        ///
        /// </summary>
        SpendingLimitReached,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CharacterReplaceCreateVideoResponseNextActionReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CharacterReplaceCreateVideoResponseNextActionReason value)
        {
            return value switch
            {
                CharacterReplaceCreateVideoResponseNextActionReason.AutoReloadPending => "auto_reload_pending",
                CharacterReplaceCreateVideoResponseNextActionReason.PaymentFailed => "payment_failed",
                CharacterReplaceCreateVideoResponseNextActionReason.SpendingLimitReached => "spending_limit_reached",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CharacterReplaceCreateVideoResponseNextActionReason? ToEnum(string value)
        {
            return value switch
            {
                "auto_reload_pending" => CharacterReplaceCreateVideoResponseNextActionReason.AutoReloadPending,
                "payment_failed" => CharacterReplaceCreateVideoResponseNextActionReason.PaymentFailed,
                "spending_limit_reached" => CharacterReplaceCreateVideoResponseNextActionReason.SpendingLimitReached,
                _ => null,
            };
        }
    }
}