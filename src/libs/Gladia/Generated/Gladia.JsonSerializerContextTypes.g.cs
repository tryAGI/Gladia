
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
        public object? Type0 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.AudioUploadMetadataDTO? Type1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Guid? Type2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? Type3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? Type4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Type5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.AudioUploadResponse? Type6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.PreRecordedEventPayload? Type7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.LiveEventPayload? Type8 { get; set; }
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
        public global::Gladia.InitPreRecordedTranscriptionResponse? Type40 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.BadRequestErrorResponse? Type41 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.UnauthorizedErrorResponse? Type42 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.UnprocessableEntityErrorResponse? Type43 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.FileResponse? Type44 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.PreRecordedRequestParamsResponse? Type45 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.TranscriptionMetadataDTO? Type46 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.AddonErrorDTO? Type47 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.SentencesDTO? Type48 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.SubtitleDTO? Type49 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.WordDTO? Type50 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.UtteranceDTO? Type51 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Gladia.WordDTO>? Type52 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.TranscriptionDTO? Type53 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Gladia.SentencesDTO>? Type54 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Gladia.SubtitleDTO>? Type55 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Gladia.UtteranceDTO>? Type56 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.TranslationResultDTO? Type57 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.TranslationDTO? Type58 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Gladia.TranslationResultDTO>? Type59 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.SummarizationDTO? Type60 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.ModerationDTO? Type61 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.NamedEntityRecognitionDTO? Type62 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.NamesConsistencyDTO? Type63 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.SpeakerReidentificationDTO? Type64 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.StructuredDataExtractionDTO? Type65 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.SentimentAnalysisDTO? Type66 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.AudioToLlmResultDTO? Type67 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.AudioToLlmDTO? Type68 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.AudioToLlmListDTO? Type69 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Gladia.AudioToLlmDTO>? Type70 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.DisplayModeDTO? Type71 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.ChapterizationDTO? Type72 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.DiarizationDTO? Type73 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.TranscriptionResultDTO? Type74 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.PreRecordedResponse? Type75 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.PreRecordedResponseStatus? Type76 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.DateTime? Type77 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.PreRecordedResponseKind? Type78 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.NotFoundErrorResponse? Type79 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.ListPreRecordedResponse? Type80 { get; set; }
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
        public global::Gladia.NamedEntityRecognitionResult? Type136 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.NamedEntityRecognitionData? Type137 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Gladia.NamedEntityRecognitionResult>? Type138 { get; set; }
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
        public global::Gladia.PayloadTooLargeErrorResponse? Type205 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.WebhookTranscriptionCreatedPayload? Type206 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.WebhookTranscriptionCreatedPayloadEvent? Type207 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.WebhookTranscriptionSuccessPayload? Type208 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.WebhookTranscriptionSuccessPayloadEvent? Type209 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.WebhookTranscriptionErrorPayload? Type210 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.WebhookTranscriptionErrorPayloadEvent? Type211 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.WebhookLiveStartSessionPayload? Type212 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.WebhookLiveStartSessionPayloadEvent? Type213 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.WebhookLiveStartRecordingPayload? Type214 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.WebhookLiveStartRecordingPayloadEvent? Type215 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.WebhookLiveEndRecordingPayload? Type216 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.WebhookLiveEndRecordingPayloadEvent? Type217 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.WebhookLiveEndSessionPayload? Type218 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.WebhookLiveEndSessionPayloadEvent? Type219 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.FileControllerUploadV2Request? Type220 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.FileControllerUploadV2Request2? Type221 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.AudioToTextControllerAudioTranscriptionRequest? Type222 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.AudioToTextControllerAudioTranscriptionRequestLanguageBehaviour? Type223 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.AudioToTextControllerAudioTranscriptionRequestLanguage? Type224 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.AudioToTextControllerAudioTranscriptionRequestTargetTranslationLanguage? Type225 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.AudioToTextControllerAudioTranscriptionRequestOutputFormat? Type226 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.VideoToTextControllerVideoTranscriptionRequest? Type227 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.VideoToTextControllerVideoTranscriptionRequestLanguageBehaviour? Type228 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.VideoToTextControllerVideoTranscriptionRequestLanguage? Type229 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.VideoToTextControllerVideoTranscriptionRequestTargetTranslationLanguage? Type230 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.VideoToTextControllerVideoTranscriptionRequestOutputFormat? Type231 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Gladia.PreRecordedControllerGetPreRecordedJobsV2Statu>? Type232 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.PreRecordedControllerGetPreRecordedJobsV2Statu? Type233 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Gladia.TranscriptionControllerListV2Statu>? Type234 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.TranscriptionControllerListV2Statu? Type235 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Gladia.TranscriptionControllerListV2KindItem>? Type236 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.TranscriptionControllerListV2KindItem? Type237 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Gladia.HistoryControllerGetListV1Statu>? Type238 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.HistoryControllerGetListV1Statu? Type239 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Gladia.HistoryControllerGetListV1KindItem>? Type240 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.HistoryControllerGetListV1KindItem? Type241 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Gladia.StreamingControllerGetStreamingJobsV2Statu>? Type242 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.StreamingControllerGetStreamingJobsV2Statu? Type243 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.TranscriptionControllerGetTranscriptV2Response? Type244 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.TranscriptionControllerGetTranscriptV2ResponseDiscriminator? Type245 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.TranscriptionControllerGetTranscriptV2ResponseDiscriminatorKind? Type246 { get; set; }

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
        public global::System.Collections.Generic.List<global::Gladia.AudioToLlmDTO>? ListType12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Gladia.PreRecordedResponse>? ListType13 { get; set; }
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
        public global::System.Collections.Generic.List<global::Gladia.NamedEntityRecognitionResult>? ListType17 { get; set; }
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