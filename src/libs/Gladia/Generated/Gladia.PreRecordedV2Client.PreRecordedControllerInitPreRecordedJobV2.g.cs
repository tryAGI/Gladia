
#nullable enable

namespace Gladia
{
    public partial class PreRecordedV2Client
    {
        partial void PreparePreRecordedControllerInitPreRecordedJobV2Arguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Gladia.InitTranscriptionRequest request);
        partial void PreparePreRecordedControllerInitPreRecordedJobV2Request(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Gladia.InitTranscriptionRequest request);
        partial void ProcessPreRecordedControllerInitPreRecordedJobV2Response(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPreRecordedControllerInitPreRecordedJobV2ResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Initiate a new pre recorded job
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gladia.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Gladia.InitPreRecordedTranscriptionResponse> PreRecordedControllerInitPreRecordedJobV2Async(

            global::Gladia.InitTranscriptionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PreparePreRecordedControllerInitPreRecordedJobV2Arguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::Gladia.PathBuilder(
                path: "/v2/pre-recorded",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PreparePreRecordedControllerInitPreRecordedJobV2Request(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessPreRecordedControllerInitPreRecordedJobV2Response(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Something is wrong with the request
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::Gladia.BadRequestErrorResponse? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::Gladia.BadRequestErrorResponse.FromJson(__content_400, JsonSerializerContext);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::Gladia.BadRequestErrorResponse.FromJson(__content_400, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::Gladia.ApiException<global::Gladia.BadRequestErrorResponse>(
                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_400,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_400,
                    ResponseObject = __value_400,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // You don't have the permissions to initiate a new pre recorded job
            if ((int)__response.StatusCode == 401)
            {
                string? __content_401 = null;
                global::System.Exception? __exception_401 = null;
                global::Gladia.UnauthorizedErrorResponse? __value_401 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_401 = global::Gladia.UnauthorizedErrorResponse.FromJson(__content_401, JsonSerializerContext);
                    }
                    else
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_401 = global::Gladia.UnauthorizedErrorResponse.FromJson(__content_401, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_401 = __ex;
                }

                throw new global::Gladia.ApiException<global::Gladia.UnauthorizedErrorResponse>(
                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_401,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_401,
                    ResponseObject = __value_401,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // The parameters you gave are incorrect
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::System.Exception? __exception_422 = null;
                global::Gladia.UnprocessableEntityErrorResponse? __value_422 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = global::Gladia.UnprocessableEntityErrorResponse.FromJson(__content_422, JsonSerializerContext);
                    }
                    else
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_422 = global::Gladia.UnprocessableEntityErrorResponse.FromJson(__content_422, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_422 = __ex;
                }

                throw new global::Gladia.ApiException<global::Gladia.UnprocessableEntityErrorResponse>(
                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_422,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_422,
                    ResponseObject = __value_422,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessPreRecordedControllerInitPreRecordedJobV2ResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Gladia.InitPreRecordedTranscriptionResponse.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::Gladia.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();

                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::Gladia.InitPreRecordedTranscriptionResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::Gladia.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }

        /// <summary>
        /// Initiate a new pre recorded job
        /// </summary>
        /// <param name="customVocabulary">
        /// **[Beta]** Can be either boolean to enable custom_vocabulary for this audio or an array with specific vocabulary list to feed the transcription model with<br/>
        /// Default Value: false
        /// </param>
        /// <param name="customVocabularyConfig">
        /// **[Beta]** Custom vocabulary configuration, if `custom_vocabulary` is enabled
        /// </param>
        /// <param name="callback">
        /// Enable callback for this transcription. If true, the `callback_config` property will be used to customize the callback behaviour<br/>
        /// Default Value: false
        /// </param>
        /// <param name="callbackConfig">
        /// Customize the callback behaviour (url and http method)
        /// </param>
        /// <param name="subtitles">
        /// Enable subtitles generation for this transcription<br/>
        /// Default Value: false
        /// </param>
        /// <param name="subtitlesConfig">
        /// Configuration for subtitles generation if `subtitles` is enabled
        /// </param>
        /// <param name="diarization">
        /// Enable speaker recognition (diarization) for this audio<br/>
        /// Default Value: false
        /// </param>
        /// <param name="diarizationConfig">
        /// Speaker recognition configuration, if `diarization` is enabled
        /// </param>
        /// <param name="translation">
        /// **[Beta]** Enable translation for this audio<br/>
        /// Default Value: false
        /// </param>
        /// <param name="translationConfig">
        /// **[Beta]** Translation configuration, if `translation` is enabled
        /// </param>
        /// <param name="summarization">
        /// **[Beta]** Enable summarization for this audio<br/>
        /// Default Value: false
        /// </param>
        /// <param name="summarizationConfig">
        /// **[Beta]** Summarization configuration, if `summarization` is enabled
        /// </param>
        /// <param name="moderation">
        /// **[Alpha]** Enable moderation for this audio<br/>
        /// Default Value: false
        /// </param>
        /// <param name="namedEntityRecognition">
        /// **[Alpha]** Enable named entity recognition for this audio<br/>
        /// Default Value: false
        /// </param>
        /// <param name="chapterization">
        /// **[Alpha]** Enable chapterization for this audio<br/>
        /// Default Value: false
        /// </param>
        /// <param name="nameConsistency">
        /// **[Alpha]** Enable names consistency for this audio<br/>
        /// Default Value: false
        /// </param>
        /// <param name="customSpelling">
        /// **[Alpha]** Enable custom spelling for this audio<br/>
        /// Default Value: false
        /// </param>
        /// <param name="customSpellingConfig">
        /// **[Alpha]** Custom spelling configuration, if `custom_spelling` is enabled
        /// </param>
        /// <param name="structuredDataExtraction">
        /// **[Alpha]** Enable structured data extraction for this audio<br/>
        /// Default Value: false
        /// </param>
        /// <param name="structuredDataExtractionConfig">
        /// **[Alpha]** Structured data extraction configuration, if `structured_data_extraction` is enabled
        /// </param>
        /// <param name="sentimentAnalysis">
        /// Enable sentiment analysis for this audio<br/>
        /// Default Value: false
        /// </param>
        /// <param name="audioToLlm">
        /// **[Alpha]** Enable audio to llm processing for this audio<br/>
        /// Default Value: false
        /// </param>
        /// <param name="audioToLlmConfig">
        /// **[Alpha]** Audio to llm configuration, if `audio_to_llm` is enabled
        /// </param>
        /// <param name="piiRedaction">
        /// Enable PII redaction for this audio<br/>
        /// Default Value: false
        /// </param>
        /// <param name="piiRedactionConfig">
        /// PII redaction configuration, if `pii_redaction` is enabled
        /// </param>
        /// <param name="customMetadata">
        /// Custom metadata you can attach to this transcription<br/>
        /// Example: {"user":"John Doe"}
        /// </param>
        /// <param name="sentences">
        /// Enable sentences for this audio<br/>
        /// Default Value: false
        /// </param>
        /// <param name="displayMode">
        /// **[Alpha]** Allows to change the output display_mode for this audio. The output will be reordered, creating new utterances when speakers overlapped<br/>
        /// Default Value: false
        /// </param>
        /// <param name="punctuationEnhanced">
        /// **[Alpha]** Use enhanced punctuation for this audio<br/>
        /// Default Value: false
        /// </param>
        /// <param name="languageConfig">
        /// Specify the language configuration
        /// </param>
        /// <param name="audioUrl">
        /// URL to a Gladia file or to an external audio or video file<br/>
        /// Example: http://files.gladia.io/example/audio-transcription/split_infinity.wav
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Gladia.InitPreRecordedTranscriptionResponse> PreRecordedControllerInitPreRecordedJobV2Async(
            string audioUrl,
            bool? customVocabulary = default,
            global::Gladia.CustomVocabularyConfigDTO? customVocabularyConfig = default,
            bool? callback = default,
            global::Gladia.CallbackConfigDto? callbackConfig = default,
            bool? subtitles = default,
            global::Gladia.SubtitlesConfigDTO? subtitlesConfig = default,
            bool? diarization = default,
            global::Gladia.DiarizationConfigDTO? diarizationConfig = default,
            bool? translation = default,
            global::Gladia.TranslationConfigDTO? translationConfig = default,
            bool? summarization = default,
            global::Gladia.SummarizationConfigDTO? summarizationConfig = default,
            bool? moderation = default,
            bool? namedEntityRecognition = default,
            bool? chapterization = default,
            bool? nameConsistency = default,
            bool? customSpelling = default,
            global::Gladia.CustomSpellingConfigDTO? customSpellingConfig = default,
            bool? structuredDataExtraction = default,
            global::Gladia.StructuredDataExtractionConfigDTO? structuredDataExtractionConfig = default,
            bool? sentimentAnalysis = default,
            bool? audioToLlm = default,
            global::Gladia.AudioToLlmListConfigDTO? audioToLlmConfig = default,
            bool? piiRedaction = default,
            global::Gladia.PiiRedactionConfigDTO? piiRedactionConfig = default,
            object? customMetadata = default,
            bool? sentences = default,
            bool? displayMode = default,
            bool? punctuationEnhanced = default,
            global::Gladia.LanguageConfig? languageConfig = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Gladia.InitTranscriptionRequest
            {
                CustomVocabulary = customVocabulary,
                CustomVocabularyConfig = customVocabularyConfig,
                Callback = callback,
                CallbackConfig = callbackConfig,
                Subtitles = subtitles,
                SubtitlesConfig = subtitlesConfig,
                Diarization = diarization,
                DiarizationConfig = diarizationConfig,
                Translation = translation,
                TranslationConfig = translationConfig,
                Summarization = summarization,
                SummarizationConfig = summarizationConfig,
                Moderation = moderation,
                NamedEntityRecognition = namedEntityRecognition,
                Chapterization = chapterization,
                NameConsistency = nameConsistency,
                CustomSpelling = customSpelling,
                CustomSpellingConfig = customSpellingConfig,
                StructuredDataExtraction = structuredDataExtraction,
                StructuredDataExtractionConfig = structuredDataExtractionConfig,
                SentimentAnalysis = sentimentAnalysis,
                AudioToLlm = audioToLlm,
                AudioToLlmConfig = audioToLlmConfig,
                PiiRedaction = piiRedaction,
                PiiRedactionConfig = piiRedactionConfig,
                CustomMetadata = customMetadata,
                Sentences = sentences,
                DisplayMode = displayMode,
                PunctuationEnhanced = punctuationEnhanced,
                LanguageConfig = languageConfig,
                AudioUrl = audioUrl,
            };

            return await PreRecordedControllerInitPreRecordedJobV2Async(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}