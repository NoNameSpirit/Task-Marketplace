using Blazor_Web_App.Services;
using Microsoft.AspNetCore.Components;
using Shared.Dtos.Responses.Users;
using Shared.Enums;

namespace Blazor_Web_App.Components.Pages.Admin;

public partial class AdminUsers : ComponentBase
{
    private const int PageSize = 10;
    private const int FirstPage = 1;

    [Inject] public ApiService ApiService { get; set; } = null!;

    private List<UserDto>? Users;
    private int CurrentPage = FirstPage;
    private int TotalPages = FirstPage;
    private bool IsLoading;
    private string ErrorMessage = string.Empty;

    private Guid _processingUserId;

    protected override async Task OnInitializedAsync()
    {
        await LoadUsers();
    }

    private async Task LoadUsers()
    {
        IsLoading = true;
        ErrorMessage = string.Empty;

        var result = await ApiService.GetUsersAsync(CurrentPage, PageSize);

        if (result.IsSuccess && result.Value is not null)
        {
            Users = result.Value.Collection.ToList();
            TotalPages = (int)Math.Ceiling((double)result.Value.TotalCount / PageSize);

            if (TotalPages < FirstPage)
            {
                TotalPages = FirstPage;
            }
        }
        else
        {
            ErrorMessage = result.Message;
            Users = new List<UserDto>();
        }

        IsLoading = false;
    }

    private async Task GoToPage(int page)
    {
        if (page < FirstPage || page > TotalPages) return;

        CurrentPage = page;

        await LoadUsers();
    }

    private async Task HandleChangeRole(Guid userId, ChangeEventArgs e)
    {
        if (!Enum.TryParse<UserRole>(e.Value?.ToString(), out var role)) return;

        _processingUserId = userId;

        var result = await ApiService.ChangeRoleAsync(userId, role);

        if (result.IsSuccess)
        {
            await LoadUsers();
        }
        else
        {
            ErrorMessage = result.Message;
        }

        _processingUserId = Guid.Empty;
    }

    private async Task HandleBlock(UserDto user)
    {
        _processingUserId = user.Id;

        var result = user.IsBlocked
            ? await ApiService.UnblockUserAsync(user.Id)
            : await ApiService.BlockUserAsync(user.Id);

        if (result.IsSuccess)
        {
            await LoadUsers();
        }
        else
        {
            ErrorMessage = result.Message;
        }

        _processingUserId = Guid.Empty;
    }

    private async Task HandleDelete(Guid userId)
    {
        _processingUserId = userId;

        var result = await ApiService.DeleteUserAsync(userId);

        if (result.IsSuccess)
        {
            await LoadUsers();
        }
        else
        {
            ErrorMessage = result.Message;
        }

        _processingUserId = Guid.Empty;
    }
}