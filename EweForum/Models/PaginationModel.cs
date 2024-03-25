namespace EweForum.Models
{
    public class PaginationModel<T>
    {
        public int PageIndex { get; set; } = 0;
        public int CurrentPageIndex { get; set; } = 0;

        public int PageCount { get; set; } = 0;

        public string SearchTerm { get; set; } = null!;
        
        public int PageSize { get; set ; }

        public List<T> Items { get; set; } = new List<T>();

    }
}
