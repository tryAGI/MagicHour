
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        /// String arrays used by dynamic JSON option values.
        /// </summary>
        public string[]? StringArray { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VideoAssetsGeneratePresignedUrlRequest? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::MagicHour.VideoAssetsGeneratePresignedUrlRequestItem>? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VideoAssetsGeneratePresignedUrlRequestItem? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VideoAssetsGeneratePresignedUrlRequestItemType? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.FaceDetectionDetectFacesRequest? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.FaceDetectionDetectFacesRequestAssets? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiTalkingPhotoCreateTalkingPhotoRequest? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public float? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiTalkingPhotoCreateTalkingPhotoRequestAssets? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiTalkingPhotoCreateTalkingPhotoRequestStyle? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiTalkingPhotoCreateTalkingPhotoRequestStyleGenerationMode? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiTalkingPhotoCreateTalkingPhotoRequestResolution? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiUgcAdCreateVideoRequest? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiUgcAdCreateVideoRequestAssets? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiUgcAdCreateVideoRequestModel? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiUgcAdCreateVideoRequestResolution? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVideoEditorCreateVideoRequest? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVideoEditorCreateVideoRequestModel? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVideoEditorCreateVideoRequestResolution? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVideoEditorCreateVideoRequestStyle? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::MagicHour.AiVideoEditorCreateVideoRequestReference>? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVideoEditorCreateVideoRequestReference? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVideoEditorCreateVideoRequestAssets? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVideoTranslatorCreateVideoRequest? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVideoTranslatorCreateVideoRequestTargetLanguage? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVideoTranslatorCreateVideoRequestResolution? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVideoTranslatorCreateVideoRequestAssets? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVideoUpscalerCreateVideoRequest? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVideoUpscalerCreateVideoRequestResolution? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVideoUpscalerCreateVideoRequestAssets? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AnimationCreateVideoRequest? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AnimationCreateVideoRequestStyle? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AnimationCreateVideoRequestStyleArtStyle? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AnimationCreateVideoRequestStyleCameraEffect? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AnimationCreateVideoRequestStylePromptType? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AnimationCreateVideoRequestAssets? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AnimationCreateVideoRequestAssetsAudioSource? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AudioToVideoCreateVideoRequest? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AudioToVideoCreateVideoRequestResolution? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AudioToVideoCreateVideoRequestAssets? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AudioToVideoCreateVideoRequestStyle? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AutoSubtitleGeneratorCreateVideoRequest? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AutoSubtitleGeneratorCreateVideoRequestAssets? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AutoSubtitleGeneratorCreateVideoRequestStyle? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AutoSubtitleGeneratorCreateVideoRequestStyleTemplate? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AutoSubtitleGeneratorCreateVideoRequestStyleCustomConfig? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.CharacterReplaceCreateVideoRequest? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.CharacterReplaceCreateVideoRequestModel? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.CharacterReplaceCreateVideoRequestResolution? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.CharacterReplaceCreateVideoRequestAssets? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.CharacterReplaceCreateVideoRequestStyle? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.CharacterReplaceCreateVideoRequestStyleMode? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.CharacterReplaceCreateVideoRequestStyleSelectionMode? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::MagicHour.CharacterReplaceCreateVideoRequestStylePoint>? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.CharacterReplaceCreateVideoRequestStylePoint? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.FaceSwapCreateVideoRequest? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.FaceSwapCreateVideoRequestStyle? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.FaceSwapCreateVideoRequestStyleVersion? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.FaceSwapCreateVideoRequestAssets? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.FaceSwapCreateVideoRequestAssetsFaceSwapMode? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::MagicHour.FaceSwapCreateVideoRequestAssetsFaceMapping>? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.FaceSwapCreateVideoRequestAssetsFaceMapping? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.FaceSwapCreateVideoRequestAssetsVideoSource? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.ImageToVideoCreateVideoRequest? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.ImageToVideoCreateVideoRequestModel? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.ImageToVideoCreateVideoRequestResolution? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.ImageToVideoCreateVideoRequestStyle? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.ImageToVideoCreateVideoRequestAssets? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.LipSyncCreateVideoRequest? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.LipSyncCreateVideoRequestAssets? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.LipSyncCreateVideoRequestAssetsVideoSource? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.LipSyncCreateVideoRequestStyle? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.LipSyncCreateVideoRequestStyleGenerationMode? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.TextToVideoCreateVideoRequest? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.TextToVideoCreateVideoRequestAspectRatio? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.TextToVideoCreateVideoRequestResolution? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.TextToVideoCreateVideoRequestModel? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.TextToVideoCreateVideoRequestStyle? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::MagicHour.TextToVideoCreateVideoRequestReference>? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.TextToVideoCreateVideoRequestReference? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VideoToVideoCreateVideoRequest? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VideoToVideoCreateVideoRequestFpsResolution? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VideoToVideoCreateVideoRequestStyle? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VideoToVideoCreateVideoRequestStyleArtStyle? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VideoToVideoCreateVideoRequestStyleVersion? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VideoToVideoCreateVideoRequestStylePromptType? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VideoToVideoCreateVideoRequestStyleModel? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VideoToVideoCreateVideoRequestAssets? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VideoToVideoCreateVideoRequestAssetsVideoSource? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiClothesChangerCreateImageRequest? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiClothesChangerCreateImageRequestAssets? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiClothesChangerCreateImageRequestAssetsGarmentType? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiFaceEditorEditImageRequest? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiFaceEditorEditImageRequestAssets? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiFaceEditorEditImageRequestStyle? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiGifGeneratorCreateImageRequest? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiGifGeneratorCreateImageRequestStyle? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiGifGeneratorCreateImageRequestOutputFormat? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiImageEditorCreateImageRequest? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiImageEditorCreateImageRequestModel? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiImageEditorCreateImageRequestAspectRatio? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiImageEditorCreateImageRequestResolution? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiImageEditorCreateImageRequestStyle? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiImageEditorCreateImageRequestAssets? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiHeadshotGeneratorCreateImageRequest? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiHeadshotGeneratorCreateImageRequestStyle? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiHeadshotGeneratorCreateImageRequestAssets? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiImageGeneratorCreateImageRequest? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiImageGeneratorCreateImageRequestModel? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiImageGeneratorCreateImageRequestAspectRatio? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiImageGeneratorCreateImageRequestResolution? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiImageGeneratorCreateImageRequestStyle? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiImageGeneratorCreateImageRequestStyleTool? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiImageUpscalerCreateImageRequest? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiImageUpscalerCreateImageRequestStyle? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiImageUpscalerCreateImageRequestStyleMode? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiImageUpscalerCreateImageRequestAssets? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiMemeGeneratorCreateImageRequest? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiMemeGeneratorCreateImageRequestStyle? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiMemeGeneratorCreateImageRequestStyleTemplate? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiQrCodeGeneratorCreateImageRequest? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiQrCodeGeneratorCreateImageRequestStyle? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.BodySwapCreateImageRequest? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.BodySwapCreateImageRequestResolution? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.BodySwapCreateImageRequestAssets? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.FaceSwapPhotoCreateImageRequest? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.FaceSwapPhotoCreateImageRequestAssets? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.FaceSwapPhotoCreateImageRequestAssetsFaceSwapMode? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::MagicHour.FaceSwapPhotoCreateImageRequestAssetsFaceMapping>? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.FaceSwapPhotoCreateImageRequestAssetsFaceMapping? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.HeadSwapCreateImageRequest? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.HeadSwapCreateImageRequestAssets? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.ImageBackgroundRemoverCreateImageRequest? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.ImageBackgroundRemoverCreateImageRequestAssets? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.PhotoColorizerCreateImageRequest? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.PhotoColorizerCreateImageRequestAssets? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiMusicGeneratorCreateAudioRequest? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiMusicGeneratorCreateAudioRequestStyle? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVoiceClonerCreateAudioRequest? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVoiceClonerCreateAudioRequestAssets? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVoiceClonerCreateAudioRequestStyle? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVoiceClonerCreateAudioRequestStyleLanguage? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVoiceGeneratorCreateAudioRequest? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVoiceGeneratorCreateAudioRequestStyle? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVoiceGeneratorCreateAudioRequestStyleVoiceName? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVoiceGeneratorCreateAudioRequestStyleLanguage? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.SavedItemsListType? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AccountGetResponse? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AccountGetResponseTier? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AccountGetResponseSubscription? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AccountGetResponseSubscriptionStatus? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AccountGetResponseSubscriptionPrice? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AccountGetResponseSubscriptionDiscount? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AccountGetResponseSubscriptionBillingInterval? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AccountGetResponse2? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AccountGetResponseCode? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AccountGetResponse3? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AccountGetResponseCode2? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.SavedItemsListResponse? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::MagicHour.SavedItemsListResponseItem>? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.SavedItemsListResponseItem? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.SavedItemsListResponseItemType? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::MagicHour.SavedItemsListResponseItemAsset>? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.SavedItemsListResponseItemAsset? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.SavedItemsListResponseItemAssetMediaKind? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.SavedItemsListResponse2? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.SavedItemsListResponseCode? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.SavedItemsListResponse3? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.SavedItemsListResponseCode2? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.SavedItemsListResponse4? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.SavedItemsListResponseCode3? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VoicesListResponse? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::MagicHour.VoicesListResponseVoice>? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VoicesListResponseVoice? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VoicesListResponse2? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VoicesListResponseCode? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VoicesListResponse3? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VoicesListResponseCode2? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VoicesListResponse4? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VoicesListResponseCode3? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VideoAssetsGeneratePresignedUrlResponse? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::MagicHour.VideoAssetsGeneratePresignedUrlResponseItem>? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VideoAssetsGeneratePresignedUrlResponseItem? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VideoAssetsGeneratePresignedUrlResponse2? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VideoAssetsGeneratePresignedUrlResponseCode? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VideoAssetsGeneratePresignedUrlResponse3? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VideoAssetsGeneratePresignedUrlResponseCode2? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VideoAssetsGeneratePresignedUrlResponse4? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VideoAssetsGeneratePresignedUrlResponseCode3? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VideoAssetsGeneratePresignedUrlResponse5? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VideoAssetsGeneratePresignedUrlResponseCode4? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VideoAssetsGeneratePresignedUrlResponse6? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VideoAssetsGeneratePresignedUrlResponseCode5? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VideoAssetsGeneratePresignedUrlResponse7? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VideoAssetsGeneratePresignedUrlResponseCode6? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.FaceDetectionGetDetailsResponse? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.FaceDetectionGetDetailsResponseStatus? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::MagicHour.FaceDetectionGetDetailsResponseFace>? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.FaceDetectionGetDetailsResponseFace? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.FaceDetectionGetDetailsResponseError? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.FaceDetectionGetDetailsResponse2? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.FaceDetectionGetDetailsResponseCode? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.FaceDetectionGetDetailsResponse3? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.FaceDetectionGetDetailsResponseCode2? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.FaceDetectionGetDetailsResponse4? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.FaceDetectionGetDetailsResponseCode3? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.FaceDetectionGetDetailsResponse5? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.FaceDetectionGetDetailsResponseCode4? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.FaceDetectionGetDetailsResponse6? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.FaceDetectionGetDetailsResponseCode5? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.FaceDetectionGetDetailsResponse7? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.FaceDetectionGetDetailsResponseCode6? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.FaceDetectionDetectFacesResponse? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.FaceDetectionDetectFacesResponse2? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.FaceDetectionDetectFacesResponseCode? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.FaceDetectionDetectFacesResponse3? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.FaceDetectionDetectFacesResponseCode2? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.FaceDetectionDetectFacesResponse4? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.FaceDetectionDetectFacesResponseCode3? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.FaceDetectionDetectFacesResponse5? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.FaceDetectionDetectFacesResponseCode4? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.FaceDetectionDetectFacesResponse6? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.FaceDetectionDetectFacesResponseCode5? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.FaceDetectionDetectFacesResponse7? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.FaceDetectionDetectFacesResponseCode6? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VideoProjectsGetDetailsResponse? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VideoProjectsGetDetailsResponseStatus? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VideoProjectsGetDetailsResponseError? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::MagicHour.VideoProjectsGetDetailsResponseDownload>? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VideoProjectsGetDetailsResponseDownload? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VideoProjectsGetDetailsResponse2? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VideoProjectsGetDetailsResponseCode? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VideoProjectsGetDetailsResponse3? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VideoProjectsGetDetailsResponseCode2? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VideoProjectsGetDetailsResponse4? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VideoProjectsGetDetailsResponseCode3? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VideoProjectsGetDetailsResponse5? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VideoProjectsGetDetailsResponseCode4? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VideoProjectsGetDetailsResponse6? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VideoProjectsGetDetailsResponseCode5? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VideoProjectsDeleteResponse? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VideoProjectsDeleteResponseCode? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VideoProjectsDeleteResponse2? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VideoProjectsDeleteResponseCode2? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VideoProjectsDeleteResponse3? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VideoProjectsDeleteResponseCode3? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VideoProjectsDeleteResponse4? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VideoProjectsDeleteResponseCode4? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VideoProjectsDeleteResponse5? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VideoProjectsDeleteResponseCode5? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VideoProjectsDeleteResponse6? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VideoProjectsDeleteResponseCode6? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponse? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponse2? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponseCode? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponse3? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponseCode2? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponse4? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponseCode3? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponse5? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponseCode4? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponse6? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponseCode5? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponse7? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponseCode6? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiUgcAdCreateVideoResponse? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiUgcAdCreateVideoResponse2? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiUgcAdCreateVideoResponseCode? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiUgcAdCreateVideoResponse3? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiUgcAdCreateVideoResponseCode2? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiUgcAdCreateVideoResponse4? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiUgcAdCreateVideoResponseCode3? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiUgcAdCreateVideoResponse5? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiUgcAdCreateVideoResponseCode4? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiUgcAdCreateVideoResponse6? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiUgcAdCreateVideoResponseCode5? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiUgcAdCreateVideoResponse7? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiUgcAdCreateVideoResponseCode6? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVideoEditorCreateVideoResponse? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVideoEditorCreateVideoResponse2? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVideoEditorCreateVideoResponseCode? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVideoEditorCreateVideoResponse3? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVideoEditorCreateVideoResponseCode2? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVideoEditorCreateVideoResponse4? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVideoEditorCreateVideoResponseCode3? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVideoEditorCreateVideoResponse5? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVideoEditorCreateVideoResponseCode4? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVideoEditorCreateVideoResponse6? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVideoEditorCreateVideoResponseCode5? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVideoEditorCreateVideoResponse7? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVideoEditorCreateVideoResponseCode6? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVideoTranslatorCreateVideoResponse? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVideoTranslatorCreateVideoResponse2? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVideoTranslatorCreateVideoResponseCode? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVideoTranslatorCreateVideoResponse3? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVideoTranslatorCreateVideoResponseCode2? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVideoTranslatorCreateVideoResponse4? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVideoTranslatorCreateVideoResponseCode3? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVideoTranslatorCreateVideoResponse5? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVideoTranslatorCreateVideoResponseCode4? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVideoTranslatorCreateVideoResponse6? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVideoTranslatorCreateVideoResponseCode5? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVideoTranslatorCreateVideoResponse7? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVideoTranslatorCreateVideoResponseCode6? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVideoUpscalerCreateVideoResponse? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVideoUpscalerCreateVideoResponse2? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVideoUpscalerCreateVideoResponseCode? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVideoUpscalerCreateVideoResponse3? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVideoUpscalerCreateVideoResponseCode2? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVideoUpscalerCreateVideoResponse4? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVideoUpscalerCreateVideoResponseCode3? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVideoUpscalerCreateVideoResponse5? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVideoUpscalerCreateVideoResponseCode4? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVideoUpscalerCreateVideoResponse6? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVideoUpscalerCreateVideoResponseCode5? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVideoUpscalerCreateVideoResponse7? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVideoUpscalerCreateVideoResponseCode6? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AnimationCreateVideoResponse? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AnimationCreateVideoResponse2? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AnimationCreateVideoResponseCode? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AnimationCreateVideoResponse3? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AnimationCreateVideoResponseCode2? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AnimationCreateVideoResponse4? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AnimationCreateVideoResponseCode3? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AnimationCreateVideoResponse5? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AnimationCreateVideoResponseCode4? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AnimationCreateVideoResponse6? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AnimationCreateVideoResponseCode5? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AnimationCreateVideoResponse7? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AnimationCreateVideoResponseCode6? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AudioToVideoCreateVideoResponse? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AudioToVideoCreateVideoResponse2? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AudioToVideoCreateVideoResponseCode? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AudioToVideoCreateVideoResponse3? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AudioToVideoCreateVideoResponseCode2? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AudioToVideoCreateVideoResponse4? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AudioToVideoCreateVideoResponseCode3? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AudioToVideoCreateVideoResponse5? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AudioToVideoCreateVideoResponseCode4? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AudioToVideoCreateVideoResponse6? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AudioToVideoCreateVideoResponseCode5? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AudioToVideoCreateVideoResponse7? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AudioToVideoCreateVideoResponseCode6? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AutoSubtitleGeneratorCreateVideoResponse? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AutoSubtitleGeneratorCreateVideoResponse2? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AutoSubtitleGeneratorCreateVideoResponseCode? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AutoSubtitleGeneratorCreateVideoResponse3? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AutoSubtitleGeneratorCreateVideoResponseCode2? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AutoSubtitleGeneratorCreateVideoResponse4? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AutoSubtitleGeneratorCreateVideoResponseCode3? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AutoSubtitleGeneratorCreateVideoResponse5? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AutoSubtitleGeneratorCreateVideoResponseCode4? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AutoSubtitleGeneratorCreateVideoResponse6? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AutoSubtitleGeneratorCreateVideoResponseCode5? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AutoSubtitleGeneratorCreateVideoResponse7? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AutoSubtitleGeneratorCreateVideoResponseCode6? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.CharacterReplaceCreateVideoResponse? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.CharacterReplaceCreateVideoResponse2? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.CharacterReplaceCreateVideoResponseCode? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.CharacterReplaceCreateVideoResponse3? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.CharacterReplaceCreateVideoResponseCode2? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.CharacterReplaceCreateVideoResponse4? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.CharacterReplaceCreateVideoResponseCode3? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.CharacterReplaceCreateVideoResponse5? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.CharacterReplaceCreateVideoResponseCode4? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.CharacterReplaceCreateVideoResponse6? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.CharacterReplaceCreateVideoResponseCode5? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.CharacterReplaceCreateVideoResponse7? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.CharacterReplaceCreateVideoResponseCode6? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.FaceSwapCreateVideoResponse? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.FaceSwapCreateVideoResponse2? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.FaceSwapCreateVideoResponseCode? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.FaceSwapCreateVideoResponse3? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.FaceSwapCreateVideoResponseCode2? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.FaceSwapCreateVideoResponse4? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.FaceSwapCreateVideoResponseCode3? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.FaceSwapCreateVideoResponse5? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.FaceSwapCreateVideoResponseCode4? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.FaceSwapCreateVideoResponse6? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.FaceSwapCreateVideoResponseCode5? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.FaceSwapCreateVideoResponse7? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.FaceSwapCreateVideoResponseCode6? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.ImageToVideoCreateVideoResponse? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.ImageToVideoCreateVideoResponse2? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.ImageToVideoCreateVideoResponseCode? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.ImageToVideoCreateVideoResponse3? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.ImageToVideoCreateVideoResponseCode2? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.ImageToVideoCreateVideoResponse4? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.ImageToVideoCreateVideoResponseCode3? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.ImageToVideoCreateVideoResponse5? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.ImageToVideoCreateVideoResponseCode4? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.ImageToVideoCreateVideoResponse6? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.ImageToVideoCreateVideoResponseCode5? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.ImageToVideoCreateVideoResponse7? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.ImageToVideoCreateVideoResponseCode6? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.LipSyncCreateVideoResponse? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.LipSyncCreateVideoResponse2? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.LipSyncCreateVideoResponseCode? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.LipSyncCreateVideoResponse3? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.LipSyncCreateVideoResponseCode2? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.LipSyncCreateVideoResponse4? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.LipSyncCreateVideoResponseCode3? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.LipSyncCreateVideoResponse5? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.LipSyncCreateVideoResponseCode4? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.LipSyncCreateVideoResponse6? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.LipSyncCreateVideoResponseCode5? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.LipSyncCreateVideoResponse7? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.LipSyncCreateVideoResponseCode6? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.TextToVideoCreateVideoResponse? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.TextToVideoCreateVideoResponse2? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.TextToVideoCreateVideoResponseCode? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.TextToVideoCreateVideoResponse3? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.TextToVideoCreateVideoResponseCode2? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.TextToVideoCreateVideoResponse4? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.TextToVideoCreateVideoResponseCode3? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.TextToVideoCreateVideoResponse5? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.TextToVideoCreateVideoResponseCode4? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.TextToVideoCreateVideoResponse6? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.TextToVideoCreateVideoResponseCode5? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.TextToVideoCreateVideoResponse7? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.TextToVideoCreateVideoResponseCode6? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VideoToVideoCreateVideoResponse? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VideoToVideoCreateVideoResponse2? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VideoToVideoCreateVideoResponseCode? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VideoToVideoCreateVideoResponse3? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VideoToVideoCreateVideoResponseCode2? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VideoToVideoCreateVideoResponse4? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VideoToVideoCreateVideoResponseCode3? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VideoToVideoCreateVideoResponse5? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VideoToVideoCreateVideoResponseCode4? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VideoToVideoCreateVideoResponse6? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VideoToVideoCreateVideoResponseCode5? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VideoToVideoCreateVideoResponse7? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.VideoToVideoCreateVideoResponseCode6? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.ImageProjectsGetDetailsResponse? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.ImageProjectsGetDetailsResponseStatus? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::MagicHour.ImageProjectsGetDetailsResponseDownload>? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.ImageProjectsGetDetailsResponseDownload? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.ImageProjectsGetDetailsResponseError? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.ImageProjectsGetDetailsResponse2? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.ImageProjectsGetDetailsResponseCode? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.ImageProjectsGetDetailsResponse3? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.ImageProjectsGetDetailsResponseCode2? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.ImageProjectsGetDetailsResponse4? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.ImageProjectsGetDetailsResponseCode3? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.ImageProjectsGetDetailsResponse5? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.ImageProjectsGetDetailsResponseCode4? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.ImageProjectsGetDetailsResponse6? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.ImageProjectsGetDetailsResponseCode5? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.ImageProjectsDeleteResponse? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.ImageProjectsDeleteResponseCode? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.ImageProjectsDeleteResponse2? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.ImageProjectsDeleteResponseCode2? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.ImageProjectsDeleteResponse3? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.ImageProjectsDeleteResponseCode3? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.ImageProjectsDeleteResponse4? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.ImageProjectsDeleteResponseCode4? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.ImageProjectsDeleteResponse5? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.ImageProjectsDeleteResponseCode5? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiClothesChangerCreateImageResponse? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiClothesChangerCreateImageResponse2? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiClothesChangerCreateImageResponseCode? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiClothesChangerCreateImageResponse3? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiClothesChangerCreateImageResponseCode2? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiClothesChangerCreateImageResponse4? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiClothesChangerCreateImageResponseCode3? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiClothesChangerCreateImageResponse5? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiClothesChangerCreateImageResponseCode4? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiClothesChangerCreateImageResponse6? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiClothesChangerCreateImageResponseCode5? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiClothesChangerCreateImageResponse7? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiClothesChangerCreateImageResponseCode6? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiFaceEditorEditImageResponse? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiFaceEditorEditImageResponse2? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiFaceEditorEditImageResponseCode? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiFaceEditorEditImageResponse3? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiFaceEditorEditImageResponseCode2? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiFaceEditorEditImageResponse4? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiFaceEditorEditImageResponseCode3? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiFaceEditorEditImageResponse5? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiFaceEditorEditImageResponseCode4? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiFaceEditorEditImageResponse6? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiFaceEditorEditImageResponseCode5? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiFaceEditorEditImageResponse7? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiFaceEditorEditImageResponseCode6? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiGifGeneratorCreateImageResponse? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiGifGeneratorCreateImageResponse2? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiGifGeneratorCreateImageResponseCode? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiGifGeneratorCreateImageResponse3? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiGifGeneratorCreateImageResponseCode2? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiGifGeneratorCreateImageResponse4? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiGifGeneratorCreateImageResponseCode3? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiGifGeneratorCreateImageResponse5? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiGifGeneratorCreateImageResponseCode4? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiGifGeneratorCreateImageResponse6? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiGifGeneratorCreateImageResponseCode5? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiGifGeneratorCreateImageResponse7? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiGifGeneratorCreateImageResponseCode6? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiImageEditorCreateImageResponse? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiImageEditorCreateImageResponse2? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiImageEditorCreateImageResponseCode? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiImageEditorCreateImageResponse3? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiImageEditorCreateImageResponseCode2? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiImageEditorCreateImageResponse4? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiImageEditorCreateImageResponseCode3? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiImageEditorCreateImageResponse5? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiImageEditorCreateImageResponseCode4? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiImageEditorCreateImageResponse6? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiImageEditorCreateImageResponseCode5? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiImageEditorCreateImageResponse7? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiImageEditorCreateImageResponseCode6? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiHeadshotGeneratorCreateImageResponse? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiHeadshotGeneratorCreateImageResponse2? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiHeadshotGeneratorCreateImageResponseCode? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiHeadshotGeneratorCreateImageResponse3? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiHeadshotGeneratorCreateImageResponseCode2? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiHeadshotGeneratorCreateImageResponse4? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiHeadshotGeneratorCreateImageResponseCode3? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiHeadshotGeneratorCreateImageResponse5? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiHeadshotGeneratorCreateImageResponseCode4? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiHeadshotGeneratorCreateImageResponse6? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiHeadshotGeneratorCreateImageResponseCode5? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiHeadshotGeneratorCreateImageResponse7? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiHeadshotGeneratorCreateImageResponseCode6? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiImageGeneratorCreateImageResponse? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiImageGeneratorCreateImageResponse2? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiImageGeneratorCreateImageResponseCode? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiImageGeneratorCreateImageResponse3? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiImageGeneratorCreateImageResponseCode2? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiImageGeneratorCreateImageResponse4? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiImageGeneratorCreateImageResponseCode3? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiImageGeneratorCreateImageResponse5? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiImageGeneratorCreateImageResponseCode4? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiImageGeneratorCreateImageResponse6? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiImageGeneratorCreateImageResponseCode5? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiImageGeneratorCreateImageResponse7? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiImageGeneratorCreateImageResponseCode6? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiImageUpscalerCreateImageResponse? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiImageUpscalerCreateImageResponse2? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiImageUpscalerCreateImageResponseCode? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiImageUpscalerCreateImageResponse3? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiImageUpscalerCreateImageResponseCode2? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiImageUpscalerCreateImageResponse4? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiImageUpscalerCreateImageResponseCode3? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiImageUpscalerCreateImageResponse5? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiImageUpscalerCreateImageResponseCode4? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiImageUpscalerCreateImageResponse6? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiImageUpscalerCreateImageResponseCode5? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiImageUpscalerCreateImageResponse7? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiImageUpscalerCreateImageResponseCode6? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiMemeGeneratorCreateImageResponse? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiMemeGeneratorCreateImageResponse2? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiMemeGeneratorCreateImageResponseCode? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiMemeGeneratorCreateImageResponse3? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiMemeGeneratorCreateImageResponseCode2? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiMemeGeneratorCreateImageResponse4? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiMemeGeneratorCreateImageResponseCode3? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiMemeGeneratorCreateImageResponse5? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiMemeGeneratorCreateImageResponseCode4? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiMemeGeneratorCreateImageResponse6? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiMemeGeneratorCreateImageResponseCode5? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiMemeGeneratorCreateImageResponse7? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiMemeGeneratorCreateImageResponseCode6? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiQrCodeGeneratorCreateImageResponse? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiQrCodeGeneratorCreateImageResponse2? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiQrCodeGeneratorCreateImageResponseCode? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiQrCodeGeneratorCreateImageResponse3? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiQrCodeGeneratorCreateImageResponseCode2? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiQrCodeGeneratorCreateImageResponse4? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiQrCodeGeneratorCreateImageResponseCode3? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiQrCodeGeneratorCreateImageResponse5? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiQrCodeGeneratorCreateImageResponseCode4? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiQrCodeGeneratorCreateImageResponse6? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiQrCodeGeneratorCreateImageResponseCode5? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiQrCodeGeneratorCreateImageResponse7? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiQrCodeGeneratorCreateImageResponseCode6? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.BodySwapCreateImageResponse? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.BodySwapCreateImageResponse2? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.BodySwapCreateImageResponseCode? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.BodySwapCreateImageResponse3? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.BodySwapCreateImageResponseCode2? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.BodySwapCreateImageResponse4? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.BodySwapCreateImageResponseCode3? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.BodySwapCreateImageResponse5? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.BodySwapCreateImageResponseCode4? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.BodySwapCreateImageResponse6? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.BodySwapCreateImageResponseCode5? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.BodySwapCreateImageResponse7? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.BodySwapCreateImageResponseCode6? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.FaceSwapPhotoCreateImageResponse? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.FaceSwapPhotoCreateImageResponse2? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.FaceSwapPhotoCreateImageResponseCode? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.FaceSwapPhotoCreateImageResponse3? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.FaceSwapPhotoCreateImageResponseCode2? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.FaceSwapPhotoCreateImageResponse4? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.FaceSwapPhotoCreateImageResponseCode3? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.FaceSwapPhotoCreateImageResponse5? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.FaceSwapPhotoCreateImageResponseCode4? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.FaceSwapPhotoCreateImageResponse6? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.FaceSwapPhotoCreateImageResponseCode5? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.FaceSwapPhotoCreateImageResponse7? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.FaceSwapPhotoCreateImageResponseCode6? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.HeadSwapCreateImageResponse? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.HeadSwapCreateImageResponse2? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.HeadSwapCreateImageResponseCode? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.HeadSwapCreateImageResponse3? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.HeadSwapCreateImageResponseCode2? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.HeadSwapCreateImageResponse4? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.HeadSwapCreateImageResponseCode3? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.HeadSwapCreateImageResponse5? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.HeadSwapCreateImageResponseCode4? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.HeadSwapCreateImageResponse6? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.HeadSwapCreateImageResponseCode5? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.HeadSwapCreateImageResponse7? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.HeadSwapCreateImageResponseCode6? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.ImageBackgroundRemoverCreateImageResponse? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.ImageBackgroundRemoverCreateImageResponse2? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.ImageBackgroundRemoverCreateImageResponseCode? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.ImageBackgroundRemoverCreateImageResponse3? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.ImageBackgroundRemoverCreateImageResponseCode2? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.ImageBackgroundRemoverCreateImageResponse4? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.ImageBackgroundRemoverCreateImageResponseCode3? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.ImageBackgroundRemoverCreateImageResponse5? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.ImageBackgroundRemoverCreateImageResponseCode4? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.ImageBackgroundRemoverCreateImageResponse6? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.ImageBackgroundRemoverCreateImageResponseCode5? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.ImageBackgroundRemoverCreateImageResponse7? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.ImageBackgroundRemoverCreateImageResponseCode6? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.PhotoColorizerCreateImageResponse? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.PhotoColorizerCreateImageResponse2? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.PhotoColorizerCreateImageResponseCode? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.PhotoColorizerCreateImageResponse3? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.PhotoColorizerCreateImageResponseCode2? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.PhotoColorizerCreateImageResponse4? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.PhotoColorizerCreateImageResponseCode3? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.PhotoColorizerCreateImageResponse5? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.PhotoColorizerCreateImageResponseCode4? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.PhotoColorizerCreateImageResponse6? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.PhotoColorizerCreateImageResponseCode5? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.PhotoColorizerCreateImageResponse7? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.PhotoColorizerCreateImageResponseCode6? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AudioProjectsGetDetailsResponse? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AudioProjectsGetDetailsResponseStatus? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::MagicHour.AudioProjectsGetDetailsResponseDownload>? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AudioProjectsGetDetailsResponseDownload? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AudioProjectsGetDetailsResponseError? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AudioProjectsGetDetailsResponse2? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AudioProjectsGetDetailsResponseCode? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AudioProjectsGetDetailsResponse3? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AudioProjectsGetDetailsResponseCode2? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AudioProjectsGetDetailsResponse4? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AudioProjectsGetDetailsResponseCode3? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AudioProjectsGetDetailsResponse5? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AudioProjectsGetDetailsResponseCode4? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AudioProjectsGetDetailsResponse6? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AudioProjectsGetDetailsResponseCode5? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AudioProjectsDeleteResponse? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AudioProjectsDeleteResponseCode? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AudioProjectsDeleteResponse2? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AudioProjectsDeleteResponseCode2? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AudioProjectsDeleteResponse3? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AudioProjectsDeleteResponseCode3? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AudioProjectsDeleteResponse4? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AudioProjectsDeleteResponseCode4? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AudioProjectsDeleteResponse5? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AudioProjectsDeleteResponseCode5? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiMusicGeneratorCreateAudioResponse? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiMusicGeneratorCreateAudioResponse2? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiMusicGeneratorCreateAudioResponseCode? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiMusicGeneratorCreateAudioResponse3? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiMusicGeneratorCreateAudioResponseCode2? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiMusicGeneratorCreateAudioResponse4? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiMusicGeneratorCreateAudioResponseCode3? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiMusicGeneratorCreateAudioResponse5? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiMusicGeneratorCreateAudioResponseCode4? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiMusicGeneratorCreateAudioResponse6? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiMusicGeneratorCreateAudioResponseCode5? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiMusicGeneratorCreateAudioResponse7? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiMusicGeneratorCreateAudioResponseCode6? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVoiceClonerCreateAudioResponse? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVoiceClonerCreateAudioResponse2? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVoiceClonerCreateAudioResponseCode? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVoiceClonerCreateAudioResponse3? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVoiceClonerCreateAudioResponseCode2? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVoiceClonerCreateAudioResponse4? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVoiceClonerCreateAudioResponseCode3? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVoiceClonerCreateAudioResponse5? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVoiceClonerCreateAudioResponseCode4? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVoiceClonerCreateAudioResponse6? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVoiceClonerCreateAudioResponseCode5? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVoiceClonerCreateAudioResponse7? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVoiceClonerCreateAudioResponseCode6? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVoiceGeneratorCreateAudioResponse? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVoiceGeneratorCreateAudioResponse2? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVoiceGeneratorCreateAudioResponseCode? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVoiceGeneratorCreateAudioResponse3? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVoiceGeneratorCreateAudioResponseCode2? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVoiceGeneratorCreateAudioResponse4? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVoiceGeneratorCreateAudioResponseCode3? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVoiceGeneratorCreateAudioResponse5? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVoiceGeneratorCreateAudioResponseCode4? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVoiceGeneratorCreateAudioResponse6? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVoiceGeneratorCreateAudioResponseCode5? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVoiceGeneratorCreateAudioResponse7? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MagicHour.AiVoiceGeneratorCreateAudioResponseCode6? Type710 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::MagicHour.VideoAssetsGeneratePresignedUrlRequestItem>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::MagicHour.AiVideoEditorCreateVideoRequestReference>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::MagicHour.CharacterReplaceCreateVideoRequestStylePoint>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::MagicHour.FaceSwapCreateVideoRequestAssetsFaceMapping>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::MagicHour.TextToVideoCreateVideoRequestReference>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::MagicHour.FaceSwapPhotoCreateImageRequestAssetsFaceMapping>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::MagicHour.SavedItemsListResponseItem>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::MagicHour.SavedItemsListResponseItemAsset>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::MagicHour.VoicesListResponseVoice>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::MagicHour.VideoAssetsGeneratePresignedUrlResponseItem>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::MagicHour.FaceDetectionGetDetailsResponseFace>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::MagicHour.VideoProjectsGetDetailsResponseDownload>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::MagicHour.ImageProjectsGetDetailsResponseDownload>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::MagicHour.AudioProjectsGetDetailsResponseDownload>? ListType14 { get; set; }
    }
}