
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// To use our templates, pass in one of the enum values.<br/>
    /// Example: Drake Hotline Bling
    /// </summary>
    public enum AiMemeGeneratorCreateImageRequestStyleTemplate
    {
        /// <summary>
        /// 
        /// </summary>
        BikeFall,
        /// <summary>
        /// 
        /// </summary>
        ChangeMyMind,
        /// <summary>
        /// 
        /// </summary>
        DisappointedGuy,
        /// <summary>
        /// 
        /// </summary>
        DrakeHotlineBling,
        /// <summary>
        /// 
        /// </summary>
        GalaxyBrain,
        /// <summary>
        /// 
        /// </summary>
        GrusPlan,
        /// <summary>
        /// 
        /// </summary>
        IsThisAPigeon,
        /// <summary>
        /// 
        /// </summary>
        PanikKalmPanik,
        /// <summary>
        /// 
        /// </summary>
        Random,
        /// <summary>
        /// 
        /// </summary>
        SideEyeingChloe,
        /// <summary>
        /// 
        /// </summary>
        TuxedoWinnieThePooh,
        /// <summary>
        /// 
        /// </summary>
        TwoButtons,
        /// <summary>
        /// 
        /// </summary>
        WaitingSkeleton,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AiMemeGeneratorCreateImageRequestStyleTemplateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiMemeGeneratorCreateImageRequestStyleTemplate value)
        {
            return value switch
            {
                AiMemeGeneratorCreateImageRequestStyleTemplate.BikeFall => "Bike Fall",
                AiMemeGeneratorCreateImageRequestStyleTemplate.ChangeMyMind => "Change My Mind",
                AiMemeGeneratorCreateImageRequestStyleTemplate.DisappointedGuy => "Disappointed Guy",
                AiMemeGeneratorCreateImageRequestStyleTemplate.DrakeHotlineBling => "Drake Hotline Bling",
                AiMemeGeneratorCreateImageRequestStyleTemplate.GalaxyBrain => "Galaxy Brain",
                AiMemeGeneratorCreateImageRequestStyleTemplate.GrusPlan => "Gru's Plan",
                AiMemeGeneratorCreateImageRequestStyleTemplate.IsThisAPigeon => "Is This a Pigeon",
                AiMemeGeneratorCreateImageRequestStyleTemplate.PanikKalmPanik => "Panik Kalm Panik",
                AiMemeGeneratorCreateImageRequestStyleTemplate.Random => "Random",
                AiMemeGeneratorCreateImageRequestStyleTemplate.SideEyeingChloe => "Side Eyeing Chloe",
                AiMemeGeneratorCreateImageRequestStyleTemplate.TuxedoWinnieThePooh => "Tuxedo Winnie The Pooh",
                AiMemeGeneratorCreateImageRequestStyleTemplate.TwoButtons => "Two Buttons",
                AiMemeGeneratorCreateImageRequestStyleTemplate.WaitingSkeleton => "Waiting Skeleton",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiMemeGeneratorCreateImageRequestStyleTemplate? ToEnum(string value)
        {
            return value switch
            {
                "Bike Fall" => AiMemeGeneratorCreateImageRequestStyleTemplate.BikeFall,
                "Change My Mind" => AiMemeGeneratorCreateImageRequestStyleTemplate.ChangeMyMind,
                "Disappointed Guy" => AiMemeGeneratorCreateImageRequestStyleTemplate.DisappointedGuy,
                "Drake Hotline Bling" => AiMemeGeneratorCreateImageRequestStyleTemplate.DrakeHotlineBling,
                "Galaxy Brain" => AiMemeGeneratorCreateImageRequestStyleTemplate.GalaxyBrain,
                "Gru's Plan" => AiMemeGeneratorCreateImageRequestStyleTemplate.GrusPlan,
                "Is This a Pigeon" => AiMemeGeneratorCreateImageRequestStyleTemplate.IsThisAPigeon,
                "Panik Kalm Panik" => AiMemeGeneratorCreateImageRequestStyleTemplate.PanikKalmPanik,
                "Random" => AiMemeGeneratorCreateImageRequestStyleTemplate.Random,
                "Side Eyeing Chloe" => AiMemeGeneratorCreateImageRequestStyleTemplate.SideEyeingChloe,
                "Tuxedo Winnie The Pooh" => AiMemeGeneratorCreateImageRequestStyleTemplate.TuxedoWinnieThePooh,
                "Two Buttons" => AiMemeGeneratorCreateImageRequestStyleTemplate.TwoButtons,
                "Waiting Skeleton" => AiMemeGeneratorCreateImageRequestStyleTemplate.WaitingSkeleton,
                _ => null,
            };
        }
    }
}