using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EweForum.Infrastructure.Migrations
{
    public partial class SeedPosts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "CreatedOn", "End", "EventDescription", "EventTitle", "ForumUserId", "ModifiedOn", "PostType", "Start", "Title", "TopicId", "VideoDescription", "VideoTitle", "VideoUrl" },
                values: new object[,]
                {
                    { 12, "", new DateTime(2024, 4, 17, 20, 58, 7, 960, DateTimeKind.Local).AddTicks(9030), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", "4635c38a-41ec-42e1-9f67-9f8b3a7e3d80", new DateTime(2024, 4, 17, 20, 58, 7, 960, DateTimeKind.Local).AddTicks(9072), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 3, "Are we alone?  What might alien species look like?  And what could we learn from them? Proudly presenting Life Beyond Remastered, a film that weaves all 3 episodes of the series together with new content and updated visuals & audio into a feature-length experience.  ", "LIFE BEYOND: Visions of Alien Life. Full Documentary Remastered (4K)", "https://www.youtube.com/embed/dww8Hekngmg?si=mctPlhuBfq9kylpw" },
                    { 13, "Engineers at L3Harris Technologies in Rochester, New York, have combined all 10 mirrors for NASA’s Nancy Grace Roman Space Telescope. Preliminary tests show the newly aligned optics, collectively called the IOA (Imaging Optics Assembly), will direct light into Roman’s science instruments extremely precisely. This will yield crisp images of space once the observatory launches. “This is the pre-launch first light, our first time seeing through the entire telescope,” said Joshua Abel, the lead systems engineer for the Roman Space Optical Telescope Assembly at NASA’s Goddard Space Flight Center in Greenbelt, Maryland. “We’re excited to enter the next phase of the project!”Each of Roman’s mirrors had passed individual tests, but this was the first time they were assessed together. Engineers had to make sure light would move through all of the optics in a tightly controlled way, or else the telescope’s images would appear blurred.“The telescope’s optics are crucial for all of Roman’s future observations,” said Bente Eegholm, an optical engineer working on Roman’s Optical Telescope Assembly at Goddard. “In addition to the large primary mirror and the secondary mirror, eight relay mirrors serve Roman’s two science instruments. All 10 telescope mirrors need to be aligned to well within the width of a human hair in order to optimize the telescope’s imaging quality such that Roman can fully achieve its science goals.”", new DateTime(2024, 4, 17, 20, 58, 7, 960, DateTimeKind.Local).AddTicks(9076), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", "4635c38a-41ec-42e1-9f67-9f8b3a7e3d80", new DateTime(2024, 4, 17, 20, 58, 7, 960, DateTimeKind.Local).AddTicks(9078), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "NASA’s Roman Space Telescope’s ‘Eyes’ Pass First Vision Test", 3, "", "", "" },
                    { 14, "", new DateTime(2024, 4, 17, 20, 58, 7, 960, DateTimeKind.Local).AddTicks(9081), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", "4635c38a-41ec-42e1-9f67-9f8b3a7e3d80", new DateTime(2024, 4, 17, 20, 58, 7, 960, DateTimeKind.Local).AddTicks(9082), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 3, "We often assume that advanced technology will make it easy for aliens to colonize space. But what if space exploration is always difficult, no matter how advanced you are? \r\nLet’s travel back in human history, to the colonization of Oceania over 5000 years ago, to find parallels between ancient explorers and extraterrestrial civilizations.", "There Are Thousands of Alien Empires in The Milky Way", "https://www.youtube.com/embed/L_JQOH1tEEA?si=jfkqx7vJ_bHS9YSG" },
                    { 15, "", new DateTime(2024, 4, 17, 20, 58, 7, 960, DateTimeKind.Local).AddTicks(9085), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", "4635c38a-41ec-42e1-9f67-9f8b3a7e3d80", new DateTime(2024, 4, 17, 20, 58, 7, 960, DateTimeKind.Local).AddTicks(9087), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 3, "Stories of near misses with UAPs in flight ignite a conversation about a serious threat in our skies not just in America, but around the world.", "The Global Threat (Full Episode) | UFOs: Investigating the Unknown", "https://www.youtube.com/embed/gQcMa9kPfR4?si=jEXZRMf4d4gYzTG1" },
                    { 16, "A powerful new European space telescope will bring astronomers closer than ever to answering a longstanding question: will the universe, which is expanding, do so forever?\r\n\r\nCalled Euclid, the telescope was launched on 1 July 2023 and is observing the dark universe from its vantage point 1.5 million kilometres from Earth. Looking in near-infrared and visible light, Euclid will take images of some 10 billion galaxies in its quest to understand both dark energy – which drives the expansion of the universe – and dark matter, which accounts for three quarters of all matter in the universe. Dark energy is a mysterious force that may have been driving the expansion of the universe since the Big Bang 13.8 billion years ago. Dark matter is an unseen form noticed by its gravitational effects on galaxies but never directly detected. \r\n\r\n‘Those are really two mystery components in our universe,’ said Professor Henk Hoekstra, a researcher in observational cosmology at Leiden University in the Netherlands. ‘We have no idea really what they are.’Of the mass-energy content of the universe, 68% comes from dark energy, 27% from dark matter and 5% from ordinary matter. Euclid, named after a Greek mathematician who lived around 300 BC and founded geometry, is designed to tackle a physics challenge: to understand the structure of the universe resulting from dark matter and dark energy since the dawn of time with unprecedented precision. Such is the power of the telescope that it will also reveal other mysteries of the universe – from studying planets orbiting distant suns to discovering objects smaller than stars found throughout the Milky Way. \r\n\r\n‘We are going to exploit Euclid’s unique capabilities,’ said Professor Eduardo Martin, a principal investigator at the Institute of Astrophysics of the Canary Islands in Spain. Major map Hoekstra leads a research project that received EU funding to use images that only Euclid can provide to shed light on the dark universe. Called Observational Cosmology Using Large Imaging Surveys, or OCULIS, the five-year project began in September 2023. ‘We basically make a giant map of the matter distribution in the universe,’ Hoekstra said.“We basically make a giant map of the matter distribution in the universe. Professor Henk Hoekstra, OCULIS. Euclid will build the map by gauging the bending of light around galaxies – a process called weak gravitational lensing. This makes it possible to measure the amount of dark matter surrounding galaxies and, by extension, its spread across the universe. The result will be improved understanding of the links between galaxies and dark matter and of the number of stars and volume of gas in each galaxy.A better measure of dark energy can be obtained thanks to the sheer volume of the universe that Euclid will observe – as much in two days as the Hubble Space Telescope in its full 30 years in space. Measuring each galaxy will offer new information about the universe’s expansion rate, which is roughly 70 km per second, but appears to be getting faster as a result of dark energy.At its core, Euclid addresses the fundamental question about why the expansion is accelerating, according to Hoekstra. ‘There must be new physics there,’ he said. ‘We’re testing this at the next level.Euclid is a fully European mission that got underway in 2011. The original plan by the European Space Agency, or ESA, was to launch the telescope in 2022 on a Russian rocket.After the Russian invasion of Ukraine in February 2022, ESA severed ties with Russia and the telescope was moved to a SpaceX Falcon 9 rocket.Euclid studies the universe with a 1.2-metre-wide primary mirror and a wide field of view. These dimensions mean that, in every picture taken, the telescope covers an area 2.5 times larger than the size of the full Moon.That’s useful for studying not just galaxies, but also much smaller objects – an area of interest to Martin at the Institute of Astrophysics of the Canary Islands.He leads a separate EU-funded project to use Euclid to hunt for objects smaller than stars hiding in the Milky Way. Known as substellar objects, these include bodies such as brown dwarfs – failed stars that never gained enough mass to ignite fusion in their cores – and giant planets many times the mass of Jupiter.", new DateTime(2024, 4, 17, 20, 58, 7, 960, DateTimeKind.Local).AddTicks(9090), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", "4635c38a-41ec-42e1-9f67-9f8b3a7e3d80", new DateTime(2024, 4, 17, 20, 58, 7, 960, DateTimeKind.Local).AddTicks(9091), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Top space telescope from Europe seeks to solve riddles of the universe", 3, "", "", "" },
                    { 17, "", new DateTime(2024, 4, 17, 20, 58, 7, 960, DateTimeKind.Local).AddTicks(9094), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gather with fellow astronomy enthusiasts at the Riverside Park Observatory for an enchanting evening of cosmic wonder and camaraderie. As the Earth intersects with the debris left by the legendary Halley's Comet, the night sky will come alive with a dazzling display of shooting stars. With May's clear skies and minimal light pollution, we'll have the perfect conditions to marvel at nature's celestial fireworks.", "Annual Starry Trail by Riverside Park Observatory, 123 Celestial Way, Springfield, USA", "4635c38a-41ec-42e1-9f67-9f8b3a7e3d80", new DateTime(2024, 4, 17, 20, 58, 7, 960, DateTimeKind.Local).AddTicks(9096), 1, new DateTime(2024, 5, 17, 20, 58, 7, 960, DateTimeKind.Local).AddTicks(9097), "", 3, "", "", "" },
                    { 18, "", new DateTime(2024, 4, 17, 20, 58, 7, 960, DateTimeKind.Local).AddTicks(9102), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", "4635c38a-41ec-42e1-9f67-9f8b3a7e3d80", new DateTime(2024, 4, 17, 20, 58, 7, 960, DateTimeKind.Local).AddTicks(9104), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 3, "Just thought some of his suggestions were awesome so I'm putting the video in the group. You can check them out", "The 15 Best Sci-Fi Books I've Ever Read [Updated] by Bookpilled youtube channel", "https://www.youtube.com/embed/pP0XnfC1jVM?si=BO0l602GvMenuHhV" }
                });

           
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18);

           
        }
    }
}
