namespace EweForum.Models
{
    public class PaginationModel<T>
    {
        public int PageIndex { get; set; } = 0;
        public int CurrentPageIndex { get; set; } = 0;

        public int PageCount { get; set; } = 0;

        public string SearchTerm { get; set; } = string.Empty;
        
        public int PageSize { get; set ; }

        public int Order { get; set; } = 0;

        public List<T> Items { get; set; } = new List<T>();

        public TopicsInfoViewModel TopicsInfo { get; set; } = null!;
    }
}
