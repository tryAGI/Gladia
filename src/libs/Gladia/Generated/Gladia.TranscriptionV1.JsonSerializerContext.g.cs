
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Gladia
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.AudioToTextControllerAudioTranscriptionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.AudioToTextControllerAudioTranscriptionRequestLanguageBehaviour), TypeInfoPropertyName = "AudioToTextControllerAudioTranscriptionRequestLanguageBehaviour2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.AudioToTextControllerAudioTranscriptionRequestLanguage), TypeInfoPropertyName = "AudioToTextControllerAudioTranscriptionRequestLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.AudioToTextControllerAudioTranscriptionRequestTargetTranslationLanguage), TypeInfoPropertyName = "AudioToTextControllerAudioTranscriptionRequestTargetTranslationLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.AudioToTextControllerAudioTranscriptionRequestOutputFormat), TypeInfoPropertyName = "AudioToTextControllerAudioTranscriptionRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.VideoToTextControllerVideoTranscriptionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.VideoToTextControllerVideoTranscriptionRequestLanguageBehaviour), TypeInfoPropertyName = "VideoToTextControllerVideoTranscriptionRequestLanguageBehaviour2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.VideoToTextControllerVideoTranscriptionRequestLanguage), TypeInfoPropertyName = "VideoToTextControllerVideoTranscriptionRequestLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.VideoToTextControllerVideoTranscriptionRequestTargetTranslationLanguage), TypeInfoPropertyName = "VideoToTextControllerVideoTranscriptionRequestTargetTranslationLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.VideoToTextControllerVideoTranscriptionRequestOutputFormat), TypeInfoPropertyName = "VideoToTextControllerVideoTranscriptionRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.AudioToTextControllerAudioTranscriptionRequestLanguageBehaviour?), TypeInfoPropertyName = "NullableAudioToTextControllerAudioTranscriptionRequestLanguageBehaviour2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.AudioToTextControllerAudioTranscriptionRequestLanguage?), TypeInfoPropertyName = "NullableAudioToTextControllerAudioTranscriptionRequestLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.AudioToTextControllerAudioTranscriptionRequestTargetTranslationLanguage?), TypeInfoPropertyName = "NullableAudioToTextControllerAudioTranscriptionRequestTargetTranslationLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.AudioToTextControllerAudioTranscriptionRequestOutputFormat?), TypeInfoPropertyName = "NullableAudioToTextControllerAudioTranscriptionRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.VideoToTextControllerVideoTranscriptionRequestLanguageBehaviour?), TypeInfoPropertyName = "NullableVideoToTextControllerVideoTranscriptionRequestLanguageBehaviour2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.VideoToTextControllerVideoTranscriptionRequestLanguage?), TypeInfoPropertyName = "NullableVideoToTextControllerVideoTranscriptionRequestLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.VideoToTextControllerVideoTranscriptionRequestTargetTranslationLanguage?), TypeInfoPropertyName = "NullableVideoToTextControllerVideoTranscriptionRequestTargetTranslationLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.VideoToTextControllerVideoTranscriptionRequestOutputFormat?), TypeInfoPropertyName = "NullableVideoToTextControllerVideoTranscriptionRequestOutputFormat2")]
    internal sealed partial class TranscriptionV1SourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TranscriptionV1SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static TranscriptionV1SourceGenerationContext Default { get; } = new(DefaultOptions);

        private TranscriptionV1SourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Gladia.JsonConverters.UnixTimestampJsonConverter());
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
                    typeToConvert == typeof(global::Gladia.AudioToTextControllerAudioTranscriptionRequestLanguageBehaviour)

                    || typeToConvert == typeof(global::Gladia.AudioToTextControllerAudioTranscriptionRequestLanguageBehaviour?)

                    || typeToConvert == typeof(global::Gladia.AudioToTextControllerAudioTranscriptionRequestLanguage)

                    || typeToConvert == typeof(global::Gladia.AudioToTextControllerAudioTranscriptionRequestLanguage?)

                    || typeToConvert == typeof(global::Gladia.AudioToTextControllerAudioTranscriptionRequestTargetTranslationLanguage)

                    || typeToConvert == typeof(global::Gladia.AudioToTextControllerAudioTranscriptionRequestTargetTranslationLanguage?)

                    || typeToConvert == typeof(global::Gladia.AudioToTextControllerAudioTranscriptionRequestOutputFormat)

                    || typeToConvert == typeof(global::Gladia.AudioToTextControllerAudioTranscriptionRequestOutputFormat?)

                    || typeToConvert == typeof(global::Gladia.VideoToTextControllerVideoTranscriptionRequestLanguageBehaviour)

                    || typeToConvert == typeof(global::Gladia.VideoToTextControllerVideoTranscriptionRequestLanguageBehaviour?)

                    || typeToConvert == typeof(global::Gladia.VideoToTextControllerVideoTranscriptionRequestLanguage)

                    || typeToConvert == typeof(global::Gladia.VideoToTextControllerVideoTranscriptionRequestLanguage?)

                    || typeToConvert == typeof(global::Gladia.VideoToTextControllerVideoTranscriptionRequestTargetTranslationLanguage)

                    || typeToConvert == typeof(global::Gladia.VideoToTextControllerVideoTranscriptionRequestTargetTranslationLanguage?)

                    || typeToConvert == typeof(global::Gladia.VideoToTextControllerVideoTranscriptionRequestOutputFormat)

                    || typeToConvert == typeof(global::Gladia.VideoToTextControllerVideoTranscriptionRequestOutputFormat?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Gladia.AudioToTextControllerAudioTranscriptionRequestLanguageBehaviour))
                {
                    return new global::Gladia.JsonConverters.AudioToTextControllerAudioTranscriptionRequestLanguageBehaviourJsonConverter();
                }

                if (typeToConvert == typeof(global::Gladia.AudioToTextControllerAudioTranscriptionRequestLanguageBehaviour?))
                {
                    return new global::Gladia.JsonConverters.AudioToTextControllerAudioTranscriptionRequestLanguageBehaviourNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Gladia.AudioToTextControllerAudioTranscriptionRequestLanguage))
                {
                    return new global::Gladia.JsonConverters.AudioToTextControllerAudioTranscriptionRequestLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Gladia.AudioToTextControllerAudioTranscriptionRequestLanguage?))
                {
                    return new global::Gladia.JsonConverters.AudioToTextControllerAudioTranscriptionRequestLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Gladia.AudioToTextControllerAudioTranscriptionRequestTargetTranslationLanguage))
                {
                    return new global::Gladia.JsonConverters.AudioToTextControllerAudioTranscriptionRequestTargetTranslationLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Gladia.AudioToTextControllerAudioTranscriptionRequestTargetTranslationLanguage?))
                {
                    return new global::Gladia.JsonConverters.AudioToTextControllerAudioTranscriptionRequestTargetTranslationLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Gladia.AudioToTextControllerAudioTranscriptionRequestOutputFormat))
                {
                    return new global::Gladia.JsonConverters.AudioToTextControllerAudioTranscriptionRequestOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Gladia.AudioToTextControllerAudioTranscriptionRequestOutputFormat?))
                {
                    return new global::Gladia.JsonConverters.AudioToTextControllerAudioTranscriptionRequestOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Gladia.VideoToTextControllerVideoTranscriptionRequestLanguageBehaviour))
                {
                    return new global::Gladia.JsonConverters.VideoToTextControllerVideoTranscriptionRequestLanguageBehaviourJsonConverter();
                }

                if (typeToConvert == typeof(global::Gladia.VideoToTextControllerVideoTranscriptionRequestLanguageBehaviour?))
                {
                    return new global::Gladia.JsonConverters.VideoToTextControllerVideoTranscriptionRequestLanguageBehaviourNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Gladia.VideoToTextControllerVideoTranscriptionRequestLanguage))
                {
                    return new global::Gladia.JsonConverters.VideoToTextControllerVideoTranscriptionRequestLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Gladia.VideoToTextControllerVideoTranscriptionRequestLanguage?))
                {
                    return new global::Gladia.JsonConverters.VideoToTextControllerVideoTranscriptionRequestLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Gladia.VideoToTextControllerVideoTranscriptionRequestTargetTranslationLanguage))
                {
                    return new global::Gladia.JsonConverters.VideoToTextControllerVideoTranscriptionRequestTargetTranslationLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Gladia.VideoToTextControllerVideoTranscriptionRequestTargetTranslationLanguage?))
                {
                    return new global::Gladia.JsonConverters.VideoToTextControllerVideoTranscriptionRequestTargetTranslationLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Gladia.VideoToTextControllerVideoTranscriptionRequestOutputFormat))
                {
                    return new global::Gladia.JsonConverters.VideoToTextControllerVideoTranscriptionRequestOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Gladia.VideoToTextControllerVideoTranscriptionRequestOutputFormat?))
                {
                    return new global::Gladia.JsonConverters.VideoToTextControllerVideoTranscriptionRequestOutputFormatNullableJsonConverter();
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
                    0 => new TranscriptionV1SourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}