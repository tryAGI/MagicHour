
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoAssetsGeneratePresignedUrlRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::MagicHour.VideoAssetsGeneratePresignedUrlRequestItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoAssetsGeneratePresignedUrlRequestItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoAssetsGeneratePresignedUrlRequestItemType), TypeInfoPropertyName = "VideoAssetsGeneratePresignedUrlRequestItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceDetectionDetectFacesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceDetectionDetectFacesRequestAssets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiTalkingPhotoCreateTalkingPhotoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiTalkingPhotoCreateTalkingPhotoRequestAssets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiTalkingPhotoCreateTalkingPhotoRequestStyle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiTalkingPhotoCreateTalkingPhotoRequestStyleGenerationMode), TypeInfoPropertyName = "AiTalkingPhotoCreateTalkingPhotoRequestStyleGenerationMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVideoEditorCreateVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVideoEditorCreateVideoRequestModel), TypeInfoPropertyName = "AiVideoEditorCreateVideoRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVideoEditorCreateVideoRequestResolution), TypeInfoPropertyName = "AiVideoEditorCreateVideoRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVideoEditorCreateVideoRequestStyle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVideoEditorCreateVideoRequestAssets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AnimationCreateVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AnimationCreateVideoRequestStyle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AnimationCreateVideoRequestStyleArtStyle), TypeInfoPropertyName = "AnimationCreateVideoRequestStyleArtStyle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AnimationCreateVideoRequestStyleCameraEffect), TypeInfoPropertyName = "AnimationCreateVideoRequestStyleCameraEffect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AnimationCreateVideoRequestStylePromptType), TypeInfoPropertyName = "AnimationCreateVideoRequestStylePromptType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AnimationCreateVideoRequestAssets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AnimationCreateVideoRequestAssetsAudioSource), TypeInfoPropertyName = "AnimationCreateVideoRequestAssetsAudioSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioToVideoCreateVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioToVideoCreateVideoRequestResolution), TypeInfoPropertyName = "AudioToVideoCreateVideoRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioToVideoCreateVideoRequestAssets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioToVideoCreateVideoRequestStyle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AutoSubtitleGeneratorCreateVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AutoSubtitleGeneratorCreateVideoRequestAssets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AutoSubtitleGeneratorCreateVideoRequestStyle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AutoSubtitleGeneratorCreateVideoRequestStyleTemplate), TypeInfoPropertyName = "AutoSubtitleGeneratorCreateVideoRequestStyleTemplate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AutoSubtitleGeneratorCreateVideoRequestStyleCustomConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.CharacterReplaceCreateVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.CharacterReplaceCreateVideoRequestResolution), TypeInfoPropertyName = "CharacterReplaceCreateVideoRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.CharacterReplaceCreateVideoRequestAssets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.CharacterReplaceCreateVideoRequestStyle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.CharacterReplaceCreateVideoRequestStyleMode), TypeInfoPropertyName = "CharacterReplaceCreateVideoRequestStyleMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.CharacterReplaceCreateVideoRequestStyleSelectionMode), TypeInfoPropertyName = "CharacterReplaceCreateVideoRequestStyleSelectionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::MagicHour.CharacterReplaceCreateVideoRequestStylePoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.CharacterReplaceCreateVideoRequestStylePoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceSwapCreateVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceSwapCreateVideoRequestStyle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceSwapCreateVideoRequestStyleVersion), TypeInfoPropertyName = "FaceSwapCreateVideoRequestStyleVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceSwapCreateVideoRequestAssets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceSwapCreateVideoRequestAssetsFaceSwapMode), TypeInfoPropertyName = "FaceSwapCreateVideoRequestAssetsFaceSwapMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::MagicHour.FaceSwapCreateVideoRequestAssetsFaceMapping>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceSwapCreateVideoRequestAssetsFaceMapping))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceSwapCreateVideoRequestAssetsVideoSource), TypeInfoPropertyName = "FaceSwapCreateVideoRequestAssetsVideoSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageToVideoCreateVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageToVideoCreateVideoRequestModel), TypeInfoPropertyName = "ImageToVideoCreateVideoRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageToVideoCreateVideoRequestResolution), TypeInfoPropertyName = "ImageToVideoCreateVideoRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageToVideoCreateVideoRequestStyle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageToVideoCreateVideoRequestAssets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.LipSyncCreateVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.LipSyncCreateVideoRequestAssets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.LipSyncCreateVideoRequestAssetsVideoSource), TypeInfoPropertyName = "LipSyncCreateVideoRequestAssetsVideoSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.LipSyncCreateVideoRequestStyle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.LipSyncCreateVideoRequestStyleGenerationMode), TypeInfoPropertyName = "LipSyncCreateVideoRequestStyleGenerationMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.TextToVideoCreateVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.TextToVideoCreateVideoRequestAspectRatio), TypeInfoPropertyName = "TextToVideoCreateVideoRequestAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.TextToVideoCreateVideoRequestResolution), TypeInfoPropertyName = "TextToVideoCreateVideoRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.TextToVideoCreateVideoRequestModel), TypeInfoPropertyName = "TextToVideoCreateVideoRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.TextToVideoCreateVideoRequestStyle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoToVideoCreateVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoToVideoCreateVideoRequestFpsResolution), TypeInfoPropertyName = "VideoToVideoCreateVideoRequestFpsResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoToVideoCreateVideoRequestStyle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoToVideoCreateVideoRequestStyleArtStyle), TypeInfoPropertyName = "VideoToVideoCreateVideoRequestStyleArtStyle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoToVideoCreateVideoRequestStyleVersion), TypeInfoPropertyName = "VideoToVideoCreateVideoRequestStyleVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoToVideoCreateVideoRequestStylePromptType), TypeInfoPropertyName = "VideoToVideoCreateVideoRequestStylePromptType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoToVideoCreateVideoRequestStyleModel), TypeInfoPropertyName = "VideoToVideoCreateVideoRequestStyleModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoToVideoCreateVideoRequestAssets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoToVideoCreateVideoRequestAssetsVideoSource), TypeInfoPropertyName = "VideoToVideoCreateVideoRequestAssetsVideoSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiClothesChangerCreateImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiClothesChangerCreateImageRequestAssets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiClothesChangerCreateImageRequestAssetsGarmentType), TypeInfoPropertyName = "AiClothesChangerCreateImageRequestAssetsGarmentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiFaceEditorEditImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiFaceEditorEditImageRequestAssets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiFaceEditorEditImageRequestStyle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiGifGeneratorCreateImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiGifGeneratorCreateImageRequestStyle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiGifGeneratorCreateImageRequestOutputFormat), TypeInfoPropertyName = "AiGifGeneratorCreateImageRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageEditorCreateImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageEditorCreateImageRequestModel), TypeInfoPropertyName = "AiImageEditorCreateImageRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageEditorCreateImageRequestAspectRatio), TypeInfoPropertyName = "AiImageEditorCreateImageRequestAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageEditorCreateImageRequestResolution), TypeInfoPropertyName = "AiImageEditorCreateImageRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageEditorCreateImageRequestStyle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageEditorCreateImageRequestAssets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiHeadshotGeneratorCreateImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiHeadshotGeneratorCreateImageRequestStyle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiHeadshotGeneratorCreateImageRequestAssets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageGeneratorCreateImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageGeneratorCreateImageRequestModel), TypeInfoPropertyName = "AiImageGeneratorCreateImageRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageGeneratorCreateImageRequestAspectRatio), TypeInfoPropertyName = "AiImageGeneratorCreateImageRequestAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageGeneratorCreateImageRequestResolution), TypeInfoPropertyName = "AiImageGeneratorCreateImageRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageGeneratorCreateImageRequestStyle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageGeneratorCreateImageRequestStyleTool), TypeInfoPropertyName = "AiImageGeneratorCreateImageRequestStyleTool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageUpscalerCreateImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageUpscalerCreateImageRequestStyle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageUpscalerCreateImageRequestStyleMode), TypeInfoPropertyName = "AiImageUpscalerCreateImageRequestStyleMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageUpscalerCreateImageRequestAssets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiMemeGeneratorCreateImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiMemeGeneratorCreateImageRequestStyle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiMemeGeneratorCreateImageRequestStyleTemplate), TypeInfoPropertyName = "AiMemeGeneratorCreateImageRequestStyleTemplate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiQrCodeGeneratorCreateImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiQrCodeGeneratorCreateImageRequestStyle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.BodySwapCreateImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.BodySwapCreateImageRequestResolution), TypeInfoPropertyName = "BodySwapCreateImageRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.BodySwapCreateImageRequestAssets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceSwapPhotoCreateImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceSwapPhotoCreateImageRequestAssets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceSwapPhotoCreateImageRequestAssetsFaceSwapMode), TypeInfoPropertyName = "FaceSwapPhotoCreateImageRequestAssetsFaceSwapMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::MagicHour.FaceSwapPhotoCreateImageRequestAssetsFaceMapping>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceSwapPhotoCreateImageRequestAssetsFaceMapping))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.HeadSwapCreateImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.HeadSwapCreateImageRequestAssets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageBackgroundRemoverCreateImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageBackgroundRemoverCreateImageRequestAssets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.PhotoColorizerCreateImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.PhotoColorizerCreateImageRequestAssets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVoiceGeneratorCreateAudioRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVoiceGeneratorCreateAudioRequestStyle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVoiceGeneratorCreateAudioRequestStyleVoiceName), TypeInfoPropertyName = "AiVoiceGeneratorCreateAudioRequestStyleVoiceName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVoiceClonerCreateAudioRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVoiceClonerCreateAudioRequestAssets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVoiceClonerCreateAudioRequestStyle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoAssetsGeneratePresignedUrlResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::MagicHour.VideoAssetsGeneratePresignedUrlResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoAssetsGeneratePresignedUrlResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoAssetsGeneratePresignedUrlResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoAssetsGeneratePresignedUrlResponseCode), TypeInfoPropertyName = "VideoAssetsGeneratePresignedUrlResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoAssetsGeneratePresignedUrlResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoAssetsGeneratePresignedUrlResponseCode2), TypeInfoPropertyName = "VideoAssetsGeneratePresignedUrlResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoAssetsGeneratePresignedUrlResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoAssetsGeneratePresignedUrlResponseCode3), TypeInfoPropertyName = "VideoAssetsGeneratePresignedUrlResponseCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoAssetsGeneratePresignedUrlResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoAssetsGeneratePresignedUrlResponseCode4), TypeInfoPropertyName = "VideoAssetsGeneratePresignedUrlResponseCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoAssetsGeneratePresignedUrlResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoAssetsGeneratePresignedUrlResponseCode5), TypeInfoPropertyName = "VideoAssetsGeneratePresignedUrlResponseCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoAssetsGeneratePresignedUrlResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoAssetsGeneratePresignedUrlResponseCode6), TypeInfoPropertyName = "VideoAssetsGeneratePresignedUrlResponseCode62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceDetectionGetDetailsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceDetectionGetDetailsResponseStatus), TypeInfoPropertyName = "FaceDetectionGetDetailsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::MagicHour.FaceDetectionGetDetailsResponseFace>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceDetectionGetDetailsResponseFace))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceDetectionGetDetailsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceDetectionGetDetailsResponseCode), TypeInfoPropertyName = "FaceDetectionGetDetailsResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceDetectionGetDetailsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceDetectionGetDetailsResponseCode2), TypeInfoPropertyName = "FaceDetectionGetDetailsResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceDetectionGetDetailsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceDetectionGetDetailsResponseCode3), TypeInfoPropertyName = "FaceDetectionGetDetailsResponseCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceDetectionGetDetailsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceDetectionGetDetailsResponseCode4), TypeInfoPropertyName = "FaceDetectionGetDetailsResponseCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceDetectionGetDetailsResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceDetectionGetDetailsResponseCode5), TypeInfoPropertyName = "FaceDetectionGetDetailsResponseCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceDetectionGetDetailsResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceDetectionGetDetailsResponseCode6), TypeInfoPropertyName = "FaceDetectionGetDetailsResponseCode62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceDetectionDetectFacesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceDetectionDetectFacesResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceDetectionDetectFacesResponseCode), TypeInfoPropertyName = "FaceDetectionDetectFacesResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceDetectionDetectFacesResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceDetectionDetectFacesResponseCode2), TypeInfoPropertyName = "FaceDetectionDetectFacesResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceDetectionDetectFacesResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceDetectionDetectFacesResponseCode3), TypeInfoPropertyName = "FaceDetectionDetectFacesResponseCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceDetectionDetectFacesResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceDetectionDetectFacesResponseCode4), TypeInfoPropertyName = "FaceDetectionDetectFacesResponseCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceDetectionDetectFacesResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceDetectionDetectFacesResponseCode5), TypeInfoPropertyName = "FaceDetectionDetectFacesResponseCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceDetectionDetectFacesResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceDetectionDetectFacesResponseCode6), TypeInfoPropertyName = "FaceDetectionDetectFacesResponseCode62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoProjectsGetDetailsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoProjectsGetDetailsResponseStatus), TypeInfoPropertyName = "VideoProjectsGetDetailsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoProjectsGetDetailsResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::MagicHour.VideoProjectsGetDetailsResponseDownload>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoProjectsGetDetailsResponseDownload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoProjectsGetDetailsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoProjectsGetDetailsResponseCode), TypeInfoPropertyName = "VideoProjectsGetDetailsResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoProjectsGetDetailsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoProjectsGetDetailsResponseCode2), TypeInfoPropertyName = "VideoProjectsGetDetailsResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoProjectsGetDetailsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoProjectsGetDetailsResponseCode3), TypeInfoPropertyName = "VideoProjectsGetDetailsResponseCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoProjectsGetDetailsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoProjectsGetDetailsResponseCode4), TypeInfoPropertyName = "VideoProjectsGetDetailsResponseCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoProjectsGetDetailsResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoProjectsGetDetailsResponseCode5), TypeInfoPropertyName = "VideoProjectsGetDetailsResponseCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoProjectsDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoProjectsDeleteResponseCode), TypeInfoPropertyName = "VideoProjectsDeleteResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoProjectsDeleteResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoProjectsDeleteResponseCode2), TypeInfoPropertyName = "VideoProjectsDeleteResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoProjectsDeleteResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoProjectsDeleteResponseCode3), TypeInfoPropertyName = "VideoProjectsDeleteResponseCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoProjectsDeleteResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoProjectsDeleteResponseCode4), TypeInfoPropertyName = "VideoProjectsDeleteResponseCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoProjectsDeleteResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoProjectsDeleteResponseCode5), TypeInfoPropertyName = "VideoProjectsDeleteResponseCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoProjectsDeleteResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoProjectsDeleteResponseCode6), TypeInfoPropertyName = "VideoProjectsDeleteResponseCode62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponseCode), TypeInfoPropertyName = "AiTalkingPhotoCreateTalkingPhotoResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponseCode2), TypeInfoPropertyName = "AiTalkingPhotoCreateTalkingPhotoResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponseCode3), TypeInfoPropertyName = "AiTalkingPhotoCreateTalkingPhotoResponseCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponseCode4), TypeInfoPropertyName = "AiTalkingPhotoCreateTalkingPhotoResponseCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponseCode5), TypeInfoPropertyName = "AiTalkingPhotoCreateTalkingPhotoResponseCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponseCode6), TypeInfoPropertyName = "AiTalkingPhotoCreateTalkingPhotoResponseCode62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVideoEditorCreateVideoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVideoEditorCreateVideoResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVideoEditorCreateVideoResponseCode), TypeInfoPropertyName = "AiVideoEditorCreateVideoResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVideoEditorCreateVideoResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVideoEditorCreateVideoResponseCode2), TypeInfoPropertyName = "AiVideoEditorCreateVideoResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVideoEditorCreateVideoResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVideoEditorCreateVideoResponseCode3), TypeInfoPropertyName = "AiVideoEditorCreateVideoResponseCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVideoEditorCreateVideoResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVideoEditorCreateVideoResponseCode4), TypeInfoPropertyName = "AiVideoEditorCreateVideoResponseCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVideoEditorCreateVideoResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVideoEditorCreateVideoResponseCode5), TypeInfoPropertyName = "AiVideoEditorCreateVideoResponseCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVideoEditorCreateVideoResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVideoEditorCreateVideoResponseCode6), TypeInfoPropertyName = "AiVideoEditorCreateVideoResponseCode62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AnimationCreateVideoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AnimationCreateVideoResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AnimationCreateVideoResponseCode), TypeInfoPropertyName = "AnimationCreateVideoResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AnimationCreateVideoResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AnimationCreateVideoResponseCode2), TypeInfoPropertyName = "AnimationCreateVideoResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AnimationCreateVideoResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AnimationCreateVideoResponseCode3), TypeInfoPropertyName = "AnimationCreateVideoResponseCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AnimationCreateVideoResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AnimationCreateVideoResponseCode4), TypeInfoPropertyName = "AnimationCreateVideoResponseCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AnimationCreateVideoResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AnimationCreateVideoResponseCode5), TypeInfoPropertyName = "AnimationCreateVideoResponseCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AnimationCreateVideoResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AnimationCreateVideoResponseCode6), TypeInfoPropertyName = "AnimationCreateVideoResponseCode62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioToVideoCreateVideoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioToVideoCreateVideoResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioToVideoCreateVideoResponseCode), TypeInfoPropertyName = "AudioToVideoCreateVideoResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioToVideoCreateVideoResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioToVideoCreateVideoResponseCode2), TypeInfoPropertyName = "AudioToVideoCreateVideoResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioToVideoCreateVideoResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioToVideoCreateVideoResponseCode3), TypeInfoPropertyName = "AudioToVideoCreateVideoResponseCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioToVideoCreateVideoResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioToVideoCreateVideoResponseCode4), TypeInfoPropertyName = "AudioToVideoCreateVideoResponseCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioToVideoCreateVideoResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioToVideoCreateVideoResponseCode5), TypeInfoPropertyName = "AudioToVideoCreateVideoResponseCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioToVideoCreateVideoResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioToVideoCreateVideoResponseCode6), TypeInfoPropertyName = "AudioToVideoCreateVideoResponseCode62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AutoSubtitleGeneratorCreateVideoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AutoSubtitleGeneratorCreateVideoResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AutoSubtitleGeneratorCreateVideoResponseCode), TypeInfoPropertyName = "AutoSubtitleGeneratorCreateVideoResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AutoSubtitleGeneratorCreateVideoResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AutoSubtitleGeneratorCreateVideoResponseCode2), TypeInfoPropertyName = "AutoSubtitleGeneratorCreateVideoResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AutoSubtitleGeneratorCreateVideoResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AutoSubtitleGeneratorCreateVideoResponseCode3), TypeInfoPropertyName = "AutoSubtitleGeneratorCreateVideoResponseCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AutoSubtitleGeneratorCreateVideoResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AutoSubtitleGeneratorCreateVideoResponseCode4), TypeInfoPropertyName = "AutoSubtitleGeneratorCreateVideoResponseCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AutoSubtitleGeneratorCreateVideoResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AutoSubtitleGeneratorCreateVideoResponseCode5), TypeInfoPropertyName = "AutoSubtitleGeneratorCreateVideoResponseCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AutoSubtitleGeneratorCreateVideoResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AutoSubtitleGeneratorCreateVideoResponseCode6), TypeInfoPropertyName = "AutoSubtitleGeneratorCreateVideoResponseCode62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.CharacterReplaceCreateVideoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.CharacterReplaceCreateVideoResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.CharacterReplaceCreateVideoResponseCode), TypeInfoPropertyName = "CharacterReplaceCreateVideoResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.CharacterReplaceCreateVideoResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.CharacterReplaceCreateVideoResponseCode2), TypeInfoPropertyName = "CharacterReplaceCreateVideoResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.CharacterReplaceCreateVideoResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.CharacterReplaceCreateVideoResponseCode3), TypeInfoPropertyName = "CharacterReplaceCreateVideoResponseCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.CharacterReplaceCreateVideoResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.CharacterReplaceCreateVideoResponseCode4), TypeInfoPropertyName = "CharacterReplaceCreateVideoResponseCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.CharacterReplaceCreateVideoResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.CharacterReplaceCreateVideoResponseCode5), TypeInfoPropertyName = "CharacterReplaceCreateVideoResponseCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.CharacterReplaceCreateVideoResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.CharacterReplaceCreateVideoResponseCode6), TypeInfoPropertyName = "CharacterReplaceCreateVideoResponseCode62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceSwapCreateVideoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceSwapCreateVideoResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceSwapCreateVideoResponseCode), TypeInfoPropertyName = "FaceSwapCreateVideoResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceSwapCreateVideoResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceSwapCreateVideoResponseCode2), TypeInfoPropertyName = "FaceSwapCreateVideoResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceSwapCreateVideoResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceSwapCreateVideoResponseCode3), TypeInfoPropertyName = "FaceSwapCreateVideoResponseCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceSwapCreateVideoResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceSwapCreateVideoResponseCode4), TypeInfoPropertyName = "FaceSwapCreateVideoResponseCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceSwapCreateVideoResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceSwapCreateVideoResponseCode5), TypeInfoPropertyName = "FaceSwapCreateVideoResponseCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceSwapCreateVideoResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceSwapCreateVideoResponseCode6), TypeInfoPropertyName = "FaceSwapCreateVideoResponseCode62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageToVideoCreateVideoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageToVideoCreateVideoResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageToVideoCreateVideoResponseCode), TypeInfoPropertyName = "ImageToVideoCreateVideoResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageToVideoCreateVideoResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageToVideoCreateVideoResponseCode2), TypeInfoPropertyName = "ImageToVideoCreateVideoResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageToVideoCreateVideoResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageToVideoCreateVideoResponseCode3), TypeInfoPropertyName = "ImageToVideoCreateVideoResponseCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageToVideoCreateVideoResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageToVideoCreateVideoResponseCode4), TypeInfoPropertyName = "ImageToVideoCreateVideoResponseCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageToVideoCreateVideoResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageToVideoCreateVideoResponseCode5), TypeInfoPropertyName = "ImageToVideoCreateVideoResponseCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageToVideoCreateVideoResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageToVideoCreateVideoResponseCode6), TypeInfoPropertyName = "ImageToVideoCreateVideoResponseCode62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.LipSyncCreateVideoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.LipSyncCreateVideoResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.LipSyncCreateVideoResponseCode), TypeInfoPropertyName = "LipSyncCreateVideoResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.LipSyncCreateVideoResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.LipSyncCreateVideoResponseCode2), TypeInfoPropertyName = "LipSyncCreateVideoResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.LipSyncCreateVideoResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.LipSyncCreateVideoResponseCode3), TypeInfoPropertyName = "LipSyncCreateVideoResponseCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.LipSyncCreateVideoResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.LipSyncCreateVideoResponseCode4), TypeInfoPropertyName = "LipSyncCreateVideoResponseCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.LipSyncCreateVideoResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.LipSyncCreateVideoResponseCode5), TypeInfoPropertyName = "LipSyncCreateVideoResponseCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.LipSyncCreateVideoResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.LipSyncCreateVideoResponseCode6), TypeInfoPropertyName = "LipSyncCreateVideoResponseCode62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.TextToVideoCreateVideoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.TextToVideoCreateVideoResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.TextToVideoCreateVideoResponseCode), TypeInfoPropertyName = "TextToVideoCreateVideoResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.TextToVideoCreateVideoResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.TextToVideoCreateVideoResponseCode2), TypeInfoPropertyName = "TextToVideoCreateVideoResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.TextToVideoCreateVideoResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.TextToVideoCreateVideoResponseCode3), TypeInfoPropertyName = "TextToVideoCreateVideoResponseCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.TextToVideoCreateVideoResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.TextToVideoCreateVideoResponseCode4), TypeInfoPropertyName = "TextToVideoCreateVideoResponseCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.TextToVideoCreateVideoResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.TextToVideoCreateVideoResponseCode5), TypeInfoPropertyName = "TextToVideoCreateVideoResponseCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.TextToVideoCreateVideoResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.TextToVideoCreateVideoResponseCode6), TypeInfoPropertyName = "TextToVideoCreateVideoResponseCode62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoToVideoCreateVideoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoToVideoCreateVideoResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoToVideoCreateVideoResponseCode), TypeInfoPropertyName = "VideoToVideoCreateVideoResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoToVideoCreateVideoResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoToVideoCreateVideoResponseCode2), TypeInfoPropertyName = "VideoToVideoCreateVideoResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoToVideoCreateVideoResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoToVideoCreateVideoResponseCode3), TypeInfoPropertyName = "VideoToVideoCreateVideoResponseCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoToVideoCreateVideoResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoToVideoCreateVideoResponseCode4), TypeInfoPropertyName = "VideoToVideoCreateVideoResponseCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoToVideoCreateVideoResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoToVideoCreateVideoResponseCode5), TypeInfoPropertyName = "VideoToVideoCreateVideoResponseCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoToVideoCreateVideoResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoToVideoCreateVideoResponseCode6), TypeInfoPropertyName = "VideoToVideoCreateVideoResponseCode62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageProjectsGetDetailsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageProjectsGetDetailsResponseStatus), TypeInfoPropertyName = "ImageProjectsGetDetailsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::MagicHour.ImageProjectsGetDetailsResponseDownload>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageProjectsGetDetailsResponseDownload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageProjectsGetDetailsResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageProjectsGetDetailsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageProjectsGetDetailsResponseCode), TypeInfoPropertyName = "ImageProjectsGetDetailsResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageProjectsGetDetailsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageProjectsGetDetailsResponseCode2), TypeInfoPropertyName = "ImageProjectsGetDetailsResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageProjectsGetDetailsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageProjectsGetDetailsResponseCode3), TypeInfoPropertyName = "ImageProjectsGetDetailsResponseCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageProjectsGetDetailsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageProjectsGetDetailsResponseCode4), TypeInfoPropertyName = "ImageProjectsGetDetailsResponseCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageProjectsGetDetailsResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageProjectsGetDetailsResponseCode5), TypeInfoPropertyName = "ImageProjectsGetDetailsResponseCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageProjectsDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageProjectsDeleteResponseCode), TypeInfoPropertyName = "ImageProjectsDeleteResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageProjectsDeleteResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageProjectsDeleteResponseCode2), TypeInfoPropertyName = "ImageProjectsDeleteResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageProjectsDeleteResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageProjectsDeleteResponseCode3), TypeInfoPropertyName = "ImageProjectsDeleteResponseCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageProjectsDeleteResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageProjectsDeleteResponseCode4), TypeInfoPropertyName = "ImageProjectsDeleteResponseCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageProjectsDeleteResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageProjectsDeleteResponseCode5), TypeInfoPropertyName = "ImageProjectsDeleteResponseCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiClothesChangerCreateImageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiClothesChangerCreateImageResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiClothesChangerCreateImageResponseCode), TypeInfoPropertyName = "AiClothesChangerCreateImageResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiClothesChangerCreateImageResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiClothesChangerCreateImageResponseCode2), TypeInfoPropertyName = "AiClothesChangerCreateImageResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiClothesChangerCreateImageResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiClothesChangerCreateImageResponseCode3), TypeInfoPropertyName = "AiClothesChangerCreateImageResponseCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiClothesChangerCreateImageResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiClothesChangerCreateImageResponseCode4), TypeInfoPropertyName = "AiClothesChangerCreateImageResponseCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiClothesChangerCreateImageResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiClothesChangerCreateImageResponseCode5), TypeInfoPropertyName = "AiClothesChangerCreateImageResponseCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiClothesChangerCreateImageResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiClothesChangerCreateImageResponseCode6), TypeInfoPropertyName = "AiClothesChangerCreateImageResponseCode62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiFaceEditorEditImageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiFaceEditorEditImageResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiFaceEditorEditImageResponseCode), TypeInfoPropertyName = "AiFaceEditorEditImageResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiFaceEditorEditImageResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiFaceEditorEditImageResponseCode2), TypeInfoPropertyName = "AiFaceEditorEditImageResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiFaceEditorEditImageResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiFaceEditorEditImageResponseCode3), TypeInfoPropertyName = "AiFaceEditorEditImageResponseCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiFaceEditorEditImageResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiFaceEditorEditImageResponseCode4), TypeInfoPropertyName = "AiFaceEditorEditImageResponseCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiFaceEditorEditImageResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiFaceEditorEditImageResponseCode5), TypeInfoPropertyName = "AiFaceEditorEditImageResponseCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiFaceEditorEditImageResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiFaceEditorEditImageResponseCode6), TypeInfoPropertyName = "AiFaceEditorEditImageResponseCode62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiGifGeneratorCreateImageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiGifGeneratorCreateImageResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiGifGeneratorCreateImageResponseCode), TypeInfoPropertyName = "AiGifGeneratorCreateImageResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiGifGeneratorCreateImageResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiGifGeneratorCreateImageResponseCode2), TypeInfoPropertyName = "AiGifGeneratorCreateImageResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiGifGeneratorCreateImageResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiGifGeneratorCreateImageResponseCode3), TypeInfoPropertyName = "AiGifGeneratorCreateImageResponseCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiGifGeneratorCreateImageResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiGifGeneratorCreateImageResponseCode4), TypeInfoPropertyName = "AiGifGeneratorCreateImageResponseCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiGifGeneratorCreateImageResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiGifGeneratorCreateImageResponseCode5), TypeInfoPropertyName = "AiGifGeneratorCreateImageResponseCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiGifGeneratorCreateImageResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiGifGeneratorCreateImageResponseCode6), TypeInfoPropertyName = "AiGifGeneratorCreateImageResponseCode62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageEditorCreateImageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageEditorCreateImageResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageEditorCreateImageResponseCode), TypeInfoPropertyName = "AiImageEditorCreateImageResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageEditorCreateImageResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageEditorCreateImageResponseCode2), TypeInfoPropertyName = "AiImageEditorCreateImageResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageEditorCreateImageResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageEditorCreateImageResponseCode3), TypeInfoPropertyName = "AiImageEditorCreateImageResponseCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageEditorCreateImageResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageEditorCreateImageResponseCode4), TypeInfoPropertyName = "AiImageEditorCreateImageResponseCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageEditorCreateImageResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageEditorCreateImageResponseCode5), TypeInfoPropertyName = "AiImageEditorCreateImageResponseCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageEditorCreateImageResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageEditorCreateImageResponseCode6), TypeInfoPropertyName = "AiImageEditorCreateImageResponseCode62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiHeadshotGeneratorCreateImageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiHeadshotGeneratorCreateImageResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiHeadshotGeneratorCreateImageResponseCode), TypeInfoPropertyName = "AiHeadshotGeneratorCreateImageResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiHeadshotGeneratorCreateImageResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiHeadshotGeneratorCreateImageResponseCode2), TypeInfoPropertyName = "AiHeadshotGeneratorCreateImageResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiHeadshotGeneratorCreateImageResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiHeadshotGeneratorCreateImageResponseCode3), TypeInfoPropertyName = "AiHeadshotGeneratorCreateImageResponseCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiHeadshotGeneratorCreateImageResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiHeadshotGeneratorCreateImageResponseCode4), TypeInfoPropertyName = "AiHeadshotGeneratorCreateImageResponseCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiHeadshotGeneratorCreateImageResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiHeadshotGeneratorCreateImageResponseCode5), TypeInfoPropertyName = "AiHeadshotGeneratorCreateImageResponseCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiHeadshotGeneratorCreateImageResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiHeadshotGeneratorCreateImageResponseCode6), TypeInfoPropertyName = "AiHeadshotGeneratorCreateImageResponseCode62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageGeneratorCreateImageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageGeneratorCreateImageResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageGeneratorCreateImageResponseCode), TypeInfoPropertyName = "AiImageGeneratorCreateImageResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageGeneratorCreateImageResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageGeneratorCreateImageResponseCode2), TypeInfoPropertyName = "AiImageGeneratorCreateImageResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageGeneratorCreateImageResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageGeneratorCreateImageResponseCode3), TypeInfoPropertyName = "AiImageGeneratorCreateImageResponseCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageGeneratorCreateImageResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageGeneratorCreateImageResponseCode4), TypeInfoPropertyName = "AiImageGeneratorCreateImageResponseCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageGeneratorCreateImageResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageGeneratorCreateImageResponseCode5), TypeInfoPropertyName = "AiImageGeneratorCreateImageResponseCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageGeneratorCreateImageResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageGeneratorCreateImageResponseCode6), TypeInfoPropertyName = "AiImageGeneratorCreateImageResponseCode62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageUpscalerCreateImageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageUpscalerCreateImageResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageUpscalerCreateImageResponseCode), TypeInfoPropertyName = "AiImageUpscalerCreateImageResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageUpscalerCreateImageResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageUpscalerCreateImageResponseCode2), TypeInfoPropertyName = "AiImageUpscalerCreateImageResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageUpscalerCreateImageResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageUpscalerCreateImageResponseCode3), TypeInfoPropertyName = "AiImageUpscalerCreateImageResponseCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageUpscalerCreateImageResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageUpscalerCreateImageResponseCode4), TypeInfoPropertyName = "AiImageUpscalerCreateImageResponseCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageUpscalerCreateImageResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageUpscalerCreateImageResponseCode5), TypeInfoPropertyName = "AiImageUpscalerCreateImageResponseCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageUpscalerCreateImageResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageUpscalerCreateImageResponseCode6), TypeInfoPropertyName = "AiImageUpscalerCreateImageResponseCode62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiMemeGeneratorCreateImageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiMemeGeneratorCreateImageResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiMemeGeneratorCreateImageResponseCode), TypeInfoPropertyName = "AiMemeGeneratorCreateImageResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiMemeGeneratorCreateImageResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiMemeGeneratorCreateImageResponseCode2), TypeInfoPropertyName = "AiMemeGeneratorCreateImageResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiMemeGeneratorCreateImageResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiMemeGeneratorCreateImageResponseCode3), TypeInfoPropertyName = "AiMemeGeneratorCreateImageResponseCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiMemeGeneratorCreateImageResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiMemeGeneratorCreateImageResponseCode4), TypeInfoPropertyName = "AiMemeGeneratorCreateImageResponseCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiMemeGeneratorCreateImageResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiMemeGeneratorCreateImageResponseCode5), TypeInfoPropertyName = "AiMemeGeneratorCreateImageResponseCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiMemeGeneratorCreateImageResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiMemeGeneratorCreateImageResponseCode6), TypeInfoPropertyName = "AiMemeGeneratorCreateImageResponseCode62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiQrCodeGeneratorCreateImageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiQrCodeGeneratorCreateImageResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiQrCodeGeneratorCreateImageResponseCode), TypeInfoPropertyName = "AiQrCodeGeneratorCreateImageResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiQrCodeGeneratorCreateImageResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiQrCodeGeneratorCreateImageResponseCode2), TypeInfoPropertyName = "AiQrCodeGeneratorCreateImageResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiQrCodeGeneratorCreateImageResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiQrCodeGeneratorCreateImageResponseCode3), TypeInfoPropertyName = "AiQrCodeGeneratorCreateImageResponseCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiQrCodeGeneratorCreateImageResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiQrCodeGeneratorCreateImageResponseCode4), TypeInfoPropertyName = "AiQrCodeGeneratorCreateImageResponseCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiQrCodeGeneratorCreateImageResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiQrCodeGeneratorCreateImageResponseCode5), TypeInfoPropertyName = "AiQrCodeGeneratorCreateImageResponseCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiQrCodeGeneratorCreateImageResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiQrCodeGeneratorCreateImageResponseCode6), TypeInfoPropertyName = "AiQrCodeGeneratorCreateImageResponseCode62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.BodySwapCreateImageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.BodySwapCreateImageResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.BodySwapCreateImageResponseCode), TypeInfoPropertyName = "BodySwapCreateImageResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.BodySwapCreateImageResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.BodySwapCreateImageResponseCode2), TypeInfoPropertyName = "BodySwapCreateImageResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.BodySwapCreateImageResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.BodySwapCreateImageResponseCode3), TypeInfoPropertyName = "BodySwapCreateImageResponseCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.BodySwapCreateImageResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.BodySwapCreateImageResponseCode4), TypeInfoPropertyName = "BodySwapCreateImageResponseCode42")]
    internal sealed partial class SourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.BodySwapCreateImageResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.BodySwapCreateImageResponseCode5), TypeInfoPropertyName = "BodySwapCreateImageResponseCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.BodySwapCreateImageResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.BodySwapCreateImageResponseCode6), TypeInfoPropertyName = "BodySwapCreateImageResponseCode62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceSwapPhotoCreateImageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceSwapPhotoCreateImageResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceSwapPhotoCreateImageResponseCode), TypeInfoPropertyName = "FaceSwapPhotoCreateImageResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceSwapPhotoCreateImageResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceSwapPhotoCreateImageResponseCode2), TypeInfoPropertyName = "FaceSwapPhotoCreateImageResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceSwapPhotoCreateImageResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceSwapPhotoCreateImageResponseCode3), TypeInfoPropertyName = "FaceSwapPhotoCreateImageResponseCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceSwapPhotoCreateImageResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceSwapPhotoCreateImageResponseCode4), TypeInfoPropertyName = "FaceSwapPhotoCreateImageResponseCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceSwapPhotoCreateImageResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceSwapPhotoCreateImageResponseCode5), TypeInfoPropertyName = "FaceSwapPhotoCreateImageResponseCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceSwapPhotoCreateImageResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceSwapPhotoCreateImageResponseCode6), TypeInfoPropertyName = "FaceSwapPhotoCreateImageResponseCode62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.HeadSwapCreateImageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.HeadSwapCreateImageResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.HeadSwapCreateImageResponseCode), TypeInfoPropertyName = "HeadSwapCreateImageResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.HeadSwapCreateImageResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.HeadSwapCreateImageResponseCode2), TypeInfoPropertyName = "HeadSwapCreateImageResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.HeadSwapCreateImageResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.HeadSwapCreateImageResponseCode3), TypeInfoPropertyName = "HeadSwapCreateImageResponseCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.HeadSwapCreateImageResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.HeadSwapCreateImageResponseCode4), TypeInfoPropertyName = "HeadSwapCreateImageResponseCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.HeadSwapCreateImageResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.HeadSwapCreateImageResponseCode5), TypeInfoPropertyName = "HeadSwapCreateImageResponseCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.HeadSwapCreateImageResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.HeadSwapCreateImageResponseCode6), TypeInfoPropertyName = "HeadSwapCreateImageResponseCode62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageBackgroundRemoverCreateImageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageBackgroundRemoverCreateImageResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageBackgroundRemoverCreateImageResponseCode), TypeInfoPropertyName = "ImageBackgroundRemoverCreateImageResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageBackgroundRemoverCreateImageResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageBackgroundRemoverCreateImageResponseCode2), TypeInfoPropertyName = "ImageBackgroundRemoverCreateImageResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageBackgroundRemoverCreateImageResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageBackgroundRemoverCreateImageResponseCode3), TypeInfoPropertyName = "ImageBackgroundRemoverCreateImageResponseCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageBackgroundRemoverCreateImageResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageBackgroundRemoverCreateImageResponseCode4), TypeInfoPropertyName = "ImageBackgroundRemoverCreateImageResponseCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageBackgroundRemoverCreateImageResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageBackgroundRemoverCreateImageResponseCode5), TypeInfoPropertyName = "ImageBackgroundRemoverCreateImageResponseCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageBackgroundRemoverCreateImageResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageBackgroundRemoverCreateImageResponseCode6), TypeInfoPropertyName = "ImageBackgroundRemoverCreateImageResponseCode62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.PhotoColorizerCreateImageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.PhotoColorizerCreateImageResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.PhotoColorizerCreateImageResponseCode), TypeInfoPropertyName = "PhotoColorizerCreateImageResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.PhotoColorizerCreateImageResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.PhotoColorizerCreateImageResponseCode2), TypeInfoPropertyName = "PhotoColorizerCreateImageResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.PhotoColorizerCreateImageResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.PhotoColorizerCreateImageResponseCode3), TypeInfoPropertyName = "PhotoColorizerCreateImageResponseCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.PhotoColorizerCreateImageResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.PhotoColorizerCreateImageResponseCode4), TypeInfoPropertyName = "PhotoColorizerCreateImageResponseCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.PhotoColorizerCreateImageResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.PhotoColorizerCreateImageResponseCode5), TypeInfoPropertyName = "PhotoColorizerCreateImageResponseCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.PhotoColorizerCreateImageResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.PhotoColorizerCreateImageResponseCode6), TypeInfoPropertyName = "PhotoColorizerCreateImageResponseCode62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioProjectsGetDetailsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioProjectsGetDetailsResponseStatus), TypeInfoPropertyName = "AudioProjectsGetDetailsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::MagicHour.AudioProjectsGetDetailsResponseDownload>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioProjectsGetDetailsResponseDownload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioProjectsGetDetailsResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioProjectsGetDetailsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioProjectsGetDetailsResponseCode), TypeInfoPropertyName = "AudioProjectsGetDetailsResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioProjectsGetDetailsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioProjectsGetDetailsResponseCode2), TypeInfoPropertyName = "AudioProjectsGetDetailsResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioProjectsGetDetailsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioProjectsGetDetailsResponseCode3), TypeInfoPropertyName = "AudioProjectsGetDetailsResponseCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioProjectsGetDetailsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioProjectsGetDetailsResponseCode4), TypeInfoPropertyName = "AudioProjectsGetDetailsResponseCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioProjectsGetDetailsResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioProjectsGetDetailsResponseCode5), TypeInfoPropertyName = "AudioProjectsGetDetailsResponseCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioProjectsDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioProjectsDeleteResponseCode), TypeInfoPropertyName = "AudioProjectsDeleteResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioProjectsDeleteResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioProjectsDeleteResponseCode2), TypeInfoPropertyName = "AudioProjectsDeleteResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioProjectsDeleteResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioProjectsDeleteResponseCode3), TypeInfoPropertyName = "AudioProjectsDeleteResponseCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioProjectsDeleteResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioProjectsDeleteResponseCode4), TypeInfoPropertyName = "AudioProjectsDeleteResponseCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioProjectsDeleteResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioProjectsDeleteResponseCode5), TypeInfoPropertyName = "AudioProjectsDeleteResponseCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVoiceGeneratorCreateAudioResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVoiceGeneratorCreateAudioResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVoiceGeneratorCreateAudioResponseCode), TypeInfoPropertyName = "AiVoiceGeneratorCreateAudioResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVoiceGeneratorCreateAudioResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVoiceGeneratorCreateAudioResponseCode2), TypeInfoPropertyName = "AiVoiceGeneratorCreateAudioResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVoiceGeneratorCreateAudioResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVoiceGeneratorCreateAudioResponseCode3), TypeInfoPropertyName = "AiVoiceGeneratorCreateAudioResponseCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVoiceGeneratorCreateAudioResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVoiceGeneratorCreateAudioResponseCode4), TypeInfoPropertyName = "AiVoiceGeneratorCreateAudioResponseCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVoiceGeneratorCreateAudioResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVoiceGeneratorCreateAudioResponseCode5), TypeInfoPropertyName = "AiVoiceGeneratorCreateAudioResponseCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVoiceGeneratorCreateAudioResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVoiceGeneratorCreateAudioResponseCode6), TypeInfoPropertyName = "AiVoiceGeneratorCreateAudioResponseCode62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVoiceClonerCreateAudioResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVoiceClonerCreateAudioResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVoiceClonerCreateAudioResponseCode), TypeInfoPropertyName = "AiVoiceClonerCreateAudioResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVoiceClonerCreateAudioResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVoiceClonerCreateAudioResponseCode2), TypeInfoPropertyName = "AiVoiceClonerCreateAudioResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVoiceClonerCreateAudioResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVoiceClonerCreateAudioResponseCode3), TypeInfoPropertyName = "AiVoiceClonerCreateAudioResponseCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVoiceClonerCreateAudioResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVoiceClonerCreateAudioResponseCode4), TypeInfoPropertyName = "AiVoiceClonerCreateAudioResponseCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVoiceClonerCreateAudioResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVoiceClonerCreateAudioResponseCode5), TypeInfoPropertyName = "AiVoiceClonerCreateAudioResponseCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVoiceClonerCreateAudioResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVoiceClonerCreateAudioResponseCode6), TypeInfoPropertyName = "AiVoiceClonerCreateAudioResponseCode62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoAssetsGeneratePresignedUrlRequestItemType?), TypeInfoPropertyName = "NullableVideoAssetsGeneratePresignedUrlRequestItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiTalkingPhotoCreateTalkingPhotoRequestStyleGenerationMode?), TypeInfoPropertyName = "NullableAiTalkingPhotoCreateTalkingPhotoRequestStyleGenerationMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVideoEditorCreateVideoRequestModel?), TypeInfoPropertyName = "NullableAiVideoEditorCreateVideoRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVideoEditorCreateVideoRequestResolution?), TypeInfoPropertyName = "NullableAiVideoEditorCreateVideoRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AnimationCreateVideoRequestStyleArtStyle?), TypeInfoPropertyName = "NullableAnimationCreateVideoRequestStyleArtStyle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AnimationCreateVideoRequestStyleCameraEffect?), TypeInfoPropertyName = "NullableAnimationCreateVideoRequestStyleCameraEffect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AnimationCreateVideoRequestStylePromptType?), TypeInfoPropertyName = "NullableAnimationCreateVideoRequestStylePromptType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AnimationCreateVideoRequestAssetsAudioSource?), TypeInfoPropertyName = "NullableAnimationCreateVideoRequestAssetsAudioSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioToVideoCreateVideoRequestResolution?), TypeInfoPropertyName = "NullableAudioToVideoCreateVideoRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AutoSubtitleGeneratorCreateVideoRequestStyleTemplate?), TypeInfoPropertyName = "NullableAutoSubtitleGeneratorCreateVideoRequestStyleTemplate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.CharacterReplaceCreateVideoRequestResolution?), TypeInfoPropertyName = "NullableCharacterReplaceCreateVideoRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.CharacterReplaceCreateVideoRequestStyleMode?), TypeInfoPropertyName = "NullableCharacterReplaceCreateVideoRequestStyleMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.CharacterReplaceCreateVideoRequestStyleSelectionMode?), TypeInfoPropertyName = "NullableCharacterReplaceCreateVideoRequestStyleSelectionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceSwapCreateVideoRequestStyleVersion?), TypeInfoPropertyName = "NullableFaceSwapCreateVideoRequestStyleVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceSwapCreateVideoRequestAssetsFaceSwapMode?), TypeInfoPropertyName = "NullableFaceSwapCreateVideoRequestAssetsFaceSwapMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceSwapCreateVideoRequestAssetsVideoSource?), TypeInfoPropertyName = "NullableFaceSwapCreateVideoRequestAssetsVideoSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageToVideoCreateVideoRequestModel?), TypeInfoPropertyName = "NullableImageToVideoCreateVideoRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageToVideoCreateVideoRequestResolution?), TypeInfoPropertyName = "NullableImageToVideoCreateVideoRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.LipSyncCreateVideoRequestAssetsVideoSource?), TypeInfoPropertyName = "NullableLipSyncCreateVideoRequestAssetsVideoSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.LipSyncCreateVideoRequestStyleGenerationMode?), TypeInfoPropertyName = "NullableLipSyncCreateVideoRequestStyleGenerationMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.TextToVideoCreateVideoRequestAspectRatio?), TypeInfoPropertyName = "NullableTextToVideoCreateVideoRequestAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.TextToVideoCreateVideoRequestResolution?), TypeInfoPropertyName = "NullableTextToVideoCreateVideoRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.TextToVideoCreateVideoRequestModel?), TypeInfoPropertyName = "NullableTextToVideoCreateVideoRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoToVideoCreateVideoRequestFpsResolution?), TypeInfoPropertyName = "NullableVideoToVideoCreateVideoRequestFpsResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoToVideoCreateVideoRequestStyleArtStyle?), TypeInfoPropertyName = "NullableVideoToVideoCreateVideoRequestStyleArtStyle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoToVideoCreateVideoRequestStyleVersion?), TypeInfoPropertyName = "NullableVideoToVideoCreateVideoRequestStyleVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoToVideoCreateVideoRequestStylePromptType?), TypeInfoPropertyName = "NullableVideoToVideoCreateVideoRequestStylePromptType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoToVideoCreateVideoRequestStyleModel?), TypeInfoPropertyName = "NullableVideoToVideoCreateVideoRequestStyleModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoToVideoCreateVideoRequestAssetsVideoSource?), TypeInfoPropertyName = "NullableVideoToVideoCreateVideoRequestAssetsVideoSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiClothesChangerCreateImageRequestAssetsGarmentType?), TypeInfoPropertyName = "NullableAiClothesChangerCreateImageRequestAssetsGarmentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiGifGeneratorCreateImageRequestOutputFormat?), TypeInfoPropertyName = "NullableAiGifGeneratorCreateImageRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageEditorCreateImageRequestModel?), TypeInfoPropertyName = "NullableAiImageEditorCreateImageRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageEditorCreateImageRequestAspectRatio?), TypeInfoPropertyName = "NullableAiImageEditorCreateImageRequestAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageEditorCreateImageRequestResolution?), TypeInfoPropertyName = "NullableAiImageEditorCreateImageRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageGeneratorCreateImageRequestModel?), TypeInfoPropertyName = "NullableAiImageGeneratorCreateImageRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageGeneratorCreateImageRequestAspectRatio?), TypeInfoPropertyName = "NullableAiImageGeneratorCreateImageRequestAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageGeneratorCreateImageRequestResolution?), TypeInfoPropertyName = "NullableAiImageGeneratorCreateImageRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageGeneratorCreateImageRequestStyleTool?), TypeInfoPropertyName = "NullableAiImageGeneratorCreateImageRequestStyleTool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageUpscalerCreateImageRequestStyleMode?), TypeInfoPropertyName = "NullableAiImageUpscalerCreateImageRequestStyleMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiMemeGeneratorCreateImageRequestStyleTemplate?), TypeInfoPropertyName = "NullableAiMemeGeneratorCreateImageRequestStyleTemplate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.BodySwapCreateImageRequestResolution?), TypeInfoPropertyName = "NullableBodySwapCreateImageRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceSwapPhotoCreateImageRequestAssetsFaceSwapMode?), TypeInfoPropertyName = "NullableFaceSwapPhotoCreateImageRequestAssetsFaceSwapMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVoiceGeneratorCreateAudioRequestStyleVoiceName?), TypeInfoPropertyName = "NullableAiVoiceGeneratorCreateAudioRequestStyleVoiceName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoAssetsGeneratePresignedUrlResponseCode?), TypeInfoPropertyName = "NullableVideoAssetsGeneratePresignedUrlResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoAssetsGeneratePresignedUrlResponseCode2?), TypeInfoPropertyName = "NullableVideoAssetsGeneratePresignedUrlResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoAssetsGeneratePresignedUrlResponseCode3?), TypeInfoPropertyName = "NullableVideoAssetsGeneratePresignedUrlResponseCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoAssetsGeneratePresignedUrlResponseCode4?), TypeInfoPropertyName = "NullableVideoAssetsGeneratePresignedUrlResponseCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoAssetsGeneratePresignedUrlResponseCode5?), TypeInfoPropertyName = "NullableVideoAssetsGeneratePresignedUrlResponseCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoAssetsGeneratePresignedUrlResponseCode6?), TypeInfoPropertyName = "NullableVideoAssetsGeneratePresignedUrlResponseCode62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceDetectionGetDetailsResponseStatus?), TypeInfoPropertyName = "NullableFaceDetectionGetDetailsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceDetectionGetDetailsResponseCode?), TypeInfoPropertyName = "NullableFaceDetectionGetDetailsResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceDetectionGetDetailsResponseCode2?), TypeInfoPropertyName = "NullableFaceDetectionGetDetailsResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceDetectionGetDetailsResponseCode3?), TypeInfoPropertyName = "NullableFaceDetectionGetDetailsResponseCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceDetectionGetDetailsResponseCode4?), TypeInfoPropertyName = "NullableFaceDetectionGetDetailsResponseCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceDetectionGetDetailsResponseCode5?), TypeInfoPropertyName = "NullableFaceDetectionGetDetailsResponseCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceDetectionGetDetailsResponseCode6?), TypeInfoPropertyName = "NullableFaceDetectionGetDetailsResponseCode62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceDetectionDetectFacesResponseCode?), TypeInfoPropertyName = "NullableFaceDetectionDetectFacesResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceDetectionDetectFacesResponseCode2?), TypeInfoPropertyName = "NullableFaceDetectionDetectFacesResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceDetectionDetectFacesResponseCode3?), TypeInfoPropertyName = "NullableFaceDetectionDetectFacesResponseCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceDetectionDetectFacesResponseCode4?), TypeInfoPropertyName = "NullableFaceDetectionDetectFacesResponseCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceDetectionDetectFacesResponseCode5?), TypeInfoPropertyName = "NullableFaceDetectionDetectFacesResponseCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceDetectionDetectFacesResponseCode6?), TypeInfoPropertyName = "NullableFaceDetectionDetectFacesResponseCode62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoProjectsGetDetailsResponseStatus?), TypeInfoPropertyName = "NullableVideoProjectsGetDetailsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoProjectsGetDetailsResponseCode?), TypeInfoPropertyName = "NullableVideoProjectsGetDetailsResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoProjectsGetDetailsResponseCode2?), TypeInfoPropertyName = "NullableVideoProjectsGetDetailsResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoProjectsGetDetailsResponseCode3?), TypeInfoPropertyName = "NullableVideoProjectsGetDetailsResponseCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoProjectsGetDetailsResponseCode4?), TypeInfoPropertyName = "NullableVideoProjectsGetDetailsResponseCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoProjectsGetDetailsResponseCode5?), TypeInfoPropertyName = "NullableVideoProjectsGetDetailsResponseCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoProjectsDeleteResponseCode?), TypeInfoPropertyName = "NullableVideoProjectsDeleteResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoProjectsDeleteResponseCode2?), TypeInfoPropertyName = "NullableVideoProjectsDeleteResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoProjectsDeleteResponseCode3?), TypeInfoPropertyName = "NullableVideoProjectsDeleteResponseCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoProjectsDeleteResponseCode4?), TypeInfoPropertyName = "NullableVideoProjectsDeleteResponseCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoProjectsDeleteResponseCode5?), TypeInfoPropertyName = "NullableVideoProjectsDeleteResponseCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoProjectsDeleteResponseCode6?), TypeInfoPropertyName = "NullableVideoProjectsDeleteResponseCode62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponseCode?), TypeInfoPropertyName = "NullableAiTalkingPhotoCreateTalkingPhotoResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponseCode2?), TypeInfoPropertyName = "NullableAiTalkingPhotoCreateTalkingPhotoResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponseCode3?), TypeInfoPropertyName = "NullableAiTalkingPhotoCreateTalkingPhotoResponseCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponseCode4?), TypeInfoPropertyName = "NullableAiTalkingPhotoCreateTalkingPhotoResponseCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponseCode5?), TypeInfoPropertyName = "NullableAiTalkingPhotoCreateTalkingPhotoResponseCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponseCode6?), TypeInfoPropertyName = "NullableAiTalkingPhotoCreateTalkingPhotoResponseCode62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVideoEditorCreateVideoResponseCode?), TypeInfoPropertyName = "NullableAiVideoEditorCreateVideoResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVideoEditorCreateVideoResponseCode2?), TypeInfoPropertyName = "NullableAiVideoEditorCreateVideoResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVideoEditorCreateVideoResponseCode3?), TypeInfoPropertyName = "NullableAiVideoEditorCreateVideoResponseCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVideoEditorCreateVideoResponseCode4?), TypeInfoPropertyName = "NullableAiVideoEditorCreateVideoResponseCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVideoEditorCreateVideoResponseCode5?), TypeInfoPropertyName = "NullableAiVideoEditorCreateVideoResponseCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVideoEditorCreateVideoResponseCode6?), TypeInfoPropertyName = "NullableAiVideoEditorCreateVideoResponseCode62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AnimationCreateVideoResponseCode?), TypeInfoPropertyName = "NullableAnimationCreateVideoResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AnimationCreateVideoResponseCode2?), TypeInfoPropertyName = "NullableAnimationCreateVideoResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AnimationCreateVideoResponseCode3?), TypeInfoPropertyName = "NullableAnimationCreateVideoResponseCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AnimationCreateVideoResponseCode4?), TypeInfoPropertyName = "NullableAnimationCreateVideoResponseCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AnimationCreateVideoResponseCode5?), TypeInfoPropertyName = "NullableAnimationCreateVideoResponseCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AnimationCreateVideoResponseCode6?), TypeInfoPropertyName = "NullableAnimationCreateVideoResponseCode62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioToVideoCreateVideoResponseCode?), TypeInfoPropertyName = "NullableAudioToVideoCreateVideoResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioToVideoCreateVideoResponseCode2?), TypeInfoPropertyName = "NullableAudioToVideoCreateVideoResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioToVideoCreateVideoResponseCode3?), TypeInfoPropertyName = "NullableAudioToVideoCreateVideoResponseCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioToVideoCreateVideoResponseCode4?), TypeInfoPropertyName = "NullableAudioToVideoCreateVideoResponseCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioToVideoCreateVideoResponseCode5?), TypeInfoPropertyName = "NullableAudioToVideoCreateVideoResponseCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioToVideoCreateVideoResponseCode6?), TypeInfoPropertyName = "NullableAudioToVideoCreateVideoResponseCode62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AutoSubtitleGeneratorCreateVideoResponseCode?), TypeInfoPropertyName = "NullableAutoSubtitleGeneratorCreateVideoResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AutoSubtitleGeneratorCreateVideoResponseCode2?), TypeInfoPropertyName = "NullableAutoSubtitleGeneratorCreateVideoResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AutoSubtitleGeneratorCreateVideoResponseCode3?), TypeInfoPropertyName = "NullableAutoSubtitleGeneratorCreateVideoResponseCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AutoSubtitleGeneratorCreateVideoResponseCode4?), TypeInfoPropertyName = "NullableAutoSubtitleGeneratorCreateVideoResponseCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AutoSubtitleGeneratorCreateVideoResponseCode5?), TypeInfoPropertyName = "NullableAutoSubtitleGeneratorCreateVideoResponseCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AutoSubtitleGeneratorCreateVideoResponseCode6?), TypeInfoPropertyName = "NullableAutoSubtitleGeneratorCreateVideoResponseCode62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.CharacterReplaceCreateVideoResponseCode?), TypeInfoPropertyName = "NullableCharacterReplaceCreateVideoResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.CharacterReplaceCreateVideoResponseCode2?), TypeInfoPropertyName = "NullableCharacterReplaceCreateVideoResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.CharacterReplaceCreateVideoResponseCode3?), TypeInfoPropertyName = "NullableCharacterReplaceCreateVideoResponseCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.CharacterReplaceCreateVideoResponseCode4?), TypeInfoPropertyName = "NullableCharacterReplaceCreateVideoResponseCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.CharacterReplaceCreateVideoResponseCode5?), TypeInfoPropertyName = "NullableCharacterReplaceCreateVideoResponseCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.CharacterReplaceCreateVideoResponseCode6?), TypeInfoPropertyName = "NullableCharacterReplaceCreateVideoResponseCode62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceSwapCreateVideoResponseCode?), TypeInfoPropertyName = "NullableFaceSwapCreateVideoResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceSwapCreateVideoResponseCode2?), TypeInfoPropertyName = "NullableFaceSwapCreateVideoResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceSwapCreateVideoResponseCode3?), TypeInfoPropertyName = "NullableFaceSwapCreateVideoResponseCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceSwapCreateVideoResponseCode4?), TypeInfoPropertyName = "NullableFaceSwapCreateVideoResponseCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceSwapCreateVideoResponseCode5?), TypeInfoPropertyName = "NullableFaceSwapCreateVideoResponseCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceSwapCreateVideoResponseCode6?), TypeInfoPropertyName = "NullableFaceSwapCreateVideoResponseCode62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageToVideoCreateVideoResponseCode?), TypeInfoPropertyName = "NullableImageToVideoCreateVideoResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageToVideoCreateVideoResponseCode2?), TypeInfoPropertyName = "NullableImageToVideoCreateVideoResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageToVideoCreateVideoResponseCode3?), TypeInfoPropertyName = "NullableImageToVideoCreateVideoResponseCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageToVideoCreateVideoResponseCode4?), TypeInfoPropertyName = "NullableImageToVideoCreateVideoResponseCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageToVideoCreateVideoResponseCode5?), TypeInfoPropertyName = "NullableImageToVideoCreateVideoResponseCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageToVideoCreateVideoResponseCode6?), TypeInfoPropertyName = "NullableImageToVideoCreateVideoResponseCode62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.LipSyncCreateVideoResponseCode?), TypeInfoPropertyName = "NullableLipSyncCreateVideoResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.LipSyncCreateVideoResponseCode2?), TypeInfoPropertyName = "NullableLipSyncCreateVideoResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.LipSyncCreateVideoResponseCode3?), TypeInfoPropertyName = "NullableLipSyncCreateVideoResponseCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.LipSyncCreateVideoResponseCode4?), TypeInfoPropertyName = "NullableLipSyncCreateVideoResponseCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.LipSyncCreateVideoResponseCode5?), TypeInfoPropertyName = "NullableLipSyncCreateVideoResponseCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.LipSyncCreateVideoResponseCode6?), TypeInfoPropertyName = "NullableLipSyncCreateVideoResponseCode62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.TextToVideoCreateVideoResponseCode?), TypeInfoPropertyName = "NullableTextToVideoCreateVideoResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.TextToVideoCreateVideoResponseCode2?), TypeInfoPropertyName = "NullableTextToVideoCreateVideoResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.TextToVideoCreateVideoResponseCode3?), TypeInfoPropertyName = "NullableTextToVideoCreateVideoResponseCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.TextToVideoCreateVideoResponseCode4?), TypeInfoPropertyName = "NullableTextToVideoCreateVideoResponseCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.TextToVideoCreateVideoResponseCode5?), TypeInfoPropertyName = "NullableTextToVideoCreateVideoResponseCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.TextToVideoCreateVideoResponseCode6?), TypeInfoPropertyName = "NullableTextToVideoCreateVideoResponseCode62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoToVideoCreateVideoResponseCode?), TypeInfoPropertyName = "NullableVideoToVideoCreateVideoResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoToVideoCreateVideoResponseCode2?), TypeInfoPropertyName = "NullableVideoToVideoCreateVideoResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoToVideoCreateVideoResponseCode3?), TypeInfoPropertyName = "NullableVideoToVideoCreateVideoResponseCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoToVideoCreateVideoResponseCode4?), TypeInfoPropertyName = "NullableVideoToVideoCreateVideoResponseCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoToVideoCreateVideoResponseCode5?), TypeInfoPropertyName = "NullableVideoToVideoCreateVideoResponseCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoToVideoCreateVideoResponseCode6?), TypeInfoPropertyName = "NullableVideoToVideoCreateVideoResponseCode62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageProjectsGetDetailsResponseStatus?), TypeInfoPropertyName = "NullableImageProjectsGetDetailsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageProjectsGetDetailsResponseCode?), TypeInfoPropertyName = "NullableImageProjectsGetDetailsResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageProjectsGetDetailsResponseCode2?), TypeInfoPropertyName = "NullableImageProjectsGetDetailsResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageProjectsGetDetailsResponseCode3?), TypeInfoPropertyName = "NullableImageProjectsGetDetailsResponseCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageProjectsGetDetailsResponseCode4?), TypeInfoPropertyName = "NullableImageProjectsGetDetailsResponseCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageProjectsGetDetailsResponseCode5?), TypeInfoPropertyName = "NullableImageProjectsGetDetailsResponseCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageProjectsDeleteResponseCode?), TypeInfoPropertyName = "NullableImageProjectsDeleteResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageProjectsDeleteResponseCode2?), TypeInfoPropertyName = "NullableImageProjectsDeleteResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageProjectsDeleteResponseCode3?), TypeInfoPropertyName = "NullableImageProjectsDeleteResponseCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageProjectsDeleteResponseCode4?), TypeInfoPropertyName = "NullableImageProjectsDeleteResponseCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageProjectsDeleteResponseCode5?), TypeInfoPropertyName = "NullableImageProjectsDeleteResponseCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiClothesChangerCreateImageResponseCode?), TypeInfoPropertyName = "NullableAiClothesChangerCreateImageResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiClothesChangerCreateImageResponseCode2?), TypeInfoPropertyName = "NullableAiClothesChangerCreateImageResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiClothesChangerCreateImageResponseCode3?), TypeInfoPropertyName = "NullableAiClothesChangerCreateImageResponseCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiClothesChangerCreateImageResponseCode4?), TypeInfoPropertyName = "NullableAiClothesChangerCreateImageResponseCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiClothesChangerCreateImageResponseCode5?), TypeInfoPropertyName = "NullableAiClothesChangerCreateImageResponseCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiClothesChangerCreateImageResponseCode6?), TypeInfoPropertyName = "NullableAiClothesChangerCreateImageResponseCode62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiFaceEditorEditImageResponseCode?), TypeInfoPropertyName = "NullableAiFaceEditorEditImageResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiFaceEditorEditImageResponseCode2?), TypeInfoPropertyName = "NullableAiFaceEditorEditImageResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiFaceEditorEditImageResponseCode3?), TypeInfoPropertyName = "NullableAiFaceEditorEditImageResponseCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiFaceEditorEditImageResponseCode4?), TypeInfoPropertyName = "NullableAiFaceEditorEditImageResponseCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiFaceEditorEditImageResponseCode5?), TypeInfoPropertyName = "NullableAiFaceEditorEditImageResponseCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiFaceEditorEditImageResponseCode6?), TypeInfoPropertyName = "NullableAiFaceEditorEditImageResponseCode62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiGifGeneratorCreateImageResponseCode?), TypeInfoPropertyName = "NullableAiGifGeneratorCreateImageResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiGifGeneratorCreateImageResponseCode2?), TypeInfoPropertyName = "NullableAiGifGeneratorCreateImageResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiGifGeneratorCreateImageResponseCode3?), TypeInfoPropertyName = "NullableAiGifGeneratorCreateImageResponseCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiGifGeneratorCreateImageResponseCode4?), TypeInfoPropertyName = "NullableAiGifGeneratorCreateImageResponseCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiGifGeneratorCreateImageResponseCode5?), TypeInfoPropertyName = "NullableAiGifGeneratorCreateImageResponseCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiGifGeneratorCreateImageResponseCode6?), TypeInfoPropertyName = "NullableAiGifGeneratorCreateImageResponseCode62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageEditorCreateImageResponseCode?), TypeInfoPropertyName = "NullableAiImageEditorCreateImageResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageEditorCreateImageResponseCode2?), TypeInfoPropertyName = "NullableAiImageEditorCreateImageResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageEditorCreateImageResponseCode3?), TypeInfoPropertyName = "NullableAiImageEditorCreateImageResponseCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageEditorCreateImageResponseCode4?), TypeInfoPropertyName = "NullableAiImageEditorCreateImageResponseCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageEditorCreateImageResponseCode5?), TypeInfoPropertyName = "NullableAiImageEditorCreateImageResponseCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageEditorCreateImageResponseCode6?), TypeInfoPropertyName = "NullableAiImageEditorCreateImageResponseCode62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiHeadshotGeneratorCreateImageResponseCode?), TypeInfoPropertyName = "NullableAiHeadshotGeneratorCreateImageResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiHeadshotGeneratorCreateImageResponseCode2?), TypeInfoPropertyName = "NullableAiHeadshotGeneratorCreateImageResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiHeadshotGeneratorCreateImageResponseCode3?), TypeInfoPropertyName = "NullableAiHeadshotGeneratorCreateImageResponseCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiHeadshotGeneratorCreateImageResponseCode4?), TypeInfoPropertyName = "NullableAiHeadshotGeneratorCreateImageResponseCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiHeadshotGeneratorCreateImageResponseCode5?), TypeInfoPropertyName = "NullableAiHeadshotGeneratorCreateImageResponseCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiHeadshotGeneratorCreateImageResponseCode6?), TypeInfoPropertyName = "NullableAiHeadshotGeneratorCreateImageResponseCode62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageGeneratorCreateImageResponseCode?), TypeInfoPropertyName = "NullableAiImageGeneratorCreateImageResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageGeneratorCreateImageResponseCode2?), TypeInfoPropertyName = "NullableAiImageGeneratorCreateImageResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageGeneratorCreateImageResponseCode3?), TypeInfoPropertyName = "NullableAiImageGeneratorCreateImageResponseCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageGeneratorCreateImageResponseCode4?), TypeInfoPropertyName = "NullableAiImageGeneratorCreateImageResponseCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageGeneratorCreateImageResponseCode5?), TypeInfoPropertyName = "NullableAiImageGeneratorCreateImageResponseCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageGeneratorCreateImageResponseCode6?), TypeInfoPropertyName = "NullableAiImageGeneratorCreateImageResponseCode62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageUpscalerCreateImageResponseCode?), TypeInfoPropertyName = "NullableAiImageUpscalerCreateImageResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageUpscalerCreateImageResponseCode2?), TypeInfoPropertyName = "NullableAiImageUpscalerCreateImageResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageUpscalerCreateImageResponseCode3?), TypeInfoPropertyName = "NullableAiImageUpscalerCreateImageResponseCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageUpscalerCreateImageResponseCode4?), TypeInfoPropertyName = "NullableAiImageUpscalerCreateImageResponseCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageUpscalerCreateImageResponseCode5?), TypeInfoPropertyName = "NullableAiImageUpscalerCreateImageResponseCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageUpscalerCreateImageResponseCode6?), TypeInfoPropertyName = "NullableAiImageUpscalerCreateImageResponseCode62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiMemeGeneratorCreateImageResponseCode?), TypeInfoPropertyName = "NullableAiMemeGeneratorCreateImageResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiMemeGeneratorCreateImageResponseCode2?), TypeInfoPropertyName = "NullableAiMemeGeneratorCreateImageResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiMemeGeneratorCreateImageResponseCode3?), TypeInfoPropertyName = "NullableAiMemeGeneratorCreateImageResponseCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiMemeGeneratorCreateImageResponseCode4?), TypeInfoPropertyName = "NullableAiMemeGeneratorCreateImageResponseCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiMemeGeneratorCreateImageResponseCode5?), TypeInfoPropertyName = "NullableAiMemeGeneratorCreateImageResponseCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiMemeGeneratorCreateImageResponseCode6?), TypeInfoPropertyName = "NullableAiMemeGeneratorCreateImageResponseCode62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiQrCodeGeneratorCreateImageResponseCode?), TypeInfoPropertyName = "NullableAiQrCodeGeneratorCreateImageResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiQrCodeGeneratorCreateImageResponseCode2?), TypeInfoPropertyName = "NullableAiQrCodeGeneratorCreateImageResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiQrCodeGeneratorCreateImageResponseCode3?), TypeInfoPropertyName = "NullableAiQrCodeGeneratorCreateImageResponseCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiQrCodeGeneratorCreateImageResponseCode4?), TypeInfoPropertyName = "NullableAiQrCodeGeneratorCreateImageResponseCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiQrCodeGeneratorCreateImageResponseCode5?), TypeInfoPropertyName = "NullableAiQrCodeGeneratorCreateImageResponseCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiQrCodeGeneratorCreateImageResponseCode6?), TypeInfoPropertyName = "NullableAiQrCodeGeneratorCreateImageResponseCode62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.BodySwapCreateImageResponseCode?), TypeInfoPropertyName = "NullableBodySwapCreateImageResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.BodySwapCreateImageResponseCode2?), TypeInfoPropertyName = "NullableBodySwapCreateImageResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.BodySwapCreateImageResponseCode3?), TypeInfoPropertyName = "NullableBodySwapCreateImageResponseCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.BodySwapCreateImageResponseCode4?), TypeInfoPropertyName = "NullableBodySwapCreateImageResponseCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.BodySwapCreateImageResponseCode5?), TypeInfoPropertyName = "NullableBodySwapCreateImageResponseCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.BodySwapCreateImageResponseCode6?), TypeInfoPropertyName = "NullableBodySwapCreateImageResponseCode62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceSwapPhotoCreateImageResponseCode?), TypeInfoPropertyName = "NullableFaceSwapPhotoCreateImageResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceSwapPhotoCreateImageResponseCode2?), TypeInfoPropertyName = "NullableFaceSwapPhotoCreateImageResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceSwapPhotoCreateImageResponseCode3?), TypeInfoPropertyName = "NullableFaceSwapPhotoCreateImageResponseCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceSwapPhotoCreateImageResponseCode4?), TypeInfoPropertyName = "NullableFaceSwapPhotoCreateImageResponseCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceSwapPhotoCreateImageResponseCode5?), TypeInfoPropertyName = "NullableFaceSwapPhotoCreateImageResponseCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceSwapPhotoCreateImageResponseCode6?), TypeInfoPropertyName = "NullableFaceSwapPhotoCreateImageResponseCode62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.HeadSwapCreateImageResponseCode?), TypeInfoPropertyName = "NullableHeadSwapCreateImageResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.HeadSwapCreateImageResponseCode2?), TypeInfoPropertyName = "NullableHeadSwapCreateImageResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.HeadSwapCreateImageResponseCode3?), TypeInfoPropertyName = "NullableHeadSwapCreateImageResponseCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.HeadSwapCreateImageResponseCode4?), TypeInfoPropertyName = "NullableHeadSwapCreateImageResponseCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.HeadSwapCreateImageResponseCode5?), TypeInfoPropertyName = "NullableHeadSwapCreateImageResponseCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.HeadSwapCreateImageResponseCode6?), TypeInfoPropertyName = "NullableHeadSwapCreateImageResponseCode62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageBackgroundRemoverCreateImageResponseCode?), TypeInfoPropertyName = "NullableImageBackgroundRemoverCreateImageResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageBackgroundRemoverCreateImageResponseCode2?), TypeInfoPropertyName = "NullableImageBackgroundRemoverCreateImageResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageBackgroundRemoverCreateImageResponseCode3?), TypeInfoPropertyName = "NullableImageBackgroundRemoverCreateImageResponseCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageBackgroundRemoverCreateImageResponseCode4?), TypeInfoPropertyName = "NullableImageBackgroundRemoverCreateImageResponseCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageBackgroundRemoverCreateImageResponseCode5?), TypeInfoPropertyName = "NullableImageBackgroundRemoverCreateImageResponseCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageBackgroundRemoverCreateImageResponseCode6?), TypeInfoPropertyName = "NullableImageBackgroundRemoverCreateImageResponseCode62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.PhotoColorizerCreateImageResponseCode?), TypeInfoPropertyName = "NullablePhotoColorizerCreateImageResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.PhotoColorizerCreateImageResponseCode2?), TypeInfoPropertyName = "NullablePhotoColorizerCreateImageResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.PhotoColorizerCreateImageResponseCode3?), TypeInfoPropertyName = "NullablePhotoColorizerCreateImageResponseCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.PhotoColorizerCreateImageResponseCode4?), TypeInfoPropertyName = "NullablePhotoColorizerCreateImageResponseCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.PhotoColorizerCreateImageResponseCode5?), TypeInfoPropertyName = "NullablePhotoColorizerCreateImageResponseCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.PhotoColorizerCreateImageResponseCode6?), TypeInfoPropertyName = "NullablePhotoColorizerCreateImageResponseCode62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioProjectsGetDetailsResponseStatus?), TypeInfoPropertyName = "NullableAudioProjectsGetDetailsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioProjectsGetDetailsResponseCode?), TypeInfoPropertyName = "NullableAudioProjectsGetDetailsResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioProjectsGetDetailsResponseCode2?), TypeInfoPropertyName = "NullableAudioProjectsGetDetailsResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioProjectsGetDetailsResponseCode3?), TypeInfoPropertyName = "NullableAudioProjectsGetDetailsResponseCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioProjectsGetDetailsResponseCode4?), TypeInfoPropertyName = "NullableAudioProjectsGetDetailsResponseCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioProjectsGetDetailsResponseCode5?), TypeInfoPropertyName = "NullableAudioProjectsGetDetailsResponseCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioProjectsDeleteResponseCode?), TypeInfoPropertyName = "NullableAudioProjectsDeleteResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioProjectsDeleteResponseCode2?), TypeInfoPropertyName = "NullableAudioProjectsDeleteResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioProjectsDeleteResponseCode3?), TypeInfoPropertyName = "NullableAudioProjectsDeleteResponseCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioProjectsDeleteResponseCode4?), TypeInfoPropertyName = "NullableAudioProjectsDeleteResponseCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioProjectsDeleteResponseCode5?), TypeInfoPropertyName = "NullableAudioProjectsDeleteResponseCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVoiceGeneratorCreateAudioResponseCode?), TypeInfoPropertyName = "NullableAiVoiceGeneratorCreateAudioResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVoiceGeneratorCreateAudioResponseCode2?), TypeInfoPropertyName = "NullableAiVoiceGeneratorCreateAudioResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVoiceGeneratorCreateAudioResponseCode3?), TypeInfoPropertyName = "NullableAiVoiceGeneratorCreateAudioResponseCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVoiceGeneratorCreateAudioResponseCode4?), TypeInfoPropertyName = "NullableAiVoiceGeneratorCreateAudioResponseCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVoiceGeneratorCreateAudioResponseCode5?), TypeInfoPropertyName = "NullableAiVoiceGeneratorCreateAudioResponseCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVoiceGeneratorCreateAudioResponseCode6?), TypeInfoPropertyName = "NullableAiVoiceGeneratorCreateAudioResponseCode62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVoiceClonerCreateAudioResponseCode?), TypeInfoPropertyName = "NullableAiVoiceClonerCreateAudioResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVoiceClonerCreateAudioResponseCode2?), TypeInfoPropertyName = "NullableAiVoiceClonerCreateAudioResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVoiceClonerCreateAudioResponseCode3?), TypeInfoPropertyName = "NullableAiVoiceClonerCreateAudioResponseCode32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVoiceClonerCreateAudioResponseCode4?), TypeInfoPropertyName = "NullableAiVoiceClonerCreateAudioResponseCode42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVoiceClonerCreateAudioResponseCode5?), TypeInfoPropertyName = "NullableAiVoiceClonerCreateAudioResponseCode52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVoiceClonerCreateAudioResponseCode6?), TypeInfoPropertyName = "NullableAiVoiceClonerCreateAudioResponseCode62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::MagicHour.VideoAssetsGeneratePresignedUrlRequestItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::MagicHour.CharacterReplaceCreateVideoRequestStylePoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::MagicHour.FaceSwapCreateVideoRequestAssetsFaceMapping>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::MagicHour.FaceSwapPhotoCreateImageRequestAssetsFaceMapping>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::MagicHour.VideoAssetsGeneratePresignedUrlResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::MagicHour.FaceDetectionGetDetailsResponseFace>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::MagicHour.VideoProjectsGetDetailsResponseDownload>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::MagicHour.ImageProjectsGetDetailsResponseDownload>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::MagicHour.AudioProjectsGetDetailsResponseDownload>))]
    internal sealed partial class SourceGenerationContextChunk1 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContext Default { get; } = new(DefaultOptions);

        private SourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

         static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::MagicHour.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::MagicHour.VideoAssetsGeneratePresignedUrlRequestItemType)

                    || typeToConvert == typeof(global::MagicHour.VideoAssetsGeneratePresignedUrlRequestItemType?)

                    || typeToConvert == typeof(global::MagicHour.AiTalkingPhotoCreateTalkingPhotoRequestStyleGenerationMode)

                    || typeToConvert == typeof(global::MagicHour.AiTalkingPhotoCreateTalkingPhotoRequestStyleGenerationMode?)

                    || typeToConvert == typeof(global::MagicHour.AiVideoEditorCreateVideoRequestModel)

                    || typeToConvert == typeof(global::MagicHour.AiVideoEditorCreateVideoRequestModel?)

                    || typeToConvert == typeof(global::MagicHour.AiVideoEditorCreateVideoRequestResolution)

                    || typeToConvert == typeof(global::MagicHour.AiVideoEditorCreateVideoRequestResolution?)

                    || typeToConvert == typeof(global::MagicHour.AnimationCreateVideoRequestStyleArtStyle)

                    || typeToConvert == typeof(global::MagicHour.AnimationCreateVideoRequestStyleArtStyle?)

                    || typeToConvert == typeof(global::MagicHour.AnimationCreateVideoRequestStyleCameraEffect)

                    || typeToConvert == typeof(global::MagicHour.AnimationCreateVideoRequestStyleCameraEffect?)

                    || typeToConvert == typeof(global::MagicHour.AnimationCreateVideoRequestStylePromptType)

                    || typeToConvert == typeof(global::MagicHour.AnimationCreateVideoRequestStylePromptType?)

                    || typeToConvert == typeof(global::MagicHour.AnimationCreateVideoRequestAssetsAudioSource)

                    || typeToConvert == typeof(global::MagicHour.AnimationCreateVideoRequestAssetsAudioSource?)

                    || typeToConvert == typeof(global::MagicHour.AudioToVideoCreateVideoRequestResolution)

                    || typeToConvert == typeof(global::MagicHour.AudioToVideoCreateVideoRequestResolution?)

                    || typeToConvert == typeof(global::MagicHour.AutoSubtitleGeneratorCreateVideoRequestStyleTemplate)

                    || typeToConvert == typeof(global::MagicHour.AutoSubtitleGeneratorCreateVideoRequestStyleTemplate?)

                    || typeToConvert == typeof(global::MagicHour.CharacterReplaceCreateVideoRequestResolution)

                    || typeToConvert == typeof(global::MagicHour.CharacterReplaceCreateVideoRequestResolution?)

                    || typeToConvert == typeof(global::MagicHour.CharacterReplaceCreateVideoRequestStyleMode)

                    || typeToConvert == typeof(global::MagicHour.CharacterReplaceCreateVideoRequestStyleMode?)

                    || typeToConvert == typeof(global::MagicHour.CharacterReplaceCreateVideoRequestStyleSelectionMode)

                    || typeToConvert == typeof(global::MagicHour.CharacterReplaceCreateVideoRequestStyleSelectionMode?)

                    || typeToConvert == typeof(global::MagicHour.FaceSwapCreateVideoRequestStyleVersion)

                    || typeToConvert == typeof(global::MagicHour.FaceSwapCreateVideoRequestStyleVersion?)

                    || typeToConvert == typeof(global::MagicHour.FaceSwapCreateVideoRequestAssetsFaceSwapMode)

                    || typeToConvert == typeof(global::MagicHour.FaceSwapCreateVideoRequestAssetsFaceSwapMode?)

                    || typeToConvert == typeof(global::MagicHour.FaceSwapCreateVideoRequestAssetsVideoSource)

                    || typeToConvert == typeof(global::MagicHour.FaceSwapCreateVideoRequestAssetsVideoSource?)

                    || typeToConvert == typeof(global::MagicHour.ImageToVideoCreateVideoRequestModel)

                    || typeToConvert == typeof(global::MagicHour.ImageToVideoCreateVideoRequestModel?)

                    || typeToConvert == typeof(global::MagicHour.ImageToVideoCreateVideoRequestResolution)

                    || typeToConvert == typeof(global::MagicHour.ImageToVideoCreateVideoRequestResolution?)

                    || typeToConvert == typeof(global::MagicHour.LipSyncCreateVideoRequestAssetsVideoSource)

                    || typeToConvert == typeof(global::MagicHour.LipSyncCreateVideoRequestAssetsVideoSource?)

                    || typeToConvert == typeof(global::MagicHour.LipSyncCreateVideoRequestStyleGenerationMode)

                    || typeToConvert == typeof(global::MagicHour.LipSyncCreateVideoRequestStyleGenerationMode?)

                    || typeToConvert == typeof(global::MagicHour.TextToVideoCreateVideoRequestAspectRatio)

                    || typeToConvert == typeof(global::MagicHour.TextToVideoCreateVideoRequestAspectRatio?)

                    || typeToConvert == typeof(global::MagicHour.TextToVideoCreateVideoRequestResolution)

                    || typeToConvert == typeof(global::MagicHour.TextToVideoCreateVideoRequestResolution?)

                    || typeToConvert == typeof(global::MagicHour.TextToVideoCreateVideoRequestModel)

                    || typeToConvert == typeof(global::MagicHour.TextToVideoCreateVideoRequestModel?)

                    || typeToConvert == typeof(global::MagicHour.VideoToVideoCreateVideoRequestFpsResolution)

                    || typeToConvert == typeof(global::MagicHour.VideoToVideoCreateVideoRequestFpsResolution?)

                    || typeToConvert == typeof(global::MagicHour.VideoToVideoCreateVideoRequestStyleArtStyle)

                    || typeToConvert == typeof(global::MagicHour.VideoToVideoCreateVideoRequestStyleArtStyle?)

                    || typeToConvert == typeof(global::MagicHour.VideoToVideoCreateVideoRequestStyleVersion)

                    || typeToConvert == typeof(global::MagicHour.VideoToVideoCreateVideoRequestStyleVersion?)

                    || typeToConvert == typeof(global::MagicHour.VideoToVideoCreateVideoRequestStylePromptType)

                    || typeToConvert == typeof(global::MagicHour.VideoToVideoCreateVideoRequestStylePromptType?)

                    || typeToConvert == typeof(global::MagicHour.VideoToVideoCreateVideoRequestStyleModel)

                    || typeToConvert == typeof(global::MagicHour.VideoToVideoCreateVideoRequestStyleModel?)

                    || typeToConvert == typeof(global::MagicHour.VideoToVideoCreateVideoRequestAssetsVideoSource)

                    || typeToConvert == typeof(global::MagicHour.VideoToVideoCreateVideoRequestAssetsVideoSource?)

                    || typeToConvert == typeof(global::MagicHour.AiClothesChangerCreateImageRequestAssetsGarmentType)

                    || typeToConvert == typeof(global::MagicHour.AiClothesChangerCreateImageRequestAssetsGarmentType?)

                    || typeToConvert == typeof(global::MagicHour.AiGifGeneratorCreateImageRequestOutputFormat)

                    || typeToConvert == typeof(global::MagicHour.AiGifGeneratorCreateImageRequestOutputFormat?)

                    || typeToConvert == typeof(global::MagicHour.AiImageEditorCreateImageRequestModel)

                    || typeToConvert == typeof(global::MagicHour.AiImageEditorCreateImageRequestModel?)

                    || typeToConvert == typeof(global::MagicHour.AiImageEditorCreateImageRequestAspectRatio)

                    || typeToConvert == typeof(global::MagicHour.AiImageEditorCreateImageRequestAspectRatio?)

                    || typeToConvert == typeof(global::MagicHour.AiImageEditorCreateImageRequestResolution)

                    || typeToConvert == typeof(global::MagicHour.AiImageEditorCreateImageRequestResolution?)

                    || typeToConvert == typeof(global::MagicHour.AiImageGeneratorCreateImageRequestModel)

                    || typeToConvert == typeof(global::MagicHour.AiImageGeneratorCreateImageRequestModel?)

                    || typeToConvert == typeof(global::MagicHour.AiImageGeneratorCreateImageRequestAspectRatio)

                    || typeToConvert == typeof(global::MagicHour.AiImageGeneratorCreateImageRequestAspectRatio?)

                    || typeToConvert == typeof(global::MagicHour.AiImageGeneratorCreateImageRequestResolution)

                    || typeToConvert == typeof(global::MagicHour.AiImageGeneratorCreateImageRequestResolution?)

                    || typeToConvert == typeof(global::MagicHour.AiImageGeneratorCreateImageRequestStyleTool)

                    || typeToConvert == typeof(global::MagicHour.AiImageGeneratorCreateImageRequestStyleTool?)

                    || typeToConvert == typeof(global::MagicHour.AiImageUpscalerCreateImageRequestStyleMode)

                    || typeToConvert == typeof(global::MagicHour.AiImageUpscalerCreateImageRequestStyleMode?)

                    || typeToConvert == typeof(global::MagicHour.AiMemeGeneratorCreateImageRequestStyleTemplate)

                    || typeToConvert == typeof(global::MagicHour.AiMemeGeneratorCreateImageRequestStyleTemplate?)

                    || typeToConvert == typeof(global::MagicHour.BodySwapCreateImageRequestResolution)

                    || typeToConvert == typeof(global::MagicHour.BodySwapCreateImageRequestResolution?)

                    || typeToConvert == typeof(global::MagicHour.FaceSwapPhotoCreateImageRequestAssetsFaceSwapMode)

                    || typeToConvert == typeof(global::MagicHour.FaceSwapPhotoCreateImageRequestAssetsFaceSwapMode?)

                    || typeToConvert == typeof(global::MagicHour.AiVoiceGeneratorCreateAudioRequestStyleVoiceName)

                    || typeToConvert == typeof(global::MagicHour.AiVoiceGeneratorCreateAudioRequestStyleVoiceName?)

                    || typeToConvert == typeof(global::MagicHour.VideoAssetsGeneratePresignedUrlResponseCode)

                    || typeToConvert == typeof(global::MagicHour.VideoAssetsGeneratePresignedUrlResponseCode?)

                    || typeToConvert == typeof(global::MagicHour.VideoAssetsGeneratePresignedUrlResponseCode2)

                    || typeToConvert == typeof(global::MagicHour.VideoAssetsGeneratePresignedUrlResponseCode2?)

                    || typeToConvert == typeof(global::MagicHour.VideoAssetsGeneratePresignedUrlResponseCode3)

                    || typeToConvert == typeof(global::MagicHour.VideoAssetsGeneratePresignedUrlResponseCode3?)

                    || typeToConvert == typeof(global::MagicHour.VideoAssetsGeneratePresignedUrlResponseCode4)

                    || typeToConvert == typeof(global::MagicHour.VideoAssetsGeneratePresignedUrlResponseCode4?)

                    || typeToConvert == typeof(global::MagicHour.VideoAssetsGeneratePresignedUrlResponseCode5)

                    || typeToConvert == typeof(global::MagicHour.VideoAssetsGeneratePresignedUrlResponseCode5?)

                    || typeToConvert == typeof(global::MagicHour.VideoAssetsGeneratePresignedUrlResponseCode6)

                    || typeToConvert == typeof(global::MagicHour.VideoAssetsGeneratePresignedUrlResponseCode6?)

                    || typeToConvert == typeof(global::MagicHour.FaceDetectionGetDetailsResponseStatus)

                    || typeToConvert == typeof(global::MagicHour.FaceDetectionGetDetailsResponseStatus?)

                    || typeToConvert == typeof(global::MagicHour.FaceDetectionGetDetailsResponseCode)

                    || typeToConvert == typeof(global::MagicHour.FaceDetectionGetDetailsResponseCode?)

                    || typeToConvert == typeof(global::MagicHour.FaceDetectionGetDetailsResponseCode2)

                    || typeToConvert == typeof(global::MagicHour.FaceDetectionGetDetailsResponseCode2?)

                    || typeToConvert == typeof(global::MagicHour.FaceDetectionGetDetailsResponseCode3)

                    || typeToConvert == typeof(global::MagicHour.FaceDetectionGetDetailsResponseCode3?)

                    || typeToConvert == typeof(global::MagicHour.FaceDetectionGetDetailsResponseCode4)

                    || typeToConvert == typeof(global::MagicHour.FaceDetectionGetDetailsResponseCode4?)

                    || typeToConvert == typeof(global::MagicHour.FaceDetectionGetDetailsResponseCode5)

                    || typeToConvert == typeof(global::MagicHour.FaceDetectionGetDetailsResponseCode5?)

                    || typeToConvert == typeof(global::MagicHour.FaceDetectionGetDetailsResponseCode6)

                    || typeToConvert == typeof(global::MagicHour.FaceDetectionGetDetailsResponseCode6?)

                    || typeToConvert == typeof(global::MagicHour.FaceDetectionDetectFacesResponseCode)

                    || typeToConvert == typeof(global::MagicHour.FaceDetectionDetectFacesResponseCode?)

                    || typeToConvert == typeof(global::MagicHour.FaceDetectionDetectFacesResponseCode2)

                    || typeToConvert == typeof(global::MagicHour.FaceDetectionDetectFacesResponseCode2?)

                    || typeToConvert == typeof(global::MagicHour.FaceDetectionDetectFacesResponseCode3)

                    || typeToConvert == typeof(global::MagicHour.FaceDetectionDetectFacesResponseCode3?)

                    || typeToConvert == typeof(global::MagicHour.FaceDetectionDetectFacesResponseCode4)

                    || typeToConvert == typeof(global::MagicHour.FaceDetectionDetectFacesResponseCode4?)

                    || typeToConvert == typeof(global::MagicHour.FaceDetectionDetectFacesResponseCode5)

                    || typeToConvert == typeof(global::MagicHour.FaceDetectionDetectFacesResponseCode5?)

                    || typeToConvert == typeof(global::MagicHour.FaceDetectionDetectFacesResponseCode6)

                    || typeToConvert == typeof(global::MagicHour.FaceDetectionDetectFacesResponseCode6?)

                    || typeToConvert == typeof(global::MagicHour.VideoProjectsGetDetailsResponseStatus)

                    || typeToConvert == typeof(global::MagicHour.VideoProjectsGetDetailsResponseStatus?)

                    || typeToConvert == typeof(global::MagicHour.VideoProjectsGetDetailsResponseCode)

                    || typeToConvert == typeof(global::MagicHour.VideoProjectsGetDetailsResponseCode?)

                    || typeToConvert == typeof(global::MagicHour.VideoProjectsGetDetailsResponseCode2)

                    || typeToConvert == typeof(global::MagicHour.VideoProjectsGetDetailsResponseCode2?)

                    || typeToConvert == typeof(global::MagicHour.VideoProjectsGetDetailsResponseCode3)

                    || typeToConvert == typeof(global::MagicHour.VideoProjectsGetDetailsResponseCode3?)

                    || typeToConvert == typeof(global::MagicHour.VideoProjectsGetDetailsResponseCode4)

                    || typeToConvert == typeof(global::MagicHour.VideoProjectsGetDetailsResponseCode4?)

                    || typeToConvert == typeof(global::MagicHour.VideoProjectsGetDetailsResponseCode5)

                    || typeToConvert == typeof(global::MagicHour.VideoProjectsGetDetailsResponseCode5?)

                    || typeToConvert == typeof(global::MagicHour.VideoProjectsDeleteResponseCode)

                    || typeToConvert == typeof(global::MagicHour.VideoProjectsDeleteResponseCode?)

                    || typeToConvert == typeof(global::MagicHour.VideoProjectsDeleteResponseCode2)

                    || typeToConvert == typeof(global::MagicHour.VideoProjectsDeleteResponseCode2?)

                    || typeToConvert == typeof(global::MagicHour.VideoProjectsDeleteResponseCode3)

                    || typeToConvert == typeof(global::MagicHour.VideoProjectsDeleteResponseCode3?)

                    || typeToConvert == typeof(global::MagicHour.VideoProjectsDeleteResponseCode4)

                    || typeToConvert == typeof(global::MagicHour.VideoProjectsDeleteResponseCode4?)

                    || typeToConvert == typeof(global::MagicHour.VideoProjectsDeleteResponseCode5)

                    || typeToConvert == typeof(global::MagicHour.VideoProjectsDeleteResponseCode5?)

                    || typeToConvert == typeof(global::MagicHour.VideoProjectsDeleteResponseCode6)

                    || typeToConvert == typeof(global::MagicHour.VideoProjectsDeleteResponseCode6?)

                    || typeToConvert == typeof(global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponseCode)

                    || typeToConvert == typeof(global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponseCode?)

                    || typeToConvert == typeof(global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponseCode2)

                    || typeToConvert == typeof(global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponseCode2?)

                    || typeToConvert == typeof(global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponseCode3)

                    || typeToConvert == typeof(global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponseCode3?)

                    || typeToConvert == typeof(global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponseCode4)

                    || typeToConvert == typeof(global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponseCode4?)

                    || typeToConvert == typeof(global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponseCode5)

                    || typeToConvert == typeof(global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponseCode5?)

                    || typeToConvert == typeof(global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponseCode6)

                    || typeToConvert == typeof(global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponseCode6?)

                    || typeToConvert == typeof(global::MagicHour.AiVideoEditorCreateVideoResponseCode)

                    || typeToConvert == typeof(global::MagicHour.AiVideoEditorCreateVideoResponseCode?)

                    || typeToConvert == typeof(global::MagicHour.AiVideoEditorCreateVideoResponseCode2)

                    || typeToConvert == typeof(global::MagicHour.AiVideoEditorCreateVideoResponseCode2?)

                    || typeToConvert == typeof(global::MagicHour.AiVideoEditorCreateVideoResponseCode3)

                    || typeToConvert == typeof(global::MagicHour.AiVideoEditorCreateVideoResponseCode3?)

                    || typeToConvert == typeof(global::MagicHour.AiVideoEditorCreateVideoResponseCode4)

                    || typeToConvert == typeof(global::MagicHour.AiVideoEditorCreateVideoResponseCode4?)

                    || typeToConvert == typeof(global::MagicHour.AiVideoEditorCreateVideoResponseCode5)

                    || typeToConvert == typeof(global::MagicHour.AiVideoEditorCreateVideoResponseCode5?)

                    || typeToConvert == typeof(global::MagicHour.AiVideoEditorCreateVideoResponseCode6)

                    || typeToConvert == typeof(global::MagicHour.AiVideoEditorCreateVideoResponseCode6?)

                    || typeToConvert == typeof(global::MagicHour.AnimationCreateVideoResponseCode)

                    || typeToConvert == typeof(global::MagicHour.AnimationCreateVideoResponseCode?)

                    || typeToConvert == typeof(global::MagicHour.AnimationCreateVideoResponseCode2)

                    || typeToConvert == typeof(global::MagicHour.AnimationCreateVideoResponseCode2?)

                    || typeToConvert == typeof(global::MagicHour.AnimationCreateVideoResponseCode3)

                    || typeToConvert == typeof(global::MagicHour.AnimationCreateVideoResponseCode3?)

                    || typeToConvert == typeof(global::MagicHour.AnimationCreateVideoResponseCode4)

                    || typeToConvert == typeof(global::MagicHour.AnimationCreateVideoResponseCode4?)

                    || typeToConvert == typeof(global::MagicHour.AnimationCreateVideoResponseCode5)

                    || typeToConvert == typeof(global::MagicHour.AnimationCreateVideoResponseCode5?)

                    || typeToConvert == typeof(global::MagicHour.AnimationCreateVideoResponseCode6)

                    || typeToConvert == typeof(global::MagicHour.AnimationCreateVideoResponseCode6?)

                    || typeToConvert == typeof(global::MagicHour.AudioToVideoCreateVideoResponseCode)

                    || typeToConvert == typeof(global::MagicHour.AudioToVideoCreateVideoResponseCode?)

                    || typeToConvert == typeof(global::MagicHour.AudioToVideoCreateVideoResponseCode2)

                    || typeToConvert == typeof(global::MagicHour.AudioToVideoCreateVideoResponseCode2?)

                    || typeToConvert == typeof(global::MagicHour.AudioToVideoCreateVideoResponseCode3)

                    || typeToConvert == typeof(global::MagicHour.AudioToVideoCreateVideoResponseCode3?)

                    || typeToConvert == typeof(global::MagicHour.AudioToVideoCreateVideoResponseCode4)

                    || typeToConvert == typeof(global::MagicHour.AudioToVideoCreateVideoResponseCode4?)

                    || typeToConvert == typeof(global::MagicHour.AudioToVideoCreateVideoResponseCode5)

                    || typeToConvert == typeof(global::MagicHour.AudioToVideoCreateVideoResponseCode5?)

                    || typeToConvert == typeof(global::MagicHour.AudioToVideoCreateVideoResponseCode6)

                    || typeToConvert == typeof(global::MagicHour.AudioToVideoCreateVideoResponseCode6?)

                    || typeToConvert == typeof(global::MagicHour.AutoSubtitleGeneratorCreateVideoResponseCode)

                    || typeToConvert == typeof(global::MagicHour.AutoSubtitleGeneratorCreateVideoResponseCode?)

                    || typeToConvert == typeof(global::MagicHour.AutoSubtitleGeneratorCreateVideoResponseCode2)

                    || typeToConvert == typeof(global::MagicHour.AutoSubtitleGeneratorCreateVideoResponseCode2?)

                    || typeToConvert == typeof(global::MagicHour.AutoSubtitleGeneratorCreateVideoResponseCode3)

                    || typeToConvert == typeof(global::MagicHour.AutoSubtitleGeneratorCreateVideoResponseCode3?)

                    || typeToConvert == typeof(global::MagicHour.AutoSubtitleGeneratorCreateVideoResponseCode4)

                    || typeToConvert == typeof(global::MagicHour.AutoSubtitleGeneratorCreateVideoResponseCode4?)

                    || typeToConvert == typeof(global::MagicHour.AutoSubtitleGeneratorCreateVideoResponseCode5)

                    || typeToConvert == typeof(global::MagicHour.AutoSubtitleGeneratorCreateVideoResponseCode5?)

                    || typeToConvert == typeof(global::MagicHour.AutoSubtitleGeneratorCreateVideoResponseCode6)

                    || typeToConvert == typeof(global::MagicHour.AutoSubtitleGeneratorCreateVideoResponseCode6?)

                    || typeToConvert == typeof(global::MagicHour.CharacterReplaceCreateVideoResponseCode)

                    || typeToConvert == typeof(global::MagicHour.CharacterReplaceCreateVideoResponseCode?)

                    || typeToConvert == typeof(global::MagicHour.CharacterReplaceCreateVideoResponseCode2)

                    || typeToConvert == typeof(global::MagicHour.CharacterReplaceCreateVideoResponseCode2?)

                    || typeToConvert == typeof(global::MagicHour.CharacterReplaceCreateVideoResponseCode3)

                    || typeToConvert == typeof(global::MagicHour.CharacterReplaceCreateVideoResponseCode3?)

                    || typeToConvert == typeof(global::MagicHour.CharacterReplaceCreateVideoResponseCode4)

                    || typeToConvert == typeof(global::MagicHour.CharacterReplaceCreateVideoResponseCode4?)

                    || typeToConvert == typeof(global::MagicHour.CharacterReplaceCreateVideoResponseCode5)

                    || typeToConvert == typeof(global::MagicHour.CharacterReplaceCreateVideoResponseCode5?)

                    || typeToConvert == typeof(global::MagicHour.CharacterReplaceCreateVideoResponseCode6)

                    || typeToConvert == typeof(global::MagicHour.CharacterReplaceCreateVideoResponseCode6?)

                    || typeToConvert == typeof(global::MagicHour.FaceSwapCreateVideoResponseCode)

                    || typeToConvert == typeof(global::MagicHour.FaceSwapCreateVideoResponseCode?)

                    || typeToConvert == typeof(global::MagicHour.FaceSwapCreateVideoResponseCode2)

                    || typeToConvert == typeof(global::MagicHour.FaceSwapCreateVideoResponseCode2?)

                    || typeToConvert == typeof(global::MagicHour.FaceSwapCreateVideoResponseCode3)

                    || typeToConvert == typeof(global::MagicHour.FaceSwapCreateVideoResponseCode3?)

                    || typeToConvert == typeof(global::MagicHour.FaceSwapCreateVideoResponseCode4)

                    || typeToConvert == typeof(global::MagicHour.FaceSwapCreateVideoResponseCode4?)

                    || typeToConvert == typeof(global::MagicHour.FaceSwapCreateVideoResponseCode5)

                    || typeToConvert == typeof(global::MagicHour.FaceSwapCreateVideoResponseCode5?)

                    || typeToConvert == typeof(global::MagicHour.FaceSwapCreateVideoResponseCode6)

                    || typeToConvert == typeof(global::MagicHour.FaceSwapCreateVideoResponseCode6?)

                    || typeToConvert == typeof(global::MagicHour.ImageToVideoCreateVideoResponseCode)

                    || typeToConvert == typeof(global::MagicHour.ImageToVideoCreateVideoResponseCode?)

                    || typeToConvert == typeof(global::MagicHour.ImageToVideoCreateVideoResponseCode2)

                    || typeToConvert == typeof(global::MagicHour.ImageToVideoCreateVideoResponseCode2?)

                    || typeToConvert == typeof(global::MagicHour.ImageToVideoCreateVideoResponseCode3)

                    || typeToConvert == typeof(global::MagicHour.ImageToVideoCreateVideoResponseCode3?)

                    || typeToConvert == typeof(global::MagicHour.ImageToVideoCreateVideoResponseCode4)

                    || typeToConvert == typeof(global::MagicHour.ImageToVideoCreateVideoResponseCode4?)

                    || typeToConvert == typeof(global::MagicHour.ImageToVideoCreateVideoResponseCode5)

                    || typeToConvert == typeof(global::MagicHour.ImageToVideoCreateVideoResponseCode5?)

                    || typeToConvert == typeof(global::MagicHour.ImageToVideoCreateVideoResponseCode6)

                    || typeToConvert == typeof(global::MagicHour.ImageToVideoCreateVideoResponseCode6?)

                    || typeToConvert == typeof(global::MagicHour.LipSyncCreateVideoResponseCode)

                    || typeToConvert == typeof(global::MagicHour.LipSyncCreateVideoResponseCode?)

                    || typeToConvert == typeof(global::MagicHour.LipSyncCreateVideoResponseCode2)

                    || typeToConvert == typeof(global::MagicHour.LipSyncCreateVideoResponseCode2?)

                    || typeToConvert == typeof(global::MagicHour.LipSyncCreateVideoResponseCode3)

                    || typeToConvert == typeof(global::MagicHour.LipSyncCreateVideoResponseCode3?)

                    || typeToConvert == typeof(global::MagicHour.LipSyncCreateVideoResponseCode4)

                    || typeToConvert == typeof(global::MagicHour.LipSyncCreateVideoResponseCode4?)

                    || typeToConvert == typeof(global::MagicHour.LipSyncCreateVideoResponseCode5)

                    || typeToConvert == typeof(global::MagicHour.LipSyncCreateVideoResponseCode5?)

                    || typeToConvert == typeof(global::MagicHour.LipSyncCreateVideoResponseCode6)

                    || typeToConvert == typeof(global::MagicHour.LipSyncCreateVideoResponseCode6?)

                    || typeToConvert == typeof(global::MagicHour.TextToVideoCreateVideoResponseCode)

                    || typeToConvert == typeof(global::MagicHour.TextToVideoCreateVideoResponseCode?)

                    || typeToConvert == typeof(global::MagicHour.TextToVideoCreateVideoResponseCode2)

                    || typeToConvert == typeof(global::MagicHour.TextToVideoCreateVideoResponseCode2?)

                    || typeToConvert == typeof(global::MagicHour.TextToVideoCreateVideoResponseCode3)

                    || typeToConvert == typeof(global::MagicHour.TextToVideoCreateVideoResponseCode3?)

                    || typeToConvert == typeof(global::MagicHour.TextToVideoCreateVideoResponseCode4)

                    || typeToConvert == typeof(global::MagicHour.TextToVideoCreateVideoResponseCode4?)

                    || typeToConvert == typeof(global::MagicHour.TextToVideoCreateVideoResponseCode5)

                    || typeToConvert == typeof(global::MagicHour.TextToVideoCreateVideoResponseCode5?)

                    || typeToConvert == typeof(global::MagicHour.TextToVideoCreateVideoResponseCode6)

                    || typeToConvert == typeof(global::MagicHour.TextToVideoCreateVideoResponseCode6?)

                    || typeToConvert == typeof(global::MagicHour.VideoToVideoCreateVideoResponseCode)

                    || typeToConvert == typeof(global::MagicHour.VideoToVideoCreateVideoResponseCode?)

                    || typeToConvert == typeof(global::MagicHour.VideoToVideoCreateVideoResponseCode2)

                    || typeToConvert == typeof(global::MagicHour.VideoToVideoCreateVideoResponseCode2?)

                    || typeToConvert == typeof(global::MagicHour.VideoToVideoCreateVideoResponseCode3)

                    || typeToConvert == typeof(global::MagicHour.VideoToVideoCreateVideoResponseCode3?)

                    || typeToConvert == typeof(global::MagicHour.VideoToVideoCreateVideoResponseCode4)

                    || typeToConvert == typeof(global::MagicHour.VideoToVideoCreateVideoResponseCode4?)

                    || typeToConvert == typeof(global::MagicHour.VideoToVideoCreateVideoResponseCode5)

                    || typeToConvert == typeof(global::MagicHour.VideoToVideoCreateVideoResponseCode5?)

                    || typeToConvert == typeof(global::MagicHour.VideoToVideoCreateVideoResponseCode6)

                    || typeToConvert == typeof(global::MagicHour.VideoToVideoCreateVideoResponseCode6?)

                    || typeToConvert == typeof(global::MagicHour.ImageProjectsGetDetailsResponseStatus)

                    || typeToConvert == typeof(global::MagicHour.ImageProjectsGetDetailsResponseStatus?)

                    || typeToConvert == typeof(global::MagicHour.ImageProjectsGetDetailsResponseCode)

                    || typeToConvert == typeof(global::MagicHour.ImageProjectsGetDetailsResponseCode?)

                    || typeToConvert == typeof(global::MagicHour.ImageProjectsGetDetailsResponseCode2)

                    || typeToConvert == typeof(global::MagicHour.ImageProjectsGetDetailsResponseCode2?)

                    || typeToConvert == typeof(global::MagicHour.ImageProjectsGetDetailsResponseCode3)

                    || typeToConvert == typeof(global::MagicHour.ImageProjectsGetDetailsResponseCode3?)

                    || typeToConvert == typeof(global::MagicHour.ImageProjectsGetDetailsResponseCode4)

                    || typeToConvert == typeof(global::MagicHour.ImageProjectsGetDetailsResponseCode4?)

                    || typeToConvert == typeof(global::MagicHour.ImageProjectsGetDetailsResponseCode5)

                    || typeToConvert == typeof(global::MagicHour.ImageProjectsGetDetailsResponseCode5?)

                    || typeToConvert == typeof(global::MagicHour.ImageProjectsDeleteResponseCode)

                    || typeToConvert == typeof(global::MagicHour.ImageProjectsDeleteResponseCode?)

                    || typeToConvert == typeof(global::MagicHour.ImageProjectsDeleteResponseCode2)

                    || typeToConvert == typeof(global::MagicHour.ImageProjectsDeleteResponseCode2?)

                    || typeToConvert == typeof(global::MagicHour.ImageProjectsDeleteResponseCode3)

                    || typeToConvert == typeof(global::MagicHour.ImageProjectsDeleteResponseCode3?)

                    || typeToConvert == typeof(global::MagicHour.ImageProjectsDeleteResponseCode4)

                    || typeToConvert == typeof(global::MagicHour.ImageProjectsDeleteResponseCode4?)

                    || typeToConvert == typeof(global::MagicHour.ImageProjectsDeleteResponseCode5)

                    || typeToConvert == typeof(global::MagicHour.ImageProjectsDeleteResponseCode5?)

                    || typeToConvert == typeof(global::MagicHour.AiClothesChangerCreateImageResponseCode)

                    || typeToConvert == typeof(global::MagicHour.AiClothesChangerCreateImageResponseCode?)

                    || typeToConvert == typeof(global::MagicHour.AiClothesChangerCreateImageResponseCode2)

                    || typeToConvert == typeof(global::MagicHour.AiClothesChangerCreateImageResponseCode2?)

                    || typeToConvert == typeof(global::MagicHour.AiClothesChangerCreateImageResponseCode3)

                    || typeToConvert == typeof(global::MagicHour.AiClothesChangerCreateImageResponseCode3?)

                    || typeToConvert == typeof(global::MagicHour.AiClothesChangerCreateImageResponseCode4)

                    || typeToConvert == typeof(global::MagicHour.AiClothesChangerCreateImageResponseCode4?)

                    || typeToConvert == typeof(global::MagicHour.AiClothesChangerCreateImageResponseCode5)

                    || typeToConvert == typeof(global::MagicHour.AiClothesChangerCreateImageResponseCode5?)

                    || typeToConvert == typeof(global::MagicHour.AiClothesChangerCreateImageResponseCode6)

                    || typeToConvert == typeof(global::MagicHour.AiClothesChangerCreateImageResponseCode6?)

                    || typeToConvert == typeof(global::MagicHour.AiFaceEditorEditImageResponseCode)

                    || typeToConvert == typeof(global::MagicHour.AiFaceEditorEditImageResponseCode?)

                    || typeToConvert == typeof(global::MagicHour.AiFaceEditorEditImageResponseCode2)

                    || typeToConvert == typeof(global::MagicHour.AiFaceEditorEditImageResponseCode2?)

                    || typeToConvert == typeof(global::MagicHour.AiFaceEditorEditImageResponseCode3)

                    || typeToConvert == typeof(global::MagicHour.AiFaceEditorEditImageResponseCode3?)

                    || typeToConvert == typeof(global::MagicHour.AiFaceEditorEditImageResponseCode4)

                    || typeToConvert == typeof(global::MagicHour.AiFaceEditorEditImageResponseCode4?)

                    || typeToConvert == typeof(global::MagicHour.AiFaceEditorEditImageResponseCode5)

                    || typeToConvert == typeof(global::MagicHour.AiFaceEditorEditImageResponseCode5?)

                    || typeToConvert == typeof(global::MagicHour.AiFaceEditorEditImageResponseCode6)

                    || typeToConvert == typeof(global::MagicHour.AiFaceEditorEditImageResponseCode6?)

                    || typeToConvert == typeof(global::MagicHour.AiGifGeneratorCreateImageResponseCode)

                    || typeToConvert == typeof(global::MagicHour.AiGifGeneratorCreateImageResponseCode?)

                    || typeToConvert == typeof(global::MagicHour.AiGifGeneratorCreateImageResponseCode2)

                    || typeToConvert == typeof(global::MagicHour.AiGifGeneratorCreateImageResponseCode2?)

                    || typeToConvert == typeof(global::MagicHour.AiGifGeneratorCreateImageResponseCode3)

                    || typeToConvert == typeof(global::MagicHour.AiGifGeneratorCreateImageResponseCode3?)

                    || typeToConvert == typeof(global::MagicHour.AiGifGeneratorCreateImageResponseCode4)

                    || typeToConvert == typeof(global::MagicHour.AiGifGeneratorCreateImageResponseCode4?)

                    || typeToConvert == typeof(global::MagicHour.AiGifGeneratorCreateImageResponseCode5)

                    || typeToConvert == typeof(global::MagicHour.AiGifGeneratorCreateImageResponseCode5?)

                    || typeToConvert == typeof(global::MagicHour.AiGifGeneratorCreateImageResponseCode6)

                    || typeToConvert == typeof(global::MagicHour.AiGifGeneratorCreateImageResponseCode6?)

                    || typeToConvert == typeof(global::MagicHour.AiImageEditorCreateImageResponseCode)

                    || typeToConvert == typeof(global::MagicHour.AiImageEditorCreateImageResponseCode?)

                    || typeToConvert == typeof(global::MagicHour.AiImageEditorCreateImageResponseCode2)

                    || typeToConvert == typeof(global::MagicHour.AiImageEditorCreateImageResponseCode2?)

                    || typeToConvert == typeof(global::MagicHour.AiImageEditorCreateImageResponseCode3)

                    || typeToConvert == typeof(global::MagicHour.AiImageEditorCreateImageResponseCode3?)

                    || typeToConvert == typeof(global::MagicHour.AiImageEditorCreateImageResponseCode4)

                    || typeToConvert == typeof(global::MagicHour.AiImageEditorCreateImageResponseCode4?)

                    || typeToConvert == typeof(global::MagicHour.AiImageEditorCreateImageResponseCode5)

                    || typeToConvert == typeof(global::MagicHour.AiImageEditorCreateImageResponseCode5?)

                    || typeToConvert == typeof(global::MagicHour.AiImageEditorCreateImageResponseCode6)

                    || typeToConvert == typeof(global::MagicHour.AiImageEditorCreateImageResponseCode6?)

                    || typeToConvert == typeof(global::MagicHour.AiHeadshotGeneratorCreateImageResponseCode)

                    || typeToConvert == typeof(global::MagicHour.AiHeadshotGeneratorCreateImageResponseCode?)

                    || typeToConvert == typeof(global::MagicHour.AiHeadshotGeneratorCreateImageResponseCode2)

                    || typeToConvert == typeof(global::MagicHour.AiHeadshotGeneratorCreateImageResponseCode2?)

                    || typeToConvert == typeof(global::MagicHour.AiHeadshotGeneratorCreateImageResponseCode3)

                    || typeToConvert == typeof(global::MagicHour.AiHeadshotGeneratorCreateImageResponseCode3?)

                    || typeToConvert == typeof(global::MagicHour.AiHeadshotGeneratorCreateImageResponseCode4)

                    || typeToConvert == typeof(global::MagicHour.AiHeadshotGeneratorCreateImageResponseCode4?)

                    || typeToConvert == typeof(global::MagicHour.AiHeadshotGeneratorCreateImageResponseCode5)

                    || typeToConvert == typeof(global::MagicHour.AiHeadshotGeneratorCreateImageResponseCode5?)

                    || typeToConvert == typeof(global::MagicHour.AiHeadshotGeneratorCreateImageResponseCode6)

                    || typeToConvert == typeof(global::MagicHour.AiHeadshotGeneratorCreateImageResponseCode6?)

                    || typeToConvert == typeof(global::MagicHour.AiImageGeneratorCreateImageResponseCode)

                    || typeToConvert == typeof(global::MagicHour.AiImageGeneratorCreateImageResponseCode?)

                    || typeToConvert == typeof(global::MagicHour.AiImageGeneratorCreateImageResponseCode2)

                    || typeToConvert == typeof(global::MagicHour.AiImageGeneratorCreateImageResponseCode2?)

                    || typeToConvert == typeof(global::MagicHour.AiImageGeneratorCreateImageResponseCode3)

                    || typeToConvert == typeof(global::MagicHour.AiImageGeneratorCreateImageResponseCode3?)

                    || typeToConvert == typeof(global::MagicHour.AiImageGeneratorCreateImageResponseCode4)

                    || typeToConvert == typeof(global::MagicHour.AiImageGeneratorCreateImageResponseCode4?)

                    || typeToConvert == typeof(global::MagicHour.AiImageGeneratorCreateImageResponseCode5)

                    || typeToConvert == typeof(global::MagicHour.AiImageGeneratorCreateImageResponseCode5?)

                    || typeToConvert == typeof(global::MagicHour.AiImageGeneratorCreateImageResponseCode6)

                    || typeToConvert == typeof(global::MagicHour.AiImageGeneratorCreateImageResponseCode6?)

                    || typeToConvert == typeof(global::MagicHour.AiImageUpscalerCreateImageResponseCode)

                    || typeToConvert == typeof(global::MagicHour.AiImageUpscalerCreateImageResponseCode?)

                    || typeToConvert == typeof(global::MagicHour.AiImageUpscalerCreateImageResponseCode2)

                    || typeToConvert == typeof(global::MagicHour.AiImageUpscalerCreateImageResponseCode2?)

                    || typeToConvert == typeof(global::MagicHour.AiImageUpscalerCreateImageResponseCode3)

                    || typeToConvert == typeof(global::MagicHour.AiImageUpscalerCreateImageResponseCode3?)

                    || typeToConvert == typeof(global::MagicHour.AiImageUpscalerCreateImageResponseCode4)

                    || typeToConvert == typeof(global::MagicHour.AiImageUpscalerCreateImageResponseCode4?)

                    || typeToConvert == typeof(global::MagicHour.AiImageUpscalerCreateImageResponseCode5)

                    || typeToConvert == typeof(global::MagicHour.AiImageUpscalerCreateImageResponseCode5?)

                    || typeToConvert == typeof(global::MagicHour.AiImageUpscalerCreateImageResponseCode6)

                    || typeToConvert == typeof(global::MagicHour.AiImageUpscalerCreateImageResponseCode6?)

                    || typeToConvert == typeof(global::MagicHour.AiMemeGeneratorCreateImageResponseCode)

                    || typeToConvert == typeof(global::MagicHour.AiMemeGeneratorCreateImageResponseCode?)

                    || typeToConvert == typeof(global::MagicHour.AiMemeGeneratorCreateImageResponseCode2)

                    || typeToConvert == typeof(global::MagicHour.AiMemeGeneratorCreateImageResponseCode2?)

                    || typeToConvert == typeof(global::MagicHour.AiMemeGeneratorCreateImageResponseCode3)

                    || typeToConvert == typeof(global::MagicHour.AiMemeGeneratorCreateImageResponseCode3?)

                    || typeToConvert == typeof(global::MagicHour.AiMemeGeneratorCreateImageResponseCode4)

                    || typeToConvert == typeof(global::MagicHour.AiMemeGeneratorCreateImageResponseCode4?)

                    || typeToConvert == typeof(global::MagicHour.AiMemeGeneratorCreateImageResponseCode5)

                    || typeToConvert == typeof(global::MagicHour.AiMemeGeneratorCreateImageResponseCode5?)

                    || typeToConvert == typeof(global::MagicHour.AiMemeGeneratorCreateImageResponseCode6)

                    || typeToConvert == typeof(global::MagicHour.AiMemeGeneratorCreateImageResponseCode6?)

                    || typeToConvert == typeof(global::MagicHour.AiQrCodeGeneratorCreateImageResponseCode)

                    || typeToConvert == typeof(global::MagicHour.AiQrCodeGeneratorCreateImageResponseCode?)

                    || typeToConvert == typeof(global::MagicHour.AiQrCodeGeneratorCreateImageResponseCode2)

                    || typeToConvert == typeof(global::MagicHour.AiQrCodeGeneratorCreateImageResponseCode2?)

                    || typeToConvert == typeof(global::MagicHour.AiQrCodeGeneratorCreateImageResponseCode3)

                    || typeToConvert == typeof(global::MagicHour.AiQrCodeGeneratorCreateImageResponseCode3?)

                    || typeToConvert == typeof(global::MagicHour.AiQrCodeGeneratorCreateImageResponseCode4)

                    || typeToConvert == typeof(global::MagicHour.AiQrCodeGeneratorCreateImageResponseCode4?)

                    || typeToConvert == typeof(global::MagicHour.AiQrCodeGeneratorCreateImageResponseCode5)

                    || typeToConvert == typeof(global::MagicHour.AiQrCodeGeneratorCreateImageResponseCode5?)

                    || typeToConvert == typeof(global::MagicHour.AiQrCodeGeneratorCreateImageResponseCode6)

                    || typeToConvert == typeof(global::MagicHour.AiQrCodeGeneratorCreateImageResponseCode6?)

                    || typeToConvert == typeof(global::MagicHour.BodySwapCreateImageResponseCode)

                    || typeToConvert == typeof(global::MagicHour.BodySwapCreateImageResponseCode?)

                    || typeToConvert == typeof(global::MagicHour.BodySwapCreateImageResponseCode2)

                    || typeToConvert == typeof(global::MagicHour.BodySwapCreateImageResponseCode2?)

                    || typeToConvert == typeof(global::MagicHour.BodySwapCreateImageResponseCode3)

                    || typeToConvert == typeof(global::MagicHour.BodySwapCreateImageResponseCode3?)

                    || typeToConvert == typeof(global::MagicHour.BodySwapCreateImageResponseCode4)

                    || typeToConvert == typeof(global::MagicHour.BodySwapCreateImageResponseCode4?)

                    || typeToConvert == typeof(global::MagicHour.BodySwapCreateImageResponseCode5)

                    || typeToConvert == typeof(global::MagicHour.BodySwapCreateImageResponseCode5?)

                    || typeToConvert == typeof(global::MagicHour.BodySwapCreateImageResponseCode6)

                    || typeToConvert == typeof(global::MagicHour.BodySwapCreateImageResponseCode6?)

                    || typeToConvert == typeof(global::MagicHour.FaceSwapPhotoCreateImageResponseCode)

                    || typeToConvert == typeof(global::MagicHour.FaceSwapPhotoCreateImageResponseCode?)

                    || typeToConvert == typeof(global::MagicHour.FaceSwapPhotoCreateImageResponseCode2)

                    || typeToConvert == typeof(global::MagicHour.FaceSwapPhotoCreateImageResponseCode2?)

                    || typeToConvert == typeof(global::MagicHour.FaceSwapPhotoCreateImageResponseCode3)

                    || typeToConvert == typeof(global::MagicHour.FaceSwapPhotoCreateImageResponseCode3?)

                    || typeToConvert == typeof(global::MagicHour.FaceSwapPhotoCreateImageResponseCode4)

                    || typeToConvert == typeof(global::MagicHour.FaceSwapPhotoCreateImageResponseCode4?)

                    || typeToConvert == typeof(global::MagicHour.FaceSwapPhotoCreateImageResponseCode5)

                    || typeToConvert == typeof(global::MagicHour.FaceSwapPhotoCreateImageResponseCode5?)

                    || typeToConvert == typeof(global::MagicHour.FaceSwapPhotoCreateImageResponseCode6)

                    || typeToConvert == typeof(global::MagicHour.FaceSwapPhotoCreateImageResponseCode6?)

                    || typeToConvert == typeof(global::MagicHour.HeadSwapCreateImageResponseCode)

                    || typeToConvert == typeof(global::MagicHour.HeadSwapCreateImageResponseCode?)

                    || typeToConvert == typeof(global::MagicHour.HeadSwapCreateImageResponseCode2)

                    || typeToConvert == typeof(global::MagicHour.HeadSwapCreateImageResponseCode2?)

                    || typeToConvert == typeof(global::MagicHour.HeadSwapCreateImageResponseCode3)

                    || typeToConvert == typeof(global::MagicHour.HeadSwapCreateImageResponseCode3?)

                    || typeToConvert == typeof(global::MagicHour.HeadSwapCreateImageResponseCode4)

                    || typeToConvert == typeof(global::MagicHour.HeadSwapCreateImageResponseCode4?)

                    || typeToConvert == typeof(global::MagicHour.HeadSwapCreateImageResponseCode5)

                    || typeToConvert == typeof(global::MagicHour.HeadSwapCreateImageResponseCode5?)

                    || typeToConvert == typeof(global::MagicHour.HeadSwapCreateImageResponseCode6)

                    || typeToConvert == typeof(global::MagicHour.HeadSwapCreateImageResponseCode6?)

                    || typeToConvert == typeof(global::MagicHour.ImageBackgroundRemoverCreateImageResponseCode)

                    || typeToConvert == typeof(global::MagicHour.ImageBackgroundRemoverCreateImageResponseCode?)

                    || typeToConvert == typeof(global::MagicHour.ImageBackgroundRemoverCreateImageResponseCode2)

                    || typeToConvert == typeof(global::MagicHour.ImageBackgroundRemoverCreateImageResponseCode2?)

                    || typeToConvert == typeof(global::MagicHour.ImageBackgroundRemoverCreateImageResponseCode3)

                    || typeToConvert == typeof(global::MagicHour.ImageBackgroundRemoverCreateImageResponseCode3?)

                    || typeToConvert == typeof(global::MagicHour.ImageBackgroundRemoverCreateImageResponseCode4)

                    || typeToConvert == typeof(global::MagicHour.ImageBackgroundRemoverCreateImageResponseCode4?)

                    || typeToConvert == typeof(global::MagicHour.ImageBackgroundRemoverCreateImageResponseCode5)

                    || typeToConvert == typeof(global::MagicHour.ImageBackgroundRemoverCreateImageResponseCode5?)

                    || typeToConvert == typeof(global::MagicHour.ImageBackgroundRemoverCreateImageResponseCode6)

                    || typeToConvert == typeof(global::MagicHour.ImageBackgroundRemoverCreateImageResponseCode6?)

                    || typeToConvert == typeof(global::MagicHour.PhotoColorizerCreateImageResponseCode)

                    || typeToConvert == typeof(global::MagicHour.PhotoColorizerCreateImageResponseCode?)

                    || typeToConvert == typeof(global::MagicHour.PhotoColorizerCreateImageResponseCode2)

                    || typeToConvert == typeof(global::MagicHour.PhotoColorizerCreateImageResponseCode2?)

                    || typeToConvert == typeof(global::MagicHour.PhotoColorizerCreateImageResponseCode3)

                    || typeToConvert == typeof(global::MagicHour.PhotoColorizerCreateImageResponseCode3?)

                    || typeToConvert == typeof(global::MagicHour.PhotoColorizerCreateImageResponseCode4)

                    || typeToConvert == typeof(global::MagicHour.PhotoColorizerCreateImageResponseCode4?)

                    || typeToConvert == typeof(global::MagicHour.PhotoColorizerCreateImageResponseCode5)

                    || typeToConvert == typeof(global::MagicHour.PhotoColorizerCreateImageResponseCode5?)

                    || typeToConvert == typeof(global::MagicHour.PhotoColorizerCreateImageResponseCode6)

                    || typeToConvert == typeof(global::MagicHour.PhotoColorizerCreateImageResponseCode6?)

                    || typeToConvert == typeof(global::MagicHour.AudioProjectsGetDetailsResponseStatus)

                    || typeToConvert == typeof(global::MagicHour.AudioProjectsGetDetailsResponseStatus?)

                    || typeToConvert == typeof(global::MagicHour.AudioProjectsGetDetailsResponseCode)

                    || typeToConvert == typeof(global::MagicHour.AudioProjectsGetDetailsResponseCode?)

                    || typeToConvert == typeof(global::MagicHour.AudioProjectsGetDetailsResponseCode2)

                    || typeToConvert == typeof(global::MagicHour.AudioProjectsGetDetailsResponseCode2?)

                    || typeToConvert == typeof(global::MagicHour.AudioProjectsGetDetailsResponseCode3)

                    || typeToConvert == typeof(global::MagicHour.AudioProjectsGetDetailsResponseCode3?)

                    || typeToConvert == typeof(global::MagicHour.AudioProjectsGetDetailsResponseCode4)

                    || typeToConvert == typeof(global::MagicHour.AudioProjectsGetDetailsResponseCode4?)

                    || typeToConvert == typeof(global::MagicHour.AudioProjectsGetDetailsResponseCode5)

                    || typeToConvert == typeof(global::MagicHour.AudioProjectsGetDetailsResponseCode5?)

                    || typeToConvert == typeof(global::MagicHour.AudioProjectsDeleteResponseCode)

                    || typeToConvert == typeof(global::MagicHour.AudioProjectsDeleteResponseCode?)

                    || typeToConvert == typeof(global::MagicHour.AudioProjectsDeleteResponseCode2)

                    || typeToConvert == typeof(global::MagicHour.AudioProjectsDeleteResponseCode2?)

                    || typeToConvert == typeof(global::MagicHour.AudioProjectsDeleteResponseCode3)

                    || typeToConvert == typeof(global::MagicHour.AudioProjectsDeleteResponseCode3?)

                    || typeToConvert == typeof(global::MagicHour.AudioProjectsDeleteResponseCode4)

                    || typeToConvert == typeof(global::MagicHour.AudioProjectsDeleteResponseCode4?)

                    || typeToConvert == typeof(global::MagicHour.AudioProjectsDeleteResponseCode5)

                    || typeToConvert == typeof(global::MagicHour.AudioProjectsDeleteResponseCode5?)

                    || typeToConvert == typeof(global::MagicHour.AiVoiceGeneratorCreateAudioResponseCode)

                    || typeToConvert == typeof(global::MagicHour.AiVoiceGeneratorCreateAudioResponseCode?)

                    || typeToConvert == typeof(global::MagicHour.AiVoiceGeneratorCreateAudioResponseCode2)

                    || typeToConvert == typeof(global::MagicHour.AiVoiceGeneratorCreateAudioResponseCode2?)

                    || typeToConvert == typeof(global::MagicHour.AiVoiceGeneratorCreateAudioResponseCode3)

                    || typeToConvert == typeof(global::MagicHour.AiVoiceGeneratorCreateAudioResponseCode3?)

                    || typeToConvert == typeof(global::MagicHour.AiVoiceGeneratorCreateAudioResponseCode4)

                    || typeToConvert == typeof(global::MagicHour.AiVoiceGeneratorCreateAudioResponseCode4?)

                    || typeToConvert == typeof(global::MagicHour.AiVoiceGeneratorCreateAudioResponseCode5)

                    || typeToConvert == typeof(global::MagicHour.AiVoiceGeneratorCreateAudioResponseCode5?)

                    || typeToConvert == typeof(global::MagicHour.AiVoiceGeneratorCreateAudioResponseCode6)

                    || typeToConvert == typeof(global::MagicHour.AiVoiceGeneratorCreateAudioResponseCode6?)

                    || typeToConvert == typeof(global::MagicHour.AiVoiceClonerCreateAudioResponseCode)

                    || typeToConvert == typeof(global::MagicHour.AiVoiceClonerCreateAudioResponseCode?)

                    || typeToConvert == typeof(global::MagicHour.AiVoiceClonerCreateAudioResponseCode2)

                    || typeToConvert == typeof(global::MagicHour.AiVoiceClonerCreateAudioResponseCode2?)

                    || typeToConvert == typeof(global::MagicHour.AiVoiceClonerCreateAudioResponseCode3)

                    || typeToConvert == typeof(global::MagicHour.AiVoiceClonerCreateAudioResponseCode3?)

                    || typeToConvert == typeof(global::MagicHour.AiVoiceClonerCreateAudioResponseCode4)

                    || typeToConvert == typeof(global::MagicHour.AiVoiceClonerCreateAudioResponseCode4?)

                    || typeToConvert == typeof(global::MagicHour.AiVoiceClonerCreateAudioResponseCode5)

                    || typeToConvert == typeof(global::MagicHour.AiVoiceClonerCreateAudioResponseCode5?)

                    || typeToConvert == typeof(global::MagicHour.AiVoiceClonerCreateAudioResponseCode6)

                    || typeToConvert == typeof(global::MagicHour.AiVoiceClonerCreateAudioResponseCode6?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::MagicHour.VideoAssetsGeneratePresignedUrlRequestItemType))
                {
                    return new global::MagicHour.JsonConverters.VideoAssetsGeneratePresignedUrlRequestItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.VideoAssetsGeneratePresignedUrlRequestItemType?))
                {
                    return new global::MagicHour.JsonConverters.VideoAssetsGeneratePresignedUrlRequestItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiTalkingPhotoCreateTalkingPhotoRequestStyleGenerationMode))
                {
                    return new global::MagicHour.JsonConverters.AiTalkingPhotoCreateTalkingPhotoRequestStyleGenerationModeJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiTalkingPhotoCreateTalkingPhotoRequestStyleGenerationMode?))
                {
                    return new global::MagicHour.JsonConverters.AiTalkingPhotoCreateTalkingPhotoRequestStyleGenerationModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiVideoEditorCreateVideoRequestModel))
                {
                    return new global::MagicHour.JsonConverters.AiVideoEditorCreateVideoRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiVideoEditorCreateVideoRequestModel?))
                {
                    return new global::MagicHour.JsonConverters.AiVideoEditorCreateVideoRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiVideoEditorCreateVideoRequestResolution))
                {
                    return new global::MagicHour.JsonConverters.AiVideoEditorCreateVideoRequestResolutionJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiVideoEditorCreateVideoRequestResolution?))
                {
                    return new global::MagicHour.JsonConverters.AiVideoEditorCreateVideoRequestResolutionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AnimationCreateVideoRequestStyleArtStyle))
                {
                    return new global::MagicHour.JsonConverters.AnimationCreateVideoRequestStyleArtStyleJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AnimationCreateVideoRequestStyleArtStyle?))
                {
                    return new global::MagicHour.JsonConverters.AnimationCreateVideoRequestStyleArtStyleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AnimationCreateVideoRequestStyleCameraEffect))
                {
                    return new global::MagicHour.JsonConverters.AnimationCreateVideoRequestStyleCameraEffectJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AnimationCreateVideoRequestStyleCameraEffect?))
                {
                    return new global::MagicHour.JsonConverters.AnimationCreateVideoRequestStyleCameraEffectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AnimationCreateVideoRequestStylePromptType))
                {
                    return new global::MagicHour.JsonConverters.AnimationCreateVideoRequestStylePromptTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AnimationCreateVideoRequestStylePromptType?))
                {
                    return new global::MagicHour.JsonConverters.AnimationCreateVideoRequestStylePromptTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AnimationCreateVideoRequestAssetsAudioSource))
                {
                    return new global::MagicHour.JsonConverters.AnimationCreateVideoRequestAssetsAudioSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AnimationCreateVideoRequestAssetsAudioSource?))
                {
                    return new global::MagicHour.JsonConverters.AnimationCreateVideoRequestAssetsAudioSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AudioToVideoCreateVideoRequestResolution))
                {
                    return new global::MagicHour.JsonConverters.AudioToVideoCreateVideoRequestResolutionJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AudioToVideoCreateVideoRequestResolution?))
                {
                    return new global::MagicHour.JsonConverters.AudioToVideoCreateVideoRequestResolutionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AutoSubtitleGeneratorCreateVideoRequestStyleTemplate))
                {
                    return new global::MagicHour.JsonConverters.AutoSubtitleGeneratorCreateVideoRequestStyleTemplateJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AutoSubtitleGeneratorCreateVideoRequestStyleTemplate?))
                {
                    return new global::MagicHour.JsonConverters.AutoSubtitleGeneratorCreateVideoRequestStyleTemplateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.CharacterReplaceCreateVideoRequestResolution))
                {
                    return new global::MagicHour.JsonConverters.CharacterReplaceCreateVideoRequestResolutionJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.CharacterReplaceCreateVideoRequestResolution?))
                {
                    return new global::MagicHour.JsonConverters.CharacterReplaceCreateVideoRequestResolutionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.CharacterReplaceCreateVideoRequestStyleMode))
                {
                    return new global::MagicHour.JsonConverters.CharacterReplaceCreateVideoRequestStyleModeJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.CharacterReplaceCreateVideoRequestStyleMode?))
                {
                    return new global::MagicHour.JsonConverters.CharacterReplaceCreateVideoRequestStyleModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.CharacterReplaceCreateVideoRequestStyleSelectionMode))
                {
                    return new global::MagicHour.JsonConverters.CharacterReplaceCreateVideoRequestStyleSelectionModeJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.CharacterReplaceCreateVideoRequestStyleSelectionMode?))
                {
                    return new global::MagicHour.JsonConverters.CharacterReplaceCreateVideoRequestStyleSelectionModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.FaceSwapCreateVideoRequestStyleVersion))
                {
                    return new global::MagicHour.JsonConverters.FaceSwapCreateVideoRequestStyleVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.FaceSwapCreateVideoRequestStyleVersion?))
                {
                    return new global::MagicHour.JsonConverters.FaceSwapCreateVideoRequestStyleVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.FaceSwapCreateVideoRequestAssetsFaceSwapMode))
                {
                    return new global::MagicHour.JsonConverters.FaceSwapCreateVideoRequestAssetsFaceSwapModeJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.FaceSwapCreateVideoRequestAssetsFaceSwapMode?))
                {
                    return new global::MagicHour.JsonConverters.FaceSwapCreateVideoRequestAssetsFaceSwapModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.FaceSwapCreateVideoRequestAssetsVideoSource))
                {
                    return new global::MagicHour.JsonConverters.FaceSwapCreateVideoRequestAssetsVideoSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.FaceSwapCreateVideoRequestAssetsVideoSource?))
                {
                    return new global::MagicHour.JsonConverters.FaceSwapCreateVideoRequestAssetsVideoSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.ImageToVideoCreateVideoRequestModel))
                {
                    return new global::MagicHour.JsonConverters.ImageToVideoCreateVideoRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.ImageToVideoCreateVideoRequestModel?))
                {
                    return new global::MagicHour.JsonConverters.ImageToVideoCreateVideoRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.ImageToVideoCreateVideoRequestResolution))
                {
                    return new global::MagicHour.JsonConverters.ImageToVideoCreateVideoRequestResolutionJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.ImageToVideoCreateVideoRequestResolution?))
                {
                    return new global::MagicHour.JsonConverters.ImageToVideoCreateVideoRequestResolutionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.LipSyncCreateVideoRequestAssetsVideoSource))
                {
                    return new global::MagicHour.JsonConverters.LipSyncCreateVideoRequestAssetsVideoSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.LipSyncCreateVideoRequestAssetsVideoSource?))
                {
                    return new global::MagicHour.JsonConverters.LipSyncCreateVideoRequestAssetsVideoSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.LipSyncCreateVideoRequestStyleGenerationMode))
                {
                    return new global::MagicHour.JsonConverters.LipSyncCreateVideoRequestStyleGenerationModeJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.LipSyncCreateVideoRequestStyleGenerationMode?))
                {
                    return new global::MagicHour.JsonConverters.LipSyncCreateVideoRequestStyleGenerationModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.TextToVideoCreateVideoRequestAspectRatio))
                {
                    return new global::MagicHour.JsonConverters.TextToVideoCreateVideoRequestAspectRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.TextToVideoCreateVideoRequestAspectRatio?))
                {
                    return new global::MagicHour.JsonConverters.TextToVideoCreateVideoRequestAspectRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.TextToVideoCreateVideoRequestResolution))
                {
                    return new global::MagicHour.JsonConverters.TextToVideoCreateVideoRequestResolutionJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.TextToVideoCreateVideoRequestResolution?))
                {
                    return new global::MagicHour.JsonConverters.TextToVideoCreateVideoRequestResolutionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.TextToVideoCreateVideoRequestModel))
                {
                    return new global::MagicHour.JsonConverters.TextToVideoCreateVideoRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.TextToVideoCreateVideoRequestModel?))
                {
                    return new global::MagicHour.JsonConverters.TextToVideoCreateVideoRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.VideoToVideoCreateVideoRequestFpsResolution))
                {
                    return new global::MagicHour.JsonConverters.VideoToVideoCreateVideoRequestFpsResolutionJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.VideoToVideoCreateVideoRequestFpsResolution?))
                {
                    return new global::MagicHour.JsonConverters.VideoToVideoCreateVideoRequestFpsResolutionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.VideoToVideoCreateVideoRequestStyleArtStyle))
                {
                    return new global::MagicHour.JsonConverters.VideoToVideoCreateVideoRequestStyleArtStyleJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.VideoToVideoCreateVideoRequestStyleArtStyle?))
                {
                    return new global::MagicHour.JsonConverters.VideoToVideoCreateVideoRequestStyleArtStyleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.VideoToVideoCreateVideoRequestStyleVersion))
                {
                    return new global::MagicHour.JsonConverters.VideoToVideoCreateVideoRequestStyleVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.VideoToVideoCreateVideoRequestStyleVersion?))
                {
                    return new global::MagicHour.JsonConverters.VideoToVideoCreateVideoRequestStyleVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.VideoToVideoCreateVideoRequestStylePromptType))
                {
                    return new global::MagicHour.JsonConverters.VideoToVideoCreateVideoRequestStylePromptTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.VideoToVideoCreateVideoRequestStylePromptType?))
                {
                    return new global::MagicHour.JsonConverters.VideoToVideoCreateVideoRequestStylePromptTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.VideoToVideoCreateVideoRequestStyleModel))
                {
                    return new global::MagicHour.JsonConverters.VideoToVideoCreateVideoRequestStyleModelJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.VideoToVideoCreateVideoRequestStyleModel?))
                {
                    return new global::MagicHour.JsonConverters.VideoToVideoCreateVideoRequestStyleModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.VideoToVideoCreateVideoRequestAssetsVideoSource))
                {
                    return new global::MagicHour.JsonConverters.VideoToVideoCreateVideoRequestAssetsVideoSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.VideoToVideoCreateVideoRequestAssetsVideoSource?))
                {
                    return new global::MagicHour.JsonConverters.VideoToVideoCreateVideoRequestAssetsVideoSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiClothesChangerCreateImageRequestAssetsGarmentType))
                {
                    return new global::MagicHour.JsonConverters.AiClothesChangerCreateImageRequestAssetsGarmentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiClothesChangerCreateImageRequestAssetsGarmentType?))
                {
                    return new global::MagicHour.JsonConverters.AiClothesChangerCreateImageRequestAssetsGarmentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiGifGeneratorCreateImageRequestOutputFormat))
                {
                    return new global::MagicHour.JsonConverters.AiGifGeneratorCreateImageRequestOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiGifGeneratorCreateImageRequestOutputFormat?))
                {
                    return new global::MagicHour.JsonConverters.AiGifGeneratorCreateImageRequestOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiImageEditorCreateImageRequestModel))
                {
                    return new global::MagicHour.JsonConverters.AiImageEditorCreateImageRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiImageEditorCreateImageRequestModel?))
                {
                    return new global::MagicHour.JsonConverters.AiImageEditorCreateImageRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiImageEditorCreateImageRequestAspectRatio))
                {
                    return new global::MagicHour.JsonConverters.AiImageEditorCreateImageRequestAspectRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiImageEditorCreateImageRequestAspectRatio?))
                {
                    return new global::MagicHour.JsonConverters.AiImageEditorCreateImageRequestAspectRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiImageEditorCreateImageRequestResolution))
                {
                    return new global::MagicHour.JsonConverters.AiImageEditorCreateImageRequestResolutionJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiImageEditorCreateImageRequestResolution?))
                {
                    return new global::MagicHour.JsonConverters.AiImageEditorCreateImageRequestResolutionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiImageGeneratorCreateImageRequestModel))
                {
                    return new global::MagicHour.JsonConverters.AiImageGeneratorCreateImageRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiImageGeneratorCreateImageRequestModel?))
                {
                    return new global::MagicHour.JsonConverters.AiImageGeneratorCreateImageRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiImageGeneratorCreateImageRequestAspectRatio))
                {
                    return new global::MagicHour.JsonConverters.AiImageGeneratorCreateImageRequestAspectRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiImageGeneratorCreateImageRequestAspectRatio?))
                {
                    return new global::MagicHour.JsonConverters.AiImageGeneratorCreateImageRequestAspectRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiImageGeneratorCreateImageRequestResolution))
                {
                    return new global::MagicHour.JsonConverters.AiImageGeneratorCreateImageRequestResolutionJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiImageGeneratorCreateImageRequestResolution?))
                {
                    return new global::MagicHour.JsonConverters.AiImageGeneratorCreateImageRequestResolutionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiImageGeneratorCreateImageRequestStyleTool))
                {
                    return new global::MagicHour.JsonConverters.AiImageGeneratorCreateImageRequestStyleToolJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiImageGeneratorCreateImageRequestStyleTool?))
                {
                    return new global::MagicHour.JsonConverters.AiImageGeneratorCreateImageRequestStyleToolNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiImageUpscalerCreateImageRequestStyleMode))
                {
                    return new global::MagicHour.JsonConverters.AiImageUpscalerCreateImageRequestStyleModeJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiImageUpscalerCreateImageRequestStyleMode?))
                {
                    return new global::MagicHour.JsonConverters.AiImageUpscalerCreateImageRequestStyleModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiMemeGeneratorCreateImageRequestStyleTemplate))
                {
                    return new global::MagicHour.JsonConverters.AiMemeGeneratorCreateImageRequestStyleTemplateJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiMemeGeneratorCreateImageRequestStyleTemplate?))
                {
                    return new global::MagicHour.JsonConverters.AiMemeGeneratorCreateImageRequestStyleTemplateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.BodySwapCreateImageRequestResolution))
                {
                    return new global::MagicHour.JsonConverters.BodySwapCreateImageRequestResolutionJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.BodySwapCreateImageRequestResolution?))
                {
                    return new global::MagicHour.JsonConverters.BodySwapCreateImageRequestResolutionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.FaceSwapPhotoCreateImageRequestAssetsFaceSwapMode))
                {
                    return new global::MagicHour.JsonConverters.FaceSwapPhotoCreateImageRequestAssetsFaceSwapModeJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.FaceSwapPhotoCreateImageRequestAssetsFaceSwapMode?))
                {
                    return new global::MagicHour.JsonConverters.FaceSwapPhotoCreateImageRequestAssetsFaceSwapModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiVoiceGeneratorCreateAudioRequestStyleVoiceName))
                {
                    return new global::MagicHour.JsonConverters.AiVoiceGeneratorCreateAudioRequestStyleVoiceNameJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiVoiceGeneratorCreateAudioRequestStyleVoiceName?))
                {
                    return new global::MagicHour.JsonConverters.AiVoiceGeneratorCreateAudioRequestStyleVoiceNameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.VideoAssetsGeneratePresignedUrlResponseCode))
                {
                    return new global::MagicHour.JsonConverters.VideoAssetsGeneratePresignedUrlResponseCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.VideoAssetsGeneratePresignedUrlResponseCode?))
                {
                    return new global::MagicHour.JsonConverters.VideoAssetsGeneratePresignedUrlResponseCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.VideoAssetsGeneratePresignedUrlResponseCode2))
                {
                    return new global::MagicHour.JsonConverters.VideoAssetsGeneratePresignedUrlResponseCode2JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.VideoAssetsGeneratePresignedUrlResponseCode2?))
                {
                    return new global::MagicHour.JsonConverters.VideoAssetsGeneratePresignedUrlResponseCode2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.VideoAssetsGeneratePresignedUrlResponseCode3))
                {
                    return new global::MagicHour.JsonConverters.VideoAssetsGeneratePresignedUrlResponseCode3JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.VideoAssetsGeneratePresignedUrlResponseCode3?))
                {
                    return new global::MagicHour.JsonConverters.VideoAssetsGeneratePresignedUrlResponseCode3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.VideoAssetsGeneratePresignedUrlResponseCode4))
                {
                    return new global::MagicHour.JsonConverters.VideoAssetsGeneratePresignedUrlResponseCode4JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.VideoAssetsGeneratePresignedUrlResponseCode4?))
                {
                    return new global::MagicHour.JsonConverters.VideoAssetsGeneratePresignedUrlResponseCode4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.VideoAssetsGeneratePresignedUrlResponseCode5))
                {
                    return new global::MagicHour.JsonConverters.VideoAssetsGeneratePresignedUrlResponseCode5JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.VideoAssetsGeneratePresignedUrlResponseCode5?))
                {
                    return new global::MagicHour.JsonConverters.VideoAssetsGeneratePresignedUrlResponseCode5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.VideoAssetsGeneratePresignedUrlResponseCode6))
                {
                    return new global::MagicHour.JsonConverters.VideoAssetsGeneratePresignedUrlResponseCode6JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.VideoAssetsGeneratePresignedUrlResponseCode6?))
                {
                    return new global::MagicHour.JsonConverters.VideoAssetsGeneratePresignedUrlResponseCode6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.FaceDetectionGetDetailsResponseStatus))
                {
                    return new global::MagicHour.JsonConverters.FaceDetectionGetDetailsResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.FaceDetectionGetDetailsResponseStatus?))
                {
                    return new global::MagicHour.JsonConverters.FaceDetectionGetDetailsResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.FaceDetectionGetDetailsResponseCode))
                {
                    return new global::MagicHour.JsonConverters.FaceDetectionGetDetailsResponseCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.FaceDetectionGetDetailsResponseCode?))
                {
                    return new global::MagicHour.JsonConverters.FaceDetectionGetDetailsResponseCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.FaceDetectionGetDetailsResponseCode2))
                {
                    return new global::MagicHour.JsonConverters.FaceDetectionGetDetailsResponseCode2JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.FaceDetectionGetDetailsResponseCode2?))
                {
                    return new global::MagicHour.JsonConverters.FaceDetectionGetDetailsResponseCode2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.FaceDetectionGetDetailsResponseCode3))
                {
                    return new global::MagicHour.JsonConverters.FaceDetectionGetDetailsResponseCode3JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.FaceDetectionGetDetailsResponseCode3?))
                {
                    return new global::MagicHour.JsonConverters.FaceDetectionGetDetailsResponseCode3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.FaceDetectionGetDetailsResponseCode4))
                {
                    return new global::MagicHour.JsonConverters.FaceDetectionGetDetailsResponseCode4JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.FaceDetectionGetDetailsResponseCode4?))
                {
                    return new global::MagicHour.JsonConverters.FaceDetectionGetDetailsResponseCode4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.FaceDetectionGetDetailsResponseCode5))
                {
                    return new global::MagicHour.JsonConverters.FaceDetectionGetDetailsResponseCode5JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.FaceDetectionGetDetailsResponseCode5?))
                {
                    return new global::MagicHour.JsonConverters.FaceDetectionGetDetailsResponseCode5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.FaceDetectionGetDetailsResponseCode6))
                {
                    return new global::MagicHour.JsonConverters.FaceDetectionGetDetailsResponseCode6JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.FaceDetectionGetDetailsResponseCode6?))
                {
                    return new global::MagicHour.JsonConverters.FaceDetectionGetDetailsResponseCode6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.FaceDetectionDetectFacesResponseCode))
                {
                    return new global::MagicHour.JsonConverters.FaceDetectionDetectFacesResponseCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.FaceDetectionDetectFacesResponseCode?))
                {
                    return new global::MagicHour.JsonConverters.FaceDetectionDetectFacesResponseCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.FaceDetectionDetectFacesResponseCode2))
                {
                    return new global::MagicHour.JsonConverters.FaceDetectionDetectFacesResponseCode2JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.FaceDetectionDetectFacesResponseCode2?))
                {
                    return new global::MagicHour.JsonConverters.FaceDetectionDetectFacesResponseCode2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.FaceDetectionDetectFacesResponseCode3))
                {
                    return new global::MagicHour.JsonConverters.FaceDetectionDetectFacesResponseCode3JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.FaceDetectionDetectFacesResponseCode3?))
                {
                    return new global::MagicHour.JsonConverters.FaceDetectionDetectFacesResponseCode3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.FaceDetectionDetectFacesResponseCode4))
                {
                    return new global::MagicHour.JsonConverters.FaceDetectionDetectFacesResponseCode4JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.FaceDetectionDetectFacesResponseCode4?))
                {
                    return new global::MagicHour.JsonConverters.FaceDetectionDetectFacesResponseCode4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.FaceDetectionDetectFacesResponseCode5))
                {
                    return new global::MagicHour.JsonConverters.FaceDetectionDetectFacesResponseCode5JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.FaceDetectionDetectFacesResponseCode5?))
                {
                    return new global::MagicHour.JsonConverters.FaceDetectionDetectFacesResponseCode5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.FaceDetectionDetectFacesResponseCode6))
                {
                    return new global::MagicHour.JsonConverters.FaceDetectionDetectFacesResponseCode6JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.FaceDetectionDetectFacesResponseCode6?))
                {
                    return new global::MagicHour.JsonConverters.FaceDetectionDetectFacesResponseCode6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.VideoProjectsGetDetailsResponseStatus))
                {
                    return new global::MagicHour.JsonConverters.VideoProjectsGetDetailsResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.VideoProjectsGetDetailsResponseStatus?))
                {
                    return new global::MagicHour.JsonConverters.VideoProjectsGetDetailsResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.VideoProjectsGetDetailsResponseCode))
                {
                    return new global::MagicHour.JsonConverters.VideoProjectsGetDetailsResponseCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.VideoProjectsGetDetailsResponseCode?))
                {
                    return new global::MagicHour.JsonConverters.VideoProjectsGetDetailsResponseCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.VideoProjectsGetDetailsResponseCode2))
                {
                    return new global::MagicHour.JsonConverters.VideoProjectsGetDetailsResponseCode2JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.VideoProjectsGetDetailsResponseCode2?))
                {
                    return new global::MagicHour.JsonConverters.VideoProjectsGetDetailsResponseCode2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.VideoProjectsGetDetailsResponseCode3))
                {
                    return new global::MagicHour.JsonConverters.VideoProjectsGetDetailsResponseCode3JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.VideoProjectsGetDetailsResponseCode3?))
                {
                    return new global::MagicHour.JsonConverters.VideoProjectsGetDetailsResponseCode3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.VideoProjectsGetDetailsResponseCode4))
                {
                    return new global::MagicHour.JsonConverters.VideoProjectsGetDetailsResponseCode4JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.VideoProjectsGetDetailsResponseCode4?))
                {
                    return new global::MagicHour.JsonConverters.VideoProjectsGetDetailsResponseCode4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.VideoProjectsGetDetailsResponseCode5))
                {
                    return new global::MagicHour.JsonConverters.VideoProjectsGetDetailsResponseCode5JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.VideoProjectsGetDetailsResponseCode5?))
                {
                    return new global::MagicHour.JsonConverters.VideoProjectsGetDetailsResponseCode5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.VideoProjectsDeleteResponseCode))
                {
                    return new global::MagicHour.JsonConverters.VideoProjectsDeleteResponseCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.VideoProjectsDeleteResponseCode?))
                {
                    return new global::MagicHour.JsonConverters.VideoProjectsDeleteResponseCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.VideoProjectsDeleteResponseCode2))
                {
                    return new global::MagicHour.JsonConverters.VideoProjectsDeleteResponseCode2JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.VideoProjectsDeleteResponseCode2?))
                {
                    return new global::MagicHour.JsonConverters.VideoProjectsDeleteResponseCode2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.VideoProjectsDeleteResponseCode3))
                {
                    return new global::MagicHour.JsonConverters.VideoProjectsDeleteResponseCode3JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.VideoProjectsDeleteResponseCode3?))
                {
                    return new global::MagicHour.JsonConverters.VideoProjectsDeleteResponseCode3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.VideoProjectsDeleteResponseCode4))
                {
                    return new global::MagicHour.JsonConverters.VideoProjectsDeleteResponseCode4JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.VideoProjectsDeleteResponseCode4?))
                {
                    return new global::MagicHour.JsonConverters.VideoProjectsDeleteResponseCode4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.VideoProjectsDeleteResponseCode5))
                {
                    return new global::MagicHour.JsonConverters.VideoProjectsDeleteResponseCode5JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.VideoProjectsDeleteResponseCode5?))
                {
                    return new global::MagicHour.JsonConverters.VideoProjectsDeleteResponseCode5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.VideoProjectsDeleteResponseCode6))
                {
                    return new global::MagicHour.JsonConverters.VideoProjectsDeleteResponseCode6JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.VideoProjectsDeleteResponseCode6?))
                {
                    return new global::MagicHour.JsonConverters.VideoProjectsDeleteResponseCode6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponseCode))
                {
                    return new global::MagicHour.JsonConverters.AiTalkingPhotoCreateTalkingPhotoResponseCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponseCode?))
                {
                    return new global::MagicHour.JsonConverters.AiTalkingPhotoCreateTalkingPhotoResponseCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponseCode2))
                {
                    return new global::MagicHour.JsonConverters.AiTalkingPhotoCreateTalkingPhotoResponseCode2JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponseCode2?))
                {
                    return new global::MagicHour.JsonConverters.AiTalkingPhotoCreateTalkingPhotoResponseCode2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponseCode3))
                {
                    return new global::MagicHour.JsonConverters.AiTalkingPhotoCreateTalkingPhotoResponseCode3JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponseCode3?))
                {
                    return new global::MagicHour.JsonConverters.AiTalkingPhotoCreateTalkingPhotoResponseCode3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponseCode4))
                {
                    return new global::MagicHour.JsonConverters.AiTalkingPhotoCreateTalkingPhotoResponseCode4JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponseCode4?))
                {
                    return new global::MagicHour.JsonConverters.AiTalkingPhotoCreateTalkingPhotoResponseCode4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponseCode5))
                {
                    return new global::MagicHour.JsonConverters.AiTalkingPhotoCreateTalkingPhotoResponseCode5JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponseCode5?))
                {
                    return new global::MagicHour.JsonConverters.AiTalkingPhotoCreateTalkingPhotoResponseCode5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponseCode6))
                {
                    return new global::MagicHour.JsonConverters.AiTalkingPhotoCreateTalkingPhotoResponseCode6JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponseCode6?))
                {
                    return new global::MagicHour.JsonConverters.AiTalkingPhotoCreateTalkingPhotoResponseCode6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiVideoEditorCreateVideoResponseCode))
                {
                    return new global::MagicHour.JsonConverters.AiVideoEditorCreateVideoResponseCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiVideoEditorCreateVideoResponseCode?))
                {
                    return new global::MagicHour.JsonConverters.AiVideoEditorCreateVideoResponseCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiVideoEditorCreateVideoResponseCode2))
                {
                    return new global::MagicHour.JsonConverters.AiVideoEditorCreateVideoResponseCode2JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiVideoEditorCreateVideoResponseCode2?))
                {
                    return new global::MagicHour.JsonConverters.AiVideoEditorCreateVideoResponseCode2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiVideoEditorCreateVideoResponseCode3))
                {
                    return new global::MagicHour.JsonConverters.AiVideoEditorCreateVideoResponseCode3JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiVideoEditorCreateVideoResponseCode3?))
                {
                    return new global::MagicHour.JsonConverters.AiVideoEditorCreateVideoResponseCode3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiVideoEditorCreateVideoResponseCode4))
                {
                    return new global::MagicHour.JsonConverters.AiVideoEditorCreateVideoResponseCode4JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiVideoEditorCreateVideoResponseCode4?))
                {
                    return new global::MagicHour.JsonConverters.AiVideoEditorCreateVideoResponseCode4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiVideoEditorCreateVideoResponseCode5))
                {
                    return new global::MagicHour.JsonConverters.AiVideoEditorCreateVideoResponseCode5JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiVideoEditorCreateVideoResponseCode5?))
                {
                    return new global::MagicHour.JsonConverters.AiVideoEditorCreateVideoResponseCode5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiVideoEditorCreateVideoResponseCode6))
                {
                    return new global::MagicHour.JsonConverters.AiVideoEditorCreateVideoResponseCode6JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiVideoEditorCreateVideoResponseCode6?))
                {
                    return new global::MagicHour.JsonConverters.AiVideoEditorCreateVideoResponseCode6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AnimationCreateVideoResponseCode))
                {
                    return new global::MagicHour.JsonConverters.AnimationCreateVideoResponseCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AnimationCreateVideoResponseCode?))
                {
                    return new global::MagicHour.JsonConverters.AnimationCreateVideoResponseCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AnimationCreateVideoResponseCode2))
                {
                    return new global::MagicHour.JsonConverters.AnimationCreateVideoResponseCode2JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AnimationCreateVideoResponseCode2?))
                {
                    return new global::MagicHour.JsonConverters.AnimationCreateVideoResponseCode2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AnimationCreateVideoResponseCode3))
                {
                    return new global::MagicHour.JsonConverters.AnimationCreateVideoResponseCode3JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AnimationCreateVideoResponseCode3?))
                {
                    return new global::MagicHour.JsonConverters.AnimationCreateVideoResponseCode3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AnimationCreateVideoResponseCode4))
                {
                    return new global::MagicHour.JsonConverters.AnimationCreateVideoResponseCode4JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AnimationCreateVideoResponseCode4?))
                {
                    return new global::MagicHour.JsonConverters.AnimationCreateVideoResponseCode4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AnimationCreateVideoResponseCode5))
                {
                    return new global::MagicHour.JsonConverters.AnimationCreateVideoResponseCode5JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AnimationCreateVideoResponseCode5?))
                {
                    return new global::MagicHour.JsonConverters.AnimationCreateVideoResponseCode5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AnimationCreateVideoResponseCode6))
                {
                    return new global::MagicHour.JsonConverters.AnimationCreateVideoResponseCode6JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AnimationCreateVideoResponseCode6?))
                {
                    return new global::MagicHour.JsonConverters.AnimationCreateVideoResponseCode6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AudioToVideoCreateVideoResponseCode))
                {
                    return new global::MagicHour.JsonConverters.AudioToVideoCreateVideoResponseCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AudioToVideoCreateVideoResponseCode?))
                {
                    return new global::MagicHour.JsonConverters.AudioToVideoCreateVideoResponseCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AudioToVideoCreateVideoResponseCode2))
                {
                    return new global::MagicHour.JsonConverters.AudioToVideoCreateVideoResponseCode2JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AudioToVideoCreateVideoResponseCode2?))
                {
                    return new global::MagicHour.JsonConverters.AudioToVideoCreateVideoResponseCode2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AudioToVideoCreateVideoResponseCode3))
                {
                    return new global::MagicHour.JsonConverters.AudioToVideoCreateVideoResponseCode3JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AudioToVideoCreateVideoResponseCode3?))
                {
                    return new global::MagicHour.JsonConverters.AudioToVideoCreateVideoResponseCode3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AudioToVideoCreateVideoResponseCode4))
                {
                    return new global::MagicHour.JsonConverters.AudioToVideoCreateVideoResponseCode4JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AudioToVideoCreateVideoResponseCode4?))
                {
                    return new global::MagicHour.JsonConverters.AudioToVideoCreateVideoResponseCode4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AudioToVideoCreateVideoResponseCode5))
                {
                    return new global::MagicHour.JsonConverters.AudioToVideoCreateVideoResponseCode5JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AudioToVideoCreateVideoResponseCode5?))
                {
                    return new global::MagicHour.JsonConverters.AudioToVideoCreateVideoResponseCode5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AudioToVideoCreateVideoResponseCode6))
                {
                    return new global::MagicHour.JsonConverters.AudioToVideoCreateVideoResponseCode6JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AudioToVideoCreateVideoResponseCode6?))
                {
                    return new global::MagicHour.JsonConverters.AudioToVideoCreateVideoResponseCode6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AutoSubtitleGeneratorCreateVideoResponseCode))
                {
                    return new global::MagicHour.JsonConverters.AutoSubtitleGeneratorCreateVideoResponseCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AutoSubtitleGeneratorCreateVideoResponseCode?))
                {
                    return new global::MagicHour.JsonConverters.AutoSubtitleGeneratorCreateVideoResponseCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AutoSubtitleGeneratorCreateVideoResponseCode2))
                {
                    return new global::MagicHour.JsonConverters.AutoSubtitleGeneratorCreateVideoResponseCode2JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AutoSubtitleGeneratorCreateVideoResponseCode2?))
                {
                    return new global::MagicHour.JsonConverters.AutoSubtitleGeneratorCreateVideoResponseCode2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AutoSubtitleGeneratorCreateVideoResponseCode3))
                {
                    return new global::MagicHour.JsonConverters.AutoSubtitleGeneratorCreateVideoResponseCode3JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AutoSubtitleGeneratorCreateVideoResponseCode3?))
                {
                    return new global::MagicHour.JsonConverters.AutoSubtitleGeneratorCreateVideoResponseCode3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AutoSubtitleGeneratorCreateVideoResponseCode4))
                {
                    return new global::MagicHour.JsonConverters.AutoSubtitleGeneratorCreateVideoResponseCode4JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AutoSubtitleGeneratorCreateVideoResponseCode4?))
                {
                    return new global::MagicHour.JsonConverters.AutoSubtitleGeneratorCreateVideoResponseCode4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AutoSubtitleGeneratorCreateVideoResponseCode5))
                {
                    return new global::MagicHour.JsonConverters.AutoSubtitleGeneratorCreateVideoResponseCode5JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AutoSubtitleGeneratorCreateVideoResponseCode5?))
                {
                    return new global::MagicHour.JsonConverters.AutoSubtitleGeneratorCreateVideoResponseCode5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AutoSubtitleGeneratorCreateVideoResponseCode6))
                {
                    return new global::MagicHour.JsonConverters.AutoSubtitleGeneratorCreateVideoResponseCode6JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AutoSubtitleGeneratorCreateVideoResponseCode6?))
                {
                    return new global::MagicHour.JsonConverters.AutoSubtitleGeneratorCreateVideoResponseCode6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.CharacterReplaceCreateVideoResponseCode))
                {
                    return new global::MagicHour.JsonConverters.CharacterReplaceCreateVideoResponseCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.CharacterReplaceCreateVideoResponseCode?))
                {
                    return new global::MagicHour.JsonConverters.CharacterReplaceCreateVideoResponseCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.CharacterReplaceCreateVideoResponseCode2))
                {
                    return new global::MagicHour.JsonConverters.CharacterReplaceCreateVideoResponseCode2JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.CharacterReplaceCreateVideoResponseCode2?))
                {
                    return new global::MagicHour.JsonConverters.CharacterReplaceCreateVideoResponseCode2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.CharacterReplaceCreateVideoResponseCode3))
                {
                    return new global::MagicHour.JsonConverters.CharacterReplaceCreateVideoResponseCode3JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.CharacterReplaceCreateVideoResponseCode3?))
                {
                    return new global::MagicHour.JsonConverters.CharacterReplaceCreateVideoResponseCode3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.CharacterReplaceCreateVideoResponseCode4))
                {
                    return new global::MagicHour.JsonConverters.CharacterReplaceCreateVideoResponseCode4JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.CharacterReplaceCreateVideoResponseCode4?))
                {
                    return new global::MagicHour.JsonConverters.CharacterReplaceCreateVideoResponseCode4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.CharacterReplaceCreateVideoResponseCode5))
                {
                    return new global::MagicHour.JsonConverters.CharacterReplaceCreateVideoResponseCode5JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.CharacterReplaceCreateVideoResponseCode5?))
                {
                    return new global::MagicHour.JsonConverters.CharacterReplaceCreateVideoResponseCode5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.CharacterReplaceCreateVideoResponseCode6))
                {
                    return new global::MagicHour.JsonConverters.CharacterReplaceCreateVideoResponseCode6JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.CharacterReplaceCreateVideoResponseCode6?))
                {
                    return new global::MagicHour.JsonConverters.CharacterReplaceCreateVideoResponseCode6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.FaceSwapCreateVideoResponseCode))
                {
                    return new global::MagicHour.JsonConverters.FaceSwapCreateVideoResponseCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.FaceSwapCreateVideoResponseCode?))
                {
                    return new global::MagicHour.JsonConverters.FaceSwapCreateVideoResponseCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.FaceSwapCreateVideoResponseCode2))
                {
                    return new global::MagicHour.JsonConverters.FaceSwapCreateVideoResponseCode2JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.FaceSwapCreateVideoResponseCode2?))
                {
                    return new global::MagicHour.JsonConverters.FaceSwapCreateVideoResponseCode2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.FaceSwapCreateVideoResponseCode3))
                {
                    return new global::MagicHour.JsonConverters.FaceSwapCreateVideoResponseCode3JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.FaceSwapCreateVideoResponseCode3?))
                {
                    return new global::MagicHour.JsonConverters.FaceSwapCreateVideoResponseCode3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.FaceSwapCreateVideoResponseCode4))
                {
                    return new global::MagicHour.JsonConverters.FaceSwapCreateVideoResponseCode4JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.FaceSwapCreateVideoResponseCode4?))
                {
                    return new global::MagicHour.JsonConverters.FaceSwapCreateVideoResponseCode4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.FaceSwapCreateVideoResponseCode5))
                {
                    return new global::MagicHour.JsonConverters.FaceSwapCreateVideoResponseCode5JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.FaceSwapCreateVideoResponseCode5?))
                {
                    return new global::MagicHour.JsonConverters.FaceSwapCreateVideoResponseCode5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.FaceSwapCreateVideoResponseCode6))
                {
                    return new global::MagicHour.JsonConverters.FaceSwapCreateVideoResponseCode6JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.FaceSwapCreateVideoResponseCode6?))
                {
                    return new global::MagicHour.JsonConverters.FaceSwapCreateVideoResponseCode6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.ImageToVideoCreateVideoResponseCode))
                {
                    return new global::MagicHour.JsonConverters.ImageToVideoCreateVideoResponseCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.ImageToVideoCreateVideoResponseCode?))
                {
                    return new global::MagicHour.JsonConverters.ImageToVideoCreateVideoResponseCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.ImageToVideoCreateVideoResponseCode2))
                {
                    return new global::MagicHour.JsonConverters.ImageToVideoCreateVideoResponseCode2JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.ImageToVideoCreateVideoResponseCode2?))
                {
                    return new global::MagicHour.JsonConverters.ImageToVideoCreateVideoResponseCode2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.ImageToVideoCreateVideoResponseCode3))
                {
                    return new global::MagicHour.JsonConverters.ImageToVideoCreateVideoResponseCode3JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.ImageToVideoCreateVideoResponseCode3?))
                {
                    return new global::MagicHour.JsonConverters.ImageToVideoCreateVideoResponseCode3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.ImageToVideoCreateVideoResponseCode4))
                {
                    return new global::MagicHour.JsonConverters.ImageToVideoCreateVideoResponseCode4JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.ImageToVideoCreateVideoResponseCode4?))
                {
                    return new global::MagicHour.JsonConverters.ImageToVideoCreateVideoResponseCode4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.ImageToVideoCreateVideoResponseCode5))
                {
                    return new global::MagicHour.JsonConverters.ImageToVideoCreateVideoResponseCode5JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.ImageToVideoCreateVideoResponseCode5?))
                {
                    return new global::MagicHour.JsonConverters.ImageToVideoCreateVideoResponseCode5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.ImageToVideoCreateVideoResponseCode6))
                {
                    return new global::MagicHour.JsonConverters.ImageToVideoCreateVideoResponseCode6JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.ImageToVideoCreateVideoResponseCode6?))
                {
                    return new global::MagicHour.JsonConverters.ImageToVideoCreateVideoResponseCode6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.LipSyncCreateVideoResponseCode))
                {
                    return new global::MagicHour.JsonConverters.LipSyncCreateVideoResponseCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.LipSyncCreateVideoResponseCode?))
                {
                    return new global::MagicHour.JsonConverters.LipSyncCreateVideoResponseCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.LipSyncCreateVideoResponseCode2))
                {
                    return new global::MagicHour.JsonConverters.LipSyncCreateVideoResponseCode2JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.LipSyncCreateVideoResponseCode2?))
                {
                    return new global::MagicHour.JsonConverters.LipSyncCreateVideoResponseCode2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.LipSyncCreateVideoResponseCode3))
                {
                    return new global::MagicHour.JsonConverters.LipSyncCreateVideoResponseCode3JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.LipSyncCreateVideoResponseCode3?))
                {
                    return new global::MagicHour.JsonConverters.LipSyncCreateVideoResponseCode3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.LipSyncCreateVideoResponseCode4))
                {
                    return new global::MagicHour.JsonConverters.LipSyncCreateVideoResponseCode4JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.LipSyncCreateVideoResponseCode4?))
                {
                    return new global::MagicHour.JsonConverters.LipSyncCreateVideoResponseCode4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.LipSyncCreateVideoResponseCode5))
                {
                    return new global::MagicHour.JsonConverters.LipSyncCreateVideoResponseCode5JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.LipSyncCreateVideoResponseCode5?))
                {
                    return new global::MagicHour.JsonConverters.LipSyncCreateVideoResponseCode5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.LipSyncCreateVideoResponseCode6))
                {
                    return new global::MagicHour.JsonConverters.LipSyncCreateVideoResponseCode6JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.LipSyncCreateVideoResponseCode6?))
                {
                    return new global::MagicHour.JsonConverters.LipSyncCreateVideoResponseCode6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.TextToVideoCreateVideoResponseCode))
                {
                    return new global::MagicHour.JsonConverters.TextToVideoCreateVideoResponseCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.TextToVideoCreateVideoResponseCode?))
                {
                    return new global::MagicHour.JsonConverters.TextToVideoCreateVideoResponseCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.TextToVideoCreateVideoResponseCode2))
                {
                    return new global::MagicHour.JsonConverters.TextToVideoCreateVideoResponseCode2JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.TextToVideoCreateVideoResponseCode2?))
                {
                    return new global::MagicHour.JsonConverters.TextToVideoCreateVideoResponseCode2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.TextToVideoCreateVideoResponseCode3))
                {
                    return new global::MagicHour.JsonConverters.TextToVideoCreateVideoResponseCode3JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.TextToVideoCreateVideoResponseCode3?))
                {
                    return new global::MagicHour.JsonConverters.TextToVideoCreateVideoResponseCode3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.TextToVideoCreateVideoResponseCode4))
                {
                    return new global::MagicHour.JsonConverters.TextToVideoCreateVideoResponseCode4JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.TextToVideoCreateVideoResponseCode4?))
                {
                    return new global::MagicHour.JsonConverters.TextToVideoCreateVideoResponseCode4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.TextToVideoCreateVideoResponseCode5))
                {
                    return new global::MagicHour.JsonConverters.TextToVideoCreateVideoResponseCode5JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.TextToVideoCreateVideoResponseCode5?))
                {
                    return new global::MagicHour.JsonConverters.TextToVideoCreateVideoResponseCode5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.TextToVideoCreateVideoResponseCode6))
                {
                    return new global::MagicHour.JsonConverters.TextToVideoCreateVideoResponseCode6JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.TextToVideoCreateVideoResponseCode6?))
                {
                    return new global::MagicHour.JsonConverters.TextToVideoCreateVideoResponseCode6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.VideoToVideoCreateVideoResponseCode))
                {
                    return new global::MagicHour.JsonConverters.VideoToVideoCreateVideoResponseCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.VideoToVideoCreateVideoResponseCode?))
                {
                    return new global::MagicHour.JsonConverters.VideoToVideoCreateVideoResponseCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.VideoToVideoCreateVideoResponseCode2))
                {
                    return new global::MagicHour.JsonConverters.VideoToVideoCreateVideoResponseCode2JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.VideoToVideoCreateVideoResponseCode2?))
                {
                    return new global::MagicHour.JsonConverters.VideoToVideoCreateVideoResponseCode2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.VideoToVideoCreateVideoResponseCode3))
                {
                    return new global::MagicHour.JsonConverters.VideoToVideoCreateVideoResponseCode3JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.VideoToVideoCreateVideoResponseCode3?))
                {
                    return new global::MagicHour.JsonConverters.VideoToVideoCreateVideoResponseCode3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.VideoToVideoCreateVideoResponseCode4))
                {
                    return new global::MagicHour.JsonConverters.VideoToVideoCreateVideoResponseCode4JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.VideoToVideoCreateVideoResponseCode4?))
                {
                    return new global::MagicHour.JsonConverters.VideoToVideoCreateVideoResponseCode4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.VideoToVideoCreateVideoResponseCode5))
                {
                    return new global::MagicHour.JsonConverters.VideoToVideoCreateVideoResponseCode5JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.VideoToVideoCreateVideoResponseCode5?))
                {
                    return new global::MagicHour.JsonConverters.VideoToVideoCreateVideoResponseCode5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.VideoToVideoCreateVideoResponseCode6))
                {
                    return new global::MagicHour.JsonConverters.VideoToVideoCreateVideoResponseCode6JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.VideoToVideoCreateVideoResponseCode6?))
                {
                    return new global::MagicHour.JsonConverters.VideoToVideoCreateVideoResponseCode6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.ImageProjectsGetDetailsResponseStatus))
                {
                    return new global::MagicHour.JsonConverters.ImageProjectsGetDetailsResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.ImageProjectsGetDetailsResponseStatus?))
                {
                    return new global::MagicHour.JsonConverters.ImageProjectsGetDetailsResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.ImageProjectsGetDetailsResponseCode))
                {
                    return new global::MagicHour.JsonConverters.ImageProjectsGetDetailsResponseCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.ImageProjectsGetDetailsResponseCode?))
                {
                    return new global::MagicHour.JsonConverters.ImageProjectsGetDetailsResponseCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.ImageProjectsGetDetailsResponseCode2))
                {
                    return new global::MagicHour.JsonConverters.ImageProjectsGetDetailsResponseCode2JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.ImageProjectsGetDetailsResponseCode2?))
                {
                    return new global::MagicHour.JsonConverters.ImageProjectsGetDetailsResponseCode2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.ImageProjectsGetDetailsResponseCode3))
                {
                    return new global::MagicHour.JsonConverters.ImageProjectsGetDetailsResponseCode3JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.ImageProjectsGetDetailsResponseCode3?))
                {
                    return new global::MagicHour.JsonConverters.ImageProjectsGetDetailsResponseCode3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.ImageProjectsGetDetailsResponseCode4))
                {
                    return new global::MagicHour.JsonConverters.ImageProjectsGetDetailsResponseCode4JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.ImageProjectsGetDetailsResponseCode4?))
                {
                    return new global::MagicHour.JsonConverters.ImageProjectsGetDetailsResponseCode4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.ImageProjectsGetDetailsResponseCode5))
                {
                    return new global::MagicHour.JsonConverters.ImageProjectsGetDetailsResponseCode5JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.ImageProjectsGetDetailsResponseCode5?))
                {
                    return new global::MagicHour.JsonConverters.ImageProjectsGetDetailsResponseCode5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.ImageProjectsDeleteResponseCode))
                {
                    return new global::MagicHour.JsonConverters.ImageProjectsDeleteResponseCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.ImageProjectsDeleteResponseCode?))
                {
                    return new global::MagicHour.JsonConverters.ImageProjectsDeleteResponseCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.ImageProjectsDeleteResponseCode2))
                {
                    return new global::MagicHour.JsonConverters.ImageProjectsDeleteResponseCode2JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.ImageProjectsDeleteResponseCode2?))
                {
                    return new global::MagicHour.JsonConverters.ImageProjectsDeleteResponseCode2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.ImageProjectsDeleteResponseCode3))
                {
                    return new global::MagicHour.JsonConverters.ImageProjectsDeleteResponseCode3JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.ImageProjectsDeleteResponseCode3?))
                {
                    return new global::MagicHour.JsonConverters.ImageProjectsDeleteResponseCode3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.ImageProjectsDeleteResponseCode4))
                {
                    return new global::MagicHour.JsonConverters.ImageProjectsDeleteResponseCode4JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.ImageProjectsDeleteResponseCode4?))
                {
                    return new global::MagicHour.JsonConverters.ImageProjectsDeleteResponseCode4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.ImageProjectsDeleteResponseCode5))
                {
                    return new global::MagicHour.JsonConverters.ImageProjectsDeleteResponseCode5JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.ImageProjectsDeleteResponseCode5?))
                {
                    return new global::MagicHour.JsonConverters.ImageProjectsDeleteResponseCode5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiClothesChangerCreateImageResponseCode))
                {
                    return new global::MagicHour.JsonConverters.AiClothesChangerCreateImageResponseCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiClothesChangerCreateImageResponseCode?))
                {
                    return new global::MagicHour.JsonConverters.AiClothesChangerCreateImageResponseCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiClothesChangerCreateImageResponseCode2))
                {
                    return new global::MagicHour.JsonConverters.AiClothesChangerCreateImageResponseCode2JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiClothesChangerCreateImageResponseCode2?))
                {
                    return new global::MagicHour.JsonConverters.AiClothesChangerCreateImageResponseCode2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiClothesChangerCreateImageResponseCode3))
                {
                    return new global::MagicHour.JsonConverters.AiClothesChangerCreateImageResponseCode3JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiClothesChangerCreateImageResponseCode3?))
                {
                    return new global::MagicHour.JsonConverters.AiClothesChangerCreateImageResponseCode3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiClothesChangerCreateImageResponseCode4))
                {
                    return new global::MagicHour.JsonConverters.AiClothesChangerCreateImageResponseCode4JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiClothesChangerCreateImageResponseCode4?))
                {
                    return new global::MagicHour.JsonConverters.AiClothesChangerCreateImageResponseCode4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiClothesChangerCreateImageResponseCode5))
                {
                    return new global::MagicHour.JsonConverters.AiClothesChangerCreateImageResponseCode5JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiClothesChangerCreateImageResponseCode5?))
                {
                    return new global::MagicHour.JsonConverters.AiClothesChangerCreateImageResponseCode5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiClothesChangerCreateImageResponseCode6))
                {
                    return new global::MagicHour.JsonConverters.AiClothesChangerCreateImageResponseCode6JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiClothesChangerCreateImageResponseCode6?))
                {
                    return new global::MagicHour.JsonConverters.AiClothesChangerCreateImageResponseCode6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiFaceEditorEditImageResponseCode))
                {
                    return new global::MagicHour.JsonConverters.AiFaceEditorEditImageResponseCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiFaceEditorEditImageResponseCode?))
                {
                    return new global::MagicHour.JsonConverters.AiFaceEditorEditImageResponseCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiFaceEditorEditImageResponseCode2))
                {
                    return new global::MagicHour.JsonConverters.AiFaceEditorEditImageResponseCode2JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiFaceEditorEditImageResponseCode2?))
                {
                    return new global::MagicHour.JsonConverters.AiFaceEditorEditImageResponseCode2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiFaceEditorEditImageResponseCode3))
                {
                    return new global::MagicHour.JsonConverters.AiFaceEditorEditImageResponseCode3JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiFaceEditorEditImageResponseCode3?))
                {
                    return new global::MagicHour.JsonConverters.AiFaceEditorEditImageResponseCode3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiFaceEditorEditImageResponseCode4))
                {
                    return new global::MagicHour.JsonConverters.AiFaceEditorEditImageResponseCode4JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiFaceEditorEditImageResponseCode4?))
                {
                    return new global::MagicHour.JsonConverters.AiFaceEditorEditImageResponseCode4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiFaceEditorEditImageResponseCode5))
                {
                    return new global::MagicHour.JsonConverters.AiFaceEditorEditImageResponseCode5JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiFaceEditorEditImageResponseCode5?))
                {
                    return new global::MagicHour.JsonConverters.AiFaceEditorEditImageResponseCode5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiFaceEditorEditImageResponseCode6))
                {
                    return new global::MagicHour.JsonConverters.AiFaceEditorEditImageResponseCode6JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiFaceEditorEditImageResponseCode6?))
                {
                    return new global::MagicHour.JsonConverters.AiFaceEditorEditImageResponseCode6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiGifGeneratorCreateImageResponseCode))
                {
                    return new global::MagicHour.JsonConverters.AiGifGeneratorCreateImageResponseCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiGifGeneratorCreateImageResponseCode?))
                {
                    return new global::MagicHour.JsonConverters.AiGifGeneratorCreateImageResponseCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiGifGeneratorCreateImageResponseCode2))
                {
                    return new global::MagicHour.JsonConverters.AiGifGeneratorCreateImageResponseCode2JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiGifGeneratorCreateImageResponseCode2?))
                {
                    return new global::MagicHour.JsonConverters.AiGifGeneratorCreateImageResponseCode2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiGifGeneratorCreateImageResponseCode3))
                {
                    return new global::MagicHour.JsonConverters.AiGifGeneratorCreateImageResponseCode3JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiGifGeneratorCreateImageResponseCode3?))
                {
                    return new global::MagicHour.JsonConverters.AiGifGeneratorCreateImageResponseCode3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiGifGeneratorCreateImageResponseCode4))
                {
                    return new global::MagicHour.JsonConverters.AiGifGeneratorCreateImageResponseCode4JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiGifGeneratorCreateImageResponseCode4?))
                {
                    return new global::MagicHour.JsonConverters.AiGifGeneratorCreateImageResponseCode4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiGifGeneratorCreateImageResponseCode5))
                {
                    return new global::MagicHour.JsonConverters.AiGifGeneratorCreateImageResponseCode5JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiGifGeneratorCreateImageResponseCode5?))
                {
                    return new global::MagicHour.JsonConverters.AiGifGeneratorCreateImageResponseCode5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiGifGeneratorCreateImageResponseCode6))
                {
                    return new global::MagicHour.JsonConverters.AiGifGeneratorCreateImageResponseCode6JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiGifGeneratorCreateImageResponseCode6?))
                {
                    return new global::MagicHour.JsonConverters.AiGifGeneratorCreateImageResponseCode6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiImageEditorCreateImageResponseCode))
                {
                    return new global::MagicHour.JsonConverters.AiImageEditorCreateImageResponseCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiImageEditorCreateImageResponseCode?))
                {
                    return new global::MagicHour.JsonConverters.AiImageEditorCreateImageResponseCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiImageEditorCreateImageResponseCode2))
                {
                    return new global::MagicHour.JsonConverters.AiImageEditorCreateImageResponseCode2JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiImageEditorCreateImageResponseCode2?))
                {
                    return new global::MagicHour.JsonConverters.AiImageEditorCreateImageResponseCode2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiImageEditorCreateImageResponseCode3))
                {
                    return new global::MagicHour.JsonConverters.AiImageEditorCreateImageResponseCode3JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiImageEditorCreateImageResponseCode3?))
                {
                    return new global::MagicHour.JsonConverters.AiImageEditorCreateImageResponseCode3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiImageEditorCreateImageResponseCode4))
                {
                    return new global::MagicHour.JsonConverters.AiImageEditorCreateImageResponseCode4JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiImageEditorCreateImageResponseCode4?))
                {
                    return new global::MagicHour.JsonConverters.AiImageEditorCreateImageResponseCode4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiImageEditorCreateImageResponseCode5))
                {
                    return new global::MagicHour.JsonConverters.AiImageEditorCreateImageResponseCode5JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiImageEditorCreateImageResponseCode5?))
                {
                    return new global::MagicHour.JsonConverters.AiImageEditorCreateImageResponseCode5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiImageEditorCreateImageResponseCode6))
                {
                    return new global::MagicHour.JsonConverters.AiImageEditorCreateImageResponseCode6JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiImageEditorCreateImageResponseCode6?))
                {
                    return new global::MagicHour.JsonConverters.AiImageEditorCreateImageResponseCode6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiHeadshotGeneratorCreateImageResponseCode))
                {
                    return new global::MagicHour.JsonConverters.AiHeadshotGeneratorCreateImageResponseCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiHeadshotGeneratorCreateImageResponseCode?))
                {
                    return new global::MagicHour.JsonConverters.AiHeadshotGeneratorCreateImageResponseCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiHeadshotGeneratorCreateImageResponseCode2))
                {
                    return new global::MagicHour.JsonConverters.AiHeadshotGeneratorCreateImageResponseCode2JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiHeadshotGeneratorCreateImageResponseCode2?))
                {
                    return new global::MagicHour.JsonConverters.AiHeadshotGeneratorCreateImageResponseCode2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiHeadshotGeneratorCreateImageResponseCode3))
                {
                    return new global::MagicHour.JsonConverters.AiHeadshotGeneratorCreateImageResponseCode3JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiHeadshotGeneratorCreateImageResponseCode3?))
                {
                    return new global::MagicHour.JsonConverters.AiHeadshotGeneratorCreateImageResponseCode3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiHeadshotGeneratorCreateImageResponseCode4))
                {
                    return new global::MagicHour.JsonConverters.AiHeadshotGeneratorCreateImageResponseCode4JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiHeadshotGeneratorCreateImageResponseCode4?))
                {
                    return new global::MagicHour.JsonConverters.AiHeadshotGeneratorCreateImageResponseCode4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiHeadshotGeneratorCreateImageResponseCode5))
                {
                    return new global::MagicHour.JsonConverters.AiHeadshotGeneratorCreateImageResponseCode5JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiHeadshotGeneratorCreateImageResponseCode5?))
                {
                    return new global::MagicHour.JsonConverters.AiHeadshotGeneratorCreateImageResponseCode5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiHeadshotGeneratorCreateImageResponseCode6))
                {
                    return new global::MagicHour.JsonConverters.AiHeadshotGeneratorCreateImageResponseCode6JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiHeadshotGeneratorCreateImageResponseCode6?))
                {
                    return new global::MagicHour.JsonConverters.AiHeadshotGeneratorCreateImageResponseCode6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiImageGeneratorCreateImageResponseCode))
                {
                    return new global::MagicHour.JsonConverters.AiImageGeneratorCreateImageResponseCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiImageGeneratorCreateImageResponseCode?))
                {
                    return new global::MagicHour.JsonConverters.AiImageGeneratorCreateImageResponseCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiImageGeneratorCreateImageResponseCode2))
                {
                    return new global::MagicHour.JsonConverters.AiImageGeneratorCreateImageResponseCode2JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiImageGeneratorCreateImageResponseCode2?))
                {
                    return new global::MagicHour.JsonConverters.AiImageGeneratorCreateImageResponseCode2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiImageGeneratorCreateImageResponseCode3))
                {
                    return new global::MagicHour.JsonConverters.AiImageGeneratorCreateImageResponseCode3JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiImageGeneratorCreateImageResponseCode3?))
                {
                    return new global::MagicHour.JsonConverters.AiImageGeneratorCreateImageResponseCode3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiImageGeneratorCreateImageResponseCode4))
                {
                    return new global::MagicHour.JsonConverters.AiImageGeneratorCreateImageResponseCode4JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiImageGeneratorCreateImageResponseCode4?))
                {
                    return new global::MagicHour.JsonConverters.AiImageGeneratorCreateImageResponseCode4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiImageGeneratorCreateImageResponseCode5))
                {
                    return new global::MagicHour.JsonConverters.AiImageGeneratorCreateImageResponseCode5JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiImageGeneratorCreateImageResponseCode5?))
                {
                    return new global::MagicHour.JsonConverters.AiImageGeneratorCreateImageResponseCode5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiImageGeneratorCreateImageResponseCode6))
                {
                    return new global::MagicHour.JsonConverters.AiImageGeneratorCreateImageResponseCode6JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiImageGeneratorCreateImageResponseCode6?))
                {
                    return new global::MagicHour.JsonConverters.AiImageGeneratorCreateImageResponseCode6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiImageUpscalerCreateImageResponseCode))
                {
                    return new global::MagicHour.JsonConverters.AiImageUpscalerCreateImageResponseCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiImageUpscalerCreateImageResponseCode?))
                {
                    return new global::MagicHour.JsonConverters.AiImageUpscalerCreateImageResponseCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiImageUpscalerCreateImageResponseCode2))
                {
                    return new global::MagicHour.JsonConverters.AiImageUpscalerCreateImageResponseCode2JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiImageUpscalerCreateImageResponseCode2?))
                {
                    return new global::MagicHour.JsonConverters.AiImageUpscalerCreateImageResponseCode2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiImageUpscalerCreateImageResponseCode3))
                {
                    return new global::MagicHour.JsonConverters.AiImageUpscalerCreateImageResponseCode3JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiImageUpscalerCreateImageResponseCode3?))
                {
                    return new global::MagicHour.JsonConverters.AiImageUpscalerCreateImageResponseCode3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiImageUpscalerCreateImageResponseCode4))
                {
                    return new global::MagicHour.JsonConverters.AiImageUpscalerCreateImageResponseCode4JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiImageUpscalerCreateImageResponseCode4?))
                {
                    return new global::MagicHour.JsonConverters.AiImageUpscalerCreateImageResponseCode4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiImageUpscalerCreateImageResponseCode5))
                {
                    return new global::MagicHour.JsonConverters.AiImageUpscalerCreateImageResponseCode5JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiImageUpscalerCreateImageResponseCode5?))
                {
                    return new global::MagicHour.JsonConverters.AiImageUpscalerCreateImageResponseCode5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiImageUpscalerCreateImageResponseCode6))
                {
                    return new global::MagicHour.JsonConverters.AiImageUpscalerCreateImageResponseCode6JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiImageUpscalerCreateImageResponseCode6?))
                {
                    return new global::MagicHour.JsonConverters.AiImageUpscalerCreateImageResponseCode6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiMemeGeneratorCreateImageResponseCode))
                {
                    return new global::MagicHour.JsonConverters.AiMemeGeneratorCreateImageResponseCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiMemeGeneratorCreateImageResponseCode?))
                {
                    return new global::MagicHour.JsonConverters.AiMemeGeneratorCreateImageResponseCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiMemeGeneratorCreateImageResponseCode2))
                {
                    return new global::MagicHour.JsonConverters.AiMemeGeneratorCreateImageResponseCode2JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiMemeGeneratorCreateImageResponseCode2?))
                {
                    return new global::MagicHour.JsonConverters.AiMemeGeneratorCreateImageResponseCode2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiMemeGeneratorCreateImageResponseCode3))
                {
                    return new global::MagicHour.JsonConverters.AiMemeGeneratorCreateImageResponseCode3JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiMemeGeneratorCreateImageResponseCode3?))
                {
                    return new global::MagicHour.JsonConverters.AiMemeGeneratorCreateImageResponseCode3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiMemeGeneratorCreateImageResponseCode4))
                {
                    return new global::MagicHour.JsonConverters.AiMemeGeneratorCreateImageResponseCode4JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiMemeGeneratorCreateImageResponseCode4?))
                {
                    return new global::MagicHour.JsonConverters.AiMemeGeneratorCreateImageResponseCode4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiMemeGeneratorCreateImageResponseCode5))
                {
                    return new global::MagicHour.JsonConverters.AiMemeGeneratorCreateImageResponseCode5JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiMemeGeneratorCreateImageResponseCode5?))
                {
                    return new global::MagicHour.JsonConverters.AiMemeGeneratorCreateImageResponseCode5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiMemeGeneratorCreateImageResponseCode6))
                {
                    return new global::MagicHour.JsonConverters.AiMemeGeneratorCreateImageResponseCode6JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiMemeGeneratorCreateImageResponseCode6?))
                {
                    return new global::MagicHour.JsonConverters.AiMemeGeneratorCreateImageResponseCode6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiQrCodeGeneratorCreateImageResponseCode))
                {
                    return new global::MagicHour.JsonConverters.AiQrCodeGeneratorCreateImageResponseCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiQrCodeGeneratorCreateImageResponseCode?))
                {
                    return new global::MagicHour.JsonConverters.AiQrCodeGeneratorCreateImageResponseCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiQrCodeGeneratorCreateImageResponseCode2))
                {
                    return new global::MagicHour.JsonConverters.AiQrCodeGeneratorCreateImageResponseCode2JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiQrCodeGeneratorCreateImageResponseCode2?))
                {
                    return new global::MagicHour.JsonConverters.AiQrCodeGeneratorCreateImageResponseCode2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiQrCodeGeneratorCreateImageResponseCode3))
                {
                    return new global::MagicHour.JsonConverters.AiQrCodeGeneratorCreateImageResponseCode3JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiQrCodeGeneratorCreateImageResponseCode3?))
                {
                    return new global::MagicHour.JsonConverters.AiQrCodeGeneratorCreateImageResponseCode3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiQrCodeGeneratorCreateImageResponseCode4))
                {
                    return new global::MagicHour.JsonConverters.AiQrCodeGeneratorCreateImageResponseCode4JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiQrCodeGeneratorCreateImageResponseCode4?))
                {
                    return new global::MagicHour.JsonConverters.AiQrCodeGeneratorCreateImageResponseCode4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiQrCodeGeneratorCreateImageResponseCode5))
                {
                    return new global::MagicHour.JsonConverters.AiQrCodeGeneratorCreateImageResponseCode5JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiQrCodeGeneratorCreateImageResponseCode5?))
                {
                    return new global::MagicHour.JsonConverters.AiQrCodeGeneratorCreateImageResponseCode5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiQrCodeGeneratorCreateImageResponseCode6))
                {
                    return new global::MagicHour.JsonConverters.AiQrCodeGeneratorCreateImageResponseCode6JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiQrCodeGeneratorCreateImageResponseCode6?))
                {
                    return new global::MagicHour.JsonConverters.AiQrCodeGeneratorCreateImageResponseCode6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.BodySwapCreateImageResponseCode))
                {
                    return new global::MagicHour.JsonConverters.BodySwapCreateImageResponseCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.BodySwapCreateImageResponseCode?))
                {
                    return new global::MagicHour.JsonConverters.BodySwapCreateImageResponseCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.BodySwapCreateImageResponseCode2))
                {
                    return new global::MagicHour.JsonConverters.BodySwapCreateImageResponseCode2JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.BodySwapCreateImageResponseCode2?))
                {
                    return new global::MagicHour.JsonConverters.BodySwapCreateImageResponseCode2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.BodySwapCreateImageResponseCode3))
                {
                    return new global::MagicHour.JsonConverters.BodySwapCreateImageResponseCode3JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.BodySwapCreateImageResponseCode3?))
                {
                    return new global::MagicHour.JsonConverters.BodySwapCreateImageResponseCode3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.BodySwapCreateImageResponseCode4))
                {
                    return new global::MagicHour.JsonConverters.BodySwapCreateImageResponseCode4JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.BodySwapCreateImageResponseCode4?))
                {
                    return new global::MagicHour.JsonConverters.BodySwapCreateImageResponseCode4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.BodySwapCreateImageResponseCode5))
                {
                    return new global::MagicHour.JsonConverters.BodySwapCreateImageResponseCode5JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.BodySwapCreateImageResponseCode5?))
                {
                    return new global::MagicHour.JsonConverters.BodySwapCreateImageResponseCode5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.BodySwapCreateImageResponseCode6))
                {
                    return new global::MagicHour.JsonConverters.BodySwapCreateImageResponseCode6JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.BodySwapCreateImageResponseCode6?))
                {
                    return new global::MagicHour.JsonConverters.BodySwapCreateImageResponseCode6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.FaceSwapPhotoCreateImageResponseCode))
                {
                    return new global::MagicHour.JsonConverters.FaceSwapPhotoCreateImageResponseCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.FaceSwapPhotoCreateImageResponseCode?))
                {
                    return new global::MagicHour.JsonConverters.FaceSwapPhotoCreateImageResponseCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.FaceSwapPhotoCreateImageResponseCode2))
                {
                    return new global::MagicHour.JsonConverters.FaceSwapPhotoCreateImageResponseCode2JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.FaceSwapPhotoCreateImageResponseCode2?))
                {
                    return new global::MagicHour.JsonConverters.FaceSwapPhotoCreateImageResponseCode2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.FaceSwapPhotoCreateImageResponseCode3))
                {
                    return new global::MagicHour.JsonConverters.FaceSwapPhotoCreateImageResponseCode3JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.FaceSwapPhotoCreateImageResponseCode3?))
                {
                    return new global::MagicHour.JsonConverters.FaceSwapPhotoCreateImageResponseCode3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.FaceSwapPhotoCreateImageResponseCode4))
                {
                    return new global::MagicHour.JsonConverters.FaceSwapPhotoCreateImageResponseCode4JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.FaceSwapPhotoCreateImageResponseCode4?))
                {
                    return new global::MagicHour.JsonConverters.FaceSwapPhotoCreateImageResponseCode4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.FaceSwapPhotoCreateImageResponseCode5))
                {
                    return new global::MagicHour.JsonConverters.FaceSwapPhotoCreateImageResponseCode5JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.FaceSwapPhotoCreateImageResponseCode5?))
                {
                    return new global::MagicHour.JsonConverters.FaceSwapPhotoCreateImageResponseCode5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.FaceSwapPhotoCreateImageResponseCode6))
                {
                    return new global::MagicHour.JsonConverters.FaceSwapPhotoCreateImageResponseCode6JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.FaceSwapPhotoCreateImageResponseCode6?))
                {
                    return new global::MagicHour.JsonConverters.FaceSwapPhotoCreateImageResponseCode6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.HeadSwapCreateImageResponseCode))
                {
                    return new global::MagicHour.JsonConverters.HeadSwapCreateImageResponseCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.HeadSwapCreateImageResponseCode?))
                {
                    return new global::MagicHour.JsonConverters.HeadSwapCreateImageResponseCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.HeadSwapCreateImageResponseCode2))
                {
                    return new global::MagicHour.JsonConverters.HeadSwapCreateImageResponseCode2JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.HeadSwapCreateImageResponseCode2?))
                {
                    return new global::MagicHour.JsonConverters.HeadSwapCreateImageResponseCode2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.HeadSwapCreateImageResponseCode3))
                {
                    return new global::MagicHour.JsonConverters.HeadSwapCreateImageResponseCode3JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.HeadSwapCreateImageResponseCode3?))
                {
                    return new global::MagicHour.JsonConverters.HeadSwapCreateImageResponseCode3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.HeadSwapCreateImageResponseCode4))
                {
                    return new global::MagicHour.JsonConverters.HeadSwapCreateImageResponseCode4JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.HeadSwapCreateImageResponseCode4?))
                {
                    return new global::MagicHour.JsonConverters.HeadSwapCreateImageResponseCode4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.HeadSwapCreateImageResponseCode5))
                {
                    return new global::MagicHour.JsonConverters.HeadSwapCreateImageResponseCode5JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.HeadSwapCreateImageResponseCode5?))
                {
                    return new global::MagicHour.JsonConverters.HeadSwapCreateImageResponseCode5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.HeadSwapCreateImageResponseCode6))
                {
                    return new global::MagicHour.JsonConverters.HeadSwapCreateImageResponseCode6JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.HeadSwapCreateImageResponseCode6?))
                {
                    return new global::MagicHour.JsonConverters.HeadSwapCreateImageResponseCode6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.ImageBackgroundRemoverCreateImageResponseCode))
                {
                    return new global::MagicHour.JsonConverters.ImageBackgroundRemoverCreateImageResponseCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.ImageBackgroundRemoverCreateImageResponseCode?))
                {
                    return new global::MagicHour.JsonConverters.ImageBackgroundRemoverCreateImageResponseCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.ImageBackgroundRemoverCreateImageResponseCode2))
                {
                    return new global::MagicHour.JsonConverters.ImageBackgroundRemoverCreateImageResponseCode2JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.ImageBackgroundRemoverCreateImageResponseCode2?))
                {
                    return new global::MagicHour.JsonConverters.ImageBackgroundRemoverCreateImageResponseCode2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.ImageBackgroundRemoverCreateImageResponseCode3))
                {
                    return new global::MagicHour.JsonConverters.ImageBackgroundRemoverCreateImageResponseCode3JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.ImageBackgroundRemoverCreateImageResponseCode3?))
                {
                    return new global::MagicHour.JsonConverters.ImageBackgroundRemoverCreateImageResponseCode3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.ImageBackgroundRemoverCreateImageResponseCode4))
                {
                    return new global::MagicHour.JsonConverters.ImageBackgroundRemoverCreateImageResponseCode4JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.ImageBackgroundRemoverCreateImageResponseCode4?))
                {
                    return new global::MagicHour.JsonConverters.ImageBackgroundRemoverCreateImageResponseCode4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.ImageBackgroundRemoverCreateImageResponseCode5))
                {
                    return new global::MagicHour.JsonConverters.ImageBackgroundRemoverCreateImageResponseCode5JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.ImageBackgroundRemoverCreateImageResponseCode5?))
                {
                    return new global::MagicHour.JsonConverters.ImageBackgroundRemoverCreateImageResponseCode5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.ImageBackgroundRemoverCreateImageResponseCode6))
                {
                    return new global::MagicHour.JsonConverters.ImageBackgroundRemoverCreateImageResponseCode6JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.ImageBackgroundRemoverCreateImageResponseCode6?))
                {
                    return new global::MagicHour.JsonConverters.ImageBackgroundRemoverCreateImageResponseCode6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.PhotoColorizerCreateImageResponseCode))
                {
                    return new global::MagicHour.JsonConverters.PhotoColorizerCreateImageResponseCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.PhotoColorizerCreateImageResponseCode?))
                {
                    return new global::MagicHour.JsonConverters.PhotoColorizerCreateImageResponseCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.PhotoColorizerCreateImageResponseCode2))
                {
                    return new global::MagicHour.JsonConverters.PhotoColorizerCreateImageResponseCode2JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.PhotoColorizerCreateImageResponseCode2?))
                {
                    return new global::MagicHour.JsonConverters.PhotoColorizerCreateImageResponseCode2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.PhotoColorizerCreateImageResponseCode3))
                {
                    return new global::MagicHour.JsonConverters.PhotoColorizerCreateImageResponseCode3JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.PhotoColorizerCreateImageResponseCode3?))
                {
                    return new global::MagicHour.JsonConverters.PhotoColorizerCreateImageResponseCode3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.PhotoColorizerCreateImageResponseCode4))
                {
                    return new global::MagicHour.JsonConverters.PhotoColorizerCreateImageResponseCode4JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.PhotoColorizerCreateImageResponseCode4?))
                {
                    return new global::MagicHour.JsonConverters.PhotoColorizerCreateImageResponseCode4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.PhotoColorizerCreateImageResponseCode5))
                {
                    return new global::MagicHour.JsonConverters.PhotoColorizerCreateImageResponseCode5JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.PhotoColorizerCreateImageResponseCode5?))
                {
                    return new global::MagicHour.JsonConverters.PhotoColorizerCreateImageResponseCode5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.PhotoColorizerCreateImageResponseCode6))
                {
                    return new global::MagicHour.JsonConverters.PhotoColorizerCreateImageResponseCode6JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.PhotoColorizerCreateImageResponseCode6?))
                {
                    return new global::MagicHour.JsonConverters.PhotoColorizerCreateImageResponseCode6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AudioProjectsGetDetailsResponseStatus))
                {
                    return new global::MagicHour.JsonConverters.AudioProjectsGetDetailsResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AudioProjectsGetDetailsResponseStatus?))
                {
                    return new global::MagicHour.JsonConverters.AudioProjectsGetDetailsResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AudioProjectsGetDetailsResponseCode))
                {
                    return new global::MagicHour.JsonConverters.AudioProjectsGetDetailsResponseCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AudioProjectsGetDetailsResponseCode?))
                {
                    return new global::MagicHour.JsonConverters.AudioProjectsGetDetailsResponseCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AudioProjectsGetDetailsResponseCode2))
                {
                    return new global::MagicHour.JsonConverters.AudioProjectsGetDetailsResponseCode2JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AudioProjectsGetDetailsResponseCode2?))
                {
                    return new global::MagicHour.JsonConverters.AudioProjectsGetDetailsResponseCode2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AudioProjectsGetDetailsResponseCode3))
                {
                    return new global::MagicHour.JsonConverters.AudioProjectsGetDetailsResponseCode3JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AudioProjectsGetDetailsResponseCode3?))
                {
                    return new global::MagicHour.JsonConverters.AudioProjectsGetDetailsResponseCode3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AudioProjectsGetDetailsResponseCode4))
                {
                    return new global::MagicHour.JsonConverters.AudioProjectsGetDetailsResponseCode4JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AudioProjectsGetDetailsResponseCode4?))
                {
                    return new global::MagicHour.JsonConverters.AudioProjectsGetDetailsResponseCode4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AudioProjectsGetDetailsResponseCode5))
                {
                    return new global::MagicHour.JsonConverters.AudioProjectsGetDetailsResponseCode5JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AudioProjectsGetDetailsResponseCode5?))
                {
                    return new global::MagicHour.JsonConverters.AudioProjectsGetDetailsResponseCode5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AudioProjectsDeleteResponseCode))
                {
                    return new global::MagicHour.JsonConverters.AudioProjectsDeleteResponseCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AudioProjectsDeleteResponseCode?))
                {
                    return new global::MagicHour.JsonConverters.AudioProjectsDeleteResponseCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AudioProjectsDeleteResponseCode2))
                {
                    return new global::MagicHour.JsonConverters.AudioProjectsDeleteResponseCode2JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AudioProjectsDeleteResponseCode2?))
                {
                    return new global::MagicHour.JsonConverters.AudioProjectsDeleteResponseCode2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AudioProjectsDeleteResponseCode3))
                {
                    return new global::MagicHour.JsonConverters.AudioProjectsDeleteResponseCode3JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AudioProjectsDeleteResponseCode3?))
                {
                    return new global::MagicHour.JsonConverters.AudioProjectsDeleteResponseCode3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AudioProjectsDeleteResponseCode4))
                {
                    return new global::MagicHour.JsonConverters.AudioProjectsDeleteResponseCode4JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AudioProjectsDeleteResponseCode4?))
                {
                    return new global::MagicHour.JsonConverters.AudioProjectsDeleteResponseCode4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AudioProjectsDeleteResponseCode5))
                {
                    return new global::MagicHour.JsonConverters.AudioProjectsDeleteResponseCode5JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AudioProjectsDeleteResponseCode5?))
                {
                    return new global::MagicHour.JsonConverters.AudioProjectsDeleteResponseCode5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiVoiceGeneratorCreateAudioResponseCode))
                {
                    return new global::MagicHour.JsonConverters.AiVoiceGeneratorCreateAudioResponseCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiVoiceGeneratorCreateAudioResponseCode?))
                {
                    return new global::MagicHour.JsonConverters.AiVoiceGeneratorCreateAudioResponseCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiVoiceGeneratorCreateAudioResponseCode2))
                {
                    return new global::MagicHour.JsonConverters.AiVoiceGeneratorCreateAudioResponseCode2JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiVoiceGeneratorCreateAudioResponseCode2?))
                {
                    return new global::MagicHour.JsonConverters.AiVoiceGeneratorCreateAudioResponseCode2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiVoiceGeneratorCreateAudioResponseCode3))
                {
                    return new global::MagicHour.JsonConverters.AiVoiceGeneratorCreateAudioResponseCode3JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiVoiceGeneratorCreateAudioResponseCode3?))
                {
                    return new global::MagicHour.JsonConverters.AiVoiceGeneratorCreateAudioResponseCode3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiVoiceGeneratorCreateAudioResponseCode4))
                {
                    return new global::MagicHour.JsonConverters.AiVoiceGeneratorCreateAudioResponseCode4JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiVoiceGeneratorCreateAudioResponseCode4?))
                {
                    return new global::MagicHour.JsonConverters.AiVoiceGeneratorCreateAudioResponseCode4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiVoiceGeneratorCreateAudioResponseCode5))
                {
                    return new global::MagicHour.JsonConverters.AiVoiceGeneratorCreateAudioResponseCode5JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiVoiceGeneratorCreateAudioResponseCode5?))
                {
                    return new global::MagicHour.JsonConverters.AiVoiceGeneratorCreateAudioResponseCode5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiVoiceGeneratorCreateAudioResponseCode6))
                {
                    return new global::MagicHour.JsonConverters.AiVoiceGeneratorCreateAudioResponseCode6JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiVoiceGeneratorCreateAudioResponseCode6?))
                {
                    return new global::MagicHour.JsonConverters.AiVoiceGeneratorCreateAudioResponseCode6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiVoiceClonerCreateAudioResponseCode))
                {
                    return new global::MagicHour.JsonConverters.AiVoiceClonerCreateAudioResponseCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiVoiceClonerCreateAudioResponseCode?))
                {
                    return new global::MagicHour.JsonConverters.AiVoiceClonerCreateAudioResponseCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiVoiceClonerCreateAudioResponseCode2))
                {
                    return new global::MagicHour.JsonConverters.AiVoiceClonerCreateAudioResponseCode2JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiVoiceClonerCreateAudioResponseCode2?))
                {
                    return new global::MagicHour.JsonConverters.AiVoiceClonerCreateAudioResponseCode2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiVoiceClonerCreateAudioResponseCode3))
                {
                    return new global::MagicHour.JsonConverters.AiVoiceClonerCreateAudioResponseCode3JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiVoiceClonerCreateAudioResponseCode3?))
                {
                    return new global::MagicHour.JsonConverters.AiVoiceClonerCreateAudioResponseCode3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiVoiceClonerCreateAudioResponseCode4))
                {
                    return new global::MagicHour.JsonConverters.AiVoiceClonerCreateAudioResponseCode4JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiVoiceClonerCreateAudioResponseCode4?))
                {
                    return new global::MagicHour.JsonConverters.AiVoiceClonerCreateAudioResponseCode4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiVoiceClonerCreateAudioResponseCode5))
                {
                    return new global::MagicHour.JsonConverters.AiVoiceClonerCreateAudioResponseCode5JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiVoiceClonerCreateAudioResponseCode5?))
                {
                    return new global::MagicHour.JsonConverters.AiVoiceClonerCreateAudioResponseCode5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiVoiceClonerCreateAudioResponseCode6))
                {
                    return new global::MagicHour.JsonConverters.AiVoiceClonerCreateAudioResponseCode6JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiVoiceClonerCreateAudioResponseCode6?))
                {
                    return new global::MagicHour.JsonConverters.AiVoiceClonerCreateAudioResponseCode6NullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[2];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new SourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => new SourceGenerationContextChunk1(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}