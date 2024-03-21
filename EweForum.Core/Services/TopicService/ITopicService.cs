using EweForum.Infrastructure.Data.Models;
using EweForum.Utilites.Enums;


namespace EweForum.Core.Services.TopicService
{
    public interface ITopicService
    {
        Task<ICollection<Topic>> All(string? searchTerm = null, SortingOrder? order = null, int topicsPerPage = 1);
    }
}
