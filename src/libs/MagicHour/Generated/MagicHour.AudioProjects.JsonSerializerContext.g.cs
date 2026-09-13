
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVoiceGeneratorCreateAudioRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVoiceGeneratorCreateAudioRequestStyle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVoiceGeneratorCreateAudioRequestStyleVoiceName), TypeInfoPropertyName = "AiVoiceGeneratorCreateAudioRequestStyleVoiceName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVoiceClonerCreateAudioRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVoiceClonerCreateAudioRequestAssets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVoiceClonerCreateAudioRequestStyle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AiVoiceGeneratorCreateAudioRequestStyleVoiceName?), TypeInfoPropertyName = "NullableAiVoiceGeneratorCreateAudioRequestStyleVoiceName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::MagicHour.AudioProjectsGetDetailsResponseDownload>))]
    internal sealed partial class AudioProjectsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AudioProjectsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AudioProjectsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AudioProjectsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::MagicHour.AiVoiceGeneratorCreateAudioRequestStyleVoiceName)

                    || typeToConvert == typeof(global::MagicHour.AiVoiceGeneratorCreateAudioRequestStyleVoiceName?)

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
                if (typeToConvert == typeof(global::MagicHour.AiVoiceGeneratorCreateAudioRequestStyleVoiceName))
                {
                    return new global::MagicHour.JsonConverters.AiVoiceGeneratorCreateAudioRequestStyleVoiceNameJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AiVoiceGeneratorCreateAudioRequestStyleVoiceName?))
                {
                    return new global::MagicHour.JsonConverters.AiVoiceGeneratorCreateAudioRequestStyleVoiceNameNullableJsonConverter();
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
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

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
                    0 => new AudioProjectsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}