using EweForum.Data;
using ForumTopic = EweForum.Infrastructure.Data.Models.Topic;
using EweForum.Utilites.Enums;
using Microsoft.EntityFrameworkCore;

namespace EweForum.Core.Services.TopicService
{
    public class TopicService : ITopicService
    {
        private readonly EweForumContext _context;

        public TopicService(EweForumContext context)
        {
            _context = context;
        }

        public async Task<ICollection<ForumTopic>> All(int pageIndex, int pageSize, string? searchTerm = null, SortingOrder? order = null )
        {
            List<ForumTopic> topics = null;
            if(searchTerm == null)
            {
                topics = await _context.Topics.ToListAsync();
            }
            if(order == null)
            {

            }
            return topics; 
        }
    }
}
