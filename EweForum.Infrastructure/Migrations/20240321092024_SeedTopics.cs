using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EweForum.Infrastructure.Migrations
{
    public partial class SeedTopics : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedOn", "Description", "ForumUserId", "IsActive", "Title", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2272), "A community for discussing all things related to machines and metal combined.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Industrial Metal", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2232) },
                    { 2, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2279), "A place for flamenco enthusiasts to share tips, tricks, and discuss their favorite gear and techniques.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Flamenco Enthusiasts", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2277) },
                    { 3, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2282), "Exploring the wonders of outer space, from celestial bodies to cutting-edge space missions.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Space Exploration", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2281) },
                    { 4, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2286), "A community for photographers to share their work, techniques, and experiences.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Photography", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2284) },
                    { 5, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2292), "For passionate football fans to discuss matches, players, and strategies.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Football Fans", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2288) },
                    { 6, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2298), "Keeping up with the latest global news and events.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "World News", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2296) },
                    { 7, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2303), "Discussing ways to preserve and protect the environment for future generations.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Environmental Conservation", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2301) },
                    { 8, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2308), "Exploring the latest fashion trends, styles, and industry news.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Fashion Trends", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2306) },
                    { 9, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2312), "Sharing recipes, tips, and techniques for delicious and nutritious vegan meals.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Vegan Meals", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2310) },
                    { 10, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2318), "For bookworms to discuss their favorite novels, authors, and literary themes.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Literature Lovers", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2316) },
                    { 11, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2322), "Discussing medical breakthroughs, health tips, and wellness strategies.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Medicine and Health", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2320) },
                    { 12, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2327), "A community for programmers to share code, ask questions, and discuss programming languages and techniques.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Programming Community", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2325) },
                    { 13, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2370), "For fitness enthusiasts to share workout routines, diet plans, and motivation tips.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Fitness Freaks", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2368) },
                    { 14, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2376), "Sharing ideas, tips, and tutorials for do-it-yourself projects and crafts.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "DIY Projects", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2373) },
                    { 15, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2380), "A community for animal lovers to share cute photos, adoption stories, and pet care tips.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Animal Lovers", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2378) },
                    { 16, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2400), "Discussing political ideologies, current events, and policy issues.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Political Debates", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2397) },
                    { 17, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2404), "For artists of all mediums to share their work, techniques, and inspiration.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Artists' Corner", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2402) },
                    { 18, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2413), "Sharing travel experiences, tips, and recommendations for exploring the world.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Travel Enthusiasts", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2411) },
                    { 19, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2418), "A community for cinephiles to discuss movies, directors, and cinematic techniques.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Film Buffs", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2416) },
                    { 20, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2422), "Exploring historical events, figures, and civilizations from around the world.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "History Buffs", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2421) },
                    { 21, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2427), "For home cooks and foodies to share recipes, cooking tips, and culinary adventures.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Cooking Enthusiasts", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2425) },
                    { 22, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2432), "Discussing the latest advancements in technology, gadgets, and digital trends.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Technology Innovations", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2430) },
                    { 23, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2435), "A community for yogis and meditation practitioners to share techniques, experiences, and wellness tips.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Yoga and Meditation", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2434) },
                    { 24, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2438), "Exploring the realms of science fiction and fantasy literature, movies, and TV shows.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Science Fiction & Fantasy", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2437) },
                    { 25, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2441), "A supportive community for parents to share advice, experiences, and parenting tips.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Parenting Advice", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2440) },
                    { 26, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2445), "Discussing cryptocurrency news, investment strategies, and blockchain technology.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Cryptocurrency Investors", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2443) },
                    { 27, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2448), "Sharing ideas, tips, and inspiration for interior design and home decor.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Hygge", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2446) },
                    { 28, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2451), "For gardeners to share tips, advice, and photos of their gardens.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Gardening Enthusiasts", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2450) },
                    { 29, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2454), "Discussing psychological theories, mental health, and human behavior.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Psychology Discussions", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2453) },
                    { 30, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2457), "A community for beer lovers to discuss craft beer, breweries, and tasting experiences.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Craft Beer Enthusiasts", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2456) },
                    { 31, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2460), "For entrepreneurs and startup enthusiasts to share advice, resources, and success stories.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Business Startups", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2459) },
                    { 32, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2464), "A community for language learners to practice, share resources, and seek advice.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Language Learning", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2462) },
                    { 33, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2467), "Sharing photos and techniques for capturing the beauty of the night sky.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Astrophotography", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2465) },
                    { 34, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2471), "For cyclists to discuss bikes, routes, and cycling events.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Cycling Community", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2470) },
                    { 35, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2474), "A community for culinary enthusiasts to participate in cooking challenges and share their creations.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Cooking Challenges", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2473) },
                    { 36, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2477), "A supportive space for parents to seek advice, share experiences, and find solidarity.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Parenting Support", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2476) },
                    { 37, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2481), "Receiving constructive feedback and critique on photography techniques and compositions.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Photography Critique", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2479) },
                    { 38, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2484), "Discussing the causes, impacts, and solutions to climate change.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Climate Change Discussions", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2482) },
                    { 39, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2487), "For musicians and producers to share techniques, software recommendations, and collaborate on music projects.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Music Production", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2486) },
                    { 40, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2490), "Exploring the wonders of the cosmos, from stars and galaxies to black holes and nebulae.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Astronomy Enthusiasts", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2489) },
                    { 41, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2493), "Discussing AI technologies, applications, and ethical implications.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Artificial Intelligence", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2492) },
                    { 42, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2496), "A community for book lovers to discuss their current reads, share recommendations, and host virtual book clubs.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Book Club", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2495) }
                });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedOn", "Description", "ForumUserId", "IsActive", "Title", "UpdatedOn" },
                values: new object[,]
                {
                    { 43, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2500), "A community for setting and achieving fitness goals, sharing progress, and supporting each other's journey.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Fitness Challenges", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2498) },
                    { 44, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2503), "Discussing nutrition, meal planning, and healthy eating habits for a balanced lifestyle.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Healthy Eating", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2502) },
                    { 45, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2506), "A place for fashion enthusiasts to seek advice, share styling tips, and discuss the latest trends.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Fashion Advice", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2505) },
                    { 46, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2509), "Exploring the therapeutic benefits of art-making, creative expression, and self-discovery.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Art Therapy", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2508) },
                    { 47, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2512), "A supportive space for writers to share their work, receive feedback, and improve their craft.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Writing Workshop", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2511) },
                    { 48, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2516), "Discussing VR technology, gaming experiences, and immersive virtual worlds.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Virtual Reality", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2514) },
                    { 49, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2519), "For baking enthusiasts to share recipes, baking tips, and showcase their baked creations.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Baking Enthusiasts", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2517) },
                    { 50, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2522), "A community for sharing motivational quotes, success stories, and tips for staying committed to fitness goals.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Fitness Motivation", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2521) },
                    { 51, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2525), "Connecting rescue animals with loving homes, sharing adoption stories, and promoting pet welfare.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Pet Adoption", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2524) },
                    { 52, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2528), "Discussing thought-provoking documentaries, exploring social issues, and documentary filmmaking techniques.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Documentary Films", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2527) },
                    { 53, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2531), "We are all the indian guy with the pool but not just at 2 am but 24/7", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "DIY Home Improvement", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2530) },
                    { 54, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2535), "For aspiring and seasoned entrepreneurs to share insights, resources, and strategies for success in business.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Entrepreneurship", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2533) },
                    { 55, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2538), "", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Mindfulness Meditation", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2537) },
                    { 56, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2541), "Exploring the world of castles, from medieval fortresses to fairytale palaces, discussing history, architecture, and legends surrounding these majestic structures.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Castle Connoisseurs", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2540) },
                    { 57, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2544), "Indulging in the world of pastries and baked goods, from flaky croissants and decadent cakes to delicate macarons and traditional pies.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Pastry Paradise", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2543) },
                    { 58, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2547), "Journeying back in time to the medieval era, exploring life, culture, and warfare in the Middle Ages, from knights and castles to feudalism and chivalry.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Medieval Meanderings", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2546) },
                    { 59, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2584), "A collective for craft beer enthusiasts to share homebrewing recipes, brewery visits, and discussions about the art and science of beer-making.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Craft Beer Collective", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2583) },
                    { 60, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2588), "A society for aficionados of sweets and desserts, from creamy gelato and rich chocolates to fruity tarts and sugary confections.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Sweet Tooth Society", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2586) },
                    { 61, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2591), "Chronicling the history and stories of castles around the world, from iconic landmarks like Edinburgh Castle to lesser-known fortifications with fascinating tales.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Castle Chronicles", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2590) },
                    { 62, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2594), "A brotherhood of beer aficionados, celebrating the camaraderie and community spirit fostered by the love of good beer and great company.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Brewery Brotherhood", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2593) },
                    { 63, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2597), "Indulging in the artistry and craftsmanship of French patisserie, from delicate éclairs and flaky mille-feuille to buttery croissants and colorful macarons.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Patisserie Passion", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2596) },
                    { 64, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2601), "A fellowship of fantasy enthusiasts exploring fictional castles from literature, movies, and games, from Hogwarts Castle to the Red Keep of King's Landing.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Fantasy Fortress Fellowship", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2599) },
                    { 65, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2604), "For fans of dark southern country music, embracing the eerie atmospheres, haunting melodies, and swampy vibes of bands like Those Poor Bastards and Sons of Perdition.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Swamp Metal Syndicate", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2603) },
                    { 66, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2609), "Delving into the world of cryptids and mythical creatures, from Bigfoot and the Loch Ness Monster to Mothman and the Chupacabra, exploring sightings, legends, and cryptozoological mysteries.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Cryptid Chronicles", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2607) },
                    { 67, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2612), "Gathering around the virtual campfire to share and discuss spooky stories, urban legends, and chilling encounters with the unknown.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Tales from the Shadows", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2610) },
                    { 68, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2615), "Exploring the realms of the paranormal, from ghost sightings and haunted locations to UFO encounters and unexplained phenomena, and sharing personal experiences and investigations.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Paranormal Pursuit", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2614) },
                    { 69, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2618), "A collection of favorite quotes from literature, philosophy, movies, and beyond, sharing timeless words of wisdom and inspiration.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Words of Wisdom", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2617) },
                    { 70, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2621), "A community for fans of Southern Gothic literature and culture, discussing themes of decay, isolation, and the grotesque in works by authors like Flannery O'Connor, William Faulkner, and Cormac McCarthy.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Southern Gothic Society", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2620) },
                    { 71, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2625), "Dedicated to the study and exploration of cryptids and unknown animals, sharing research, eyewitness accounts, and investigations into elusive creatures.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Cryptozoology Club", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2623) },
                    { 72, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2628), "A gathering place for lovers of mysteries and thrillers, discussing whodunits, detective stories, and psychological suspense novels, and sharing recommendations for gripping reads.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Midnight Mysteries", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2626) },
                    { 73, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2631), "Embarking on a journey to uncover the mysteries of the supernatural world, from psychic phenomena and hauntings to demonic possessions and spiritual encounters.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Supernatural Seekers", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2630) },
                    { 74, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2634), "Sharing and discussing favorite quotes from literature, movies, music, and pop culture, from profound insights to witty one-liners.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Quotable Quotes Corner", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2633) },
                    { 75, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2637), "For home cooks and foodies to share recipes, cooking tips, and culinary adventures.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Cooking Enthusiasts", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2636) },
                    { 76, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2640), "Discussing the latest advancements in technology, gadgets, and digital trends.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Technology Innovations", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2639) },
                    { 77, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2644), "A community for yogis and meditation practitioners to share techniques, experiences, and wellness tips.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Yoga and Meditation", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2642) },
                    { 78, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2647), "For anime enthusiasts to discuss their favorite series, characters, and genres.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Anime", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2646) },
                    { 79, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2650), "Exploring the realms of science fiction and fantasy literature, movies, and TV shows.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Science Fiction & Fantasy", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2649) },
                    { 80, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2653), "A supportive community for parents to share advice, experiences, and parenting tips.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Parenting Advice", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2652) },
                    { 81, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2656), "Discussing cryptocurrency news, investment strategies, and blockchain technology.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Cryptocurrency Investors", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2655) },
                    { 82, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2659), "Sharing ideas, tips, and inspiration for interior design and home decor.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Home Decor Inspiration", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2658) },
                    { 83, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2663), "For gardeners to share tips, advice, and photos of their gardens.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Gardening Enthusiasts", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2661) },
                    { 84, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2666), "Discussing psychological theories, mental health, and human behavior.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Psychology Discussions", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2665) }
                });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedOn", "Description", "ForumUserId", "IsActive", "Title", "UpdatedOn" },
                values: new object[,]
                {
                    { 85, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2669), "A cozy corner for kawaii enthusiasts to share their love for all things cute, from adorable characters to colorful accessories.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Kawaii Cafe Corner", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2668) },
                    { 86, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2672), "A society celebrating the beauty of cherry blossoms and Japanese culture, hosting events and discussions inspired by the ephemeral beauty of sakura season.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Sakura Blossom Society", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2671) },
                    { 87, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2675), "Indulging in the chewy goodness of mochi treats, from traditional flavors to innovative creations, and sharing recipes and recommendations.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Mochi Madness Club", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2674) },
                    { 88, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2678), "A virtual nook for cat lovers and kawaii enthusiasts, featuring cute cat memes, GIFs, and discussions about feline friends.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Neko Nook", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2677) },
                    { 89, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2682), "A hangout spot for fans of Harajuku fashion and kawaii culture, sharing outfit ideas, shopping tips, and trends from Tokyo's vibrant street scene.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Harajuku Hangout", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2680) },
                    { 90, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2685), "Embarking on culinary adventures inspired by kawaii aesthetics, from adorable bento boxes to cute character-themed desserts.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Kawaii Kitchen Adventures", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2683) },
                    { 91, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2688), "Finding tranquility and inspiration in Japanese gardens, exploring the principles of zen and mindfulness through nature.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Zen Garden Zenith", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2687) },
                    { 92, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2691), "A hideout for Hello Kitty fans to connect and share their passion for Sanrio's beloved character, from merchandise collections to fan art.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Hello Kitty Hideout", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2690) },
                    { 93, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2694), "A community of dreamers embracing the concept of yume (dream) in Japanese culture, sharing aspirations, goals, and whimsical visions.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Yume Dreamers", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2693) },
                    { 94, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2698), "Crafting cute and kawaii creations, from plush toys to DIY accessories, and sharing crafting tips and tutorials.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Kawaii Crafting Club", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2696) },
                    { 95, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2701), "Discussing music composition techniques, songwriting tips, and musical inspiration.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Music Composition", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2699) },
                    { 96, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2704), "How to lose weight and not starve (too much)", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Weight Loss Recipes", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2703) },
                    { 97, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2707), "Engaging in discussions about books, characters, plot twists, and literary analysis that you wish you didn't read.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Terrible Book Discussions", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2706) },
                    { 98, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2710), "Participating in fitness challenges, setting goals, and tracking progress. Only for crossfitters.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Fitness Challenges", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2709) },
                    { 99, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2713), "Exploring emerging technology trends, innovations, and future predictions.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Technology Trends", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2712) },
                    { 100, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2717), "Analyzing films, cinematography techniques, and narrative structures.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Film Analysis", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2715) },
                    { 101, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2720), "Exploring the lives, achievements, and legacies of historical figures.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Historical Figures", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2718) },
                    { 102, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2723), "Sharing creative writing prompts, exercises, and challenges to inspire writing.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Creative Writing Prompts", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2722) },
                    { 103, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2747), "A tavern for horror writers to share spine-chilling stories, discuss writing techniques, and collaborate on dark and unsettling narratives.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Terror Tales Tavern", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2745) },
                    { 104, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2752), "A guild for writers of gothic fiction, where members delve into the shadows of the human psyche, crafting tales of terror and suspense.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Gothic Writers Guild", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2750) },
                    { 105, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2756), "An ensemble of writers and readers, all channeling eldritch echoes, where horror writers explore cosmic horrors, eldritch abominations, and the unknown terrors of the cosmos.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Eldritch Echoes Ensemble", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2754) },
                    { 106, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2760), "A workshop for fans of The Witcher series, where enthusiasts discuss Geralt's adventures, monster hunting techniques, and the rich lore of the world created by Andrzej Sapkowski.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Witcher's Workshop", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2758) },
                    { 107, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2763), "A sanctuary for Dark Souls fans to share their experiences, strategies, and lore interpretations from the challenging and atmospheric games in the series.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Dark Souls Sanctuary", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2762) },
                    { 108, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2766), "Pioneering the mind-bending puzzles and innovative gameplay of the Portal series, where fans discuss portal mechanics, companion cubes, and the enigmatic GLaDOS.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Portal Pioneers", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2765) },
                    { 109, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2769), "A den for fans of the Doom series, where demon slayers gather to discuss fast-paced action, brutal weapons, and the eternal battle against the forces of Hell.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Doom Den", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2768) },
                    { 110, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2772), "An oasis for Overwatch players, where heroes assemble to discuss strategies, share highlight reels, and celebrate the vibrant characters and diverse maps of Blizzard's team-based shooter.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Overwatch Oasis", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2771) },
                    { 111, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2775), "Building empires and shaping history in the Civilization series, where players discuss strategy, diplomacy, and the art of war in Sid Meier's iconic turn-based strategy game.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Civilization Citadel", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2774) },
                    { 112, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2779), "Embracing the tranquility and charm of Stardew Valley, where virtual farmers tend to crops, raise animals, and forge friendships in ConcernedApe's beloved farming simulation game.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Stardew Valley Valley", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2777) },
                    { 113, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2782), "Navigating the sprawling open-world landscapes and criminal underworlds of the Grand Theft Auto series, where players discuss heists, car chases, and the chaos of life in the city.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "GTA Gangland", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2780) },
                    { 114, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2785), "A community for computer hardware enthusiasts to stay updated on the latest news, releases, and innovations in the world of technology, from CPUs and GPUs to storage solutions and peripherals.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Tech Tidbits", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2784) },
                    { 115, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2788), "A corner for exploring conspiracy theories and alternative narratives, where members delve into mysteries, cover-ups, and unexplained phenomena, sharing theories and evidence.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Conspiracy Corner", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2787) },
                    { 116, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2791), "A space for discussing atmospheric phenomena and weather mysteries, from auroras and lightning sprites to ball lightning and mysterious cloud formations.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Atmospheric Anomalies", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2790) },
                    { 117, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2794), "A haven for computer hardware enthusiasts to share reviews, benchmarks, and DIY projects, discussing everything from overclocking to water cooling and RGB lighting.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Hardware Haven", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2793) },
                    { 118, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2798), "A hideout for Hello Kitty fans to connect and share their passion for Sanrio's beloved character, from merchandise collections to fan art.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Hello Kitty Hideout", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2796) },
                    { 119, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2801), "A community of dreamers embracing the concept of yume (dream) in Japanese culture, sharing aspirations, goals, and whimsical visions.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Yume Dreamers", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2799) },
                    { 120, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2804), "Crafting cute and kawaii creations, from plush toys to DIY accessories, and sharing crafting tips and tutorials.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Kawaii Crafting Club", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2803) },
                    { 121, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2807), "A community for Python enthusiasts to discuss best practices, libraries, and projects, sharing tips and tricks for mastering the versatile programming language.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Python Prodigies", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2806) },
                    { 122, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2810), "A junction for JavaScript developers to explore frameworks, tooling, and emerging trends in web development, from front-end frameworks like React to server-side technologies like Node.js.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "JavaScript Junction", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2809) },
                    { 123, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2813), "A community for basketball enthusiasts to discuss slam dunks, buzzer-beaters, and mind-blowing crossovers from the hardwood court.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "NBA", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2812) },
                    { 124, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2817), "A gathering place for die-hard soccer fans to debate the beautiful game, from stunning goals to controversial referee decisions, and everything in between.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Soccer", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2815) },
                    { 125, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2820), "A cage for mixed martial arts enthusiasts to witness jaw-dropping knockouts, slick submissions, and adrenaline-fueled battles inside the octagon.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "MMA Mania", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2819) },
                    { 126, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2823), "A space for fans of Banksy's thought-provoking and often controversial street art to admire his creations, discuss their interpretations, and share sightings of his iconic works around the world.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Banksy", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2822) }
                });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedOn", "Description", "ForumUserId", "IsActive", "Title", "UpdatedOn" },
                values: new object[] { 127, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2826), "A celestial realm for fans of Bjork's avant-garde music to explore her eclectic discography, dissect her experimental soundscapes, and discuss the impact of her innovative approach to music-making.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Bjork", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2825) });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedOn", "Description", "ForumUserId", "IsActive", "Title", "UpdatedOn" },
                values: new object[] { 128, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2829), "A fiery pit for fans of Rammstein's explosive music to headbang to their heavy riffs, belt out their powerful lyrics, and discuss the German band's legendary live performances.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Rammstein", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2828) });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedOn", "Description", "ForumUserId", "IsActive", "Title", "UpdatedOn" },
                values: new object[] { 129, new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2832), "A community for music enthusiasts to explore the boundary-pushing sounds of Bjork, the industrial metal madness of Rammstein, and the subversive street art of Banksy, celebrating their contributions to the world of art and music.", "23bf5fc9-cefd-45d3-8f2b-82e34b675c40", true, "Psychadelics in sound waves", new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2831) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 129);
        }
    }
}
