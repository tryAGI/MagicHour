
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Optionally add an audio source if you'd like to incorporate audio into your video<br/>
    /// Example: file
    /// </summary>
    public enum AnimationCreateVideoRequestAssetsAudioSource
    {
        /// <summary>
        /// 
        /// </summary>
        File,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Youtube,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnimationCreateVideoRequestAssetsAudioSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnimationCreateVideoRequestAssetsAudioSource value)
        {
            return value switch
            {
                AnimationCreateVideoRequestAssetsAudioSource.File => "file",
                AnimationCreateVideoRequestAssetsAudioSource.None => "none",
                AnimationCreateVideoRequestAssetsAudioSource.Youtube => "youtube",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnimationCreateVideoRequestAssetsAudioSource? ToEnum(string value)
        {
            return value switch
            {
                "file" => AnimationCreateVideoRequestAssetsAudioSource.File,
                "none" => AnimationCreateVideoRequestAssetsAudioSource.None,
                "youtube" => AnimationCreateVideoRequestAssetsAudioSource.Youtube,
                _ => null,
            };
        }
    }
}