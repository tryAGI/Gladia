#nullable enable

namespace Gladia
{
    public partial interface IFileManagementClient
    {
        /// <summary>
        /// Upload an audio file or provide an audio URL for processing
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gladia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Gladia.AudioUploadResponse> FileControllerUploadV2Async(

            global::Gladia.FileControllerUploadV2Request request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload an audio file or provide an audio URL for processing
        /// </summary>
        /// <param name="audio">
        /// The file to be uploaded. This should be an audio or video file.
        /// </param>
        /// <param name="audioname">
        /// The file to be uploaded. This should be an audio or video file.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Gladia.AudioUploadResponse> FileControllerUploadV2Async(
            byte[]? audio = default,
            string? audioname = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}