using ForumTopic =  EweForum.Infrastructure.Data.Models.Topic;
using EweForum.Utilites.Enums;


namespace EweForum.Core.Services.Topic
{
    public interface ITopicService
    {
        Task<ICollection<ForumTopic>> All(string? searchTerm = null, SortingOrder? order = null, int topicsPerPage = 1);
    }
}
