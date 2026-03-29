
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Choose how to swap faces:<br/>
    /// **all-faces** (recommended) — swap all detected faces using one source image (`source_file_path` required)<br/>
    /// +- **individual-faces** — specify exact mappings using `face_mappings`<br/>
    /// Default Value: all-faces<br/>
    /// Example: all-faces
    /// </summary>
    public enum FaceSwapCreateVideoRequestAssetsFaceSwapMode
    {
        /// <summary>
        /// 
        /// </summary>
        AllFaces,
        /// <summary>
        /// 
        /// </summary>
        IndividualFaces,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FaceSwapCreateVideoRequestAssetsFaceSwapModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FaceSwapCreateVideoRequestAssetsFaceSwapMode value)
        {
            return value switch
            {
                FaceSwapCreateVideoRequestAssetsFaceSwapMode.AllFaces => "all-faces",
                FaceSwapCreateVideoRequestAssetsFaceSwapMode.IndividualFaces => "individual-faces",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FaceSwapCreateVideoRequestAssetsFaceSwapMode? ToEnum(string value)
        {
            return value switch
            {
                "all-faces" => FaceSwapCreateVideoRequestAssetsFaceSwapMode.AllFaces,
                "individual-faces" => FaceSwapCreateVideoRequestAssetsFaceSwapMode.IndividualFaces,
                _ => null,
            };
        }
    }
}