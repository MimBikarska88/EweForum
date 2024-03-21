using EweForum.Infrastructure.Data.Datasets.JsObjects;
using EweForum.Infrastructure.Data.Models;
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
    }
}
