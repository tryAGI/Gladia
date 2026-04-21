
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
            typeof(global::Gladia.JsonConverters.TranscriptionLanguageCodeEnumJsonConverter),

            typeof(global::Gladia.JsonConverters.TranscriptionLanguageCodeEnumNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.CallbackMethodEnumJsonConverter),

            typeof(global::Gladia.JsonConverters.CallbackMethodEnumNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.SubtitlesFormatEnumJsonConverter),

            typeof(global::Gladia.JsonConverters.SubtitlesFormatEnumNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.SubtitlesStyleEnumJsonConverter),

            typeof(global::Gladia.JsonConverters.SubtitlesStyleEnumNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.TranslationLanguageCodeEnumJsonConverter),

            typeof(global::Gladia.JsonConverters.TranslationLanguageCodeEnumNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.TranslationModelEnumJsonConverter),

            typeof(global::Gladia.JsonConverters.TranslationModelEnumNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.SummaryTypesEnumJsonConverter),

            typeof(global::Gladia.JsonConverters.SummaryTypesEnumNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.PiiRedactionEntityTypeEnumJsonConverter),

            typeof(global::Gladia.JsonConverters.PiiRedactionEntityTypeEnumNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.PiiRedactionConfigDTOProcessedTextTypeJsonConverter),

            typeof(global::Gladia.JsonConverters.PiiRedactionConfigDTOProcessedTextTypeNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.PreRecordedResponseStatusJsonConverter),

            typeof(global::Gladia.JsonConverters.PreRecordedResponseStatusNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.PreRecordedResponseKindJsonConverter),

            typeof(global::Gladia.JsonConverters.PreRecordedResponseKindNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.CallbackTranscriptionSuccessPayloadEventJsonConverter),

            typeof(global::Gladia.JsonConverters.CallbackTranscriptionSuccessPayloadEventNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.CallbackTranscriptionErrorPayloadEventJsonConverter),

            typeof(global::Gladia.JsonConverters.CallbackTranscriptionErrorPayloadEventNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.StreamingSupportedEncodingEnumJsonConverter),

            typeof(global::Gladia.JsonConverters.StreamingSupportedEncodingEnumNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.StreamingSupportedModelsJsonConverter),

            typeof(global::Gladia.JsonConverters.StreamingSupportedModelsNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.StreamingResponseStatusJsonConverter),

            typeof(global::Gladia.JsonConverters.StreamingResponseStatusNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.StreamingResponseKindJsonConverter),

            typeof(global::Gladia.JsonConverters.StreamingResponseKindNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.ListTranscriptionResponseItemsDiscriminatorKindJsonConverter),

            typeof(global::Gladia.JsonConverters.ListTranscriptionResponseItemsDiscriminatorKindNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.ListHistoryResponseItemsDiscriminatorKindJsonConverter),

            typeof(global::Gladia.JsonConverters.ListHistoryResponseItemsDiscriminatorKindNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.AudioChunkActionTypeJsonConverter),

            typeof(global::Gladia.JsonConverters.AudioChunkActionTypeNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.StopRecordingActionTypeJsonConverter),

            typeof(global::Gladia.JsonConverters.StopRecordingActionTypeNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.AudioChunkAckMessageTypeJsonConverter),

            typeof(global::Gladia.JsonConverters.AudioChunkAckMessageTypeNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.CallbackLiveAudioChunkAckMessageEventJsonConverter),

            typeof(global::Gladia.JsonConverters.CallbackLiveAudioChunkAckMessageEventNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.EndRecordingMessageTypeJsonConverter),

            typeof(global::Gladia.JsonConverters.EndRecordingMessageTypeNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.CallbackLiveEndRecordingMessageEventJsonConverter),

            typeof(global::Gladia.JsonConverters.CallbackLiveEndRecordingMessageEventNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.EndSessionMessageTypeJsonConverter),

            typeof(global::Gladia.JsonConverters.EndSessionMessageTypeNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.CallbackLiveEndSessionMessageEventJsonConverter),

            typeof(global::Gladia.JsonConverters.CallbackLiveEndSessionMessageEventNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.TranslationMessageTypeJsonConverter),

            typeof(global::Gladia.JsonConverters.TranslationMessageTypeNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.CallbackLiveTranslationMessageEventJsonConverter),

            typeof(global::Gladia.JsonConverters.CallbackLiveTranslationMessageEventNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.NamedEntityRecognitionMessageTypeJsonConverter),

            typeof(global::Gladia.JsonConverters.NamedEntityRecognitionMessageTypeNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.CallbackLiveNamedEntityRecognitionMessageEventJsonConverter),

            typeof(global::Gladia.JsonConverters.CallbackLiveNamedEntityRecognitionMessageEventNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.PostChapterizationMessageTypeJsonConverter),

            typeof(global::Gladia.JsonConverters.PostChapterizationMessageTypeNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.CallbackLivePostChapterizationMessageEventJsonConverter),

            typeof(global::Gladia.JsonConverters.CallbackLivePostChapterizationMessageEventNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.PostFinalTranscriptMessageTypeJsonConverter),

            typeof(global::Gladia.JsonConverters.PostFinalTranscriptMessageTypeNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.CallbackLivePostFinalTranscriptMessageEventJsonConverter),

            typeof(global::Gladia.JsonConverters.CallbackLivePostFinalTranscriptMessageEventNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.PostSummarizationMessageTypeJsonConverter),

            typeof(global::Gladia.JsonConverters.PostSummarizationMessageTypeNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.CallbackLivePostSummarizationMessageEventJsonConverter),

            typeof(global::Gladia.JsonConverters.CallbackLivePostSummarizationMessageEventNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.PostTranscriptMessageTypeJsonConverter),

            typeof(global::Gladia.JsonConverters.PostTranscriptMessageTypeNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.CallbackLivePostTranscriptMessageEventJsonConverter),

            typeof(global::Gladia.JsonConverters.CallbackLivePostTranscriptMessageEventNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.SentimentAnalysisMessageTypeJsonConverter),

            typeof(global::Gladia.JsonConverters.SentimentAnalysisMessageTypeNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.CallbackLiveSentimentAnalysisMessageEventJsonConverter),

            typeof(global::Gladia.JsonConverters.CallbackLiveSentimentAnalysisMessageEventNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.StartRecordingMessageTypeJsonConverter),

            typeof(global::Gladia.JsonConverters.StartRecordingMessageTypeNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.CallbackLiveStartRecordingMessageEventJsonConverter),

            typeof(global::Gladia.JsonConverters.CallbackLiveStartRecordingMessageEventNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.StartSessionMessageTypeJsonConverter),

            typeof(global::Gladia.JsonConverters.StartSessionMessageTypeNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.CallbackLiveStartSessionMessageEventJsonConverter),

            typeof(global::Gladia.JsonConverters.CallbackLiveStartSessionMessageEventNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.StopRecordingAckMessageTypeJsonConverter),

            typeof(global::Gladia.JsonConverters.StopRecordingAckMessageTypeNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.CallbackLiveStopRecordingAckMessageEventJsonConverter),

            typeof(global::Gladia.JsonConverters.CallbackLiveStopRecordingAckMessageEventNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.TranscriptMessageTypeJsonConverter),

            typeof(global::Gladia.JsonConverters.TranscriptMessageTypeNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.CallbackLiveTranscriptMessageEventJsonConverter),

            typeof(global::Gladia.JsonConverters.CallbackLiveTranscriptMessageEventNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.SpeechStartMessageTypeJsonConverter),

            typeof(global::Gladia.JsonConverters.SpeechStartMessageTypeNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.CallbackLiveSpeechStartMessageEventJsonConverter),

            typeof(global::Gladia.JsonConverters.CallbackLiveSpeechStartMessageEventNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.SpeechEndMessageTypeJsonConverter),

            typeof(global::Gladia.JsonConverters.SpeechEndMessageTypeNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.CallbackLiveSpeechEndMessageEventJsonConverter),

            typeof(global::Gladia.JsonConverters.CallbackLiveSpeechEndMessageEventNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.StreamingSupportedRegionsJsonConverter),

            typeof(global::Gladia.JsonConverters.StreamingSupportedRegionsNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.WebhookTranscriptionCreatedPayloadEventJsonConverter),

            typeof(global::Gladia.JsonConverters.WebhookTranscriptionCreatedPayloadEventNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.WebhookTranscriptionSuccessPayloadEventJsonConverter),

            typeof(global::Gladia.JsonConverters.WebhookTranscriptionSuccessPayloadEventNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.WebhookTranscriptionErrorPayloadEventJsonConverter),

            typeof(global::Gladia.JsonConverters.WebhookTranscriptionErrorPayloadEventNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.WebhookLiveStartSessionPayloadEventJsonConverter),

            typeof(global::Gladia.JsonConverters.WebhookLiveStartSessionPayloadEventNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.WebhookLiveStartRecordingPayloadEventJsonConverter),

            typeof(global::Gladia.JsonConverters.WebhookLiveStartRecordingPayloadEventNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.WebhookLiveEndRecordingPayloadEventJsonConverter),

            typeof(global::Gladia.JsonConverters.WebhookLiveEndRecordingPayloadEventNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.WebhookLiveEndSessionPayloadEventJsonConverter),

            typeof(global::Gladia.JsonConverters.WebhookLiveEndSessionPayloadEventNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.AudioToTextControllerAudioTranscriptionRequestLanguageBehaviourJsonConverter),

            typeof(global::Gladia.JsonConverters.AudioToTextControllerAudioTranscriptionRequestLanguageBehaviourNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.AudioToTextControllerAudioTranscriptionRequestLanguageJsonConverter),

            typeof(global::Gladia.JsonConverters.AudioToTextControllerAudioTranscriptionRequestLanguageNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.AudioToTextControllerAudioTranscriptionRequestTargetTranslationLanguageJsonConverter),

            typeof(global::Gladia.JsonConverters.AudioToTextControllerAudioTranscriptionRequestTargetTranslationLanguageNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.AudioToTextControllerAudioTranscriptionRequestOutputFormatJsonConverter),

            typeof(global::Gladia.JsonConverters.AudioToTextControllerAudioTranscriptionRequestOutputFormatNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.VideoToTextControllerVideoTranscriptionRequestLanguageBehaviourJsonConverter),

            typeof(global::Gladia.JsonConverters.VideoToTextControllerVideoTranscriptionRequestLanguageBehaviourNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.VideoToTextControllerVideoTranscriptionRequestLanguageJsonConverter),

            typeof(global::Gladia.JsonConverters.VideoToTextControllerVideoTranscriptionRequestLanguageNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.VideoToTextControllerVideoTranscriptionRequestTargetTranslationLanguageJsonConverter),

            typeof(global::Gladia.JsonConverters.VideoToTextControllerVideoTranscriptionRequestTargetTranslationLanguageNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.VideoToTextControllerVideoTranscriptionRequestOutputFormatJsonConverter),

            typeof(global::Gladia.JsonConverters.VideoToTextControllerVideoTranscriptionRequestOutputFormatNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.PreRecordedControllerGetPreRecordedJobsV2StatuJsonConverter),

            typeof(global::Gladia.JsonConverters.PreRecordedControllerGetPreRecordedJobsV2StatuNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.TranscriptionControllerListV2StatuJsonConverter),

            typeof(global::Gladia.JsonConverters.TranscriptionControllerListV2StatuNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.TranscriptionControllerListV2KindItemJsonConverter),

            typeof(global::Gladia.JsonConverters.TranscriptionControllerListV2KindItemNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.HistoryControllerGetListV1StatuJsonConverter),

            typeof(global::Gladia.JsonConverters.HistoryControllerGetListV1StatuNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.HistoryControllerGetListV1KindItemJsonConverter),

            typeof(global::Gladia.JsonConverters.HistoryControllerGetListV1KindItemNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.StreamingControllerGetStreamingJobsV2StatuJsonConverter),

            typeof(global::Gladia.JsonConverters.StreamingControllerGetStreamingJobsV2StatuNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.TranscriptionControllerGetTranscriptV2ResponseDiscriminatorKindJsonConverter),

            typeof(global::Gladia.JsonConverters.TranscriptionControllerGetTranscriptV2ResponseDiscriminatorKindNullableJsonConverter),

            typeof(global::Gladia.JsonConverters.TranscriptionControllerGetTranscriptV2ResponseJsonConverter),

            typeof(global::Gladia.JsonConverters.OneOfJsonConverter<global::Gladia.CustomVocabularyEntryDTO, string>),

            typeof(global::Gladia.JsonConverters.OneOfJsonConverter<global::Gladia.PreRecordedResponse, global::Gladia.StreamingResponse>),

            typeof(global::Gladia.JsonConverters.OneOfJsonConverter<global::Gladia.PreRecordedResponse, global::Gladia.StreamingResponse>),

            typeof(global::Gladia.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.UploadBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.AudioUploadMetadataDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.AudioUploadResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.PreRecordedEventPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.LiveEventPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.TranscriptionLanguageCodeEnum), TypeInfoPropertyName = "TranscriptionLanguageCodeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.CustomVocabularyEntryDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.CustomVocabularyConfigDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Gladia.OneOf<global::Gladia.CustomVocabularyEntryDTO, string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.OneOf<global::Gladia.CustomVocabularyEntryDTO, string>), TypeInfoPropertyName = "OneOfCustomVocabularyEntryDTOString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.CallbackMethodEnum), TypeInfoPropertyName = "CallbackMethodEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.CallbackConfigDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.SubtitlesFormatEnum), TypeInfoPropertyName = "SubtitlesFormatEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.SubtitlesStyleEnum), TypeInfoPropertyName = "SubtitlesStyleEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.SubtitlesConfigDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Gladia.SubtitlesFormatEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.DiarizationConfigDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.TranslationLanguageCodeEnum), TypeInfoPropertyName = "TranslationLanguageCodeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.TranslationModelEnum), TypeInfoPropertyName = "TranslationModelEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.TranslationConfigDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Gladia.TranslationLanguageCodeEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.SummaryTypesEnum), TypeInfoPropertyName = "SummaryTypesEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.SummarizationConfigDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.CustomSpellingConfigDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.AudioToLlmListConfigDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.PiiRedactionEntityTypeEnum), TypeInfoPropertyName = "PiiRedactionEntityTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.PiiRedactionConfigDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.PiiRedactionConfigDTOProcessedTextType), TypeInfoPropertyName = "PiiRedactionConfigDTOProcessedTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.LanguageConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Gladia.TranscriptionLanguageCodeEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.InitTranscriptionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.InitPreRecordedTranscriptionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.BadRequestErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.UnauthorizedErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.UnprocessableEntityErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.FileResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.PreRecordedRequestParamsResponse))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.ModerationDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.NamedEntityRecognitionResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.NamedEntityRecognitionDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Gladia.NamedEntityRecognitionResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.NamesConsistencyDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.StructuredDataExtractionDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.SentimentAnalysisDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.AudioToLlmResultDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.AudioToLlmDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.AudioToLlmListDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Gladia.AudioToLlmDTO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.DisplayModeDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.ChapterizationDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.DiarizationDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.TranscriptionResultDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.PreRecordedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.PreRecordedResponseStatus), TypeInfoPropertyName = "PreRecordedResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.PreRecordedResponseKind), TypeInfoPropertyName = "PreRecordedResponseKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.NotFoundErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.ListPreRecordedResponse), TypeInfoPropertyName = "ListPreRecordedResponse_Gladia_ListPreRecordedResponse")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Gladia.PreRecordedResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.ForbiddenErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.CallbackTranscriptionSuccessPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.CallbackTranscriptionSuccessPayloadEvent), TypeInfoPropertyName = "CallbackTranscriptionSuccessPayloadEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.ErrorDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.CallbackTranscriptionErrorPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.CallbackTranscriptionErrorPayloadEvent), TypeInfoPropertyName = "CallbackTranscriptionErrorPayloadEvent2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.ListTranscriptionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Gladia.OneOf<global::Gladia.PreRecordedResponse, global::Gladia.StreamingResponse>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.OneOf<global::Gladia.PreRecordedResponse, global::Gladia.StreamingResponse>), TypeInfoPropertyName = "OneOfPreRecordedResponseStreamingResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.ListTranscriptionResponseItemsDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.ListTranscriptionResponseItemsDiscriminatorKind), TypeInfoPropertyName = "ListTranscriptionResponseItemsDiscriminatorKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.ListHistoryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.ListHistoryResponseItemsDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.ListHistoryResponseItemsDiscriminatorKind), TypeInfoPropertyName = "ListHistoryResponseItemsDiscriminatorKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.AudioChunkActionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.AudioChunkAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.AudioChunkActionType), TypeInfoPropertyName = "AudioChunkActionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.StopRecordingAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.StopRecordingActionType), TypeInfoPropertyName = "StopRecordingActionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.AudioChunkAckData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<long>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.AudioChunkAckMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.AudioChunkAckMessageType), TypeInfoPropertyName = "AudioChunkAckMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.CallbackLiveAudioChunkAckMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.CallbackLiveAudioChunkAckMessageEvent), TypeInfoPropertyName = "CallbackLiveAudioChunkAckMessageEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.EndRecordingMessageData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.EndRecordingMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.EndRecordingMessageType), TypeInfoPropertyName = "EndRecordingMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.CallbackLiveEndRecordingMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.CallbackLiveEndRecordingMessageEvent), TypeInfoPropertyName = "CallbackLiveEndRecordingMessageEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.EndSessionMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.EndSessionMessageType), TypeInfoPropertyName = "EndSessionMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.CallbackLiveEndSessionMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.CallbackLiveEndSessionMessageEvent), TypeInfoPropertyName = "CallbackLiveEndSessionMessageEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.TranslationData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.TranslationMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.TranslationMessageType), TypeInfoPropertyName = "TranslationMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.CallbackLiveTranslationMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.CallbackLiveTranslationMessageEvent), TypeInfoPropertyName = "CallbackLiveTranslationMessageEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.NamedEntityRecognitionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.NamedEntityRecognitionMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.NamedEntityRecognitionMessageType), TypeInfoPropertyName = "NamedEntityRecognitionMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.CallbackLiveNamedEntityRecognitionMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.CallbackLiveNamedEntityRecognitionMessageEvent), TypeInfoPropertyName = "CallbackLiveNamedEntityRecognitionMessageEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.ChapterizationSentence))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.PostChapterizationResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Gladia.ChapterizationSentence>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.PostChapterizationMessageData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Gladia.PostChapterizationResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.PostChapterizationMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.PostChapterizationMessageType), TypeInfoPropertyName = "PostChapterizationMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.CallbackLivePostChapterizationMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.CallbackLivePostChapterizationMessageEvent), TypeInfoPropertyName = "CallbackLivePostChapterizationMessageEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.StreamingTranscriptionResultDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.PostFinalTranscriptMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.PostFinalTranscriptMessageType), TypeInfoPropertyName = "PostFinalTranscriptMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.CallbackLivePostFinalTranscriptMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.CallbackLivePostFinalTranscriptMessageEvent), TypeInfoPropertyName = "CallbackLivePostFinalTranscriptMessageEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.PostSummarizationMessageData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.PostSummarizationMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.PostSummarizationMessageType), TypeInfoPropertyName = "PostSummarizationMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.CallbackLivePostSummarizationMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.CallbackLivePostSummarizationMessageEvent), TypeInfoPropertyName = "CallbackLivePostSummarizationMessageEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.PostTranscriptMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.PostTranscriptMessageType), TypeInfoPropertyName = "PostTranscriptMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.CallbackLivePostTranscriptMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.CallbackLivePostTranscriptMessageEvent), TypeInfoPropertyName = "CallbackLivePostTranscriptMessageEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.SentimentAnalysisResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.SentimentAnalysisData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Gladia.SentimentAnalysisResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.SentimentAnalysisMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.SentimentAnalysisMessageType), TypeInfoPropertyName = "SentimentAnalysisMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.CallbackLiveSentimentAnalysisMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.CallbackLiveSentimentAnalysisMessageEvent), TypeInfoPropertyName = "CallbackLiveSentimentAnalysisMessageEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.StartRecordingMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.StartRecordingMessageType), TypeInfoPropertyName = "StartRecordingMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.CallbackLiveStartRecordingMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.CallbackLiveStartRecordingMessageEvent), TypeInfoPropertyName = "CallbackLiveStartRecordingMessageEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.StartSessionMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.StartSessionMessageType), TypeInfoPropertyName = "StartSessionMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.CallbackLiveStartSessionMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.CallbackLiveStartSessionMessageEvent), TypeInfoPropertyName = "CallbackLiveStartSessionMessageEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.StopRecordingAckData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.StopRecordingAckMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.StopRecordingAckMessageType), TypeInfoPropertyName = "StopRecordingAckMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.CallbackLiveStopRecordingAckMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.CallbackLiveStopRecordingAckMessageEvent), TypeInfoPropertyName = "CallbackLiveStopRecordingAckMessageEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.TranscriptMessageData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.TranscriptMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.TranscriptMessageType), TypeInfoPropertyName = "TranscriptMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.CallbackLiveTranscriptMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.CallbackLiveTranscriptMessageEvent), TypeInfoPropertyName = "CallbackLiveTranscriptMessageEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.SpeechMessageData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.SpeechStartMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.SpeechStartMessageType), TypeInfoPropertyName = "SpeechStartMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.CallbackLiveSpeechStartMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.CallbackLiveSpeechStartMessageEvent), TypeInfoPropertyName = "CallbackLiveSpeechStartMessageEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.SpeechEndMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.SpeechEndMessageType), TypeInfoPropertyName = "SpeechEndMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.CallbackLiveSpeechEndMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.CallbackLiveSpeechEndMessageEvent), TypeInfoPropertyName = "CallbackLiveSpeechEndMessageEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.StreamingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.StreamingSupportedRegions), TypeInfoPropertyName = "StreamingSupportedRegions2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.InitStreamingResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.ListStreamingResponse), TypeInfoPropertyName = "ListStreamingResponse_Gladia_ListStreamingResponse")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Gladia.StreamingResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.PatchRequestParamsDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.PayloadTooLargeErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.WebhookTranscriptionCreatedPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.WebhookTranscriptionCreatedPayloadEvent), TypeInfoPropertyName = "WebhookTranscriptionCreatedPayloadEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.WebhookTranscriptionSuccessPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.WebhookTranscriptionSuccessPayloadEvent), TypeInfoPropertyName = "WebhookTranscriptionSuccessPayloadEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.WebhookTranscriptionErrorPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.WebhookTranscriptionErrorPayloadEvent), TypeInfoPropertyName = "WebhookTranscriptionErrorPayloadEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.WebhookLiveStartSessionPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.WebhookLiveStartSessionPayloadEvent), TypeInfoPropertyName = "WebhookLiveStartSessionPayloadEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.WebhookLiveStartRecordingPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.WebhookLiveStartRecordingPayloadEvent), TypeInfoPropertyName = "WebhookLiveStartRecordingPayloadEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.WebhookLiveEndRecordingPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.WebhookLiveEndRecordingPayloadEvent), TypeInfoPropertyName = "WebhookLiveEndRecordingPayloadEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.WebhookLiveEndSessionPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.WebhookLiveEndSessionPayloadEvent), TypeInfoPropertyName = "WebhookLiveEndSessionPayloadEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.FileControllerUploadV2Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.FileControllerUploadV2Request2))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Gladia.PreRecordedControllerGetPreRecordedJobsV2Statu>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.PreRecordedControllerGetPreRecordedJobsV2Statu), TypeInfoPropertyName = "PreRecordedControllerGetPreRecordedJobsV2Statu2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Gladia.TranscriptionControllerListV2Statu>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.TranscriptionControllerListV2Statu), TypeInfoPropertyName = "TranscriptionControllerListV2Statu2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Gladia.TranscriptionControllerListV2KindItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.TranscriptionControllerListV2KindItem), TypeInfoPropertyName = "TranscriptionControllerListV2KindItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Gladia.HistoryControllerGetListV1Statu>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.HistoryControllerGetListV1Statu), TypeInfoPropertyName = "HistoryControllerGetListV1Statu2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Gladia.HistoryControllerGetListV1KindItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.HistoryControllerGetListV1KindItem), TypeInfoPropertyName = "HistoryControllerGetListV1KindItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Gladia.StreamingControllerGetStreamingJobsV2Statu>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.StreamingControllerGetStreamingJobsV2Statu), TypeInfoPropertyName = "StreamingControllerGetStreamingJobsV2Statu2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.TranscriptionControllerGetTranscriptV2Response), TypeInfoPropertyName = "TranscriptionControllerGetTranscriptV2Response2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.TranscriptionControllerGetTranscriptV2ResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gladia.TranscriptionControllerGetTranscriptV2ResponseDiscriminatorKind), TypeInfoPropertyName = "TranscriptionControllerGetTranscriptV2ResponseDiscriminatorKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Gladia.OneOf<global::Gladia.CustomVocabularyEntryDTO, string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Gladia.SubtitlesFormatEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Gladia.TranslationLanguageCodeEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Gladia.TranscriptionLanguageCodeEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Gladia.WordDTO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Gladia.SentencesDTO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Gladia.SubtitleDTO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Gladia.UtteranceDTO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Gladia.TranslationResultDTO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Gladia.NamedEntityRecognitionResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Gladia.AudioToLlmDTO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Gladia.PreRecordedResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Gladia.OneOf<global::Gladia.PreRecordedResponse, global::Gladia.StreamingResponse>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<long>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Gladia.ChapterizationSentence>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Gladia.PostChapterizationResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Gladia.SentimentAnalysisResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Gladia.StreamingResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Gladia.PreRecordedControllerGetPreRecordedJobsV2Statu>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Gladia.TranscriptionControllerListV2Statu>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Gladia.TranscriptionControllerListV2KindItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Gladia.HistoryControllerGetListV1Statu>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Gladia.HistoryControllerGetListV1KindItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Gladia.StreamingControllerGetStreamingJobsV2Statu>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}