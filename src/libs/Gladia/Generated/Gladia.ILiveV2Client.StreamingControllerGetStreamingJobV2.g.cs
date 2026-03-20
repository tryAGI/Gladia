#nullable enable

namespace Gladia
{
    public partial interface ILiveV2Client
    {

        /// <summary>
        /// Get the live job's metadata
        /// </summary>
        /// <param name="id">
        /// Example: 45463597-20b7-4af7-b3b3-f5fb778203ab
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gladia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Gladia.StreamingResponse> StreamingControllerGetStreamingJobV2Async(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}