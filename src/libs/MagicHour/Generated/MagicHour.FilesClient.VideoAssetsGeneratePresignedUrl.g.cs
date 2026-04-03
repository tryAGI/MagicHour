
#nullable enable

namespace MagicHour
{
    public partial class FilesClient
    {
        partial void PrepareVideoAssetsGeneratePresignedUrlArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::MagicHour.VideoAssetsGeneratePresignedUrlRequest request);
        partial void PrepareVideoAssetsGeneratePresignedUrlRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::MagicHour.VideoAssetsGeneratePresignedUrlRequest request);
        partial void ProcessVideoAssetsGeneratePresignedUrlResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessVideoAssetsGeneratePresignedUrlResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Generate asset upload urls<br/>
        /// Generates a list of pre-signed upload URLs for the assets required. This API is only necessary if you want to upload to Magic Hour's storage. Refer to the [Input Files Guide](/integration/input-files) for more details.<br/>
        /// The response array will match the order of items in the request body.<br/>
        /// **Valid file extensions per asset type**:<br/>
        /// - video: mp4, m4v, mov, webm<br/>
        /// - audio: mp3, wav, aac, flac, webm, m4a<br/>
        /// - image: png, jpg, jpeg, heic, webp, avif, jp2, tiff, bmp<br/>
        /// - gif: gif, webp, webm<br/>
        /// &gt; Note: `gif` is only supported for face swap API `video_file_path` field.<br/>
        /// Once you receive an upload URL, send a `PUT` request to upload the file directly.<br/>
        /// Example:<br/>
        /// ```<br/>
        /// curl -X PUT --data '@/path/to/file/video.mp4' \<br/>
        ///   https://videos.magichour.ai/api-assets/id/video.mp4?&lt;auth params from the API response&gt;<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MagicHour.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///      --url https://api.magichour.ai/v1/files/upload-urls \<br/>
        ///      --header 'accept: application/json' \<br/>
        ///      --header 'authorization: Bearer &lt;token&gt;' \<br/>
        ///      --header 'content-type: application/json' \<br/>
        ///      --data '<br/>
        /// {<br/>
        ///   "items": [<br/>
        ///     {<br/>
        ///       "type": "video",<br/>
        ///       "extension": "mp4"<br/>
        ///     },<br/>
        ///     {<br/>
        ///       "type": "audio",<br/>
        ///       "extension": "mp3"<br/>
        ///     }<br/>
        ///   ]<br/>
        /// }<br/>
        /// '
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::MagicHour.VideoAssetsGeneratePresignedUrlResponse> VideoAssetsGeneratePresignedUrlAsync(

            global::MagicHour.VideoAssetsGeneratePresignedUrlRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareVideoAssetsGeneratePresignedUrlArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::MagicHour.PathBuilder(
                path: "/v1/files/upload-urls",
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
            PrepareVideoAssetsGeneratePresignedUrlRequest(
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
            ProcessVideoAssetsGeneratePresignedUrlResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Invalid Request
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::MagicHour.VideoAssetsGeneratePresignedUrlResponse2? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::MagicHour.VideoAssetsGeneratePresignedUrlResponse2.FromJson(__content_400, JsonSerializerContext);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::MagicHour.VideoAssetsGeneratePresignedUrlResponse2.FromJson(__content_400, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::MagicHour.ApiException<global::MagicHour.VideoAssetsGeneratePresignedUrlResponse2>(
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
            // Unauthorized
            if ((int)__response.StatusCode == 401)
            {
                string? __content_401 = null;
                global::System.Exception? __exception_401 = null;
                global::MagicHour.VideoAssetsGeneratePresignedUrlResponse3? __value_401 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_401 = global::MagicHour.VideoAssetsGeneratePresignedUrlResponse3.FromJson(__content_401, JsonSerializerContext);
                    }
                    else
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_401 = global::MagicHour.VideoAssetsGeneratePresignedUrlResponse3.FromJson(__content_401, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_401 = __ex;
                }

                throw new global::MagicHour.ApiException<global::MagicHour.VideoAssetsGeneratePresignedUrlResponse3>(
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
            // Payment Required
            if ((int)__response.StatusCode == 402)
            {
                string? __content_402 = null;
                global::System.Exception? __exception_402 = null;
                global::MagicHour.VideoAssetsGeneratePresignedUrlResponse4? __value_402 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_402 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_402 = global::MagicHour.VideoAssetsGeneratePresignedUrlResponse4.FromJson(__content_402, JsonSerializerContext);
                    }
                    else
                    {
                        __content_402 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_402 = global::MagicHour.VideoAssetsGeneratePresignedUrlResponse4.FromJson(__content_402, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_402 = __ex;
                }

                throw new global::MagicHour.ApiException<global::MagicHour.VideoAssetsGeneratePresignedUrlResponse4>(
                    message: __content_402 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_402,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_402,
                    ResponseObject = __value_402,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Not Found
            if ((int)__response.StatusCode == 404)
            {
                string? __content_404 = null;
                global::System.Exception? __exception_404 = null;
                global::MagicHour.VideoAssetsGeneratePresignedUrlResponse5? __value_404 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_404 = global::MagicHour.VideoAssetsGeneratePresignedUrlResponse5.FromJson(__content_404, JsonSerializerContext);
                    }
                    else
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_404 = global::MagicHour.VideoAssetsGeneratePresignedUrlResponse5.FromJson(__content_404, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_404 = __ex;
                }

                throw new global::MagicHour.ApiException<global::MagicHour.VideoAssetsGeneratePresignedUrlResponse5>(
                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_404,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_404,
                    ResponseObject = __value_404,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Unprocessable Entity
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::System.Exception? __exception_422 = null;
                global::MagicHour.VideoAssetsGeneratePresignedUrlResponse6? __value_422 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = global::MagicHour.VideoAssetsGeneratePresignedUrlResponse6.FromJson(__content_422, JsonSerializerContext);
                    }
                    else
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_422 = global::MagicHour.VideoAssetsGeneratePresignedUrlResponse6.FromJson(__content_422, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_422 = __ex;
                }

                throw new global::MagicHour.ApiException<global::MagicHour.VideoAssetsGeneratePresignedUrlResponse6>(
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
                ProcessVideoAssetsGeneratePresignedUrlResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::MagicHour.VideoAssetsGeneratePresignedUrlResponse.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::MagicHour.ApiException(
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
                        await global::MagicHour.VideoAssetsGeneratePresignedUrlResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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

                    throw new global::MagicHour.ApiException(
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
        /// Generate asset upload urls<br/>
        /// Generates a list of pre-signed upload URLs for the assets required. This API is only necessary if you want to upload to Magic Hour's storage. Refer to the [Input Files Guide](/integration/input-files) for more details.<br/>
        /// The response array will match the order of items in the request body.<br/>
        /// **Valid file extensions per asset type**:<br/>
        /// - video: mp4, m4v, mov, webm<br/>
        /// - audio: mp3, wav, aac, flac, webm, m4a<br/>
        /// - image: png, jpg, jpeg, heic, webp, avif, jp2, tiff, bmp<br/>
        /// - gif: gif, webp, webm<br/>
        /// &gt; Note: `gif` is only supported for face swap API `video_file_path` field.<br/>
        /// Once you receive an upload URL, send a `PUT` request to upload the file directly.<br/>
        /// Example:<br/>
        /// ```<br/>
        /// curl -X PUT --data '@/path/to/file/video.mp4' \<br/>
        ///   https://videos.magichour.ai/api-assets/id/video.mp4?&lt;auth params from the API response&gt;<br/>
        /// ```
        /// </summary>
        /// <param name="items">
        /// The list of assets to upload. The response array will match the order of items in the request body.<br/>
        /// Example: [{"type":"video","extension":"mp4"}, {"type":"audio","extension":"mp3"}]
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::MagicHour.VideoAssetsGeneratePresignedUrlResponse> VideoAssetsGeneratePresignedUrlAsync(
            global::System.Collections.Generic.IList<global::MagicHour.VideoAssetsGeneratePresignedUrlRequestItem> items,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::MagicHour.VideoAssetsGeneratePresignedUrlRequest
            {
                Items = items,
            };

            return await VideoAssetsGeneratePresignedUrlAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}