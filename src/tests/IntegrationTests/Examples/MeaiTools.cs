/*
order: 20
title: MEAI Tools
slug: meai-tools

Example showing how to create AIFunction tools for use with any IChatClient.
*/

using Microsoft.Extensions.AI;

namespace MagicHour.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void Example_MeaiTools()
    {
        //// Create an authenticated client.
        using var client = GetAuthenticatedClient();

        //// Create AIFunction tools from the Magic Hour client.
        //// These tools can be used with any `IChatClient` for AI agent workflows.
        var textToVideoTool = client.AsTextToVideoTool();
        var imageToVideoTool = client.AsImageToVideoTool();
        var getVideoStatusTool = client.AsGetVideoStatusTool();
        var getImageStatusTool = client.AsGetImageStatusTool();
        var generateImageTool = client.AsGenerateImageTool();
        var faceSwapTool = client.AsFaceSwapVideoTool();
        var lipSyncTool = client.AsLipSyncTool();

        //// Each tool has a name and description suitable for LLM tool calling.
        textToVideoTool.Name.Should().Be("MagicHour_TextToVideo");
        imageToVideoTool.Name.Should().Be("MagicHour_ImageToVideo");
        getVideoStatusTool.Name.Should().Be("MagicHour_GetVideoStatus");
        getImageStatusTool.Name.Should().Be("MagicHour_GetImageStatus");
        generateImageTool.Name.Should().Be("MagicHour_GenerateImage");
        faceSwapTool.Name.Should().Be("MagicHour_FaceSwapVideo");
        lipSyncTool.Name.Should().Be("MagicHour_LipSync");
    }
}
