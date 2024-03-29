using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EweForum.Infrastructure.Migrations
{
    public partial class SeedUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CountryId", "CreatedOn", "Discriminator", "Email", "EmailConfirmed", "IsActive", "LockoutEnabled", "LockoutEnd", "ModifiedOn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonalInfo", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "07b40a11-9941-4b21-a90a-605b11cdb487", 0, "daadac54-b890-4ece-a410-ee34a7e3d660", "CA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ForumUser", "katz_cakes@gmail.com", false, false, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "katz_cakes@gmail.com", "cocoagurl", "AQAAAAEAACcQAAAAEPaihd7np3pG8CfhRsdD2MNyk/YRf0qkF2p+0WB5JnMgXhvt0AL+o9Vp3wfVGyia2A==", "", null, false, "7f063318-71c4-4f38-9856-f1bdf0733263", false, "CocoaGurl" },
                    { "1093c6dc-48eb-486d-a866-b8f8b4bbf77b", 0, "28d4c5a1-f390-46b8-8644-9349b4f8ddcf", "CA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ForumUser", "victor_ulster@yahoo.com", false, false, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "victor_ulster@yahoo.com", "vectorvortex", "AQAAAAEAACcQAAAAEJyE37fr22/U1VGSSEU68tSx/gCkOMrE8IP1phw9W8/iX7kP7Ua/e7ibcax9LIH2ZQ==", "", null, false, "d97779fb-f40a-4445-ba77-ef2f0c90b6c1", false, "VectorVortex" },
                    { "4635c38a-41ec-42e1-9f67-9f8b3a7e3d80", 0, "9f925856-b3c3-45d7-8610-3e75209fb6e2", "DE", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ForumUser", "henrik_jakobsen@gmail.com", false, false, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "henrik_jakobsen@gmail.com", "henrik", "AQAAAAEAACcQAAAAEMra05952Kf5wUbGyat+OyS44yz4Mbefs5UKtKoBVvas2Yov50sZpAVmmcBo1deWFw==", "", null, false, "4196f7cc-bdd2-455f-a8e6-e0b62d77e5c3", false, "Henrik" },
                    { "4a99a16d-1096-44cb-96a3-053b56917bcf", 0, "4c948b71-d561-42c8-9233-6cbb0258a6d1", "FR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ForumUser", "EclipseEmber@yahoo.com", false, false, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "eclipseember@yahoo.com", "elysiumblimp", "AQAAAAEAACcQAAAAEGDrwqb7+3Jlou8OzSaNPshsA1s8sbPE06S8FuhOk94BYp/AqMsIeVJIK8fX1WVzlg==", "", null, false, "695b2c37-3d13-42ae-a535-b5e3e6c1a06e", false, "ElysiumBlimp" },
                    { "54c4d727-865e-438b-ab3f-339a689c5c19", 0, "dcc633ad-ab00-488a-82f4-6ac347416444", "PL", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ForumUser", "kiki_woods@gmail.com", false, false, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "kiki_woods@gmail.com", "kiki", "AQAAAAEAACcQAAAAEOBdbhkztaA3Yx1fRhGMlDoexiQPztBelPA5mTM8TwLHarfHOtDsBw/PTD+oK7JUSg==", "", null, false, "ec600039-1547-4d56-be0a-88ea3da03c58", false, "Kiki" },
                    { "5a118590-c2ac-4064-aab1-abbad1cd6bce", 0, "e6b23706-52f9-4622-b45c-a973e1bee406", "JP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ForumUser", "kim_lee_ayohasa@gmail.com", false, false, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "kim_lee_ayohasa@gmail.com", "kim", "AQAAAAEAACcQAAAAENm1RL9GSCICTY4oqGQA7TBGjjifNM/B1JCjtdwcH0ORZRW/xibg3TfS85wHgx1CQw==", "", null, false, "e7be453e-5457-4400-af38-d4abb03b715a", false, "Kim" },
                    { "6d07c695-8bfc-4a06-86e5-74bb86b3fd79", 0, "217c7021-61e1-46a4-a2db-77338faf4eb4", "BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ForumUser", "alexis_bladel_rughs@example.com", false, false, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "alexis_bladel_rughs@example.com", "enchantededen", "AQAAAAEAACcQAAAAEIxyztz4/i+wLqjZIDU6CO8PCsiKk3LvTeiBCzw8GtPBf677PWIIOMFf7Coi2fdPDw==", "", null, false, "fbda0149-1bd3-40c1-9534-56574f4387db", false, "EnchantedEden" },
                    { "6ebf8e6e-516b-463f-b996-dd327746e711", 0, "b7e4c8ae-0e7f-4110-88fb-8877a404c103", "BR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ForumUser", "andreas_michaelson@yahoo.com", false, false, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "andreas_michaelson@yahoo.com", "michaelson", "AQAAAAEAACcQAAAAEC8XXVcNDAj6d0Wy3E/WbSLK8PfbzXJhO99yuSMCQPiOy519YQLxiI+lr7cNUprYog==", "", null, false, "383d8de7-e823-4786-8017-600575d7b080", false, "Michaelson" },
                    { "73f3662c-2459-4b3e-8cc4-fabf43d05236", 0, "5f4395b2-1bce-4d3f-8518-bb4b0e2f8aa2", "US", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ForumUser", "marny_brahms@gmail.com", false, false, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "marny_brahms@gmail.com", "cosmiccascade", "AQAAAAEAACcQAAAAECJIpVbebk9ys9JFI13yECjlhveXL1L+0Nz2XEcnOKjxBMh+OM0yAcl/Vkp8MNexGA==", "", null, false, "2b10f5c6-c9da-47d9-af8d-95b8d7d35252", false, "CosmicCascade" },
                    { "79c263d0-fea3-4908-bc1e-d298311067d2", 0, "6e319cde-eac3-4b25-8221-d30c7faceaf5", "RU", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ForumUser", "blake_james@example.com", false, false, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "blake_james@example.com", "mysticalmeadow", "AQAAAAEAACcQAAAAENW+ad93Nvo/oj2h0nXC6h2gUM0Ph8SyxZkVJqkbQdNUFw5mmYRQac4gVB149hXdMA==", "", null, false, "8f6c5a05-837c-4373-888f-d4ff3d180654", false, "MysticalMeadow" },
                    { "7c61be63-6a12-4301-bd3b-cc50861735f0", 0, "ba2f8956-d60c-4847-aff6-86b2d413bccd", "GB", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ForumUser", "lyric_freak_delRey@gmail.com", false, false, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "lyric_freak_delrey@gmail.com", "lea seydoux", "AQAAAAEAACcQAAAAEGeZW8pe0K8oXEzHBfQCHHR/k14/oCV+KDAgVVpE/YKU7B58MTe9ZTiOCLPj7z2ytg==", "", null, false, "5713bd0b-1846-4130-a285-bb4041b57476", false, "Lea Seydoux" },
                    { "86e02b21-25d7-4246-af4f-beac10cff1a6", 0, "0fda44f3-7c41-4f98-9e8a-dc747ac11796", "US", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ForumUser", "dynamicDolphin17@gmail.com", false, false, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "dynamicdolphin17@gmail.com", "dynamicdolphin17", "AQAAAAEAACcQAAAAEDp1AygeiFHD0soTpTC7Jc3ZKivpllAbyCBhlZUFbHbbJqtZOCKycEmpZKHIhRU+Pw==", "", null, false, "33712872-88fd-4c69-8771-b9fac0bf8b1c", false, "dynamicDolphin17" },
                    { "88a75459-c19a-40f1-98bb-5d51bb514359", 0, "5a4bd47b-7762-4d6f-97aa-bfff8dd47f16", "DE", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ForumUser", "happyGoLucky42@example.com", false, false, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "happygolucky42@example.com", "happygolucky42", "AQAAAAEAACcQAAAAEIgFRzr8Z2ha2lhtGSlLqvjpmhbijQPHpKC+X4Oxpe2HQlCoR9zH7qMPeGU7Alh9JA==", "", null, false, "5b32a97c-64ef-414c-9cb9-723166056550", false, "happyGoLucky42" },
                    { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 0, "7e5f6def-47b6-4c54-a8f9-5a0d75026253", "AU", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ForumUser", "awesomeSauce88@hotmail.com", false, false, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "awesomesauce88@hotmail.com", "awesomesauce88", "AQAAAAEAACcQAAAAEKUlApr3uD8ODT5WZf9Dp/OYrycbu5bCYjBIkdCdiXLlBa1SPdRAYQ+yWIXwi0q5yQ==", "", null, false, "f364d296-9746-4a33-ad8e-994ae0009c00", false, "awesomeSauce88" },
                    { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 0, "85028a15-86ad-4937-8cd4-7870fe57565a", "JP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ForumUser", "arthur_yikes@gmail.com", false, false, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "arthur_yikes@gmail.com", "archie99", "AQAAAAEAACcQAAAAEPRQzKVAOrzhzxNTip9ACwLuTR1XcMbnVrGHw/lzcclMCiNxFybsvsltLO74j9VO6A==", "", null, false, "92723f63-f6c2-4423-9dac-480d02770a5c", false, "Archie99" },
                    { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 0, "a3429542-c813-4fe9-96c6-aa6e30fcc12f", "DE", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ForumUser", "quail_rjf93@pluto_mail.com", false, false, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "quail_rjf93@pluto_mail.com", "quantumquill", "AQAAAAEAACcQAAAAENdZhDBOFkPyvDd5kNYhjBYzT4VnODIfsz0cWyp85mygvvrobQezd3J93sFPqjfbBg==", "", null, false, "a9e6fcf0-1c22-4ed4-8efa-07238237c2e0", false, "QuantumQuill" },
                    { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 0, "dd95db04-7455-4e88-8272-46a3beef263a", "CA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ForumUser", "coolUser23@yahoo.com", false, false, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "cooluser23@yahoo.com", "cooluser23", "AQAAAAEAACcQAAAAEEuv+6UD3OIO2xOLbS0SkOZPrrAgm6tyLFtmEICQryUYCOB/RQEPgswnLgQa+9c0KQ==", "", null, false, "c7d0baea-5d11-428b-92dc-6df23c1142e2", false, "coolUser23" },
                    { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 0, "4340d8b5-7a34-407f-a434-3862d3fe25ea", "KR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ForumUser", "korean_language_center@gmail.com", false, false, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "korean_language_center@gmail.com", "sehee kim", "AQAAAAEAACcQAAAAEM0E28oKmuukOLc6ikPGg7YXsFWt4TB08rayVVBiebqcJhjfXJhGduVwhmsSG9pspg==", "", null, false, "179566e0-b454-4c74-8b10-bbdace715281", false, "Sehee Kim" },
                    { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 0, "5a3a175e-3b07-4ab2-8ffa-bb161b1d7c7b", "JP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ForumUser", "dreamyArtist21@example.com", false, false, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "dreamyartist21@example.com", "turbogamer55", "AQAAAAEAACcQAAAAEIi/c8iJ7/+3RXQmNZDC7Gz1h/3f8RIdmtZOPzJ59oVqnoPBDCFCQKIzfjaFVF/5Jg==", "", null, false, "4a20609f-d76e-4133-827f-1086cf335453", false, "TURBOGamer55" },
                    { "b0433d4e-d7df-4868-b831-a17f0a30af31", 0, "616f9842-374c-4280-ba31-a1ab17332a83", "JP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ForumUser", "尺の丂乇乃ﾚののﾶ丂@gmail.com", false, false, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "尺の丂乇乃ﾚののﾶ丂@gmail.com", "heylin", "AQAAAAEAACcQAAAAENWG3FAd9nkLRTdmefdas+28IhpRPfyOqNNW19XhC9Ki6altAgfl+fX7lsl1NdKVUw==", "", null, false, "62049cb9-e31f-44d2-abec-f6b9e8691672", false, "HeyLin" },
                    { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 0, "c136507b-a39a-4014-aa6a-e14398c96da6", "AU", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ForumUser", "lacrimus_maximus@hotmail.com", false, false, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "lacrimus_maximus@hotmail.com", "lzzy83", "AQAAAAEAACcQAAAAEEdWq4EVZ4WlQE1T2kgvh8uPgWm0/zUxNg5Z71EHgK/9cZY5otBWIVOn39g0Go2fdg==", "", null, false, "5d324504-9dbe-48f7-8f16-5e3003670987", false, "Lzzy83" },
                    { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 0, "164c1b06-ae33-45db-be0e-e67cad2bf7ef", "GB", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ForumUser", "maddie49_54_3587@gmail.com", false, false, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "maddie49_54_3587@gmail.com", "fusionfalcon", "AQAAAAEAACcQAAAAEDr54hsVneMzqO+OIjKMsBk3CkUQkRQwxv6ZNVioHnb1aG6zO6sRyZjuDqG/3EgBQw==", "", null, false, "a0610166-091b-4d4f-920f-7bdd1936c50f", false, "FusionFalcon" },
                    { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 0, "1af1f5a1-92ec-469a-8d97-53b087e23c75", "BG", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ForumUser", "black_swan@gmail.com", false, false, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "black_swan@gmail.com", "rapunzel", "AQAAAAEAACcQAAAAEB8wEBYivB5SQNBXGb5Fuxb/S2pP8EQ7yj9nW4SKwAbtzztTilZAWTQKm1Rrsnu1dg==", "", null, false, "34bb4155-af48-4a8b-a159-13c06ddaa49d", false, "Rapunzel" },
                    { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 0, "0a606dbe-f6c2-4b8b-80b0-14f243e71d40", "FR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ForumUser", "cherrymoncheri@example.com", false, false, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "cherrymoncheri@example.com", "craftyninja77", "AQAAAAEAACcQAAAAEP4g8yCA1RjE1k52ohwkedwaeLCEeMThENXkOpJgVjVj4+eu/10DPliRQ7SgIOFmUQ==", "", null, false, "00537aab-c57d-442d-87fc-2af496c924b5", false, "craftyNinja77" },
                    { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 0, "b2b7b8f2-ab05-478c-ae2d-927bf7c3e36d", "US", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ForumUser", "JackOutdoorAdventurer@gmail.com", false, false, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "jackoutdooradventurer@gmail.com", "jax", "AQAAAAEAACcQAAAAEAiGkf6PDMz2DrJ1N6A/wgDwCybd8myRVxO4pC52p5E0Po0k5sKxX2UtjF4+fyhXXQ==", "", null, false, "dc1aa84c-e201-4919-9a01-86388ca4519b", false, "Jax" },
                    { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 0, "ef3db528-cc90-42ad-9f5b-11a2e7bc1a8a", "GB", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ForumUser", "cleverCoder99@gmail.com", false, false, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "clevercoder99@gmail.com", "clevercoder99", "AQAAAAEAACcQAAAAEH558bQV5PTB/FSE4jS34iGzpd9otrROSzGMYdIZuX2fxbTtKNdPfwlyjwpBEtZi3g==", "", null, false, "d2e20192-afb8-4c49-88b0-3fbab94cbfc9", false, "cleverCoder99" },
                    { "d8a49048-5ac1-4586-907d-baceecb14fed", 0, "90edc278-0cfb-4e6b-8fed-65e460816d4b", "AU", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ForumUser", "blinkblink88@hotmail.com", false, false, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "blinkblink88@hotmail.com", "vanguardvale", "AQAAAAEAACcQAAAAEHDcwPcEXRXJ/ZNPSjfwaliRSjMHWiYzgF3wts6BuBAvMHIzetgZNhIKhk76z0IWOw==", "", null, false, "98c073cf-0cc4-4586-8ae7-146cd2204908", false, "VanguardVale" },
                    { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 0, "3b39742e-9579-4629-bd94-7ff8550bbe64", "FR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ForumUser", "sally_su@yahoo.com", false, false, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "sally_su@yahoo.com", "selenne levoux", "AQAAAAEAACcQAAAAEKg/uMJ1b7e7D17VnZ5HQwAbJmHHZpSoVcF8wfUgL5Sthc5sG2rPZMKWNz2TkOBd5A==", "", null, false, "ea1a4dda-72da-4e81-8cfb-1471ea9bf42d", false, "Selenne Levoux" },
                    { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 0, "ebe4c67e-a5dc-40c3-ba39-c93e99342afa", "IT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ForumUser", "dreamy_girl_23835@example.com", false, false, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "dreamy_girl_23835@example.com", "dreamyartist21", "AQAAAAEAACcQAAAAECGXFBtHT9aSn+28NMHraJOwoN1HytTnyNVMdbCLbtTcXegYOzh2BvNpiPNSJggxnw==", "", null, false, "f56d6c6a-9ea4-40f1-b2ac-cecf3c83569e", false, "DreamyArtist21" }
                });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1364), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1330) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1374), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1373) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1378), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1376) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1381), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1380) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1385), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1383) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1389), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1388) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1393), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1392) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1397), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1395) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1400), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1399) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1405), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1403) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1408), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1407) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1412), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1410) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1415), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1414) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1419), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1418) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1423), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1421) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1426), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1425) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1430), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1428) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1434), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1433) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1438), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1436) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1441), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1440) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1445), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1444) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1449), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1447) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1452), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1451) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1456), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1454) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1459), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1458) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1463), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1461) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1466), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1465) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1470), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1469) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1474), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1472) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1477), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1476) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1481), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1479) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1484), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1483) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1488), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1486) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1493), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1491) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1496), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1495) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1500), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1498) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1503), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1502) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1507), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1505) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1510), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1509) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1514), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1512) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1524), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1522) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1528), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1526) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1531), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1530) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1535), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1533) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1538), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1537) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1542), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1540) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1545), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1544) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1549), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1548) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1553), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1551) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1556), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1555) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1560), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1558) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1563), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1562) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1567), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1565) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1570), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1569) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1630), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1628) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1634), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1632) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1637), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1636) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1641), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1639) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1644), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1643) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1648), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1647) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1651), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1650) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1655), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1654) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1659), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1657) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1662), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1661) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1666), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1664) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1671), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1669) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1674), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1673) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1678), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1676) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1681), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1680) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1685), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1683) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1688), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1687) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1692), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1690) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1695), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1694) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1699), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1698) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1703), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1701) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1706), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1705) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1710), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1708) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1713), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1712) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1717), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1715) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1720), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1719) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1724), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1722) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1727), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1726) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1731), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1729) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1734), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1733) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1738), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1737) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1742), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1740) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1745), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1744) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1749), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1747) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1752), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1751) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1756), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1754) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1759), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1758) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1763), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1761) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1766), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1765) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1770), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1769) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1774), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1772) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1777), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1776) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1781), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1779) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1784), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1783) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1817), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1815) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1821), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1819) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1825), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1823) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1828), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1827) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1832), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1830) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1835), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1834) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1839), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1837) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1842), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1841) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1846), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1844) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1850), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1848) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1853), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1852) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1857), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1855) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1860), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1859) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1864), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1862) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1867), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1866) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1871), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1870) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1875), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1873) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1878), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1877) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1882), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1880) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1885), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1884) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1889), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1887) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1892), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1891) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1896), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1895) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1900), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1898) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1903), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1902) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1907), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1905) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1910), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1909) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1914), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1912) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1918), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1916) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1921), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1920) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1925), new DateTime(2024, 3, 28, 21, 36, 43, 172, DateTimeKind.Local).AddTicks(1923) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1bda777f-d458-4ae6-b89a-e1f019149bec", "07b40a11-9941-4b21-a90a-605b11cdb487" },
                    { "1bda777f-d458-4ae6-b89a-e1f019149bec", "1093c6dc-48eb-486d-a866-b8f8b4bbf77b" },
                    { "1bda777f-d458-4ae6-b89a-e1f019149bec", "4635c38a-41ec-42e1-9f67-9f8b3a7e3d80" },
                    { "1bda777f-d458-4ae6-b89a-e1f019149bec", "4a99a16d-1096-44cb-96a3-053b56917bcf" },
                    { "1bda777f-d458-4ae6-b89a-e1f019149bec", "54c4d727-865e-438b-ab3f-339a689c5c19" },
                    { "1bda777f-d458-4ae6-b89a-e1f019149bec", "5a118590-c2ac-4064-aab1-abbad1cd6bce" },
                    { "1bda777f-d458-4ae6-b89a-e1f019149bec", "6d07c695-8bfc-4a06-86e5-74bb86b3fd79" },
                    { "1bda777f-d458-4ae6-b89a-e1f019149bec", "6ebf8e6e-516b-463f-b996-dd327746e711" },
                    { "1bda777f-d458-4ae6-b89a-e1f019149bec", "73f3662c-2459-4b3e-8cc4-fabf43d05236" },
                    { "1bda777f-d458-4ae6-b89a-e1f019149bec", "79c263d0-fea3-4908-bc1e-d298311067d2" },
                    { "1bda777f-d458-4ae6-b89a-e1f019149bec", "7c61be63-6a12-4301-bd3b-cc50861735f0" },
                    { "1bda777f-d458-4ae6-b89a-e1f019149bec", "86e02b21-25d7-4246-af4f-beac10cff1a6" },
                    { "1bda777f-d458-4ae6-b89a-e1f019149bec", "88a75459-c19a-40f1-98bb-5d51bb514359" },
                    { "1bda777f-d458-4ae6-b89a-e1f019149bec", "8b29eded-bdbc-470b-a183-5d82c3c49c97" },
                    { "1bda777f-d458-4ae6-b89a-e1f019149bec", "8cf89a46-bd09-4384-96c0-c1c654841bbb" },
                    { "1bda777f-d458-4ae6-b89a-e1f019149bec", "95d90f10-67fa-418b-a16d-1a63bfeb970f" },
                    { "1bda777f-d458-4ae6-b89a-e1f019149bec", "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a" },
                    { "1bda777f-d458-4ae6-b89a-e1f019149bec", "aaf47a62-e659-4d92-bab6-02a3dd812aeb" },
                    { "1bda777f-d458-4ae6-b89a-e1f019149bec", "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7" },
                    { "1bda777f-d458-4ae6-b89a-e1f019149bec", "b0433d4e-d7df-4868-b831-a17f0a30af31" },
                    { "1bda777f-d458-4ae6-b89a-e1f019149bec", "b3d890e0-11b6-417a-b7f7-41473235e3fc" },
                    { "1bda777f-d458-4ae6-b89a-e1f019149bec", "ba413c8e-bd92-4b67-ad4e-bd7ac0236013" },
                    { "1bda777f-d458-4ae6-b89a-e1f019149bec", "c6317ffc-2f72-40b3-acee-9a85dab1cd66" },
                    { "1bda777f-d458-4ae6-b89a-e1f019149bec", "c6831bc6-00ef-4da1-9f61-df4c26101bbf" },
                    { "1bda777f-d458-4ae6-b89a-e1f019149bec", "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e" },
                    { "1bda777f-d458-4ae6-b89a-e1f019149bec", "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec" },
                    { "1bda777f-d458-4ae6-b89a-e1f019149bec", "d8a49048-5ac1-4586-907d-baceecb14fed" },
                    { "1bda777f-d458-4ae6-b89a-e1f019149bec", "e4490d07-ba6d-467a-9dda-b9f9b0c3928e" },
                    { "1bda777f-d458-4ae6-b89a-e1f019149bec", "e9075bbf-849c-4133-a682-f1dc7467ddf6" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1bda777f-d458-4ae6-b89a-e1f019149bec", "07b40a11-9941-4b21-a90a-605b11cdb487" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1bda777f-d458-4ae6-b89a-e1f019149bec", "1093c6dc-48eb-486d-a866-b8f8b4bbf77b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1bda777f-d458-4ae6-b89a-e1f019149bec", "4635c38a-41ec-42e1-9f67-9f8b3a7e3d80" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1bda777f-d458-4ae6-b89a-e1f019149bec", "4a99a16d-1096-44cb-96a3-053b56917bcf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1bda777f-d458-4ae6-b89a-e1f019149bec", "54c4d727-865e-438b-ab3f-339a689c5c19" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1bda777f-d458-4ae6-b89a-e1f019149bec", "5a118590-c2ac-4064-aab1-abbad1cd6bce" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1bda777f-d458-4ae6-b89a-e1f019149bec", "6d07c695-8bfc-4a06-86e5-74bb86b3fd79" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1bda777f-d458-4ae6-b89a-e1f019149bec", "6ebf8e6e-516b-463f-b996-dd327746e711" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1bda777f-d458-4ae6-b89a-e1f019149bec", "73f3662c-2459-4b3e-8cc4-fabf43d05236" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1bda777f-d458-4ae6-b89a-e1f019149bec", "79c263d0-fea3-4908-bc1e-d298311067d2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1bda777f-d458-4ae6-b89a-e1f019149bec", "7c61be63-6a12-4301-bd3b-cc50861735f0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1bda777f-d458-4ae6-b89a-e1f019149bec", "86e02b21-25d7-4246-af4f-beac10cff1a6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1bda777f-d458-4ae6-b89a-e1f019149bec", "88a75459-c19a-40f1-98bb-5d51bb514359" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1bda777f-d458-4ae6-b89a-e1f019149bec", "8b29eded-bdbc-470b-a183-5d82c3c49c97" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1bda777f-d458-4ae6-b89a-e1f019149bec", "8cf89a46-bd09-4384-96c0-c1c654841bbb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1bda777f-d458-4ae6-b89a-e1f019149bec", "95d90f10-67fa-418b-a16d-1a63bfeb970f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1bda777f-d458-4ae6-b89a-e1f019149bec", "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1bda777f-d458-4ae6-b89a-e1f019149bec", "aaf47a62-e659-4d92-bab6-02a3dd812aeb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1bda777f-d458-4ae6-b89a-e1f019149bec", "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1bda777f-d458-4ae6-b89a-e1f019149bec", "b0433d4e-d7df-4868-b831-a17f0a30af31" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1bda777f-d458-4ae6-b89a-e1f019149bec", "b3d890e0-11b6-417a-b7f7-41473235e3fc" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1bda777f-d458-4ae6-b89a-e1f019149bec", "ba413c8e-bd92-4b67-ad4e-bd7ac0236013" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1bda777f-d458-4ae6-b89a-e1f019149bec", "c6317ffc-2f72-40b3-acee-9a85dab1cd66" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1bda777f-d458-4ae6-b89a-e1f019149bec", "c6831bc6-00ef-4da1-9f61-df4c26101bbf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1bda777f-d458-4ae6-b89a-e1f019149bec", "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1bda777f-d458-4ae6-b89a-e1f019149bec", "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1bda777f-d458-4ae6-b89a-e1f019149bec", "d8a49048-5ac1-4586-907d-baceecb14fed" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1bda777f-d458-4ae6-b89a-e1f019149bec", "e4490d07-ba6d-467a-9dda-b9f9b0c3928e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1bda777f-d458-4ae6-b89a-e1f019149bec", "e9075bbf-849c-4133-a682-f1dc7467ddf6" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "07b40a11-9941-4b21-a90a-605b11cdb487");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1093c6dc-48eb-486d-a866-b8f8b4bbf77b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4635c38a-41ec-42e1-9f67-9f8b3a7e3d80");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4a99a16d-1096-44cb-96a3-053b56917bcf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "54c4d727-865e-438b-ab3f-339a689c5c19");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5a118590-c2ac-4064-aab1-abbad1cd6bce");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d07c695-8bfc-4a06-86e5-74bb86b3fd79");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6ebf8e6e-516b-463f-b996-dd327746e711");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73f3662c-2459-4b3e-8cc4-fabf43d05236");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79c263d0-fea3-4908-bc1e-d298311067d2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7c61be63-6a12-4301-bd3b-cc50861735f0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "86e02b21-25d7-4246-af4f-beac10cff1a6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "88a75459-c19a-40f1-98bb-5d51bb514359");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8b29eded-bdbc-470b-a183-5d82c3c49c97");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8cf89a46-bd09-4384-96c0-c1c654841bbb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95d90f10-67fa-418b-a16d-1a63bfeb970f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aaf47a62-e659-4d92-bab6-02a3dd812aeb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b0433d4e-d7df-4868-b831-a17f0a30af31");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3d890e0-11b6-417a-b7f7-41473235e3fc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ba413c8e-bd92-4b67-ad4e-bd7ac0236013");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6317ffc-2f72-40b3-acee-9a85dab1cd66");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6831bc6-00ef-4da1-9f61-df4c26101bbf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d8a49048-5ac1-4586-907d-baceecb14fed");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4490d07-ba6d-467a-9dda-b9f9b0c3928e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9075bbf-849c-4133-a682-f1dc7467ddf6");

            migrationBuilder.AddColumn<bool>(
                name: "IsCurrentAvatar",
                table: "ForumUsersAttachments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2272), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2232) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2279), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2277) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2282), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2281) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2286), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2284) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2292), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2288) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2298), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2296) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2303), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2301) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2308), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2306) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2312), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2310) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2318), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2316) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2322), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2320) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2327), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2325) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2370), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2368) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2376), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2373) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2380), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2378) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2400), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2397) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2404), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2402) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2413), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2411) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2418), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2416) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2422), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2421) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2427), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2425) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2432), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2430) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2435), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2434) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2438), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2437) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2441), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2440) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2445), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2443) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2448), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2446) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2451), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2450) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2454), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2453) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2457), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2456) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2460), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2459) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2464), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2462) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2467), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2465) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2471), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2470) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2474), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2473) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2477), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2476) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2481), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2479) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2484), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2482) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2487), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2486) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2490), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2489) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2493), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2492) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2496), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2495) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2500), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2498) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2503), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2502) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2506), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2505) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2509), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2508) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2512), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2511) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2516), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2514) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2519), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2517) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2522), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2521) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2525), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2524) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2528), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2527) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2531), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2530) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2535), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2533) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2538), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2537) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2541), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2540) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2544), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2543) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2547), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2546) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2584), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2583) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2588), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2586) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2591), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2590) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2594), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2593) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2597), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2596) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2601), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2599) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2604), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2603) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2609), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2607) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2612), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2610) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2615), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2614) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2618), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2617) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2621), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2620) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2625), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2623) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2628), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2631), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2630) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2634), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2633) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2637), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2636) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2640), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2639) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2644), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2642) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2647), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2646) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2650), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2649) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2653), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2652) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2656), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2655) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2659), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2658) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2663), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2661) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2666), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2665) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2669), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2668) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2672), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2671) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2675), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2674) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2678), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2677) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2682), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2680) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2685), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2683) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2688), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2687) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2691), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2690) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2694), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2693) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2698), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2696) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2701), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2699) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2704), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2707), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2706) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2710), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2709) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2713), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2712) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2717), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2715) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2720), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2718) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2723), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2722) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2747), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2745) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2752), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2750) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2756), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2754) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2760), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2758) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2763), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2762) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2766), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2765) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2769), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2768) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2772), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2771) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2775), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2774) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2779), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2777) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2782), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2780) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2785), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2784) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2788), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2787) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2791), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2790) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2794), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2793) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2798), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2796) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2801), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2799) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2804), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2803) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2807), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2806) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2810), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2809) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2813), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2812) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2817), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2815) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2820), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2819) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2823), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2822) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2826), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2825) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2829), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2828) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2832), new DateTime(2024, 3, 21, 11, 20, 24, 13, DateTimeKind.Local).AddTicks(2831) });
        }
    }
}
