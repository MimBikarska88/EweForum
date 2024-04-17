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
        public static void SeedPosts(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>().HasData(
                new Post
                {
                    Id = 12,
                    ForumUserId = "4635c38a-41ec-42e1-9f67-9f8b3a7e3d80",
                    TopicId = 3,
                    VideoTitle = "LIFE BEYOND: Visions of Alien Life. Full Documentary Remastered (4K)",
                    VideoDescription = "Are we alone?  What might alien species look like?  And what could we learn from them? Proudly presenting Life Beyond Remastered, a film that weaves all 3 episodes of the series together with new content and updated visuals & audio into a feature-length experience.  ",
                    VideoUrl = "https://www.youtube.com/embed/dww8Hekngmg?si=mctPlhuBfq9kylpw",
                    PostType = EweForum.Utilites.Enums.PostType.Media,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                },
                new Post
                {
                    Id = 13,
                    ForumUserId = "4635c38a-41ec-42e1-9f67-9f8b3a7e3d80",
                    TopicId = 3,
                    Content = "Engineers at L3Harris Technologies in Rochester, New York, have combined all 10 mirrors for NASA’s Nancy Grace Roman Space Telescope. Preliminary tests show the newly aligned optics, collectively called the IOA (Imaging Optics Assembly), will direct light into Roman’s science instruments extremely precisely. This will yield crisp images of space once the observatory launches. “This is the pre-launch first light, our first time seeing through the entire telescope,” said Joshua Abel, the lead systems engineer for the Roman Space Optical Telescope Assembly at NASA’s Goddard Space Flight Center in Greenbelt, Maryland. “We’re excited to enter the next phase of the project!”Each of Roman’s mirrors had passed individual tests, but this was the first time they were assessed together. Engineers had to make sure light would move through all of the optics in a tightly controlled way, or else the telescope’s images would appear blurred.“The telescope’s optics are crucial for all of Roman’s future observations,” said Bente Eegholm, an optical engineer working on Roman’s Optical Telescope Assembly at Goddard. “In addition to the large primary mirror and the secondary mirror, eight relay mirrors serve Roman’s two science instruments. All 10 telescope mirrors need to be aligned to well within the width of a human hair in order to optimize the telescope’s imaging quality such that Roman can fully achieve its science goals.”",
                    Title = "NASA’s Roman Space Telescope’s ‘Eyes’ Pass First Vision Test",
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    PostType = EweForum.Utilites.Enums.PostType.Text
                },
                new Post
                {
                    Id = 14,
                    ForumUserId = "4635c38a-41ec-42e1-9f67-9f8b3a7e3d80",
                    TopicId = 3,
                    VideoTitle = "There Are Thousands of Alien Empires in The Milky Way",
                    VideoDescription = "We often assume that advanced technology will make it easy for aliens to colonize space. But what if space exploration is always difficult, no matter how advanced you are? \r\nLet’s travel back in human history, to the colonization of Oceania over 5000 years ago, to find parallels between ancient explorers and extraterrestrial civilizations.",
                    VideoUrl = "https://www.youtube.com/embed/L_JQOH1tEEA?si=jfkqx7vJ_bHS9YSG",
                    PostType = EweForum.Utilites.Enums.PostType.Media,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                },
                new Post
                {
                    Id = 15,
                    ForumUserId = "4635c38a-41ec-42e1-9f67-9f8b3a7e3d80",
                    TopicId = 3,
                    VideoTitle = "The Global Threat (Full Episode) | UFOs: Investigating the Unknown",
                    VideoDescription = "Stories of near misses with UAPs in flight ignite a conversation about a serious threat in our skies not just in America, but around the world.",
                    VideoUrl = "https://www.youtube.com/embed/gQcMa9kPfR4?si=jEXZRMf4d4gYzTG1",
                    PostType = EweForum.Utilites.Enums.PostType.Media,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                }
                ,
                new Post
                {
                    Id = 16,
                    ForumUserId = "4635c38a-41ec-42e1-9f67-9f8b3a7e3d80",
                    TopicId = 3,
                    Title = "Top space telescope from Europe seeks to solve riddles of the universe",
                    Content = "A powerful new European space telescope will bring astronomers closer than ever to answering a longstanding question: will the universe, which is expanding, do so forever?\r\n\r\nCalled Euclid, the telescope was launched on 1 July 2023 and is observing the dark universe from its vantage point 1.5 million kilometres from Earth. Looking in near-infrared and visible light, Euclid will take images of some 10 billion galaxies in its quest to understand both dark energy – which drives the expansion of the universe – and dark matter, which accounts for three quarters of all matter in the universe. Dark energy is a mysterious force that may have been driving the expansion of the universe since the Big Bang 13.8 billion years ago. Dark matter is an unseen form noticed by its gravitational effects on galaxies but never directly detected. \r\n\r\n‘Those are really two mystery components in our universe,’ said Professor Henk Hoekstra, a researcher in observational cosmology at Leiden University in the Netherlands. ‘We have no idea really what they are.’Of the mass-energy content of the universe, 68% comes from dark energy, 27% from dark matter and 5% from ordinary matter. Euclid, named after a Greek mathematician who lived around 300 BC and founded geometry, is designed to tackle a physics challenge: to understand the structure of the universe resulting from dark matter and dark energy since the dawn of time with unprecedented precision. Such is the power of the telescope that it will also reveal other mysteries of the universe – from studying planets orbiting distant suns to discovering objects smaller than stars found throughout the Milky Way. \r\n\r\n‘We are going to exploit Euclid’s unique capabilities,’ said Professor Eduardo Martin, a principal investigator at the Institute of Astrophysics of the Canary Islands in Spain. Major map Hoekstra leads a research project that received EU funding to use images that only Euclid can provide to shed light on the dark universe. Called Observational Cosmology Using Large Imaging Surveys, or OCULIS, the five-year project began in September 2023. ‘We basically make a giant map of the matter distribution in the universe,’ Hoekstra said.“We basically make a giant map of the matter distribution in the universe. Professor Henk Hoekstra, OCULIS. Euclid will build the map by gauging the bending of light around galaxies – a process called weak gravitational lensing. This makes it possible to measure the amount of dark matter surrounding galaxies and, by extension, its spread across the universe. The result will be improved understanding of the links between galaxies and dark matter and of the number of stars and volume of gas in each galaxy.A better measure of dark energy can be obtained thanks to the sheer volume of the universe that Euclid will observe – as much in two days as the Hubble Space Telescope in its full 30 years in space. Measuring each galaxy will offer new information about the universe’s expansion rate, which is roughly 70 km per second, but appears to be getting faster as a result of dark energy.At its core, Euclid addresses the fundamental question about why the expansion is accelerating, according to Hoekstra. ‘There must be new physics there,’ he said. ‘We’re testing this at the next level.Euclid is a fully European mission that got underway in 2011. The original plan by the European Space Agency, or ESA, was to launch the telescope in 2022 on a Russian rocket.After the Russian invasion of Ukraine in February 2022, ESA severed ties with Russia and the telescope was moved to a SpaceX Falcon 9 rocket.Euclid studies the universe with a 1.2-metre-wide primary mirror and a wide field of view. These dimensions mean that, in every picture taken, the telescope covers an area 2.5 times larger than the size of the full Moon.That’s useful for studying not just galaxies, but also much smaller objects – an area of interest to Martin at the Institute of Astrophysics of the Canary Islands.He leads a separate EU-funded project to use Euclid to hunt for objects smaller than stars hiding in the Milky Way. Known as substellar objects, these include bodies such as brown dwarfs – failed stars that never gained enough mass to ignite fusion in their cores – and giant planets many times the mass of Jupiter.",
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    PostType = EweForum.Utilites.Enums.PostType.Text
                }
                ,
                new Post
                {
                    Id = 17,
                    ForumUserId = "4635c38a-41ec-42e1-9f67-9f8b3a7e3d80",
                    TopicId = 3,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    Start = DateTime.Now.AddMonths(1),
                    EventTitle = "Annual Starry Trail by Riverside Park Observatory, 123 Celestial Way, Springfield, USA",
                    EventDescription = "Gather with fellow astronomy enthusiasts at the Riverside Park Observatory for an enchanting evening of cosmic wonder and camaraderie. As the Earth intersects with the debris left by the legendary Halley's Comet, the night sky will come alive with a dazzling display of shooting stars. With May's clear skies and minimal light pollution, we'll have the perfect conditions to marvel at nature's celestial fireworks.",
                    PostType = EweForum.Utilites.Enums.PostType.Event
                }
                ,
                new Post
                {
                    Id= 18,
                    ForumUserId = "4635c38a-41ec-42e1-9f67-9f8b3a7e3d80",
                    TopicId = 3,
                    VideoTitle = "The 15 Best Sci-Fi Books I've Ever Read [Updated] by Bookpilled youtube channel",
                    VideoDescription = "Just thought some of his suggestions were awesome so I'm putting the video in the group. You can check them out",
                    VideoUrl = "https://www.youtube.com/embed/pP0XnfC1jVM?si=BO0l602GvMenuHhV",
                    PostType = EweForum.Utilites.Enums.PostType.Media,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                }
                
                );
        }
    }
}
