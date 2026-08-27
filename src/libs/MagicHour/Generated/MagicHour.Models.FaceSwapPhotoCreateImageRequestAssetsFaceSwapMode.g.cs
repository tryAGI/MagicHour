
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
    public enum FaceSwapPhotoCreateImageRequestAssetsFaceSwapMode
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
    public static class FaceSwapPhotoCreateImageRequestAssetsFaceSwapModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FaceSwapPhotoCreateImageRequestAssetsFaceSwapMode value)
        {
            return value switch
            {
                FaceSwapPhotoCreateImageRequestAssetsFaceSwapMode.AllFaces => "all-faces",
                FaceSwapPhotoCreateImageRequestAssetsFaceSwapMode.IndividualFaces => "individual-faces",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FaceSwapPhotoCreateImageRequestAssetsFaceSwapMode? ToEnum(string value)
        {
            return value switch
            {
                "all-faces" => FaceSwapPhotoCreateImageRequestAssetsFaceSwapMode.AllFaces,
                "individual-faces" => FaceSwapPhotoCreateImageRequestAssetsFaceSwapMode.IndividualFaces,
                _ => null,
            };
        }
    }
}