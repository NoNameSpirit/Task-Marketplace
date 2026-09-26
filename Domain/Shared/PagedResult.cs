using Domain.Constants;

namespace Domain.Shared;

public class PagedResult<T>
{
    public IReadOnlyCollection<T> Collection = null!;
    public int Page { get; }
    public int PageSize { get; }
    public int TotalCount { get; }
    public int TotalPages { get; }

    public bool HasPreviousPage
        => Page > CurrencyConstants.MinPage;

    public bool HasNextPage
        => Page < TotalPages;


    private PagedResult(
        IReadOnlyCollection<T> items,
        int page,
        int pageSize,
        int totalCount)
    {
        Collection = items;
        Page = page;
        PageSize = pageSize;
        TotalCount = totalCount;
        TotalPages = (int)Math.Ceiling((double)(TotalCount / PageSize));
    }

    public static PagedResult<T> Create(
        IReadOnlyList<T> items,
        int page,
        int pageSize,
        int totalCount)
    {
        return new PagedResult<T>(items, page, pageSize, totalCount);
    }

    public static PagedResult<T> Empty(
        int page,
        int pageSize)
    {
        return new PagedResult<T>(Array.Empty<T>(), page, pageSize, CurrencyConstants.ZeroElements);
    }
}
