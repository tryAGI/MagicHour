
#nullable enable

namespace MagicHour
{
    public partial class VideoProjectsClient
    {


        private static readonly global::MagicHour.EndPointSecurityRequirement s_AiTalkingPhotoCreateTalkingPhotoSecurityRequirement0 =
            new global::MagicHour.EndPointSecurityRequirement
            {
                Authorizations = new global::MagicHour.EndPointAuthorizationRequirement[]
                {                    new global::MagicHour.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::MagicHour.EndPointSecurityRequirement[] s_AiTalkingPhotoCreateTalkingPhotoSecurityRequirements =
            new global::MagicHour.EndPointSecurityRequirement[]
            {                s_AiTalkingPhotoCreateTalkingPhotoSecurityRequirement0,
            };
        partial void PrepareAiTalkingPhotoCreateTalkingPhotoArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::MagicHour.AiTalkingPhotoCreateTalkingPhotoRequest request);
        partial void PrepareAiTalkingPhotoCreateTalkingPhotoRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::MagicHour.AiTalkingPhotoCreateTalkingPhotoRequest request);
        partial void ProcessAiTalkingPhotoCreateTalkingPhotoResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessAiTalkingPhotoCreateTalkingPhotoResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// AI Talking Photo<br/>
        /// Create a talking photo from an image and audio or text input.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MagicHour.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///      --url https://api.magichour.ai/v1/ai-talking-photo \<br/>
        ///      --header 'accept: application/json' \<br/>
        ///      --header 'authorization: Bearer &lt;token&gt;' \<br/>
        ///      --header 'content-type: application/json' \<br/>
        ///      --data '<br/>
        /// {<br/>
        ///   "name": "My Talking Photo image",<br/>
        ///   "start_seconds": 0,<br/>
        ///   "end_seconds": 15,<br/>
        ///   "assets": {<br/>
        ///     "image_file_path": "api-assets/id/1234.png",<br/>
        ///     "audio_file_path": "api-assets/id/1234.mp3"<br/>
        ///   },<br/>
        ///   "style": {<br/>
        ///     "generation_mode": "realistic",<br/>
        ///     "prompt": "string"<br/>
        ///   },<br/>
        ///   "max_resolution": 1024<br/>
        /// }<br/>
        /// '
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponse> AiTalkingPhotoCreateTalkingPhotoAsync(

            global::MagicHour.AiTalkingPhotoCreateTalkingPhotoRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareAiTalkingPhotoCreateTalkingPhotoArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::MagicHour.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_AiTalkingPhotoCreateTalkingPhotoSecurityRequirements,
                operationName: "AiTalkingPhotoCreateTalkingPhotoAsync");

            var __pathBuilder = new global::MagicHour.PathBuilder(
                path: "/v1/ai-talking-photo",
                baseUri: HttpClient.BaseAddress);
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
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
            PrepareAiTalkingPhotoCreateTalkingPhotoRequest(
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
            ProcessAiTalkingPhotoCreateTalkingPhotoResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Invalid Request
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponse2? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponse2.FromJson(__content_400, JsonSerializerContext);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponse2.FromJson(__content_400, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::MagicHour.ApiException<global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponse2>(
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
                global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponse3? __value_401 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_401 = global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponse3.FromJson(__content_401, JsonSerializerContext);
                    }
                    else
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_401 = global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponse3.FromJson(__content_401, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_401 = __ex;
                }

                throw new global::MagicHour.ApiException<global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponse3>(
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
                global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponse4? __value_402 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_402 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_402 = global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponse4.FromJson(__content_402, JsonSerializerContext);
                    }
                    else
                    {
                        __content_402 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_402 = global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponse4.FromJson(__content_402, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_402 = __ex;
                }

                throw new global::MagicHour.ApiException<global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponse4>(
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
                global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponse5? __value_404 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_404 = global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponse5.FromJson(__content_404, JsonSerializerContext);
                    }
                    else
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_404 = global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponse5.FromJson(__content_404, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_404 = __ex;
                }

                throw new global::MagicHour.ApiException<global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponse5>(
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
                global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponse6? __value_422 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponse6.FromJson(__content_422, JsonSerializerContext);
                    }
                    else
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_422 = global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponse6.FromJson(__content_422, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_422 = __ex;
                }

                throw new global::MagicHour.ApiException<global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponse6>(
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
                ProcessAiTalkingPhotoCreateTalkingPhotoResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponse.FromJson(__content, JsonSerializerContext) ??
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
                        await global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// AI Talking Photo<br/>
        /// Create a talking photo from an image and audio or text input.
        /// </summary>
        /// <param name="name">
        /// Give your image a custom name for easy identification.<br/>
        /// Default Value: Talking Photo - dateTime<br/>
        /// Example: My Talking Photo image
        /// </param>
        /// <param name="startSeconds">
        /// The start time of the input audio in seconds. The maximum duration allowed is 60 seconds.<br/>
        /// Example: 0
        /// </param>
        /// <param name="endSeconds">
        /// The end time of the input audio in seconds. The maximum duration allowed is 60 seconds.<br/>
        /// Example: 15
        /// </param>
        /// <param name="assets">
        /// Provide the assets for creating a talking photo
        /// </param>
        /// <param name="style">
        /// Attributes used to dictate the style of the output
        /// </param>
        /// <param name="maxResolution">
        /// Constrains the larger dimension (height or width) of the output video. Allows you to set a lower resolution than your plan's maximum if desired. The value is capped by your plan's max resolution.<br/>
        /// Example: 1024
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponse> AiTalkingPhotoCreateTalkingPhotoAsync(
            float startSeconds,
            float endSeconds,
            global::MagicHour.AiTalkingPhotoCreateTalkingPhotoRequestAssets assets,
            string? name = default,
            global::MagicHour.AiTalkingPhotoCreateTalkingPhotoRequestStyle? style = default,
            int? maxResolution = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::MagicHour.AiTalkingPhotoCreateTalkingPhotoRequest
            {
                Name = name,
                StartSeconds = startSeconds,
                EndSeconds = endSeconds,
                Assets = assets,
                Style = style,
                MaxResolution = maxResolution,
            };

            return await AiTalkingPhotoCreateTalkingPhotoAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}