using FluentAssertions;
using System.Net;
using Task_Marketplace.Tests.Integration.Infrastructure;
using Xunit;

namespace Task_Marketplace.Tests.Integration.Endpoints.TaskAttachments.Commands;

[Collection("DBCollection")]
public class DownloadEndpointTests(IntegrationTestFixture fixture)
{
    [Fact]
    public async Task Download_WithoutAuthorization_ReturnsUnauthorized()
    {
        ProjectTestHelper.ClearAuthorization(fixture.Client);

        var response = await fixture.Client.GetAsync(
            $"/api/tasks/{Guid.NewGuid()}/attachments/{Guid.NewGuid()}/download");

        response.StatusCode.Should().Be(HttpStatusCode.Unauthorized);
    }

    [Fact]
    public async Task Download_ExistingAttachment_ReturnsOk()
    {
        var customer = await ProjectTestHelper.RegisterUserAsync(fixture.Client);
        ProjectTestHelper.Authorize(fixture.Client, customer.Token);
        var task = await ProjectTestHelper.CreateTaskAsync(fixture.Client);
        var attachment = await TaskAttachmentTestHelper.CreateAttachmentAsync(
            fixture.Client, task.Id);

        var response = await fixture.Client.GetAsync(
            $"/api/tasks/{task.Id}/attachments/{attachment.Id}/download");

        response.StatusCode.Should().Be(HttpStatusCode.OK);
    }

    [Fact]
    public async Task Download_NonExistingAttachment_ReturnsNotFound()
    {
        var customer = await ProjectTestHelper.RegisterUserAsync(fixture.Client);
        ProjectTestHelper.Authorize(fixture.Client, customer.Token);

        var response = await fixture.Client.GetAsync(
            $"/api/tasks/{Guid.NewGuid()}/attachments/{Guid.NewGuid()}/download");

        response.StatusCode.Should().Be(HttpStatusCode.NotFound);
    }
}