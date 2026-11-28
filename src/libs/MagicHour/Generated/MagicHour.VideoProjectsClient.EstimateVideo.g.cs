
#nullable enable

namespace MagicHour
{
    public partial class VideoProjectsClient
    {


        private static readonly global::MagicHour.EndPointSecurityRequirement s_EstimateVideoSecurityRequirement0 =
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
        private static readonly global::MagicHour.EndPointSecurityRequirement[] s_EstimateVideoSecurityRequirements =
            new global::MagicHour.EndPointSecurityRequirement[]
            {                s_EstimateVideoSecurityRequirement0,
            };
        partial void PrepareEstimateVideoArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::MagicHour.EstimateVideoTool tool,
            ref double endSeconds,
            ref double? startSeconds,
            ref string? model,
            ref string? resolution,
            ref bool? audio,
            ref bool? hasVideoReference);
        partial void PrepareEstimateVideoRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::MagicHour.EstimateVideoTool tool,
            double endSeconds,
            double? startSeconds,
            string? model,
            string? resolution,
            bool? audio,
            bool? hasVideoReference);
        partial void ProcessEstimateVideoResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessEstimateVideoResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Estimate video credits<br/>
        /// Get the credits a video create request charges when it is submitted. Pass `tool`, then the fields below that the tool's create request uses, with the same values. Tools billed per frame charge an estimate at submission, assuming 30 fps for an uploaded video, and settle to the frames that render. Does not create a project or spend credits. It prices the fields passed here. It does not check your plan, your balance or the rest of the create request.
        /// </summary>
        /// <param name="tool">
        /// Example: image-to-video
        /// </param>
        /// <param name="endSeconds">
        /// Example: 5
        /// </param>
        /// <param name="startSeconds"></param>
        /// <param name="model">
        /// Example: kling-3.0
        /// </param>
        /// <param name="resolution">
        /// Example: 720p
        /// </param>
        /// <param name="audio"></param>
        /// <param name="hasVideoReference"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MagicHour.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::MagicHour.EstimateVideoResponse> EstimateVideoAsync(
            global::MagicHour.EstimateVideoTool tool,
            double endSeconds,
            double? startSeconds = default,
            string? model = default,
            string? resolution = default,
            bool? audio = default,
            bool? hasVideoReference = default,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await EstimateVideoAsResponseAsync(
                tool: tool,
                endSeconds: endSeconds,
                startSeconds: startSeconds,
                model: model,
                resolution: resolution,
                audio: audio,
                hasVideoReference: hasVideoReference,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Estimate video credits<br/>
        /// Get the credits a video create request charges when it is submitted. Pass `tool`, then the fields below that the tool's create request uses, with the same values. Tools billed per frame charge an estimate at submission, assuming 30 fps for an uploaded video, and settle to the frames that render. Does not create a project or spend credits. It prices the fields passed here. It does not check your plan, your balance or the rest of the create request.
        /// </summary>
        /// <param name="tool">
        /// Example: image-to-video
        /// </param>
        /// <param name="endSeconds">
        /// Example: 5
        /// </param>
        /// <param name="startSeconds"></param>
        /// <param name="model">
        /// Example: kling-3.0
        /// </param>
        /// <param name="resolution">
        /// Example: 720p
        /// </param>
        /// <param name="audio"></param>
        /// <param name="hasVideoReference"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MagicHour.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::MagicHour.AutoSDKHttpResponse<global::MagicHour.EstimateVideoResponse>> EstimateVideoAsResponseAsync(
            global::MagicHour.EstimateVideoTool tool,
            double endSeconds,
            double? startSeconds = default,
            string? model = default,
            string? resolution = default,
            bool? audio = default,
            bool? hasVideoReference = default,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareEstimateVideoArguments(
                httpClient: HttpClient,
                tool: ref tool,
                endSeconds: ref endSeconds,
                startSeconds: ref startSeconds,
                model: ref model,
                resolution: ref resolution,
                audio: ref audio,
                hasVideoReference: ref hasVideoReference);


            var __authorizations = global::MagicHour.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_EstimateVideoSecurityRequirements,
                operationName: "EstimateVideoAsync");

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
                                path: "/v1/estimate/video",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddRequiredParameter("tool", tool.ToValueString())
                                .AddRequiredParameter("end_seconds", endSeconds.ToString() ?? throw new global::System.InvalidOperationException("A required query parameter returned null from ToString()."))
                                .AddOptionalParameter("start_seconds", startSeconds?.ToString())
                                .AddOptionalParameter("model", model)
                                .AddOptionalParameter("resolution", resolution)
                                .AddOptionalParameter("audio", audio?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("has_video_reference", hasVideoReference?.ToString().ToLowerInvariant())
                                ;
                            var __path = __pathBuilder.ToString();
                __path = global::MagicHour.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Get,
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
                global::MagicHour.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareEstimateVideoRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    tool: tool,
                    endSeconds: endSeconds,
                    startSeconds: startSeconds,
                    model: model,
                    resolution: resolution,
                    audio: audio,
                    hasVideoReference: hasVideoReference);

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
                                operationId: "EstimateVideo",
                                methodName: "EstimateVideoAsync",
                                pathTemplate: "\"/v1/estimate/video\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
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
                                operationId: "EstimateVideo",
                                methodName: "EstimateVideoAsync",
                                pathTemplate: "\"/v1/estimate/video\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
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
                                operationId: "EstimateVideo",
                                methodName: "EstimateVideoAsync",
                                pathTemplate: "\"/v1/estimate/video\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
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
                ProcessEstimateVideoResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::MagicHour.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::MagicHour.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "EstimateVideo",
                                methodName: "EstimateVideoAsync",
                                pathTemplate: "\"/v1/estimate/video\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
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
                                operationId: "EstimateVideo",
                                methodName: "EstimateVideoAsync",
                                pathTemplate: "\"/v1/estimate/video\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
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
                                global::MagicHour.EstimateVideoResponse2? __value_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_400 = __content_400 is not { Length: > 0 } ? null : global::MagicHour.EstimateVideoResponse2.FromJson(__content_400, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_400 = __content_400 is not { Length: > 0 } ? null : global::MagicHour.EstimateVideoResponse2.FromJson(__content_400, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }


                                throw global::MagicHour.ApiException<global::MagicHour.EstimateVideoResponse2>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_400 is { Length: > 0 } ? __content_400 : __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_400,
                                    responseBody: __content_400,
                                    responseObject: __value_400,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Unauthorized
                            if ((int)__response.StatusCode == 401)
                            {
                                string? __content_401 = null;
                                global::System.Exception? __exception_401 = null;
                                global::MagicHour.EstimateVideoResponse3? __value_401 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_401 = __content_401 is not { Length: > 0 } ? null : global::MagicHour.EstimateVideoResponse3.FromJson(__content_401, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_401 = __content_401 is not { Length: > 0 } ? null : global::MagicHour.EstimateVideoResponse3.FromJson(__content_401, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_401 = __ex;
                                }


                                throw global::MagicHour.ApiException<global::MagicHour.EstimateVideoResponse3>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_401 is { Length: > 0 } ? __content_401 : __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_401,
                                    responseBody: __content_401,
                                    responseObject: __value_401,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Unprocessable Entity
                            if ((int)__response.StatusCode == 422)
                            {
                                string? __content_422 = null;
                                global::System.Exception? __exception_422 = null;
                                global::MagicHour.EstimateVideoResponse4? __value_422 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_422 = __content_422 is not { Length: > 0 } ? null : global::MagicHour.EstimateVideoResponse4.FromJson(__content_422, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_422 = __content_422 is not { Length: > 0 } ? null : global::MagicHour.EstimateVideoResponse4.FromJson(__content_422, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_422 = __ex;
                                }


                                throw global::MagicHour.ApiException<global::MagicHour.EstimateVideoResponse4>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_422 is { Length: > 0 } ? __content_422 : __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_422,
                                    responseBody: __content_422,
                                    responseObject: __value_422,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Internal Server Error
                            if ((int)__response.StatusCode == 500)
                            {
                                string? __content_500 = null;
                                global::System.Exception? __exception_500 = null;
                                global::MagicHour.EstimateVideoResponse5? __value_500 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_500 = __content_500 is not { Length: > 0 } ? null : global::MagicHour.EstimateVideoResponse5.FromJson(__content_500, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_500 = __content_500 is not { Length: > 0 } ? null : global::MagicHour.EstimateVideoResponse5.FromJson(__content_500, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_500 = __ex;
                                }


                                throw global::MagicHour.ApiException<global::MagicHour.EstimateVideoResponse5>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_500 is { Length: > 0 } ? __content_500 : __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_500,
                                    responseBody: __content_500,
                                    responseObject: __value_500,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
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
                                ProcessEstimateVideoResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::MagicHour.EstimateVideoResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::MagicHour.AutoSDKHttpResponse<global::MagicHour.EstimateVideoResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::MagicHour.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::MagicHour.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content is { Length: > 0 } ? __content : __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
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

                                    var __value = await global::MagicHour.EstimateVideoResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::MagicHour.AutoSDKHttpResponse<global::MagicHour.EstimateVideoResponse>(
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

                                    throw global::MagicHour.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content is { Length: > 0 } ? __content : __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
    }
}