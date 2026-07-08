
#nullable enable

namespace Gladia
{
    public partial class JobHistoryClient
    {


        private static readonly global::Gladia.EndPointSecurityRequirement s_HistoryControllerGetListV1SecurityRequirement0 =
            new global::Gladia.EndPointSecurityRequirement
            {
                Authorizations = new global::Gladia.EndPointAuthorizationRequirement[]
                {                    new global::Gladia.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        SchemeId = "ApikeyXGladiaKey",
                        Location = "Header",
                        Name = "x-gladia-key",
                        FriendlyName = "ApiKeyInHeader",
                    },
                },
            };
        private static readonly global::Gladia.EndPointSecurityRequirement[] s_HistoryControllerGetListV1SecurityRequirements =
            new global::Gladia.EndPointSecurityRequirement[]
            {                s_HistoryControllerGetListV1SecurityRequirement0,
            };
        partial void PrepareHistoryControllerGetListV1Arguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? offset,
            ref int? limit,
            ref global::System.DateTime? date,
            ref global::System.DateTime? beforeDate,
            ref global::System.DateTime? afterDate,
            global::System.Collections.Generic.IList<global::Gladia.HistoryControllerGetListV1Statu>? status,
            object? customMetadata,
            global::System.Collections.Generic.IList<global::Gladia.HistoryControllerGetListV1KindItem>? kind);
        partial void PrepareHistoryControllerGetListV1Request(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? offset,
            int? limit,
            global::System.DateTime? date,
            global::System.DateTime? beforeDate,
            global::System.DateTime? afterDate,
            global::System.Collections.Generic.IList<global::Gladia.HistoryControllerGetListV1Statu>? status,
            object? customMetadata,
            global::System.Collections.Generic.IList<global::Gladia.HistoryControllerGetListV1KindItem>? kind);
        partial void ProcessHistoryControllerGetListV1Response(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessHistoryControllerGetListV1ResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get the history of all your jobs
        /// </summary>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="date">
        /// Example: 2026-07-08
        /// </param>
        /// <param name="beforeDate">
        /// Example: 2024-01-01T00:00:00.000Z
        /// </param>
        /// <param name="afterDate">
        /// Example: 2024-01-01T00:00:00.000Z
        /// </param>
        /// <param name="status">
        /// Example: [done]
        /// </param>
        /// <param name="customMetadata">
        /// Example: {"user":"John Doe"}
        /// </param>
        /// <param name="kind">
        /// Example: [pre-recorded]
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gladia.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Gladia.ListHistoryResponse> HistoryControllerGetListV1Async(
            int? offset = default,
            int? limit = default,
            global::System.DateTime? date = default,
            global::System.DateTime? beforeDate = default,
            global::System.DateTime? afterDate = default,
            global::System.Collections.Generic.IList<global::Gladia.HistoryControllerGetListV1Statu>? status = default,
            object? customMetadata = default,
            global::System.Collections.Generic.IList<global::Gladia.HistoryControllerGetListV1KindItem>? kind = default,
            global::Gladia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await HistoryControllerGetListV1AsResponseAsync(
                offset: offset,
                limit: limit,
                date: date,
                beforeDate: beforeDate,
                afterDate: afterDate,
                status: status,
                customMetadata: customMetadata,
                kind: kind,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Get the history of all your jobs
        /// </summary>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="date">
        /// Example: 2026-07-08
        /// </param>
        /// <param name="beforeDate">
        /// Example: 2024-01-01T00:00:00.000Z
        /// </param>
        /// <param name="afterDate">
        /// Example: 2024-01-01T00:00:00.000Z
        /// </param>
        /// <param name="status">
        /// Example: [done]
        /// </param>
        /// <param name="customMetadata">
        /// Example: {"user":"John Doe"}
        /// </param>
        /// <param name="kind">
        /// Example: [pre-recorded]
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gladia.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Gladia.AutoSDKHttpResponse<global::Gladia.ListHistoryResponse>> HistoryControllerGetListV1AsResponseAsync(
            int? offset = default,
            int? limit = default,
            global::System.DateTime? date = default,
            global::System.DateTime? beforeDate = default,
            global::System.DateTime? afterDate = default,
            global::System.Collections.Generic.IList<global::Gladia.HistoryControllerGetListV1Statu>? status = default,
            object? customMetadata = default,
            global::System.Collections.Generic.IList<global::Gladia.HistoryControllerGetListV1KindItem>? kind = default,
            global::Gladia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareHistoryControllerGetListV1Arguments(
                httpClient: HttpClient,
                offset: ref offset,
                limit: ref limit,
                date: ref date,
                beforeDate: ref beforeDate,
                afterDate: ref afterDate,
                status: status,
                customMetadata: customMetadata,
                kind: kind);


            var __authorizations = global::Gladia.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_HistoryControllerGetListV1SecurityRequirements,
                operationName: "HistoryControllerGetListV1Async");

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
                                path: "/v1/history",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddOptionalParameter("offset", offset?.ToString())
                                .AddOptionalParameter("limit", limit?.ToString())
                                .AddOptionalParameter("date", date?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                                .AddOptionalParameter("before_date", beforeDate?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                                .AddOptionalParameter("after_date", afterDate?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                                .AddOptionalParameter("status", status, selector: static x => x.ToValueString(), delimiter: ",", explode: true)
                                .AddOptionalParameter("custom_metadata", customMetadata?.ToString())
                                .AddOptionalParameter("kind", kind, selector: static x => x.ToValueString(), delimiter: ",", explode: true)
                                ;
                            var __path = __pathBuilder.ToString();
                __path = global::Gladia.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Get,
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
                global::Gladia.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareHistoryControllerGetListV1Request(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    offset: offset,
                    limit: limit,
                    date: date,
                    beforeDate: beforeDate,
                    afterDate: afterDate,
                    status: status,
                    customMetadata: customMetadata,
                    kind: kind);

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
                                operationId: "HistoryControllerGetListV1",
                                methodName: "HistoryControllerGetListV1Async",
                                pathTemplate: "\"/v1/history\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
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
                        var __retryDelay = global::Gladia.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Gladia.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Gladia.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "HistoryControllerGetListV1",
                                methodName: "HistoryControllerGetListV1Async",
                                pathTemplate: "\"/v1/history\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Gladia.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Gladia.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::Gladia.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::Gladia.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Gladia.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "HistoryControllerGetListV1",
                                methodName: "HistoryControllerGetListV1Async",
                                pathTemplate: "\"/v1/history\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Gladia.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
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
                ProcessHistoryControllerGetListV1Response(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Gladia.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Gladia.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "HistoryControllerGetListV1",
                                methodName: "HistoryControllerGetListV1Async",
                                pathTemplate: "\"/v1/history\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Gladia.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Gladia.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "HistoryControllerGetListV1",
                                methodName: "HistoryControllerGetListV1Async",
                                pathTemplate: "\"/v1/history\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
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
                                ProcessHistoryControllerGetListV1ResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Gladia.ListHistoryResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Gladia.AutoSDKHttpResponse<global::Gladia.ListHistoryResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Gladia.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::Gladia.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::Gladia.ListHistoryResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Gladia.AutoSDKHttpResponse<global::Gladia.ListHistoryResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Gladia.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
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

                                    throw global::Gladia.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
    }
}