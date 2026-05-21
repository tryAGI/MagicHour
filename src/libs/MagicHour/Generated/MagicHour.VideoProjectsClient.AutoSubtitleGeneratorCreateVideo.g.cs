
#nullable enable

namespace MagicHour
{
    public partial class VideoProjectsClient
    {


        private static readonly global::MagicHour.EndPointSecurityRequirement s_AutoSubtitleGeneratorCreateVideoSecurityRequirement0 =
            new global::MagicHour.EndPointSecurityRequirement
            {
                Authorizations = new global::MagicHour.EndPointAuthorizationRequirement[]
                {                    new global::MagicHour.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "HttpBearer",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::MagicHour.EndPointSecurityRequirement[] s_AutoSubtitleGeneratorCreateVideoSecurityRequirements =
            new global::MagicHour.EndPointSecurityRequirement[]
            {                s_AutoSubtitleGeneratorCreateVideoSecurityRequirement0,
            };
        partial void PrepareAutoSubtitleGeneratorCreateVideoArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::MagicHour.AutoSubtitleGeneratorCreateVideoRequest request);
        partial void PrepareAutoSubtitleGeneratorCreateVideoRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::MagicHour.AutoSubtitleGeneratorCreateVideoRequest request);
        partial void ProcessAutoSubtitleGeneratorCreateVideoResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessAutoSubtitleGeneratorCreateVideoResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Auto Subtitle Generator<br/>
        /// Automatically generate subtitles for your video in multiple languages.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MagicHour.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///      --url https://api.magichour.ai/v1/auto-subtitle-generator \<br/>
        ///      --header 'accept: application/json' \<br/>
        ///      --header 'authorization: Bearer &lt;token&gt;' \<br/>
        ///      --header 'content-type: application/json' \<br/>
        ///      --data '<br/>
        /// {<br/>
        ///   "name": "My Auto Subtitle video",<br/>
        ///   "start_seconds": 0,<br/>
        ///   "end_seconds": 15,<br/>
        ///   "assets": {<br/>
        ///     "video_file_path": "api-assets/id/1234.mp4"<br/>
        ///   },<br/>
        ///   "style": {<br/>
        ///     "template": "karaoke",<br/>
        ///     "custom_config": {<br/>
        ///       "font": "Noto Sans",<br/>
        ///       "font_size": 24,<br/>
        ///       "font_style": "normal",<br/>
        ///       "text_color": "#FFFFFF",<br/>
        ///       "highlighted_text_color": "#FFD700",<br/>
        ///       "stroke_color": "#000000",<br/>
        ///       "stroke_width": 1,<br/>
        ///       "vertical_position": "bottom",<br/>
        ///       "horizontal_position": "center"<br/>
        ///     }<br/>
        ///   }<br/>
        /// }<br/>
        /// '
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::MagicHour.AutoSubtitleGeneratorCreateVideoResponse> AutoSubtitleGeneratorCreateVideoAsync(

            global::MagicHour.AutoSubtitleGeneratorCreateVideoRequest request,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await AutoSubtitleGeneratorCreateVideoAsResponseAsync(

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Auto Subtitle Generator<br/>
        /// Automatically generate subtitles for your video in multiple languages.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MagicHour.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///      --url https://api.magichour.ai/v1/auto-subtitle-generator \<br/>
        ///      --header 'accept: application/json' \<br/>
        ///      --header 'authorization: Bearer &lt;token&gt;' \<br/>
        ///      --header 'content-type: application/json' \<br/>
        ///      --data '<br/>
        /// {<br/>
        ///   "name": "My Auto Subtitle video",<br/>
        ///   "start_seconds": 0,<br/>
        ///   "end_seconds": 15,<br/>
        ///   "assets": {<br/>
        ///     "video_file_path": "api-assets/id/1234.mp4"<br/>
        ///   },<br/>
        ///   "style": {<br/>
        ///     "template": "karaoke",<br/>
        ///     "custom_config": {<br/>
        ///       "font": "Noto Sans",<br/>
        ///       "font_size": 24,<br/>
        ///       "font_style": "normal",<br/>
        ///       "text_color": "#FFFFFF",<br/>
        ///       "highlighted_text_color": "#FFD700",<br/>
        ///       "stroke_color": "#000000",<br/>
        ///       "stroke_width": 1,<br/>
        ///       "vertical_position": "bottom",<br/>
        ///       "horizontal_position": "center"<br/>
        ///     }<br/>
        ///   }<br/>
        /// }<br/>
        /// '
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::MagicHour.AutoSDKHttpResponse<global::MagicHour.AutoSubtitleGeneratorCreateVideoResponse>> AutoSubtitleGeneratorCreateVideoAsResponseAsync(

            global::MagicHour.AutoSubtitleGeneratorCreateVideoRequest request,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareAutoSubtitleGeneratorCreateVideoArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::MagicHour.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_AutoSubtitleGeneratorCreateVideoSecurityRequirements,
                operationName: "AutoSubtitleGeneratorCreateVideoAsync");

            using var __timeoutCancellationTokenSource = global::MagicHour.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::MagicHour.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::MagicHour.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::MagicHour.PathBuilder(
                                path: "/v1/auto-subtitle-generator",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::MagicHour.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
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
                            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
                            var __httpRequestContent = new global::System.Net.Http.StringContent(
                                content: __httpRequestContentBody,
                                encoding: global::System.Text.Encoding.UTF8,
                                mediaType: "application/json");
                            __httpRequest.Content = __httpRequestContent;
                global::MagicHour.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareAutoSubtitleGeneratorCreateVideoRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    request: request);

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
                    await global::MagicHour.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::MagicHour.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "AutoSubtitleGeneratorCreateVideo",
                                methodName: "AutoSubtitleGeneratorCreateVideoAsync",
                                pathTemplate: "\"/v1/auto-subtitle-generator\"",
                                httpMethod: "POST",
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
                        var __retryDelay = global::MagicHour.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::MagicHour.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::MagicHour.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "AutoSubtitleGeneratorCreateVideo",
                                methodName: "AutoSubtitleGeneratorCreateVideoAsync",
                                pathTemplate: "\"/v1/auto-subtitle-generator\"",
                                httpMethod: "POST",
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
                        await global::MagicHour.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::MagicHour.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::MagicHour.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::MagicHour.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::MagicHour.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "AutoSubtitleGeneratorCreateVideo",
                                methodName: "AutoSubtitleGeneratorCreateVideoAsync",
                                pathTemplate: "\"/v1/auto-subtitle-generator\"",
                                httpMethod: "POST",
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
                        await global::MagicHour.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
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
                ProcessAutoSubtitleGeneratorCreateVideoResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::MagicHour.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::MagicHour.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "AutoSubtitleGeneratorCreateVideo",
                                methodName: "AutoSubtitleGeneratorCreateVideoAsync",
                                pathTemplate: "\"/v1/auto-subtitle-generator\"",
                                httpMethod: "POST",
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
                    await global::MagicHour.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::MagicHour.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "AutoSubtitleGeneratorCreateVideo",
                                methodName: "AutoSubtitleGeneratorCreateVideoAsync",
                                pathTemplate: "\"/v1/auto-subtitle-generator\"",
                                httpMethod: "POST",
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
                            // Invalid Request
                            if ((int)__response.StatusCode == 400)
                            {
                                string? __content_400 = null;
                                global::System.Exception? __exception_400 = null;
                                global::MagicHour.AutoSubtitleGeneratorCreateVideoResponse2? __value_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_400 = global::MagicHour.AutoSubtitleGeneratorCreateVideoResponse2.FromJson(__content_400, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_400 = global::MagicHour.AutoSubtitleGeneratorCreateVideoResponse2.FromJson(__content_400, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }

                                throw new global::MagicHour.ApiException<global::MagicHour.AutoSubtitleGeneratorCreateVideoResponse2>(
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
                                global::MagicHour.AutoSubtitleGeneratorCreateVideoResponse3? __value_401 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_401 = global::MagicHour.AutoSubtitleGeneratorCreateVideoResponse3.FromJson(__content_401, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_401 = global::MagicHour.AutoSubtitleGeneratorCreateVideoResponse3.FromJson(__content_401, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_401 = __ex;
                                }

                                throw new global::MagicHour.ApiException<global::MagicHour.AutoSubtitleGeneratorCreateVideoResponse3>(
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
                                global::MagicHour.AutoSubtitleGeneratorCreateVideoResponse4? __value_402 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_402 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_402 = global::MagicHour.AutoSubtitleGeneratorCreateVideoResponse4.FromJson(__content_402, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_402 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_402 = global::MagicHour.AutoSubtitleGeneratorCreateVideoResponse4.FromJson(__content_402, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_402 = __ex;
                                }

                                throw new global::MagicHour.ApiException<global::MagicHour.AutoSubtitleGeneratorCreateVideoResponse4>(
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
                                global::MagicHour.AutoSubtitleGeneratorCreateVideoResponse5? __value_404 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_404 = global::MagicHour.AutoSubtitleGeneratorCreateVideoResponse5.FromJson(__content_404, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_404 = global::MagicHour.AutoSubtitleGeneratorCreateVideoResponse5.FromJson(__content_404, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_404 = __ex;
                                }

                                throw new global::MagicHour.ApiException<global::MagicHour.AutoSubtitleGeneratorCreateVideoResponse5>(
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
                                global::MagicHour.AutoSubtitleGeneratorCreateVideoResponse6? __value_422 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_422 = global::MagicHour.AutoSubtitleGeneratorCreateVideoResponse6.FromJson(__content_422, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_422 = global::MagicHour.AutoSubtitleGeneratorCreateVideoResponse6.FromJson(__content_422, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_422 = __ex;
                                }

                                throw new global::MagicHour.ApiException<global::MagicHour.AutoSubtitleGeneratorCreateVideoResponse6>(
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
                                ProcessAutoSubtitleGeneratorCreateVideoResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::MagicHour.AutoSubtitleGeneratorCreateVideoResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::MagicHour.AutoSDKHttpResponse<global::MagicHour.AutoSubtitleGeneratorCreateVideoResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::MagicHour.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
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
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::MagicHour.AutoSubtitleGeneratorCreateVideoResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::MagicHour.AutoSDKHttpResponse<global::MagicHour.AutoSubtitleGeneratorCreateVideoResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::MagicHour.AutoSDKHttpResponse.CreateHeaders(__response),
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
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// Auto Subtitle Generator<br/>
        /// Automatically generate subtitles for your video in multiple languages.
        /// </summary>
        /// <param name="name">
        /// Give your video a custom name for easy identification.<br/>
        /// Default Value: Auto Subtitle - dateTime<br/>
        /// Example: My Auto Subtitle video
        /// </param>
        /// <param name="startSeconds">
        /// Start time of your clip (seconds). Must be ≥ 0.<br/>
        /// Example: 0
        /// </param>
        /// <param name="endSeconds">
        /// End time of your clip (seconds). Must be greater than start_seconds.<br/>
        /// Example: 15
        /// </param>
        /// <param name="assets">
        /// Provide the assets for auto subtitle generator
        /// </param>
        /// <param name="style">
        /// Style of the subtitle. At least one of `.style.template` or `.style.custom_config` must be provided. <br/>
        /// * If only `.style.template` is provided, default values for the template will be used.<br/>
        /// * If both are provided, the fields in `.style.custom_config` will be used to overwrite the fields in `.style.template`.<br/>
        /// * If only `.style.custom_config` is provided, then all fields in `.style.custom_config` will be used.<br/>
        /// To use custom config only, the following `custom_config` params are required:<br/>
        /// * `.style.custom_config.font`<br/>
        /// * `.style.custom_config.text_color`<br/>
        /// * `.style.custom_config.vertical_position`<br/>
        /// * `.style.custom_config.horizontal_position`
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::MagicHour.AutoSubtitleGeneratorCreateVideoResponse> AutoSubtitleGeneratorCreateVideoAsync(
            float startSeconds,
            float endSeconds,
            global::MagicHour.AutoSubtitleGeneratorCreateVideoRequestAssets assets,
            global::MagicHour.AutoSubtitleGeneratorCreateVideoRequestStyle style,
            string? name = default,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::MagicHour.AutoSubtitleGeneratorCreateVideoRequest
            {
                Name = name,
                StartSeconds = startSeconds,
                EndSeconds = endSeconds,
                Assets = assets,
                Style = style,
            };

            return await AutoSubtitleGeneratorCreateVideoAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}