
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AccountGetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AccountGetResponseTier), TypeInfoPropertyName = "AccountGetResponseTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AccountGetResponseSubscription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AccountGetResponseSubscriptionStatus), TypeInfoPropertyName = "AccountGetResponseSubscriptionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AccountGetResponseSubscriptionPrice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AccountGetResponseSubscriptionDiscount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AccountGetResponseSubscriptionBillingInterval), TypeInfoPropertyName = "AccountGetResponseSubscriptionBillingInterval2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AccountGetResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AccountGetResponseCode), TypeInfoPropertyName = "AccountGetResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AccountGetResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AccountGetResponseCode2), TypeInfoPropertyName = "AccountGetResponseCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AccountGetResponseTier?), TypeInfoPropertyName = "NullableAccountGetResponseTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AccountGetResponseSubscriptionStatus?), TypeInfoPropertyName = "NullableAccountGetResponseSubscriptionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AccountGetResponseSubscriptionBillingInterval?), TypeInfoPropertyName = "NullableAccountGetResponseSubscriptionBillingInterval2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AccountGetResponseCode?), TypeInfoPropertyName = "NullableAccountGetResponseCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MagicHour.AccountGetResponseCode2?), TypeInfoPropertyName = "NullableAccountGetResponseCode22")]
    internal sealed partial class AccountSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AccountSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AccountSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AccountSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::MagicHour.AccountGetResponseTier)

                    || typeToConvert == typeof(global::MagicHour.AccountGetResponseTier?)

                    || typeToConvert == typeof(global::MagicHour.AccountGetResponseSubscriptionStatus)

                    || typeToConvert == typeof(global::MagicHour.AccountGetResponseSubscriptionStatus?)

                    || typeToConvert == typeof(global::MagicHour.AccountGetResponseSubscriptionBillingInterval)

                    || typeToConvert == typeof(global::MagicHour.AccountGetResponseSubscriptionBillingInterval?)

                    || typeToConvert == typeof(global::MagicHour.AccountGetResponseCode)

                    || typeToConvert == typeof(global::MagicHour.AccountGetResponseCode?)

                    || typeToConvert == typeof(global::MagicHour.AccountGetResponseCode2)

                    || typeToConvert == typeof(global::MagicHour.AccountGetResponseCode2?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::MagicHour.AccountGetResponseTier))
                {
                    return new global::MagicHour.JsonConverters.AccountGetResponseTierJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AccountGetResponseTier?))
                {
                    return new global::MagicHour.JsonConverters.AccountGetResponseTierNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AccountGetResponseSubscriptionStatus))
                {
                    return new global::MagicHour.JsonConverters.AccountGetResponseSubscriptionStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AccountGetResponseSubscriptionStatus?))
                {
                    return new global::MagicHour.JsonConverters.AccountGetResponseSubscriptionStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AccountGetResponseSubscriptionBillingInterval))
                {
                    return new global::MagicHour.JsonConverters.AccountGetResponseSubscriptionBillingIntervalJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AccountGetResponseSubscriptionBillingInterval?))
                {
                    return new global::MagicHour.JsonConverters.AccountGetResponseSubscriptionBillingIntervalNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AccountGetResponseCode))
                {
                    return new global::MagicHour.JsonConverters.AccountGetResponseCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AccountGetResponseCode?))
                {
                    return new global::MagicHour.JsonConverters.AccountGetResponseCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AccountGetResponseCode2))
                {
                    return new global::MagicHour.JsonConverters.AccountGetResponseCode2JsonConverter();
                }

                if (typeToConvert == typeof(global::MagicHour.AccountGetResponseCode2?))
                {
                    return new global::MagicHour.JsonConverters.AccountGetResponseCode2NullableJsonConverter();
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
                    0 => new AccountSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}