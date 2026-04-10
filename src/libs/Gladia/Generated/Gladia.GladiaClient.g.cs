
#nullable enable

namespace Gladia
{
    /// <summary>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class GladiaClient : global::Gladia.IGladiaClient, global::System.IDisposable
    {
        /// <summary>
        /// Gladia API production URL
        /// </summary>
        public const string DefaultBaseUrl = "https://api.gladia.io/";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public System.Uri? BaseUri => HttpClient.BaseAddress;

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::Gladia.EndPointAuthorization> Authorizations { get; }

        /// <inheritdoc/>
        public bool ReadResponseAsString { get; set; }
#if DEBUG
            = true;
#endif

        /// <inheritdoc/>
        public global::Gladia.AutoSDKClientOptions Options { get; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; } = global::Gladia.SourceGenerationContext.Default;


        /// <summary>
        /// 
        /// </summary>
        public AudioToTextClient AudioToText => new AudioToTextClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public FileManagementClient FileManagement => new FileManagementClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public JobHistoryClient JobHistory => new JobHistoryClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public LiveV2Client LiveV2 => new LiveV2Client(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public PreRecordedV2Client PreRecordedV2 => new PreRecordedV2Client(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public TranscriptionV1Client TranscriptionV1 => new TranscriptionV1Client(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public TranscriptionV2Client TranscriptionV2 => new TranscriptionV2Client(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Creates a new instance of the GladiaClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public GladiaClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::Gladia.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true) : this(
                httpClient,
                baseUri,
                authorizations,
                options: null,
                disposeHttpClient: disposeHttpClient)
        {
        }

        /// <summary>
        /// Creates a new instance of the GladiaClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="options">Client-wide request defaults such as headers, query parameters, retries, and timeout.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public GladiaClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::Gladia.EndPointAuthorization>? authorizations = null,
            global::Gladia.AutoSDKClientOptions? options = null,
            bool disposeHttpClient = true)
        {

            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::Gladia.EndPointAuthorization>();
            Options = options ?? new global::Gladia.AutoSDKClientOptions();
            _disposeHttpClient = disposeHttpClient;

            Initialized(HttpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (_disposeHttpClient)
            {
                HttpClient.Dispose();
            }
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }
}