
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Magic Hour provides an API (beta) that can be integrated into your own application to generate videos and images using AI. <br/>
    /// Webhook documentation can be found [here](https://magichour.ai/docs/webhook).<br/>
    /// If you have any questions, please reach out to us via [discord](https://discord.gg/JX5rgsZaJp).<br/>
    /// # Authentication<br/>
    /// Every request requires an API key.<br/>
    /// To get started, first generate your API key [here](https://magichour.ai/settings/developer).<br/>
    /// Then, add the `Authorization` header to the request.<br/>
    /// | Key | Value |<br/>
    /// |-|-|<br/>
    /// | Authorization | Bearer mhk_live_apikey |<br/>
    /// &gt; **Warning**: any API call that renders a video will utilize credits in your account.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IMagicHourClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::MagicHour.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }
        /// <summary>
        /// Client-wide request defaults such as headers, query parameters, retries, and timeout.
        /// </summary>
        public global::MagicHour.AutoSDKClientOptions Options { get; }


        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// API related to audio projects.
        /// </summary>
        public AudioProjectsClient AudioProjects { get; }

        /// <summary>
        /// API related to uploading assets used for video generation.
        /// </summary>
        public FilesClient Files { get; }

        /// <summary>
        /// API related to image projects.
        /// </summary>
        public ImageProjectsClient ImageProjects { get; }

        /// <summary>
        /// API related to video projects.
        /// </summary>
        public VideoProjectsClient VideoProjects { get; }

    }
}