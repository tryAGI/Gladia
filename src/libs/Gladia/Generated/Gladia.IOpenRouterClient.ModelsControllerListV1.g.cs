#nullable enable

namespace Gladia
{
    public partial interface IOpenRouterClient
    {
        /// <summary>
        /// List Gladia's available transcription models as per OpenRouter integration spec
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gladia.ApiException"></exception>
        global::System.Threading.Tasks.Task ModelsControllerListV1Async(
            global::Gladia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Gladia's available transcription models as per OpenRouter integration spec
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gladia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Gladia.AutoSDKHttpResponse> ModelsControllerListV1AsResponseAsync(
            global::Gladia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}