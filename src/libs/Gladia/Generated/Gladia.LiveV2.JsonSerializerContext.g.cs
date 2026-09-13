
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.ListStreamingResponse), TypeInfoPropertyName = "ListStreamingResponse_Gladia_ListStreamingResponse")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Gladia.StreamingResponse>), TypeInfoPropertyName = "ListStreamingResponse_System_Collections_Generic_List_global_Gladia_StreamingResponse")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.TranscriptionLanguageCodeEnum), TypeInfoPropertyName = "TranscriptionLanguageCodeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.CustomVocabularyEntryDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.CustomVocabularyConfigDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Gladia.OneOf<global::Gladia.CustomVocabularyEntryDTO, string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.OneOf<global::Gladia.CustomVocabularyEntryDTO, string>), TypeInfoPropertyName = "OneOfCustomVocabularyEntryDTOString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.SubtitlesFormatEnum), TypeInfoPropertyName = "SubtitlesFormatEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.TranslationLanguageCodeEnum), TypeInfoPropertyName = "TranslationLanguageCodeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.TranslationModelEnum), TypeInfoPropertyName = "TranslationModelEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.TranslationConfigDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Gladia.TranslationLanguageCodeEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.SummaryTypesEnum), TypeInfoPropertyName = "SummaryTypesEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.SummarizationConfigDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.CustomSpellingConfigDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.LanguageConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Gladia.TranscriptionLanguageCodeEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.BadRequestErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.UnauthorizedErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.UnprocessableEntityErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.FileResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.TranscriptionMetadataDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.AddonErrorDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.SentencesDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.SubtitleDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.WordDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.UtteranceDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Gladia.WordDTO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.TranscriptionDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Gladia.SentencesDTO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Gladia.SubtitleDTO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Gladia.UtteranceDTO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.TranslationResultDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.TranslationDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Gladia.TranslationResultDTO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.SummarizationDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.NamedEntityRecognitionResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.NamedEntityRecognitionDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Gladia.NamedEntityRecognitionResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.SentimentAnalysisDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.PreRecordedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.NotFoundErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.ForbiddenErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.StreamingSupportedEncodingEnum), TypeInfoPropertyName = "StreamingSupportedEncodingEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.StreamingSupportedModels), TypeInfoPropertyName = "StreamingSupportedModels2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.PreProcessingConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.RealtimeProcessingConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.PostProcessingConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.MessagesConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.CallbackConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.StreamingRequestParamsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.StreamingTranscriptionResultWithMessagesDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.StreamingResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.StreamingResponseStatus), TypeInfoPropertyName = "StreamingResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.StreamingResponseKind), TypeInfoPropertyName = "StreamingResponseKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Gladia.OneOf<global::Gladia.PreRecordedResponse, global::Gladia.StreamingResponse>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.StreamingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.StreamingSupportedRegions), TypeInfoPropertyName = "StreamingSupportedRegions2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.InitStreamingResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Gladia.StreamingResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.PatchRequestParamsDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.PayloadTooLargeErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Gladia.StreamingControllerGetStreamingJobsV2Statu>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.StreamingControllerGetStreamingJobsV2Statu), TypeInfoPropertyName = "StreamingControllerGetStreamingJobsV2Statu2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.TranscriptionControllerGetTranscriptV2Response), TypeInfoPropertyName = "TranscriptionControllerGetTranscriptV2Response2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.TranscriptionLanguageCodeEnum?), TypeInfoPropertyName = "NullableTranscriptionLanguageCodeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.OneOf<global::Gladia.CustomVocabularyEntryDTO, string>?), TypeInfoPropertyName = "NullableOneOfCustomVocabularyEntryDTOString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.SubtitlesFormatEnum?), TypeInfoPropertyName = "NullableSubtitlesFormatEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.TranslationLanguageCodeEnum?), TypeInfoPropertyName = "NullableTranslationLanguageCodeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.TranslationModelEnum?), TypeInfoPropertyName = "NullableTranslationModelEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.SummaryTypesEnum?), TypeInfoPropertyName = "NullableSummaryTypesEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.StreamingSupportedEncodingEnum?), TypeInfoPropertyName = "NullableStreamingSupportedEncodingEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.StreamingSupportedModels?), TypeInfoPropertyName = "NullableStreamingSupportedModels2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.StreamingResponseStatus?), TypeInfoPropertyName = "NullableStreamingResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.StreamingResponseKind?), TypeInfoPropertyName = "NullableStreamingResponseKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.StreamingSupportedRegions?), TypeInfoPropertyName = "NullableStreamingSupportedRegions2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.StreamingControllerGetStreamingJobsV2Statu?), TypeInfoPropertyName = "NullableStreamingControllerGetStreamingJobsV2Statu2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.TranscriptionControllerGetTranscriptV2Response?), TypeInfoPropertyName = "NullableTranscriptionControllerGetTranscriptV2Response2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Gladia.OneOf<global::Gladia.CustomVocabularyEntryDTO, string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Gladia.TranslationLanguageCodeEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Gladia.TranscriptionLanguageCodeEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Gladia.WordDTO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Gladia.SentencesDTO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Gladia.SubtitleDTO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Gladia.UtteranceDTO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Gladia.TranslationResultDTO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Gladia.NamedEntityRecognitionResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Gladia.OneOf<global::Gladia.PreRecordedResponse, global::Gladia.StreamingResponse>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Gladia.StreamingControllerGetStreamingJobsV2Statu>))]
    internal sealed partial class LiveV2SourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LiveV2SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static LiveV2SourceGenerationContext Default { get; } = new(DefaultOptions);

        private LiveV2SourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Gladia.JsonConverters.TranscriptionControllerGetTranscriptV2ResponseJsonConverter());
            options.Converters.Add(new global::Gladia.JsonConverters.OneOfJsonConverter<global::Gladia.CustomVocabularyEntryDTO, string>());
            options.Converters.Add(new global::Gladia.JsonConverters.OneOfJsonConverter<global::Gladia.PreRecordedResponse, global::Gladia.StreamingResponse>());
            options.Converters.Add(new global::Gladia.JsonConverters.OneOfJsonConverter<global::Gladia.PreRecordedResponse, global::Gladia.StreamingResponse>());
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
                    typeToConvert == typeof(global::Gladia.TranscriptionLanguageCodeEnum)

                    || typeToConvert == typeof(global::Gladia.TranscriptionLanguageCodeEnum?)

                    || typeToConvert == typeof(global::Gladia.SubtitlesFormatEnum)

                    || typeToConvert == typeof(global::Gladia.SubtitlesFormatEnum?)

                    || typeToConvert == typeof(global::Gladia.TranslationLanguageCodeEnum)

                    || typeToConvert == typeof(global::Gladia.TranslationLanguageCodeEnum?)

                    || typeToConvert == typeof(global::Gladia.TranslationModelEnum)

                    || typeToConvert == typeof(global::Gladia.TranslationModelEnum?)

                    || typeToConvert == typeof(global::Gladia.SummaryTypesEnum)

                    || typeToConvert == typeof(global::Gladia.SummaryTypesEnum?)

                    || typeToConvert == typeof(global::Gladia.StreamingSupportedEncodingEnum)

                    || typeToConvert == typeof(global::Gladia.StreamingSupportedEncodingEnum?)

                    || typeToConvert == typeof(global::Gladia.StreamingSupportedModels)

                    || typeToConvert == typeof(global::Gladia.StreamingSupportedModels?)

                    || typeToConvert == typeof(global::Gladia.StreamingResponseStatus)

                    || typeToConvert == typeof(global::Gladia.StreamingResponseStatus?)

                    || typeToConvert == typeof(global::Gladia.StreamingResponseKind)

                    || typeToConvert == typeof(global::Gladia.StreamingResponseKind?)

                    || typeToConvert == typeof(global::Gladia.StreamingSupportedRegions)

                    || typeToConvert == typeof(global::Gladia.StreamingSupportedRegions?)

                    || typeToConvert == typeof(global::Gladia.StreamingControllerGetStreamingJobsV2Statu)

                    || typeToConvert == typeof(global::Gladia.StreamingControllerGetStreamingJobsV2Statu?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Gladia.TranscriptionLanguageCodeEnum))
                {
                    return new global::Gladia.JsonConverters.TranscriptionLanguageCodeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Gladia.TranscriptionLanguageCodeEnum?))
                {
                    return new global::Gladia.JsonConverters.TranscriptionLanguageCodeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Gladia.SubtitlesFormatEnum))
                {
                    return new global::Gladia.JsonConverters.SubtitlesFormatEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Gladia.SubtitlesFormatEnum?))
                {
                    return new global::Gladia.JsonConverters.SubtitlesFormatEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Gladia.TranslationLanguageCodeEnum))
                {
                    return new global::Gladia.JsonConverters.TranslationLanguageCodeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Gladia.TranslationLanguageCodeEnum?))
                {
                    return new global::Gladia.JsonConverters.TranslationLanguageCodeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Gladia.TranslationModelEnum))
                {
                    return new global::Gladia.JsonConverters.TranslationModelEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Gladia.TranslationModelEnum?))
                {
                    return new global::Gladia.JsonConverters.TranslationModelEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Gladia.SummaryTypesEnum))
                {
                    return new global::Gladia.JsonConverters.SummaryTypesEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Gladia.SummaryTypesEnum?))
                {
                    return new global::Gladia.JsonConverters.SummaryTypesEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Gladia.StreamingSupportedEncodingEnum))
                {
                    return new global::Gladia.JsonConverters.StreamingSupportedEncodingEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Gladia.StreamingSupportedEncodingEnum?))
                {
                    return new global::Gladia.JsonConverters.StreamingSupportedEncodingEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Gladia.StreamingSupportedModels))
                {
                    return new global::Gladia.JsonConverters.StreamingSupportedModelsJsonConverter();
                }

                if (typeToConvert == typeof(global::Gladia.StreamingSupportedModels?))
                {
                    return new global::Gladia.JsonConverters.StreamingSupportedModelsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Gladia.StreamingResponseStatus))
                {
                    return new global::Gladia.JsonConverters.StreamingResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Gladia.StreamingResponseStatus?))
                {
                    return new global::Gladia.JsonConverters.StreamingResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Gladia.StreamingResponseKind))
                {
                    return new global::Gladia.JsonConverters.StreamingResponseKindJsonConverter();
                }

                if (typeToConvert == typeof(global::Gladia.StreamingResponseKind?))
                {
                    return new global::Gladia.JsonConverters.StreamingResponseKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Gladia.StreamingSupportedRegions))
                {
                    return new global::Gladia.JsonConverters.StreamingSupportedRegionsJsonConverter();
                }

                if (typeToConvert == typeof(global::Gladia.StreamingSupportedRegions?))
                {
                    return new global::Gladia.JsonConverters.StreamingSupportedRegionsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Gladia.StreamingControllerGetStreamingJobsV2Statu))
                {
                    return new global::Gladia.JsonConverters.StreamingControllerGetStreamingJobsV2StatuJsonConverter();
                }

                if (typeToConvert == typeof(global::Gladia.StreamingControllerGetStreamingJobsV2Statu?))
                {
                    return new global::Gladia.JsonConverters.StreamingControllerGetStreamingJobsV2StatuNullableJsonConverter();
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
                    0 => new LiveV2SourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}