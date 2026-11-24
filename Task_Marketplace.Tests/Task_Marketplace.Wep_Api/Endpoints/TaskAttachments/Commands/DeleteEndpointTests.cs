using FluentAssertions;
using System.Net;
using Task_Marketplace.Tests.Integration.Infrastructure;
using Xunit;

namespace Task_Marketplace.Tests.Integration.Endpoints.TaskAttachments.Commands;

[Collection("DBCollection")]
public class DeleteEndpointTests(IntegrationTestFixture fixture)
{
    [Fact]
    public async Task Delete_WithoutAuthorization_ReturnsUnauthorized()
    {
        ProjectTestHelper.ClearAuthorization(fixture.Client);

        var response = await fixture.Client.DeleteAsync(
            $"/api/tasks/{Guid.NewGuid()}/attachments/{Guid.NewGuid()}");

        response.StatusCode.Should().Be(HttpStatusCode.Unauthorized);
    }

    [Fact]
    public async Task Delete_Uploader_ReturnsNoContent()
    {
        var customer = await ProjectTestHelper.RegisterUserAsync(fixture.Client);
        ProjectTestHelper.Authorize(fixture.Client, customer.Token);
        var task = await ProjectTestHelper.CreateTaskAsync(fixture.Client);
        var attachment = await TaskAttachmentTestHelper.CreateAttachmentAsync(
            fixture.Client, task.Id);

        var response = await fixture.Client.DeleteAsync(
            $"/api/tasks/{task.Id}/attachments/{attachment.Id}");

        response.StatusCode.Should().Be(HttpStatusCode.NoContent);
    }

    [Fact]
    public async Task Delete_OtherUser_ReturnsForbidden()
    {
        var owner = await ProjectTestHelper.RegisterUserAsync(fixture.Client);
        ProjectTestHelper.Authorize(fixture.Client, owner.Token);
        var task = await ProjectTestHelper.CreateTaskAsync(fixture.Client);
        var attachment = await TaskAttachmentTestHelper.CreateAttachmentAsync(
            fixture.Client, task.Id);

        var anotherCustomer = await ProjectTestHelper.RegisterUserAsync(fixture.Client);
        ProjectTestHelper.Authorize(fixture.Client, anotherCustomer.Token);

        var response = await fixture.Client.DeleteAsync(
            $"/api/tasks/{task.Id}/attachments/{attachment.Id}");

        response.StatusCode.Should().Be(HttpStatusCode.Forbidden);
    }

    [Fact]
    public async Task Delete_NonExistingAttachment_ReturnsNotFound()
    {
        var customer = await ProjectTestHelper.RegisterUserAsync(fixture.Client);
        ProjectTestHelper.Authorize(fixture.Client, customer.Token);

        var response = await fixture.Client.DeleteAsync(
            $"/api/tasks/{Guid.NewGuid()}/attachments/{Guid.NewGuid()}");

        response.StatusCode.Should().Be(HttpStatusCode.NotFound);
    }
}