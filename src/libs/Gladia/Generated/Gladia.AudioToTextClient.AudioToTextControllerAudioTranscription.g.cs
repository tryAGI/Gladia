
#nullable enable

namespace Gladia
{
    public partial class AudioToTextClient
    {


        private static readonly global::Gladia.EndPointSecurityRequirement s_AudioToTextControllerAudioTranscriptionSecurityRequirement0 =
            new global::Gladia.EndPointSecurityRequirement
            {
                Authorizations = new global::Gladia.EndPointAuthorizationRequirement[]
                {                    new global::Gladia.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "HttpBearer",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Gladia.EndPointSecurityRequirement[] s_AudioToTextControllerAudioTranscriptionSecurityRequirements =
            new global::Gladia.EndPointSecurityRequirement[]
            {                s_AudioToTextControllerAudioTranscriptionSecurityRequirement0,
            };
        partial void PrepareAudioToTextControllerAudioTranscriptionArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Gladia.AudioToTextControllerAudioTranscriptionRequest request);
        partial void PrepareAudioToTextControllerAudioTranscriptionRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Gladia.AudioToTextControllerAudioTranscriptionRequest request);
        partial void ProcessAudioToTextControllerAudioTranscriptionResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gladia.ApiException"></exception>
        public async global::System.Threading.Tasks.Task AudioToTextControllerAudioTranscriptionAsync(

            global::Gladia.AudioToTextControllerAudioTranscriptionRequest request,
            global::Gladia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareAudioToTextControllerAudioTranscriptionArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::Gladia.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_AudioToTextControllerAudioTranscriptionSecurityRequirements,
                operationName: "AudioToTextControllerAudioTranscriptionAsync");

            using var __timeoutCancellationTokenSource = global::Gladia.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Gladia.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Gladia.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {
                            var __pathBuilder = new global::Gladia.PathBuilder(
                                path: "/audio/text/audio-transcription",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::Gladia.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
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
                            var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
                            if (request.Audio != default)
                            {

                                var __contentAudio = new global::System.Net.Http.ByteArrayContent(request.Audio ?? global::System.Array.Empty<byte>());
                                __httpRequestContent.Add(
                                    content: __contentAudio,
                                    name: "\"audio\"",
                                    fileName: request.Audioname != null ? $"\"{request.Audioname}\"" : string.Empty);
                                if (__contentAudio.Headers.ContentDisposition != null)
                                {
                                    __contentAudio.Headers.ContentDisposition.FileNameStar = null;
                                }
                            } 
                            if (request.AudioUrl != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent($"{request.AudioUrl}"),
                                    name: "\"audio_url\"");
                            } 
                            if (request.LanguageBehaviour != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent($"{request.LanguageBehaviour?.ToValueString()}"),
                                    name: "\"language_behaviour\"");
                            } 
                            if (request.Language != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent($"{request.Language?.ToValueString()}"),
                                    name: "\"language\"");
                            } 
                            if (request.TranscriptionHint != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent($"{request.TranscriptionHint}"),
                                    name: "\"transcription_hint\"");
                            } 
                            if (request.ToggleDiarization != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent($"{request.ToggleDiarization}"),
                                    name: "\"toggle_diarization\"");
                            } 
                            if (request.DiarizationNumSpeakers != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent($"{request.DiarizationNumSpeakers}"),
                                    name: "\"diarization_num_speakers\"");
                            } 
                            if (request.DiarizationMinSpeakers != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent($"{request.DiarizationMinSpeakers}"),
                                    name: "\"diarization_min_speakers\"");
                            } 
                            if (request.DiarizationMaxSpeakers != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent($"{request.DiarizationMaxSpeakers}"),
                                    name: "\"diarization_max_speakers\"");
                            } 
                            if (request.ToggleDirectTranslate != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent($"{request.ToggleDirectTranslate}"),
                                    name: "\"toggle_direct_translate\"");
                            } 
                            if (request.TargetTranslationLanguage != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent($"{request.TargetTranslationLanguage?.ToValueString()}"),
                                    name: "\"target_translation_language\"");
                            } 
                            if (request.OutputFormat != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent($"{request.OutputFormat?.ToValueString()}"),
                                    name: "\"output_format\"");
                            } 
                            if (request.ToggleNoiseReduction != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent($"{request.ToggleNoiseReduction}"),
                                    name: "\"toggle_noise_reduction\"");
                            } 
                            if (request.ToggleAccurateWordsTimestamps != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent($"{request.ToggleAccurateWordsTimestamps}"),
                                    name: "\"toggle_accurate_words_timestamps\"");
                            } 
                            if (request.WebhookUrl != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent($"{request.WebhookUrl}"),
                                    name: "\"webhook_url\"");
                            }
                            __httpRequest.Content = __httpRequestContent;
                global::Gladia.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareAudioToTextControllerAudioTranscriptionRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::Gladia.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Gladia.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "AudioToTextControllerAudioTranscription",
                                methodName: "AudioToTextControllerAudioTranscriptionAsync",
                                pathTemplate: "\"/audio/text/audio-transcription\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Gladia.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Gladia.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "AudioToTextControllerAudioTranscription",
                                methodName: "AudioToTextControllerAudioTranscriptionAsync",
                                pathTemplate: "\"/audio/text/audio-transcription\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Gladia.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Gladia.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        await global::Gladia.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Gladia.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "AudioToTextControllerAudioTranscription",
                                methodName: "AudioToTextControllerAudioTranscriptionAsync",
                                pathTemplate: "\"/audio/text/audio-transcription\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Gladia.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessAudioToTextControllerAudioTranscriptionResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Gladia.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Gladia.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "AudioToTextControllerAudioTranscription",
                                methodName: "AudioToTextControllerAudioTranscriptionAsync",
                                pathTemplate: "\"/audio/text/audio-transcription\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Gladia.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Gladia.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "AudioToTextControllerAudioTranscription",
                                methodName: "AudioToTextControllerAudioTranscriptionAsync",
                                pathTemplate: "\"/audio/text/audio-transcription\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

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
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
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
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="audio"></param>
        /// <param name="audioname"></param>
        /// <param name="audioUrl">
        /// Default Value: http://files.gladia.io/example/audio-transcription/split_infinity.wav
        /// </param>
        /// <param name="languageBehaviour">
        /// Default Value: automatic single language
        /// </param>
        /// <param name="language"></param>
        /// <param name="transcriptionHint"></param>
        /// <param name="toggleDiarization">
        /// Default Value: false
        /// </param>
        /// <param name="diarizationNumSpeakers"></param>
        /// <param name="diarizationMinSpeakers"></param>
        /// <param name="diarizationMaxSpeakers"></param>
        /// <param name="toggleDirectTranslate">
        /// Default Value: false
        /// </param>
        /// <param name="targetTranslationLanguage"></param>
        /// <param name="outputFormat">
        /// Default Value: json
        /// </param>
        /// <param name="toggleNoiseReduction">
        /// Default Value: false
        /// </param>
        /// <param name="toggleAccurateWordsTimestamps">
        /// Default Value: false
        /// </param>
        /// <param name="webhookUrl"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task AudioToTextControllerAudioTranscriptionAsync(
            byte[]? audio = default,
            string? audioname = default,
            string? audioUrl = default,
            global::Gladia.AudioToTextControllerAudioTranscriptionRequestLanguageBehaviour? languageBehaviour = default,
            global::Gladia.AudioToTextControllerAudioTranscriptionRequestLanguage? language = default,
            string? transcriptionHint = default,
            bool? toggleDiarization = default,
            int? diarizationNumSpeakers = default,
            int? diarizationMinSpeakers = default,
            int? diarizationMaxSpeakers = default,
            bool? toggleDirectTranslate = default,
            global::Gladia.AudioToTextControllerAudioTranscriptionRequestTargetTranslationLanguage? targetTranslationLanguage = default,
            global::Gladia.AudioToTextControllerAudioTranscriptionRequestOutputFormat? outputFormat = default,
            bool? toggleNoiseReduction = default,
            bool? toggleAccurateWordsTimestamps = default,
            string? webhookUrl = default,
            global::Gladia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Gladia.AudioToTextControllerAudioTranscriptionRequest
            {
                Audio = audio,
                Audioname = audioname,
                AudioUrl = audioUrl,
                LanguageBehaviour = languageBehaviour,
                Language = language,
                TranscriptionHint = transcriptionHint,
                ToggleDiarization = toggleDiarization,
                DiarizationNumSpeakers = diarizationNumSpeakers,
                DiarizationMinSpeakers = diarizationMinSpeakers,
                DiarizationMaxSpeakers = diarizationMaxSpeakers,
                ToggleDirectTranslate = toggleDirectTranslate,
                TargetTranslationLanguage = targetTranslationLanguage,
                OutputFormat = outputFormat,
                ToggleNoiseReduction = toggleNoiseReduction,
                ToggleAccurateWordsTimestamps = toggleAccurateWordsTimestamps,
                WebhookUrl = webhookUrl,
            };

            await AudioToTextControllerAudioTranscriptionAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}