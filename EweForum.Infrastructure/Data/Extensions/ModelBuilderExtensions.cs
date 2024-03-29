using EweForum.Data;
using EweForum.Infrastructure.Data.Datasets.JsObjects;
using EweForum.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;


namespace Microsoft.EntityFrameworkCore.Metadata.Builders
{
    
    public static class ModelBuilderExtensions 
    {
       

        public static void SeedCountries(this ModelBuilder modelBuilder)
        {
            var json = File.ReadAllText("../EweForum.Infrastructure/Data/Datasets/countries.json");

            var countries = (CountryJs[])JsonConvert.DeserializeObject(json, typeof(CountryJs[]));
            List<Country>data = new List<Country>();
            foreach(var entry in countries)
            {
                data.Add(new Country
                {
                    Name = entry.Name,
                    Id = entry.Code,
                });
            }
            modelBuilder.Entity<Country>().HasData(data);
        }

        public static void SeedTopics(this ModelBuilder modelBuilder)
        {
            var json = File.ReadAllText("../EweForum.Infrastructure/Data/Datasets/topics.json");

            var topics = (TopicJs[])JsonConvert.DeserializeObject(json, typeof(TopicJs[]));
            List<Topic> data = new List<Topic>();
            int id = 1;
            foreach (var entry in topics)
            {

                data.Add(new Topic
                {   Id = id,
                    Title = entry.Title,
                    IsActive = entry.IsActive,
                    Description = entry.Description,
                    UpdatedOn = DateTime.Now,
                    CreatedOn = DateTime.Now,
                    ForumUserId= "23bf5fc9-cefd-45d3-8f2b-82e34b675c40",

                }); 
                id++;
            }
            modelBuilder.Entity<Topic>().HasData(data);
        }
        public static async void SeedUsers(this ModelBuilder modelBuilder)
        {
            var json = File.ReadAllText("../EweForum.Infrastructure/Data/Datasets/users.json");
            var users = (UserJs[])JsonConvert.DeserializeObject(json, typeof(UserJs[]));
            var hasher = new PasswordHasher<ForumUser>();
            foreach (var user in users)
            {
                List<JoinedTopic> joinedTopics = new List<JoinedTopic>();

                var userModel = Activator.CreateInstance<ForumUser>();
                userModel.Id = Guid.NewGuid().ToString();
                userModel.UserName = user.Username;
                userModel.NormalizedUserName = user.Username.ToLower();
                userModel.Email = user.Email;
                userModel.NormalizedEmail = user.Email.ToLower();
                userModel.PasswordHash = hasher.HashPassword(userModel, user.Password);
                userModel.CountryId = user.CountryId;
                List<JoinedTopic>JoinedTopics = new List<JoinedTopic>();
                foreach(var topicId in user.JoinedTopics)
                {
                    
                        if(!JoinedTopics.Any(jt => jt.TopicId == topicId))
                        {
                            JoinedTopics.Add(new JoinedTopic
                            {
                                ForumUser = userModel,
                                TopicId = topicId,
                            });
                        }
                    
                }
                userModel.JoinedTopics = joinedTopics;
                modelBuilder.Entity<ForumUser>().HasData(userModel);
                modelBuilder.Entity<IdentityUserRole<string>>()
                .HasData( new IdentityUserRole<string> {
                    UserId = userModel.Id,
                    RoleId = "1bda777f-d458-4ae6-b89a-e1f019149bec",
                });
            }

        }
        public static void SeedJoinedTopics(this ModelBuilder modelBuilder)
        {
            var json = File.ReadAllText("../EweForum.Infrastructure/Data/Datasets/joinedTopics.json");
            var userJoinedTopics = (UserJoinTopicJs[])JsonConvert.DeserializeObject(json, typeof(UserJoinTopicJs[]));
            List<JoinedTopic> joinedTopics = new List<JoinedTopic>();
            
            foreach(var entry in userJoinedTopics)
            {
                foreach(var topicId in entry.TopicsIds)
                {
                    if(!joinedTopics.Any(item => item.TopicId==topicId && item.ForumUserId == entry.ForumUserId)){
                        joinedTopics.Add(new JoinedTopic{
                            ForumUserId = entry.ForumUserId,
                            TopicId = topicId,
                        });
                    }
                   
                }
            }
            foreach (var item in joinedTopics)
            {
                modelBuilder.Entity<JoinedTopic>().HasData(
                       new JoinedTopic
                       {
                           ForumUserId = item.ForumUserId,
                           TopicId = item.TopicId,
                       });
            }
        }
    }
}
