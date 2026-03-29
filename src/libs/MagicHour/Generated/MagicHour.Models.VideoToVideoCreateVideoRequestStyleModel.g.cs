
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// * `Dreamshaper` - a good all-around model that works for both animations as well as realism.<br/>
    /// * `Absolute Reality` - better at realism, but you'll often get similar results with Dreamshaper as well.<br/>
    /// * `Flat 2D Anime` - best for a flat illustration style that's common in most anime.<br/>
    /// * `default` - use the default recommended model for the selected art style.<br/>
    /// Default Value: default<br/>
    /// Example: default
    /// </summary>
    public enum VideoToVideoCreateVideoRequestStyleModel
    {
        /// <summary>
        /// 
        /// </summary>
        x3dAnime,
        /// <summary>
        /// 
        /// </summary>
        AbsoluteReality,
        /// <summary>
        /// 
        /// </summary>
        Dreamshaper,
        /// <summary>
        /// 
        /// </summary>
        Flat2dAnime,
        /// <summary>
        /// 
        /// </summary>
        Kaywaii,
        /// <summary>
        /// 
        /// </summary>
        SoftAnime,
        /// <summary>
        /// 
        /// </summary>
        WesternAnime,
        /// <summary>
        /// 
        /// </summary>
        Default,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoToVideoCreateVideoRequestStyleModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoToVideoCreateVideoRequestStyleModel value)
        {
            return value switch
            {
                VideoToVideoCreateVideoRequestStyleModel.x3dAnime => "3D Anime",
                VideoToVideoCreateVideoRequestStyleModel.AbsoluteReality => "Absolute Reality",
                VideoToVideoCreateVideoRequestStyleModel.Dreamshaper => "Dreamshaper",
                VideoToVideoCreateVideoRequestStyleModel.Flat2dAnime => "Flat 2D Anime",
                VideoToVideoCreateVideoRequestStyleModel.Kaywaii => "Kaywaii",
                VideoToVideoCreateVideoRequestStyleModel.SoftAnime => "Soft Anime",
                VideoToVideoCreateVideoRequestStyleModel.WesternAnime => "Western Anime",
                VideoToVideoCreateVideoRequestStyleModel.Default => "default",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoToVideoCreateVideoRequestStyleModel? ToEnum(string value)
        {
            return value switch
            {
                "3D Anime" => VideoToVideoCreateVideoRequestStyleModel.x3dAnime,
                "Absolute Reality" => VideoToVideoCreateVideoRequestStyleModel.AbsoluteReality,
                "Dreamshaper" => VideoToVideoCreateVideoRequestStyleModel.Dreamshaper,
                "Flat 2D Anime" => VideoToVideoCreateVideoRequestStyleModel.Flat2dAnime,
                "Kaywaii" => VideoToVideoCreateVideoRequestStyleModel.Kaywaii,
                "Soft Anime" => VideoToVideoCreateVideoRequestStyleModel.SoftAnime,
                "Western Anime" => VideoToVideoCreateVideoRequestStyleModel.WesternAnime,
                "default" => VideoToVideoCreateVideoRequestStyleModel.Default,
                _ => null,
            };
        }
    }
}