
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
        public global::Gladia.InitTranscriptionRequest? Type39 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public object? Type40 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.InitPreRecordedTranscriptionResponse? Type41 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.BadRequestErrorResponse? Type42 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.UnauthorizedErrorResponse? Type43 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.UnprocessableEntityErrorResponse? Type44 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.FileResponse? Type45 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.PreRecordedRequestParamsResponse? Type46 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.TranscriptionMetadataDTO? Type47 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.AddonErrorDTO? Type48 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.SentencesDTO? Type49 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.SubtitleDTO? Type50 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.WordDTO? Type51 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.UtteranceDTO? Type52 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Gladia.WordDTO>? Type53 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.TranscriptionDTO? Type54 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Gladia.SentencesDTO>? Type55 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Gladia.SubtitleDTO>? Type56 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Gladia.UtteranceDTO>? Type57 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.TranslationResultDTO? Type58 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.TranslationDTO? Type59 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Gladia.TranslationResultDTO>? Type60 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.SummarizationDTO? Type61 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.ModerationDTO? Type62 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.NamedEntityRecognitionResult? Type63 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.NamedEntityRecognitionDTO? Type64 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Gladia.NamedEntityRecognitionResult>? Type65 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.NamesConsistencyDTO? Type66 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.StructuredDataExtractionDTO? Type67 { get; set; }
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
        public global::Gladia.ChapterizationDTO? Type74 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.DiarizationDTO? Type75 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.TranscriptionResultDTO? Type76 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.PreRecordedResponse? Type77 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.PreRecordedResponseStatus? Type78 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.DateTime? Type79 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.PreRecordedResponseKind? Type80 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.NotFoundErrorResponse? Type81 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.ListPreRecordedResponse? Type82 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Gladia.PreRecordedResponse>? Type83 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.ForbiddenErrorResponse? Type84 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.CallbackTranscriptionSuccessPayload? Type85 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.CallbackTranscriptionSuccessPayloadEvent? Type86 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.ErrorDTO? Type87 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.CallbackTranscriptionErrorPayload? Type88 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.CallbackTranscriptionErrorPayloadEvent? Type89 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.StreamingSupportedEncodingEnum? Type90 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.StreamingSupportedModels? Type91 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.PreProcessingConfig? Type92 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.RealtimeProcessingConfig? Type93 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.PostProcessingConfig? Type94 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.MessagesConfig? Type95 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.CallbackConfig? Type96 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.StreamingRequestParamsResponse? Type97 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.StreamingTranscriptionResultWithMessagesDTO? Type98 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.StreamingResponse? Type99 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.StreamingResponseStatus? Type100 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.StreamingResponseKind? Type101 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.ListTranscriptionResponse? Type102 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Gladia.OneOf<global::Gladia.PreRecordedResponse, global::Gladia.StreamingResponse>>? Type103 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.OneOf<global::Gladia.PreRecordedResponse, global::Gladia.StreamingResponse>? Type104 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.ListTranscriptionResponseItemsDiscriminator? Type105 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.ListTranscriptionResponseItemsDiscriminatorKind? Type106 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.ListHistoryResponse? Type107 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.ListHistoryResponseItemsDiscriminator? Type108 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.ListHistoryResponseItemsDiscriminatorKind? Type109 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.AudioChunkActionData? Type110 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.AudioChunkAction? Type111 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.AudioChunkActionType? Type112 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.StopRecordingAction? Type113 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.StopRecordingActionType? Type114 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.Error? Type115 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.AudioChunkAckData? Type116 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<long>? Type117 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long? Type118 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type119 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.AudioChunkAckMessage? Type120 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.AudioChunkAckMessageType? Type121 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.CallbackLiveAudioChunkAckMessage? Type122 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.CallbackLiveAudioChunkAckMessageEvent? Type123 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.EndRecordingMessageData? Type124 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.EndRecordingMessage? Type125 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.EndRecordingMessageType? Type126 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.CallbackLiveEndRecordingMessage? Type127 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.CallbackLiveEndRecordingMessageEvent? Type128 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.EndSessionMessage? Type129 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.EndSessionMessageType? Type130 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.CallbackLiveEndSessionMessage? Type131 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.CallbackLiveEndSessionMessageEvent? Type132 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.TranslationData? Type133 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.TranslationMessage? Type134 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.TranslationMessageType? Type135 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.CallbackLiveTranslationMessage? Type136 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.CallbackLiveTranslationMessageEvent? Type137 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.NamedEntityRecognitionData? Type138 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.NamedEntityRecognitionMessage? Type139 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.NamedEntityRecognitionMessageType? Type140 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.CallbackLiveNamedEntityRecognitionMessage? Type141 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.CallbackLiveNamedEntityRecognitionMessageEvent? Type142 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.ChapterizationSentence? Type143 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.PostChapterizationResult? Type144 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Gladia.ChapterizationSentence>? Type145 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.PostChapterizationMessageData? Type146 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Gladia.PostChapterizationResult>? Type147 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.PostChapterizationMessage? Type148 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.PostChapterizationMessageType? Type149 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.CallbackLivePostChapterizationMessage? Type150 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.CallbackLivePostChapterizationMessageEvent? Type151 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.StreamingTranscriptionResultDTO? Type152 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.PostFinalTranscriptMessage? Type153 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.PostFinalTranscriptMessageType? Type154 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.CallbackLivePostFinalTranscriptMessage? Type155 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.CallbackLivePostFinalTranscriptMessageEvent? Type156 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.PostSummarizationMessageData? Type157 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.PostSummarizationMessage? Type158 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.PostSummarizationMessageType? Type159 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.CallbackLivePostSummarizationMessage? Type160 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.CallbackLivePostSummarizationMessageEvent? Type161 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.PostTranscriptMessage? Type162 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.PostTranscriptMessageType? Type163 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.CallbackLivePostTranscriptMessage? Type164 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.CallbackLivePostTranscriptMessageEvent? Type165 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.SentimentAnalysisResult? Type166 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.SentimentAnalysisData? Type167 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Gladia.SentimentAnalysisResult>? Type168 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.SentimentAnalysisMessage? Type169 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.SentimentAnalysisMessageType? Type170 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.CallbackLiveSentimentAnalysisMessage? Type171 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.CallbackLiveSentimentAnalysisMessageEvent? Type172 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.StartRecordingMessage? Type173 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.StartRecordingMessageType? Type174 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.CallbackLiveStartRecordingMessage? Type175 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.CallbackLiveStartRecordingMessageEvent? Type176 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.StartSessionMessage? Type177 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.StartSessionMessageType? Type178 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.CallbackLiveStartSessionMessage? Type179 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.CallbackLiveStartSessionMessageEvent? Type180 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.StopRecordingAckData? Type181 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.StopRecordingAckMessage? Type182 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.StopRecordingAckMessageType? Type183 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.CallbackLiveStopRecordingAckMessage? Type184 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.CallbackLiveStopRecordingAckMessageEvent? Type185 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.TranscriptMessageData? Type186 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.TranscriptMessage? Type187 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.TranscriptMessageType? Type188 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.CallbackLiveTranscriptMessage? Type189 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.CallbackLiveTranscriptMessageEvent? Type190 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.SpeechMessageData? Type191 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.SpeechStartMessage? Type192 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.SpeechStartMessageType? Type193 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.CallbackLiveSpeechStartMessage? Type194 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.CallbackLiveSpeechStartMessageEvent? Type195 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.SpeechEndMessage? Type196 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.SpeechEndMessageType? Type197 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.CallbackLiveSpeechEndMessage? Type198 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.CallbackLiveSpeechEndMessageEvent? Type199 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.StreamingRequest? Type200 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.StreamingSupportedRegions? Type201 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.InitStreamingResponse? Type202 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.ListStreamingResponse? Type203 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Gladia.StreamingResponse>? Type204 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.PatchRequestParamsDTO? Type205 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.PayloadTooLargeErrorResponse? Type206 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.WebhookTranscriptionCreatedPayload? Type207 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.WebhookTranscriptionCreatedPayloadEvent? Type208 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.WebhookTranscriptionSuccessPayload? Type209 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.WebhookTranscriptionSuccessPayloadEvent? Type210 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.WebhookTranscriptionErrorPayload? Type211 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.WebhookTranscriptionErrorPayloadEvent? Type212 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.WebhookLiveStartSessionPayload? Type213 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.WebhookLiveStartSessionPayloadEvent? Type214 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.WebhookLiveStartRecordingPayload? Type215 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.WebhookLiveStartRecordingPayloadEvent? Type216 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.WebhookLiveEndRecordingPayload? Type217 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.WebhookLiveEndRecordingPayloadEvent? Type218 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.WebhookLiveEndSessionPayload? Type219 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.WebhookLiveEndSessionPayloadEvent? Type220 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.FileControllerUploadV2Request? Type221 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.FileControllerUploadV2Request2? Type222 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.AudioToTextControllerAudioTranscriptionRequest? Type223 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.AudioToTextControllerAudioTranscriptionRequestLanguageBehaviour? Type224 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.AudioToTextControllerAudioTranscriptionRequestLanguage? Type225 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.AudioToTextControllerAudioTranscriptionRequestTargetTranslationLanguage? Type226 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.AudioToTextControllerAudioTranscriptionRequestOutputFormat? Type227 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.VideoToTextControllerVideoTranscriptionRequest? Type228 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.VideoToTextControllerVideoTranscriptionRequestLanguageBehaviour? Type229 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.VideoToTextControllerVideoTranscriptionRequestLanguage? Type230 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.VideoToTextControllerVideoTranscriptionRequestTargetTranslationLanguage? Type231 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.VideoToTextControllerVideoTranscriptionRequestOutputFormat? Type232 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Gladia.PreRecordedControllerGetPreRecordedJobsV2Statu>? Type233 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.PreRecordedControllerGetPreRecordedJobsV2Statu? Type234 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Gladia.TranscriptionControllerListV2Statu>? Type235 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.TranscriptionControllerListV2Statu? Type236 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Gladia.TranscriptionControllerListV2KindItem>? Type237 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.TranscriptionControllerListV2KindItem? Type238 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Gladia.HistoryControllerGetListV1Statu>? Type239 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.HistoryControllerGetListV1Statu? Type240 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Gladia.HistoryControllerGetListV1KindItem>? Type241 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.HistoryControllerGetListV1KindItem? Type242 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Gladia.StreamingControllerGetStreamingJobsV2Statu>? Type243 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.StreamingControllerGetStreamingJobsV2Statu? Type244 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.TranscriptionControllerGetTranscriptV2Response? Type245 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.TranscriptionControllerGetTranscriptV2ResponseDiscriminator? Type246 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.TranscriptionControllerGetTranscriptV2ResponseDiscriminatorKind? Type247 { get; set; }

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
        public global::System.Collections.Generic.List<global::Gladia.PreRecordedResponse>? ListType14 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Gladia.OneOf<global::Gladia.PreRecordedResponse, global::Gladia.StreamingResponse>>? ListType15 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<long>? ListType16 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<double>? ListType17 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Gladia.ChapterizationSentence>? ListType18 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Gladia.PostChapterizationResult>? ListType19 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Gladia.SentimentAnalysisResult>? ListType20 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Gladia.StreamingResponse>? ListType21 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Gladia.PreRecordedControllerGetPreRecordedJobsV2Statu>? ListType22 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Gladia.TranscriptionControllerListV2Statu>? ListType23 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Gladia.TranscriptionControllerListV2KindItem>? ListType24 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Gladia.HistoryControllerGetListV1Statu>? ListType25 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Gladia.HistoryControllerGetListV1KindItem>? ListType26 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Gladia.StreamingControllerGetStreamingJobsV2Statu>? ListType27 { get; set; }
    }
}