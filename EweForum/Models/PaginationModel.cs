namespace EweForum.Models
{
    public class PaginationModel<T>
    {
        public int PageIndex { get; set; } = 0;
        public int CurrentPageIndex { get; set; } = 0;

        public int PageCount { get; set; } = 0;

        public int PageSize { get; set; } = 0;

        public List<T> Items { get; set; } = new List<T>();

    }
}
