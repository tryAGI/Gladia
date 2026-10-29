
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Gladia
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
        public global::Gladia.PreRecordedEventPayload? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Guid? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.LiveEventPayload? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.UploadBody? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.AudioUploadMetadataDTO? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.AudioUploadResponse? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.TranscriptionLanguageCodeEnum? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.CustomVocabularyEntryDTO? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.CustomVocabularyConfigDTO? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Gladia.OneOf<global::Gladia.CustomVocabularyEntryDTO, string>>? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.OneOf<global::Gladia.CustomVocabularyEntryDTO, string>? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.CallbackMethodEnum? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.CallbackConfigDto? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.SubtitlesFormatEnum? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.SubtitlesStyleEnum? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.SubtitlesConfigDTO? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Gladia.SubtitlesFormatEnum>? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.DiarizationConfigDTO? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.TranslationLanguageCodeEnum? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.TranslationModelEnum? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.TranslationConfigDTO? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Gladia.TranslationLanguageCodeEnum>? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.SummaryTypesEnum? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.SummarizationConfigDTO? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.CustomSpellingConfigDTO? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.AudioToLlmListConfigDTO? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<byte[]>? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.PiiRedactionEntityTypeEnum? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.PiiRedactionConfigDTO? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.PiiRedactionConfigDTOProcessedTextType? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.LanguageConfig? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Gladia.TranscriptionLanguageCodeEnum>? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.TranscriptionSupportedModels? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.InitTranscriptionRequest? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.PreRecordedTranscriptionModel? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.InitPreRecordedTranscriptionResponse? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.BadRequestErrorResponse? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.UnauthorizedErrorResponse? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.UnprocessableEntityErrorResponse? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.FileResponse? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.PreRecordedRequestParamsResponse? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.TranscriptionMetadataDTO? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.AddonErrorDTO? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.SentencesDTO? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.SubtitleDTO? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.WordDTO? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.UtteranceDTO? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Gladia.WordDTO>? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.TranscriptionDTO? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Gladia.SentencesDTO>? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Gladia.SubtitleDTO>? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Gladia.UtteranceDTO>? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.TranslationResultDTO? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.TranslationDTO? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Gladia.TranslationResultDTO>? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.SummarizationDTO? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.NamedEntityRecognitionResult? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.NamedEntityRecognitionDTO? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Gladia.NamedEntityRecognitionResult>? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.NamesConsistencyDTO? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.SentimentAnalysisDTO? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.AudioToLlmResultDTO? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.AudioToLlmDTO? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.AudioToLlmListDTO? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Gladia.AudioToLlmDTO>? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.DisplayModeDTO? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.DiarizationDTO? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.TranscriptionResultDTO? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.PreRecordedResponse? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.PreRecordedResponseStatus? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.PreRecordedResponseKind? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.NotFoundErrorResponse? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Gladia.PreRecordedResponse>? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.ForbiddenErrorResponse? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.CallbackTranscriptionSuccessPayload? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.CallbackTranscriptionSuccessPayloadEvent? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.ErrorDTO? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.CallbackTranscriptionErrorPayload? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.CallbackTranscriptionErrorPayloadEvent? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.StreamingSupportedEncodingEnum? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.StreamingSupportedModels? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.PreProcessingConfig? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.RealtimeProcessingConfig? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.PostProcessingConfig? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.MessagesConfig? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.CallbackConfig? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.StreamingRequestParamsResponse? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.StreamingTranscriptionResultWithMessagesDTO? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.StreamingResponse? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.StreamingResponseStatus? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.StreamingResponseKind? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.ListTranscriptionResponse? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Gladia.OneOf<global::Gladia.PreRecordedResponse, global::Gladia.StreamingResponse>>? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.OneOf<global::Gladia.PreRecordedResponse, global::Gladia.StreamingResponse>? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.ListTranscriptionResponseItemsDiscriminator? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.ListTranscriptionResponseItemsDiscriminatorKind? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.ListHistoryResponse? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.ListHistoryResponseItemsDiscriminator? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.ListHistoryResponseItemsDiscriminatorKind? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.AudioChunkActionData? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.AudioChunkAction? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.AudioChunkActionType? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.StopRecordingAction? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.StopRecordingActionType? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.Error? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.AudioChunkAckData? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<long>? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.AudioChunkAckMessage? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.AudioChunkAckMessageType? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.CallbackLiveAudioChunkAckMessage? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.CallbackLiveAudioChunkAckMessageEvent? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.EndRecordingMessageData? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.EndRecordingMessage? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.EndRecordingMessageType? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.CallbackLiveEndRecordingMessage? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.CallbackLiveEndRecordingMessageEvent? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.EndSessionMessage? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.EndSessionMessageType? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.CallbackLiveEndSessionMessage? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.CallbackLiveEndSessionMessageEvent? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.TranslationData? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.TranslationMessage? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.TranslationMessageType? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.CallbackLiveTranslationMessage? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.CallbackLiveTranslationMessageEvent? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.NamedEntityRecognitionData? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.NamedEntityRecognitionMessage? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.NamedEntityRecognitionMessageType? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.CallbackLiveNamedEntityRecognitionMessage? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.CallbackLiveNamedEntityRecognitionMessageEvent? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.StreamingTranscriptionResultDTO? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.PostFinalTranscriptMessage? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.PostFinalTranscriptMessageType? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.CallbackLivePostFinalTranscriptMessage? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.CallbackLivePostFinalTranscriptMessageEvent? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.PostSummarizationMessageData? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.PostSummarizationMessage? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.PostSummarizationMessageType? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.CallbackLivePostSummarizationMessage? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.CallbackLivePostSummarizationMessageEvent? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.PostTranscriptMessage? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.PostTranscriptMessageType? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.CallbackLivePostTranscriptMessage? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.CallbackLivePostTranscriptMessageEvent? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.SentimentAnalysisResult? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.SentimentAnalysisData? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Gladia.SentimentAnalysisResult>? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.SentimentAnalysisMessage? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.SentimentAnalysisMessageType? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.CallbackLiveSentimentAnalysisMessage? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.CallbackLiveSentimentAnalysisMessageEvent? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.StartRecordingMessage? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.StartRecordingMessageType? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.CallbackLiveStartRecordingMessage? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.CallbackLiveStartRecordingMessageEvent? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.StartSessionMessage? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.StartSessionMessageType? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.CallbackLiveStartSessionMessage? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.CallbackLiveStartSessionMessageEvent? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.StopRecordingAckData? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.StopRecordingAckMessage? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.StopRecordingAckMessageType? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.CallbackLiveStopRecordingAckMessage? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.CallbackLiveStopRecordingAckMessageEvent? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.TranscriptMessageData? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.TranscriptMessage? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.TranscriptMessageType? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.CallbackLiveTranscriptMessage? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.CallbackLiveTranscriptMessageEvent? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.SpeechMessageData? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.SpeechStartMessage? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.SpeechStartMessageType? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.CallbackLiveSpeechStartMessage? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.CallbackLiveSpeechStartMessageEvent? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.SpeechEndMessage? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.SpeechEndMessageType? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.CallbackLiveSpeechEndMessage? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.CallbackLiveSpeechEndMessageEvent? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.StreamingRequest? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.StreamingSupportedRegions? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.InitStreamingResponse? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Gladia.StreamingResponse>? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.PatchRequestParamsDTO? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.PayloadTooLargeErrorResponse? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.WebhookTranscriptionCreatedPayload? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.WebhookTranscriptionCreatedPayloadEvent? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.WebhookTranscriptionSuccessPayload? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.WebhookTranscriptionSuccessPayloadEvent? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.WebhookTranscriptionErrorPayload? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.WebhookTranscriptionErrorPayloadEvent? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.WebhookLiveStartSessionPayload? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.WebhookLiveStartSessionPayloadEvent? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.WebhookLiveStartRecordingPayload? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.WebhookLiveStartRecordingPayloadEvent? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.WebhookLiveEndRecordingPayload? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.WebhookLiveEndRecordingPayloadEvent? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.WebhookLiveEndSessionPayload? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.WebhookLiveEndSessionPayloadEvent? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.FileControllerUploadV2Request? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.FileControllerUploadV2Request2? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.AudioToTextControllerAudioTranscriptionRequest? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.AudioToTextControllerAudioTranscriptionRequestLanguageBehaviour? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.AudioToTextControllerAudioTranscriptionRequestLanguage? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.AudioToTextControllerAudioTranscriptionRequestTargetTranslationLanguage? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.AudioToTextControllerAudioTranscriptionRequestOutputFormat? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.VideoToTextControllerVideoTranscriptionRequest? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.VideoToTextControllerVideoTranscriptionRequestLanguageBehaviour? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.VideoToTextControllerVideoTranscriptionRequestLanguage? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.VideoToTextControllerVideoTranscriptionRequestTargetTranslationLanguage? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.VideoToTextControllerVideoTranscriptionRequestOutputFormat? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Gladia.PreRecordedControllerGetPreRecordedJobsV2Statu>? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.PreRecordedControllerGetPreRecordedJobsV2Statu? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Gladia.TranscriptionControllerListV2Statu>? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.TranscriptionControllerListV2Statu? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Gladia.TranscriptionControllerListV2KindItem>? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.TranscriptionControllerListV2KindItem? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Gladia.HistoryControllerGetListV1Statu>? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.HistoryControllerGetListV1Statu? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Gladia.HistoryControllerGetListV1KindItem>? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.HistoryControllerGetListV1KindItem? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Gladia.StreamingControllerGetStreamingJobsV2Statu>? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.StreamingControllerGetStreamingJobsV2Statu? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.TranscriptionControllerGetTranscriptV2Response? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.TranscriptionControllerGetTranscriptV2ResponseDiscriminator? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Gladia.TranscriptionControllerGetTranscriptV2ResponseDiscriminatorKind? Type235 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Gladia.OneOf<global::Gladia.CustomVocabularyEntryDTO, string>>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Gladia.SubtitlesFormatEnum>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Gladia.TranslationLanguageCodeEnum>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<byte[]>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Gladia.TranscriptionLanguageCodeEnum>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Gladia.WordDTO>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Gladia.SentencesDTO>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Gladia.SubtitleDTO>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Gladia.UtteranceDTO>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Gladia.TranslationResultDTO>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Gladia.NamedEntityRecognitionResult>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Gladia.AudioToLlmDTO>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Gladia.OneOf<global::Gladia.PreRecordedResponse, global::Gladia.StreamingResponse>>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<long>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<double>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Gladia.SentimentAnalysisResult>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Gladia.PreRecordedControllerGetPreRecordedJobsV2Statu>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Gladia.TranscriptionControllerListV2Statu>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Gladia.TranscriptionControllerListV2KindItem>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Gladia.HistoryControllerGetListV1Statu>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Gladia.HistoryControllerGetListV1KindItem>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Gladia.StreamingControllerGetStreamingJobsV2Statu>? ListType23 { get; set; }
    }
}