#nullable enable

namespace Gladia
{
    public partial interface ILiveV2Client
    {
        /// <summary>
        /// Get live jobs based on query parameters
        /// </summary>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="date">
        /// Example: 2026-03-20
        /// </param>
        /// <param name="beforeDate">
        /// Example: 2026-03-20T21:00:10.111Z
        /// </param>
        /// <param name="afterDate">
        /// Example: 2026-03-20T21:00:10.111Z
        /// </param>
        /// <param name="status">
        /// Example: [done]
        /// </param>
        /// <param name="customMetadata">
        /// Example: {"user":"John Doe"}
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gladia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Gladia.ListStreamingResponse> StreamingControllerGetStreamingJobsV2Async(
            int? offset = default,
            int? limit = default,
            global::System.DateTime? date = default,
            global::System.DateTime? beforeDate = default,
            global::System.DateTime? afterDate = default,
            global::System.Collections.Generic.IList<global::Gladia.StreamingControllerGetStreamingJobsV2Statu>? status = default,
            object? customMetadata = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}