
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
            typeof(global::MagicHour.JsonConverters.VideoAssetsGeneratePresignedUrlRequestItemTypeJsonConverter),

            typeof(global::MagicHour.JsonConverters.VideoAssetsGeneratePresignedUrlRequestItemTypeNullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.AiTalkingPhotoCreateTalkingPhotoRequestStyleGenerationModeJsonConverter),

            typeof(global::MagicHour.JsonConverters.AiTalkingPhotoCreateTalkingPhotoRequestStyleGenerationModeNullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.AnimationCreateVideoRequestStyleArtStyleJsonConverter),

            typeof(global::MagicHour.JsonConverters.AnimationCreateVideoRequestStyleArtStyleNullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.AnimationCreateVideoRequestStyleCameraEffectJsonConverter),

            typeof(global::MagicHour.JsonConverters.AnimationCreateVideoRequestStyleCameraEffectNullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.AnimationCreateVideoRequestStylePromptTypeJsonConverter),

            typeof(global::MagicHour.JsonConverters.AnimationCreateVideoRequestStylePromptTypeNullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.AnimationCreateVideoRequestAssetsAudioSourceJsonConverter),

            typeof(global::MagicHour.JsonConverters.AnimationCreateVideoRequestAssetsAudioSourceNullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.AutoSubtitleGeneratorCreateVideoRequestStyleTemplateJsonConverter),

            typeof(global::MagicHour.JsonConverters.AutoSubtitleGeneratorCreateVideoRequestStyleTemplateNullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.FaceSwapCreateVideoRequestStyleVersionJsonConverter),

            typeof(global::MagicHour.JsonConverters.FaceSwapCreateVideoRequestStyleVersionNullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.FaceSwapCreateVideoRequestAssetsFaceSwapModeJsonConverter),

            typeof(global::MagicHour.JsonConverters.FaceSwapCreateVideoRequestAssetsFaceSwapModeNullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.FaceSwapCreateVideoRequestAssetsVideoSourceJsonConverter),

            typeof(global::MagicHour.JsonConverters.FaceSwapCreateVideoRequestAssetsVideoSourceNullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.ImageToVideoCreateVideoRequestModelJsonConverter),

            typeof(global::MagicHour.JsonConverters.ImageToVideoCreateVideoRequestModelNullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.ImageToVideoCreateVideoRequestResolutionJsonConverter),

            typeof(global::MagicHour.JsonConverters.ImageToVideoCreateVideoRequestResolutionNullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.LipSyncCreateVideoRequestAssetsVideoSourceJsonConverter),

            typeof(global::MagicHour.JsonConverters.LipSyncCreateVideoRequestAssetsVideoSourceNullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.LipSyncCreateVideoRequestStyleGenerationModeJsonConverter),

            typeof(global::MagicHour.JsonConverters.LipSyncCreateVideoRequestStyleGenerationModeNullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.VideoToVideoCreateVideoRequestFpsResolutionJsonConverter),

            typeof(global::MagicHour.JsonConverters.VideoToVideoCreateVideoRequestFpsResolutionNullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.VideoToVideoCreateVideoRequestStyleArtStyleJsonConverter),

            typeof(global::MagicHour.JsonConverters.VideoToVideoCreateVideoRequestStyleArtStyleNullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.VideoToVideoCreateVideoRequestStyleVersionJsonConverter),

            typeof(global::MagicHour.JsonConverters.VideoToVideoCreateVideoRequestStyleVersionNullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.VideoToVideoCreateVideoRequestStylePromptTypeJsonConverter),

            typeof(global::MagicHour.JsonConverters.VideoToVideoCreateVideoRequestStylePromptTypeNullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.VideoToVideoCreateVideoRequestStyleModelJsonConverter),

            typeof(global::MagicHour.JsonConverters.VideoToVideoCreateVideoRequestStyleModelNullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.VideoToVideoCreateVideoRequestAssetsVideoSourceJsonConverter),

            typeof(global::MagicHour.JsonConverters.VideoToVideoCreateVideoRequestAssetsVideoSourceNullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.TextToVideoCreateVideoRequestAspectRatioJsonConverter),

            typeof(global::MagicHour.JsonConverters.TextToVideoCreateVideoRequestAspectRatioNullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.TextToVideoCreateVideoRequestResolutionJsonConverter),

            typeof(global::MagicHour.JsonConverters.TextToVideoCreateVideoRequestResolutionNullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.TextToVideoCreateVideoRequestModelJsonConverter),

            typeof(global::MagicHour.JsonConverters.TextToVideoCreateVideoRequestModelNullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.AiClothesChangerCreateImageRequestAssetsGarmentTypeJsonConverter),

            typeof(global::MagicHour.JsonConverters.AiClothesChangerCreateImageRequestAssetsGarmentTypeNullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.AiGifGeneratorCreateImageRequestOutputFormatJsonConverter),

            typeof(global::MagicHour.JsonConverters.AiGifGeneratorCreateImageRequestOutputFormatNullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.AiImageEditorCreateImageRequestModelJsonConverter),

            typeof(global::MagicHour.JsonConverters.AiImageEditorCreateImageRequestModelNullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.AiImageEditorCreateImageRequestAspectRatioJsonConverter),

            typeof(global::MagicHour.JsonConverters.AiImageEditorCreateImageRequestAspectRatioNullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.AiImageEditorCreateImageRequestResolutionJsonConverter),

            typeof(global::MagicHour.JsonConverters.AiImageEditorCreateImageRequestResolutionNullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.AiImageGeneratorCreateImageRequestModelJsonConverter),

            typeof(global::MagicHour.JsonConverters.AiImageGeneratorCreateImageRequestModelNullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.AiImageGeneratorCreateImageRequestAspectRatioJsonConverter),

            typeof(global::MagicHour.JsonConverters.AiImageGeneratorCreateImageRequestAspectRatioNullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.AiImageGeneratorCreateImageRequestResolutionJsonConverter),

            typeof(global::MagicHour.JsonConverters.AiImageGeneratorCreateImageRequestResolutionNullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.AiImageGeneratorCreateImageRequestStyleToolJsonConverter),

            typeof(global::MagicHour.JsonConverters.AiImageGeneratorCreateImageRequestStyleToolNullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.AiImageUpscalerCreateImageRequestStyleEnhancementJsonConverter),

            typeof(global::MagicHour.JsonConverters.AiImageUpscalerCreateImageRequestStyleEnhancementNullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.AiMemeGeneratorCreateImageRequestStyleTemplateJsonConverter),

            typeof(global::MagicHour.JsonConverters.AiMemeGeneratorCreateImageRequestStyleTemplateNullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.FaceSwapPhotoCreateImageRequestAssetsFaceSwapModeJsonConverter),

            typeof(global::MagicHour.JsonConverters.FaceSwapPhotoCreateImageRequestAssetsFaceSwapModeNullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.AiVoiceGeneratorCreateAudioRequestStyleVoiceNameJsonConverter),

            typeof(global::MagicHour.JsonConverters.AiVoiceGeneratorCreateAudioRequestStyleVoiceNameNullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.VideoAssetsGeneratePresignedUrlResponseMessageJsonConverter),

            typeof(global::MagicHour.JsonConverters.VideoAssetsGeneratePresignedUrlResponseMessageNullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.VideoAssetsGeneratePresignedUrlResponseMessage2JsonConverter),

            typeof(global::MagicHour.JsonConverters.VideoAssetsGeneratePresignedUrlResponseMessage2NullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.FaceDetectionGetDetailsResponseStatusJsonConverter),

            typeof(global::MagicHour.JsonConverters.FaceDetectionGetDetailsResponseStatusNullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.FaceDetectionGetDetailsResponseMessageJsonConverter),

            typeof(global::MagicHour.JsonConverters.FaceDetectionGetDetailsResponseMessageNullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.FaceDetectionGetDetailsResponseMessage2JsonConverter),

            typeof(global::MagicHour.JsonConverters.FaceDetectionGetDetailsResponseMessage2NullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.FaceDetectionDetectFacesResponseMessageJsonConverter),

            typeof(global::MagicHour.JsonConverters.FaceDetectionDetectFacesResponseMessageNullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.FaceDetectionDetectFacesResponseMessage2JsonConverter),

            typeof(global::MagicHour.JsonConverters.FaceDetectionDetectFacesResponseMessage2NullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.VideoProjectsGetDetailsResponseStatusJsonConverter),

            typeof(global::MagicHour.JsonConverters.VideoProjectsGetDetailsResponseStatusNullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.VideoProjectsGetDetailsResponseMessageJsonConverter),

            typeof(global::MagicHour.JsonConverters.VideoProjectsGetDetailsResponseMessageNullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.VideoProjectsGetDetailsResponseMessage2JsonConverter),

            typeof(global::MagicHour.JsonConverters.VideoProjectsGetDetailsResponseMessage2NullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.VideoProjectsDeleteResponseMessageJsonConverter),

            typeof(global::MagicHour.JsonConverters.VideoProjectsDeleteResponseMessageNullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.VideoProjectsDeleteResponseMessage2JsonConverter),

            typeof(global::MagicHour.JsonConverters.VideoProjectsDeleteResponseMessage2NullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.AiTalkingPhotoCreateTalkingPhotoResponseMessageJsonConverter),

            typeof(global::MagicHour.JsonConverters.AiTalkingPhotoCreateTalkingPhotoResponseMessageNullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.AiTalkingPhotoCreateTalkingPhotoResponseMessage2JsonConverter),

            typeof(global::MagicHour.JsonConverters.AiTalkingPhotoCreateTalkingPhotoResponseMessage2NullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.AnimationCreateVideoResponseMessageJsonConverter),

            typeof(global::MagicHour.JsonConverters.AnimationCreateVideoResponseMessageNullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.AnimationCreateVideoResponseMessage2JsonConverter),

            typeof(global::MagicHour.JsonConverters.AnimationCreateVideoResponseMessage2NullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.AutoSubtitleGeneratorCreateVideoResponseMessageJsonConverter),

            typeof(global::MagicHour.JsonConverters.AutoSubtitleGeneratorCreateVideoResponseMessageNullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.AutoSubtitleGeneratorCreateVideoResponseMessage2JsonConverter),

            typeof(global::MagicHour.JsonConverters.AutoSubtitleGeneratorCreateVideoResponseMessage2NullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.FaceSwapCreateVideoResponseMessageJsonConverter),

            typeof(global::MagicHour.JsonConverters.FaceSwapCreateVideoResponseMessageNullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.FaceSwapCreateVideoResponseMessage2JsonConverter),

            typeof(global::MagicHour.JsonConverters.FaceSwapCreateVideoResponseMessage2NullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.ImageToVideoCreateVideoResponseMessageJsonConverter),

            typeof(global::MagicHour.JsonConverters.ImageToVideoCreateVideoResponseMessageNullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.ImageToVideoCreateVideoResponseMessage2JsonConverter),

            typeof(global::MagicHour.JsonConverters.ImageToVideoCreateVideoResponseMessage2NullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.LipSyncCreateVideoResponseMessageJsonConverter),

            typeof(global::MagicHour.JsonConverters.LipSyncCreateVideoResponseMessageNullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.LipSyncCreateVideoResponseMessage2JsonConverter),

            typeof(global::MagicHour.JsonConverters.LipSyncCreateVideoResponseMessage2NullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.VideoToVideoCreateVideoResponseMessageJsonConverter),

            typeof(global::MagicHour.JsonConverters.VideoToVideoCreateVideoResponseMessageNullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.VideoToVideoCreateVideoResponseMessage2JsonConverter),

            typeof(global::MagicHour.JsonConverters.VideoToVideoCreateVideoResponseMessage2NullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.TextToVideoCreateVideoResponseMessageJsonConverter),

            typeof(global::MagicHour.JsonConverters.TextToVideoCreateVideoResponseMessageNullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.TextToVideoCreateVideoResponseMessage2JsonConverter),

            typeof(global::MagicHour.JsonConverters.TextToVideoCreateVideoResponseMessage2NullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.ImageProjectsGetDetailsResponseStatusJsonConverter),

            typeof(global::MagicHour.JsonConverters.ImageProjectsGetDetailsResponseStatusNullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.ImageProjectsGetDetailsResponseMessageJsonConverter),

            typeof(global::MagicHour.JsonConverters.ImageProjectsGetDetailsResponseMessageNullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.ImageProjectsGetDetailsResponseMessage2JsonConverter),

            typeof(global::MagicHour.JsonConverters.ImageProjectsGetDetailsResponseMessage2NullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.ImageProjectsDeleteResponseMessageJsonConverter),

            typeof(global::MagicHour.JsonConverters.ImageProjectsDeleteResponseMessageNullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.ImageProjectsDeleteResponseMessage2JsonConverter),

            typeof(global::MagicHour.JsonConverters.ImageProjectsDeleteResponseMessage2NullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.AiClothesChangerCreateImageResponseMessageJsonConverter),

            typeof(global::MagicHour.JsonConverters.AiClothesChangerCreateImageResponseMessageNullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.AiClothesChangerCreateImageResponseMessage2JsonConverter),

            typeof(global::MagicHour.JsonConverters.AiClothesChangerCreateImageResponseMessage2NullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.AiFaceEditorEditImageResponseMessageJsonConverter),

            typeof(global::MagicHour.JsonConverters.AiFaceEditorEditImageResponseMessageNullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.AiFaceEditorEditImageResponseMessage2JsonConverter),

            typeof(global::MagicHour.JsonConverters.AiFaceEditorEditImageResponseMessage2NullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.AiGifGeneratorCreateImageResponseMessageJsonConverter),

            typeof(global::MagicHour.JsonConverters.AiGifGeneratorCreateImageResponseMessageNullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.AiGifGeneratorCreateImageResponseMessage2JsonConverter),

            typeof(global::MagicHour.JsonConverters.AiGifGeneratorCreateImageResponseMessage2NullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.AiImageEditorCreateImageResponseMessageJsonConverter),

            typeof(global::MagicHour.JsonConverters.AiImageEditorCreateImageResponseMessageNullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.AiImageEditorCreateImageResponseMessage2JsonConverter),

            typeof(global::MagicHour.JsonConverters.AiImageEditorCreateImageResponseMessage2NullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.AiHeadshotGeneratorCreateImageResponseMessageJsonConverter),

            typeof(global::MagicHour.JsonConverters.AiHeadshotGeneratorCreateImageResponseMessageNullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.AiHeadshotGeneratorCreateImageResponseMessage2JsonConverter),

            typeof(global::MagicHour.JsonConverters.AiHeadshotGeneratorCreateImageResponseMessage2NullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.AiImageGeneratorCreateImageResponseMessageJsonConverter),

            typeof(global::MagicHour.JsonConverters.AiImageGeneratorCreateImageResponseMessageNullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.AiImageGeneratorCreateImageResponseMessage2JsonConverter),

            typeof(global::MagicHour.JsonConverters.AiImageGeneratorCreateImageResponseMessage2NullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.AiImageUpscalerCreateImageResponseMessageJsonConverter),

            typeof(global::MagicHour.JsonConverters.AiImageUpscalerCreateImageResponseMessageNullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.AiImageUpscalerCreateImageResponseMessage2JsonConverter),

            typeof(global::MagicHour.JsonConverters.AiImageUpscalerCreateImageResponseMessage2NullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.AiMemeGeneratorCreateImageResponseMessageJsonConverter),

            typeof(global::MagicHour.JsonConverters.AiMemeGeneratorCreateImageResponseMessageNullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.AiMemeGeneratorCreateImageResponseMessage2JsonConverter),

            typeof(global::MagicHour.JsonConverters.AiMemeGeneratorCreateImageResponseMessage2NullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.AiQrCodeGeneratorCreateImageResponseMessageJsonConverter),

            typeof(global::MagicHour.JsonConverters.AiQrCodeGeneratorCreateImageResponseMessageNullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.AiQrCodeGeneratorCreateImageResponseMessage2JsonConverter),

            typeof(global::MagicHour.JsonConverters.AiQrCodeGeneratorCreateImageResponseMessage2NullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.FaceSwapPhotoCreateImageResponseMessageJsonConverter),

            typeof(global::MagicHour.JsonConverters.FaceSwapPhotoCreateImageResponseMessageNullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.FaceSwapPhotoCreateImageResponseMessage2JsonConverter),

            typeof(global::MagicHour.JsonConverters.FaceSwapPhotoCreateImageResponseMessage2NullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.HeadSwapCreateImageResponseMessageJsonConverter),

            typeof(global::MagicHour.JsonConverters.HeadSwapCreateImageResponseMessageNullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.HeadSwapCreateImageResponseMessage2JsonConverter),

            typeof(global::MagicHour.JsonConverters.HeadSwapCreateImageResponseMessage2NullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.ImageBackgroundRemoverCreateImageResponseMessageJsonConverter),

            typeof(global::MagicHour.JsonConverters.ImageBackgroundRemoverCreateImageResponseMessageNullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.ImageBackgroundRemoverCreateImageResponseMessage2JsonConverter),

            typeof(global::MagicHour.JsonConverters.ImageBackgroundRemoverCreateImageResponseMessage2NullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.PhotoColorizerCreateImageResponseMessageJsonConverter),

            typeof(global::MagicHour.JsonConverters.PhotoColorizerCreateImageResponseMessageNullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.PhotoColorizerCreateImageResponseMessage2JsonConverter),

            typeof(global::MagicHour.JsonConverters.PhotoColorizerCreateImageResponseMessage2NullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.AudioProjectsGetDetailsResponseStatusJsonConverter),

            typeof(global::MagicHour.JsonConverters.AudioProjectsGetDetailsResponseStatusNullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.AudioProjectsGetDetailsResponseMessageJsonConverter),

            typeof(global::MagicHour.JsonConverters.AudioProjectsGetDetailsResponseMessageNullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.AudioProjectsGetDetailsResponseMessage2JsonConverter),

            typeof(global::MagicHour.JsonConverters.AudioProjectsGetDetailsResponseMessage2NullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.AudioProjectsDeleteResponseMessageJsonConverter),

            typeof(global::MagicHour.JsonConverters.AudioProjectsDeleteResponseMessageNullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.AudioProjectsDeleteResponseMessage2JsonConverter),

            typeof(global::MagicHour.JsonConverters.AudioProjectsDeleteResponseMessage2NullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.AiVoiceGeneratorCreateAudioResponseMessageJsonConverter),

            typeof(global::MagicHour.JsonConverters.AiVoiceGeneratorCreateAudioResponseMessageNullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.AiVoiceGeneratorCreateAudioResponseMessage2JsonConverter),

            typeof(global::MagicHour.JsonConverters.AiVoiceGeneratorCreateAudioResponseMessage2NullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.AiVoiceClonerCreateAudioResponseMessageJsonConverter),

            typeof(global::MagicHour.JsonConverters.AiVoiceClonerCreateAudioResponseMessageNullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.AiVoiceClonerCreateAudioResponseMessage2JsonConverter),

            typeof(global::MagicHour.JsonConverters.AiVoiceClonerCreateAudioResponseMessage2NullableJsonConverter),

            typeof(global::MagicHour.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.JsonSerializerContextTypes))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AnimationCreateVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AnimationCreateVideoRequestStyle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AnimationCreateVideoRequestStyleArtStyle), TypeInfoPropertyName = "AnimationCreateVideoRequestStyleArtStyle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AnimationCreateVideoRequestStyleCameraEffect), TypeInfoPropertyName = "AnimationCreateVideoRequestStyleCameraEffect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AnimationCreateVideoRequestStylePromptType), TypeInfoPropertyName = "AnimationCreateVideoRequestStylePromptType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AnimationCreateVideoRequestAssets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AnimationCreateVideoRequestAssetsAudioSource), TypeInfoPropertyName = "AnimationCreateVideoRequestAssetsAudioSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AutoSubtitleGeneratorCreateVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AutoSubtitleGeneratorCreateVideoRequestAssets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AutoSubtitleGeneratorCreateVideoRequestStyle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AutoSubtitleGeneratorCreateVideoRequestStyleTemplate), TypeInfoPropertyName = "AutoSubtitleGeneratorCreateVideoRequestStyleTemplate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AutoSubtitleGeneratorCreateVideoRequestStyleCustomConfig))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoToVideoCreateVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoToVideoCreateVideoRequestFpsResolution), TypeInfoPropertyName = "VideoToVideoCreateVideoRequestFpsResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoToVideoCreateVideoRequestStyle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoToVideoCreateVideoRequestStyleArtStyle), TypeInfoPropertyName = "VideoToVideoCreateVideoRequestStyleArtStyle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoToVideoCreateVideoRequestStyleVersion), TypeInfoPropertyName = "VideoToVideoCreateVideoRequestStyleVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoToVideoCreateVideoRequestStylePromptType), TypeInfoPropertyName = "VideoToVideoCreateVideoRequestStylePromptType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoToVideoCreateVideoRequestStyleModel), TypeInfoPropertyName = "VideoToVideoCreateVideoRequestStyleModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoToVideoCreateVideoRequestAssets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoToVideoCreateVideoRequestAssetsVideoSource), TypeInfoPropertyName = "VideoToVideoCreateVideoRequestAssetsVideoSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.TextToVideoCreateVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.TextToVideoCreateVideoRequestAspectRatio), TypeInfoPropertyName = "TextToVideoCreateVideoRequestAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.TextToVideoCreateVideoRequestResolution), TypeInfoPropertyName = "TextToVideoCreateVideoRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.TextToVideoCreateVideoRequestModel), TypeInfoPropertyName = "TextToVideoCreateVideoRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.TextToVideoCreateVideoRequestStyle))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageUpscalerCreateImageRequestStyleEnhancement), TypeInfoPropertyName = "AiImageUpscalerCreateImageRequestStyleEnhancement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageUpscalerCreateImageRequestAssets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiMemeGeneratorCreateImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiMemeGeneratorCreateImageRequestStyle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiMemeGeneratorCreateImageRequestStyleTemplate), TypeInfoPropertyName = "AiMemeGeneratorCreateImageRequestStyleTemplate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiQrCodeGeneratorCreateImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiQrCodeGeneratorCreateImageRequestStyle))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoAssetsGeneratePresignedUrlResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoAssetsGeneratePresignedUrlResponseMessage), TypeInfoPropertyName = "VideoAssetsGeneratePresignedUrlResponseMessage2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoAssetsGeneratePresignedUrlResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoAssetsGeneratePresignedUrlResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoAssetsGeneratePresignedUrlResponseMessage2), TypeInfoPropertyName = "VideoAssetsGeneratePresignedUrlResponseMessage22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoAssetsGeneratePresignedUrlResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceDetectionGetDetailsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceDetectionGetDetailsResponseStatus), TypeInfoPropertyName = "FaceDetectionGetDetailsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::MagicHour.FaceDetectionGetDetailsResponseFace>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceDetectionGetDetailsResponseFace))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceDetectionGetDetailsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceDetectionGetDetailsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceDetectionGetDetailsResponseMessage), TypeInfoPropertyName = "FaceDetectionGetDetailsResponseMessage2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceDetectionGetDetailsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceDetectionGetDetailsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceDetectionGetDetailsResponseMessage2), TypeInfoPropertyName = "FaceDetectionGetDetailsResponseMessage22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceDetectionGetDetailsResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceDetectionDetectFacesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceDetectionDetectFacesResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceDetectionDetectFacesResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceDetectionDetectFacesResponseMessage), TypeInfoPropertyName = "FaceDetectionDetectFacesResponseMessage2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceDetectionDetectFacesResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceDetectionDetectFacesResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceDetectionDetectFacesResponseMessage2), TypeInfoPropertyName = "FaceDetectionDetectFacesResponseMessage22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceDetectionDetectFacesResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoProjectsGetDetailsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoProjectsGetDetailsResponseStatus), TypeInfoPropertyName = "VideoProjectsGetDetailsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoProjectsGetDetailsResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::MagicHour.VideoProjectsGetDetailsResponseDownload>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoProjectsGetDetailsResponseDownload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoProjectsGetDetailsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoProjectsGetDetailsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoProjectsGetDetailsResponseMessage), TypeInfoPropertyName = "VideoProjectsGetDetailsResponseMessage2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoProjectsGetDetailsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoProjectsGetDetailsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoProjectsGetDetailsResponseMessage2), TypeInfoPropertyName = "VideoProjectsGetDetailsResponseMessage22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoProjectsDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoProjectsDeleteResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoProjectsDeleteResponseMessage), TypeInfoPropertyName = "VideoProjectsDeleteResponseMessage2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoProjectsDeleteResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoProjectsDeleteResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoProjectsDeleteResponseMessage2), TypeInfoPropertyName = "VideoProjectsDeleteResponseMessage22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoProjectsDeleteResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponseMessage), TypeInfoPropertyName = "AiTalkingPhotoCreateTalkingPhotoResponseMessage2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponseMessage2), TypeInfoPropertyName = "AiTalkingPhotoCreateTalkingPhotoResponseMessage22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AnimationCreateVideoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AnimationCreateVideoResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AnimationCreateVideoResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AnimationCreateVideoResponseMessage), TypeInfoPropertyName = "AnimationCreateVideoResponseMessage2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AnimationCreateVideoResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AnimationCreateVideoResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AnimationCreateVideoResponseMessage2), TypeInfoPropertyName = "AnimationCreateVideoResponseMessage22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AnimationCreateVideoResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AutoSubtitleGeneratorCreateVideoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AutoSubtitleGeneratorCreateVideoResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AutoSubtitleGeneratorCreateVideoResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AutoSubtitleGeneratorCreateVideoResponseMessage), TypeInfoPropertyName = "AutoSubtitleGeneratorCreateVideoResponseMessage2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AutoSubtitleGeneratorCreateVideoResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AutoSubtitleGeneratorCreateVideoResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AutoSubtitleGeneratorCreateVideoResponseMessage2), TypeInfoPropertyName = "AutoSubtitleGeneratorCreateVideoResponseMessage22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AutoSubtitleGeneratorCreateVideoResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceSwapCreateVideoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceSwapCreateVideoResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceSwapCreateVideoResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceSwapCreateVideoResponseMessage), TypeInfoPropertyName = "FaceSwapCreateVideoResponseMessage2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceSwapCreateVideoResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceSwapCreateVideoResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceSwapCreateVideoResponseMessage2), TypeInfoPropertyName = "FaceSwapCreateVideoResponseMessage22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceSwapCreateVideoResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageToVideoCreateVideoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageToVideoCreateVideoResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageToVideoCreateVideoResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageToVideoCreateVideoResponseMessage), TypeInfoPropertyName = "ImageToVideoCreateVideoResponseMessage2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageToVideoCreateVideoResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageToVideoCreateVideoResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageToVideoCreateVideoResponseMessage2), TypeInfoPropertyName = "ImageToVideoCreateVideoResponseMessage22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageToVideoCreateVideoResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.LipSyncCreateVideoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.LipSyncCreateVideoResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.LipSyncCreateVideoResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.LipSyncCreateVideoResponseMessage), TypeInfoPropertyName = "LipSyncCreateVideoResponseMessage2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.LipSyncCreateVideoResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.LipSyncCreateVideoResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.LipSyncCreateVideoResponseMessage2), TypeInfoPropertyName = "LipSyncCreateVideoResponseMessage22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.LipSyncCreateVideoResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoToVideoCreateVideoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoToVideoCreateVideoResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoToVideoCreateVideoResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoToVideoCreateVideoResponseMessage), TypeInfoPropertyName = "VideoToVideoCreateVideoResponseMessage2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoToVideoCreateVideoResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoToVideoCreateVideoResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoToVideoCreateVideoResponseMessage2), TypeInfoPropertyName = "VideoToVideoCreateVideoResponseMessage22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.VideoToVideoCreateVideoResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.TextToVideoCreateVideoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.TextToVideoCreateVideoResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.TextToVideoCreateVideoResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.TextToVideoCreateVideoResponseMessage), TypeInfoPropertyName = "TextToVideoCreateVideoResponseMessage2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.TextToVideoCreateVideoResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.TextToVideoCreateVideoResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.TextToVideoCreateVideoResponseMessage2), TypeInfoPropertyName = "TextToVideoCreateVideoResponseMessage22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.TextToVideoCreateVideoResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageProjectsGetDetailsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageProjectsGetDetailsResponseStatus), TypeInfoPropertyName = "ImageProjectsGetDetailsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::MagicHour.ImageProjectsGetDetailsResponseDownload>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageProjectsGetDetailsResponseDownload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageProjectsGetDetailsResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageProjectsGetDetailsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageProjectsGetDetailsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageProjectsGetDetailsResponseMessage), TypeInfoPropertyName = "ImageProjectsGetDetailsResponseMessage2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageProjectsGetDetailsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageProjectsGetDetailsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageProjectsGetDetailsResponseMessage2), TypeInfoPropertyName = "ImageProjectsGetDetailsResponseMessage22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageProjectsDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageProjectsDeleteResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageProjectsDeleteResponseMessage), TypeInfoPropertyName = "ImageProjectsDeleteResponseMessage2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageProjectsDeleteResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageProjectsDeleteResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageProjectsDeleteResponseMessage2), TypeInfoPropertyName = "ImageProjectsDeleteResponseMessage22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiClothesChangerCreateImageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiClothesChangerCreateImageResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiClothesChangerCreateImageResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiClothesChangerCreateImageResponseMessage), TypeInfoPropertyName = "AiClothesChangerCreateImageResponseMessage2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiClothesChangerCreateImageResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiClothesChangerCreateImageResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiClothesChangerCreateImageResponseMessage2), TypeInfoPropertyName = "AiClothesChangerCreateImageResponseMessage22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiClothesChangerCreateImageResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiFaceEditorEditImageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiFaceEditorEditImageResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiFaceEditorEditImageResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiFaceEditorEditImageResponseMessage), TypeInfoPropertyName = "AiFaceEditorEditImageResponseMessage2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiFaceEditorEditImageResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiFaceEditorEditImageResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiFaceEditorEditImageResponseMessage2), TypeInfoPropertyName = "AiFaceEditorEditImageResponseMessage22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiFaceEditorEditImageResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiGifGeneratorCreateImageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiGifGeneratorCreateImageResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiGifGeneratorCreateImageResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiGifGeneratorCreateImageResponseMessage), TypeInfoPropertyName = "AiGifGeneratorCreateImageResponseMessage2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiGifGeneratorCreateImageResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiGifGeneratorCreateImageResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiGifGeneratorCreateImageResponseMessage2), TypeInfoPropertyName = "AiGifGeneratorCreateImageResponseMessage22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiGifGeneratorCreateImageResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageEditorCreateImageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageEditorCreateImageResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageEditorCreateImageResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageEditorCreateImageResponseMessage), TypeInfoPropertyName = "AiImageEditorCreateImageResponseMessage2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageEditorCreateImageResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageEditorCreateImageResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageEditorCreateImageResponseMessage2), TypeInfoPropertyName = "AiImageEditorCreateImageResponseMessage22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageEditorCreateImageResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiHeadshotGeneratorCreateImageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiHeadshotGeneratorCreateImageResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiHeadshotGeneratorCreateImageResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiHeadshotGeneratorCreateImageResponseMessage), TypeInfoPropertyName = "AiHeadshotGeneratorCreateImageResponseMessage2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiHeadshotGeneratorCreateImageResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiHeadshotGeneratorCreateImageResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiHeadshotGeneratorCreateImageResponseMessage2), TypeInfoPropertyName = "AiHeadshotGeneratorCreateImageResponseMessage22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiHeadshotGeneratorCreateImageResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageGeneratorCreateImageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageGeneratorCreateImageResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageGeneratorCreateImageResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageGeneratorCreateImageResponseMessage), TypeInfoPropertyName = "AiImageGeneratorCreateImageResponseMessage2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageGeneratorCreateImageResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageGeneratorCreateImageResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageGeneratorCreateImageResponseMessage2), TypeInfoPropertyName = "AiImageGeneratorCreateImageResponseMessage22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageGeneratorCreateImageResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageUpscalerCreateImageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageUpscalerCreateImageResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageUpscalerCreateImageResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageUpscalerCreateImageResponseMessage), TypeInfoPropertyName = "AiImageUpscalerCreateImageResponseMessage2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageUpscalerCreateImageResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageUpscalerCreateImageResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageUpscalerCreateImageResponseMessage2), TypeInfoPropertyName = "AiImageUpscalerCreateImageResponseMessage22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiImageUpscalerCreateImageResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiMemeGeneratorCreateImageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiMemeGeneratorCreateImageResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiMemeGeneratorCreateImageResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiMemeGeneratorCreateImageResponseMessage), TypeInfoPropertyName = "AiMemeGeneratorCreateImageResponseMessage2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiMemeGeneratorCreateImageResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiMemeGeneratorCreateImageResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiMemeGeneratorCreateImageResponseMessage2), TypeInfoPropertyName = "AiMemeGeneratorCreateImageResponseMessage22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiMemeGeneratorCreateImageResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiQrCodeGeneratorCreateImageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiQrCodeGeneratorCreateImageResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiQrCodeGeneratorCreateImageResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiQrCodeGeneratorCreateImageResponseMessage), TypeInfoPropertyName = "AiQrCodeGeneratorCreateImageResponseMessage2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiQrCodeGeneratorCreateImageResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiQrCodeGeneratorCreateImageResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiQrCodeGeneratorCreateImageResponseMessage2), TypeInfoPropertyName = "AiQrCodeGeneratorCreateImageResponseMessage22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiQrCodeGeneratorCreateImageResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceSwapPhotoCreateImageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceSwapPhotoCreateImageResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceSwapPhotoCreateImageResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceSwapPhotoCreateImageResponseMessage), TypeInfoPropertyName = "FaceSwapPhotoCreateImageResponseMessage2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceSwapPhotoCreateImageResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceSwapPhotoCreateImageResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceSwapPhotoCreateImageResponseMessage2), TypeInfoPropertyName = "FaceSwapPhotoCreateImageResponseMessage22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.FaceSwapPhotoCreateImageResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.HeadSwapCreateImageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.HeadSwapCreateImageResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.HeadSwapCreateImageResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.HeadSwapCreateImageResponseMessage), TypeInfoPropertyName = "HeadSwapCreateImageResponseMessage2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.HeadSwapCreateImageResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.HeadSwapCreateImageResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.HeadSwapCreateImageResponseMessage2), TypeInfoPropertyName = "HeadSwapCreateImageResponseMessage22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.HeadSwapCreateImageResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageBackgroundRemoverCreateImageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageBackgroundRemoverCreateImageResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageBackgroundRemoverCreateImageResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageBackgroundRemoverCreateImageResponseMessage), TypeInfoPropertyName = "ImageBackgroundRemoverCreateImageResponseMessage2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageBackgroundRemoverCreateImageResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageBackgroundRemoverCreateImageResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageBackgroundRemoverCreateImageResponseMessage2), TypeInfoPropertyName = "ImageBackgroundRemoverCreateImageResponseMessage22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.ImageBackgroundRemoverCreateImageResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.PhotoColorizerCreateImageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.PhotoColorizerCreateImageResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.PhotoColorizerCreateImageResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.PhotoColorizerCreateImageResponseMessage), TypeInfoPropertyName = "PhotoColorizerCreateImageResponseMessage2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.PhotoColorizerCreateImageResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.PhotoColorizerCreateImageResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.PhotoColorizerCreateImageResponseMessage2), TypeInfoPropertyName = "PhotoColorizerCreateImageResponseMessage22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.PhotoColorizerCreateImageResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioProjectsGetDetailsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioProjectsGetDetailsResponseStatus), TypeInfoPropertyName = "AudioProjectsGetDetailsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::MagicHour.AudioProjectsGetDetailsResponseDownload>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioProjectsGetDetailsResponseDownload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioProjectsGetDetailsResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioProjectsGetDetailsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioProjectsGetDetailsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioProjectsGetDetailsResponseMessage), TypeInfoPropertyName = "AudioProjectsGetDetailsResponseMessage2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioProjectsGetDetailsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioProjectsGetDetailsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioProjectsGetDetailsResponseMessage2), TypeInfoPropertyName = "AudioProjectsGetDetailsResponseMessage22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioProjectsDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioProjectsDeleteResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioProjectsDeleteResponseMessage), TypeInfoPropertyName = "AudioProjectsDeleteResponseMessage2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioProjectsDeleteResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioProjectsDeleteResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AudioProjectsDeleteResponseMessage2), TypeInfoPropertyName = "AudioProjectsDeleteResponseMessage22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVoiceGeneratorCreateAudioResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVoiceGeneratorCreateAudioResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVoiceGeneratorCreateAudioResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVoiceGeneratorCreateAudioResponseMessage), TypeInfoPropertyName = "AiVoiceGeneratorCreateAudioResponseMessage2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVoiceGeneratorCreateAudioResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVoiceGeneratorCreateAudioResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVoiceGeneratorCreateAudioResponseMessage2), TypeInfoPropertyName = "AiVoiceGeneratorCreateAudioResponseMessage22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVoiceGeneratorCreateAudioResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVoiceClonerCreateAudioResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVoiceClonerCreateAudioResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVoiceClonerCreateAudioResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVoiceClonerCreateAudioResponseMessage), TypeInfoPropertyName = "AiVoiceClonerCreateAudioResponseMessage2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVoiceClonerCreateAudioResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVoiceClonerCreateAudioResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVoiceClonerCreateAudioResponseMessage2), TypeInfoPropertyName = "AiVoiceClonerCreateAudioResponseMessage22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVoiceClonerCreateAudioResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::MagicHour.VideoAssetsGeneratePresignedUrlRequestItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::MagicHour.FaceSwapCreateVideoRequestAssetsFaceMapping>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::MagicHour.FaceSwapPhotoCreateImageRequestAssetsFaceMapping>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::MagicHour.VideoAssetsGeneratePresignedUrlResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::MagicHour.FaceDetectionGetDetailsResponseFace>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::MagicHour.VideoProjectsGetDetailsResponseDownload>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::MagicHour.ImageProjectsGetDetailsResponseDownload>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::MagicHour.AudioProjectsGetDetailsResponseDownload>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}