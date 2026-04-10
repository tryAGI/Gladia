#nullable enable

namespace Gladia
{
    public partial interface IPreRecordedV2Client
    {
        /// <summary>
        /// Delete the pre recorded job
        /// </summary>
        /// <param name="id">
        /// Example: 45463597-20b7-4af7-b3b3-f5fb778203ab
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gladia.ApiException"></exception>
        global::System.Threading.Tasks.Task PreRecordedControllerDeletePreRecordedJobV2Async(
            string id,
            global::Gladia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}