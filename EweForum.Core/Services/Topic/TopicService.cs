using EweForum.Data;
using EweForum.Utilites.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EweForum.Core.Services.Topic
{
    public class TopicService : ITopicService
    {
        private readonly EweForumContext _context;

        public TopicService(EweForumContext context)
        {
            _context = context;
        }

        public Task<ICollection<Infrastructure.Data.Models.Topic>> All(string? searchTerm = null, SortingOrder? order = null, int topicsPerPage = 1)
        {
            throw new NotImplementedException();
        }
    }
}
