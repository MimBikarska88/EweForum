using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EweForum.Infrastructure.Migrations
{
    public partial class SeedJoinedTopics : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.InsertData(
                table: "JoinedTopic",
                columns: new[] { "ForumUserId", "TopicId" },
                values: new object[,]
                {
                    { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 1 },
                    { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 1 },
                    { "b0433d4e-d7df-4868-b831-a17f0a30af31", 1 },
                    { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 1 },
                    { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 1 },
                    { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 1 },
                    { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 1 },
                    { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 1 },
                    { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 1 },
                    { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 1 },
                    { "d8a49048-5ac1-4586-907d-baceecb14fed", 1 },
                    { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 1 },
                    { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 1 }
                });

            migrationBuilder.InsertData(
                table: "JoinedTopic",
                columns: new[] { "ForumUserId", "TopicId" },
                values: new object[,]
                {
                    { "07b40a11-9941-4b21-a90a-605b11cdb487", 2 },
                    { "1093c6dc-48eb-486d-a866-b8f8b4bbf77b", 2 },
                    { "4635c38a-41ec-42e1-9f67-9f8b3a7e3d80", 2 },
                    { "4a99a16d-1096-44cb-96a3-053b56917bcf", 2 },
                    { "54c4d727-865e-438b-ab3f-339a689c5c19", 2 },
                    { "5a118590-c2ac-4064-aab1-abbad1cd6bce", 2 },
                    { "659ad282-2d5b-47a7-b0bf-c773676cb16b", 2 },
                    { "6d07c695-8bfc-4a06-86e5-74bb86b3fd79", 2 },
                    { "6ebf8e6e-516b-463f-b996-dd327746e711", 2 },
                    { "73f3662c-2459-4b3e-8cc4-fabf43d05236", 2 },
                    { "79c263d0-fea3-4908-bc1e-d298311067d2", 2 },
                    { "7c61be63-6a12-4301-bd3b-cc50861735f0", 2 },
                    { "86e02b21-25d7-4246-af4f-beac10cff1a6", 2 },
                    { "88a75459-c19a-40f1-98bb-5d51bb514359", 2 },
                    { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 2 },
                    { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 2 },
                    { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 2 },
                    { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 2 },
                    { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 2 },
                    { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 2 },
                    { "b0433d4e-d7df-4868-b831-a17f0a30af31", 2 },
                    { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 2 },
                    { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 2 },
                    { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 2 },
                    { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 2 },
                    { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 2 },
                    { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 2 },
                    { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 2 },
                    { "d8a49048-5ac1-4586-907d-baceecb14fed", 2 },
                    { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 2 },
                    { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 2 },
                    { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 3 },
                    { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 3 },
                    { "b0433d4e-d7df-4868-b831-a17f0a30af31", 3 },
                    { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 3 },
                    { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 3 },
                    { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 3 },
                    { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 3 },
                    { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 3 },
                    { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 3 },
                    { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 3 },
                    { "d8a49048-5ac1-4586-907d-baceecb14fed", 3 }
                });

            migrationBuilder.InsertData(
                table: "JoinedTopic",
                columns: new[] { "ForumUserId", "TopicId" },
                values: new object[,]
                {
                    { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 3 },
                    { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 3 },
                    { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 4 },
                    { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 4 },
                    { "b0433d4e-d7df-4868-b831-a17f0a30af31", 4 },
                    { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 4 },
                    { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 4 },
                    { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 4 },
                    { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 4 },
                    { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 4 },
                    { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 4 },
                    { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 4 },
                    { "d8a49048-5ac1-4586-907d-baceecb14fed", 4 },
                    { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 4 },
                    { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 4 },
                    { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 5 },
                    { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 5 },
                    { "b0433d4e-d7df-4868-b831-a17f0a30af31", 5 },
                    { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 5 },
                    { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 5 },
                    { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 5 },
                    { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 5 },
                    { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 5 },
                    { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 5 },
                    { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 5 },
                    { "d8a49048-5ac1-4586-907d-baceecb14fed", 5 },
                    { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 5 },
                    { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 5 },
                    { "07b40a11-9941-4b21-a90a-605b11cdb487", 6 },
                    { "4635c38a-41ec-42e1-9f67-9f8b3a7e3d80", 6 },
                    { "73f3662c-2459-4b3e-8cc4-fabf43d05236", 7 },
                    { "79c263d0-fea3-4908-bc1e-d298311067d2", 7 },
                    { "7c61be63-6a12-4301-bd3b-cc50861735f0", 7 },
                    { "86e02b21-25d7-4246-af4f-beac10cff1a6", 7 },
                    { "88a75459-c19a-40f1-98bb-5d51bb514359", 7 },
                    { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 7 },
                    { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 7 },
                    { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 7 },
                    { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 7 },
                    { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 7 },
                    { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 7 },
                    { "b0433d4e-d7df-4868-b831-a17f0a30af31", 7 }
                });

            migrationBuilder.InsertData(
                table: "JoinedTopic",
                columns: new[] { "ForumUserId", "TopicId" },
                values: new object[,]
                {
                    { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 7 },
                    { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 7 },
                    { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 7 },
                    { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 7 },
                    { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 7 },
                    { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 7 },
                    { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 7 },
                    { "d8a49048-5ac1-4586-907d-baceecb14fed", 7 },
                    { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 7 },
                    { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 7 },
                    { "73f3662c-2459-4b3e-8cc4-fabf43d05236", 8 },
                    { "79c263d0-fea3-4908-bc1e-d298311067d2", 8 },
                    { "7c61be63-6a12-4301-bd3b-cc50861735f0", 8 },
                    { "86e02b21-25d7-4246-af4f-beac10cff1a6", 8 },
                    { "88a75459-c19a-40f1-98bb-5d51bb514359", 8 },
                    { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 8 },
                    { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 8 },
                    { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 8 },
                    { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 8 },
                    { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 8 },
                    { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 8 },
                    { "b0433d4e-d7df-4868-b831-a17f0a30af31", 8 },
                    { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 8 },
                    { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 8 },
                    { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 8 },
                    { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 8 },
                    { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 8 },
                    { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 8 },
                    { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 8 },
                    { "d8a49048-5ac1-4586-907d-baceecb14fed", 8 },
                    { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 8 },
                    { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 8 },
                    { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 10 },
                    { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 10 },
                    { "b0433d4e-d7df-4868-b831-a17f0a30af31", 10 },
                    { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 10 },
                    { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 10 },
                    { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 10 },
                    { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 10 },
                    { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 10 },
                    { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 10 },
                    { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 10 }
                });

            migrationBuilder.InsertData(
                table: "JoinedTopic",
                columns: new[] { "ForumUserId", "TopicId" },
                values: new object[,]
                {
                    { "d8a49048-5ac1-4586-907d-baceecb14fed", 10 },
                    { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 10 },
                    { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 10 },
                    { "07b40a11-9941-4b21-a90a-605b11cdb487", 12 },
                    { "1093c6dc-48eb-486d-a866-b8f8b4bbf77b", 12 },
                    { "1093c6dc-48eb-486d-a866-b8f8b4bbf77b", 13 },
                    { "5a118590-c2ac-4064-aab1-abbad1cd6bce", 13 },
                    { "659ad282-2d5b-47a7-b0bf-c773676cb16b", 13 },
                    { "6d07c695-8bfc-4a06-86e5-74bb86b3fd79", 13 },
                    { "6ebf8e6e-516b-463f-b996-dd327746e711", 13 },
                    { "73f3662c-2459-4b3e-8cc4-fabf43d05236", 13 },
                    { "79c263d0-fea3-4908-bc1e-d298311067d2", 13 },
                    { "7c61be63-6a12-4301-bd3b-cc50861735f0", 13 },
                    { "86e02b21-25d7-4246-af4f-beac10cff1a6", 13 },
                    { "88a75459-c19a-40f1-98bb-5d51bb514359", 13 },
                    { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 13 },
                    { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 13 },
                    { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 13 },
                    { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 13 },
                    { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 13 },
                    { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 13 },
                    { "b0433d4e-d7df-4868-b831-a17f0a30af31", 13 },
                    { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 13 },
                    { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 13 },
                    { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 13 },
                    { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 13 },
                    { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 13 },
                    { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 13 },
                    { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 13 },
                    { "d8a49048-5ac1-4586-907d-baceecb14fed", 13 },
                    { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 13 },
                    { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 13 },
                    { "07b40a11-9941-4b21-a90a-605b11cdb487", 14 },
                    { "1093c6dc-48eb-486d-a866-b8f8b4bbf77b", 14 },
                    { "4635c38a-41ec-42e1-9f67-9f8b3a7e3d80", 14 },
                    { "4a99a16d-1096-44cb-96a3-053b56917bcf", 14 },
                    { "54c4d727-865e-438b-ab3f-339a689c5c19", 14 },
                    { "5a118590-c2ac-4064-aab1-abbad1cd6bce", 14 },
                    { "659ad282-2d5b-47a7-b0bf-c773676cb16b", 14 },
                    { "6d07c695-8bfc-4a06-86e5-74bb86b3fd79", 14 },
                    { "6ebf8e6e-516b-463f-b996-dd327746e711", 14 },
                    { "73f3662c-2459-4b3e-8cc4-fabf43d05236", 14 }
                });

            migrationBuilder.InsertData(
                table: "JoinedTopic",
                columns: new[] { "ForumUserId", "TopicId" },
                values: new object[,]
                {
                    { "79c263d0-fea3-4908-bc1e-d298311067d2", 14 },
                    { "7c61be63-6a12-4301-bd3b-cc50861735f0", 14 },
                    { "86e02b21-25d7-4246-af4f-beac10cff1a6", 14 },
                    { "88a75459-c19a-40f1-98bb-5d51bb514359", 14 },
                    { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 14 },
                    { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 14 },
                    { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 14 },
                    { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 14 },
                    { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 14 },
                    { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 14 },
                    { "b0433d4e-d7df-4868-b831-a17f0a30af31", 14 },
                    { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 14 },
                    { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 14 },
                    { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 14 },
                    { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 14 },
                    { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 14 },
                    { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 14 },
                    { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 14 },
                    { "d8a49048-5ac1-4586-907d-baceecb14fed", 14 },
                    { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 14 },
                    { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 14 },
                    { "1093c6dc-48eb-486d-a866-b8f8b4bbf77b", 15 },
                    { "4635c38a-41ec-42e1-9f67-9f8b3a7e3d80", 15 },
                    { "4a99a16d-1096-44cb-96a3-053b56917bcf", 15 },
                    { "54c4d727-865e-438b-ab3f-339a689c5c19", 15 },
                    { "5a118590-c2ac-4064-aab1-abbad1cd6bce", 15 },
                    { "659ad282-2d5b-47a7-b0bf-c773676cb16b", 15 },
                    { "6d07c695-8bfc-4a06-86e5-74bb86b3fd79", 15 },
                    { "6ebf8e6e-516b-463f-b996-dd327746e711", 15 },
                    { "73f3662c-2459-4b3e-8cc4-fabf43d05236", 15 },
                    { "79c263d0-fea3-4908-bc1e-d298311067d2", 15 },
                    { "7c61be63-6a12-4301-bd3b-cc50861735f0", 15 },
                    { "86e02b21-25d7-4246-af4f-beac10cff1a6", 15 },
                    { "88a75459-c19a-40f1-98bb-5d51bb514359", 15 },
                    { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 15 },
                    { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 15 },
                    { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 15 },
                    { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 15 },
                    { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 15 },
                    { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 15 },
                    { "b0433d4e-d7df-4868-b831-a17f0a30af31", 15 },
                    { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 15 }
                });

            migrationBuilder.InsertData(
                table: "JoinedTopic",
                columns: new[] { "ForumUserId", "TopicId" },
                values: new object[,]
                {
                    { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 15 },
                    { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 15 },
                    { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 15 },
                    { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 15 },
                    { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 15 },
                    { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 15 },
                    { "d8a49048-5ac1-4586-907d-baceecb14fed", 15 },
                    { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 15 },
                    { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 15 },
                    { "1093c6dc-48eb-486d-a866-b8f8b4bbf77b", 17 },
                    { "4635c38a-41ec-42e1-9f67-9f8b3a7e3d80", 17 },
                    { "73f3662c-2459-4b3e-8cc4-fabf43d05236", 17 },
                    { "79c263d0-fea3-4908-bc1e-d298311067d2", 17 },
                    { "7c61be63-6a12-4301-bd3b-cc50861735f0", 17 },
                    { "86e02b21-25d7-4246-af4f-beac10cff1a6", 17 },
                    { "88a75459-c19a-40f1-98bb-5d51bb514359", 17 },
                    { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 17 },
                    { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 17 },
                    { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 17 },
                    { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 17 },
                    { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 17 },
                    { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 17 },
                    { "b0433d4e-d7df-4868-b831-a17f0a30af31", 17 },
                    { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 17 },
                    { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 17 },
                    { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 17 },
                    { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 17 },
                    { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 17 },
                    { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 17 },
                    { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 17 },
                    { "d8a49048-5ac1-4586-907d-baceecb14fed", 17 },
                    { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 17 },
                    { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 17 },
                    { "4a99a16d-1096-44cb-96a3-053b56917bcf", 18 },
                    { "54c4d727-865e-438b-ab3f-339a689c5c19", 18 },
                    { "5a118590-c2ac-4064-aab1-abbad1cd6bce", 18 },
                    { "659ad282-2d5b-47a7-b0bf-c773676cb16b", 18 },
                    { "6d07c695-8bfc-4a06-86e5-74bb86b3fd79", 18 },
                    { "6ebf8e6e-516b-463f-b996-dd327746e711", 18 },
                    { "73f3662c-2459-4b3e-8cc4-fabf43d05236", 18 },
                    { "79c263d0-fea3-4908-bc1e-d298311067d2", 18 },
                    { "7c61be63-6a12-4301-bd3b-cc50861735f0", 18 }
                });

            migrationBuilder.InsertData(
                table: "JoinedTopic",
                columns: new[] { "ForumUserId", "TopicId" },
                values: new object[,]
                {
                    { "86e02b21-25d7-4246-af4f-beac10cff1a6", 18 },
                    { "88a75459-c19a-40f1-98bb-5d51bb514359", 18 },
                    { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 18 },
                    { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 18 },
                    { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 18 },
                    { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 18 },
                    { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 18 },
                    { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 18 },
                    { "b0433d4e-d7df-4868-b831-a17f0a30af31", 18 },
                    { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 18 },
                    { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 18 },
                    { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 18 },
                    { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 18 },
                    { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 18 },
                    { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 18 },
                    { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 18 },
                    { "d8a49048-5ac1-4586-907d-baceecb14fed", 18 },
                    { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 18 },
                    { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 18 },
                    { "07b40a11-9941-4b21-a90a-605b11cdb487", 21 },
                    { "4a99a16d-1096-44cb-96a3-053b56917bcf", 21 },
                    { "54c4d727-865e-438b-ab3f-339a689c5c19", 21 },
                    { "5a118590-c2ac-4064-aab1-abbad1cd6bce", 21 },
                    { "659ad282-2d5b-47a7-b0bf-c773676cb16b", 21 },
                    { "6d07c695-8bfc-4a06-86e5-74bb86b3fd79", 21 },
                    { "6ebf8e6e-516b-463f-b996-dd327746e711", 21 },
                    { "73f3662c-2459-4b3e-8cc4-fabf43d05236", 21 },
                    { "79c263d0-fea3-4908-bc1e-d298311067d2", 21 },
                    { "7c61be63-6a12-4301-bd3b-cc50861735f0", 21 },
                    { "86e02b21-25d7-4246-af4f-beac10cff1a6", 21 },
                    { "88a75459-c19a-40f1-98bb-5d51bb514359", 21 },
                    { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 21 },
                    { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 21 },
                    { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 21 },
                    { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 21 },
                    { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 21 },
                    { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 21 },
                    { "b0433d4e-d7df-4868-b831-a17f0a30af31", 21 },
                    { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 21 },
                    { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 21 },
                    { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 21 },
                    { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 21 }
                });

            migrationBuilder.InsertData(
                table: "JoinedTopic",
                columns: new[] { "ForumUserId", "TopicId" },
                values: new object[,]
                {
                    { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 21 },
                    { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 21 },
                    { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 21 },
                    { "d8a49048-5ac1-4586-907d-baceecb14fed", 21 },
                    { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 21 },
                    { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 21 },
                    { "07b40a11-9941-4b21-a90a-605b11cdb487", 22 },
                    { "07b40a11-9941-4b21-a90a-605b11cdb487", 23 },
                    { "4a99a16d-1096-44cb-96a3-053b56917bcf", 24 },
                    { "54c4d727-865e-438b-ab3f-339a689c5c19", 24 },
                    { "5a118590-c2ac-4064-aab1-abbad1cd6bce", 24 },
                    { "659ad282-2d5b-47a7-b0bf-c773676cb16b", 24 },
                    { "6d07c695-8bfc-4a06-86e5-74bb86b3fd79", 24 },
                    { "6ebf8e6e-516b-463f-b996-dd327746e711", 24 },
                    { "73f3662c-2459-4b3e-8cc4-fabf43d05236", 24 },
                    { "79c263d0-fea3-4908-bc1e-d298311067d2", 24 },
                    { "7c61be63-6a12-4301-bd3b-cc50861735f0", 24 },
                    { "86e02b21-25d7-4246-af4f-beac10cff1a6", 24 },
                    { "88a75459-c19a-40f1-98bb-5d51bb514359", 24 },
                    { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 24 },
                    { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 24 },
                    { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 24 },
                    { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 24 },
                    { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 24 },
                    { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 24 },
                    { "b0433d4e-d7df-4868-b831-a17f0a30af31", 24 },
                    { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 24 },
                    { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 24 },
                    { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 24 },
                    { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 24 },
                    { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 24 },
                    { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 24 },
                    { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 24 },
                    { "d8a49048-5ac1-4586-907d-baceecb14fed", 24 },
                    { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 24 },
                    { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 24 },
                    { "4a99a16d-1096-44cb-96a3-053b56917bcf", 25 },
                    { "54c4d727-865e-438b-ab3f-339a689c5c19", 25 },
                    { "5a118590-c2ac-4064-aab1-abbad1cd6bce", 25 },
                    { "659ad282-2d5b-47a7-b0bf-c773676cb16b", 25 },
                    { "6d07c695-8bfc-4a06-86e5-74bb86b3fd79", 25 },
                    { "6ebf8e6e-516b-463f-b996-dd327746e711", 25 }
                });

            migrationBuilder.InsertData(
                table: "JoinedTopic",
                columns: new[] { "ForumUserId", "TopicId" },
                values: new object[,]
                {
                    { "73f3662c-2459-4b3e-8cc4-fabf43d05236", 25 },
                    { "79c263d0-fea3-4908-bc1e-d298311067d2", 25 },
                    { "7c61be63-6a12-4301-bd3b-cc50861735f0", 25 },
                    { "86e02b21-25d7-4246-af4f-beac10cff1a6", 25 },
                    { "88a75459-c19a-40f1-98bb-5d51bb514359", 25 },
                    { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 25 },
                    { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 25 },
                    { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 25 },
                    { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 25 },
                    { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 25 },
                    { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 25 },
                    { "b0433d4e-d7df-4868-b831-a17f0a30af31", 25 },
                    { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 25 },
                    { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 25 },
                    { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 25 },
                    { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 25 },
                    { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 25 },
                    { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 25 },
                    { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 25 },
                    { "d8a49048-5ac1-4586-907d-baceecb14fed", 25 },
                    { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 25 },
                    { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 25 },
                    { "4a99a16d-1096-44cb-96a3-053b56917bcf", 26 },
                    { "54c4d727-865e-438b-ab3f-339a689c5c19", 26 },
                    { "5a118590-c2ac-4064-aab1-abbad1cd6bce", 26 },
                    { "659ad282-2d5b-47a7-b0bf-c773676cb16b", 26 },
                    { "6d07c695-8bfc-4a06-86e5-74bb86b3fd79", 26 },
                    { "6ebf8e6e-516b-463f-b996-dd327746e711", 26 },
                    { "73f3662c-2459-4b3e-8cc4-fabf43d05236", 26 },
                    { "79c263d0-fea3-4908-bc1e-d298311067d2", 26 },
                    { "7c61be63-6a12-4301-bd3b-cc50861735f0", 26 },
                    { "86e02b21-25d7-4246-af4f-beac10cff1a6", 26 },
                    { "88a75459-c19a-40f1-98bb-5d51bb514359", 26 },
                    { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 26 },
                    { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 26 },
                    { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 26 },
                    { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 26 },
                    { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 26 },
                    { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 26 },
                    { "b0433d4e-d7df-4868-b831-a17f0a30af31", 26 },
                    { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 26 },
                    { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 26 }
                });

            migrationBuilder.InsertData(
                table: "JoinedTopic",
                columns: new[] { "ForumUserId", "TopicId" },
                values: new object[,]
                {
                    { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 26 },
                    { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 26 },
                    { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 26 },
                    { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 26 },
                    { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 26 },
                    { "d8a49048-5ac1-4586-907d-baceecb14fed", 26 },
                    { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 26 },
                    { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 26 },
                    { "4a99a16d-1096-44cb-96a3-053b56917bcf", 27 },
                    { "54c4d727-865e-438b-ab3f-339a689c5c19", 27 },
                    { "5a118590-c2ac-4064-aab1-abbad1cd6bce", 27 },
                    { "659ad282-2d5b-47a7-b0bf-c773676cb16b", 27 },
                    { "6d07c695-8bfc-4a06-86e5-74bb86b3fd79", 27 },
                    { "6ebf8e6e-516b-463f-b996-dd327746e711", 27 },
                    { "73f3662c-2459-4b3e-8cc4-fabf43d05236", 27 },
                    { "79c263d0-fea3-4908-bc1e-d298311067d2", 27 },
                    { "7c61be63-6a12-4301-bd3b-cc50861735f0", 27 },
                    { "86e02b21-25d7-4246-af4f-beac10cff1a6", 27 },
                    { "88a75459-c19a-40f1-98bb-5d51bb514359", 27 },
                    { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 27 },
                    { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 27 },
                    { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 27 },
                    { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 27 },
                    { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 27 },
                    { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 27 },
                    { "b0433d4e-d7df-4868-b831-a17f0a30af31", 27 },
                    { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 27 },
                    { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 27 },
                    { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 27 },
                    { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 27 },
                    { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 27 },
                    { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 27 },
                    { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 27 },
                    { "d8a49048-5ac1-4586-907d-baceecb14fed", 27 },
                    { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 27 },
                    { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 27 },
                    { "5a118590-c2ac-4064-aab1-abbad1cd6bce", 29 },
                    { "659ad282-2d5b-47a7-b0bf-c773676cb16b", 29 },
                    { "6d07c695-8bfc-4a06-86e5-74bb86b3fd79", 29 },
                    { "6ebf8e6e-516b-463f-b996-dd327746e711", 29 },
                    { "73f3662c-2459-4b3e-8cc4-fabf43d05236", 29 },
                    { "79c263d0-fea3-4908-bc1e-d298311067d2", 29 }
                });

            migrationBuilder.InsertData(
                table: "JoinedTopic",
                columns: new[] { "ForumUserId", "TopicId" },
                values: new object[,]
                {
                    { "7c61be63-6a12-4301-bd3b-cc50861735f0", 29 },
                    { "86e02b21-25d7-4246-af4f-beac10cff1a6", 29 },
                    { "88a75459-c19a-40f1-98bb-5d51bb514359", 29 },
                    { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 29 },
                    { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 29 },
                    { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 29 },
                    { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 29 },
                    { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 29 },
                    { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 29 },
                    { "b0433d4e-d7df-4868-b831-a17f0a30af31", 29 },
                    { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 29 },
                    { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 29 },
                    { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 29 },
                    { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 29 },
                    { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 29 },
                    { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 29 },
                    { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 29 },
                    { "d8a49048-5ac1-4586-907d-baceecb14fed", 29 },
                    { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 29 },
                    { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 29 },
                    { "4a99a16d-1096-44cb-96a3-053b56917bcf", 32 },
                    { "54c4d727-865e-438b-ab3f-339a689c5c19", 32 },
                    { "5a118590-c2ac-4064-aab1-abbad1cd6bce", 32 },
                    { "659ad282-2d5b-47a7-b0bf-c773676cb16b", 32 },
                    { "6d07c695-8bfc-4a06-86e5-74bb86b3fd79", 32 },
                    { "6ebf8e6e-516b-463f-b996-dd327746e711", 32 },
                    { "73f3662c-2459-4b3e-8cc4-fabf43d05236", 32 },
                    { "79c263d0-fea3-4908-bc1e-d298311067d2", 32 },
                    { "7c61be63-6a12-4301-bd3b-cc50861735f0", 32 },
                    { "86e02b21-25d7-4246-af4f-beac10cff1a6", 32 },
                    { "88a75459-c19a-40f1-98bb-5d51bb514359", 32 },
                    { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 32 },
                    { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 32 },
                    { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 32 },
                    { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 32 },
                    { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 32 },
                    { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 32 },
                    { "b0433d4e-d7df-4868-b831-a17f0a30af31", 32 },
                    { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 32 },
                    { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 32 },
                    { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 32 },
                    { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 32 }
                });

            migrationBuilder.InsertData(
                table: "JoinedTopic",
                columns: new[] { "ForumUserId", "TopicId" },
                values: new object[,]
                {
                    { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 32 },
                    { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 32 },
                    { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 32 },
                    { "d8a49048-5ac1-4586-907d-baceecb14fed", 32 },
                    { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 32 },
                    { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 32 },
                    { "5a118590-c2ac-4064-aab1-abbad1cd6bce", 33 },
                    { "659ad282-2d5b-47a7-b0bf-c773676cb16b", 33 },
                    { "6d07c695-8bfc-4a06-86e5-74bb86b3fd79", 33 },
                    { "6ebf8e6e-516b-463f-b996-dd327746e711", 33 },
                    { "73f3662c-2459-4b3e-8cc4-fabf43d05236", 33 },
                    { "79c263d0-fea3-4908-bc1e-d298311067d2", 33 },
                    { "7c61be63-6a12-4301-bd3b-cc50861735f0", 33 },
                    { "86e02b21-25d7-4246-af4f-beac10cff1a6", 33 },
                    { "88a75459-c19a-40f1-98bb-5d51bb514359", 33 },
                    { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 33 },
                    { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 33 },
                    { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 33 },
                    { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 33 },
                    { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 33 },
                    { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 33 },
                    { "b0433d4e-d7df-4868-b831-a17f0a30af31", 33 },
                    { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 33 },
                    { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 33 },
                    { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 33 },
                    { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 33 },
                    { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 33 },
                    { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 33 },
                    { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 33 },
                    { "d8a49048-5ac1-4586-907d-baceecb14fed", 33 },
                    { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 33 },
                    { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 33 },
                    { "07b40a11-9941-4b21-a90a-605b11cdb487", 34 },
                    { "1093c6dc-48eb-486d-a866-b8f8b4bbf77b", 34 },
                    { "4635c38a-41ec-42e1-9f67-9f8b3a7e3d80", 34 },
                    { "4a99a16d-1096-44cb-96a3-053b56917bcf", 36 },
                    { "54c4d727-865e-438b-ab3f-339a689c5c19", 36 },
                    { "5a118590-c2ac-4064-aab1-abbad1cd6bce", 36 },
                    { "659ad282-2d5b-47a7-b0bf-c773676cb16b", 36 },
                    { "6d07c695-8bfc-4a06-86e5-74bb86b3fd79", 36 },
                    { "6ebf8e6e-516b-463f-b996-dd327746e711", 36 },
                    { "73f3662c-2459-4b3e-8cc4-fabf43d05236", 36 }
                });

            migrationBuilder.InsertData(
                table: "JoinedTopic",
                columns: new[] { "ForumUserId", "TopicId" },
                values: new object[,]
                {
                    { "79c263d0-fea3-4908-bc1e-d298311067d2", 36 },
                    { "7c61be63-6a12-4301-bd3b-cc50861735f0", 36 },
                    { "86e02b21-25d7-4246-af4f-beac10cff1a6", 36 },
                    { "88a75459-c19a-40f1-98bb-5d51bb514359", 36 },
                    { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 36 },
                    { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 36 },
                    { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 36 },
                    { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 36 },
                    { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 36 },
                    { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 36 },
                    { "b0433d4e-d7df-4868-b831-a17f0a30af31", 36 },
                    { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 36 },
                    { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 36 },
                    { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 36 },
                    { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 36 },
                    { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 36 },
                    { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 36 },
                    { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 36 },
                    { "d8a49048-5ac1-4586-907d-baceecb14fed", 36 },
                    { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 36 },
                    { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 36 },
                    { "73f3662c-2459-4b3e-8cc4-fabf43d05236", 37 },
                    { "79c263d0-fea3-4908-bc1e-d298311067d2", 37 },
                    { "7c61be63-6a12-4301-bd3b-cc50861735f0", 37 },
                    { "86e02b21-25d7-4246-af4f-beac10cff1a6", 37 },
                    { "88a75459-c19a-40f1-98bb-5d51bb514359", 37 },
                    { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 37 },
                    { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 37 },
                    { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 37 },
                    { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 37 },
                    { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 37 },
                    { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 37 },
                    { "b0433d4e-d7df-4868-b831-a17f0a30af31", 37 },
                    { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 37 },
                    { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 37 },
                    { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 37 },
                    { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 37 },
                    { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 37 },
                    { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 37 },
                    { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 37 },
                    { "d8a49048-5ac1-4586-907d-baceecb14fed", 37 },
                    { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 37 }
                });

            migrationBuilder.InsertData(
                table: "JoinedTopic",
                columns: new[] { "ForumUserId", "TopicId" },
                values: new object[,]
                {
                    { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 37 },
                    { "1093c6dc-48eb-486d-a866-b8f8b4bbf77b", 38 },
                    { "4635c38a-41ec-42e1-9f67-9f8b3a7e3d80", 38 },
                    { "4a99a16d-1096-44cb-96a3-053b56917bcf", 38 },
                    { "54c4d727-865e-438b-ab3f-339a689c5c19", 38 },
                    { "5a118590-c2ac-4064-aab1-abbad1cd6bce", 38 },
                    { "659ad282-2d5b-47a7-b0bf-c773676cb16b", 38 },
                    { "6d07c695-8bfc-4a06-86e5-74bb86b3fd79", 38 },
                    { "6ebf8e6e-516b-463f-b996-dd327746e711", 38 },
                    { "73f3662c-2459-4b3e-8cc4-fabf43d05236", 38 },
                    { "79c263d0-fea3-4908-bc1e-d298311067d2", 38 },
                    { "7c61be63-6a12-4301-bd3b-cc50861735f0", 38 },
                    { "86e02b21-25d7-4246-af4f-beac10cff1a6", 38 },
                    { "88a75459-c19a-40f1-98bb-5d51bb514359", 38 },
                    { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 38 },
                    { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 38 },
                    { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 38 },
                    { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 38 },
                    { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 38 },
                    { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 38 },
                    { "b0433d4e-d7df-4868-b831-a17f0a30af31", 38 },
                    { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 38 },
                    { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 38 },
                    { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 38 },
                    { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 38 },
                    { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 38 },
                    { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 38 },
                    { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 38 },
                    { "d8a49048-5ac1-4586-907d-baceecb14fed", 38 },
                    { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 38 },
                    { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 38 },
                    { "5a118590-c2ac-4064-aab1-abbad1cd6bce", 39 },
                    { "659ad282-2d5b-47a7-b0bf-c773676cb16b", 39 },
                    { "6d07c695-8bfc-4a06-86e5-74bb86b3fd79", 39 },
                    { "6ebf8e6e-516b-463f-b996-dd327746e711", 39 },
                    { "73f3662c-2459-4b3e-8cc4-fabf43d05236", 39 },
                    { "79c263d0-fea3-4908-bc1e-d298311067d2", 39 },
                    { "7c61be63-6a12-4301-bd3b-cc50861735f0", 39 },
                    { "86e02b21-25d7-4246-af4f-beac10cff1a6", 39 },
                    { "88a75459-c19a-40f1-98bb-5d51bb514359", 39 },
                    { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 39 },
                    { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 39 }
                });

            migrationBuilder.InsertData(
                table: "JoinedTopic",
                columns: new[] { "ForumUserId", "TopicId" },
                values: new object[,]
                {
                    { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 39 },
                    { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 39 },
                    { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 39 },
                    { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 39 },
                    { "b0433d4e-d7df-4868-b831-a17f0a30af31", 39 },
                    { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 39 },
                    { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 39 },
                    { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 39 },
                    { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 39 },
                    { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 39 },
                    { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 39 },
                    { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 39 },
                    { "d8a49048-5ac1-4586-907d-baceecb14fed", 39 },
                    { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 39 },
                    { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 39 },
                    { "7c61be63-6a12-4301-bd3b-cc50861735f0", 41 },
                    { "86e02b21-25d7-4246-af4f-beac10cff1a6", 41 },
                    { "88a75459-c19a-40f1-98bb-5d51bb514359", 41 },
                    { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 41 },
                    { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 41 },
                    { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 41 },
                    { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 41 },
                    { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 41 },
                    { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 41 },
                    { "b0433d4e-d7df-4868-b831-a17f0a30af31", 41 },
                    { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 41 },
                    { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 41 },
                    { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 41 },
                    { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 41 },
                    { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 41 },
                    { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 41 },
                    { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 41 },
                    { "d8a49048-5ac1-4586-907d-baceecb14fed", 41 },
                    { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 41 },
                    { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 41 },
                    { "5a118590-c2ac-4064-aab1-abbad1cd6bce", 43 },
                    { "659ad282-2d5b-47a7-b0bf-c773676cb16b", 43 },
                    { "6d07c695-8bfc-4a06-86e5-74bb86b3fd79", 43 },
                    { "6ebf8e6e-516b-463f-b996-dd327746e711", 43 },
                    { "73f3662c-2459-4b3e-8cc4-fabf43d05236", 43 },
                    { "79c263d0-fea3-4908-bc1e-d298311067d2", 43 },
                    { "7c61be63-6a12-4301-bd3b-cc50861735f0", 43 }
                });

            migrationBuilder.InsertData(
                table: "JoinedTopic",
                columns: new[] { "ForumUserId", "TopicId" },
                values: new object[,]
                {
                    { "86e02b21-25d7-4246-af4f-beac10cff1a6", 43 },
                    { "88a75459-c19a-40f1-98bb-5d51bb514359", 43 },
                    { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 43 },
                    { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 43 },
                    { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 43 },
                    { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 43 },
                    { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 43 },
                    { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 43 },
                    { "b0433d4e-d7df-4868-b831-a17f0a30af31", 43 },
                    { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 43 },
                    { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 43 },
                    { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 43 },
                    { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 43 },
                    { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 43 },
                    { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 43 },
                    { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 43 },
                    { "d8a49048-5ac1-4586-907d-baceecb14fed", 43 },
                    { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 43 },
                    { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 43 },
                    { "07b40a11-9941-4b21-a90a-605b11cdb487", 45 },
                    { "1093c6dc-48eb-486d-a866-b8f8b4bbf77b", 45 },
                    { "1093c6dc-48eb-486d-a866-b8f8b4bbf77b", 46 },
                    { "4635c38a-41ec-42e1-9f67-9f8b3a7e3d80", 46 },
                    { "4a99a16d-1096-44cb-96a3-053b56917bcf", 46 },
                    { "54c4d727-865e-438b-ab3f-339a689c5c19", 46 },
                    { "5a118590-c2ac-4064-aab1-abbad1cd6bce", 46 },
                    { "659ad282-2d5b-47a7-b0bf-c773676cb16b", 46 },
                    { "6d07c695-8bfc-4a06-86e5-74bb86b3fd79", 46 },
                    { "6ebf8e6e-516b-463f-b996-dd327746e711", 46 },
                    { "73f3662c-2459-4b3e-8cc4-fabf43d05236", 46 },
                    { "79c263d0-fea3-4908-bc1e-d298311067d2", 46 },
                    { "7c61be63-6a12-4301-bd3b-cc50861735f0", 46 },
                    { "86e02b21-25d7-4246-af4f-beac10cff1a6", 46 },
                    { "88a75459-c19a-40f1-98bb-5d51bb514359", 46 },
                    { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 46 },
                    { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 46 },
                    { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 46 },
                    { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 46 },
                    { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 46 },
                    { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 46 },
                    { "b0433d4e-d7df-4868-b831-a17f0a30af31", 46 },
                    { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 46 }
                });

            migrationBuilder.InsertData(
                table: "JoinedTopic",
                columns: new[] { "ForumUserId", "TopicId" },
                values: new object[,]
                {
                    { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 46 },
                    { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 46 },
                    { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 46 },
                    { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 46 },
                    { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 46 },
                    { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 46 },
                    { "d8a49048-5ac1-4586-907d-baceecb14fed", 46 },
                    { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 46 },
                    { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 46 },
                    { "73f3662c-2459-4b3e-8cc4-fabf43d05236", 62 },
                    { "79c263d0-fea3-4908-bc1e-d298311067d2", 62 },
                    { "7c61be63-6a12-4301-bd3b-cc50861735f0", 62 },
                    { "86e02b21-25d7-4246-af4f-beac10cff1a6", 62 },
                    { "88a75459-c19a-40f1-98bb-5d51bb514359", 62 },
                    { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 62 },
                    { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 62 },
                    { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 62 },
                    { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 62 },
                    { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 62 },
                    { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 62 },
                    { "b0433d4e-d7df-4868-b831-a17f0a30af31", 62 },
                    { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 62 },
                    { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 62 },
                    { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 62 },
                    { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 62 },
                    { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 62 },
                    { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 62 },
                    { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 62 },
                    { "d8a49048-5ac1-4586-907d-baceecb14fed", 62 },
                    { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 62 },
                    { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 62 },
                    { "1093c6dc-48eb-486d-a866-b8f8b4bbf77b", 66 },
                    { "4635c38a-41ec-42e1-9f67-9f8b3a7e3d80", 66 },
                    { "07b40a11-9941-4b21-a90a-605b11cdb487", 67 },
                    { "1093c6dc-48eb-486d-a866-b8f8b4bbf77b", 67 },
                    { "5a118590-c2ac-4064-aab1-abbad1cd6bce", 71 },
                    { "659ad282-2d5b-47a7-b0bf-c773676cb16b", 71 },
                    { "6d07c695-8bfc-4a06-86e5-74bb86b3fd79", 71 },
                    { "6ebf8e6e-516b-463f-b996-dd327746e711", 71 },
                    { "73f3662c-2459-4b3e-8cc4-fabf43d05236", 71 },
                    { "79c263d0-fea3-4908-bc1e-d298311067d2", 71 },
                    { "7c61be63-6a12-4301-bd3b-cc50861735f0", 71 }
                });

            migrationBuilder.InsertData(
                table: "JoinedTopic",
                columns: new[] { "ForumUserId", "TopicId" },
                values: new object[,]
                {
                    { "86e02b21-25d7-4246-af4f-beac10cff1a6", 71 },
                    { "88a75459-c19a-40f1-98bb-5d51bb514359", 71 },
                    { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 71 },
                    { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 71 },
                    { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 71 },
                    { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 71 },
                    { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 71 },
                    { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 71 },
                    { "b0433d4e-d7df-4868-b831-a17f0a30af31", 71 },
                    { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 71 },
                    { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 71 },
                    { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 71 },
                    { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 71 },
                    { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 71 },
                    { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 71 },
                    { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 71 },
                    { "d8a49048-5ac1-4586-907d-baceecb14fed", 71 },
                    { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 71 },
                    { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 71 },
                    { "7c61be63-6a12-4301-bd3b-cc50861735f0", 75 },
                    { "86e02b21-25d7-4246-af4f-beac10cff1a6", 75 },
                    { "88a75459-c19a-40f1-98bb-5d51bb514359", 75 },
                    { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 75 },
                    { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 75 },
                    { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 75 },
                    { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 75 },
                    { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 75 },
                    { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 75 },
                    { "b0433d4e-d7df-4868-b831-a17f0a30af31", 75 },
                    { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 75 },
                    { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 75 },
                    { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 75 },
                    { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 75 },
                    { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 75 },
                    { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 75 },
                    { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 75 },
                    { "d8a49048-5ac1-4586-907d-baceecb14fed", 75 },
                    { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 75 },
                    { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 75 },
                    { "1093c6dc-48eb-486d-a866-b8f8b4bbf77b", 76 },
                    { "4635c38a-41ec-42e1-9f67-9f8b3a7e3d80", 76 },
                    { "4a99a16d-1096-44cb-96a3-053b56917bcf", 76 }
                });

            migrationBuilder.InsertData(
                table: "JoinedTopic",
                columns: new[] { "ForumUserId", "TopicId" },
                values: new object[,]
                {
                    { "54c4d727-865e-438b-ab3f-339a689c5c19", 76 },
                    { "5a118590-c2ac-4064-aab1-abbad1cd6bce", 76 },
                    { "659ad282-2d5b-47a7-b0bf-c773676cb16b", 76 },
                    { "6d07c695-8bfc-4a06-86e5-74bb86b3fd79", 76 },
                    { "6ebf8e6e-516b-463f-b996-dd327746e711", 76 },
                    { "73f3662c-2459-4b3e-8cc4-fabf43d05236", 76 },
                    { "79c263d0-fea3-4908-bc1e-d298311067d2", 76 },
                    { "7c61be63-6a12-4301-bd3b-cc50861735f0", 76 },
                    { "86e02b21-25d7-4246-af4f-beac10cff1a6", 76 },
                    { "88a75459-c19a-40f1-98bb-5d51bb514359", 76 },
                    { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 76 },
                    { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 76 },
                    { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 76 },
                    { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 76 },
                    { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 76 },
                    { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 76 },
                    { "b0433d4e-d7df-4868-b831-a17f0a30af31", 76 },
                    { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 76 },
                    { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 76 },
                    { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 76 },
                    { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 76 },
                    { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 76 },
                    { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 76 },
                    { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 76 },
                    { "d8a49048-5ac1-4586-907d-baceecb14fed", 76 },
                    { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 76 },
                    { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 76 },
                    { "4a99a16d-1096-44cb-96a3-053b56917bcf", 78 },
                    { "54c4d727-865e-438b-ab3f-339a689c5c19", 78 },
                    { "5a118590-c2ac-4064-aab1-abbad1cd6bce", 78 },
                    { "659ad282-2d5b-47a7-b0bf-c773676cb16b", 78 },
                    { "6d07c695-8bfc-4a06-86e5-74bb86b3fd79", 78 },
                    { "6ebf8e6e-516b-463f-b996-dd327746e711", 78 },
                    { "73f3662c-2459-4b3e-8cc4-fabf43d05236", 78 },
                    { "79c263d0-fea3-4908-bc1e-d298311067d2", 78 },
                    { "7c61be63-6a12-4301-bd3b-cc50861735f0", 78 },
                    { "86e02b21-25d7-4246-af4f-beac10cff1a6", 78 },
                    { "88a75459-c19a-40f1-98bb-5d51bb514359", 78 },
                    { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 78 },
                    { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 78 },
                    { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 78 },
                    { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 78 }
                });

            migrationBuilder.InsertData(
                table: "JoinedTopic",
                columns: new[] { "ForumUserId", "TopicId" },
                values: new object[,]
                {
                    { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 78 },
                    { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 78 },
                    { "b0433d4e-d7df-4868-b831-a17f0a30af31", 78 },
                    { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 78 },
                    { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 78 },
                    { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 78 },
                    { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 78 },
                    { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 78 },
                    { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 78 },
                    { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 78 },
                    { "d8a49048-5ac1-4586-907d-baceecb14fed", 78 },
                    { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 78 },
                    { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 78 },
                    { "7c61be63-6a12-4301-bd3b-cc50861735f0", 85 },
                    { "86e02b21-25d7-4246-af4f-beac10cff1a6", 85 },
                    { "88a75459-c19a-40f1-98bb-5d51bb514359", 85 },
                    { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 85 },
                    { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 85 },
                    { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 85 },
                    { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 85 },
                    { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 85 },
                    { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 85 },
                    { "b0433d4e-d7df-4868-b831-a17f0a30af31", 85 },
                    { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 85 },
                    { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 85 },
                    { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 85 },
                    { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 85 },
                    { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 85 },
                    { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 85 },
                    { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 85 },
                    { "d8a49048-5ac1-4586-907d-baceecb14fed", 85 },
                    { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 85 },
                    { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 85 },
                    { "1093c6dc-48eb-486d-a866-b8f8b4bbf77b", 88 },
                    { "4a99a16d-1096-44cb-96a3-053b56917bcf", 88 },
                    { "54c4d727-865e-438b-ab3f-339a689c5c19", 88 },
                    { "5a118590-c2ac-4064-aab1-abbad1cd6bce", 88 },
                    { "659ad282-2d5b-47a7-b0bf-c773676cb16b", 88 },
                    { "6d07c695-8bfc-4a06-86e5-74bb86b3fd79", 88 },
                    { "6ebf8e6e-516b-463f-b996-dd327746e711", 88 },
                    { "73f3662c-2459-4b3e-8cc4-fabf43d05236", 88 },
                    { "79c263d0-fea3-4908-bc1e-d298311067d2", 88 }
                });

            migrationBuilder.InsertData(
                table: "JoinedTopic",
                columns: new[] { "ForumUserId", "TopicId" },
                values: new object[,]
                {
                    { "7c61be63-6a12-4301-bd3b-cc50861735f0", 88 },
                    { "86e02b21-25d7-4246-af4f-beac10cff1a6", 88 },
                    { "88a75459-c19a-40f1-98bb-5d51bb514359", 88 },
                    { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 88 },
                    { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 88 },
                    { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 88 },
                    { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 88 },
                    { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 88 },
                    { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 88 },
                    { "b0433d4e-d7df-4868-b831-a17f0a30af31", 88 },
                    { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 88 },
                    { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 88 },
                    { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 88 },
                    { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 88 },
                    { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 88 },
                    { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 88 },
                    { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 88 },
                    { "d8a49048-5ac1-4586-907d-baceecb14fed", 88 },
                    { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 88 },
                    { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 88 },
                    { "07b40a11-9941-4b21-a90a-605b11cdb487", 90 },
                    { "4635c38a-41ec-42e1-9f67-9f8b3a7e3d80", 90 },
                    { "07b40a11-9941-4b21-a90a-605b11cdb487", 94 },
                    { "1093c6dc-48eb-486d-a866-b8f8b4bbf77b", 94 },
                    { "4a99a16d-1096-44cb-96a3-053b56917bcf", 94 },
                    { "54c4d727-865e-438b-ab3f-339a689c5c19", 94 },
                    { "5a118590-c2ac-4064-aab1-abbad1cd6bce", 94 },
                    { "659ad282-2d5b-47a7-b0bf-c773676cb16b", 94 },
                    { "6d07c695-8bfc-4a06-86e5-74bb86b3fd79", 94 },
                    { "6ebf8e6e-516b-463f-b996-dd327746e711", 94 },
                    { "73f3662c-2459-4b3e-8cc4-fabf43d05236", 94 },
                    { "79c263d0-fea3-4908-bc1e-d298311067d2", 94 },
                    { "7c61be63-6a12-4301-bd3b-cc50861735f0", 94 },
                    { "86e02b21-25d7-4246-af4f-beac10cff1a6", 94 },
                    { "88a75459-c19a-40f1-98bb-5d51bb514359", 94 },
                    { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 94 },
                    { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 94 },
                    { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 94 },
                    { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 94 },
                    { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 94 },
                    { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 94 },
                    { "b0433d4e-d7df-4868-b831-a17f0a30af31", 94 }
                });

            migrationBuilder.InsertData(
                table: "JoinedTopic",
                columns: new[] { "ForumUserId", "TopicId" },
                values: new object[,]
                {
                    { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 94 },
                    { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 94 },
                    { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 94 },
                    { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 94 },
                    { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 94 },
                    { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 94 },
                    { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 94 },
                    { "d8a49048-5ac1-4586-907d-baceecb14fed", 94 },
                    { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 94 },
                    { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 94 },
                    { "5a118590-c2ac-4064-aab1-abbad1cd6bce", 96 },
                    { "659ad282-2d5b-47a7-b0bf-c773676cb16b", 96 },
                    { "6d07c695-8bfc-4a06-86e5-74bb86b3fd79", 96 },
                    { "6ebf8e6e-516b-463f-b996-dd327746e711", 96 },
                    { "73f3662c-2459-4b3e-8cc4-fabf43d05236", 96 },
                    { "79c263d0-fea3-4908-bc1e-d298311067d2", 96 },
                    { "7c61be63-6a12-4301-bd3b-cc50861735f0", 96 },
                    { "86e02b21-25d7-4246-af4f-beac10cff1a6", 96 },
                    { "88a75459-c19a-40f1-98bb-5d51bb514359", 96 },
                    { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 96 },
                    { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 96 },
                    { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 96 },
                    { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 96 },
                    { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 96 },
                    { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 96 },
                    { "b0433d4e-d7df-4868-b831-a17f0a30af31", 96 },
                    { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 96 },
                    { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 96 },
                    { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 96 },
                    { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 96 },
                    { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 96 },
                    { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 96 },
                    { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 96 },
                    { "d8a49048-5ac1-4586-907d-baceecb14fed", 96 },
                    { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 96 },
                    { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 96 },
                    { "73f3662c-2459-4b3e-8cc4-fabf43d05236", 98 },
                    { "79c263d0-fea3-4908-bc1e-d298311067d2", 98 },
                    { "7c61be63-6a12-4301-bd3b-cc50861735f0", 98 },
                    { "86e02b21-25d7-4246-af4f-beac10cff1a6", 98 },
                    { "88a75459-c19a-40f1-98bb-5d51bb514359", 98 },
                    { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 98 }
                });

            migrationBuilder.InsertData(
                table: "JoinedTopic",
                columns: new[] { "ForumUserId", "TopicId" },
                values: new object[,]
                {
                    { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 98 },
                    { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 98 },
                    { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 98 },
                    { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 98 },
                    { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 98 },
                    { "b0433d4e-d7df-4868-b831-a17f0a30af31", 98 },
                    { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 98 },
                    { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 98 },
                    { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 98 },
                    { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 98 },
                    { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 98 },
                    { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 98 },
                    { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 98 },
                    { "d8a49048-5ac1-4586-907d-baceecb14fed", 98 },
                    { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 98 },
                    { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 98 },
                    { "73f3662c-2459-4b3e-8cc4-fabf43d05236", 99 },
                    { "79c263d0-fea3-4908-bc1e-d298311067d2", 99 },
                    { "7c61be63-6a12-4301-bd3b-cc50861735f0", 99 },
                    { "86e02b21-25d7-4246-af4f-beac10cff1a6", 99 },
                    { "88a75459-c19a-40f1-98bb-5d51bb514359", 99 },
                    { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 99 },
                    { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 99 },
                    { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 99 },
                    { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 99 },
                    { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 99 },
                    { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 99 },
                    { "b0433d4e-d7df-4868-b831-a17f0a30af31", 99 },
                    { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 99 },
                    { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 99 },
                    { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 99 },
                    { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 99 },
                    { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 99 },
                    { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 99 },
                    { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 99 },
                    { "d8a49048-5ac1-4586-907d-baceecb14fed", 99 },
                    { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 99 },
                    { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 99 },
                    { "5a118590-c2ac-4064-aab1-abbad1cd6bce", 102 },
                    { "659ad282-2d5b-47a7-b0bf-c773676cb16b", 102 },
                    { "6d07c695-8bfc-4a06-86e5-74bb86b3fd79", 102 },
                    { "6ebf8e6e-516b-463f-b996-dd327746e711", 102 }
                });

            migrationBuilder.InsertData(
                table: "JoinedTopic",
                columns: new[] { "ForumUserId", "TopicId" },
                values: new object[,]
                {
                    { "73f3662c-2459-4b3e-8cc4-fabf43d05236", 102 },
                    { "79c263d0-fea3-4908-bc1e-d298311067d2", 102 },
                    { "7c61be63-6a12-4301-bd3b-cc50861735f0", 102 },
                    { "86e02b21-25d7-4246-af4f-beac10cff1a6", 102 },
                    { "88a75459-c19a-40f1-98bb-5d51bb514359", 102 },
                    { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 102 },
                    { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 102 },
                    { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 102 },
                    { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 102 },
                    { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 102 },
                    { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 102 },
                    { "b0433d4e-d7df-4868-b831-a17f0a30af31", 102 },
                    { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 102 },
                    { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 102 },
                    { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 102 },
                    { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 102 },
                    { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 102 },
                    { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 102 },
                    { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 102 },
                    { "d8a49048-5ac1-4586-907d-baceecb14fed", 102 },
                    { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 102 },
                    { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 102 },
                    { "88a75459-c19a-40f1-98bb-5d51bb514359", 103 },
                    { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 103 },
                    { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 103 },
                    { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 103 },
                    { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 103 },
                    { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 103 },
                    { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 103 },
                    { "b0433d4e-d7df-4868-b831-a17f0a30af31", 103 },
                    { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 103 },
                    { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 103 },
                    { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 103 },
                    { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 103 },
                    { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 103 },
                    { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 103 },
                    { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 103 },
                    { "d8a49048-5ac1-4586-907d-baceecb14fed", 103 },
                    { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 103 },
                    { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 103 },
                    { "5a118590-c2ac-4064-aab1-abbad1cd6bce", 106 },
                    { "659ad282-2d5b-47a7-b0bf-c773676cb16b", 106 }
                });

            migrationBuilder.InsertData(
                table: "JoinedTopic",
                columns: new[] { "ForumUserId", "TopicId" },
                values: new object[,]
                {
                    { "6d07c695-8bfc-4a06-86e5-74bb86b3fd79", 106 },
                    { "6ebf8e6e-516b-463f-b996-dd327746e711", 106 },
                    { "73f3662c-2459-4b3e-8cc4-fabf43d05236", 106 },
                    { "79c263d0-fea3-4908-bc1e-d298311067d2", 106 },
                    { "7c61be63-6a12-4301-bd3b-cc50861735f0", 106 },
                    { "86e02b21-25d7-4246-af4f-beac10cff1a6", 106 },
                    { "88a75459-c19a-40f1-98bb-5d51bb514359", 106 },
                    { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 106 },
                    { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 106 },
                    { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 106 },
                    { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 106 },
                    { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 106 },
                    { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 106 },
                    { "b0433d4e-d7df-4868-b831-a17f0a30af31", 106 },
                    { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 106 },
                    { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 106 },
                    { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 106 },
                    { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 106 },
                    { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 106 },
                    { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 106 },
                    { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 106 },
                    { "d8a49048-5ac1-4586-907d-baceecb14fed", 106 },
                    { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 106 },
                    { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 106 },
                    { "5a118590-c2ac-4064-aab1-abbad1cd6bce", 110 },
                    { "659ad282-2d5b-47a7-b0bf-c773676cb16b", 110 },
                    { "6d07c695-8bfc-4a06-86e5-74bb86b3fd79", 110 },
                    { "6ebf8e6e-516b-463f-b996-dd327746e711", 110 },
                    { "73f3662c-2459-4b3e-8cc4-fabf43d05236", 110 },
                    { "79c263d0-fea3-4908-bc1e-d298311067d2", 110 },
                    { "7c61be63-6a12-4301-bd3b-cc50861735f0", 110 },
                    { "86e02b21-25d7-4246-af4f-beac10cff1a6", 110 },
                    { "88a75459-c19a-40f1-98bb-5d51bb514359", 110 },
                    { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 110 },
                    { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 110 },
                    { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 110 },
                    { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 110 },
                    { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 110 },
                    { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 110 },
                    { "b0433d4e-d7df-4868-b831-a17f0a30af31", 110 },
                    { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 110 },
                    { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 110 }
                });

            migrationBuilder.InsertData(
                table: "JoinedTopic",
                columns: new[] { "ForumUserId", "TopicId" },
                values: new object[,]
                {
                    { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 110 },
                    { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 110 },
                    { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 110 },
                    { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 110 },
                    { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 110 },
                    { "d8a49048-5ac1-4586-907d-baceecb14fed", 110 },
                    { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 110 },
                    { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 110 },
                    { "73f3662c-2459-4b3e-8cc4-fabf43d05236", 112 },
                    { "79c263d0-fea3-4908-bc1e-d298311067d2", 112 },
                    { "7c61be63-6a12-4301-bd3b-cc50861735f0", 112 },
                    { "86e02b21-25d7-4246-af4f-beac10cff1a6", 112 },
                    { "88a75459-c19a-40f1-98bb-5d51bb514359", 112 },
                    { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 112 },
                    { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 112 },
                    { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 112 },
                    { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 112 },
                    { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 112 },
                    { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 112 },
                    { "b0433d4e-d7df-4868-b831-a17f0a30af31", 112 },
                    { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 112 },
                    { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 112 },
                    { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 112 },
                    { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 112 },
                    { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 112 },
                    { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 112 },
                    { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 112 },
                    { "d8a49048-5ac1-4586-907d-baceecb14fed", 112 },
                    { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 112 },
                    { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 112 },
                    { "88a75459-c19a-40f1-98bb-5d51bb514359", 114 },
                    { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 114 },
                    { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 114 },
                    { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 114 },
                    { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 114 },
                    { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 114 },
                    { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 114 },
                    { "b0433d4e-d7df-4868-b831-a17f0a30af31", 114 },
                    { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 114 },
                    { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 114 },
                    { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 114 },
                    { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 114 }
                });

            migrationBuilder.InsertData(
                table: "JoinedTopic",
                columns: new[] { "ForumUserId", "TopicId" },
                values: new object[,]
                {
                    { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 114 },
                    { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 114 },
                    { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 114 },
                    { "d8a49048-5ac1-4586-907d-baceecb14fed", 114 },
                    { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 114 },
                    { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 114 },
                    { "88a75459-c19a-40f1-98bb-5d51bb514359", 115 },
                    { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 115 },
                    { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 115 },
                    { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 115 },
                    { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 115 },
                    { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 115 },
                    { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 115 },
                    { "b0433d4e-d7df-4868-b831-a17f0a30af31", 115 },
                    { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 115 },
                    { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 115 },
                    { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 115 },
                    { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 115 },
                    { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 115 },
                    { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 115 },
                    { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 115 },
                    { "d8a49048-5ac1-4586-907d-baceecb14fed", 115 },
                    { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 115 },
                    { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 115 },
                    { "88a75459-c19a-40f1-98bb-5d51bb514359", 116 },
                    { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 116 },
                    { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 116 },
                    { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 116 },
                    { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 116 },
                    { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 116 },
                    { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 116 },
                    { "b0433d4e-d7df-4868-b831-a17f0a30af31", 116 },
                    { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 116 },
                    { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 116 },
                    { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 116 },
                    { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 116 },
                    { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 116 },
                    { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 116 },
                    { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 116 },
                    { "d8a49048-5ac1-4586-907d-baceecb14fed", 116 },
                    { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 116 },
                    { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 116 }
                });

            migrationBuilder.InsertData(
                table: "JoinedTopic",
                columns: new[] { "ForumUserId", "TopicId" },
                values: new object[,]
                {
                    { "88a75459-c19a-40f1-98bb-5d51bb514359", 120 },
                    { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 120 },
                    { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 120 },
                    { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 120 },
                    { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 120 },
                    { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 120 },
                    { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 120 },
                    { "b0433d4e-d7df-4868-b831-a17f0a30af31", 120 },
                    { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 120 },
                    { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 120 },
                    { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 120 },
                    { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 120 },
                    { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 120 },
                    { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 120 },
                    { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 120 },
                    { "d8a49048-5ac1-4586-907d-baceecb14fed", 120 },
                    { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 120 },
                    { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 120 },
                    { "88a75459-c19a-40f1-98bb-5d51bb514359", 122 },
                    { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 122 },
                    { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 122 },
                    { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 122 },
                    { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 122 },
                    { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 122 },
                    { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 122 },
                    { "b0433d4e-d7df-4868-b831-a17f0a30af31", 122 },
                    { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 122 },
                    { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 122 },
                    { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 122 },
                    { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 122 },
                    { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 122 },
                    { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 122 },
                    { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 122 },
                    { "d8a49048-5ac1-4586-907d-baceecb14fed", 122 },
                    { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 122 },
                    { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 122 },
                    { "88a75459-c19a-40f1-98bb-5d51bb514359", 123 },
                    { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 123 },
                    { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 123 },
                    { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 123 },
                    { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 123 },
                    { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 123 }
                });

            migrationBuilder.InsertData(
                table: "JoinedTopic",
                columns: new[] { "ForumUserId", "TopicId" },
                values: new object[,]
                {
                    { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 123 },
                    { "b0433d4e-d7df-4868-b831-a17f0a30af31", 123 },
                    { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 123 },
                    { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 123 },
                    { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 123 },
                    { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 123 },
                    { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 123 },
                    { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 123 },
                    { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 123 },
                    { "d8a49048-5ac1-4586-907d-baceecb14fed", 123 },
                    { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 123 },
                    { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 123 }
                });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 781, DateTimeKind.Local).AddTicks(9888), new DateTime(2024, 3, 29, 14, 26, 40, 781, DateTimeKind.Local).AddTicks(9850) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 781, DateTimeKind.Local).AddTicks(9899), new DateTime(2024, 3, 29, 14, 26, 40, 781, DateTimeKind.Local).AddTicks(9897) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 781, DateTimeKind.Local).AddTicks(9905), new DateTime(2024, 3, 29, 14, 26, 40, 781, DateTimeKind.Local).AddTicks(9903) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 781, DateTimeKind.Local).AddTicks(9911), new DateTime(2024, 3, 29, 14, 26, 40, 781, DateTimeKind.Local).AddTicks(9909) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 781, DateTimeKind.Local).AddTicks(9917), new DateTime(2024, 3, 29, 14, 26, 40, 781, DateTimeKind.Local).AddTicks(9914) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 781, DateTimeKind.Local).AddTicks(9924), new DateTime(2024, 3, 29, 14, 26, 40, 781, DateTimeKind.Local).AddTicks(9922) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 781, DateTimeKind.Local).AddTicks(9930), new DateTime(2024, 3, 29, 14, 26, 40, 781, DateTimeKind.Local).AddTicks(9928) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 781, DateTimeKind.Local).AddTicks(9936), new DateTime(2024, 3, 29, 14, 26, 40, 781, DateTimeKind.Local).AddTicks(9934) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 781, DateTimeKind.Local).AddTicks(9942), new DateTime(2024, 3, 29, 14, 26, 40, 781, DateTimeKind.Local).AddTicks(9939) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 781, DateTimeKind.Local).AddTicks(9949), new DateTime(2024, 3, 29, 14, 26, 40, 781, DateTimeKind.Local).AddTicks(9946) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 781, DateTimeKind.Local).AddTicks(9955), new DateTime(2024, 3, 29, 14, 26, 40, 781, DateTimeKind.Local).AddTicks(9952) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 781, DateTimeKind.Local).AddTicks(9960), new DateTime(2024, 3, 29, 14, 26, 40, 781, DateTimeKind.Local).AddTicks(9958) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 781, DateTimeKind.Local).AddTicks(9966), new DateTime(2024, 3, 29, 14, 26, 40, 781, DateTimeKind.Local).AddTicks(9964) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 781, DateTimeKind.Local).AddTicks(9972), new DateTime(2024, 3, 29, 14, 26, 40, 781, DateTimeKind.Local).AddTicks(9970) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 781, DateTimeKind.Local).AddTicks(9978), new DateTime(2024, 3, 29, 14, 26, 40, 781, DateTimeKind.Local).AddTicks(9975) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 781, DateTimeKind.Local).AddTicks(9984), new DateTime(2024, 3, 29, 14, 26, 40, 781, DateTimeKind.Local).AddTicks(9981) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 781, DateTimeKind.Local).AddTicks(9989), new DateTime(2024, 3, 29, 14, 26, 40, 781, DateTimeKind.Local).AddTicks(9987) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 781, DateTimeKind.Local).AddTicks(9997), new DateTime(2024, 3, 29, 14, 26, 40, 781, DateTimeKind.Local).AddTicks(9994) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(2), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(8), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(6) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(14), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(11) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(20), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(17) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(25), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(23) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(31), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(29) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(37), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(34) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(43), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(40) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(48), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(46) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(54), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(52) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(60), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(57) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(66), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(63) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(71), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(69) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(77), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(75) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(83), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(80) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(90), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(88) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(96), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(94) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(102), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(99) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(107), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(105) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(113), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(111) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(119), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(117) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(125), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(122) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(142), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(140) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(148), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(146) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(154), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(152) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(160), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(157) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(166), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(163) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(171), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(169) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(177), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(175) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(183), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(180) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(189), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(186) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(194), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(192) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(200), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(198) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(206), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(203) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(212), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(209) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(217), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(215) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(223), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(221) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(229), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(226) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(235), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(232) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(240), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(238) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(246), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(244) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(252), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(250) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(258), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(255) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(263), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(261) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(269), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(267) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(275), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(272) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(281), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(278) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(288), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(286) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(294), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(292) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(300), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(297) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(306), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(303) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(311), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(309) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(317), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(315) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(323), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(320) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(329), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(326) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(334), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(332) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(340), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(338) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(346), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(343) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(352), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(349) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(357), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(355) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(363), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(361) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(369), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(367) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(375), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(372) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(380), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(378) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(386), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(384) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(392), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(389) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(404), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(402) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(410), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(408) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(416), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(414) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(422), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(419) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(428), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(425) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(433), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(431) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(439), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(437) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(445), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(442) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(450), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(448) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(456), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(454) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(462), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(460) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(468), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(465) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(473), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(471) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(479), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(477) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(485), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(483) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(491), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(488) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(496), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(494) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(502), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(500) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(508), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(505) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(514), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(511) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(519), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(517) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(525), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(523) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(531), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(529) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(537), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(534) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(542), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(540) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(548), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(546) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(554), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(551) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(560), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(557) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(565), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(563) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(571), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(569) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(577), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(574) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(583), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(580) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(588), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(586) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(594), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(592) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(600), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(597) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(606), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(603) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(611), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(609) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(617), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(615) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(623), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(620) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(629), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(626) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(634), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(632) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(640), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(638) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(646), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(643) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(652), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(649) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(657), new DateTime(2024, 3, 29, 14, 26, 40, 782, DateTimeKind.Local).AddTicks(655) });

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1bda777f-d458-4ae6-b89a-e1f019149bec", "085bf7a7-da17-40fe-bc8e-ffef207316ad" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1bda777f-d458-4ae6-b89a-e1f019149bec", "08836084-ec69-4663-bd5c-743575f34bdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1bda777f-d458-4ae6-b89a-e1f019149bec", "1ff5865b-8ffd-459f-9e6c-5ff9f5a08e2e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1bda777f-d458-4ae6-b89a-e1f019149bec", "2e651bfd-f58b-43ef-86d6-96b84e61f5f9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1bda777f-d458-4ae6-b89a-e1f019149bec", "2ef871e3-650a-44f7-8a55-b4e7cb1508e1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1bda777f-d458-4ae6-b89a-e1f019149bec", "30ddcbb2-38e9-4c32-8ec5-cd59d637b099" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1bda777f-d458-4ae6-b89a-e1f019149bec", "32076358-f21f-4d99-bb1a-e8fd484611df" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1bda777f-d458-4ae6-b89a-e1f019149bec", "3c7e3a85-f802-4c9c-8dc0-729c6391d500" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1bda777f-d458-4ae6-b89a-e1f019149bec", "427b763c-db92-4e38-af69-0eb636580aae" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1bda777f-d458-4ae6-b89a-e1f019149bec", "48be314c-8033-44a7-a6fc-8d6c746e8648" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1bda777f-d458-4ae6-b89a-e1f019149bec", "59199cda-06ab-4ce3-b7f6-aabc0183ceaa" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1bda777f-d458-4ae6-b89a-e1f019149bec", "5a58b850-ee28-4f9c-a2b5-815f5f65584e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1bda777f-d458-4ae6-b89a-e1f019149bec", "649dcef4-4445-42dc-864d-a3aaed9d3994" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1bda777f-d458-4ae6-b89a-e1f019149bec", "66a2e531-9d21-4ac8-affd-f8120e449384" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1bda777f-d458-4ae6-b89a-e1f019149bec", "69978dbf-37d6-4a91-b09d-d3f1c641f2e9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1bda777f-d458-4ae6-b89a-e1f019149bec", "6aee9516-0099-40c6-b2a0-3489cafb215e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1bda777f-d458-4ae6-b89a-e1f019149bec", "6e5e1c32-a516-402f-b9bd-34889e9969bc" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1bda777f-d458-4ae6-b89a-e1f019149bec", "752c49aa-0bee-4c45-a695-2a7da6274fb9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1bda777f-d458-4ae6-b89a-e1f019149bec", "7bc576d0-c572-44c4-b25c-5df8bd4ed4cf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1bda777f-d458-4ae6-b89a-e1f019149bec", "83f228e0-2e70-41ea-8c9b-2bdbe6544796" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1bda777f-d458-4ae6-b89a-e1f019149bec", "8794a217-bcbc-48e5-a582-934bff1cefec" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1bda777f-d458-4ae6-b89a-e1f019149bec", "9cf71a8d-53f4-405c-bafa-226083eae8b6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1bda777f-d458-4ae6-b89a-e1f019149bec", "b5b08e7f-c01b-4493-9490-8ef92b266929" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1bda777f-d458-4ae6-b89a-e1f019149bec", "caca7aa1-e368-4028-8e34-20297175515a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1bda777f-d458-4ae6-b89a-e1f019149bec", "e9376bdf-9c1d-4330-a6c1-2571bda649b1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1bda777f-d458-4ae6-b89a-e1f019149bec", "ea0e0994-77d9-4be5-ba52-5ddeff82917c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1bda777f-d458-4ae6-b89a-e1f019149bec", "ed9503db-79f7-4133-9636-04835e89a05f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1bda777f-d458-4ae6-b89a-e1f019149bec", "f79c2ca4-b5cb-4d3b-b998-5d43d3bf070e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1bda777f-d458-4ae6-b89a-e1f019149bec", "f88cf83b-d76a-498e-b82a-b6486b49fcee" });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 1 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 1 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b0433d4e-d7df-4868-b831-a17f0a30af31", 1 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 1 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 1 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 1 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 1 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 1 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 1 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 1 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d8a49048-5ac1-4586-907d-baceecb14fed", 1 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 1 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 1 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "07b40a11-9941-4b21-a90a-605b11cdb487", 2 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "1093c6dc-48eb-486d-a866-b8f8b4bbf77b", 2 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "4635c38a-41ec-42e1-9f67-9f8b3a7e3d80", 2 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "4a99a16d-1096-44cb-96a3-053b56917bcf", 2 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "54c4d727-865e-438b-ab3f-339a689c5c19", 2 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "5a118590-c2ac-4064-aab1-abbad1cd6bce", 2 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "659ad282-2d5b-47a7-b0bf-c773676cb16b", 2 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "6d07c695-8bfc-4a06-86e5-74bb86b3fd79", 2 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "6ebf8e6e-516b-463f-b996-dd327746e711", 2 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "73f3662c-2459-4b3e-8cc4-fabf43d05236", 2 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "79c263d0-fea3-4908-bc1e-d298311067d2", 2 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "7c61be63-6a12-4301-bd3b-cc50861735f0", 2 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "86e02b21-25d7-4246-af4f-beac10cff1a6", 2 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "88a75459-c19a-40f1-98bb-5d51bb514359", 2 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 2 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 2 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 2 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 2 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 2 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 2 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b0433d4e-d7df-4868-b831-a17f0a30af31", 2 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 2 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 2 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 2 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 2 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 2 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 2 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 2 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d8a49048-5ac1-4586-907d-baceecb14fed", 2 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 2 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 2 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 3 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 3 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b0433d4e-d7df-4868-b831-a17f0a30af31", 3 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 3 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 3 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 3 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 3 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 3 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 3 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 3 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d8a49048-5ac1-4586-907d-baceecb14fed", 3 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 3 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 3 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 4 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 4 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b0433d4e-d7df-4868-b831-a17f0a30af31", 4 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 4 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 4 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 4 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 4 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 4 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 4 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 4 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d8a49048-5ac1-4586-907d-baceecb14fed", 4 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 4 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 4 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 5 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 5 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b0433d4e-d7df-4868-b831-a17f0a30af31", 5 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 5 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 5 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 5 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 5 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 5 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 5 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 5 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d8a49048-5ac1-4586-907d-baceecb14fed", 5 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 5 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 5 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "07b40a11-9941-4b21-a90a-605b11cdb487", 6 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "4635c38a-41ec-42e1-9f67-9f8b3a7e3d80", 6 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "73f3662c-2459-4b3e-8cc4-fabf43d05236", 7 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "79c263d0-fea3-4908-bc1e-d298311067d2", 7 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "7c61be63-6a12-4301-bd3b-cc50861735f0", 7 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "86e02b21-25d7-4246-af4f-beac10cff1a6", 7 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "88a75459-c19a-40f1-98bb-5d51bb514359", 7 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 7 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 7 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 7 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 7 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 7 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 7 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b0433d4e-d7df-4868-b831-a17f0a30af31", 7 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 7 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 7 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 7 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 7 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 7 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 7 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 7 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d8a49048-5ac1-4586-907d-baceecb14fed", 7 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 7 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 7 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "73f3662c-2459-4b3e-8cc4-fabf43d05236", 8 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "79c263d0-fea3-4908-bc1e-d298311067d2", 8 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "7c61be63-6a12-4301-bd3b-cc50861735f0", 8 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "86e02b21-25d7-4246-af4f-beac10cff1a6", 8 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "88a75459-c19a-40f1-98bb-5d51bb514359", 8 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 8 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 8 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 8 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 8 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 8 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 8 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b0433d4e-d7df-4868-b831-a17f0a30af31", 8 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 8 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 8 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 8 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 8 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 8 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 8 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 8 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d8a49048-5ac1-4586-907d-baceecb14fed", 8 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 8 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 8 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 10 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 10 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b0433d4e-d7df-4868-b831-a17f0a30af31", 10 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 10 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 10 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 10 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 10 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 10 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 10 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 10 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d8a49048-5ac1-4586-907d-baceecb14fed", 10 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 10 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 10 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "07b40a11-9941-4b21-a90a-605b11cdb487", 12 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "1093c6dc-48eb-486d-a866-b8f8b4bbf77b", 12 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "1093c6dc-48eb-486d-a866-b8f8b4bbf77b", 13 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "5a118590-c2ac-4064-aab1-abbad1cd6bce", 13 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "659ad282-2d5b-47a7-b0bf-c773676cb16b", 13 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "6d07c695-8bfc-4a06-86e5-74bb86b3fd79", 13 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "6ebf8e6e-516b-463f-b996-dd327746e711", 13 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "73f3662c-2459-4b3e-8cc4-fabf43d05236", 13 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "79c263d0-fea3-4908-bc1e-d298311067d2", 13 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "7c61be63-6a12-4301-bd3b-cc50861735f0", 13 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "86e02b21-25d7-4246-af4f-beac10cff1a6", 13 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "88a75459-c19a-40f1-98bb-5d51bb514359", 13 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 13 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 13 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 13 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 13 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 13 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 13 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b0433d4e-d7df-4868-b831-a17f0a30af31", 13 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 13 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 13 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 13 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 13 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 13 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 13 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 13 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d8a49048-5ac1-4586-907d-baceecb14fed", 13 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 13 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 13 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "07b40a11-9941-4b21-a90a-605b11cdb487", 14 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "1093c6dc-48eb-486d-a866-b8f8b4bbf77b", 14 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "4635c38a-41ec-42e1-9f67-9f8b3a7e3d80", 14 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "4a99a16d-1096-44cb-96a3-053b56917bcf", 14 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "54c4d727-865e-438b-ab3f-339a689c5c19", 14 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "5a118590-c2ac-4064-aab1-abbad1cd6bce", 14 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "659ad282-2d5b-47a7-b0bf-c773676cb16b", 14 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "6d07c695-8bfc-4a06-86e5-74bb86b3fd79", 14 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "6ebf8e6e-516b-463f-b996-dd327746e711", 14 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "73f3662c-2459-4b3e-8cc4-fabf43d05236", 14 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "79c263d0-fea3-4908-bc1e-d298311067d2", 14 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "7c61be63-6a12-4301-bd3b-cc50861735f0", 14 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "86e02b21-25d7-4246-af4f-beac10cff1a6", 14 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "88a75459-c19a-40f1-98bb-5d51bb514359", 14 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 14 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 14 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 14 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 14 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 14 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 14 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b0433d4e-d7df-4868-b831-a17f0a30af31", 14 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 14 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 14 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 14 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 14 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 14 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 14 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 14 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d8a49048-5ac1-4586-907d-baceecb14fed", 14 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 14 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 14 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "1093c6dc-48eb-486d-a866-b8f8b4bbf77b", 15 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "4635c38a-41ec-42e1-9f67-9f8b3a7e3d80", 15 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "4a99a16d-1096-44cb-96a3-053b56917bcf", 15 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "54c4d727-865e-438b-ab3f-339a689c5c19", 15 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "5a118590-c2ac-4064-aab1-abbad1cd6bce", 15 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "659ad282-2d5b-47a7-b0bf-c773676cb16b", 15 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "6d07c695-8bfc-4a06-86e5-74bb86b3fd79", 15 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "6ebf8e6e-516b-463f-b996-dd327746e711", 15 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "73f3662c-2459-4b3e-8cc4-fabf43d05236", 15 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "79c263d0-fea3-4908-bc1e-d298311067d2", 15 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "7c61be63-6a12-4301-bd3b-cc50861735f0", 15 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "86e02b21-25d7-4246-af4f-beac10cff1a6", 15 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "88a75459-c19a-40f1-98bb-5d51bb514359", 15 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 15 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 15 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 15 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 15 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 15 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 15 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b0433d4e-d7df-4868-b831-a17f0a30af31", 15 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 15 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 15 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 15 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 15 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 15 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 15 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 15 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d8a49048-5ac1-4586-907d-baceecb14fed", 15 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 15 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 15 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "1093c6dc-48eb-486d-a866-b8f8b4bbf77b", 17 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "4635c38a-41ec-42e1-9f67-9f8b3a7e3d80", 17 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "73f3662c-2459-4b3e-8cc4-fabf43d05236", 17 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "79c263d0-fea3-4908-bc1e-d298311067d2", 17 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "7c61be63-6a12-4301-bd3b-cc50861735f0", 17 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "86e02b21-25d7-4246-af4f-beac10cff1a6", 17 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "88a75459-c19a-40f1-98bb-5d51bb514359", 17 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 17 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 17 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 17 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 17 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 17 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 17 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b0433d4e-d7df-4868-b831-a17f0a30af31", 17 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 17 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 17 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 17 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 17 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 17 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 17 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 17 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d8a49048-5ac1-4586-907d-baceecb14fed", 17 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 17 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 17 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "4a99a16d-1096-44cb-96a3-053b56917bcf", 18 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "54c4d727-865e-438b-ab3f-339a689c5c19", 18 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "5a118590-c2ac-4064-aab1-abbad1cd6bce", 18 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "659ad282-2d5b-47a7-b0bf-c773676cb16b", 18 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "6d07c695-8bfc-4a06-86e5-74bb86b3fd79", 18 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "6ebf8e6e-516b-463f-b996-dd327746e711", 18 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "73f3662c-2459-4b3e-8cc4-fabf43d05236", 18 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "79c263d0-fea3-4908-bc1e-d298311067d2", 18 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "7c61be63-6a12-4301-bd3b-cc50861735f0", 18 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "86e02b21-25d7-4246-af4f-beac10cff1a6", 18 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "88a75459-c19a-40f1-98bb-5d51bb514359", 18 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 18 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 18 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 18 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 18 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 18 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 18 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b0433d4e-d7df-4868-b831-a17f0a30af31", 18 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 18 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 18 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 18 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 18 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 18 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 18 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 18 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d8a49048-5ac1-4586-907d-baceecb14fed", 18 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 18 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 18 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "07b40a11-9941-4b21-a90a-605b11cdb487", 21 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "4a99a16d-1096-44cb-96a3-053b56917bcf", 21 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "54c4d727-865e-438b-ab3f-339a689c5c19", 21 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "5a118590-c2ac-4064-aab1-abbad1cd6bce", 21 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "659ad282-2d5b-47a7-b0bf-c773676cb16b", 21 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "6d07c695-8bfc-4a06-86e5-74bb86b3fd79", 21 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "6ebf8e6e-516b-463f-b996-dd327746e711", 21 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "73f3662c-2459-4b3e-8cc4-fabf43d05236", 21 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "79c263d0-fea3-4908-bc1e-d298311067d2", 21 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "7c61be63-6a12-4301-bd3b-cc50861735f0", 21 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "86e02b21-25d7-4246-af4f-beac10cff1a6", 21 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "88a75459-c19a-40f1-98bb-5d51bb514359", 21 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 21 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 21 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 21 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 21 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 21 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 21 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b0433d4e-d7df-4868-b831-a17f0a30af31", 21 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 21 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 21 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 21 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 21 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 21 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 21 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 21 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d8a49048-5ac1-4586-907d-baceecb14fed", 21 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 21 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 21 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "07b40a11-9941-4b21-a90a-605b11cdb487", 22 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "07b40a11-9941-4b21-a90a-605b11cdb487", 23 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "4a99a16d-1096-44cb-96a3-053b56917bcf", 24 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "54c4d727-865e-438b-ab3f-339a689c5c19", 24 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "5a118590-c2ac-4064-aab1-abbad1cd6bce", 24 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "659ad282-2d5b-47a7-b0bf-c773676cb16b", 24 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "6d07c695-8bfc-4a06-86e5-74bb86b3fd79", 24 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "6ebf8e6e-516b-463f-b996-dd327746e711", 24 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "73f3662c-2459-4b3e-8cc4-fabf43d05236", 24 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "79c263d0-fea3-4908-bc1e-d298311067d2", 24 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "7c61be63-6a12-4301-bd3b-cc50861735f0", 24 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "86e02b21-25d7-4246-af4f-beac10cff1a6", 24 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "88a75459-c19a-40f1-98bb-5d51bb514359", 24 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 24 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 24 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 24 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 24 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 24 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 24 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b0433d4e-d7df-4868-b831-a17f0a30af31", 24 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 24 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 24 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 24 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 24 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 24 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 24 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 24 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d8a49048-5ac1-4586-907d-baceecb14fed", 24 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 24 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 24 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "4a99a16d-1096-44cb-96a3-053b56917bcf", 25 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "54c4d727-865e-438b-ab3f-339a689c5c19", 25 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "5a118590-c2ac-4064-aab1-abbad1cd6bce", 25 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "659ad282-2d5b-47a7-b0bf-c773676cb16b", 25 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "6d07c695-8bfc-4a06-86e5-74bb86b3fd79", 25 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "6ebf8e6e-516b-463f-b996-dd327746e711", 25 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "73f3662c-2459-4b3e-8cc4-fabf43d05236", 25 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "79c263d0-fea3-4908-bc1e-d298311067d2", 25 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "7c61be63-6a12-4301-bd3b-cc50861735f0", 25 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "86e02b21-25d7-4246-af4f-beac10cff1a6", 25 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "88a75459-c19a-40f1-98bb-5d51bb514359", 25 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 25 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 25 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 25 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 25 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 25 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 25 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b0433d4e-d7df-4868-b831-a17f0a30af31", 25 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 25 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 25 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 25 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 25 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 25 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 25 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 25 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d8a49048-5ac1-4586-907d-baceecb14fed", 25 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 25 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 25 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "4a99a16d-1096-44cb-96a3-053b56917bcf", 26 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "54c4d727-865e-438b-ab3f-339a689c5c19", 26 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "5a118590-c2ac-4064-aab1-abbad1cd6bce", 26 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "659ad282-2d5b-47a7-b0bf-c773676cb16b", 26 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "6d07c695-8bfc-4a06-86e5-74bb86b3fd79", 26 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "6ebf8e6e-516b-463f-b996-dd327746e711", 26 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "73f3662c-2459-4b3e-8cc4-fabf43d05236", 26 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "79c263d0-fea3-4908-bc1e-d298311067d2", 26 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "7c61be63-6a12-4301-bd3b-cc50861735f0", 26 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "86e02b21-25d7-4246-af4f-beac10cff1a6", 26 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "88a75459-c19a-40f1-98bb-5d51bb514359", 26 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 26 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 26 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 26 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 26 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 26 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 26 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b0433d4e-d7df-4868-b831-a17f0a30af31", 26 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 26 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 26 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 26 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 26 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 26 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 26 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 26 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d8a49048-5ac1-4586-907d-baceecb14fed", 26 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 26 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 26 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "4a99a16d-1096-44cb-96a3-053b56917bcf", 27 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "54c4d727-865e-438b-ab3f-339a689c5c19", 27 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "5a118590-c2ac-4064-aab1-abbad1cd6bce", 27 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "659ad282-2d5b-47a7-b0bf-c773676cb16b", 27 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "6d07c695-8bfc-4a06-86e5-74bb86b3fd79", 27 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "6ebf8e6e-516b-463f-b996-dd327746e711", 27 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "73f3662c-2459-4b3e-8cc4-fabf43d05236", 27 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "79c263d0-fea3-4908-bc1e-d298311067d2", 27 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "7c61be63-6a12-4301-bd3b-cc50861735f0", 27 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "86e02b21-25d7-4246-af4f-beac10cff1a6", 27 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "88a75459-c19a-40f1-98bb-5d51bb514359", 27 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 27 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 27 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 27 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 27 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 27 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 27 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b0433d4e-d7df-4868-b831-a17f0a30af31", 27 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 27 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 27 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 27 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 27 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 27 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 27 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 27 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d8a49048-5ac1-4586-907d-baceecb14fed", 27 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 27 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 27 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "5a118590-c2ac-4064-aab1-abbad1cd6bce", 29 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "659ad282-2d5b-47a7-b0bf-c773676cb16b", 29 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "6d07c695-8bfc-4a06-86e5-74bb86b3fd79", 29 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "6ebf8e6e-516b-463f-b996-dd327746e711", 29 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "73f3662c-2459-4b3e-8cc4-fabf43d05236", 29 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "79c263d0-fea3-4908-bc1e-d298311067d2", 29 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "7c61be63-6a12-4301-bd3b-cc50861735f0", 29 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "86e02b21-25d7-4246-af4f-beac10cff1a6", 29 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "88a75459-c19a-40f1-98bb-5d51bb514359", 29 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 29 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 29 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 29 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 29 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 29 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 29 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b0433d4e-d7df-4868-b831-a17f0a30af31", 29 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 29 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 29 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 29 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 29 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 29 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 29 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 29 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d8a49048-5ac1-4586-907d-baceecb14fed", 29 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 29 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 29 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "4a99a16d-1096-44cb-96a3-053b56917bcf", 32 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "54c4d727-865e-438b-ab3f-339a689c5c19", 32 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "5a118590-c2ac-4064-aab1-abbad1cd6bce", 32 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "659ad282-2d5b-47a7-b0bf-c773676cb16b", 32 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "6d07c695-8bfc-4a06-86e5-74bb86b3fd79", 32 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "6ebf8e6e-516b-463f-b996-dd327746e711", 32 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "73f3662c-2459-4b3e-8cc4-fabf43d05236", 32 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "79c263d0-fea3-4908-bc1e-d298311067d2", 32 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "7c61be63-6a12-4301-bd3b-cc50861735f0", 32 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "86e02b21-25d7-4246-af4f-beac10cff1a6", 32 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "88a75459-c19a-40f1-98bb-5d51bb514359", 32 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 32 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 32 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 32 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 32 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 32 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 32 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b0433d4e-d7df-4868-b831-a17f0a30af31", 32 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 32 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 32 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 32 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 32 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 32 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 32 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 32 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d8a49048-5ac1-4586-907d-baceecb14fed", 32 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 32 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 32 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "5a118590-c2ac-4064-aab1-abbad1cd6bce", 33 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "659ad282-2d5b-47a7-b0bf-c773676cb16b", 33 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "6d07c695-8bfc-4a06-86e5-74bb86b3fd79", 33 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "6ebf8e6e-516b-463f-b996-dd327746e711", 33 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "73f3662c-2459-4b3e-8cc4-fabf43d05236", 33 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "79c263d0-fea3-4908-bc1e-d298311067d2", 33 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "7c61be63-6a12-4301-bd3b-cc50861735f0", 33 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "86e02b21-25d7-4246-af4f-beac10cff1a6", 33 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "88a75459-c19a-40f1-98bb-5d51bb514359", 33 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 33 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 33 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 33 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 33 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 33 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 33 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b0433d4e-d7df-4868-b831-a17f0a30af31", 33 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 33 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 33 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 33 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 33 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 33 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 33 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 33 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d8a49048-5ac1-4586-907d-baceecb14fed", 33 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 33 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 33 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "07b40a11-9941-4b21-a90a-605b11cdb487", 34 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "1093c6dc-48eb-486d-a866-b8f8b4bbf77b", 34 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "4635c38a-41ec-42e1-9f67-9f8b3a7e3d80", 34 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "4a99a16d-1096-44cb-96a3-053b56917bcf", 36 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "54c4d727-865e-438b-ab3f-339a689c5c19", 36 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "5a118590-c2ac-4064-aab1-abbad1cd6bce", 36 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "659ad282-2d5b-47a7-b0bf-c773676cb16b", 36 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "6d07c695-8bfc-4a06-86e5-74bb86b3fd79", 36 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "6ebf8e6e-516b-463f-b996-dd327746e711", 36 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "73f3662c-2459-4b3e-8cc4-fabf43d05236", 36 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "79c263d0-fea3-4908-bc1e-d298311067d2", 36 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "7c61be63-6a12-4301-bd3b-cc50861735f0", 36 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "86e02b21-25d7-4246-af4f-beac10cff1a6", 36 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "88a75459-c19a-40f1-98bb-5d51bb514359", 36 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 36 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 36 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 36 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 36 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 36 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 36 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b0433d4e-d7df-4868-b831-a17f0a30af31", 36 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 36 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 36 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 36 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 36 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 36 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 36 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 36 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d8a49048-5ac1-4586-907d-baceecb14fed", 36 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 36 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 36 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "73f3662c-2459-4b3e-8cc4-fabf43d05236", 37 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "79c263d0-fea3-4908-bc1e-d298311067d2", 37 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "7c61be63-6a12-4301-bd3b-cc50861735f0", 37 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "86e02b21-25d7-4246-af4f-beac10cff1a6", 37 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "88a75459-c19a-40f1-98bb-5d51bb514359", 37 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 37 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 37 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 37 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 37 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 37 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 37 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b0433d4e-d7df-4868-b831-a17f0a30af31", 37 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 37 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 37 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 37 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 37 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 37 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 37 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 37 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d8a49048-5ac1-4586-907d-baceecb14fed", 37 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 37 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 37 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "1093c6dc-48eb-486d-a866-b8f8b4bbf77b", 38 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "4635c38a-41ec-42e1-9f67-9f8b3a7e3d80", 38 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "4a99a16d-1096-44cb-96a3-053b56917bcf", 38 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "54c4d727-865e-438b-ab3f-339a689c5c19", 38 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "5a118590-c2ac-4064-aab1-abbad1cd6bce", 38 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "659ad282-2d5b-47a7-b0bf-c773676cb16b", 38 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "6d07c695-8bfc-4a06-86e5-74bb86b3fd79", 38 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "6ebf8e6e-516b-463f-b996-dd327746e711", 38 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "73f3662c-2459-4b3e-8cc4-fabf43d05236", 38 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "79c263d0-fea3-4908-bc1e-d298311067d2", 38 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "7c61be63-6a12-4301-bd3b-cc50861735f0", 38 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "86e02b21-25d7-4246-af4f-beac10cff1a6", 38 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "88a75459-c19a-40f1-98bb-5d51bb514359", 38 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 38 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 38 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 38 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 38 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 38 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 38 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b0433d4e-d7df-4868-b831-a17f0a30af31", 38 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 38 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 38 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 38 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 38 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 38 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 38 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 38 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d8a49048-5ac1-4586-907d-baceecb14fed", 38 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 38 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 38 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "5a118590-c2ac-4064-aab1-abbad1cd6bce", 39 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "659ad282-2d5b-47a7-b0bf-c773676cb16b", 39 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "6d07c695-8bfc-4a06-86e5-74bb86b3fd79", 39 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "6ebf8e6e-516b-463f-b996-dd327746e711", 39 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "73f3662c-2459-4b3e-8cc4-fabf43d05236", 39 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "79c263d0-fea3-4908-bc1e-d298311067d2", 39 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "7c61be63-6a12-4301-bd3b-cc50861735f0", 39 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "86e02b21-25d7-4246-af4f-beac10cff1a6", 39 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "88a75459-c19a-40f1-98bb-5d51bb514359", 39 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 39 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 39 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 39 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 39 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 39 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 39 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b0433d4e-d7df-4868-b831-a17f0a30af31", 39 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 39 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 39 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 39 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 39 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 39 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 39 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 39 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d8a49048-5ac1-4586-907d-baceecb14fed", 39 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 39 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 39 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "7c61be63-6a12-4301-bd3b-cc50861735f0", 41 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "86e02b21-25d7-4246-af4f-beac10cff1a6", 41 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "88a75459-c19a-40f1-98bb-5d51bb514359", 41 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 41 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 41 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 41 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 41 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 41 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 41 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b0433d4e-d7df-4868-b831-a17f0a30af31", 41 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 41 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 41 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 41 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 41 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 41 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 41 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 41 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d8a49048-5ac1-4586-907d-baceecb14fed", 41 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 41 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 41 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "5a118590-c2ac-4064-aab1-abbad1cd6bce", 43 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "659ad282-2d5b-47a7-b0bf-c773676cb16b", 43 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "6d07c695-8bfc-4a06-86e5-74bb86b3fd79", 43 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "6ebf8e6e-516b-463f-b996-dd327746e711", 43 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "73f3662c-2459-4b3e-8cc4-fabf43d05236", 43 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "79c263d0-fea3-4908-bc1e-d298311067d2", 43 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "7c61be63-6a12-4301-bd3b-cc50861735f0", 43 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "86e02b21-25d7-4246-af4f-beac10cff1a6", 43 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "88a75459-c19a-40f1-98bb-5d51bb514359", 43 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 43 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 43 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 43 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 43 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 43 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 43 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b0433d4e-d7df-4868-b831-a17f0a30af31", 43 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 43 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 43 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 43 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 43 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 43 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 43 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 43 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d8a49048-5ac1-4586-907d-baceecb14fed", 43 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 43 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 43 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "07b40a11-9941-4b21-a90a-605b11cdb487", 45 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "1093c6dc-48eb-486d-a866-b8f8b4bbf77b", 45 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "1093c6dc-48eb-486d-a866-b8f8b4bbf77b", 46 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "4635c38a-41ec-42e1-9f67-9f8b3a7e3d80", 46 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "4a99a16d-1096-44cb-96a3-053b56917bcf", 46 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "54c4d727-865e-438b-ab3f-339a689c5c19", 46 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "5a118590-c2ac-4064-aab1-abbad1cd6bce", 46 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "659ad282-2d5b-47a7-b0bf-c773676cb16b", 46 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "6d07c695-8bfc-4a06-86e5-74bb86b3fd79", 46 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "6ebf8e6e-516b-463f-b996-dd327746e711", 46 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "73f3662c-2459-4b3e-8cc4-fabf43d05236", 46 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "79c263d0-fea3-4908-bc1e-d298311067d2", 46 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "7c61be63-6a12-4301-bd3b-cc50861735f0", 46 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "86e02b21-25d7-4246-af4f-beac10cff1a6", 46 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "88a75459-c19a-40f1-98bb-5d51bb514359", 46 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 46 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 46 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 46 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 46 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 46 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 46 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b0433d4e-d7df-4868-b831-a17f0a30af31", 46 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 46 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 46 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 46 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 46 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 46 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 46 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 46 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d8a49048-5ac1-4586-907d-baceecb14fed", 46 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 46 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 46 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "73f3662c-2459-4b3e-8cc4-fabf43d05236", 62 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "79c263d0-fea3-4908-bc1e-d298311067d2", 62 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "7c61be63-6a12-4301-bd3b-cc50861735f0", 62 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "86e02b21-25d7-4246-af4f-beac10cff1a6", 62 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "88a75459-c19a-40f1-98bb-5d51bb514359", 62 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 62 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 62 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 62 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 62 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 62 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 62 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b0433d4e-d7df-4868-b831-a17f0a30af31", 62 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 62 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 62 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 62 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 62 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 62 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 62 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 62 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d8a49048-5ac1-4586-907d-baceecb14fed", 62 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 62 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 62 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "1093c6dc-48eb-486d-a866-b8f8b4bbf77b", 66 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "4635c38a-41ec-42e1-9f67-9f8b3a7e3d80", 66 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "07b40a11-9941-4b21-a90a-605b11cdb487", 67 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "1093c6dc-48eb-486d-a866-b8f8b4bbf77b", 67 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "5a118590-c2ac-4064-aab1-abbad1cd6bce", 71 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "659ad282-2d5b-47a7-b0bf-c773676cb16b", 71 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "6d07c695-8bfc-4a06-86e5-74bb86b3fd79", 71 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "6ebf8e6e-516b-463f-b996-dd327746e711", 71 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "73f3662c-2459-4b3e-8cc4-fabf43d05236", 71 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "79c263d0-fea3-4908-bc1e-d298311067d2", 71 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "7c61be63-6a12-4301-bd3b-cc50861735f0", 71 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "86e02b21-25d7-4246-af4f-beac10cff1a6", 71 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "88a75459-c19a-40f1-98bb-5d51bb514359", 71 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 71 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 71 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 71 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 71 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 71 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 71 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b0433d4e-d7df-4868-b831-a17f0a30af31", 71 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 71 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 71 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 71 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 71 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 71 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 71 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 71 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d8a49048-5ac1-4586-907d-baceecb14fed", 71 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 71 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 71 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "7c61be63-6a12-4301-bd3b-cc50861735f0", 75 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "86e02b21-25d7-4246-af4f-beac10cff1a6", 75 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "88a75459-c19a-40f1-98bb-5d51bb514359", 75 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 75 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 75 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 75 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 75 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 75 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 75 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b0433d4e-d7df-4868-b831-a17f0a30af31", 75 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 75 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 75 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 75 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 75 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 75 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 75 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 75 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d8a49048-5ac1-4586-907d-baceecb14fed", 75 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 75 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 75 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "1093c6dc-48eb-486d-a866-b8f8b4bbf77b", 76 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "4635c38a-41ec-42e1-9f67-9f8b3a7e3d80", 76 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "4a99a16d-1096-44cb-96a3-053b56917bcf", 76 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "54c4d727-865e-438b-ab3f-339a689c5c19", 76 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "5a118590-c2ac-4064-aab1-abbad1cd6bce", 76 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "659ad282-2d5b-47a7-b0bf-c773676cb16b", 76 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "6d07c695-8bfc-4a06-86e5-74bb86b3fd79", 76 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "6ebf8e6e-516b-463f-b996-dd327746e711", 76 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "73f3662c-2459-4b3e-8cc4-fabf43d05236", 76 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "79c263d0-fea3-4908-bc1e-d298311067d2", 76 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "7c61be63-6a12-4301-bd3b-cc50861735f0", 76 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "86e02b21-25d7-4246-af4f-beac10cff1a6", 76 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "88a75459-c19a-40f1-98bb-5d51bb514359", 76 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 76 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 76 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 76 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 76 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 76 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 76 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b0433d4e-d7df-4868-b831-a17f0a30af31", 76 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 76 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 76 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 76 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 76 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 76 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 76 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 76 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d8a49048-5ac1-4586-907d-baceecb14fed", 76 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 76 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 76 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "4a99a16d-1096-44cb-96a3-053b56917bcf", 78 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "54c4d727-865e-438b-ab3f-339a689c5c19", 78 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "5a118590-c2ac-4064-aab1-abbad1cd6bce", 78 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "659ad282-2d5b-47a7-b0bf-c773676cb16b", 78 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "6d07c695-8bfc-4a06-86e5-74bb86b3fd79", 78 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "6ebf8e6e-516b-463f-b996-dd327746e711", 78 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "73f3662c-2459-4b3e-8cc4-fabf43d05236", 78 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "79c263d0-fea3-4908-bc1e-d298311067d2", 78 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "7c61be63-6a12-4301-bd3b-cc50861735f0", 78 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "86e02b21-25d7-4246-af4f-beac10cff1a6", 78 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "88a75459-c19a-40f1-98bb-5d51bb514359", 78 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 78 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 78 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 78 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 78 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 78 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 78 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b0433d4e-d7df-4868-b831-a17f0a30af31", 78 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 78 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 78 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 78 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 78 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 78 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 78 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 78 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d8a49048-5ac1-4586-907d-baceecb14fed", 78 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 78 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 78 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "7c61be63-6a12-4301-bd3b-cc50861735f0", 85 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "86e02b21-25d7-4246-af4f-beac10cff1a6", 85 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "88a75459-c19a-40f1-98bb-5d51bb514359", 85 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 85 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 85 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 85 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 85 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 85 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 85 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b0433d4e-d7df-4868-b831-a17f0a30af31", 85 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 85 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 85 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 85 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 85 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 85 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 85 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 85 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d8a49048-5ac1-4586-907d-baceecb14fed", 85 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 85 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 85 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "1093c6dc-48eb-486d-a866-b8f8b4bbf77b", 88 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "4a99a16d-1096-44cb-96a3-053b56917bcf", 88 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "54c4d727-865e-438b-ab3f-339a689c5c19", 88 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "5a118590-c2ac-4064-aab1-abbad1cd6bce", 88 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "659ad282-2d5b-47a7-b0bf-c773676cb16b", 88 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "6d07c695-8bfc-4a06-86e5-74bb86b3fd79", 88 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "6ebf8e6e-516b-463f-b996-dd327746e711", 88 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "73f3662c-2459-4b3e-8cc4-fabf43d05236", 88 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "79c263d0-fea3-4908-bc1e-d298311067d2", 88 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "7c61be63-6a12-4301-bd3b-cc50861735f0", 88 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "86e02b21-25d7-4246-af4f-beac10cff1a6", 88 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "88a75459-c19a-40f1-98bb-5d51bb514359", 88 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 88 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 88 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 88 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 88 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 88 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 88 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b0433d4e-d7df-4868-b831-a17f0a30af31", 88 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 88 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 88 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 88 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 88 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 88 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 88 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 88 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d8a49048-5ac1-4586-907d-baceecb14fed", 88 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 88 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 88 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "07b40a11-9941-4b21-a90a-605b11cdb487", 90 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "4635c38a-41ec-42e1-9f67-9f8b3a7e3d80", 90 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "07b40a11-9941-4b21-a90a-605b11cdb487", 94 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "1093c6dc-48eb-486d-a866-b8f8b4bbf77b", 94 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "4a99a16d-1096-44cb-96a3-053b56917bcf", 94 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "54c4d727-865e-438b-ab3f-339a689c5c19", 94 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "5a118590-c2ac-4064-aab1-abbad1cd6bce", 94 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "659ad282-2d5b-47a7-b0bf-c773676cb16b", 94 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "6d07c695-8bfc-4a06-86e5-74bb86b3fd79", 94 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "6ebf8e6e-516b-463f-b996-dd327746e711", 94 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "73f3662c-2459-4b3e-8cc4-fabf43d05236", 94 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "79c263d0-fea3-4908-bc1e-d298311067d2", 94 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "7c61be63-6a12-4301-bd3b-cc50861735f0", 94 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "86e02b21-25d7-4246-af4f-beac10cff1a6", 94 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "88a75459-c19a-40f1-98bb-5d51bb514359", 94 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 94 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 94 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 94 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 94 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 94 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 94 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b0433d4e-d7df-4868-b831-a17f0a30af31", 94 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 94 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 94 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 94 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 94 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 94 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 94 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 94 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d8a49048-5ac1-4586-907d-baceecb14fed", 94 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 94 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 94 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "5a118590-c2ac-4064-aab1-abbad1cd6bce", 96 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "659ad282-2d5b-47a7-b0bf-c773676cb16b", 96 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "6d07c695-8bfc-4a06-86e5-74bb86b3fd79", 96 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "6ebf8e6e-516b-463f-b996-dd327746e711", 96 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "73f3662c-2459-4b3e-8cc4-fabf43d05236", 96 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "79c263d0-fea3-4908-bc1e-d298311067d2", 96 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "7c61be63-6a12-4301-bd3b-cc50861735f0", 96 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "86e02b21-25d7-4246-af4f-beac10cff1a6", 96 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "88a75459-c19a-40f1-98bb-5d51bb514359", 96 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 96 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 96 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 96 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 96 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 96 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 96 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b0433d4e-d7df-4868-b831-a17f0a30af31", 96 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 96 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 96 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 96 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 96 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 96 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 96 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 96 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d8a49048-5ac1-4586-907d-baceecb14fed", 96 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 96 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 96 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "73f3662c-2459-4b3e-8cc4-fabf43d05236", 98 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "79c263d0-fea3-4908-bc1e-d298311067d2", 98 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "7c61be63-6a12-4301-bd3b-cc50861735f0", 98 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "86e02b21-25d7-4246-af4f-beac10cff1a6", 98 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "88a75459-c19a-40f1-98bb-5d51bb514359", 98 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 98 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 98 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 98 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 98 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 98 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 98 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b0433d4e-d7df-4868-b831-a17f0a30af31", 98 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 98 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 98 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 98 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 98 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 98 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 98 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 98 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d8a49048-5ac1-4586-907d-baceecb14fed", 98 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 98 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 98 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "73f3662c-2459-4b3e-8cc4-fabf43d05236", 99 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "79c263d0-fea3-4908-bc1e-d298311067d2", 99 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "7c61be63-6a12-4301-bd3b-cc50861735f0", 99 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "86e02b21-25d7-4246-af4f-beac10cff1a6", 99 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "88a75459-c19a-40f1-98bb-5d51bb514359", 99 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 99 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 99 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 99 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 99 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 99 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 99 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b0433d4e-d7df-4868-b831-a17f0a30af31", 99 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 99 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 99 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 99 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 99 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 99 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 99 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 99 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d8a49048-5ac1-4586-907d-baceecb14fed", 99 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 99 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 99 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "5a118590-c2ac-4064-aab1-abbad1cd6bce", 102 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "659ad282-2d5b-47a7-b0bf-c773676cb16b", 102 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "6d07c695-8bfc-4a06-86e5-74bb86b3fd79", 102 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "6ebf8e6e-516b-463f-b996-dd327746e711", 102 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "73f3662c-2459-4b3e-8cc4-fabf43d05236", 102 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "79c263d0-fea3-4908-bc1e-d298311067d2", 102 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "7c61be63-6a12-4301-bd3b-cc50861735f0", 102 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "86e02b21-25d7-4246-af4f-beac10cff1a6", 102 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "88a75459-c19a-40f1-98bb-5d51bb514359", 102 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 102 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 102 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 102 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 102 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 102 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 102 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b0433d4e-d7df-4868-b831-a17f0a30af31", 102 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 102 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 102 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 102 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 102 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 102 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 102 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 102 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d8a49048-5ac1-4586-907d-baceecb14fed", 102 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 102 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 102 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "88a75459-c19a-40f1-98bb-5d51bb514359", 103 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 103 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 103 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 103 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 103 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 103 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 103 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b0433d4e-d7df-4868-b831-a17f0a30af31", 103 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 103 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 103 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 103 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 103 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 103 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 103 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 103 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d8a49048-5ac1-4586-907d-baceecb14fed", 103 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 103 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 103 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "5a118590-c2ac-4064-aab1-abbad1cd6bce", 106 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "659ad282-2d5b-47a7-b0bf-c773676cb16b", 106 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "6d07c695-8bfc-4a06-86e5-74bb86b3fd79", 106 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "6ebf8e6e-516b-463f-b996-dd327746e711", 106 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "73f3662c-2459-4b3e-8cc4-fabf43d05236", 106 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "79c263d0-fea3-4908-bc1e-d298311067d2", 106 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "7c61be63-6a12-4301-bd3b-cc50861735f0", 106 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "86e02b21-25d7-4246-af4f-beac10cff1a6", 106 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "88a75459-c19a-40f1-98bb-5d51bb514359", 106 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 106 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 106 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 106 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 106 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 106 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 106 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b0433d4e-d7df-4868-b831-a17f0a30af31", 106 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 106 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 106 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 106 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 106 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 106 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 106 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 106 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d8a49048-5ac1-4586-907d-baceecb14fed", 106 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 106 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 106 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "5a118590-c2ac-4064-aab1-abbad1cd6bce", 110 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "659ad282-2d5b-47a7-b0bf-c773676cb16b", 110 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "6d07c695-8bfc-4a06-86e5-74bb86b3fd79", 110 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "6ebf8e6e-516b-463f-b996-dd327746e711", 110 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "73f3662c-2459-4b3e-8cc4-fabf43d05236", 110 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "79c263d0-fea3-4908-bc1e-d298311067d2", 110 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "7c61be63-6a12-4301-bd3b-cc50861735f0", 110 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "86e02b21-25d7-4246-af4f-beac10cff1a6", 110 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "88a75459-c19a-40f1-98bb-5d51bb514359", 110 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 110 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 110 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 110 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 110 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 110 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 110 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b0433d4e-d7df-4868-b831-a17f0a30af31", 110 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 110 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 110 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 110 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 110 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 110 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 110 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 110 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d8a49048-5ac1-4586-907d-baceecb14fed", 110 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 110 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 110 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "73f3662c-2459-4b3e-8cc4-fabf43d05236", 112 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "79c263d0-fea3-4908-bc1e-d298311067d2", 112 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "7c61be63-6a12-4301-bd3b-cc50861735f0", 112 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "86e02b21-25d7-4246-af4f-beac10cff1a6", 112 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "88a75459-c19a-40f1-98bb-5d51bb514359", 112 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 112 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 112 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 112 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 112 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 112 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 112 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b0433d4e-d7df-4868-b831-a17f0a30af31", 112 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 112 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 112 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 112 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 112 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 112 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 112 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 112 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d8a49048-5ac1-4586-907d-baceecb14fed", 112 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 112 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 112 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "88a75459-c19a-40f1-98bb-5d51bb514359", 114 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 114 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 114 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 114 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 114 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 114 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 114 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b0433d4e-d7df-4868-b831-a17f0a30af31", 114 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 114 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 114 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 114 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 114 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 114 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 114 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 114 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d8a49048-5ac1-4586-907d-baceecb14fed", 114 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 114 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 114 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "88a75459-c19a-40f1-98bb-5d51bb514359", 115 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 115 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 115 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 115 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 115 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 115 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 115 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b0433d4e-d7df-4868-b831-a17f0a30af31", 115 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 115 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 115 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 115 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 115 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 115 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 115 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 115 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d8a49048-5ac1-4586-907d-baceecb14fed", 115 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 115 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 115 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "88a75459-c19a-40f1-98bb-5d51bb514359", 116 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 116 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 116 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 116 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 116 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 116 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 116 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b0433d4e-d7df-4868-b831-a17f0a30af31", 116 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 116 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 116 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 116 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 116 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 116 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 116 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 116 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d8a49048-5ac1-4586-907d-baceecb14fed", 116 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 116 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 116 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "88a75459-c19a-40f1-98bb-5d51bb514359", 120 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 120 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 120 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 120 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 120 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 120 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 120 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b0433d4e-d7df-4868-b831-a17f0a30af31", 120 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 120 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 120 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 120 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 120 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 120 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 120 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 120 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d8a49048-5ac1-4586-907d-baceecb14fed", 120 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 120 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 120 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "88a75459-c19a-40f1-98bb-5d51bb514359", 122 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 122 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 122 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 122 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 122 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 122 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 122 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b0433d4e-d7df-4868-b831-a17f0a30af31", 122 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 122 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 122 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 122 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 122 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 122 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 122 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 122 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d8a49048-5ac1-4586-907d-baceecb14fed", 122 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 122 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 122 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "88a75459-c19a-40f1-98bb-5d51bb514359", 123 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8b29eded-bdbc-470b-a183-5d82c3c49c97", 123 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "8cf89a46-bd09-4384-96c0-c1c654841bbb", 123 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "95d90f10-67fa-418b-a16d-1a63bfeb970f", 123 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "9ee7d2b0-3042-42f3-acca-cbfdbd8e188a", 123 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aaf47a62-e659-4d92-bab6-02a3dd812aeb", 123 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "aef15ff0-bdc1-4a4f-9a52-7e68f90a75d7", 123 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b0433d4e-d7df-4868-b831-a17f0a30af31", 123 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "b3d890e0-11b6-417a-b7f7-41473235e3fc", 123 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "ba413c8e-bd92-4b67-ad4e-bd7ac0236013", 123 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6317ffc-2f72-40b3-acee-9a85dab1cd66", 123 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "c6831bc6-00ef-4da1-9f61-df4c26101bbf", 123 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cb96d59c-bb9b-4128-b9d0-dc7c86f6419e", 123 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "cddea03f-b686-4937-93ea-bbcb3ffebc2c", 123 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d2c474eb-8f8c-4688-bcf3-3fb2447ac5ec", 123 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "d8a49048-5ac1-4586-907d-baceecb14fed", 123 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e4490d07-ba6d-467a-9dda-b9f9b0c3928e", 123 });

            migrationBuilder.DeleteData(
                table: "JoinedTopic",
                keyColumns: new[] { "ForumUserId", "TopicId" },
                keyValues: new object[] { "e9075bbf-849c-4133-a682-f1dc7467ddf6", 123 });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "085bf7a7-da17-40fe-bc8e-ffef207316ad");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "08836084-ec69-4663-bd5c-743575f34bdf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ff5865b-8ffd-459f-9e6c-5ff9f5a08e2e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2e651bfd-f58b-43ef-86d6-96b84e61f5f9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2ef871e3-650a-44f7-8a55-b4e7cb1508e1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30ddcbb2-38e9-4c32-8ec5-cd59d637b099");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32076358-f21f-4d99-bb1a-e8fd484611df");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3c7e3a85-f802-4c9c-8dc0-729c6391d500");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "427b763c-db92-4e38-af69-0eb636580aae");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48be314c-8033-44a7-a6fc-8d6c746e8648");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "59199cda-06ab-4ce3-b7f6-aabc0183ceaa");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5a58b850-ee28-4f9c-a2b5-815f5f65584e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "649dcef4-4445-42dc-864d-a3aaed9d3994");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "66a2e531-9d21-4ac8-affd-f8120e449384");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69978dbf-37d6-4a91-b09d-d3f1c641f2e9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6aee9516-0099-40c6-b2a0-3489cafb215e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6e5e1c32-a516-402f-b9bd-34889e9969bc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "752c49aa-0bee-4c45-a695-2a7da6274fb9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7bc576d0-c572-44c4-b25c-5df8bd4ed4cf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "83f228e0-2e70-41ea-8c9b-2bdbe6544796");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8794a217-bcbc-48e5-a582-934bff1cefec");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9cf71a8d-53f4-405c-bafa-226083eae8b6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b5b08e7f-c01b-4493-9490-8ef92b266929");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "caca7aa1-e368-4028-8e34-20297175515a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9376bdf-9c1d-4330-a6c1-2571bda649b1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ea0e0994-77d9-4be5-ba52-5ddeff82917c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed9503db-79f7-4133-9636-04835e89a05f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f79c2ca4-b5cb-4d3b-b998-5d43d3bf070e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f88cf83b-d76a-498e-b82a-b6486b49fcee");

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
    }
}
