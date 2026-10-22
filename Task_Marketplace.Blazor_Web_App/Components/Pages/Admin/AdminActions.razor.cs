using Blazor_Web_App.Resources;
using Blazor_Web_App.Services.Receivers.UserActions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using Shared.Dtos.Responses.UserActions;
using Shared.Enums;

namespace Blazor_Web_App.Components.Pages.Admin;

[Authorize(Roles = nameof(UserRole.Admin))]
public partial class AdminActions : ComponentBase
{
    [Inject] public IUserActionService UserActionService { get; set; } = null!;
    [Inject] public IStringLocalizer<SharedResources> Localizer { get; set; } = null!;

    private const int PageSize = 20;
    private const int FirstPage = 1;

    private List<UserActionDto>? Actions;
    private int CurrentPage = FirstPage;
    private int TotalPages = FirstPage;
    private bool IsLoading;
    private string ErrorMessage = string.Empty;
    private Guid? _filterUserId;
    private int? _filterActionType;

    protected override async Task OnInitializedAsync()
    {
        await LoadActions();
    }

    private async Task LoadActions()
    {
        IsLoading = true;
        ErrorMessage = string.Empty;

        var result = await UserActionService.GetUserActionsAsync(
            _filterUserId,
            _filterActionType,
            CurrentPage,
            PageSize);

        if (result.IsSuccess && result.Value is not null)
        {
            Actions = result.Value.Collection.ToList();
            TotalPages = (int)Math.Ceiling((double)result.Value.TotalCount / PageSize);

            if (TotalPages < FirstPage)
            {
                TotalPages = FirstPage;
            }
        }
        else
        {
            ErrorMessage = result.Message;
            Actions = new List<UserActionDto>();
        }

        IsLoading = false;
    }

    private async Task ApplyFilter()
    {
        CurrentPage = FirstPage;

        await LoadActions();
    }

    private async Task ClearFilter()
    {
        _filterUserId = null;
        _filterActionType = null;
        CurrentPage = FirstPage;

        await LoadActions();
    }

    private async Task GoToPage(int page)
    {
        if (page < FirstPage || page > TotalPages)
        {
            return;
        }

        CurrentPage = page;

        await LoadActions();
    }
}