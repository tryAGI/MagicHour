
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Defaults to kling-3.0 on paid plans and ltx-2.5 on free plans.
    /// </summary>
    public enum AiUgcAdCreateVideoRequestModel
    {
        /// <summary>
        ///
        /// </summary>
        Kling30,
        /// <summary>
        ///
        /// </summary>
        Ltx25,
        /// <summary>
        ///
        /// </summary>
        Veo31,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AiUgcAdCreateVideoRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiUgcAdCreateVideoRequestModel value)
        {
            return value switch
            {
                AiUgcAdCreateVideoRequestModel.Kling30 => "kling-3.0",
                AiUgcAdCreateVideoRequestModel.Ltx25 => "ltx-2.5",
                AiUgcAdCreateVideoRequestModel.Veo31 => "veo3.1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiUgcAdCreateVideoRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "kling-3.0" => AiUgcAdCreateVideoRequestModel.Kling30,
                "ltx-2.5" => AiUgcAdCreateVideoRequestModel.Ltx25,
                "veo3.1" => AiUgcAdCreateVideoRequestModel.Veo31,
                _ => null,
            };
        }
    }
}