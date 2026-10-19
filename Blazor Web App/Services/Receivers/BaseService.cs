using Blazor_Web_App.Constants;
using Blazor_Web_App.Services.LocalStorage;
using Microsoft.AspNetCore.Mvc;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Users;
using System.Net.Http.Headers;
using System.Text.Json;

namespace Blazor_Web_App.Services.Receivers;

public abstract class BaseService
{
    protected HttpClient _httpClient { get; private set; }
    protected ILocalStorageService _localStorage { get; private set; }

    private const string Scheme = "Bearer";
    protected const int FirstPageNumber = Pagination.FirstPage;
    protected const int BasePageSize = Pagination.DefaultPageSize;

    private readonly JsonSerializerOptions _options = new JsonSerializerOptions
    {
        PropertyNameCaseInsensitive = true
    };

    protected BaseService(
        HttpClient httpClient,
        ILocalStorageService localStorage)
    {
        _httpClient = httpClient;
        _localStorage = localStorage;
    }

    protected async Task SetAuthHeaderAsync(
        CancellationToken cancellationToken = default)
    {
        var token = await _localStorage
            .GetItemAsync(nameof(AuthDto.Token));

        if (!string.IsNullOrEmpty(token))
        {
            _httpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue(Scheme, token);
        }
    }

    protected async Task<Result<T>> HandleResponseAsync<T>(
    HttpResponseMessage response,
    CancellationToken cancellationToken = default) where T : class
    {
        if (!response.IsSuccessStatusCode)
        {
            var problemDetails = await response.Content.ReadFromJsonAsync<ProblemDetails>(cancellationToken);

            return Result<T>.Failure(problemDetails!.Detail! ?? ServiceMessages.UnknownServerError);
        }

        if (response.Content.Headers.ContentLength == AttachmentConstants.Zero)
        {
            return Result<T>.Failure(ServiceMessages.EmptyResponse);
        }

        var dto = await response.Content.ReadFromJsonAsync<T>(
            _options,
            cancellationToken);

        if (dto is null)
        {
            return Result<T>.Failure(ServiceMessages.DeserializationFailed);
        }

        return Result<T>.Success(dto!);
    }

    protected async Task<Result> HandleResponseAsync(
       HttpResponseMessage response,
       CancellationToken cancellationToken = default)
    {
        if (!response.IsSuccessStatusCode)
        {
            var problemDetails = await response.Content.ReadFromJsonAsync<ProblemDetails>(cancellationToken);

            return Result.Failure(problemDetails!.Detail! ?? ServiceMessages.UnknownServerError);
        }

        return Result.Success();
    }
}