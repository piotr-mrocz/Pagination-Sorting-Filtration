namespace WebApi.Models.Responses;

public class PagedResult<T>
{
    public int TotalPages { get; set; }
    public int ItemsFrom { get; set; }
    public int ItemsTo { get; set; }
    public int TotalItems { get; set; }
    public List<T> ItemsList { get; set; } = new();

    public PagedResult(int totalCount, int pageSize, int pageNumber, List<T> itemsList)
    {
        TotalPages = (int)Math.Ceiling(totalCount / (double)pageSize);
        TotalItems = totalCount;
        ItemsFrom = pageSize * (pageNumber - 1) + 1;
        ItemsTo = ItemsFrom + pageSize - 1;
        ItemsList = itemsList;
    }
}
