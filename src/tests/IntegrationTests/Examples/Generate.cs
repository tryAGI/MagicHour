/*
order: 10
title: Text-to-Video
slug: text-to-video

Basic example showing how to create a text-to-video project.
*/

namespace MagicHour.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_TextToVideo()
    {
        //// Create an authenticated client using your API key.
        using var client = GetAuthenticatedClient();

        //// Create a text-to-video generation job with a prompt.
        var response = await client.VideoProjects.TextToVideoCreateVideoAsync(
            request: new TextToVideoCreateVideoRequest
            {
                EndSeconds = 5,
                AspectRatio = TextToVideoCreateVideoRequestAspectRatio.x16_9,
                Resolution = TextToVideoCreateVideoRequestResolution.x720p,
                Model = TextToVideoCreateVideoRequestModel.Default,
                Style = new TextToVideoCreateVideoRequestStyle
                {
                    Prompt = "a dog running through a meadow",
                },
            });

        //// The response contains the project ID and estimated credits charged.
        response.Id.Should().NotBeNullOrEmpty();

        //// Poll for completion using the video project status endpoint.
        var status = await client.VideoProjects.VideoProjectsGetDetailsAsync(
            id: response.Id);

        status.Id.Should().Be(response.Id);
    }
}
