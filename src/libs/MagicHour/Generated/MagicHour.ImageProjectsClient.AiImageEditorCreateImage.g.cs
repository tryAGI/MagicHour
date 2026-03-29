
#nullable enable

namespace MagicHour
{
    public partial class ImageProjectsClient
    {
        partial void PrepareAiImageEditorCreateImageArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::MagicHour.AiImageEditorCreateImageRequest request);
        partial void PrepareAiImageEditorCreateImageRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::MagicHour.AiImageEditorCreateImageRequest request);
        partial void ProcessAiImageEditorCreateImageResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessAiImageEditorCreateImageResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// AI Image Editor<br/>
        /// Edit images with AI.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MagicHour.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///      --url https://api.magichour.ai/v1/ai-image-editor \<br/>
        ///      --header 'accept: application/json' \<br/>
        ///      --header 'authorization: Bearer &lt;token&gt;' \<br/>
        ///      --header 'content-type: application/json' \<br/>
        ///      --data '<br/>
        /// {<br/>
        ///   "name": "My Ai Image Editor image",<br/>
        ///   "image_count": 1,<br/>
        ///   "model": "default",<br/>
        ///   "aspect_ratio": "1:1",<br/>
        ///   "resolution": "auto",<br/>
        ///   "style": {<br/>
        ///     "prompt": "Give me sunglasses"<br/>
        ///   },<br/>
        ///   "assets": {<br/>
        ///     "image_file_paths": [<br/>
        ///       "api-assets/id/1234.png",<br/>
        ///       "api-assets/id/1235.png"<br/>
        ///     ]<br/>
        ///   }<br/>
        /// }<br/>
        /// '
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::MagicHour.AiImageEditorCreateImageResponse> AiImageEditorCreateImageAsync(

            global::MagicHour.AiImageEditorCreateImageRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareAiImageEditorCreateImageArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::MagicHour.PathBuilder(
                path: "/v1/ai-image-editor",
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
            PrepareAiImageEditorCreateImageRequest(
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
            ProcessAiImageEditorCreateImageResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Invalid Request
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::MagicHour.AiImageEditorCreateImageResponse2? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::MagicHour.AiImageEditorCreateImageResponse2.FromJson(__content_400, JsonSerializerContext);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::MagicHour.AiImageEditorCreateImageResponse2.FromJson(__content_400, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::MagicHour.ApiException<global::MagicHour.AiImageEditorCreateImageResponse2>(
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
                global::MagicHour.AiImageEditorCreateImageResponse3? __value_401 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_401 = global::MagicHour.AiImageEditorCreateImageResponse3.FromJson(__content_401, JsonSerializerContext);
                    }
                    else
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_401 = global::MagicHour.AiImageEditorCreateImageResponse3.FromJson(__content_401, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_401 = __ex;
                }

                throw new global::MagicHour.ApiException<global::MagicHour.AiImageEditorCreateImageResponse3>(
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
                global::MagicHour.AiImageEditorCreateImageResponse4? __value_402 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_402 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_402 = global::MagicHour.AiImageEditorCreateImageResponse4.FromJson(__content_402, JsonSerializerContext);
                    }
                    else
                    {
                        __content_402 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_402 = global::MagicHour.AiImageEditorCreateImageResponse4.FromJson(__content_402, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_402 = __ex;
                }

                throw new global::MagicHour.ApiException<global::MagicHour.AiImageEditorCreateImageResponse4>(
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
                global::MagicHour.AiImageEditorCreateImageResponse5? __value_404 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_404 = global::MagicHour.AiImageEditorCreateImageResponse5.FromJson(__content_404, JsonSerializerContext);
                    }
                    else
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_404 = global::MagicHour.AiImageEditorCreateImageResponse5.FromJson(__content_404, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_404 = __ex;
                }

                throw new global::MagicHour.ApiException<global::MagicHour.AiImageEditorCreateImageResponse5>(
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
                global::MagicHour.AiImageEditorCreateImageResponse6? __value_422 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = global::MagicHour.AiImageEditorCreateImageResponse6.FromJson(__content_422, JsonSerializerContext);
                    }
                    else
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_422 = global::MagicHour.AiImageEditorCreateImageResponse6.FromJson(__content_422, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_422 = __ex;
                }

                throw new global::MagicHour.ApiException<global::MagicHour.AiImageEditorCreateImageResponse6>(
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
                ProcessAiImageEditorCreateImageResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::MagicHour.AiImageEditorCreateImageResponse.FromJson(__content, JsonSerializerContext) ??
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
                        await global::MagicHour.AiImageEditorCreateImageResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// AI Image Editor<br/>
        /// Edit images with AI.
        /// </summary>
        /// <param name="name">
        /// Give your image a custom name for easy identification.<br/>
        /// Default Value: Ai Image Editor - dateTime<br/>
        /// Example: My Ai Image Editor image
        /// </param>
        /// <param name="imageCount">
        /// Number of images to generate. Maximum varies by model. Defaults to 1 if not specified.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
        /// <param name="model">
        /// The AI model to use for image editing. Each model has different capabilities and costs.<br/>
        /// **Models:**<br/>
        /// - `default` - Use the model we recommend, which will change over time. This is recommended unless you need a specific model. This is the default behavior.<br/>
        /// - `qwen-edit` - 10 credits/image<br/>
        ///   - Available for tiers: free, creator, pro, business<br/>
        ///   - Image count allowed: 1<br/>
        ///   - Max additional input images: 2<br/>
        /// - `nano-banana` - 50 credits/image<br/>
        ///   - Available for tiers: free, creator, pro, business<br/>
        ///   - Image count allowed: 1<br/>
        ///   - Max additional input images: 9<br/>
        /// - `nano-banana-2` - 100 credits/image<br/>
        ///   - Available for tiers: free, creator, pro, business<br/>
        ///   - Image count allowed: 1<br/>
        ///   - Max additional input images: 9<br/>
        /// - `seedream-v4` - 50 credits/image<br/>
        ///   - Available for tiers: free, creator, pro, business<br/>
        ///   - Image count allowed: 1<br/>
        ///   - Max additional input images: 9<br/>
        /// - `nano-banana-pro` - 150 credits/image<br/>
        ///   - Available for tiers: creator, pro, business<br/>
        ///   - Image count allowed: 1, 4, 9, 16<br/>
        ///   - Max additional input images: 9<br/>
        /// - `seedream-v4.5` - 100 credits/image<br/>
        ///   - Available for tiers: creator, pro, business<br/>
        ///   - Image count allowed: 1<br/>
        ///   - Max additional input images: 9<br/>
        /// Example: default
        /// </param>
        /// <param name="aspectRatio">
        /// The aspect ratio of the output image(s). If not specified, defaults to `auto`.<br/>
        /// Example: 1:1
        /// </param>
        /// <param name="resolution">
        /// Maximum resolution for the generated image.<br/>
        /// **Options:**<br/>
        /// - `auto` - Automatic resolution (all tiers, default)<br/>
        /// - `2k` - Up to 2048px (requires Pro or Business tier)<br/>
        /// - `4k` - Up to 4096px (requires Business tier)<br/>
        /// Note: Resolution availability depends on your subscription tier. Defaults to `auto` if not specified.<br/>
        /// Example: auto
        /// </param>
        /// <param name="style"></param>
        /// <param name="assets">
        /// Provide the assets for image edit
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::MagicHour.AiImageEditorCreateImageResponse> AiImageEditorCreateImageAsync(
            global::MagicHour.AiImageEditorCreateImageRequestStyle style,
            global::MagicHour.AiImageEditorCreateImageRequestAssets assets,
            string? name = default,
            double? imageCount = default,
            global::MagicHour.AiImageEditorCreateImageRequestModel? model = default,
            global::MagicHour.AiImageEditorCreateImageRequestAspectRatio? aspectRatio = default,
            global::MagicHour.AiImageEditorCreateImageRequestResolution? resolution = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::MagicHour.AiImageEditorCreateImageRequest
            {
                Name = name,
                ImageCount = imageCount,
                Model = model,
                AspectRatio = aspectRatio,
                Resolution = resolution,
                Style = style,
                Assets = assets,
            };

            return await AiImageEditorCreateImageAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}