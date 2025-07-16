using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace budget_request_app.WebApi.Migrations.MSSQL.LookupValue
{
    /// <inheritdoc />
    public partial class AddLookupValueSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "lookup",
                table: "LookupValues",
                columns: new[] { "Id", "Created", "CreatedBy", "Deleted", "DeletedBy", "IsActive", "LastModified", "LastModifiedBy", "LookupCategoryId", "Name", "TenantId" },
                values: new object[,]
                {
                    { new Guid("01ed4386-e34e-4231-8f54-a5d321e22e2e"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 8, 22, 550, DateTimeKind.Unspecified).AddTicks(5921), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 8, 22, 550, DateTimeKind.Unspecified).AddTicks(5921), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "2018 HOME (Fund 2731)", "root" },
                    { new Guid("0292e932-f7b8-4d83-90fd-6c974cb5fe68"), new DateTimeOffset(new DateTime(2025, 5, 26, 5, 59, 50, 571, DateTimeKind.Unspecified).AddTicks(6277), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 5, 59, 50, 571, DateTimeKind.Unspecified).AddTicks(6277), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("2fbf3c72-e26f-4db8-a5de-180bc862d79e"), "General - Municipal Court Operating Budget (Dept 670)", "root" },
                    { new Guid("029e7e7c-f42d-436a-9d5a-00cdfd7afa13"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 1, 20, 69, DateTimeKind.Unspecified).AddTicks(7978), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 1, 20, 69, DateTimeKind.Unspecified).AddTicks(7978), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("2fbf3c72-e26f-4db8-a5de-180bc862d79e"), "Utility - Sanitary Sewer Utility Funds (Fund 630)", "root" },
                    { new Guid("02aba20a-3f80-4754-a27e-afbfb911db86"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 17, 50, 469, DateTimeKind.Unspecified).AddTicks(2865), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 17, 50, 469, DateTimeKind.Unspecified).AddTicks(2865), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "REPLACEMENT HOUSING (Fund 2020)", "root" },
                    { new Guid("02bf93bf-7aff-4508-8961-3c23427e592d"), new DateTimeOffset(new DateTime(2025, 5, 26, 5, 49, 10, 599, DateTimeKind.Unspecified).AddTicks(847), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 5, 49, 10, 599, DateTimeKind.Unspecified).AddTicks(847), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("e0dd3254-0249-4f71-8c70-36063346ad72"), "TIF Bonds/Notes: 10 - Park Plaza", "root" },
                    { new Guid("0475db20-6ee5-4c72-af8a-70c5e3ac8877"), new DateTimeOffset(new DateTime(2025, 5, 26, 5, 49, 45, 400, DateTimeKind.Unspecified).AddTicks(9785), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 5, 49, 45, 400, DateTimeKind.Unspecified).AddTicks(9785), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("e0dd3254-0249-4f71-8c70-36063346ad72"), "TIF Bonds/Notes: 12 - Three Rivers Plaza", "root" },
                    { new Guid("05112108-8ed8-4525-b05b-67d0c5b27342"), new DateTimeOffset(new DateTime(2025, 5, 22, 17, 27, 3, 827, DateTimeKind.Unspecified).AddTicks(9510), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 17, 27, 3, 827, DateTimeKind.Unspecified).AddTicks(9510), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("c1353eb7-87ca-4cca-9d5c-f87bd4ae97c8"), "Sanitary Sewer Utility", "root" },
                    { new Guid("0574e943-adb4-42bc-b6e2-9553796dddc2"), new DateTimeOffset(new DateTime(2025, 2, 19, 7, 33, 11, 83, DateTimeKind.Unspecified).AddTicks(6986), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 19, 7, 34, 21, 629, DateTimeKind.Unspecified).AddTicks(8832), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("5baad37a-5ba1-4ec1-aaa3-992fa352a887"), "Partial", "root" },
                    { new Guid("05b8205f-abe9-47aa-a0eb-82532b75e145"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 7, 36, 593, DateTimeKind.Unspecified).AddTicks(3349), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 7, 36, 593, DateTimeKind.Unspecified).AddTicks(3349), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "2015 CDBG (Fund 2258)", "root" },
                    { new Guid("05c5e2f1-9987-487d-b92e-5ed2b06912e8"), new DateTimeOffset(new DateTime(2025, 5, 26, 5, 50, 9, 224, DateTimeKind.Unspecified).AddTicks(5454), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 5, 50, 9, 224, DateTimeKind.Unspecified).AddTicks(5454), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("e0dd3254-0249-4f71-8c70-36063346ad72"), "TIF Bonds/Notes: 14 - Gundersen Lutheran", "root" },
                    { new Guid("0647e23d-3216-454d-a065-2e00da633ac9"), new DateTimeOffset(new DateTime(2025, 2, 18, 1, 37, 6, 330, DateTimeKind.Unspecified).AddTicks(5950), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 18, 1, 37, 6, 330, DateTimeKind.Unspecified).AddTicks(5950), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("c1353eb7-87ca-4cca-9d5c-f87bd4ae97c8"), "Assessor's Office", "root" },
                    { new Guid("06a72058-6842-4728-b175-683aecdfe924"), new DateTimeOffset(new DateTime(2025, 2, 19, 7, 35, 4, 119, DateTimeKind.Unspecified).AddTicks(5350), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 19, 7, 35, 4, 119, DateTimeKind.Unspecified).AddTicks(5350), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("49921477-b361-4299-8fcb-5ec327ddf57c"), "No Curb", "root" },
                    { new Guid("06ec47a6-edcd-4919-a81f-6209b63ea418"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 16, 54, 76, DateTimeKind.Unspecified).AddTicks(6832), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 16, 54, 76, DateTimeKind.Unspecified).AddTicks(6832), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "POLICE GRANTS (Fund 526)", "root" },
                    { new Guid("06fb60fd-8754-4fa3-9a95-5fb2364d9eb3"), new DateTimeOffset(new DateTime(2025, 3, 19, 13, 27, 50, 431, DateTimeKind.Unspecified).AddTicks(4505), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 3, 19, 13, 27, 50, 431, DateTimeKind.Unspecified).AddTicks(4505), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("93985952-4e53-4b3d-a897-8bec835d8d42"), "Withdrawn by Department", "root" },
                    { new Guid("073fad94-7a7a-4df3-a7a6-a51aefa7c2c5"), new DateTimeOffset(new DateTime(2025, 2, 6, 6, 49, 50, 636, DateTimeKind.Unspecified).AddTicks(6667), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 6, 6, 49, 50, 636, DateTimeKind.Unspecified).AddTicks(6667), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("41e3334c-a1be-4c55-a21c-8540053b458e"), "Low", "root" },
                    { new Guid("07b3502a-690f-4d52-9e49-109666cd0c91"), new DateTimeOffset(new DateTime(2025, 5, 26, 5, 58, 40, 222, DateTimeKind.Unspecified).AddTicks(4190), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 5, 58, 40, 222, DateTimeKind.Unspecified).AddTicks(4190), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("2fbf3c72-e26f-4db8-a5de-180bc862d79e"), "General - Fire Operating Budget (Dept 370)", "root" },
                    { new Guid("07ded818-cbba-4adf-912f-2e192c2d653a"), new DateTimeOffset(new DateTime(2025, 5, 22, 17, 10, 52, 634, DateTimeKind.Unspecified).AddTicks(4572), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 17, 10, 52, 634, DateTimeKind.Unspecified).AddTicks(4572), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("95f8e0c2-b1dd-44b4-aa66-09f63efddc48"), "2025-Initial Changes", "root" },
                    { new Guid("08662cba-f8a1-447b-8418-18602cf49415"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 0, 10, 328, DateTimeKind.Unspecified).AddTicks(6242), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 0, 10, 328, DateTimeKind.Unspecified).AddTicks(6242), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("2fbf3c72-e26f-4db8-a5de-180bc862d79e"), "General - Police Operating Budget (Dept 850)", "root" },
                    { new Guid("08903189-9966-4262-b2c1-1e0fc249a91e"), new DateTimeOffset(new DateTime(2025, 5, 26, 5, 53, 17, 602, DateTimeKind.Unspecified).AddTicks(3629), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 5, 53, 17, 602, DateTimeKind.Unspecified).AddTicks(3629), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("2c4caa8d-544b-4393-82be-9a5b7c221117"), "TIF Bonds/Notes: 14 - Gundersen Lutheran", "root" },
                    { new Guid("08d4017f-136b-4830-848a-e4d10645c8c2"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 19, 39, 776, DateTimeKind.Unspecified).AddTicks(8779), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 19, 39, 776, DateTimeKind.Unspecified).AddTicks(8779), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "YOUTH ENRICHMENT ASSN (Fund 567)", "root" },
                    { new Guid("094da7d1-3458-4d39-b9d5-3f3035b4b8d0"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 3, 43, 159, DateTimeKind.Unspecified).AddTicks(8479), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 3, 43, 159, DateTimeKind.Unspecified).AddTicks(8479), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("1881c517-32e2-4c09-8bd2-09e2efe7dc61"), "La Crosse Center Room Tax", "root" },
                    { new Guid("09d09cd2-98d8-49b3-8b70-b130f0a8cc42"), new DateTimeOffset(new DateTime(2025, 5, 22, 1, 19, 42, 904, DateTimeKind.Unspecified).AddTicks(1570), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 1, 19, 42, 904, DateTimeKind.Unspecified).AddTicks(1570), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("cf4a4d66-6ced-43f2-959d-613c2fa2110d"), "Municipal Transit Utility Board", "root" },
                    { new Guid("0a8bbee9-f548-4229-83c9-78cebf603ba4"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 4, 32, 79, DateTimeKind.Unspecified).AddTicks(5592), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 4, 32, 79, DateTimeKind.Unspecified).AddTicks(5592), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("1881c517-32e2-4c09-8bd2-09e2efe7dc61"), "TID Increment: 11 - Gateway Redevelopment", "root" },
                    { new Guid("0cb142e3-e533-4ae3-83ef-ad5d8d6c4a7b"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 1, 13, 159, DateTimeKind.Unspecified).AddTicks(3590), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 1, 13, 159, DateTimeKind.Unspecified).AddTicks(3590), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("2fbf3c72-e26f-4db8-a5de-180bc862d79e"), "Utility - Sanitary Sewer Equipment Replacement Funds (Fund 632)", "root" },
                    { new Guid("0cd00c57-e497-45c9-8d19-3cdb5821fcd9"), new DateTimeOffset(new DateTime(2025, 2, 25, 2, 5, 20, 553, DateTimeKind.Unspecified).AddTicks(7100), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 25, 2, 5, 20, 553, DateTimeKind.Unspecified).AddTicks(7100), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("c72a2551-f9d5-4b61-bfe7-0cb74bd53de4"), "Detail 2", "root" },
                    { new Guid("0d3b1e88-d210-4199-9374-d649a49e2140"), new DateTimeOffset(new DateTime(2025, 5, 22, 17, 26, 48, 300, DateTimeKind.Unspecified).AddTicks(2805), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 17, 26, 48, 300, DateTimeKind.Unspecified).AddTicks(2805), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("c1353eb7-87ca-4cca-9d5c-f87bd4ae97c8"), "Refuse & Recycling", "root" },
                    { new Guid("0d59136b-b196-44a2-8e0b-ff82e24e7a6c"), new DateTimeOffset(new DateTime(2025, 2, 19, 7, 33, 1, 970, DateTimeKind.Unspecified).AddTicks(9048), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 19, 7, 34, 48, 706, DateTimeKind.Unspecified).AddTicks(9500), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("5baad37a-5ba1-4ec1-aaa3-992fa352a887"), "Miscellaneous", "root" },
                    { new Guid("0dadfa71-ef6c-4b5b-a785-af51ef365659"), new DateTimeOffset(new DateTime(2025, 2, 19, 7, 39, 37, 663, DateTimeKind.Unspecified).AddTicks(6872), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 19, 7, 39, 37, 663, DateTimeKind.Unspecified).AddTicks(6872), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("7b667e0f-6875-4180-b774-92136e36924b"), "Sanitary Sewers", "root" },
                    { new Guid("0e0e4e33-5203-4970-8db1-44fdca7e2e70"), new DateTimeOffset(new DateTime(2025, 2, 26, 12, 35, 38, 862, DateTimeKind.Unspecified).AddTicks(8298), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 26, 12, 35, 38, 862, DateTimeKind.Unspecified).AddTicks(8298), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("ea188a54-8da6-4c4c-bedf-89a079480790"), "Dan Trussoni", "root" },
                    { new Guid("0e2c8070-66d2-4255-adfa-0e99cc1bf89c"), new DateTimeOffset(new DateTime(2025, 2, 26, 12, 59, 43, 478, DateTimeKind.Unspecified).AddTicks(982), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 26, 12, 59, 43, 478, DateTimeKind.Unspecified).AddTicks(982), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("5516c30d-7a89-419e-be1b-0e5cb64f01ea"), "18 - River Point District", "root" },
                    { new Guid("0e6abb22-13da-452c-a8da-ee62bd0293db"), new DateTimeOffset(new DateTime(2025, 5, 21, 23, 7, 44, 6, DateTimeKind.Unspecified).AddTicks(3211), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 21, 23, 7, 44, 6, DateTimeKind.Unspecified).AddTicks(3211), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("18b298cd-91de-4b10-ae36-3bafd0ec02e8"), "Refuse and Recycling", "root" },
                    { new Guid("0eee03d6-77d0-44fa-9dd1-8777b5b2f1f9"), new DateTimeOffset(new DateTime(2025, 5, 22, 17, 28, 44, 461, DateTimeKind.Unspecified).AddTicks(2035), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 17, 29, 6, 2, DateTimeKind.Unspecified).AddTicks(1076), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("76fc224c-bc0a-4458-bf43-bfd8db3a0b83"), "Gallager, Matthew", "root" },
                    { new Guid("0eee7673-2a8f-4be2-b7ac-71c09eceeeb8"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 15, 25, 220, DateTimeKind.Unspecified).AddTicks(2630), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 15, 25, 220, DateTimeKind.Unspecified).AddTicks(2630), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "PASSENGER FACILITY CHG-R (Fund 2003)", "root" },
                    { new Guid("1094fb08-dfdf-4157-abd3-94c062effc13"), new DateTimeOffset(new DateTime(2025, 5, 22, 17, 24, 40, 171, DateTimeKind.Unspecified).AddTicks(8636), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 17, 24, 40, 171, DateTimeKind.Unspecified).AddTicks(8636), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("c1353eb7-87ca-4cca-9d5c-f87bd4ae97c8"), "Legal", "root" },
                    { new Guid("10b264e8-5f58-4055-9a02-ae0d763b9c63"), new DateTimeOffset(new DateTime(2025, 5, 26, 5, 52, 28, 714, DateTimeKind.Unspecified).AddTicks(3794), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 5, 52, 28, 714, DateTimeKind.Unspecified).AddTicks(3794), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("2c4caa8d-544b-4393-82be-9a5b7c221117"), "Revenue Bonds/Notes: Storm Water Utility", "root" },
                    { new Guid("1286cd4f-d154-4e33-b033-e323af39f0ec"), new DateTimeOffset(new DateTime(2025, 5, 26, 7, 1, 4, 316, DateTimeKind.Unspecified).AddTicks(3517), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 7, 1, 4, 316, DateTimeKind.Unspecified).AddTicks(3517), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"), "Streetscaping - Street Lighting", "root" },
                    { new Guid("12a47836-5007-4ea4-964a-66e5cb630c07"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 14, 47, 280, DateTimeKind.Unspecified).AddTicks(7981), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 14, 47, 280, DateTimeKind.Unspecified).AddTicks(7981), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "NEIGHBORHOOD STAB PROG GRT (Fund 564)", "root" },
                    { new Guid("12c94843-4f73-4381-8714-a49047ac586c"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 9, 45, 903, DateTimeKind.Unspecified).AddTicks(7452), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 9, 45, 903, DateTimeKind.Unspecified).AddTicks(7452), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "BUDGET CARRYOVER (Fund 299)", "root" },
                    { new Guid("13b37571-c157-40f0-9482-92083efc6884"), new DateTimeOffset(new DateTime(2025, 2, 6, 6, 50, 9, 380, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 17, 8, 46, 59, 63, DateTimeKind.Unspecified).AddTicks(2984), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("cf4a4d66-6ced-43f2-959d-613c2fa2110d"), "Board of Park Commissioners", "root" },
                    { new Guid("144cefe8-e8ae-4285-b0f7-19af4221215c"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 10, 19, 39, DateTimeKind.Unspecified).AddTicks(3992), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 10, 19, 39, DateTimeKind.Unspecified).AddTicks(3992), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "CITY WIDE HSNG RENEW PROGRAM (Fund 582)", "root" },
                    { new Guid("146af0b5-0594-47e2-b9e7-8fb4b35d355d"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 18, 31, 119, DateTimeKind.Unspecified).AddTicks(4100), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 18, 31, 119, DateTimeKind.Unspecified).AddTicks(4100), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "SPECIAL OLYMPICS (Fund 569)", "root" },
                    { new Guid("149ee3be-2113-40ee-b7e7-2ba8a2068192"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 12, 14, 499, DateTimeKind.Unspecified).AddTicks(2854), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 12, 14, 499, DateTimeKind.Unspecified).AddTicks(2854), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "GOLF COURSE (Fund 200)", "root" },
                    { new Guid("14aa9088-d3cc-4dbd-ab87-73d03f570cfc"), new DateTimeOffset(new DateTime(2025, 2, 28, 11, 12, 47, 544, DateTimeKind.Unspecified).AddTicks(7041), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 5, 54, 50, 9, DateTimeKind.Unspecified).AddTicks(2812), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("eb07f930-9e73-4cda-a9eb-98c4ec2a2afc"), "Federal", "root" },
                    { new Guid("14b4ed11-6fdd-4359-aa31-b58575c42e92"), new DateTimeOffset(new DateTime(2025, 2, 19, 13, 50, 22, 226, DateTimeKind.Unspecified).AddTicks(4370), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 19, 13, 50, 22, 226, DateTimeKind.Unspecified).AddTicks(4370), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("c1353eb7-87ca-4cca-9d5c-f87bd4ae97c8"), "Finance", "root" },
                    { new Guid("1555bc34-8ac4-49fc-bcec-64efc5b92db7"), new DateTimeOffset(new DateTime(2025, 5, 26, 5, 53, 35, 393, DateTimeKind.Unspecified).AddTicks(3472), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 5, 53, 35, 393, DateTimeKind.Unspecified).AddTicks(3472), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("2c4caa8d-544b-4393-82be-9a5b7c221117"), "TIF Bonds/Notes: 16 - LIPCO/Trane Plant 6", "root" },
                    { new Guid("1690d44c-fe68-4d3b-97e8-5f2c7bb5dddb"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 2, 7, 309, DateTimeKind.Unspecified).AddTicks(6594), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 2, 7, 309, DateTimeKind.Unspecified).AddTicks(6594), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("2fbf3c72-e26f-4db8-a5de-180bc862d79e"), "Utilty - Storm Water Utility Funds (Fund 650)", "root" },
                    { new Guid("16c1abde-1120-4a6e-bbe6-8399f02e32cf"), new DateTimeOffset(new DateTime(2025, 5, 26, 2, 55, 59, 445, DateTimeKind.Unspecified).AddTicks(2603), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 2, 55, 59, 445, DateTimeKind.Unspecified).AddTicks(2603), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("00316b5b-16ab-480a-8974-50f0f6dd97fe"), "Plan and Dev - Plans and Studies", "root" },
                    { new Guid("16dab5ee-5b4d-4277-a11d-419b0e746442"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 12, 41, 253, DateTimeKind.Unspecified).AddTicks(3689), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 12, 41, 253, DateTimeKind.Unspecified).AddTicks(3689), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "HAMMES PROPERTY (Fund 241)", "root" },
                    { new Guid("16f40604-4809-48ef-a2a3-c2ace7f55c0d"), new DateTimeOffset(new DateTime(2025, 5, 26, 7, 0, 11, 872, DateTimeKind.Unspecified).AddTicks(3523), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 7, 0, 11, 872, DateTimeKind.Unspecified).AddTicks(3523), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"), "Storm Sewer/Stormwater - Other", "root" },
                    { new Guid("172fa433-d257-4d55-ba44-05794ecf6e29"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 59, 53, 744, DateTimeKind.Unspecified).AddTicks(6868), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 59, 53, 744, DateTimeKind.Unspecified).AddTicks(6868), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"), "Sanitary Sewer/Wastewater - Sanitary Sewer Mains", "root" },
                    { new Guid("1737baba-3402-4d11-83bd-b3e38ea20649"), new DateTimeOffset(new DateTime(2025, 5, 26, 2, 51, 6, 907, DateTimeKind.Unspecified).AddTicks(808), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 2, 51, 6, 907, DateTimeKind.Unspecified).AddTicks(808), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("00316b5b-16ab-480a-8974-50f0f6dd97fe"), "Flood Control - Docks and Levees", "root" },
                    { new Guid("175d84dd-ecdc-4daa-8d08-230b9edd329c"), new DateTimeOffset(new DateTime(2025, 5, 21, 22, 58, 14, 857, DateTimeKind.Unspecified).AddTicks(2699), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 21, 22, 58, 14, 857, DateTimeKind.Unspecified).AddTicks(2699), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("18b298cd-91de-4b10-ae36-3bafd0ec02e8"), "Human Resources", "root" },
                    { new Guid("17ad5030-24f1-4507-aeba-7c3ebc4201f5"), new DateTimeOffset(new DateTime(2025, 5, 21, 5, 36, 13, 55, DateTimeKind.Unspecified).AddTicks(4918), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 21, 5, 36, 13, 55, DateTimeKind.Unspecified).AddTicks(4918), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("b44e86cb-1388-4c3f-ae4c-94d3df4f662b"), "General - Employee Benefit Operating Budget (Dept 421)", "root" },
                    { new Guid("180b5930-9bfe-4bdf-b00a-574066ca164e"), new DateTimeOffset(new DateTime(2025, 2, 19, 7, 37, 4, 822, DateTimeKind.Unspecified).AddTicks(9976), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 19, 7, 37, 4, 822, DateTimeKind.Unspecified).AddTicks(9976), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("c641a57f-5f5e-4458-b940-4c9e562ff653"), "Bike Safety", "root" },
                    { new Guid("18af88a7-a294-432c-bd84-54db919bf5c3"), new DateTimeOffset(new DateTime(2025, 5, 22, 17, 51, 35, 499, DateTimeKind.Unspecified).AddTicks(5425), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 17, 51, 35, 499, DateTimeKind.Unspecified).AddTicks(5425), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"), "Public Buildings - City Hall", "root" },
                    { new Guid("1967eb57-4c09-4684-bb1d-7b9a0b303455"), new DateTimeOffset(new DateTime(2025, 5, 21, 5, 35, 9, 752, DateTimeKind.Unspecified).AddTicks(58), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 21, 5, 35, 9, 752, DateTimeKind.Unspecified).AddTicks(58), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("b44e86cb-1388-4c3f-ae4c-94d3df4f662b"), "Enterprise - Passenger Facility Charges", "root" },
                    { new Guid("1ab1207b-0963-49e0-ae74-5806b617e67a"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 56, 38, 829, DateTimeKind.Unspecified).AddTicks(7737), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 56, 38, 829, DateTimeKind.Unspecified).AddTicks(7737), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"), "Equipment and Tools", "root" },
                    { new Guid("1b71e6fb-4645-484e-b7d1-b1b6563a2256"), new DateTimeOffset(new DateTime(2025, 2, 6, 6, 50, 4, 203, DateTimeKind.Unspecified).AddTicks(3333), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 17, 0, 15, 58, 331, DateTimeKind.Unspecified).AddTicks(2222), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("18b298cd-91de-4b10-ae36-3bafd0ec02e8"), "Airport", "root" },
                    { new Guid("1b9c7555-d145-4020-bb54-0d87410ed50f"), new DateTimeOffset(new DateTime(2025, 5, 26, 2, 56, 43, 125, DateTimeKind.Unspecified).AddTicks(8568), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 2, 56, 43, 125, DateTimeKind.Unspecified).AddTicks(8568), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("00316b5b-16ab-480a-8974-50f0f6dd97fe"), "Public Safety - Municipal Court", "root" },
                    { new Guid("1bd665d0-0430-45ff-9459-cf0f02080850"), new DateTimeOffset(new DateTime(2025, 5, 21, 22, 57, 2, 731, DateTimeKind.Unspecified).AddTicks(1740), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 21, 22, 57, 2, 731, DateTimeKind.Unspecified).AddTicks(1740), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("18b298cd-91de-4b10-ae36-3bafd0ec02e8"), "City Clerk", "root" },
                    { new Guid("1c767135-83af-4f9b-8b08-a07105a55dd8"), new DateTimeOffset(new DateTime(2025, 5, 26, 2, 56, 19, 875, DateTimeKind.Unspecified).AddTicks(8357), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 2, 56, 19, 875, DateTimeKind.Unspecified).AddTicks(8357), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("00316b5b-16ab-480a-8974-50f0f6dd97fe"), "Public Safety - Fire", "root" },
                    { new Guid("1c7693c7-5a87-446a-91bc-961549a51e31"), new DateTimeOffset(new DateTime(2025, 5, 22, 1, 5, 46, 858, DateTimeKind.Unspecified).AddTicks(5664), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 1, 5, 46, 858, DateTimeKind.Unspecified).AddTicks(5664), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("b4fe9e53-b0cc-4a8b-89d7-712bfc97ac24"), "New Operation", "root" },
                    { new Guid("1c83e967-8d79-49b3-ad80-55b5ece6b17a"), new DateTimeOffset(new DateTime(2025, 5, 26, 2, 46, 51, 314, DateTimeKind.Unspecified).AddTicks(3207), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 2, 46, 51, 314, DateTimeKind.Unspecified).AddTicks(3207), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("3c78d7af-5305-4138-9038-be7425fcecb2"), "Judiciary & Administration Committee", "root" },
                    { new Guid("1c98551c-70d4-4e0b-b82a-5b0449485878"), new DateTimeOffset(new DateTime(2025, 5, 21, 22, 57, 23, 987, DateTimeKind.Unspecified).AddTicks(5799), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 21, 22, 57, 23, 987, DateTimeKind.Unspecified).AddTicks(5799), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("18b298cd-91de-4b10-ae36-3bafd0ec02e8"), "Community Development and Housing", "root" },
                    { new Guid("1caf9421-f1cc-4bf7-85ab-d55eb249db38"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 57, 4, 216, DateTimeKind.Unspecified).AddTicks(2661), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 57, 4, 216, DateTimeKind.Unspecified).AddTicks(2661), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"), "Harbors, Docks and Waterways", "root" },
                    { new Guid("1d08fb75-b304-465a-943c-1b481e7dedeb"), new DateTimeOffset(new DateTime(2025, 5, 22, 1, 19, 28, 585, DateTimeKind.Unspecified).AddTicks(5050), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 1, 19, 28, 585, DateTimeKind.Unspecified).AddTicks(5050), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("cf4a4d66-6ced-43f2-959d-613c2fa2110d"), "La Crosse Center Board", "root" },
                    { new Guid("1d1ab47f-02e8-4d04-a4d2-eea013254ac0"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 7, 2, 248, DateTimeKind.Unspecified).AddTicks(1547), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 7, 2, 248, DateTimeKind.Unspecified).AddTicks(1547), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "2011 CDBG (Fund 2254)", "root" },
                    { new Guid("1d468275-63e0-462c-b0ef-7a084cb927ba"), new DateTimeOffset(new DateTime(2025, 2, 19, 7, 2, 35, 216, DateTimeKind.Unspecified).AddTicks(4864), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 54, 49, 349, DateTimeKind.Unspecified).AddTicks(4049), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"), "Airport - Other Buildings", "root" },
                    { new Guid("1e5f6332-e41d-44ed-8bf2-cd10c919cc3b"), new DateTimeOffset(new DateTime(2025, 5, 21, 5, 34, 24, 566, DateTimeKind.Unspecified).AddTicks(9962), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 21, 5, 34, 24, 566, DateTimeKind.Unspecified).AddTicks(9962), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("f0770a04-79f8-488e-b674-d1dde98e8079"), "Other", "root" },
                    { new Guid("1fb8c160-e938-46e7-983d-36ef39c72bbf"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 15, 59, 537, DateTimeKind.Unspecified).AddTicks(2305), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 15, 59, 537, DateTimeKind.Unspecified).AddTicks(2305), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "POLICE CHAPLAIN PROGRAM (Fund 535)", "root" },
                    { new Guid("1fed6bee-da44-4e33-a1b4-823ec3a67827"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 8, 30, 240, DateTimeKind.Unspecified).AddTicks(9221), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 8, 30, 240, DateTimeKind.Unspecified).AddTicks(9221), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "ABANDONED VEHICLE AND TOWING (Fund 542)", "root" },
                    { new Guid("201e1eff-5acf-47f3-a4fa-e2d551f15d86"), new DateTimeOffset(new DateTime(2025, 2, 6, 6, 49, 50, 643, DateTimeKind.Unspecified).AddTicks(3333), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 12, 13, 8, 42, 814, DateTimeKind.Unspecified).AddTicks(9740), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("41e3334c-a1be-4c55-a21c-8540053b458e"), "Medium", "root" },
                    { new Guid("2020161c-89d1-4f9f-8bc5-2a7193494b88"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 4, 25, 556, DateTimeKind.Unspecified).AddTicks(4422), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 4, 25, 556, DateTimeKind.Unspecified).AddTicks(4422), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("1881c517-32e2-4c09-8bd2-09e2efe7dc61"), "TID Increment: 10 - Park Plaza", "root" },
                    { new Guid("20244247-ca45-48fe-b2d5-b987a3563d3d"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 14, 19, 147, DateTimeKind.Unspecified).AddTicks(4306), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 14, 19, 147, DateTimeKind.Unspecified).AddTicks(4306), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "MISCELLANEOUS CONTRIBUTIONS (Fund 288)", "root" },
                    { new Guid("20c22846-e389-4596-b140-6b99927eaf52"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 15, 42, 528, DateTimeKind.Unspecified).AddTicks(7080), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 15, 42, 528, DateTimeKind.Unspecified).AddTicks(7080), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "PLANNING GRANTS (Fund 504)", "root" },
                    { new Guid("2230ad55-b7ef-463a-bd3f-3ada90798e77"), new DateTimeOffset(new DateTime(2025, 2, 14, 13, 31, 44, 103, DateTimeKind.Unspecified).AddTicks(2319), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 14, 13, 31, 44, 103, DateTimeKind.Unspecified).AddTicks(2319), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("910fb5e3-80a0-4a46-b616-8cb94f56e86f"), "Vehicles and Attachments", "root" },
                    { new Guid("224f1993-257d-47ca-b3d6-be8a016f1df0"), new DateTimeOffset(new DateTime(2025, 2, 10, 5, 33, 32, 440, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 27, 1, 26, 27, 655, DateTimeKind.Unspecified).AddTicks(5450), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("08b0863c-ba0c-48f8-8702-06bbe6578170"), "Gallager, Matthew", "root" },
                    { new Guid("229bae8d-4e97-427f-9625-c11d86ed25f7"), new DateTimeOffset(new DateTime(2025, 5, 26, 5, 52, 19, 961, DateTimeKind.Unspecified).AddTicks(1787), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 5, 52, 19, 961, DateTimeKind.Unspecified).AddTicks(1787), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("2c4caa8d-544b-4393-82be-9a5b7c221117"), "Revenue Bonds/Notes: Sanitary Sewer Utility", "root" },
                    { new Guid("22bc6809-68c9-4493-b4c9-1a271106475e"), new DateTimeOffset(new DateTime(2025, 5, 26, 2, 48, 36, 580, DateTimeKind.Unspecified).AddTicks(9251), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 2, 48, 36, 580, DateTimeKind.Unspecified).AddTicks(9251), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("7590f78d-2412-47a6-81b3-4c3acc462b14"), "Rejected by Finance", "root" },
                    { new Guid("2502aad0-ce2c-48ca-b068-f0cd19182739"), new DateTimeOffset(new DateTime(2025, 5, 22, 6, 52, 16, 751, DateTimeKind.Unspecified).AddTicks(3509), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 6, 52, 16, 751, DateTimeKind.Unspecified).AddTicks(3509), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("b44e86cb-1388-4c3f-ae4c-94d3df4f662b"), "General - General Expense Operating Budget (Dept 420)", "root" },
                    { new Guid("2600c3d0-e7e8-432b-8765-f360f3b639f5"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 14, 41, 948, DateTimeKind.Unspecified).AddTicks(1399), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 14, 41, 948, DateTimeKind.Unspecified).AddTicks(1399), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "NAVAL RESERVE (Fund 291)", "root" },
                    { new Guid("2885db15-fde1-405b-aeab-0a266fb5dc7b"), new DateTimeOffset(new DateTime(2025, 5, 26, 7, 1, 43, 862, DateTimeKind.Unspecified).AddTicks(9888), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 7, 1, 43, 862, DateTimeKind.Unspecified).AddTicks(9888), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"), "Water - Wells, Pumphouses and Reservoir", "root" },
                    { new Guid("2887f6fa-b983-44c7-a651-e35f9b58240b"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 7, 43, 729, DateTimeKind.Unspecified).AddTicks(3611), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 7, 43, 729, DateTimeKind.Unspecified).AddTicks(3611), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "2015 HOME (Fund 2728)", "root" },
                    { new Guid("28bf110a-f8b7-46f4-a1fb-19e8db1077e0"), new DateTimeOffset(new DateTime(2025, 5, 26, 2, 48, 46, 764, DateTimeKind.Unspecified).AddTicks(7274), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 2, 48, 46, 764, DateTimeKind.Unspecified).AddTicks(7274), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("7590f78d-2412-47a6-81b3-4c3acc462b14"), "Approved by Finance", "root" },
                    { new Guid("28ff616c-19ac-47b3-9183-641502ef7cf2"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 18, 17, 843, DateTimeKind.Unspecified).AddTicks(5064), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 18, 17, 843, DateTimeKind.Unspecified).AddTicks(5064), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "SIGNS (NO PARKNG PRIVATE WALK) (Fund 560)", "root" },
                    { new Guid("29062e38-2192-448a-a947-ecdbe4e91d29"), new DateTimeOffset(new DateTime(2025, 2, 19, 7, 38, 55, 395, DateTimeKind.Unspecified).AddTicks(1654), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 19, 7, 38, 55, 395, DateTimeKind.Unspecified).AddTicks(1654), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("bd4dd1db-1f4d-455c-846b-4e0b620dfb1d"), "Decorative Paving/Makers", "root" },
                    { new Guid("29251245-a159-4a9d-a75a-04aec242699c"), new DateTimeOffset(new DateTime(2025, 5, 22, 17, 47, 51, 11, DateTimeKind.Unspecified).AddTicks(4680), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 17, 47, 51, 11, DateTimeKind.Unspecified).AddTicks(4680), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("db09f0d8-49fe-41af-99a3-01c0d498d8de"), "Land Acquisition", "root" },
                    { new Guid("2936f712-eebd-4453-aca4-d857e1358196"), new DateTimeOffset(new DateTime(2025, 2, 19, 6, 50, 32, 321, DateTimeKind.Unspecified).AddTicks(7444), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 19, 6, 50, 32, 321, DateTimeKind.Unspecified).AddTicks(7444), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("e2bc2f40-b296-48b6-bfaa-faf91bd5539e"), "7", "root" },
                    { new Guid("2a7adaab-e175-454b-83be-f16a29a19445"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 14, 36, 504, DateTimeKind.Unspecified).AddTicks(5960), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 14, 36, 504, DateTimeKind.Unspecified).AddTicks(5960), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "MYRICK PARK IMPROVEMENT (Fund 207)", "root" },
                    { new Guid("2a9eb309-e354-4f96-a12e-af6fd0fb265b"), new DateTimeOffset(new DateTime(2025, 5, 22, 17, 14, 56, 612, DateTimeKind.Unspecified).AddTicks(6436), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 17, 14, 56, 612, DateTimeKind.Unspecified).AddTicks(6436), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("0f4e03dc-0ead-41ad-93a9-26b0b6a0af3a"), "Funding Sources Changed", "root" },
                    { new Guid("2aba7026-d9b6-443b-b77e-f1548a14b8be"), new DateTimeOffset(new DateTime(2025, 5, 26, 7, 0, 18, 35, DateTimeKind.Unspecified).AddTicks(3585), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 7, 0, 18, 35, DateTimeKind.Unspecified).AddTicks(3585), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"), "Storm Sewer/Stormwater - Storm Sewer Mains", "root" },
                    { new Guid("2ad079ec-3fbe-4c53-b950-c1801f03ec98"), new DateTimeOffset(new DateTime(2025, 2, 19, 7, 36, 57, 49, DateTimeKind.Unspecified).AddTicks(7778), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 19, 7, 36, 57, 49, DateTimeKind.Unspecified).AddTicks(7778), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("c641a57f-5f5e-4458-b940-4c9e562ff653"), "Traffic Safety", "root" },
                    { new Guid("2b729536-38c1-4750-af80-560440b09017"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 18, 36, 847, DateTimeKind.Unspecified).AddTicks(4752), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 18, 36, 847, DateTimeKind.Unspecified).AddTicks(4752), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "SPECIAL RECREATION (Fund 568)", "root" },
                    { new Guid("2c3c8380-2591-4c59-96c7-3b82d2ae145b"), new DateTimeOffset(new DateTime(2025, 5, 22, 6, 48, 57, 668, DateTimeKind.Unspecified).AddTicks(6401), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 6, 48, 57, 668, DateTimeKind.Unspecified).AddTicks(6401), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("b44e86cb-1388-4c3f-ae4c-94d3df4f662b"), "General - Room Tax Operating Budget (Dept 791)", "root" },
                    { new Guid("2c77a980-7eb3-4a17-a92e-629ad4c2302a"), new DateTimeOffset(new DateTime(2025, 2, 19, 7, 35, 9, 24, DateTimeKind.Unspecified).AddTicks(7821), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 19, 7, 35, 9, 24, DateTimeKind.Unspecified).AddTicks(7821), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("49921477-b361-4299-8fcb-5ec327ddf57c"), "Good", "root" },
                    { new Guid("2ca367ac-cc3a-4133-b9c2-51c6bb6069ef"), new DateTimeOffset(new DateTime(2025, 2, 19, 7, 39, 14, 843, DateTimeKind.Unspecified).AddTicks(7409), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 19, 7, 39, 14, 843, DateTimeKind.Unspecified).AddTicks(7409), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("7b667e0f-6875-4180-b774-92136e36924b"), "Water Mains", "root" },
                    { new Guid("2d2e4195-d283-4cdd-8eb3-54db98aefd35"), new DateTimeOffset(new DateTime(2025, 5, 26, 2, 57, 44, 661, DateTimeKind.Unspecified).AddTicks(4157), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 2, 57, 44, 661, DateTimeKind.Unspecified).AddTicks(4157), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("00316b5b-16ab-480a-8974-50f0f6dd97fe"), "Trans and Utils - Utilities", "root" },
                    { new Guid("2d4674f6-b2fd-4515-a0b5-1b8f89b5895c"), new DateTimeOffset(new DateTime(2025, 3, 19, 5, 33, 39, 870, DateTimeKind.Unspecified).AddTicks(876), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 27, 1, 26, 57, 99, DateTimeKind.Unspecified).AddTicks(7428), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("08b0863c-ba0c-48f8-8702-06bbe6578170"), "Greschner, Jacky", "root" },
                    { new Guid("2d8b9626-1eec-4ad3-8770-85030d52a93c"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 9, 51, 796, DateTimeKind.Unspecified).AddTicks(1704), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 9, 51, 796, DateTimeKind.Unspecified).AddTicks(1704), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "CAMERON PARK CONSTRUCTION (Fund 247)", "root" },
                    { new Guid("2e0cb8ec-056c-4a69-b8a6-878854cfd678"), new DateTimeOffset(new DateTime(2025, 2, 28, 1, 43, 19, 937, DateTimeKind.Unspecified).AddTicks(3370), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 28, 1, 43, 19, 937, DateTimeKind.Unspecified).AddTicks(3370), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("578eae04-ecae-421b-b6e3-722eaee8fc0e"), "Test Funding Type", "root" },
                    { new Guid("2e36ce16-a881-4c22-8333-356629a7f8d4"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 17, 8, 915, DateTimeKind.Unspecified).AddTicks(2879), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 17, 8, 915, DateTimeKind.Unspecified).AddTicks(2879), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "POLICE RESERVE PROGRAM (Fund 545)", "root" },
                    { new Guid("2f169734-910b-4bc4-a1bc-d63cd85faf24"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 5, 24, 675, DateTimeKind.Unspecified).AddTicks(5157), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 5, 24, 675, DateTimeKind.Unspecified).AddTicks(5157), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("1881c517-32e2-4c09-8bd2-09e2efe7dc61"), "TID Increment: 18 - River Point District", "root" },
                    { new Guid("2f7cee83-1d27-4c44-8303-1bbbfaf51872"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 15, 19, 224, DateTimeKind.Unspecified).AddTicks(7260), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 15, 19, 224, DateTimeKind.Unspecified).AddTicks(7260), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "PASSENGER FACILITY CHARGE (Fund 2002)", "root" },
                    { new Guid("3166b9f7-d9bb-45c9-805f-7978bb06011c"), new DateTimeOffset(new DateTime(2025, 2, 6, 6, 50, 24, 676, DateTimeKind.Unspecified).AddTicks(6667), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 6, 6, 50, 24, 676, DateTimeKind.Unspecified).AddTicks(6667), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("f0770a04-79f8-488e-b674-d1dde98e8079"), "Federal", "root" },
                    { new Guid("320a4663-595d-486e-a710-9c2d7965491e"), new DateTimeOffset(new DateTime(2025, 2, 13, 6, 24, 42, 874, DateTimeKind.Unspecified).AddTicks(928), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 13, 6, 24, 42, 874, DateTimeKind.Unspecified).AddTicks(928), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("761adb91-60e3-43bc-bbdf-bdf1b586d4f1"), "Project", "root" },
                    { new Guid("3320de24-723f-4f16-881a-333d2a4ddac0"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 15, 31, 52, DateTimeKind.Unspecified).AddTicks(2608), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 15, 31, 52, DateTimeKind.Unspecified).AddTicks(2608), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "PETTIBONE BATHHOUSE MURAL (Fund 552)", "root" },
                    { new Guid("332dc9b4-695f-4ad3-ac2a-16bd03e27122"), new DateTimeOffset(new DateTime(2025, 5, 26, 2, 45, 2, 706, DateTimeKind.Unspecified).AddTicks(9238), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 2, 45, 2, 706, DateTimeKind.Unspecified).AddTicks(9238), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("3c78d7af-5305-4138-9038-be7425fcecb2"), "Aviation Board", "root" },
                    { new Guid("356726e6-1968-494c-91ff-ad3d67ab9cbc"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 12, 3, 703, DateTimeKind.Unspecified).AddTicks(5398), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 12, 3, 703, DateTimeKind.Unspecified).AddTicks(5398), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "FLOODPLAIN HSNG REPLACEMENT (Fund 584)", "root" },
                    { new Guid("3575e95f-253b-4cf4-a86b-2f529b880bf2"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 14, 54, 386, DateTimeKind.Unspecified).AddTicks(2939), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 14, 54, 386, DateTimeKind.Unspecified).AddTicks(2939), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "NEIGHBR RENOVATION RESTORATION (Fund 298)", "root" },
                    { new Guid("35f8ffdd-5920-4143-a3c6-f9c469cf1244"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 7, 8, 288, DateTimeKind.Unspecified).AddTicks(5274), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 7, 8, 288, DateTimeKind.Unspecified).AddTicks(5274), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "2012 CDBG (Fund 2255)", "root" },
                    { new Guid("36093421-1d0d-48e3-84be-337bede2a5b2"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 13, 56, 916, DateTimeKind.Unspecified).AddTicks(3214), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 13, 56, 916, DateTimeKind.Unspecified).AddTicks(3214), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "LIBRARY SANDY GORDON (Fund 226)", "root" },
                    { new Guid("363e8dea-53fd-43e7-b502-64080bb1386c"), new DateTimeOffset(new DateTime(2025, 5, 26, 5, 53, 10, 311, DateTimeKind.Unspecified).AddTicks(1452), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 5, 53, 10, 311, DateTimeKind.Unspecified).AddTicks(1452), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("2c4caa8d-544b-4393-82be-9a5b7c221117"), "TIF Bonds/Notes: 13 - Kwik Trip", "root" },
                    { new Guid("3656e5f9-4721-4a64-b031-94866a724005"), new DateTimeOffset(new DateTime(2025, 2, 6, 6, 50, 19, 833, DateTimeKind.Unspecified).AddTicks(3333), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 21, 5, 35, 1, 471, DateTimeKind.Unspecified).AddTicks(1371), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("b44e86cb-1388-4c3f-ae4c-94d3df4f662b"), "Enterprise - La Crosse Center Operating Funds (Fund 101)", "root" },
                    { new Guid("3699325f-4d84-4e96-936b-e83312047940"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 11, 6, 847, DateTimeKind.Unspecified).AddTicks(2305), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 11, 6, 847, DateTimeKind.Unspecified).AddTicks(2305), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "FIRE DEFIBRILLATORS (Fund 220)", "root" },
                    { new Guid("379e4563-c28f-452f-9067-07f1a100e022"), new DateTimeOffset(new DateTime(2025, 3, 27, 5, 37, 47, 94, DateTimeKind.Unspecified).AddTicks(5194), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 3, 27, 5, 37, 47, 94, DateTimeKind.Unspecified).AddTicks(5194), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("76854444-444f-4524-8a61-9fcb24e1c9b1"), "Project", "root" },
                    { new Guid("37cf055b-99d9-46bc-978d-80e022a9fb3d"), new DateTimeOffset(new DateTime(2025, 5, 26, 2, 56, 50, 858, DateTimeKind.Unspecified).AddTicks(7594), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 2, 56, 50, 858, DateTimeKind.Unspecified).AddTicks(7594), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("00316b5b-16ab-480a-8974-50f0f6dd97fe"), "Trans and Utils - Alleys", "root" },
                    { new Guid("3a6c2698-96fd-4db5-9a6c-9be55b00223a"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 16, 4, 819, DateTimeKind.Unspecified).AddTicks(3077), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 16, 4, 819, DateTimeKind.Unspecified).AddTicks(3077), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "POLICE CRIME STOPPERS (Fund 521)", "root" },
                    { new Guid("3b41552d-cb8e-4e2d-bf50-6e68ba203d53"), new DateTimeOffset(new DateTime(2025, 5, 26, 5, 57, 43, 725, DateTimeKind.Unspecified).AddTicks(8488), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 5, 57, 43, 725, DateTimeKind.Unspecified).AddTicks(8488), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("2fbf3c72-e26f-4db8-a5de-180bc862d79e"), "General - Assessor Operating Budget (Dept 130)", "root" },
                    { new Guid("3b6710d1-b5c4-41ed-b70a-49797a089f56"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 17, 44, 687, DateTimeKind.Unspecified).AddTicks(4726), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 17, 44, 687, DateTimeKind.Unspecified).AddTicks(4726), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "RENEW (Fund 549)", "root" },
                    { new Guid("3b6b8952-6c60-492d-b1b8-d8873df684b4"), new DateTimeOffset(new DateTime(2025, 5, 21, 22, 58, 46, 833, DateTimeKind.Unspecified).AddTicks(7602), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 21, 22, 58, 46, 833, DateTimeKind.Unspecified).AddTicks(7602), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("18b298cd-91de-4b10-ae36-3bafd0ec02e8"), "Legal", "root" },
                    { new Guid("3c01a9dd-2f80-4039-92e4-f1512dfcc4e5"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 13, 50, 991, DateTimeKind.Unspecified).AddTicks(4405), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 13, 50, 991, DateTimeKind.Unspecified).AddTicks(4405), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "LIBRARY GERTRUDE GORDON (Fund 227)", "root" },
                    { new Guid("3c9d382f-6848-4117-9411-d0be3b4800d2"), new DateTimeOffset(new DateTime(2025, 5, 26, 7, 0, 25, 450, DateTimeKind.Unspecified).AddTicks(3220), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 7, 0, 25, 450, DateTimeKind.Unspecified).AddTicks(3220), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"), "Streets - Bicycle and Pedestrian Improvements", "root" },
                    { new Guid("3cefaa9f-e413-40e0-94ba-58ed5e57ee12"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 8, 16, 956, DateTimeKind.Unspecified).AddTicks(7643), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 8, 16, 956, DateTimeKind.Unspecified).AddTicks(7643), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "2018 CDBG (Fund 2261)", "root" },
                    { new Guid("3d51ec28-15eb-46c4-8d71-5bc4e0912a1f"), new DateTimeOffset(new DateTime(2025, 5, 26, 2, 59, 8, 983, DateTimeKind.Unspecified).AddTicks(7580), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 2, 59, 8, 983, DateTimeKind.Unspecified).AddTicks(7580), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("c4121504-a142-4624-9c71-8764661893aa"), "Approved (Not Started)", "root" },
                    { new Guid("3e7bebcc-1548-4de7-b4b3-e63b7951161d"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 15, 0, 654, DateTimeKind.Unspecified).AddTicks(8600), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 15, 0, 654, DateTimeKind.Unspecified).AddTicks(8600), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "NORTHSIDE DOCK IMPROVEMENTS (Fund 508)", "root" },
                    { new Guid("3f0fb3b7-84e9-4dd6-a67d-9b9975574715"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 5, 2, 431, DateTimeKind.Unspecified).AddTicks(7238), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 5, 2, 431, DateTimeKind.Unspecified).AddTicks(7238), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("1881c517-32e2-4c09-8bd2-09e2efe7dc61"), "TID Increment: 15 - Chart", "root" },
                    { new Guid("3f57473d-4476-48f0-bf86-efad6cc5fca4"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 10, 37, 632, DateTimeKind.Unspecified).AddTicks(6688), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 10, 37, 632, DateTimeKind.Unspecified).AddTicks(6688), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "COMMUNITY POLICING CENTER (Fund 529)", "root" },
                    { new Guid("3fb83c02-a74e-4b67-b08e-465413419f0f"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 18, 43, 62, DateTimeKind.Unspecified).AddTicks(4741), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 18, 43, 62, DateTimeKind.Unspecified).AddTicks(4741), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "SUBDIVISION FEES PARK PURPOSES (Fund 562)", "root" },
                    { new Guid("41619839-9c72-4dc8-aa68-da1feaf1c31a"), new DateTimeOffset(new DateTime(2025, 5, 22, 17, 14, 10, 949, DateTimeKind.Unspecified).AddTicks(2183), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 17, 14, 10, 949, DateTimeKind.Unspecified).AddTicks(2183), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("0f4e03dc-0ead-41ad-93a9-26b0b6a0af3a"), "Request Added", "root" },
                    { new Guid("41a4e66e-6556-4e57-968f-b47e7f67940d"), new DateTimeOffset(new DateTime(2025, 5, 21, 23, 6, 52, 405, DateTimeKind.Unspecified).AddTicks(6130), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 21, 23, 6, 52, 405, DateTimeKind.Unspecified).AddTicks(6130), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("18b298cd-91de-4b10-ae36-3bafd0ec02e8"), "Parking Utility", "root" },
                    { new Guid("41e5abd7-4a60-4f6b-b90f-268ff3e49592"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 14, 2, 170, DateTimeKind.Unspecified).AddTicks(4777), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 14, 2, 170, DateTimeKind.Unspecified).AddTicks(4777), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "LIBRARY SPECIAL (Fund 293)", "root" },
                    { new Guid("4212182c-5e43-4c0e-9b1f-ddd9587b2516"), new DateTimeOffset(new DateTime(2025, 5, 26, 2, 45, 14, 786, DateTimeKind.Unspecified).AddTicks(7331), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 2, 45, 14, 786, DateTimeKind.Unspecified).AddTicks(7331), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("3c78d7af-5305-4138-9038-be7425fcecb2"), "Bicycle and Pedestrian Advisory Committee", "root" },
                    { new Guid("42de20af-58e7-4349-8452-231b6933f829"), new DateTimeOffset(new DateTime(2025, 5, 22, 17, 48, 5, 492, DateTimeKind.Unspecified).AddTicks(1633), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 17, 48, 5, 492, DateTimeKind.Unspecified).AddTicks(1633), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("db09f0d8-49fe-41af-99a3-01c0d498d8de"), "Construction/Maintenance", "root" },
                    { new Guid("42e1165e-58c4-4cb6-881a-38634e730505"), new DateTimeOffset(new DateTime(2025, 5, 26, 5, 53, 50, 853, DateTimeKind.Unspecified).AddTicks(2191), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 5, 53, 50, 853, DateTimeKind.Unspecified).AddTicks(2191), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("2c4caa8d-544b-4393-82be-9a5b7c221117"), "TIF Bonds/Notes: 18 - River Point District", "root" },
                    { new Guid("4319ff74-168f-4dd6-918c-b9680d0ddb30"), new DateTimeOffset(new DateTime(2025, 5, 22, 1, 5, 20, 934, DateTimeKind.Unspecified).AddTicks(6915), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 1, 5, 20, 934, DateTimeKind.Unspecified).AddTicks(6915), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("b4fe9e53-b0cc-4a8b-89d7-712bfc97ac24"), "Reduce personnel time", "root" },
                    { new Guid("4419a1cb-69ac-4712-96ef-85ac9ec0bce9"), new DateTimeOffset(new DateTime(2025, 5, 26, 5, 54, 57, 402, DateTimeKind.Unspecified).AddTicks(8750), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 5, 54, 57, 402, DateTimeKind.Unspecified).AddTicks(8750), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("eb07f930-9e73-4cda-a9eb-98c4ec2a2afc"), "Local", "root" },
                    { new Guid("441ab957-ca07-441c-a2ca-0586f3ceb6f8"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 8, 49, 85, DateTimeKind.Unspecified).AddTicks(5656), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 8, 49, 85, DateTimeKind.Unspecified).AddTicks(5656), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "AMTRAK DEPOT (Fund 205)", "root" },
                    { new Guid("4566301d-7346-4a70-84d8-5cf403f23dd1"), new DateTimeOffset(new DateTime(2025, 5, 22, 6, 52, 43, 341, DateTimeKind.Unspecified).AddTicks(6262), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 6, 52, 43, 341, DateTimeKind.Unspecified).AddTicks(6262), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("b44e86cb-1388-4c3f-ae4c-94d3df4f662b"), "General - Fire O perating Budget (Dept 370)", "root" },
                    { new Guid("4609f8ee-21ec-4d5e-9474-762531508deb"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 56, 26, 325, DateTimeKind.Unspecified).AddTicks(4467), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 56, 26, 325, DateTimeKind.Unspecified).AddTicks(4467), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"), "Economic Development - Riverside North", "root" },
                    { new Guid("46183932-e00a-4e07-9287-0b2482ae42fd"), new DateTimeOffset(new DateTime(2025, 5, 26, 7, 0, 31, 708, DateTimeKind.Unspecified).AddTicks(5473), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 7, 0, 31, 708, DateTimeKind.Unspecified).AddTicks(5473), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"), "Streets - DOT Projects", "root" },
                    { new Guid("475f2755-3a21-428d-a0fe-e754f1e160d5"), new DateTimeOffset(new DateTime(2025, 5, 26, 23, 58, 53, 542, DateTimeKind.Unspecified).AddTicks(1206), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 23, 58, 53, 542, DateTimeKind.Unspecified).AddTicks(1206), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("5516c30d-7a89-419e-be1b-0e5cb64f01ea"), "9 - International Business Park", "root" },
                    { new Guid("478881fa-94fa-4133-9d35-2883993a400e"), new DateTimeOffset(new DateTime(2025, 2, 6, 6, 49, 39, 876, DateTimeKind.Unspecified).AddTicks(6667), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 8, 33, 48, 394, DateTimeKind.Unspecified).AddTicks(9261), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("910fb5e3-80a0-4a46-b616-8cb94f56e86f"), "Technology Hardware and Software", "root" },
                    { new Guid("47fc7aee-87f5-4832-acbc-92a360ad2c03"), new DateTimeOffset(new DateTime(2025, 5, 26, 7, 1, 23, 249, DateTimeKind.Unspecified).AddTicks(8218), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 7, 1, 23, 249, DateTimeKind.Unspecified).AddTicks(8218), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"), "Vehicles and Attachments", "root" },
                    { new Guid("485c2dcd-b430-4b62-b0b2-e0ee5bafe80d"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 55, 49, 954, DateTimeKind.Unspecified).AddTicks(806), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 55, 59, 116, DateTimeKind.Unspecified).AddTicks(6919), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"), "Economic Development - Facade Rennovation", "root" },
                    { new Guid("48d2a343-2956-4785-9f39-9e6b65248f62"), new DateTimeOffset(new DateTime(2025, 2, 19, 7, 37, 16, 770, DateTimeKind.Unspecified).AddTicks(368), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 19, 7, 37, 16, 770, DateTimeKind.Unspecified).AddTicks(368), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("c641a57f-5f5e-4458-b940-4c9e562ff653"), "Pedestrian Safety", "root" },
                    { new Guid("48e6626a-2e62-47d8-a6d5-2a6b1838e4f8"), new DateTimeOffset(new DateTime(2025, 5, 22, 17, 24, 27, 482, DateTimeKind.Unspecified).AddTicks(4974), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 17, 24, 27, 482, DateTimeKind.Unspecified).AddTicks(4974), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("c1353eb7-87ca-4cca-9d5c-f87bd4ae97c8"), "La Crosse Center", "root" },
                    { new Guid("48f2f630-e2cc-4f9b-a27b-742fee8ed7dd"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 14, 13, 492, DateTimeKind.Unspecified).AddTicks(3051), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 14, 13, 492, DateTimeKind.Unspecified).AddTicks(3051), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "MEG LOCAL (Fund 502)", "root" },
                    { new Guid("4928d6b9-e054-4380-b75e-b12b17c49344"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 11, 50, 611, DateTimeKind.Unspecified).AddTicks(1846), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 11, 50, 611, DateTimeKind.Unspecified).AddTicks(1846), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "FIRE TRAINING (Fund 246)", "root" },
                    { new Guid("4960c3e8-d82b-46c7-a723-ba068f4d43e4"), new DateTimeOffset(new DateTime(2025, 5, 26, 5, 50, 41, 984, DateTimeKind.Unspecified).AddTicks(3332), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 5, 50, 41, 984, DateTimeKind.Unspecified).AddTicks(3332), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("e0dd3254-0249-4f71-8c70-36063346ad72"), "TIF Bonds/Notes: 17 - Lot C Downtown", "root" },
                    { new Guid("4a1796a4-1886-437f-a5ec-073701c39f1b"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 9, 8, 613, DateTimeKind.Unspecified).AddTicks(2390), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 9, 8, 613, DateTimeKind.Unspecified).AddTicks(2390), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "BICYCLE TRAIL (Fund 208)", "root" },
                    { new Guid("4a31b68f-fe8e-45fc-88c5-b8b081da8a3b"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 5, 37, 468, DateTimeKind.Unspecified).AddTicks(3688), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 5, 37, 468, DateTimeKind.Unspecified).AddTicks(3688), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("1881c517-32e2-4c09-8bd2-09e2efe7dc61"), "TID Increment: 7 - Amtrak Depot", "root" },
                    { new Guid("4a7859c6-76e8-47a3-af85-9a97fc6b411e"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 17, 57, 306, DateTimeKind.Unspecified).AddTicks(3630), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 17, 57, 306, DateTimeKind.Unspecified).AddTicks(3630), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "RIVERSIDE PARK IMPROVEMENTS (Fund 550)", "root" },
                    { new Guid("4b8d28ce-1bf3-46de-b999-19efd918cb9a"), new DateTimeOffset(new DateTime(2025, 5, 22, 1, 17, 51, 614, DateTimeKind.Unspecified).AddTicks(7024), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 1, 17, 51, 614, DateTimeKind.Unspecified).AddTicks(7024), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("cf4a4d66-6ced-43f2-959d-613c2fa2110d"), "City Plan Commission", "root" },
                    { new Guid("4c3f0f8a-ab30-4d7d-a975-b1efbeb87e25"), new DateTimeOffset(new DateTime(2025, 5, 26, 5, 53, 3, 508, DateTimeKind.Unspecified).AddTicks(1357), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 5, 53, 3, 508, DateTimeKind.Unspecified).AddTicks(1357), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("2c4caa8d-544b-4393-82be-9a5b7c221117"), "TIF Bonds/Notes: 12 - Three Rivers Plaza", "root" },
                    { new Guid("4c6578f5-c58b-4f12-a2e4-4de8a65e7636"), new DateTimeOffset(new DateTime(2025, 5, 22, 17, 49, 19, 563, DateTimeKind.Unspecified).AddTicks(1448), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 17, 49, 19, 563, DateTimeKind.Unspecified).AddTicks(1448), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("db09f0d8-49fe-41af-99a3-01c0d498d8de"), "Grants/Loans", "root" },
                    { new Guid("4cdfcffb-7db1-4620-b33c-6dc228205491"), new DateTimeOffset(new DateTime(2025, 5, 26, 2, 47, 59, 844, DateTimeKind.Unspecified).AddTicks(1907), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 2, 47, 59, 844, DateTimeKind.Unspecified).AddTicks(1907), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("3c78d7af-5305-4138-9038-be7425fcecb2"), "Sustainable La Crosse Commission", "root" },
                    { new Guid("4d0dae76-7e27-4c6c-8335-5d34bc817d88"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 19, 21, 184, DateTimeKind.Unspecified).AddTicks(3295), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 19, 21, 184, DateTimeKind.Unspecified).AddTicks(3295), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "VENDING MACHINES (Fund 566)", "root" },
                    { new Guid("4d65147f-9dab-42a2-9a76-de80b52fe622"), new DateTimeOffset(new DateTime(2025, 2, 19, 7, 35, 41, 220, DateTimeKind.Unspecified).AddTicks(6662), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 19, 7, 35, 41, 220, DateTimeKind.Unspecified).AddTicks(6662), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("13b9f0c2-c3b3-4b76-b238-1582ecfc81e8"), "Contract", "root" },
                    { new Guid("4d77766d-26dc-40f4-b722-dc222ca1b318"), new DateTimeOffset(new DateTime(2025, 2, 18, 5, 59, 55, 690, DateTimeKind.Unspecified).AddTicks(6850), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 18, 5, 59, 55, 690, DateTimeKind.Unspecified).AddTicks(6850), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("76fc224c-bc0a-4458-bf43-bfd8db3a0b83"), "Francis", "root" },
                    { new Guid("4d7d40e1-cdf1-4e52-bc47-1a7e5928e3bf"), new DateTimeOffset(new DateTime(2025, 5, 22, 17, 24, 46, 953, DateTimeKind.Unspecified).AddTicks(8035), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 17, 24, 46, 953, DateTimeKind.Unspecified).AddTicks(8035), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("c1353eb7-87ca-4cca-9d5c-f87bd4ae97c8"), "Library", "root" },
                    { new Guid("4dbeebce-7455-42cc-8791-029be7309883"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 13, 23, 166, DateTimeKind.Unspecified).AddTicks(3793), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 13, 23, 166, DateTimeKind.Unspecified).AddTicks(3793), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "K-9 UNIT (Fund 578)", "root" },
                    { new Guid("4dd6e9fd-af74-4c1f-9bea-917f4c625a14"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 4, 42, 234, DateTimeKind.Unspecified).AddTicks(5970), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 4, 42, 234, DateTimeKind.Unspecified).AddTicks(5970), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("1881c517-32e2-4c09-8bd2-09e2efe7dc61"), "TID Increment: 12 - Three Rivers Plaza", "root" },
                    { new Guid("4de0eb76-d5bf-40d1-acb1-3dbfce2b4389"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 11, 18, 70, DateTimeKind.Unspecified).AddTicks(2880), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 11, 18, 70, DateTimeKind.Unspecified).AddTicks(2880), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "FIRE HAZMAT TRAILER (Fund 223)", "root" },
                    { new Guid("4dfdf388-c842-45ef-b689-11fd7a7de42f"), new DateTimeOffset(new DateTime(2025, 5, 26, 2, 55, 24, 648, DateTimeKind.Unspecified).AddTicks(8903), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 2, 55, 24, 648, DateTimeKind.Unspecified).AddTicks(8903), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("00316b5b-16ab-480a-8974-50f0f6dd97fe"), "Plan and Dev - Economic Development", "root" },
                    { new Guid("4e0c0aee-57ba-41b9-a758-78c82790fdb6"), new DateTimeOffset(new DateTime(2025, 2, 14, 13, 7, 4, 934, DateTimeKind.Unspecified).AddTicks(5387), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 17, 4, 6, 28, 296, DateTimeKind.Unspecified).AddTicks(9120), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("cf4a4d66-6ced-43f2-959d-613c2fa2110d"), "Aviation Board", "root" },
                    { new Guid("4e25f5f7-02d5-4172-882c-cf4af92bab5e"), new DateTimeOffset(new DateTime(2025, 5, 21, 1, 42, 55, 337, DateTimeKind.Unspecified).AddTicks(1865), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 21, 1, 42, 55, 337, DateTimeKind.Unspecified).AddTicks(1865), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("e0dd3254-0249-4f71-8c70-36063346ad72"), "Revenue Bonds/Notes: Storm Water Utility", "root" },
                    { new Guid("4ea341b1-289e-4b59-b5f6-66c401157e39"), new DateTimeOffset(new DateTime(2025, 5, 26, 7, 0, 39, 203, DateTimeKind.Unspecified).AddTicks(6000), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 7, 0, 39, 203, DateTimeKind.Unspecified).AddTicks(6000), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"), "Streets - Street Improvements", "root" },
                    { new Guid("4f13b518-5c74-40bd-9d93-842f8164f2a4"), new DateTimeOffset(new DateTime(2025, 5, 26, 5, 54, 9, 801, DateTimeKind.Unspecified).AddTicks(3567), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 5, 54, 9, 801, DateTimeKind.Unspecified).AddTicks(3567), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("2c4caa8d-544b-4393-82be-9a5b7c221117"), "TIF Bonds/Notes: 7 - Amtrak Depot", "root" },
                    { new Guid("4f359e2b-9950-407f-917a-94c8a447e2eb"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 10, 24, 831, DateTimeKind.Unspecified).AddTicks(3407), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 10, 24, 831, DateTimeKind.Unspecified).AddTicks(3407), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "CL0SED MILLENNIUM CELEBRATION (Fund 573)", "root" },
                    { new Guid("4f549198-cf6d-418b-b3fd-5774877bba9c"), new DateTimeOffset(new DateTime(2025, 5, 22, 17, 10, 2, 49, DateTimeKind.Unspecified).AddTicks(2960), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 17, 10, 2, 49, DateTimeKind.Unspecified).AddTicks(2960), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("95f8e0c2-b1dd-44b4-aa66-09f63efddc48"), "2020-Mayor's Changes - 6/17/2020", "root" },
                    { new Guid("4f791c6e-512d-46a8-8ea9-c58953fb0b41"), new DateTimeOffset(new DateTime(2025, 2, 18, 1, 37, 33, 830, DateTimeKind.Unspecified).AddTicks(2174), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 18, 1, 37, 33, 830, DateTimeKind.Unspecified).AddTicks(2174), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("449aa104-a5aa-43c4-8552-5aa69aa69960"), "100 - GENERAL FUND", "root" },
                    { new Guid("5173dd01-4bc8-4e6e-9eb6-69d3c2a41919"), new DateTimeOffset(new DateTime(2025, 5, 22, 17, 26, 35, 501, DateTimeKind.Unspecified).AddTicks(6478), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 17, 26, 35, 501, DateTimeKind.Unspecified).AddTicks(6478), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("c1353eb7-87ca-4cca-9d5c-f87bd4ae97c8"), "Police", "root" },
                    { new Guid("5180f348-5b81-4392-8923-5585b78d09da"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 11, 57, 413, DateTimeKind.Unspecified).AddTicks(1140), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 11, 57, 413, DateTimeKind.Unspecified).AddTicks(1140), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "FITNESS FESTIVAL (Fund 218)", "root" },
                    { new Guid("51af579c-c6f9-4dd4-8411-4a5ca7f98cb1"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 0, 54, 287, DateTimeKind.Unspecified).AddTicks(2723), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 0, 54, 287, DateTimeKind.Unspecified).AddTicks(2723), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("2fbf3c72-e26f-4db8-a5de-180bc862d79e"), "Unknown", "root" },
                    { new Guid("52b1af58-6f1c-4ea9-bcb4-ba8e068a876f"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 59, 42, 892, DateTimeKind.Unspecified).AddTicks(5004), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 59, 42, 892, DateTimeKind.Unspecified).AddTicks(5004), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"), "Sanitary Sewer/Wastewater - Lift Stations", "root" },
                    { new Guid("53109d06-056c-40e0-b421-023db5651201"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 8, 43, 137, DateTimeKind.Unspecified).AddTicks(878), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 8, 43, 137, DateTimeKind.Unspecified).AddTicks(878), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "ALTERNATIVE FUEL (Fund 540)", "root" },
                    { new Guid("53c4a2a0-1a02-4b03-9d93-a05d01c4688d"), new DateTimeOffset(new DateTime(2025, 5, 21, 23, 6, 19, 690, DateTimeKind.Unspecified).AddTicks(4763), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 21, 23, 6, 19, 690, DateTimeKind.Unspecified).AddTicks(4763), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("18b298cd-91de-4b10-ae36-3bafd0ec02e8"), "Municipal Court", "root" },
                    { new Guid("53e13160-97ec-4437-a7c7-5aafcff89f77"), new DateTimeOffset(new DateTime(2025, 5, 21, 5, 34, 47, 816, DateTimeKind.Unspecified).AddTicks(5261), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 21, 5, 34, 47, 816, DateTimeKind.Unspecified).AddTicks(5261), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("b44e86cb-1388-4c3f-ae4c-94d3df4f662b"), "Enterprise - Car Rental Facility Charges", "root" },
                    { new Guid("542695af-fde3-4d2d-8bb4-6b04de85832a"), new DateTimeOffset(new DateTime(2025, 5, 22, 1, 6, 15, 812, DateTimeKind.Unspecified).AddTicks(9384), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 1, 6, 15, 812, DateTimeKind.Unspecified).AddTicks(9384), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("b4fe9e53-b0cc-4a8b-89d7-712bfc97ac24"), "Improve procedures, records, etc...", "root" },
                    { new Guid("545e1110-5274-4fa0-af38-f118687f4a12"), new DateTimeOffset(new DateTime(2025, 5, 26, 5, 52, 11, 886, DateTimeKind.Unspecified).AddTicks(3109), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 6, 13, 2, 11, 33, 712, DateTimeKind.Unspecified).AddTicks(9594), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("2c4caa8d-544b-4393-82be-9a5b7c221117"), "Revenue Bonds/Notes: Parking Utility", "root" },
                    { new Guid("546d28fb-1784-43cf-b8e9-ee34e5b8414a"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 5, 30, 768, DateTimeKind.Unspecified).AddTicks(8771), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 5, 30, 768, DateTimeKind.Unspecified).AddTicks(8771), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("1881c517-32e2-4c09-8bd2-09e2efe7dc61"), "TID Increment: 6 - City Vision Downtown", "root" },
                    { new Guid("56f80fdb-c079-4128-b301-e93a51463cb5"), new DateTimeOffset(new DateTime(2025, 5, 21, 23, 6, 40, 434, DateTimeKind.Unspecified).AddTicks(8939), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 21, 23, 6, 40, 434, DateTimeKind.Unspecified).AddTicks(8939), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("18b298cd-91de-4b10-ae36-3bafd0ec02e8"), "Municipal Transit Utility", "root" },
                    { new Guid("574166fe-1c6a-404c-a3ce-ed4e30eeab48"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 58, 9, 307, DateTimeKind.Unspecified).AddTicks(6153), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 58, 9, 307, DateTimeKind.Unspecified).AddTicks(6153), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"), "Parks - Sports Facilities", "root" },
                    { new Guid("5750c3ec-7a87-4b51-9b2f-ade8dd2d337e"), new DateTimeOffset(new DateTime(2025, 5, 26, 2, 46, 0, 48, DateTimeKind.Unspecified).AddTicks(3711), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 2, 46, 0, 48, DateTimeKind.Unspecified).AddTicks(3711), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("3c78d7af-5305-4138-9038-be7425fcecb2"), "City Plan Commission", "root" },
                    { new Guid("57f35fba-2d07-4197-94bb-07bf8d5bf4a9"), new DateTimeOffset(new DateTime(2025, 5, 26, 7, 0, 0, 733, DateTimeKind.Unspecified).AddTicks(4144), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 7, 0, 0, 733, DateTimeKind.Unspecified).AddTicks(4144), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"), "Sanitary Sewer/Wastewater - Wastewater Treatment Plant", "root" },
                    { new Guid("59a217a3-f411-4a93-899f-26f19d18f966"), new DateTimeOffset(new DateTime(2025, 5, 22, 1, 5, 33, 239, DateTimeKind.Unspecified).AddTicks(1566), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 1, 5, 33, 239, DateTimeKind.Unspecified).AddTicks(1566), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("b4fe9e53-b0cc-4a8b-89d7-712bfc97ac24"), "Expand service", "root" },
                    { new Guid("59a708f6-b024-4ce3-835c-a7016d42bc2f"), new DateTimeOffset(new DateTime(2025, 5, 22, 17, 14, 42, 756, DateTimeKind.Unspecified).AddTicks(1390), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 17, 14, 42, 756, DateTimeKind.Unspecified).AddTicks(1390), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("0f4e03dc-0ead-41ad-93a9-26b0b6a0af3a"), "Funding Decreased", "root" },
                    { new Guid("5a28c441-acb2-4b31-acb8-a2659cc33e67"), new DateTimeOffset(new DateTime(2025, 5, 22, 17, 20, 9, 633, DateTimeKind.Unspecified).AddTicks(1051), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 17, 20, 9, 633, DateTimeKind.Unspecified).AddTicks(1051), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("c1353eb7-87ca-4cca-9d5c-f87bd4ae97c8"), "Grounds and Buildings", "root" },
                    { new Guid("5a4f79da-9a76-4b4a-872f-3b452e0aaa31"), new DateTimeOffset(new DateTime(2025, 5, 21, 5, 35, 33, 771, DateTimeKind.Unspecified).AddTicks(2265), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 21, 5, 35, 33, 771, DateTimeKind.Unspecified).AddTicks(2265), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("b44e86cb-1388-4c3f-ae4c-94d3df4f662b"), "General - Clerks Operating Budget (Dept 220)", "root" },
                    { new Guid("5b0b8808-b722-47bf-98a5-effe24a353f6"), new DateTimeOffset(new DateTime(2025, 5, 26, 2, 59, 35, 812, DateTimeKind.Unspecified).AddTicks(6222), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 2, 59, 35, 812, DateTimeKind.Unspecified).AddTicks(6222), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("c4121504-a142-4624-9c71-8764661893aa"), "Withdrawn", "root" },
                    { new Guid("5b45eeeb-6d3c-4682-83a4-a28753a3570f"), new DateTimeOffset(new DateTime(2025, 5, 26, 5, 58, 2, 968, DateTimeKind.Unspecified).AddTicks(1608), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 5, 58, 2, 968, DateTimeKind.Unspecified).AddTicks(1608), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("2fbf3c72-e26f-4db8-a5de-180bc862d79e"), "General - Contingency Operating Budget (Dept 250)", "root" },
                    { new Guid("5b9850bc-8abc-440b-896a-7368d5dbcadb"), new DateTimeOffset(new DateTime(2025, 5, 22, 17, 25, 24, 341, DateTimeKind.Unspecified).AddTicks(8360), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 17, 25, 24, 341, DateTimeKind.Unspecified).AddTicks(8360), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("c1353eb7-87ca-4cca-9d5c-f87bd4ae97c8"), "Municipal Transit Utility", "root" },
                    { new Guid("5c2086a3-26d9-4b66-bacc-de0d0efb72c2"), new DateTimeOffset(new DateTime(2025, 2, 28, 5, 30, 52, 684, DateTimeKind.Unspecified).AddTicks(6273), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 6, 55, 625, DateTimeKind.Unspecified).AddTicks(7656), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "2010 CDBG (Fund 2253)", "root" },
                    { new Guid("5c3cbe43-7742-455c-a390-30145d974d0a"), new DateTimeOffset(new DateTime(2025, 2, 6, 6, 50, 14, 696, DateTimeKind.Unspecified).AddTicks(6667), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 21, 1, 42, 21, 448, DateTimeKind.Unspecified).AddTicks(7538), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("e0dd3254-0249-4f71-8c70-36063346ad72"), "Revenue Bonds/Notes: Parking Utility", "root" },
                    { new Guid("5c457d7b-5067-438d-bb2d-8220f63337a2"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 14, 8, 13, DateTimeKind.Unspecified).AddTicks(1493), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 14, 8, 13, DateTimeKind.Unspecified).AddTicks(1493), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "LIBRARY SPECIAL CHECKING (Fund 289)", "root" },
                    { new Guid("5c45f11d-e76f-45f8-ac0f-411c28cf6839"), new DateTimeOffset(new DateTime(2025, 2, 20, 6, 35, 52, 439, DateTimeKind.Unspecified).AddTicks(8875), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 20, 6, 35, 52, 439, DateTimeKind.Unspecified).AddTicks(8875), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("5516c30d-7a89-419e-be1b-0e5cb64f01ea"), "16 - LIPCO/Trane Plant 6", "root" },
                    { new Guid("5d25246d-ed63-4149-a7a8-de320af10b54"), new DateTimeOffset(new DateTime(2025, 5, 26, 7, 1, 30, 418, DateTimeKind.Unspecified).AddTicks(8274), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 7, 1, 30, 418, DateTimeKind.Unspecified).AddTicks(8274), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"), "Water - Other", "root" },
                    { new Guid("5e5b211c-93a4-45ca-84fb-9f5d177acd44"), new DateTimeOffset(new DateTime(2025, 5, 26, 2, 55, 49, 319, DateTimeKind.Unspecified).AddTicks(4693), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 2, 55, 49, 319, DateTimeKind.Unspecified).AddTicks(4693), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("00316b5b-16ab-480a-8974-50f0f6dd97fe"), "Plan and Dev - Neighborhoods", "root" },
                    { new Guid("5e791233-7539-4271-9a98-84d906dc412b"), new DateTimeOffset(new DateTime(2025, 5, 26, 5, 59, 6, 522, DateTimeKind.Unspecified).AddTicks(3261), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 5, 59, 6, 522, DateTimeKind.Unspecified).AddTicks(3261), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("2fbf3c72-e26f-4db8-a5de-180bc862d79e"), "General - Grounds and Building Operating Budget (Dept 882)", "root" },
                    { new Guid("5e7c54c5-b9de-4d83-ac0a-d4ffd0e98448"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 17, 0, 445, DateTimeKind.Unspecified).AddTicks(3659), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 17, 0, 445, DateTimeKind.Unspecified).AddTicks(3659), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "POLICE GREAT LOCAL (Fund 527)", "root" },
                    { new Guid("5e95db11-08b3-4517-b367-0a488ddeee9b"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 19, 3, 423, DateTimeKind.Unspecified).AddTicks(4427), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 19, 3, 423, DateTimeKind.Unspecified).AddTicks(4427), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "TUITION REIMBURSEMENT (Fund 576)", "root" },
                    { new Guid("5ee122a6-7faf-42bf-910e-7f1d496773da"), new DateTimeOffset(new DateTime(2025, 2, 13, 6, 35, 0, 742, DateTimeKind.Unspecified).AddTicks(232), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 13, 6, 35, 0, 742, DateTimeKind.Unspecified).AddTicks(232), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("0224d7e1-5841-49c4-8dd1-1cb4791bc028"), "Group First", "root" },
                    { new Guid("5f4209d7-9703-46e4-8230-364cf32ae470"), new DateTimeOffset(new DateTime(2025, 5, 26, 2, 50, 38, 854, DateTimeKind.Unspecified).AddTicks(6135), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 2, 50, 38, 854, DateTimeKind.Unspecified).AddTicks(6135), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("00316b5b-16ab-480a-8974-50f0f6dd97fe"), "B and G - Municipal Service Center", "root" },
                    { new Guid("5fbb5f6b-0cb9-459d-b1ca-a9558d630bcb"), new DateTimeOffset(new DateTime(2025, 5, 26, 5, 52, 39, 995, DateTimeKind.Unspecified).AddTicks(4211), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 5, 52, 39, 995, DateTimeKind.Unspecified).AddTicks(4211), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("2c4caa8d-544b-4393-82be-9a5b7c221117"), "Reve nue Bonds/Notes: Water Utility", "root" },
                    { new Guid("5fde2bbd-6fb7-4d6b-b63c-faec780f5031"), new DateTimeOffset(new DateTime(2025, 5, 26, 5, 51, 27, 59, DateTimeKind.Unspecified).AddTicks(325), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 5, 51, 27, 59, DateTimeKind.Unspecified).AddTicks(325), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("e0dd3254-0249-4f71-8c70-36063346ad72"), "TIF Bonds/Notes: 9 - International Business Park", "root" },
                    { new Guid("5fe61493-b4d3-4927-99c9-455ec535d3db"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 15, 36, 851, DateTimeKind.Unspecified).AddTicks(7619), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 15, 36, 851, DateTimeKind.Unspecified).AddTicks(7619), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "PETTIBONE PARK IMPROVEMENTS (Fund 515)", "root" },
                    { new Guid("60896384-1b49-4777-a210-1504a525b2c2"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 0, 32, 726, DateTimeKind.Unspecified).AddTicks(540), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 0, 32, 726, DateTimeKind.Unspecified).AddTicks(540), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("2fbf3c72-e26f-4db8-a5de-180bc862d79e"), "General - Room Tax Operating Budget (Dept 791)", "root" },
                    { new Guid("60b6d3c6-528f-4990-89ed-2d453ee171f7"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 13, 6, 192, DateTimeKind.Unspecified).AddTicks(2831), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 13, 6, 192, DateTimeKind.Unspecified).AddTicks(2831), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "HUMAN RIGHTS AND ETHICS INVSTGTN (Fund 585)", "root" },
                    { new Guid("6213fe1c-8a7d-4129-9d99-dd3748326f6f"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 16, 15, 810, DateTimeKind.Unspecified).AddTicks(5746), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 16, 15, 810, DateTimeKind.Unspecified).AddTicks(5746), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "POLICE DART (Fund 523)", "root" },
                    { new Guid("62626ce1-957e-47e9-ade7-554420f27d06"), new DateTimeOffset(new DateTime(2025, 2, 13, 6, 24, 47, 720, DateTimeKind.Unspecified).AddTicks(8837), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 13, 6, 24, 47, 720, DateTimeKind.Unspecified).AddTicks(8837), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("761adb91-60e3-43bc-bbdf-bdf1b586d4f1"), "Program", "root" },
                    { new Guid("6265803a-eac9-4ca4-b0f3-dc9418952754"), new DateTimeOffset(new DateTime(2025, 5, 26, 2, 55, 16, 344, DateTimeKind.Unspecified).AddTicks(6950), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 2, 55, 16, 344, DateTimeKind.Unspecified).AddTicks(6950), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("00316b5b-16ab-480a-8974-50f0f6dd97fe"), "Parks, Recreation and Forestry", "root" },
                    { new Guid("62ba9a19-bd80-4ca6-91d2-8928a60984fa"), new DateTimeOffset(new DateTime(2025, 5, 22, 6, 49, 53, 604, DateTimeKind.Unspecified).AddTicks(4925), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 6, 49, 53, 604, DateTimeKind.Unspecified).AddTicks(4925), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("b44e86cb-1388-4c3f-ae4c-94d3df4f662b"), "General - Police Operating Budget (Dept 850)", "root" },
                    { new Guid("62dee8f6-4289-498e-87d4-d0ebb545fb9c"), new DateTimeOffset(new DateTime(2025, 2, 19, 7, 38, 25, 329, DateTimeKind.Unspecified).AddTicks(8453), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 19, 7, 38, 25, 329, DateTimeKind.Unspecified).AddTicks(8453), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("bd4dd1db-1f4d-455c-846b-4e0b620dfb1d"), "Trees/Plants", "root" },
                    { new Guid("63114c92-bf9c-4f63-910f-3d31e518c90d"), new DateTimeOffset(new DateTime(2025, 5, 22, 6, 51, 9, 410, DateTimeKind.Unspecified).AddTicks(2968), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 6, 51, 9, 410, DateTimeKind.Unspecified).AddTicks(2968), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("b44e86cb-1388-4c3f-ae4c-94d3df4f662b"), "General - Library Operating Budget (Dept 520)", "root" },
                    { new Guid("635be736-ca46-47c3-a6f8-cc1ca0914179"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 58, 49, 764, DateTimeKind.Unspecified).AddTicks(6882), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 58, 49, 764, DateTimeKind.Unspecified).AddTicks(6882), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"), "Public Buildings - Green Island", "root" },
                    { new Guid("640356b8-ba9f-43a2-bea6-4f3d0d283c42"), new DateTimeOffset(new DateTime(2025, 2, 6, 6, 49, 44, 610, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 6, 6, 49, 44, 610, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("b4fe9e53-b0cc-4a8b-89d7-712bfc97ac24"), "Present Equipment Obsolete", "root" },
                    { new Guid("640f9351-c3ea-4fa2-8a6b-6e5909808e68"), new DateTimeOffset(new DateTime(2025, 5, 26, 5, 58, 57, 378, DateTimeKind.Unspecified).AddTicks(2207), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 5, 58, 57, 378, DateTimeKind.Unspecified).AddTicks(2207), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("2fbf3c72-e26f-4db8-a5de-180bc862d79e"), "General - General Expens e Operating Budget (Dept 420)", "root" },
                    { new Guid("646a13fa-1e68-49ba-841c-03486759cdaf"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 56, 45, 17, DateTimeKind.Unspecified).AddTicks(1282), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 56, 45, 17, DateTimeKind.Unspecified).AddTicks(1282), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"), "Fiber", "root" },
                    { new Guid("6484910f-09ef-423b-b96e-fce8c6f0362c"), new DateTimeOffset(new DateTime(2025, 5, 21, 23, 7, 18, 848, DateTimeKind.Unspecified).AddTicks(6374), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 21, 23, 7, 18, 848, DateTimeKind.Unspecified).AddTicks(6374), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("18b298cd-91de-4b10-ae36-3bafd0ec02e8"), "Planning and Development", "root" },
                    { new Guid("653317bb-9339-48e0-ada4-e18b5fe8b2bd"), new DateTimeOffset(new DateTime(2025, 5, 26, 2, 59, 17, 99, DateTimeKind.Unspecified).AddTicks(9684), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 2, 59, 17, 99, DateTimeKind.Unspecified).AddTicks(9684), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("c4121504-a142-4624-9c71-8764661893aa"), "Completed", "root" },
                    { new Guid("6760722c-46d1-4c6b-90bd-5bc544a78bc7"), new DateTimeOffset(new DateTime(2025, 5, 26, 5, 57, 36, 937, DateTimeKind.Unspecified).AddTicks(2470), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 5, 57, 36, 937, DateTimeKind.Unspecified).AddTicks(2470), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("2fbf3c72-e26f-4db8-a5de-180bc862d79e"), "Enterprise - Passenger Facility Charges", "root" },
                    { new Guid("676b5e58-aa0a-47b8-b8a2-1ab1b3b57f03"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 56, 51, 150, DateTimeKind.Unspecified).AddTicks(1121), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 56, 51, 150, DateTimeKind.Unspecified).AddTicks(1121), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"), "Fire Stations", "root" },
                    { new Guid("67c7473d-3071-42f0-ac52-da3721223389"), new DateTimeOffset(new DateTime(2025, 3, 19, 13, 27, 18, 266, DateTimeKind.Unspecified).AddTicks(8369), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 3, 19, 13, 27, 18, 266, DateTimeKind.Unspecified).AddTicks(8369), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("93985952-4e53-4b3d-a897-8bec835d8d42"), "Approved by Finance", "root" },
                    { new Guid("68c03bcf-929d-4bd0-98be-e2409de526e0"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 19, 15, 19, DateTimeKind.Unspecified).AddTicks(3024), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 19, 15, 19, DateTimeKind.Unspecified).AddTicks(3024), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "VACANT BLDG REGISTRATION PROG (Fund 286)", "root" },
                    { new Guid("68c2bcd8-10f2-4afe-b837-f00294bc39a1"), new DateTimeOffset(new DateTime(2025, 2, 19, 7, 39, 22, 168, DateTimeKind.Unspecified).AddTicks(787), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 19, 7, 39, 22, 168, DateTimeKind.Unspecified).AddTicks(787), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("7b667e0f-6875-4180-b774-92136e36924b"), "Storm Sewers", "root" },
                    { new Guid("696c523e-7c0d-4833-bf52-7a535f3c0698"), new DateTimeOffset(new DateTime(2025, 5, 22, 1, 20, 7, 390, DateTimeKind.Unspecified).AddTicks(3726), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 1, 20, 7, 390, DateTimeKind.Unspecified).AddTicks(3726), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("cf4a4d66-6ced-43f2-959d-613c2fa2110d"), "Redevelopment Authority", "root" },
                    { new Guid("69d9670a-6395-4b4d-a633-47c3c6395b96"), new DateTimeOffset(new DateTime(2025, 2, 12, 14, 33, 20, 356, DateTimeKind.Unspecified).AddTicks(3791), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 12, 14, 33, 20, 356, DateTimeKind.Unspecified).AddTicks(3791), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("18b298cd-91de-4b10-ae36-3bafd0ec02e8"), "Fire", "root" },
                    { new Guid("6a1083a3-6f8b-4723-bd91-05cadfa9a8b7"), new DateTimeOffset(new DateTime(2025, 5, 26, 5, 50, 26, 763, DateTimeKind.Unspecified).AddTicks(6917), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 5, 50, 26, 763, DateTimeKind.Unspecified).AddTicks(6917), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("e0dd3254-0249-4f71-8c70-36063346ad72"), "TIF Bonds/Notes: 16 - LIPCO/Trane Plant 6", "root" },
                    { new Guid("6a1d4fb3-39bb-4245-bb2c-e030b440a636"), new DateTimeOffset(new DateTime(2025, 5, 26, 2, 57, 52, 639, DateTimeKind.Unspecified).AddTicks(6164), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 2, 57, 52, 639, DateTimeKind.Unspecified).AddTicks(6164), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("00316b5b-16ab-480a-8974-50f0f6dd97fe"), "Trans and Utils - Airport", "root" },
                    { new Guid("6a9742df-5b46-4757-927d-706d0cee554c"), new DateTimeOffset(new DateTime(2025, 5, 26, 5, 58, 33, 443, DateTimeKind.Unspecified).AddTicks(2983), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 5, 58, 33, 443, DateTimeKind.Unspecified).AddTicks(2983), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("2fbf3c72-e26f-4db8-a5de-180bc862d79e"), "General - Finance Operating Budget (Dept 340)", "root" },
                    { new Guid("6acfa308-89fb-4a06-a181-1b3f6dc4e984"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 57, 56, 418, DateTimeKind.Unspecified).AddTicks(2676), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 57, 56, 418, DateTimeKind.Unspecified).AddTicks(2676), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"), "Parks - General Improvements", "root" },
                    { new Guid("6ae74ffe-54e4-4af6-828c-21f4ed24d9b4"), new DateTimeOffset(new DateTime(2025, 5, 26, 5, 58, 46, 873, DateTimeKind.Unspecified).AddTicks(2164), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 5, 58, 46, 873, DateTimeKind.Unspecified).AddTicks(2164), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("2fbf3c72-e26f-4db8-a5de-180bc862d79e"), "General - Fire Prevention and Building Safety Operating Budget (Dept 889)", "root" },
                    { new Guid("6b49150f-ba9c-40b1-8f07-7a34e4f1d243"), new DateTimeOffset(new DateTime(2025, 5, 21, 1, 42, 30, 278, DateTimeKind.Unspecified).AddTicks(2947), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 21, 1, 42, 30, 278, DateTimeKind.Unspecified).AddTicks(2947), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("e0dd3254-0249-4f71-8c70-36063346ad72"), "Loan: State Trust Fund", "root" },
                    { new Guid("6e0b5321-1356-4919-b19e-db5621b3ad01"), new DateTimeOffset(new DateTime(2025, 2, 25, 2, 5, 13, 800, DateTimeKind.Unspecified).AddTicks(8803), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 25, 2, 5, 13, 800, DateTimeKind.Unspecified).AddTicks(8803), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("c72a2551-f9d5-4b61-bfe7-0cb74bd53de4"), "Detail 1", "root" },
                    { new Guid("6ea100f5-4f72-42e7-b663-712c568bb0ee"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 58, 38, 548, DateTimeKind.Unspecified).AddTicks(7601), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 59, 1, 505, DateTimeKind.Unspecified).AddTicks(2391), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"), "Public Buildings - La Crosse Center", "root" },
                    { new Guid("6efa5e41-8b70-4587-98ec-035ccabf0af3"), new DateTimeOffset(new DateTime(2025, 2, 20, 5, 6, 51, 985, DateTimeKind.Unspecified).AddTicks(2155), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 20, 5, 6, 51, 985, DateTimeKind.Unspecified).AddTicks(2155), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("5516c30d-7a89-419e-be1b-0e5cb64f01ea"), "11 - Gateway Redevelpment", "root" },
                    { new Guid("7018bbf4-98a9-46eb-b93f-fbe43d9c8644"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 8, 56, 189, DateTimeKind.Unspecified).AddTicks(2128), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 8, 56, 189, DateTimeKind.Unspecified).AddTicks(2128), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "ANDERSON MEMORIAL (Fund 236)", "root" },
                    { new Guid("7092ff7a-955b-4e64-97d9-edfa1e10e4a1"), new DateTimeOffset(new DateTime(2025, 5, 22, 17, 25, 40, 849, DateTimeKind.Unspecified).AddTicks(2405), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 17, 25, 40, 849, DateTimeKind.Unspecified).AddTicks(2405), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("c1353eb7-87ca-4cca-9d5c-f87bd4ae97c8"), "Parking Utility", "root" },
                    { new Guid("70dc2871-45af-4f39-ae5a-11249395d0ee"), new DateTimeOffset(new DateTime(2025, 5, 26, 7, 0, 51, 105, DateTimeKind.Unspecified).AddTicks(4594), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 7, 0, 51, 105, DateTimeKind.Unspecified).AddTicks(4594), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"), "Streets - Traffic Signals", "root" },
                    { new Guid("7117ad7b-fe19-42ea-8bff-3096d8a13e2e"), new DateTimeOffset(new DateTime(2025, 5, 22, 6, 51, 35, 356, DateTimeKind.Unspecified).AddTicks(1215), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 6, 51, 35, 356, DateTimeKind.Unspecified).AddTicks(1215), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("b44e86cb-1388-4c3f-ae4c-94d3df4f662b"), "General - Insurance Operating Budget (Dept 460)", "root" },
                    { new Guid("712966c9-c55d-490b-ba63-a72fd33c27a2"), new DateTimeOffset(new DateTime(2025, 5, 26, 5, 54, 1, 516, DateTimeKind.Unspecified).AddTicks(4369), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 5, 54, 1, 516, DateTimeKind.Unspecified).AddTicks(4369), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("2c4caa8d-544b-4393-82be-9a5b7c221117"), "TIF Bonds/Notes: 6 - City Vision Downtown", "root" },
                    { new Guid("713ec569-9421-4ae3-b6a9-4a3be1606562"), new DateTimeOffset(new DateTime(2025, 2, 19, 6, 50, 28, 569, DateTimeKind.Unspecified).AddTicks(9679), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 19, 6, 50, 28, 569, DateTimeKind.Unspecified).AddTicks(9679), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("e2bc2f40-b296-48b6-bfaa-faf91bd5539e"), "6", "root" },
                    { new Guid("716c7ab5-fa5d-4a46-b6c1-0a06172d30a2"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 12, 35, 671, DateTimeKind.Unspecified).AddTicks(1896), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 12, 35, 671, DateTimeKind.Unspecified).AddTicks(1896), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "GRIEVANCE PROCEDURE FUND (Fund 217)", "root" },
                    { new Guid("723dd3de-8a09-4939-82e9-22c27b872cc7"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 1, 3, 12, DateTimeKind.Unspecified).AddTicks(2505), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 1, 3, 12, DateTimeKind.Unspecified).AddTicks(2505), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("2fbf3c72-e26f-4db8-a5de-180bc862d79e"), "Utility - Parking Utility Funds (Fund 610)", "root" },
                    { new Guid("72583ddf-2de8-4d2f-8ed4-41af542b5fa0"), new DateTimeOffset(new DateTime(2025, 5, 26, 5, 55, 19, 437, DateTimeKind.Unspecified).AddTicks(2702), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 5, 55, 19, 437, DateTimeKind.Unspecified).AddTicks(2702), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("eb07f930-9e73-4cda-a9eb-98c4ec2a2afc"), "Unknown", "root" },
                    { new Guid("72b2781b-a087-4929-82a3-9348e76174fb"), new DateTimeOffset(new DateTime(2025, 5, 21, 23, 7, 9, 629, DateTimeKind.Unspecified).AddTicks(2988), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 21, 23, 7, 9, 629, DateTimeKind.Unspecified).AddTicks(2988), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("18b298cd-91de-4b10-ae36-3bafd0ec02e8"), "Parks and Recreation", "root" },
                    { new Guid("73457654-b4ea-4101-a3cf-dec59a535da8"), new DateTimeOffset(new DateTime(2025, 2, 19, 6, 50, 48, 203, DateTimeKind.Unspecified).AddTicks(1923), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 19, 6, 50, 48, 203, DateTimeKind.Unspecified).AddTicks(1923), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("e2bc2f40-b296-48b6-bfaa-faf91bd5539e"), "10", "root" },
                    { new Guid("74a24f2e-fa9d-4d64-accb-ac36964293d7"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 17, 8, 918, DateTimeKind.Unspecified).AddTicks(5176), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 17, 8, 918, DateTimeKind.Unspecified).AddTicks(5176), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "POLICE RESERVE PROGRAM (Fund 545)", "root" },
                    { new Guid("750bf786-a886-4bb9-8fb5-2071d327d746"), new DateTimeOffset(new DateTime(2025, 5, 26, 5, 59, 28, 88, DateTimeKind.Unspecified).AddTicks(786), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 5, 59, 28, 88, DateTimeKind.Unspecified).AddTicks(786), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("2fbf3c72-e26f-4db8-a5de-180bc862d79e"), "General - IT Operating Budget (Dept 580)", "root" },
                    { new Guid("75691d23-ac0a-43ee-9ee0-78563c5f6fcd"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 5, 10, 519, DateTimeKind.Unspecified).AddTicks(8499), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 5, 10, 519, DateTimeKind.Unspecified).AddTicks(8499), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("1881c517-32e2-4c09-8bd2-09e2efe7dc61"), "TID Increment: 16 - LIPCO/Trane Plant 6", "root" },
                    { new Guid("75b7158f-56f1-4873-a5b3-8e29c3565945"), new DateTimeOffset(new DateTime(2025, 5, 22, 17, 13, 11, 501, DateTimeKind.Unspecified).AddTicks(1507), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 17, 13, 11, 501, DateTimeKind.Unspecified).AddTicks(1507), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("0f4e03dc-0ead-41ad-93a9-26b0b6a0af3a"), "Funding Moved Out", "root" },
                    { new Guid("762129a9-181a-4957-ad86-0b0f582343c1"), new DateTimeOffset(new DateTime(2025, 5, 22, 17, 12, 15, 275, DateTimeKind.Unspecified).AddTicks(8483), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 17, 12, 15, 275, DateTimeKind.Unspecified).AddTicks(8483), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("3c78d7af-5305-4138-9038-be7425fcecb2"), "Board of Park Commissioners", "root" },
                    { new Guid("767aae96-b6a4-4fb8-8fe3-c203e090ab4e"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 12, 47, 753, DateTimeKind.Unspecified).AddTicks(2432), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 12, 47, 753, DateTimeKind.Unspecified).AddTicks(2432), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "HARBOR SINKING FUND (Fund 507)", "root" },
                    { new Guid("7729ad84-0917-49b3-a52d-bfe34f14b06f"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 57, 37, 96, DateTimeKind.Unspecified).AddTicks(3397), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 57, 37, 96, DateTimeKind.Unspecified).AddTicks(3397), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"), "Parks - Blufflands", "root" },
                    { new Guid("77c767e7-37db-4339-b0f0-5221f05e9925"), new DateTimeOffset(new DateTime(2025, 5, 22, 17, 19, 44, 326, DateTimeKind.Unspecified).AddTicks(9133), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 17, 19, 44, 326, DateTimeKind.Unspecified).AddTicks(9133), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("c1353eb7-87ca-4cca-9d5c-f87bd4ae97c8"), "Engineering", "root" },
                    { new Guid("77cc2141-c6da-4c34-822b-cafe537bb2f6"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 58, 22, 317, DateTimeKind.Unspecified).AddTicks(4518), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 58, 22, 317, DateTimeKind.Unspecified).AddTicks(4518), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"), "Planning and Community Development - Miscellaneous", "root" },
                    { new Guid("785f8599-9650-40b5-834f-ad750cf260a6"), new DateTimeOffset(new DateTime(2025, 5, 26, 5, 50, 52, 222, DateTimeKind.Unspecified).AddTicks(3137), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 5, 50, 52, 222, DateTimeKind.Unspecified).AddTicks(3137), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("e0dd3254-0249-4f71-8c70-36063346ad72"), "TIF Bonds/Notes: 18 - River Point District", "root" },
                    { new Guid("78703599-6c34-48de-92bf-5a312228621d"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 11, 25, 741, DateTimeKind.Unspecified).AddTicks(1598), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 11, 25, 741, DateTimeKind.Unspecified).AddTicks(1598), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "FIRE IRIS (Fund 221)", "root" },
                    { new Guid("7889017e-7301-4d75-95e8-49d5ed83ebd6"), new DateTimeOffset(new DateTime(2025, 2, 14, 13, 6, 52, 685, DateTimeKind.Unspecified).AddTicks(1950), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 17, 6, 14, 10, 379, DateTimeKind.Unspecified).AddTicks(2341), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("cf4a4d66-6ced-43f2-959d-613c2fa2110d"), "(None)", "root" },
                    { new Guid("78c6a068-9f45-43bb-a59c-bb372ed9e15c"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 6, 6, 289, DateTimeKind.Unspecified).AddTicks(4339), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 6, 6, 289, DateTimeKind.Unspecified).AddTicks(4339), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("1881c517-32e2-4c09-8bd2-09e2efe7dc61"), "Unknown", "root" },
                    { new Guid("7914ce74-8f62-4734-a6c7-e6dedb569f15"), new DateTimeOffset(new DateTime(2025, 3, 27, 5, 37, 58, 195, DateTimeKind.Unspecified).AddTicks(1772), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 3, 27, 5, 37, 58, 195, DateTimeKind.Unspecified).AddTicks(1772), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("76854444-444f-4524-8a61-9fcb24e1c9b1"), "Program", "root" },
                    { new Guid("79a1bc4d-ee3a-4b49-9d9d-482f5e6fb56c"), new DateTimeOffset(new DateTime(2025, 5, 26, 5, 58, 9, 699, DateTimeKind.Unspecified).AddTicks(5123), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 5, 58, 9, 699, DateTimeKind.Unspecified).AddTicks(5123), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("2fbf3c72-e26f-4db8-a5de-180bc862d79e"), "General - Council Operating Budget (Dept 280)", "root" },
                    { new Guid("79c3f898-9f84-46e2-b250-00f18e03060f"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 13, 37, 884, DateTimeKind.Unspecified).AddTicks(6091), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 13, 37, 884, DateTimeKind.Unspecified).AddTicks(6091), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "LA CROSSE CTR FOOD AND BEVERAG (Fund 579)", "root" },
                    { new Guid("7a5c35bf-6762-443e-ac1d-7c9d74ceda3f"), new DateTimeOffset(new DateTime(2025, 3, 19, 13, 28, 31, 418, DateTimeKind.Unspecified).AddTicks(3127), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 3, 19, 13, 28, 31, 418, DateTimeKind.Unspecified).AddTicks(3127), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("93985952-4e53-4b3d-a897-8bec835d8d42"), "Requires Department Review", "root" },
                    { new Guid("7abfc6b9-0efc-4aba-bec7-9b3c1899269c"), new DateTimeOffset(new DateTime(2025, 5, 22, 1, 4, 53, 476, DateTimeKind.Unspecified).AddTicks(8760), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 1, 4, 53, 476, DateTimeKind.Unspecified).AddTicks(8760), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("b4fe9e53-b0cc-4a8b-89d7-712bfc97ac24"), "Replace worn-out equipment", "root" },
                    { new Guid("7b75bb54-bf53-4bd0-8085-a0c4494e65d7"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 16, 41, 572, DateTimeKind.Unspecified).AddTicks(5133), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 16, 41, 572, DateTimeKind.Unspecified).AddTicks(5133), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "POLICE EXPLORER POST PROGRAM (Fund 547)", "root" },
                    { new Guid("7b7bea58-bb80-455a-b890-7ac655ca2693"), new DateTimeOffset(new DateTime(2025, 2, 28, 5, 48, 10, 569, DateTimeKind.Unspecified).AddTicks(5058), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 28, 5, 48, 10, 569, DateTimeKind.Unspecified).AddTicks(5058), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("95f8e0c2-b1dd-44b4-aa66-09f63efddc48"), "Test Change Set", "root" },
                    { new Guid("7bc23531-8799-474d-9556-45b1c19f5ab3"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 16, 10, 138, DateTimeKind.Unspecified).AddTicks(3186), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 16, 10, 138, DateTimeKind.Unspecified).AddTicks(3186), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "POLICE DARE (Fund 522)", "root" },
                    { new Guid("7c724313-8c93-410e-944b-05a81b6c1b78"), new DateTimeOffset(new DateTime(2025, 2, 19, 7, 35, 13, 112, DateTimeKind.Unspecified).AddTicks(9974), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 19, 7, 35, 13, 112, DateTimeKind.Unspecified).AddTicks(9974), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("49921477-b361-4299-8fcb-5ec327ddf57c"), "Fair", "root" },
                    { new Guid("7cc437a2-5fda-4a9b-ada4-47a23dc2bfb0"), new DateTimeOffset(new DateTime(2025, 5, 21, 22, 59, 2, 432, DateTimeKind.Unspecified).AddTicks(2339), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 21, 22, 59, 2, 432, DateTimeKind.Unspecified).AddTicks(2339), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("18b298cd-91de-4b10-ae36-3bafd0ec02e8"), "Library", "root" },
                    { new Guid("7e42ed08-08bd-4c75-8443-372c80ece999"), new DateTimeOffset(new DateTime(2025, 5, 21, 22, 57, 11, 400, DateTimeKind.Unspecified).AddTicks(3388), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 21, 22, 57, 11, 400, DateTimeKind.Unspecified).AddTicks(3388), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("18b298cd-91de-4b10-ae36-3bafd0ec02e8"), "Citywide", "root" },
                    { new Guid("7e65e830-74bb-4c21-8dea-f94e057f29f5"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 16, 48, 85, DateTimeKind.Unspecified).AddTicks(2680), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 16, 48, 85, DateTimeKind.Unspecified).AddTicks(2680), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "POLICE FINGERPRINTING (Fund 543)", "root" },
                    { new Guid("7e67eb2d-e8fe-4342-92a0-cc0a6361d435"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 13, 17, 394, DateTimeKind.Unspecified).AddTicks(6489), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 13, 17, 394, DateTimeKind.Unspecified).AddTicks(6489), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "INT'L CITY GARDEN FUND (Fund 296)", "root" },
                    { new Guid("7f09a62d-e810-4bc9-b6b1-fb04b24947bf"), new DateTimeOffset(new DateTime(2025, 5, 26, 5, 58, 16, 325, DateTimeKind.Unspecified).AddTicks(4316), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 5, 58, 16, 325, DateTimeKind.Unspecified).AddTicks(4316), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("2fbf3c72-e26f-4db8-a5de-180bc862d79e"), "General - Employee Benefit Operating Budget (Dept 421)", "root" },
                    { new Guid("7f4e75a1-ab7d-4190-8ca6-6b77fa4cf432"), new DateTimeOffset(new DateTime(2025, 5, 22, 1, 19, 35, 820, DateTimeKind.Unspecified).AddTicks(7071), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 1, 19, 35, 820, DateTimeKind.Unspecified).AddTicks(7071), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("cf4a4d66-6ced-43f2-959d-613c2fa2110d"), "Library Board", "root" },
                    { new Guid("80e694cd-a657-47f5-8089-e871e53a9a4a"), new DateTimeOffset(new DateTime(2025, 2, 19, 6, 50, 7, 168, DateTimeKind.Unspecified).AddTicks(6756), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 19, 6, 50, 7, 168, DateTimeKind.Unspecified).AddTicks(6756), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("e2bc2f40-b296-48b6-bfaa-faf91bd5539e"), "1", "root" },
                    { new Guid("80eb4a58-1173-4a69-9de8-4f8aca2ea777"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 18, 55, 774, DateTimeKind.Unspecified).AddTicks(6336), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 18, 55, 774, DateTimeKind.Unspecified).AddTicks(6336), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "TRAIL IMPROVEMENTS (Fund 232)", "root" },
                    { new Guid("8187e3c4-a3bd-42d5-bdf5-7991c9bc720d"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 7, 15, 762, DateTimeKind.Unspecified).AddTicks(5791), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 7, 15, 762, DateTimeKind.Unspecified).AddTicks(5791), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "2013 CDBG (Fund 2256)", "root" },
                    { new Guid("81fba826-48c7-402f-bbf6-3347aaa9530f"), new DateTimeOffset(new DateTime(2025, 5, 26, 2, 57, 12, 391, DateTimeKind.Unspecified).AddTicks(9253), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 2, 57, 12, 391, DateTimeKind.Unspecified).AddTicks(9253), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("00316b5b-16ab-480a-8974-50f0f6dd97fe"), "Trans and Utils - Streets", "root" },
                    { new Guid("8253aa37-6e01-4f67-b9a8-18efd3fe9e06"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 10, 13, 170, DateTimeKind.Unspecified).AddTicks(4542), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 10, 13, 170, DateTimeKind.Unspecified).AddTicks(4542), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "CDBG RECOVERY FUNDS (Fund 2070)", "root" },
                    { new Guid("825ad848-535d-4bf3-a638-55679a14c68a"), new DateTimeOffset(new DateTime(2025, 2, 28, 11, 11, 14, 643, DateTimeKind.Unspecified).AddTicks(6766), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 5, 57, 15, 689, DateTimeKind.Unspecified).AddTicks(7054), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("2fbf3c72-e26f-4db8-a5de-180bc862d79e"), "Enterprise - Airport Operating Funds (Fund 600)", "root" },
                    { new Guid("84573742-0ed5-4fb7-a0e5-c280a71452ef"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 1, 35, 18, DateTimeKind.Unspecified).AddTicks(5233), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 1, 35, 18, DateTimeKind.Unspecified).AddTicks(5233), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("2fbf3c72-e26f-4db8-a5de-180bc862d79e"), "Utility - Water Utility Funds (Fund 645)", "root" },
                    { new Guid("84a72325-bdad-4a47-b5b0-8dec733f0f5a"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 13, 11, 387, DateTimeKind.Unspecified).AddTicks(2231), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 13, 11, 387, DateTimeKind.Unspecified).AddTicks(2231), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "INDUSTRIAL PARK SINKING (Fund 290)", "root" },
                    { new Guid("85e267a0-a4dc-439d-8895-f0083cbd8d01"), new DateTimeOffset(new DateTime(2025, 2, 6, 6, 50, 24, 683, DateTimeKind.Unspecified).AddTicks(3333), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 6, 6, 50, 24, 683, DateTimeKind.Unspecified).AddTicks(3333), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("f0770a04-79f8-488e-b674-d1dde98e8079"), "State", "root" },
                    { new Guid("86d92cd6-ad63-4d8c-b283-4e1e01c8186b"), new DateTimeOffset(new DateTime(2025, 5, 21, 23, 7, 52, 464, DateTimeKind.Unspecified).AddTicks(7269), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 21, 23, 7, 52, 464, DateTimeKind.Unspecified).AddTicks(7269), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("18b298cd-91de-4b10-ae36-3bafd0ec02e8"), "Sanitary Sewer Utility", "root" },
                    { new Guid("870cf565-d498-4d15-89a7-71f29aaedacd"), new DateTimeOffset(new DateTime(2025, 2, 18, 5, 59, 27, 296, DateTimeKind.Unspecified).AddTicks(5294), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 2, 48, 29, 114, DateTimeKind.Unspecified).AddTicks(6895), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("7590f78d-2412-47a6-81b3-4c3acc462b14"), "Sent to Finance", "root" },
                    { new Guid("8767103b-e15f-4015-bed9-5c1d303cbcf0"), new DateTimeOffset(new DateTime(2025, 2, 19, 7, 37, 39, 843, DateTimeKind.Unspecified).AddTicks(148), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 19, 7, 37, 39, 843, DateTimeKind.Unspecified).AddTicks(148), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("720119db-c9f6-442b-abd4-6dc1271e7ee1"), "New", "root" },
                    { new Guid("87c33308-18f1-43c3-a2f4-a8ee0ae83a6c"), new DateTimeOffset(new DateTime(2025, 5, 26, 23, 58, 43, 470, DateTimeKind.Unspecified).AddTicks(233), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 23, 58, 43, 470, DateTimeKind.Unspecified).AddTicks(233), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("5516c30d-7a89-419e-be1b-0e5cb64f01ea"), "6 - City Vision Downtown", "root" },
                    { new Guid("886758d2-4624-4cd0-bcd9-5a1636497bec"), new DateTimeOffset(new DateTime(2025, 5, 26, 5, 59, 34, 407, DateTimeKind.Unspecified).AddTicks(2635), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 5, 59, 34, 407, DateTimeKind.Unspecified).AddTicks(2635), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("2fbf3c72-e26f-4db8-a5de-180bc862d79e"), "General - Library Operating Budget (Dept 520)", "root" },
                    { new Guid("8910c16f-8f87-411c-b2f8-45ab52e4307e"), new DateTimeOffset(new DateTime(2025, 5, 26, 5, 54, 17, 940, DateTimeKind.Unspecified).AddTicks(6707), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 5, 54, 17, 940, DateTimeKind.Unspecified).AddTicks(6707), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("2c4caa8d-544b-4393-82be-9a5b7c221117"), "TIF Bonds/Notes: 9 - International Business Park", "root" },
                    { new Guid("894c5acf-eb82-4286-b7cc-018c7db7731a"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 19, 27, 727, DateTimeKind.Unspecified).AddTicks(8492), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 19, 27, 727, DateTimeKind.Unspecified).AddTicks(8492), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "VICTIMS OF CRIME GRANT (VOCA) (Fund 546)", "root" },
                    { new Guid("89dde96e-1acf-4ae2-8541-7a51c1f6a4ee"), new DateTimeOffset(new DateTime(2025, 2, 19, 6, 50, 36, 331, DateTimeKind.Unspecified).AddTicks(7237), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 19, 6, 50, 36, 331, DateTimeKind.Unspecified).AddTicks(7237), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("e2bc2f40-b296-48b6-bfaa-faf91bd5539e"), "8", "root" },
                    { new Guid("89f91d8d-0afd-495d-a920-eb47323980b6"), new DateTimeOffset(new DateTime(2025, 5, 22, 1, 6, 7, 422, DateTimeKind.Unspecified).AddTicks(1853), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 1, 6, 7, 422, DateTimeKind.Unspecified).AddTicks(1853), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("b4fe9e53-b0cc-4a8b-89d7-712bfc97ac24"), "Increased Safety", "root" },
                    { new Guid("8a0261b2-a7b9-451d-960b-a3f5c40590bd"), new DateTimeOffset(new DateTime(2025, 5, 22, 17, 19, 53, 727, DateTimeKind.Unspecified).AddTicks(9365), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 17, 19, 53, 727, DateTimeKind.Unspecified).AddTicks(9365), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("c1353eb7-87ca-4cca-9d5c-f87bd4ae97c8"), "Fire", "root" },
                    { new Guid("8a58750f-d1a1-4e8a-a0d5-e9f0ec1cb5a8"), new DateTimeOffset(new DateTime(2025, 2, 19, 7, 36, 27, 684, DateTimeKind.Unspecified).AddTicks(8395), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 19, 7, 36, 33, 49, DateTimeKind.Unspecified).AddTicks(3775), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("26b6536f-76d3-47db-b395-2a758802bd13"), "Route Changes", "root" },
                    { new Guid("8ae0bb3e-5c2d-4ccf-9351-e8aaddd3d528"), new DateTimeOffset(new DateTime(2025, 5, 26, 2, 56, 9, 308, DateTimeKind.Unspecified).AddTicks(6312), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 2, 56, 9, 308, DateTimeKind.Unspecified).AddTicks(6312), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("00316b5b-16ab-480a-8974-50f0f6dd97fe"), "Plan and Dev - Public Art", "root" },
                    { new Guid("8bb68ec9-48f1-4cd4-8825-0a4074aa5d20"), new DateTimeOffset(new DateTime(2025, 5, 22, 1, 17, 41, 987, DateTimeKind.Unspecified).AddTicks(7124), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 1, 17, 41, 987, DateTimeKind.Unspecified).AddTicks(7124), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("cf4a4d66-6ced-43f2-959d-613c2fa2110d"), "Board of Public Works", "root" },
                    { new Guid("8c0fe778-ba0c-4b14-af97-cdff2319e29d"), new DateTimeOffset(new DateTime(2025, 5, 26, 5, 52, 48, 292, DateTimeKind.Unspecified).AddTicks(2337), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 5, 52, 48, 292, DateTimeKind.Unspecified).AddTicks(2337), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("2c4caa8d-544b-4393-82be-9a5b7c221117"), "TIF Bonds/Notes: 10 - Park Plaza", "root" },
                    { new Guid("8c3daad9-f8ee-43f1-9edf-7b5079c93cba"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 5, 17, 565, DateTimeKind.Unspecified).AddTicks(9516), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 5, 17, 565, DateTimeKind.Unspecified).AddTicks(9516), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("1881c517-32e2-4c09-8bd2-09e2efe7dc61"), "TID Increment: 17 - Lot C Downtown", "root" },
                    { new Guid("8da7deb3-2171-40d8-baf4-676572d10085"), new DateTimeOffset(new DateTime(2025, 5, 22, 17, 24, 16, 826, DateTimeKind.Unspecified).AddTicks(7187), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 17, 24, 16, 826, DateTimeKind.Unspecified).AddTicks(7187), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("c1353eb7-87ca-4cca-9d5c-f87bd4ae97c8"), "Information Technology", "root" },
                    { new Guid("8f9e1cf6-9420-4451-939c-ae01b72ba943"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 10, 50, 723, DateTimeKind.Unspecified).AddTicks(2325), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 10, 50, 723, DateTimeKind.Unspecified).AddTicks(2325), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "COPELAND PARK IMPROVEMENT (Fund 212)", "root" },
                    { new Guid("908e4dda-3536-4095-b58e-a408d36ca6e0"), new DateTimeOffset(new DateTime(2025, 3, 19, 13, 27, 2, 428, DateTimeKind.Unspecified).AddTicks(7173), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 3, 19, 13, 27, 2, 428, DateTimeKind.Unspecified).AddTicks(7173), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("93985952-4e53-4b3d-a897-8bec835d8d42"), "Rejected by Finance", "root" },
                    { new Guid("90f46a55-8f73-4718-93b2-fb5704b0f71b"), new DateTimeOffset(new DateTime(2025, 5, 26, 23, 58, 48, 136, DateTimeKind.Unspecified).AddTicks(9514), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 23, 58, 48, 136, DateTimeKind.Unspecified).AddTicks(9514), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("5516c30d-7a89-419e-be1b-0e5cb64f01ea"), "7 - Amtrak Depot", "root" },
                    { new Guid("9179d50e-9fa0-495f-8b82-b773d23b3b02"), new DateTimeOffset(new DateTime(2025, 5, 22, 1, 6, 26, 662, DateTimeKind.Unspecified).AddTicks(7710), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 1, 6, 26, 662, DateTimeKind.Unspecified).AddTicks(7710), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("b4fe9e53-b0cc-4a8b-89d7-712bfc97ac24"), "In Kind/Grant", "root" },
                    { new Guid("91c3944d-ac19-4fb2-b340-21f640630065"), new DateTimeOffset(new DateTime(2025, 5, 21, 22, 58, 1, 133, DateTimeKind.Unspecified).AddTicks(6201), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 21, 22, 58, 1, 133, DateTimeKind.Unspecified).AddTicks(6201), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("18b298cd-91de-4b10-ae36-3bafd0ec02e8"), "Grounds and Buildings", "root" },
                    { new Guid("92c48777-180f-47bc-b762-812da9a3d311"), new DateTimeOffset(new DateTime(2025, 5, 22, 17, 11, 32, 405, DateTimeKind.Unspecified).AddTicks(7642), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 17, 11, 32, 405, DateTimeKind.Unspecified).AddTicks(7642), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("3c78d7af-5305-4138-9038-be7425fcecb2"), "Board of Public Works", "root" },
                    { new Guid("930b2160-0eb3-4c81-80c4-d9f6794a511f"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 9, 40, 60, DateTimeKind.Unspecified).AddTicks(7184), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 9, 40, 60, DateTimeKind.Unspecified).AddTicks(7184), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "BOAT LANDING IMPROVEMENTS (Fund 514)", "root" },
                    { new Guid("933f9a7e-4ca3-472a-8ef3-4fb4ac07bb59"), new DateTimeOffset(new DateTime(2025, 2, 6, 6, 50, 4, 210, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 6, 6, 50, 4, 210, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("18b298cd-91de-4b10-ae36-3bafd0ec02e8"), "Assesor's Office", "root" },
                    { new Guid("9409e34f-a2dd-4334-97f4-48507864b1f1"), new DateTimeOffset(new DateTime(2025, 2, 20, 5, 7, 3, 808, DateTimeKind.Unspecified).AddTicks(5727), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 20, 5, 7, 13, 557, DateTimeKind.Unspecified).AddTicks(400), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("5516c30d-7a89-419e-be1b-0e5cb64f01ea"), "12 - Three Rivers Plaza", "root" },
                    { new Guid("94e8a8ea-96e9-4756-bff2-b70a819310d1"), new DateTimeOffset(new DateTime(2025, 6, 13, 2, 12, 11, 645, DateTimeKind.Unspecified).AddTicks(4113), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 6, 13, 2, 12, 11, 645, DateTimeKind.Unspecified).AddTicks(4113), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("2c4caa8d-544b-4393-82be-9a5b7c221117"), "Loan: State Trust Fund", "root" },
                    { new Guid("95581d66-8687-4a75-bf39-e711af9955c5"), new DateTimeOffset(new DateTime(2025, 5, 21, 22, 57, 46, 620, DateTimeKind.Unspecified).AddTicks(7853), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 21, 22, 57, 46, 620, DateTimeKind.Unspecified).AddTicks(7853), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("18b298cd-91de-4b10-ae36-3bafd0ec02e8"), "Finance", "root" },
                    { new Guid("9592ac30-88bb-4451-88e5-478685d45fbb"), new DateTimeOffset(new DateTime(2025, 5, 26, 5, 49, 23, 988, DateTimeKind.Unspecified).AddTicks(1401), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 5, 49, 23, 988, DateTimeKind.Unspecified).AddTicks(1401), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("e0dd3254-0249-4f71-8c70-36063346ad72"), "TIF Bonds/Notes: 11 - Gateway Redevelopment", "root" },
                    { new Guid("95a118a2-154b-4a2f-acc2-92865494f5a1"), new DateTimeOffset(new DateTime(2025, 5, 22, 6, 52, 56, 530, DateTimeKind.Unspecified).AddTicks(4917), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 6, 52, 56, 530, DateTimeKind.Unspecified).AddTicks(4917), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("b44e86cb-1388-4c3f-ae4c-94d3df4f662b"), "General - Finance Operating Budget (Dept 340)", "root" },
                    { new Guid("961dc7a6-60e2-41a8-9827-a22185e9dbb9"), new DateTimeOffset(new DateTime(2025, 5, 26, 2, 49, 3, 413, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 2, 49, 3, 413, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("7590f78d-2412-47a6-81b3-4c3acc462b14"), "Archived", "root" },
                    { new Guid("9625b0bf-a0ab-4a72-9c13-1265984c819f"), new DateTimeOffset(new DateTime(2025, 5, 26, 5, 51, 1, 181, DateTimeKind.Unspecified).AddTicks(4401), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 5, 51, 1, 181, DateTimeKind.Unspecified).AddTicks(4401), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("e0dd3254-0249-4f71-8c70-36063346ad72"), "TIF Bonds/Notes: 6 - City Vision Downtown", "root" },
                    { new Guid("967902e0-6ea3-40f4-97e7-7d02d681b238"), new DateTimeOffset(new DateTime(2025, 5, 22, 6, 51, 49, 663, DateTimeKind.Unspecified).AddTicks(9703), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 6, 51, 49, 663, DateTimeKind.Unspecified).AddTicks(9703), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("b44e86cb-1388-4c3f-ae4c-94d3df4f662b"), "General - Human Resources Operating Budget (Dept 790)", "root" },
                    { new Guid("98d9a98b-64d8-4ada-89b3-77910ce41c0a"), new DateTimeOffset(new DateTime(2025, 5, 22, 17, 10, 17, 505, DateTimeKind.Unspecified).AddTicks(774), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 17, 16, 45, 242, DateTimeKind.Unspecified).AddTicks(7884), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("95f8e0c2-b1dd-44b4-aa66-09f63efddc48"), "2025-Finance CPC Draft", "root" },
                    { new Guid("99859e55-a855-4754-8c02-2fdae538a8a5"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 58, 27, 675, DateTimeKind.Unspecified).AddTicks(9014), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 58, 27, 675, DateTimeKind.Unspecified).AddTicks(9014), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"), "Planning and Community Development - Neighborhoods", "root" },
                    { new Guid("99ad0e07-8288-453b-b693-ac673a9335be"), new DateTimeOffset(new DateTime(2025, 5, 21, 1, 42, 46, 958, DateTimeKind.Unspecified).AddTicks(1632), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 21, 1, 42, 46, 958, DateTimeKind.Unspecified).AddTicks(1632), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("e0dd3254-0249-4f71-8c70-36063346ad72"), "Revenue Bonds/Notes: Sanitary Sewer Utility", "root" },
                    { new Guid("99e267e8-48c6-4fe3-999f-9e8599717b22"), new DateTimeOffset(new DateTime(2025, 2, 6, 6, 49, 30, 563, DateTimeKind.Unspecified).AddTicks(3333), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 18, 6, 41, 48, 411, DateTimeKind.Unspecified).AddTicks(726), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("93985952-4e53-4b3d-a897-8bec835d8d42"), "Sent to Finance", "root" },
                    { new Guid("9a776989-8997-4644-be82-ad6055bb83c5"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 13, 30, 485, DateTimeKind.Unspecified).AddTicks(2906), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 13, 30, 485, DateTimeKind.Unspecified).AddTicks(2906), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "LA CROSSE CENTER (Fund 201)", "root" },
                    { new Guid("9a78b288-1880-44c9-af24-ba26abb1c339"), new DateTimeOffset(new DateTime(2025, 5, 26, 7, 0, 58, 340, DateTimeKind.Unspecified).AddTicks(9264), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 7, 0, 58, 340, DateTimeKind.Unspecified).AddTicks(9264), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"), "Streetscaping - Boulevard Trees", "root" },
                    { new Guid("9a91d388-d3dd-4614-846b-4b79a68538f5"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 3, 49, 612, DateTimeKind.Unspecified).AddTicks(6028), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 3, 49, 612, DateTimeKind.Unspecified).AddTicks(6028), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("1881c517-32e2-4c09-8bd2-09e2efe7dc61"), "La Crosse Center Surplus Funds", "root" },
                    { new Guid("9ac2f7c8-dfc8-4b34-92d7-3a060b4099c3"), new DateTimeOffset(new DateTime(2025, 2, 19, 7, 2, 4, 729, DateTimeKind.Unspecified).AddTicks(5360), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 55, 6, 458, DateTimeKind.Unspecified).AddTicks(5658), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"), "Airport - Runways and Taxiways", "root" },
                    { new Guid("9b1638a0-115d-4267-9c2e-9d111758a89a"), new DateTimeOffset(new DateTime(2025, 5, 26, 2, 56, 59, 696, DateTimeKind.Unspecified).AddTicks(6459), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 2, 56, 59, 696, DateTimeKind.Unspecified).AddTicks(6459), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("00316b5b-16ab-480a-8974-50f0f6dd97fe"), "Trans and Utils - Joint Projects", "root" },
                    { new Guid("9c057e97-e9dd-465b-94a3-55032419e168"), new DateTimeOffset(new DateTime(2025, 2, 18, 1, 36, 43, 214, DateTimeKind.Unspecified).AddTicks(2293), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 18, 1, 36, 43, 214, DateTimeKind.Unspecified).AddTicks(2293), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("c1353eb7-87ca-4cca-9d5c-f87bd4ae97c8"), "Airport", "root" },
                    { new Guid("9c6342d4-8721-4bec-bc5d-0d57c4bfb52f"), new DateTimeOffset(new DateTime(2025, 5, 22, 17, 31, 12, 556, DateTimeKind.Unspecified).AddTicks(4740), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 17, 31, 12, 556, DateTimeKind.Unspecified).AddTicks(4740), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("76fc224c-bc0a-4458-bf43-bfd8db3a0b83"), "Flottmeyer, James", "root" },
                    { new Guid("9cdfbffd-2693-4a1a-81e3-f2bad59e7c54"), new DateTimeOffset(new DateTime(2025, 2, 6, 6, 50, 14, 693, DateTimeKind.Unspecified).AddTicks(3333), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 5, 47, 43, 715, DateTimeKind.Unspecified).AddTicks(6835), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("e0dd3254-0249-4f71-8c70-36063346ad72"), "General Obligation Bonds/Notes", "root" },
                    { new Guid("9d3d9753-c75d-4d2d-a714-b9496b6bfc90"), new DateTimeOffset(new DateTime(2025, 5, 26, 5, 57, 49, 803, DateTimeKind.Unspecified).AddTicks(6382), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 5, 57, 49, 803, DateTimeKind.Unspecified).AddTicks(6382), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("2fbf3c72-e26f-4db8-a5de-180bc862d79e"), "General - Attorney Operating Budget (Dept 140)", "root" },
                    { new Guid("9e05b1b3-f7c7-490d-a832-8ab1a3789797"), new DateTimeOffset(new DateTime(2025, 5, 26, 7, 1, 16, 731, DateTimeKind.Unspecified).AddTicks(5012), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 7, 1, 16, 731, DateTimeKind.Unspecified).AddTicks(5012), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"), "Technology Hardware and Software", "root" },
                    { new Guid("9e56af7b-971b-4f27-9d4c-ad6e70d7e3bb"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 10, 5, 291, DateTimeKind.Unspecified).AddTicks(1508), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 10, 5, 291, DateTimeKind.Unspecified).AddTicks(1508), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "CDBG PROGRAM AND OTHER INCOME (Fund 2060)", "root" },
                    { new Guid("9e9d7fd2-1878-45c3-8719-2761d68421a4"), new DateTimeOffset(new DateTime(2025, 2, 26, 12, 47, 37, 396, DateTimeKind.Unspecified).AddTicks(3627), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 26, 12, 47, 55, 639, DateTimeKind.Unspecified).AddTicks(7901), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("449aa104-a5aa-43c4-8552-5aa69aa69960"), "200 - GOLF COURSE", "root" },
                    { new Guid("a09472e6-e8ce-4b43-aded-b939f77c6d7c"), new DateTimeOffset(new DateTime(2025, 2, 25, 5, 3, 46, 561, DateTimeKind.Unspecified).AddTicks(1726), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 25, 5, 3, 46, 561, DateTimeKind.Unspecified).AddTicks(1726), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("c4121504-a142-4624-9c71-8764661893aa"), "Under Review", "root" },
                    { new Guid("a0ff5f63-b7dd-4841-ac44-d6ca5756e6ad"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 10, 32, 220, DateTimeKind.Unspecified).AddTicks(918), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 10, 32, 220, DateTimeKind.Unspecified).AddTicks(918), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "COMMUNITY POL PLAN (FGRTLCL) (Fund 519)", "root" },
                    { new Guid("a104fc5c-a458-4845-aba4-10984a7698b3"), new DateTimeOffset(new DateTime(2025, 5, 22, 17, 47, 39, 321, DateTimeKind.Unspecified).AddTicks(2889), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 17, 47, 39, 321, DateTimeKind.Unspecified).AddTicks(2889), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("db09f0d8-49fe-41af-99a3-01c0d498d8de"), "Planning/Design", "root" },
                    { new Guid("a15af204-9184-448c-aa37-d01a95861696"), new DateTimeOffset(new DateTime(2025, 5, 22, 17, 27, 53, 3, DateTimeKind.Unspecified).AddTicks(2302), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 17, 27, 53, 3, DateTimeKind.Unspecified).AddTicks(2302), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("c1353eb7-87ca-4cca-9d5c-f87bd4ae97c8"), "City Council", "root" },
                    { new Guid("a2377ed7-e86b-46d2-8ef8-a0b4e534f936"), new DateTimeOffset(new DateTime(2025, 5, 21, 1, 43, 2, 790, DateTimeKind.Unspecified).AddTicks(8820), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 21, 1, 43, 2, 790, DateTimeKind.Unspecified).AddTicks(8820), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("e0dd3254-0249-4f71-8c70-36063346ad72"), "Revenue Bonds/Notes: Water Utility", "root" },
                    { new Guid("a2411943-1d1e-4c45-a481-06084c50cc7a"), new DateTimeOffset(new DateTime(2025, 2, 18, 1, 37, 47, 83, DateTimeKind.Unspecified).AddTicks(9667), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 18, 1, 37, 47, 83, DateTimeKind.Unspecified).AddTicks(9667), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("449aa104-a5aa-43c4-8552-5aa69aa69960"), "101 - LA CROSSE CENTER", "root" },
                    { new Guid("a2778e7a-22bb-4f58-a1b7-69d75d4e1297"), new DateTimeOffset(new DateTime(2025, 2, 6, 6, 49, 50, 650, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 6, 6, 49, 50, 650, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("41e3334c-a1be-4c55-a21c-8540053b458e"), "High", "root" },
                    { new Guid("a3156d0f-f884-44d4-b635-1e22700d6b6d"), new DateTimeOffset(new DateTime(2025, 2, 19, 6, 50, 3, 785, DateTimeKind.Unspecified).AddTicks(3192), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 19, 6, 50, 3, 785, DateTimeKind.Unspecified).AddTicks(3192), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("e2bc2f40-b296-48b6-bfaa-faf91bd5539e"), "0", "root" },
                    { new Guid("a3faa5e4-dc96-4485-b52f-c75b57d885b5"), new DateTimeOffset(new DateTime(2025, 2, 20, 6, 35, 19, 612, DateTimeKind.Unspecified).AddTicks(4191), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 20, 6, 35, 19, 612, DateTimeKind.Unspecified).AddTicks(4191), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("5516c30d-7a89-419e-be1b-0e5cb64f01ea"), "15 - Chart", "root" },
                    { new Guid("a4d141a6-9b6c-4a04-97e7-13660c8c04b6"), new DateTimeOffset(new DateTime(2025, 5, 22, 6, 50, 26, 975, DateTimeKind.Unspecified).AddTicks(875), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 6, 50, 26, 975, DateTimeKind.Unspecified).AddTicks(875), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("b44e86cb-1388-4c3f-ae4c-94d3df4f662b"), "General - Parks, Recreation and Forestry Operating Budget (Dept 761)", "root" },
                    { new Guid("a5dd86fb-7b65-4f5e-85b5-59d3688bb428"), new DateTimeOffset(new DateTime(2025, 5, 26, 2, 47, 9, 564, DateTimeKind.Unspecified).AddTicks(1080), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 2, 47, 9, 564, DateTimeKind.Unspecified).AddTicks(1080), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("3c78d7af-5305-4138-9038-be7425fcecb2"), "Library Board", "root" },
                    { new Guid("a6c2f440-5305-4181-88f8-ceba034d2932"), new DateTimeOffset(new DateTime(2025, 5, 26, 5, 57, 56, 816, DateTimeKind.Unspecified).AddTicks(4665), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 5, 57, 56, 816, DateTimeKind.Unspecified).AddTicks(4665), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("2fbf3c72-e26f-4db8-a5de-180bc862d79e"), "General - Clerks Operating Budget (Dept 220)", "root" },
                    { new Guid("a6d06abc-9184-4af4-8ecf-adfced498680"), new DateTimeOffset(new DateTime(2025, 5, 26, 2, 56, 29, 753, DateTimeKind.Unspecified).AddTicks(147), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 2, 56, 29, 753, DateTimeKind.Unspecified).AddTicks(147), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("00316b5b-16ab-480a-8974-50f0f6dd97fe"), "Public Safety - Police", "root" },
                    { new Guid("a77e9ec5-c7a8-43d7-8484-478f5abf6c1d"), new DateTimeOffset(new DateTime(2025, 5, 26, 2, 47, 38, 925, DateTimeKind.Unspecified).AddTicks(1307), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 2, 47, 38, 925, DateTimeKind.Unspecified).AddTicks(1307), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("3c78d7af-5305-4138-9038-be7425fcecb2"), "Redevelopment Authority", "root" },
                    { new Guid("a7a4219d-e994-4de9-942c-a45f29175d47"), new DateTimeOffset(new DateTime(2025, 2, 19, 6, 50, 20, 559, DateTimeKind.Unspecified).AddTicks(6340), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 19, 6, 50, 20, 559, DateTimeKind.Unspecified).AddTicks(6340), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("e2bc2f40-b296-48b6-bfaa-faf91bd5539e"), "4", "root" },
                    { new Guid("a7a9428c-7db7-427c-aa78-4e21e5accfa2"), new DateTimeOffset(new DateTime(2025, 5, 22, 6, 48, 37, 813, DateTimeKind.Unspecified).AddTicks(5816), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 6, 48, 37, 813, DateTimeKind.Unspecified).AddTicks(5816), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("b44e86cb-1388-4c3f-ae4c-94d3df4f662b"), "General - Special Appropriations Operating Budget (Dept 423)", "root" },
                    { new Guid("a7aadc3b-f8bd-48be-8590-897b991bb54e"), new DateTimeOffset(new DateTime(2025, 5, 26, 7, 0, 45, 649, DateTimeKind.Unspecified).AddTicks(3355), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 7, 0, 45, 649, DateTimeKind.Unspecified).AddTicks(3355), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"), "Streets - Total Street Reconstruction", "root" },
                    { new Guid("a86bd8a2-c386-45a9-af33-0a4805a4c813"), new DateTimeOffset(new DateTime(2025, 5, 21, 5, 34, 15, 958, DateTimeKind.Unspecified).AddTicks(3314), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 21, 5, 34, 15, 958, DateTimeKind.Unspecified).AddTicks(3314), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("f0770a04-79f8-488e-b674-d1dde98e8079"), "Unknown", "root" },
                    { new Guid("a88e3137-f923-4c93-8151-b8a1d6141943"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 19, 9, 713, DateTimeKind.Unspecified).AddTicks(6363), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 19, 9, 713, DateTimeKind.Unspecified).AddTicks(6363), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "UPPER FLOOR RENOVATION (Fund 577)", "root" },
                    { new Guid("aa33fcb6-3725-4ee5-a12e-1054b15e8cd0"), new DateTimeOffset(new DateTime(2025, 5, 21, 23, 8, 9, 405, DateTimeKind.Unspecified).AddTicks(7465), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 21, 23, 8, 9, 405, DateTimeKind.Unspecified).AddTicks(7465), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("18b298cd-91de-4b10-ae36-3bafd0ec02e8"), "Streets", "root" },
                    { new Guid("aa75b19d-d635-4f1e-aa7c-a309e6abc669"), new DateTimeOffset(new DateTime(2025, 2, 6, 6, 49, 50, 653, DateTimeKind.Unspecified).AddTicks(3333), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 6, 6, 49, 50, 653, DateTimeKind.Unspecified).AddTicks(3333), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("41e3334c-a1be-4c55-a21c-8540053b458e"), "Not Applicable", "root" },
                    { new Guid("aa83a537-d4b8-45ae-948d-4120b5793cb2"), new DateTimeOffset(new DateTime(2025, 5, 22, 17, 28, 29, 466, DateTimeKind.Unspecified).AddTicks(4291), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 17, 28, 29, 466, DateTimeKind.Unspecified).AddTicks(4291), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("76fc224c-bc0a-4458-bf43-bfd8db3a0b83"), "Greschner, Jacky", "root" },
                    { new Guid("aa9b7c05-1750-4187-a183-282c393c21df"), new DateTimeOffset(new DateTime(2025, 2, 19, 7, 37, 33, 5, DateTimeKind.Unspecified).AddTicks(7772), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 19, 7, 37, 33, 5, DateTimeKind.Unspecified).AddTicks(7772), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("720119db-c9f6-442b-abd4-6dc1271e7ee1"), "Infill", "root" },
                    { new Guid("aac3d084-98a2-43cb-a7dc-177be6e1102c"), new DateTimeOffset(new DateTime(2025, 5, 22, 17, 19, 33, 108, DateTimeKind.Unspecified).AddTicks(3941), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 17, 19, 33, 108, DateTimeKind.Unspecified).AddTicks(3941), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("c1353eb7-87ca-4cca-9d5c-f87bd4ae97c8"), "Community Development and Housing", "root" },
                    { new Guid("aaecf3c9-5fcd-4190-a1c7-c9ad93d3aec4"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 16, 27, 897, DateTimeKind.Unspecified).AddTicks(4216), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 16, 27, 897, DateTimeKind.Unspecified).AddTicks(4216), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "POLICE EMERGENCY RESPONSE TEAM (Fund 528)", "root" },
                    { new Guid("ab16b4f6-68a3-4324-994b-3af1986c4989"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 58, 33, 354, DateTimeKind.Unspecified).AddTicks(7507), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 58, 33, 354, DateTimeKind.Unspecified).AddTicks(7507), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"), "Police Stations", "root" },
                    { new Guid("abc2ec60-4c08-413a-b6a7-02dde63108be"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 0, 38, 654, DateTimeKind.Unspecified).AddTicks(8160), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 0, 38, 654, DateTimeKind.Unspecified).AddTicks(8160), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("2fbf3c72-e26f-4db8-a5de-180bc862d79e"), "General - Special Appropriations Operating Budget (Dept 423)", "root" },
                    { new Guid("ac24f415-d398-4371-8be1-9c5f9ac3d9d9"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 0, 26, 441, DateTimeKind.Unspecified).AddTicks(5680), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 0, 26, 441, DateTimeKind.Unspecified).AddTicks(5680), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("2fbf3c72-e26f-4db8-a5de-180bc862d79e"), "General - Refuse and Recycling Operating Budget (Dept 886)", "root" },
                    { new Guid("ac541d16-4247-4ee9-b268-13841d66857d"), new DateTimeOffset(new DateTime(2025, 5, 22, 1, 18, 51, 684, DateTimeKind.Unspecified).AddTicks(3685), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 1, 18, 51, 684, DateTimeKind.Unspecified).AddTicks(3685), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("cf4a4d66-6ced-43f2-959d-613c2fa2110d"), "Judiciary & Administration Committee", "root" },
                    { new Guid("ac8946a4-4794-4bdd-9e36-b424a019d2b1"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 55, 26, 698, DateTimeKind.Unspecified).AddTicks(6021), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 55, 26, 698, DateTimeKind.Unspecified).AddTicks(6021), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"), "Alleys", "root" },
                    { new Guid("acc71dcc-922a-4e69-a4a2-fdcd374ec58b"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 3, 56, 301, DateTimeKind.Unspecified).AddTicks(3226), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 3, 56, 301, DateTimeKind.Unspecified).AddTicks(3226), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("1881c517-32e2-4c09-8bd2-09e2efe7dc61"), "Library Trustee Funds", "root" },
                    { new Guid("ad41d752-558b-4952-9629-10d219f62df2"), new DateTimeOffset(new DateTime(2025, 2, 19, 7, 36, 19, 539, DateTimeKind.Unspecified).AddTicks(1180), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 19, 7, 36, 19, 539, DateTimeKind.Unspecified).AddTicks(1180), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("26b6536f-76d3-47db-b395-2a758802bd13"), "Enlargement", "root" },
                    { new Guid("ad489041-62e0-4317-b9c8-4798e1eeb70d"), new DateTimeOffset(new DateTime(2025, 6, 17, 0, 43, 24, 5, DateTimeKind.Unspecified).AddTicks(8745), new TimeSpan(0, 0, 0, 0, 0)), new Guid("69694165-d62e-4fba-9262-814877732f5e"), null, null, true, new DateTimeOffset(new DateTime(2025, 6, 17, 0, 43, 24, 5, DateTimeKind.Unspecified).AddTicks(8745), new TimeSpan(0, 0, 0, 0, 0)), new Guid("69694165-d62e-4fba-9262-814877732f5e"), new Guid("b44e86cb-1388-4c3f-ae4c-94d3df4f662b"), "Utility - Sanitary Sewer Utility Funds (Fund 630)", "root" },
                    { new Guid("ad6a4186-0d6e-4fdb-a5f2-1d78756a2f91"), new DateTimeOffset(new DateTime(2025, 5, 21, 23, 4, 34, 37, DateTimeKind.Unspecified).AddTicks(1742), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 21, 23, 4, 34, 37, DateTimeKind.Unspecified).AddTicks(1742), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("18b298cd-91de-4b10-ae36-3bafd0ec02e8"), "Mayor", "root" },
                    { new Guid("ae24dd4d-c5a1-4e17-b649-5dc231ed508a"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 9, 59, 93, DateTimeKind.Unspecified).AddTicks(3956), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 9, 59, 93, DateTimeKind.Unspecified).AddTicks(3956), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "CAPITAL PROJ REIMB FOR DEBT (Fund 215)", "root" },
                    { new Guid("ae7a4657-f92e-4dd2-9617-4bc369dde239"), new DateTimeOffset(new DateTime(2025, 5, 26, 2, 47, 26, 460, DateTimeKind.Unspecified).AddTicks(4067), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 2, 47, 26, 460, DateTimeKind.Unspecified).AddTicks(4067), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("3c78d7af-5305-4138-9038-be7425fcecb2"), "Neighborhood Revitalization Commission", "root" },
                    { new Guid("aeae193f-6ee4-441c-abe1-0f7281fef36b"), new DateTimeOffset(new DateTime(2025, 2, 6, 6, 49, 39, 870, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 6, 6, 49, 39, 870, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("910fb5e3-80a0-4a46-b616-8cb94f56e86f"), "Equipment and Tools", "root" },
                    { new Guid("aeccecae-c036-4268-9709-6c2aaf32e859"), new DateTimeOffset(new DateTime(2025, 5, 26, 5, 53, 26, 773, DateTimeKind.Unspecified).AddTicks(4953), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 5, 53, 26, 773, DateTimeKind.Unspecified).AddTicks(4953), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("2c4caa8d-544b-4393-82be-9a5b7c221117"), "TIF Bonds/Notes: 15 - Chart", "root" },
                    { new Guid("af3c5e84-4b67-4268-a99a-c4817e5a0936"), new DateTimeOffset(new DateTime(2025, 2, 19, 6, 50, 24, 458, DateTimeKind.Unspecified).AddTicks(1089), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 19, 6, 50, 24, 458, DateTimeKind.Unspecified).AddTicks(1089), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("e2bc2f40-b296-48b6-bfaa-faf91bd5539e"), "5", "root" },
                    { new Guid("af46d003-cd67-46b7-a3bb-02ea968cf6d8"), new DateTimeOffset(new DateTime(2025, 5, 22, 6, 50, 55, 93, DateTimeKind.Unspecified).AddTicks(7380), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 6, 50, 55, 93, DateTimeKind.Unspecified).AddTicks(7380), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("b44e86cb-1388-4c3f-ae4c-94d3df4f662b"), "General - Mayor Operating Budget (Dept 550)", "root" },
                    { new Guid("af629b26-f793-4859-b474-b17ddc8519c9"), new DateTimeOffset(new DateTime(2025, 2, 28, 11, 13, 11, 921, DateTimeKind.Unspecified).AddTicks(472), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 28, 11, 13, 11, 921, DateTimeKind.Unspecified).AddTicks(472), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("aef1cf33-b160-4229-a360-691194d2336b"), "Test Funding Changes", "root" },
                    { new Guid("b124d5f8-2160-46b7-8a83-6ae83500e314"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 5, 46, 509, DateTimeKind.Unspecified).AddTicks(5638), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 5, 46, 509, DateTimeKind.Unspecified).AddTicks(5638), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("1881c517-32e2-4c09-8bd2-09e2efe7dc61"), "TID Increment: 9 - International Business Park", "root" },
                    { new Guid("b2193b96-593f-4628-89af-3261df5d82ab"), new DateTimeOffset(new DateTime(2025, 3, 19, 13, 28, 9, 807, DateTimeKind.Unspecified).AddTicks(2860), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 3, 19, 13, 28, 9, 807, DateTimeKind.Unspecified).AddTicks(2860), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("93985952-4e53-4b3d-a897-8bec835d8d42"), "Archived", "root" },
                    { new Guid("b2373446-0fb5-427d-a2b1-f05077e8ff74"), new DateTimeOffset(new DateTime(2025, 2, 6, 6, 55, 29, 673, DateTimeKind.Unspecified).AddTicks(3333), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 6, 6, 55, 29, 673, DateTimeKind.Unspecified).AddTicks(3333), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("ecc83d3f-910a-4d5c-a8fe-25014b9544d6"), "Developer Capital Contributions", "root" },
                    { new Guid("b2a953c6-1d94-44d3-b0a0-abf0da366b5c"), new DateTimeOffset(new DateTime(2025, 2, 19, 7, 35, 51, 323, DateTimeKind.Unspecified).AddTicks(164), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 19, 7, 35, 51, 323, DateTimeKind.Unspecified).AddTicks(164), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("13b9f0c2-c3b3-4b76-b238-1582ecfc81e8"), "Street Department", "root" },
                    { new Guid("b2cbe997-8d47-4892-846e-e12a2ca06863"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 56, 57, 594, DateTimeKind.Unspecified).AddTicks(6392), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 56, 57, 594, DateTimeKind.Unspecified).AddTicks(6392), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"), "Floodplain Improvements", "root" },
                    { new Guid("b2d39a9d-6eaf-4b6a-a438-5a9b5f299480"), new DateTimeOffset(new DateTime(2025, 5, 26, 2, 54, 12, 416, DateTimeKind.Unspecified).AddTicks(9510), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 2, 54, 12, 416, DateTimeKind.Unspecified).AddTicks(9510), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("00316b5b-16ab-480a-8974-50f0f6dd97fe"), "Flood Control - Harbors and Waterfront", "root" },
                    { new Guid("b37f08fc-5977-4f41-adb4-5717a0a271e4"), new DateTimeOffset(new DateTime(2025, 5, 26, 5, 59, 41, 864, DateTimeKind.Unspecified).AddTicks(1845), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 5, 59, 41, 864, DateTimeKind.Unspecified).AddTicks(1845), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("2fbf3c72-e26f-4db8-a5de-180bc862d79e"), "General - Mayor Operating Budget (Dept 550)", "root" },
                    { new Guid("b40f76f3-ff28-4806-ae7b-ff6cb211e2d9"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 57, 17, 856, DateTimeKind.Unspecified).AddTicks(3765), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 57, 17, 856, DateTimeKind.Unspecified).AddTicks(3765), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"), "Infrastructure - Special Projects", "root" },
                    { new Guid("b560cbfd-171e-4dda-b189-f9b2a8d0ab88"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 56, 9, 384, DateTimeKind.Unspecified).AddTicks(2025), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 56, 9, 384, DateTimeKind.Unspecified).AddTicks(2025), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"), "Economic Development - Other", "root" },
                    { new Guid("b597dad4-e94a-4acf-8ecf-3436cf5e96b9"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 15, 12, 247, DateTimeKind.Unspecified).AddTicks(1305), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 15, 12, 247, DateTimeKind.Unspecified).AddTicks(1305), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "PARK TREE MEMORIALS (Fund 511)", "root" },
                    { new Guid("b6cacdd0-7813-49ad-ac7b-41f1705c53f7"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 57, 24, 149, DateTimeKind.Unspecified).AddTicks(6846), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 57, 24, 149, DateTimeKind.Unspecified).AddTicks(6846), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"), "Parking Utility", "root" },
                    { new Guid("b6d091b6-22b8-42a1-b6d0-3f022fc1df3e"), new DateTimeOffset(new DateTime(2025, 2, 25, 2, 7, 19, 709, DateTimeKind.Unspecified).AddTicks(9066), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 25, 2, 7, 19, 709, DateTimeKind.Unspecified).AddTicks(9066), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("d2b40805-4186-4088-ac14-16be43330171"), "Sub Detail 2", "root" },
                    { new Guid("b755d8be-e91c-4b73-9b25-2f961ad186b0"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 18, 3, 792, DateTimeKind.Unspecified).AddTicks(4453), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 18, 3, 792, DateTimeKind.Unspecified).AddTicks(4453), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "RIVERSIDE REDEVELOPMENT (Fund 2040)", "root" },
                    { new Guid("b762e092-2e35-4eb9-aaf4-59c9a3996d31"), new DateTimeOffset(new DateTime(2025, 2, 28, 11, 11, 48, 955, DateTimeKind.Unspecified).AddTicks(2637), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 5, 51, 53, 22, DateTimeKind.Unspecified).AddTicks(8561), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("2c4caa8d-544b-4393-82be-9a5b7c221117"), "General Obligation Bonds/Notes", "root" },
                    { new Guid("b7d057b1-c45e-46da-b759-86583d276795"), new DateTimeOffset(new DateTime(2025, 5, 22, 6, 51, 21, 798, DateTimeKind.Unspecified).AddTicks(1450), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 6, 51, 21, 798, DateTimeKind.Unspecified).AddTicks(1450), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("b44e86cb-1388-4c3f-ae4c-94d3df4f662b"), "General - IT Operating Budget (Dept 580)", "root" },
                    { new Guid("b87c6e65-a210-4b5f-8919-1006947bec22"), new DateTimeOffset(new DateTime(2025, 2, 18, 5, 59, 17, 755, DateTimeKind.Unspecified).AddTicks(1449), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 2, 48, 19, 191, DateTimeKind.Unspecified).AddTicks(9003), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("7590f78d-2412-47a6-81b3-4c3acc462b14"), "Entered by Department", "root" },
                    { new Guid("b8b96d7d-4918-428f-ba65-cd118bf7d63b"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 1, 26, 649, DateTimeKind.Unspecified).AddTicks(2686), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 1, 26, 649, DateTimeKind.Unspecified).AddTicks(2686), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("2fbf3c72-e26f-4db8-a5de-180bc862d79e"), "Utility - Storm Water Utility Funds (Fund 650)", "root" },
                    { new Guid("b8e8cbc4-6b74-4c50-a098-1046a9ba00be"), new DateTimeOffset(new DateTime(2025, 5, 22, 17, 48, 53, 647, DateTimeKind.Unspecified).AddTicks(9088), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 17, 48, 53, 647, DateTimeKind.Unspecified).AddTicks(9088), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("db09f0d8-49fe-41af-99a3-01c0d498d8de"), "Other", "root" },
                    { new Guid("b9023a7d-6e41-4b04-8867-ad0ce39f763e"), new DateTimeOffset(new DateTime(2025, 5, 22, 1, 19, 57, 842, DateTimeKind.Unspecified).AddTicks(8248), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 1, 19, 57, 842, DateTimeKind.Unspecified).AddTicks(8248), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("cf4a4d66-6ced-43f2-959d-613c2fa2110d"), "Police and Fire Commission", "root" },
                    { new Guid("ba336f14-cef5-40c1-852e-05ca301b4cae"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 11, 12, 316, DateTimeKind.Unspecified).AddTicks(927), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 11, 12, 316, DateTimeKind.Unspecified).AddTicks(927), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "FIRE DEPT EMS SERVICES (Fund 242)", "root" },
                    { new Guid("bb1bf163-f14c-4eef-9d0c-96a5ed9640cc"), new DateTimeOffset(new DateTime(2025, 2, 19, 14, 33, 50, 645, DateTimeKind.Unspecified).AddTicks(9401), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 28, 10, 55, 4, 287, DateTimeKind.Unspecified).AddTicks(5651), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("0f4e03dc-0ead-41ad-93a9-26b0b6a0af3a"), "Test Change Type", "root" },
                    { new Guid("bb81a609-e0e8-4334-a904-ecdd493c24f4"), new DateTimeOffset(new DateTime(2025, 5, 21, 5, 35, 22, 486, DateTimeKind.Unspecified).AddTicks(7286), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 21, 5, 35, 22, 486, DateTimeKind.Unspecified).AddTicks(7286), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("b44e86cb-1388-4c3f-ae4c-94d3df4f662b"), "General - Assessor Operating Budget (Dept 130)", "root" },
                    { new Guid("bba146f3-f1df-4cab-8f8c-f59f43fe855d"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 17, 24, 691, DateTimeKind.Unspecified).AddTicks(4542), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 17, 24, 691, DateTimeKind.Unspecified).AddTicks(4542), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "POLICE SECURITY (Fund 530)", "root" },
                    { new Guid("bbfe42e4-5e7e-4aae-805f-aaa3bedae890"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 7, 51, 467, DateTimeKind.Unspecified).AddTicks(1081), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 7, 51, 467, DateTimeKind.Unspecified).AddTicks(1081), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "2016 CDBG (Fund 2259)", "root" },
                    { new Guid("bc0601a6-fb89-4575-bb24-4510bb9e853f"), new DateTimeOffset(new DateTime(2025, 5, 22, 6, 52, 5, 888, DateTimeKind.Unspecified).AddTicks(560), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 6, 52, 5, 888, DateTimeKind.Unspecified).AddTicks(560), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("b44e86cb-1388-4c3f-ae4c-94d3df4f662b"), "General - Grounds and Building Operating Budget (Dept 882)", "root" },
                    { new Guid("bc7ddfed-45f6-45e2-a227-8f0d74bb10ec"), new DateTimeOffset(new DateTime(2025, 2, 6, 6, 53, 39, 973, DateTimeKind.Unspecified).AddTicks(3333), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 6, 6, 53, 39, 973, DateTimeKind.Unspecified).AddTicks(3333), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("93985952-4e53-4b3d-a897-8bec835d8d42"), "Entered by Department", "root" },
                    { new Guid("bd09f22b-676e-4864-8fb3-f64c348194ac"), new DateTimeOffset(new DateTime(2025, 5, 26, 5, 51, 15, 912, DateTimeKind.Unspecified).AddTicks(1523), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 5, 51, 15, 912, DateTimeKind.Unspecified).AddTicks(1523), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("e0dd3254-0249-4f71-8c70-36063346ad72"), "TIF Bonds/Notes: 7 - Amtrak Depot", "root" },
                    { new Guid("bd8fb4fb-6550-4a54-acd6-973387859d0a"), new DateTimeOffset(new DateTime(2025, 2, 28, 5, 49, 43, 414, DateTimeKind.Unspecified).AddTicks(5366), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 28, 5, 49, 43, 414, DateTimeKind.Unspecified).AddTicks(5366), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("95f8e0c2-b1dd-44b4-aa66-09f63efddc48"), "Test 2 Change Set", "root" },
                    { new Guid("bdaa6217-cac1-4926-86c3-a696ea3fec28"), new DateTimeOffset(new DateTime(2025, 5, 26, 5, 57, 22, 515, DateTimeKind.Unspecified).AddTicks(3053), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 5, 57, 22, 515, DateTimeKind.Unspecified).AddTicks(3053), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("2fbf3c72-e26f-4db8-a5de-180bc862d79e"), "Enterprise - Car Rental Facility Charges", "root" },
                    { new Guid("bea45c1e-2488-4f86-b99a-e52c73709815"), new DateTimeOffset(new DateTime(2025, 2, 17, 0, 54, 2, 941, DateTimeKind.Unspecified).AddTicks(1654), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 21, 14, 33, 11, 471, DateTimeKind.Unspecified).AddTicks(434), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("18b298cd-91de-4b10-ae36-3bafd0ec02e8"), "Water Utility", "root" },
                    { new Guid("bef6f460-9964-495b-bd77-581cb0c39e6d"), new DateTimeOffset(new DateTime(2025, 2, 6, 6, 50, 9, 376, DateTimeKind.Unspecified).AddTicks(6667), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 1, 17, 21, 188, DateTimeKind.Unspecified).AddTicks(3269), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("cf4a4d66-6ced-43f2-959d-613c2fa2110d"), "Arts Board", "root" },
                    { new Guid("bf06be8a-b314-4c20-875f-ff917751f9b6"), new DateTimeOffset(new DateTime(2025, 2, 6, 6, 55, 29, 670, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 6, 6, 55, 29, 670, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("ecc83d3f-910a-4d5c-a8fe-25014b9544d6"), "Donations", "root" },
                    { new Guid("bf4d0de5-b5ee-4bbf-9bc0-f23df6d5965b"), new DateTimeOffset(new DateTime(2025, 5, 21, 23, 7, 32, 723, DateTimeKind.Unspecified).AddTicks(27), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 21, 23, 7, 32, 723, DateTimeKind.Unspecified).AddTicks(27), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("18b298cd-91de-4b10-ae36-3bafd0ec02e8"), "Police", "root" },
                    { new Guid("c0b5063d-44bf-42e9-8dde-4ebadbe79391"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 57, 11, 408, DateTimeKind.Unspecified).AddTicks(9783), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 57, 11, 408, DateTimeKind.Unspecified).AddTicks(9783), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"), "Housing Rehabilitation", "root" },
                    { new Guid("c148a4af-fdc0-4e0e-a1c9-e5f97a137755"), new DateTimeOffset(new DateTime(2025, 5, 22, 17, 27, 16, 903, DateTimeKind.Unspecified).AddTicks(7744), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 17, 27, 16, 903, DateTimeKind.Unspecified).AddTicks(7744), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("c1353eb7-87ca-4cca-9d5c-f87bd4ae97c8"), "Stormwater Utility", "root" },
                    { new Guid("c1739a03-f189-47c1-ab15-b9b23255fe5b"), new DateTimeOffset(new DateTime(2025, 5, 26, 2, 49, 11, 105, DateTimeKind.Unspecified).AddTicks(4758), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 2, 49, 11, 105, DateTimeKind.Unspecified).AddTicks(4758), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("7590f78d-2412-47a6-81b3-4c3acc462b14"), "Requires Department Review", "root" },
                    { new Guid("c1b908c3-f68c-412d-b1ad-218ad84352c8"), new DateTimeOffset(new DateTime(2025, 5, 26, 5, 55, 5, 300, DateTimeKind.Unspecified).AddTicks(3546), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 5, 55, 5, 300, DateTimeKind.Unspecified).AddTicks(3546), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("eb07f930-9e73-4cda-a9eb-98c4ec2a2afc"), "State", "root" },
                    { new Guid("c29b655c-8ebe-4cc0-abab-1e304c3d6471"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 55, 19, 74, DateTimeKind.Unspecified).AddTicks(39), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 55, 19, 74, DateTimeKind.Unspecified).AddTicks(39), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"), "Airport - Terminal", "root" },
                    { new Guid("c36239b5-adfa-4600-931b-0ec805e638a3"), new DateTimeOffset(new DateTime(2025, 5, 26, 7, 1, 37, 67, DateTimeKind.Unspecified).AddTicks(3903), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 7, 1, 37, 67, DateTimeKind.Unspecified).AddTicks(3903), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"), "Water - Watermains", "root" },
                    { new Guid("c47da043-47d4-40d9-97b4-72349b3f07e9"), new DateTimeOffset(new DateTime(2025, 5, 26, 5, 58, 25, 779, DateTimeKind.Unspecified).AddTicks(8796), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 5, 58, 25, 779, DateTimeKind.Unspecified).AddTicks(8796), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("2fbf3c72-e26f-4db8-a5de-180bc862d79e"), "General - Engineering Operating Budget (Dept 881)", "root" },
                    { new Guid("c51b7da1-eb46-4503-ae59-ab54f491024a"), new DateTimeOffset(new DateTime(2025, 5, 26, 2, 48, 54, 541, DateTimeKind.Unspecified).AddTicks(3017), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 2, 48, 54, 541, DateTimeKind.Unspecified).AddTicks(3017), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("7590f78d-2412-47a6-81b3-4c3acc462b14"), "Withdrawn by Department", "root" },
                    { new Guid("c540b166-5e6d-4223-86a2-f2aa676ad022"), new DateTimeOffset(new DateTime(2025, 5, 21, 5, 35, 39, 833, DateTimeKind.Unspecified).AddTicks(5354), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 21, 5, 35, 39, 833, DateTimeKind.Unspecified).AddTicks(5354), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("b44e86cb-1388-4c3f-ae4c-94d3df4f662b"), "General - Contingency Operating Budget (Dept 250)", "root" },
                    { new Guid("c5830631-95bd-48bb-b493-7a71bacfcb79"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 12, 21, 289, DateTimeKind.Unspecified).AddTicks(7226), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 12, 21, 289, DateTimeKind.Unspecified).AddTicks(7226), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "GREEN ISLAND ICE ARENA IMPROVE (Fund 239)", "root" },
                    { new Guid("c591ab48-c851-4bf5-8efc-9961d24741bb"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 18, 12, 311, DateTimeKind.Unspecified).AddTicks(1995), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 18, 12, 311, DateTimeKind.Unspecified).AddTicks(1995), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "SCULPTURE (Fund 559)", "root" },
                    { new Guid("c5b89a28-8659-4bda-9d63-580200f55d32"), new DateTimeOffset(new DateTime(2025, 5, 21, 22, 58, 27, 349, DateTimeKind.Unspecified).AddTicks(9818), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 21, 22, 58, 27, 349, DateTimeKind.Unspecified).AddTicks(9818), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("18b298cd-91de-4b10-ae36-3bafd0ec02e8"), "Information Technology", "root" },
                    { new Guid("c646d35d-2549-4356-b3ed-3e38122becd8"), new DateTimeOffset(new DateTime(2025, 2, 19, 6, 50, 16, 635, DateTimeKind.Unspecified).AddTicks(8239), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 19, 6, 50, 16, 635, DateTimeKind.Unspecified).AddTicks(8239), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("e2bc2f40-b296-48b6-bfaa-faf91bd5539e"), "3", "root" },
                    { new Guid("c670e351-520f-40e0-a0fc-22bdd4bc364a"), new DateTimeOffset(new DateTime(2025, 5, 26, 2, 55, 7, 967, DateTimeKind.Unspecified).AddTicks(4839), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 2, 55, 7, 967, DateTimeKind.Unspecified).AddTicks(4839), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("00316b5b-16ab-480a-8974-50f0f6dd97fe"), "La Crosse Center", "root" },
                    { new Guid("c6dc63b7-0fc4-4c13-896f-26a95a367ebf"), new DateTimeOffset(new DateTime(2025, 2, 28, 5, 42, 39, 835, DateTimeKind.Unspecified).AddTicks(8683), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 28, 5, 42, 39, 835, DateTimeKind.Unspecified).AddTicks(8683), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("db09f0d8-49fe-41af-99a3-01c0d498d8de"), "Test Spending Purpose", "root" },
                    { new Guid("c7436917-afea-42ba-9723-e2e143a2ff91"), new DateTimeOffset(new DateTime(2025, 5, 22, 6, 49, 18, 413, DateTimeKind.Unspecified).AddTicks(2419), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 6, 49, 18, 413, DateTimeKind.Unspecified).AddTicks(2419), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("b44e86cb-1388-4c3f-ae4c-94d3df4f662b"), "General - Refuse and Recycling Operating Budget (Dept 886)", "root" },
                    { new Guid("c7baa91b-0bfa-4313-8aeb-d608d6dc3ce0"), new DateTimeOffset(new DateTime(2025, 5, 22, 17, 24, 56, 307, DateTimeKind.Unspecified).AddTicks(7472), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 17, 24, 56, 307, DateTimeKind.Unspecified).AddTicks(7472), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("c1353eb7-87ca-4cca-9d5c-f87bd4ae97c8"), "Mayor", "root" },
                    { new Guid("c7f0e84d-ac32-42f8-99a6-eefe624687db"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 1, 41, 621, DateTimeKind.Unspecified).AddTicks(7275), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 1, 41, 621, DateTimeKind.Unspecified).AddTicks(7275), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("2fbf3c72-e26f-4db8-a5de-180bc862d79e"), "Utilty - Sanitary Sewer Utility Funds (Fund 630)", "root" },
                    { new Guid("c8286cc1-4863-4459-986a-4fce8f0af9a1"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 0, 47, 288, DateTimeKind.Unspecified).AddTicks(3089), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 0, 47, 288, DateTimeKind.Unspecified).AddTicks(3089), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("2fbf3c72-e26f-4db8-a5de-180bc862d79e"), "General - Streets Operating Budget (Dept 883)", "root" },
                    { new Guid("c85b7ec0-09ac-49bd-81bb-ecea97e782a8"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 59, 36, 203, DateTimeKind.Unspecified).AddTicks(5242), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 59, 36, 203, DateTimeKind.Unspecified).AddTicks(5242), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"), "Public Buildings - Pump House", "root" },
                    { new Guid("c872f859-dc0e-4df4-91e4-53388687a349"), new DateTimeOffset(new DateTime(2025, 2, 19, 6, 50, 40, 176, DateTimeKind.Unspecified).AddTicks(7264), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 19, 6, 50, 40, 176, DateTimeKind.Unspecified).AddTicks(7264), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("e2bc2f40-b296-48b6-bfaa-faf91bd5539e"), "9", "root" },
                    { new Guid("c8add5b3-ee01-49d0-b903-fcae3b460aa2"), new DateTimeOffset(new DateTime(2025, 5, 22, 1, 18, 11, 756, DateTimeKind.Unspecified).AddTicks(7134), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 1, 18, 11, 756, DateTimeKind.Unspecified).AddTicks(7134), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("cf4a4d66-6ced-43f2-959d-613c2fa2110d"), "Economic Development Commission", "root" },
                    { new Guid("c8d68beb-771f-4bd2-885e-5b3a0ac4ed66"), new DateTimeOffset(new DateTime(2025, 2, 20, 5, 6, 27, 153, DateTimeKind.Unspecified).AddTicks(9557), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 20, 5, 6, 27, 153, DateTimeKind.Unspecified).AddTicks(9557), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("5516c30d-7a89-419e-be1b-0e5cb64f01ea"), "10 - Park Plaza", "root" },
                    { new Guid("c90134c5-8afb-41ca-9a57-781a066c3ea2"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 14, 30, 974, DateTimeKind.Unspecified).AddTicks(3100), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 14, 30, 974, DateTimeKind.Unspecified).AddTicks(3100), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "MUNICIPAL COURT TRUST (Fund 506)", "root" },
                    { new Guid("c912687d-ef31-4ed9-843d-f9b7050f7d42"), new DateTimeOffset(new DateTime(2025, 2, 19, 12, 17, 21, 253, DateTimeKind.Unspecified).AddTicks(8917), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 2, 44, 34, 312, DateTimeKind.Unspecified).AddTicks(6154), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("3c78d7af-5305-4138-9038-be7425fcecb2"), "(None)", "root" },
                    { new Guid("c9319d11-55f9-4877-9db0-f582c5d60e43"), new DateTimeOffset(new DateTime(2025, 5, 22, 6, 50, 10, 636, DateTimeKind.Unspecified).AddTicks(5396), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 6, 50, 10, 636, DateTimeKind.Unspecified).AddTicks(5396), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("b44e86cb-1388-4c3f-ae4c-94d3df4f662b"), "General - Planning Operating Budget (Dept 820)", "root" },
                    { new Guid("ca978126-4a2f-4541-a78e-56a59b35d07a"), new DateTimeOffset(new DateTime(2025, 5, 26, 2, 57, 34, 863, DateTimeKind.Unspecified).AddTicks(536), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 2, 57, 34, 863, DateTimeKind.Unspecified).AddTicks(536), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("00316b5b-16ab-480a-8974-50f0f6dd97fe"), "Trans and Utils - Transit", "root" },
                    { new Guid("caed32da-ff03-4a32-bad1-b9484088729d"), new DateTimeOffset(new DateTime(2025, 5, 22, 17, 30, 40, 562, DateTimeKind.Unspecified).AddTicks(6367), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 17, 30, 40, 562, DateTimeKind.Unspecified).AddTicks(6367), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("76fc224c-bc0a-4458-bf43-bfd8db3a0b83"), "Trussoni, Dan", "root" },
                    { new Guid("cb0dd839-c113-4324-8145-c1b67807815a"), new DateTimeOffset(new DateTime(2025, 2, 19, 14, 38, 56, 926, DateTimeKind.Unspecified).AddTicks(2955), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 19, 14, 38, 56, 926, DateTimeKind.Unspecified).AddTicks(2955), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("76fc224c-bc0a-4458-bf43-bfd8db3a0b83"), "Jack", "root" },
                    { new Guid("cb152177-58e4-472e-bf4a-05980411f382"), new DateTimeOffset(new DateTime(2025, 5, 26, 5, 52, 55, 674, DateTimeKind.Unspecified).AddTicks(2980), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 5, 52, 55, 674, DateTimeKind.Unspecified).AddTicks(2980), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("2c4caa8d-544b-4393-82be-9a5b7c221117"), "TIF Bonds/Notes: 11 - Gateway Redevelopment", "root" },
                    { new Guid("cb75452b-0a64-4748-a89f-e19f474cd4f1"), new DateTimeOffset(new DateTime(2025, 5, 22, 6, 53, 24, 992, DateTimeKind.Unspecified).AddTicks(8480), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 6, 53, 24, 992, DateTimeKind.Unspecified).AddTicks(8480), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("b44e86cb-1388-4c3f-ae4c-94d3df4f662b"), "General - Council Operating Budget (Dept 280)", "root" },
                    { new Guid("cbb5d9d3-f018-4a9d-b8bb-aeca741bb4ca"), new DateTimeOffset(new DateTime(2025, 5, 26, 2, 58, 1, 492, DateTimeKind.Unspecified).AddTicks(7514), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 2, 58, 1, 492, DateTimeKind.Unspecified).AddTicks(7514), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("00316b5b-16ab-480a-8974-50f0f6dd97fe"), "Trans and Utils - Bridges", "root" },
                    { new Guid("cbb8d039-5643-4fc4-b287-8627068c52b0"), new DateTimeOffset(new DateTime(2025, 5, 22, 17, 13, 31, 870, DateTimeKind.Unspecified).AddTicks(4753), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 17, 13, 31, 870, DateTimeKind.Unspecified).AddTicks(4753), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("0f4e03dc-0ead-41ad-93a9-26b0b6a0af3a"), "Funding Adjusted", "root" },
                    { new Guid("cbcd5af8-7cce-464b-a352-a6fe5730463e"), new DateTimeOffset(new DateTime(2025, 5, 26, 5, 59, 15, 164, DateTimeKind.Unspecified).AddTicks(3157), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 5, 59, 15, 164, DateTimeKind.Unspecified).AddTicks(3157), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("2fbf3c72-e26f-4db8-a5de-180bc862d79e"), "General - Human Resources Operating Budget (Dept 790)", "root" },
                    { new Guid("cbe99014-230e-44d8-8f73-3ed3e9d9621e"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 58, 3, 361, DateTimeKind.Unspecified).AddTicks(3592), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 58, 3, 361, DateTimeKind.Unspecified).AddTicks(3592), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"), "Parks - Recreation Facilities", "root" },
                    { new Guid("cbfe409b-c838-4264-916a-cba1b894f9fd"), new DateTimeOffset(new DateTime(2025, 2, 19, 7, 2, 4, 726, DateTimeKind.Unspecified).AddTicks(5378), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 55, 42, 727, DateTimeKind.Unspecified).AddTicks(188), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"), "Arts", "root" },
                    { new Guid("cca5fb20-2c38-4955-b3d5-bb7a408a35fc"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 58, 16, 107, DateTimeKind.Unspecified).AddTicks(1452), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 58, 16, 107, DateTimeKind.Unspecified).AddTicks(1452), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"), "Parks - Trails", "root" },
                    { new Guid("ccd6df9a-7592-4f0a-a247-ceab980799f9"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 10, 56, 580, DateTimeKind.Unspecified).AddTicks(9760), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 10, 56, 580, DateTimeKind.Unspecified).AddTicks(9760), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "COUNTY CONTRIBUTIONS FOR AIRPT (Fund 219)", "root" },
                    { new Guid("ccda628e-8435-41e1-a300-84559fac17dc"), new DateTimeOffset(new DateTime(2025, 5, 22, 17, 14, 21, 326, DateTimeKind.Unspecified).AddTicks(672), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 17, 14, 21, 326, DateTimeKind.Unspecified).AddTicks(672), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("0f4e03dc-0ead-41ad-93a9-26b0b6a0af3a"), "Request Removed", "root" },
                    { new Guid("ccf40f54-60b9-4244-a678-1ff27b172f50"), new DateTimeOffset(new DateTime(2025, 5, 26, 2, 47, 18, 810, DateTimeKind.Unspecified).AddTicks(225), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 2, 47, 18, 810, DateTimeKind.Unspecified).AddTicks(225), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("3c78d7af-5305-4138-9038-be7425fcecb2"), "Municipal Transit Utility Board", "root" },
                    { new Guid("cd049916-d292-4380-975a-c8cbe02374e5"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 7, 57, 406, DateTimeKind.Unspecified).AddTicks(1354), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 7, 57, 406, DateTimeKind.Unspecified).AddTicks(1354), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "2016 HOME (Fund 2729)", "root" },
                    { new Guid("cd7f7b93-f325-45f4-87bf-a54ae215de18"), new DateTimeOffset(new DateTime(2025, 5, 22, 1, 18, 43, 418, DateTimeKind.Unspecified).AddTicks(1257), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 1, 18, 43, 418, DateTimeKind.Unspecified).AddTicks(1257), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("cf4a4d66-6ced-43f2-959d-613c2fa2110d"), "Housing Rehabilitation Committee", "root" },
                    { new Guid("ce2b6d47-7e23-4c9a-ab7b-65328b112a67"), new DateTimeOffset(new DateTime(2025, 5, 22, 17, 27, 41, 398, DateTimeKind.Unspecified).AddTicks(1194), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 17, 27, 41, 398, DateTimeKind.Unspecified).AddTicks(1194), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("c1353eb7-87ca-4cca-9d5c-f87bd4ae97c8"), "Water Utility", "root" },
                    { new Guid("ce330a1c-43fc-4d78-ae42-8ad075b2afcd"), new DateTimeOffset(new DateTime(2025, 2, 19, 7, 35, 18, 101, DateTimeKind.Unspecified).AddTicks(2427), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 19, 7, 35, 18, 101, DateTimeKind.Unspecified).AddTicks(2427), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("49921477-b361-4299-8fcb-5ec327ddf57c"), "Poor", "root" },
                    { new Guid("cecb3cbf-e6ed-4c4f-9dda-4b2b5ed06ebc"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 9, 15, 784, DateTimeKind.Unspecified).AddTicks(852), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 9, 15, 784, DateTimeKind.Unspecified).AddTicks(852), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "BIKE RODEO (Fund 520)", "root" },
                    { new Guid("cfe6d9f0-e3ae-4db5-a75f-8a651ba6c420"), new DateTimeOffset(new DateTime(2025, 5, 22, 1, 18, 0, 885, DateTimeKind.Unspecified).AddTicks(7554), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 1, 18, 0, 885, DateTimeKind.Unspecified).AddTicks(7554), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("cf4a4d66-6ced-43f2-959d-613c2fa2110d"), "Common Council", "root" },
                    { new Guid("d010102d-b0bc-4b8a-99d7-8cdaa8cf6815"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 11, 32, 583, DateTimeKind.Unspecified).AddTicks(3398), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 11, 32, 583, DateTimeKind.Unspecified).AddTicks(3398), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "FIRE JUVENILE FIRESETTERS (Fund 224)", "root" },
                    { new Guid("d0c62b2b-da03-46f6-9233-837b1dbe260c"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 7, 22, 385, DateTimeKind.Unspecified).AddTicks(8079), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 7, 22, 385, DateTimeKind.Unspecified).AddTicks(8079), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "2013 HOME (Fund 2726)", "root" },
                    { new Guid("d13c8830-8c8b-4594-9b40-225dcf20b6f3"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 4, 50, 331, DateTimeKind.Unspecified).AddTicks(3703), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 4, 50, 331, DateTimeKind.Unspecified).AddTicks(3703), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("1881c517-32e2-4c09-8bd2-09e2efe7dc61"), "TID Increment: 13 - Kwik Trip", "root" },
                    { new Guid("d1ded914-5537-44fe-8060-edf929d5fa8a"), new DateTimeOffset(new DateTime(2025, 5, 26, 2, 59, 43, 641, DateTimeKind.Unspecified).AddTicks(779), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 2, 59, 43, 641, DateTimeKind.Unspecified).AddTicks(779), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("c4121504-a142-4624-9c71-8764661893aa"), "Needs Status", "root" },
                    { new Guid("d307f507-ac73-4ab4-a078-34a75f5d28ed"), new DateTimeOffset(new DateTime(2025, 2, 19, 6, 50, 12, 608, DateTimeKind.Unspecified).AddTicks(3836), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 19, 6, 50, 12, 608, DateTimeKind.Unspecified).AddTicks(3836), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("e2bc2f40-b296-48b6-bfaa-faf91bd5539e"), "2", "root" },
                    { new Guid("d3ae36c1-f060-4706-9872-cc000dd28e0e"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 9, 32, 756, DateTimeKind.Unspecified).AddTicks(1706), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 9, 32, 756, DateTimeKind.Unspecified).AddTicks(1706), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "BOAT HOUSE (Fund 209)", "root" },
                    { new Guid("d3bbdb33-2ffd-4892-8d86-4748d996e07a"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 18, 49, 670, DateTimeKind.Unspecified).AddTicks(845), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 18, 49, 670, DateTimeKind.Unspecified).AddTicks(845), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "TID APPLICATION FEES (Fund 583)", "root" },
                    { new Guid("d4044db2-3e76-4607-ac7c-11157f6d88ae"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 4, 10, 117, DateTimeKind.Unspecified).AddTicks(9822), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 4, 10, 117, DateTimeKind.Unspecified).AddTicks(9822), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("1881c517-32e2-4c09-8bd2-09e2efe7dc61"), "Reserve Fund Reduction", "root" },
                    { new Guid("d46f8771-7734-41a7-a37a-7aa14da4a711"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 15, 6, 903, DateTimeKind.Unspecified).AddTicks(5193), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 15, 6, 903, DateTimeKind.Unspecified).AddTicks(5193), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "PARK IMPROVEMENT (Fund 509)", "root" },
                    { new Guid("d4b3f515-0a2a-428a-be37-b95301eb48d3"), new DateTimeOffset(new DateTime(2025, 5, 22, 6, 49, 34, 459, DateTimeKind.Unspecified).AddTicks(3122), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 6, 49, 34, 459, DateTimeKind.Unspecified).AddTicks(3122), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("b44e86cb-1388-4c3f-ae4c-94d3df4f662b"), "General - Police/Fire Operating Budget (Dept 422)", "root" },
                    { new Guid("d53964be-851f-4cb1-be85-7dc051104c4f"), new DateTimeOffset(new DateTime(2025, 2, 10, 5, 33, 32, 433, DateTimeKind.Unspecified).AddTicks(3333), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 27, 1, 25, 58, 562, DateTimeKind.Unspecified).AddTicks(3123), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("08b0863c-ba0c-48f8-8702-06bbe6578170"), "Flottmeyer, James", "root" },
                    { new Guid("d53c5987-0225-4433-a019-0710d27074d3"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 16, 22, 492, DateTimeKind.Unspecified).AddTicks(3705), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 16, 22, 492, DateTimeKind.Unspecified).AddTicks(3705), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "POLICE DRUG INVESTIGATION (Fund 524)", "root" },
                    { new Guid("d5624254-dcad-45bd-ad70-f1897e257d53"), new DateTimeOffset(new DateTime(2025, 2, 19, 13, 12, 33, 740, DateTimeKind.Unspecified).AddTicks(1273), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 19, 13, 12, 33, 740, DateTimeKind.Unspecified).AddTicks(1273), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("c4121504-a142-4624-9c71-8764661893aa"), "In Progress", "root" },
                    { new Guid("d69598eb-dd86-4068-a79e-4b1abe1c6234"), new DateTimeOffset(new DateTime(2025, 5, 22, 17, 19, 17, 394, DateTimeKind.Unspecified).AddTicks(9171), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 17, 19, 17, 394, DateTimeKind.Unspecified).AddTicks(9171), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("c1353eb7-87ca-4cca-9d5c-f87bd4ae97c8"), "City Clerk", "root" },
                    { new Guid("d6a35e05-dc95-469b-8c71-ed35f78737b5"), new DateTimeOffset(new DateTime(2025, 5, 22, 6, 52, 34, 54, DateTimeKind.Unspecified).AddTicks(4539), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 6, 52, 34, 54, DateTimeKind.Unspecified).AddTicks(4539), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("b44e86cb-1388-4c3f-ae4c-94d3df4f662b"), "General - Fire Prevention and Building Safety Operating Budget (Dept 889)", "root" },
                    { new Guid("d75bc862-369b-4102-87f6-15887ca77cca"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 57, 30, 755, DateTimeKind.Unspecified).AddTicks(4531), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 57, 30, 755, DateTimeKind.Unspecified).AddTicks(4531), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"), "Parks - Aquatics Facilities", "root" },
                    { new Guid("d7e40cc8-af1e-49ed-aedb-84859960f879"), new DateTimeOffset(new DateTime(2025, 5, 21, 5, 36, 18, 665, DateTimeKind.Unspecified).AddTicks(5494), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 21, 5, 36, 18, 665, DateTimeKind.Unspecified).AddTicks(5494), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("b44e86cb-1388-4c3f-ae4c-94d3df4f662b"), "General - Engineering Operating Budget (Dept 881)", "root" },
                    { new Guid("d88c4739-3b34-4ea7-9e5b-eda997ff8b06"), new DateTimeOffset(new DateTime(2025, 5, 22, 6, 48, 15, 769, DateTimeKind.Unspecified).AddTicks(6678), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 6, 48, 15, 769, DateTimeKind.Unspecified).AddTicks(6678), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("b44e86cb-1388-4c3f-ae4c-94d3df4f662b"), "Unknown", "root" },
                    { new Guid("d9a9568f-035c-4b12-a2f6-2388c95fae1c"), new DateTimeOffset(new DateTime(2025, 5, 22, 6, 50, 41, 482, DateTimeKind.Unspecified).AddTicks(1094), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 6, 50, 41, 482, DateTimeKind.Unspecified).AddTicks(1094), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("b44e86cb-1388-4c3f-ae4c-94d3df4f662b"), "General - Municipal Court Operating Budget (Dept 670)", "root" },
                    { new Guid("da0a06f7-596f-446f-8f1c-57cb8d48195a"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 59, 15, 882, DateTimeKind.Unspecified).AddTicks(4062), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 59, 15, 882, DateTimeKind.Unspecified).AddTicks(4062), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"), "Public Buildings - Library", "root" },
                    { new Guid("da872400-f047-4b46-b6a4-c52f78a94752"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 12, 53, 931, DateTimeKind.Unspecified).AddTicks(3118), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 12, 53, 931, DateTimeKind.Unspecified).AddTicks(3118), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "HOME PROGRAM INCOME (Fund 2050)", "root" },
                    { new Guid("da8c313f-942c-4165-9040-e2c066794427"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 19, 33, 521, DateTimeKind.Unspecified).AddTicks(3930), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 19, 33, 521, DateTimeKind.Unspecified).AddTicks(3930), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "WI HAZMAT REGIONAL RESPONSE (Fund 234)", "root" },
                    { new Guid("db472c58-414b-45d4-8010-1b40953b69fb"), new DateTimeOffset(new DateTime(2025, 5, 26, 7, 0, 6, 343, DateTimeKind.Unspecified).AddTicks(7221), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 7, 0, 6, 343, DateTimeKind.Unspecified).AddTicks(7221), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"), "Storm Sewer/Stormwater - Lift Stations", "root" },
                    { new Guid("db5d6f13-be66-4791-a30b-239f06c23f56"), new DateTimeOffset(new DateTime(2025, 6, 17, 0, 42, 37, 465, DateTimeKind.Unspecified).AddTicks(3580), new TimeSpan(0, 0, 0, 0, 0)), new Guid("69694165-d62e-4fba-9262-814877732f5e"), null, null, true, new DateTimeOffset(new DateTime(2025, 6, 17, 0, 42, 37, 465, DateTimeKind.Unspecified).AddTicks(3580), new TimeSpan(0, 0, 0, 0, 0)), new Guid("69694165-d62e-4fba-9262-814877732f5e"), new Guid("b44e86cb-1388-4c3f-ae4c-94d3df4f662b"), "Utility - Storm Water Utility Funds (Fund 650)", "root" },
                    { new Guid("dc7b7096-68a4-42c8-80a4-c8699eb4ecb9"), new DateTimeOffset(new DateTime(2025, 2, 6, 6, 50, 34, 340, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 6, 6, 50, 34, 340, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("93a30161-93b4-4b47-81f4-021f3f27bb66"), "2011 CBDG (Fund 2254)", "root" },
                    { new Guid("dd544e13-d22a-4b07-bb58-4ca068674230"), new DateTimeOffset(new DateTime(2025, 5, 22, 17, 25, 9, 105, DateTimeKind.Unspecified).AddTicks(5363), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 17, 25, 9, 105, DateTimeKind.Unspecified).AddTicks(5363), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("c1353eb7-87ca-4cca-9d5c-f87bd4ae97c8"), "Municipal Court", "root" },
                    { new Guid("ddef33fc-55ab-4639-bbb0-001848e58400"), new DateTimeOffset(new DateTime(2025, 5, 22, 17, 26, 3, 351, DateTimeKind.Unspecified).AddTicks(1220), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 17, 26, 3, 351, DateTimeKind.Unspecified).AddTicks(1220), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("c1353eb7-87ca-4cca-9d5c-f87bd4ae97c8"), "Parks, Recreation & Forestry", "root" },
                    { new Guid("ded616df-779b-4144-8aa6-27f5ab28846d"), new DateTimeOffset(new DateTime(2025, 5, 26, 5, 59, 55, 848, DateTimeKind.Unspecified).AddTicks(6550), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 5, 59, 55, 848, DateTimeKind.Unspecified).AddTicks(6550), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("2fbf3c72-e26f-4db8-a5de-180bc862d79e"), "General - Parks, Recreation and Forestry Operating Budget (Dept 761)", "root" },
                    { new Guid("df295673-f749-464b-b862-90ef8573b339"), new DateTimeOffset(new DateTime(2025, 5, 22, 17, 27, 26, 87, DateTimeKind.Unspecified).AddTicks(7344), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 17, 27, 26, 87, DateTimeKind.Unspecified).AddTicks(7344), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("c1353eb7-87ca-4cca-9d5c-f87bd4ae97c8"), "Streets", "root" },
                    { new Guid("e06e61d5-ebc1-4dc1-8696-4e98affee785"), new DateTimeOffset(new DateTime(2025, 5, 26, 7, 1, 10, 771, DateTimeKind.Unspecified).AddTicks(9623), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 7, 1, 10, 771, DateTimeKind.Unspecified).AddTicks(9623), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"), "Streetscaping - Streetscaping", "root" },
                    { new Guid("e07824af-9be1-4416-bab8-3fd15591ff8e"), new DateTimeOffset(new DateTime(2025, 5, 26, 5, 50, 18, 765, DateTimeKind.Unspecified).AddTicks(9617), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 5, 50, 18, 765, DateTimeKind.Unspecified).AddTicks(9617), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("e0dd3254-0249-4f71-8c70-36063346ad72"), "TIF Bonds/Notes: 15 - Chart", "root" },
                    { new Guid("e0bac29c-0707-4dc7-8329-a7c26cfaab5d"), new DateTimeOffset(new DateTime(2025, 5, 22, 17, 20, 26, 312, DateTimeKind.Unspecified).AddTicks(9132), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 17, 20, 26, 312, DateTimeKind.Unspecified).AddTicks(9132), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("c1353eb7-87ca-4cca-9d5c-f87bd4ae97c8"), "Human Resources", "root" },
                    { new Guid("e13c26b4-4d8e-489b-9b41-5158ef958bc3"), new DateTimeOffset(new DateTime(2025, 5, 22, 17, 49, 11, 55, DateTimeKind.Unspecified).AddTicks(337), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 17, 49, 11, 55, DateTimeKind.Unspecified).AddTicks(337), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("db09f0d8-49fe-41af-99a3-01c0d498d8de"), "Equipment/Vehicles/Furnishings", "root" },
                    { new Guid("e13f0afb-8fa5-49dc-ae3c-a894bfbe8301"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 11, 38, 967, DateTimeKind.Unspecified).AddTicks(4754), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 11, 38, 967, DateTimeKind.Unspecified).AddTicks(4754), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "FIRE MISC GRANTS AND CONTRIB (Fund 287)", "root" },
                    { new Guid("e20f6181-e7ea-4e6f-8d60-9199e17c56a1"), new DateTimeOffset(new DateTime(2025, 5, 26, 2, 50, 30, 686, DateTimeKind.Unspecified).AddTicks(7047), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 2, 50, 30, 686, DateTimeKind.Unspecified).AddTicks(7047), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("00316b5b-16ab-480a-8974-50f0f6dd97fe"), "B and G - City Hall", "root" },
                    { new Guid("e296ed8c-a424-4f90-b77c-e169e6b7407b"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 9, 2, 382, DateTimeKind.Unspecified).AddTicks(1519), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 9, 2, 382, DateTimeKind.Unspecified).AddTicks(1519), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "ANIMAL LICENSE (Fund 235)", "root" },
                    { new Guid("e2d2c5d6-c47b-4737-ab4c-9e855eef1db8"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 11, 1, 556, DateTimeKind.Unspecified).AddTicks(3460), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 11, 1, 556, DateTimeKind.Unspecified).AddTicks(3460), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "EDWIN ERICKSON PARK (Fund 225)", "root" },
                    { new Guid("e360290b-3578-4b1a-b9c7-ea83432c2b5c"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 3, 28, 302, DateTimeKind.Unspecified).AddTicks(4990), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 3, 28, 302, DateTimeKind.Unspecified).AddTicks(4990), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("1881c517-32e2-4c09-8bd2-09e2efe7dc61"), "GENA Funds", "root" },
                    { new Guid("e3752f57-199d-457e-97d5-39e0a6b48ea7"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 3, 37, 16, DateTimeKind.Unspecified).AddTicks(7900), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 3, 37, 16, DateTimeKind.Unspecified).AddTicks(7900), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("1881c517-32e2-4c09-8bd2-09e2efe7dc61"), "Harbor Tenant Fees", "root" },
                    { new Guid("e4c3d301-7bc7-4162-b299-1799bd2177cd"), new DateTimeOffset(new DateTime(2025, 5, 26, 2, 54, 0, 179, DateTimeKind.Unspecified).AddTicks(4672), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 2, 54, 0, 179, DateTimeKind.Unspecified).AddTicks(4672), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("00316b5b-16ab-480a-8974-50f0f6dd97fe"), "Flood Control - Floodplain Control and Relief", "root" },
                    { new Guid("e53f00a8-8909-4831-b80f-ace0e5fb5fed"), new DateTimeOffset(new DateTime(2025, 5, 26, 2, 49, 19, 438, DateTimeKind.Unspecified).AddTicks(5161), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 2, 49, 19, 438, DateTimeKind.Unspecified).AddTicks(5161), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("7590f78d-2412-47a6-81b3-4c3acc462b14"), "Unfunded Request", "root" },
                    { new Guid("e58b113a-af81-4e14-9255-ee8ffb58f517"), new DateTimeOffset(new DateTime(2025, 5, 22, 17, 10, 38, 912, DateTimeKind.Unspecified).AddTicks(884), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 17, 16, 34, 425, DateTimeKind.Unspecified).AddTicks(6711), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("95f8e0c2-b1dd-44b4-aa66-09f63efddc48"), "2023-Department Submitted", "root" },
                    { new Guid("e664d54c-0a08-4963-b774-267f96e44b58"), new DateTimeOffset(new DateTime(2025, 5, 26, 2, 47, 0, 994, DateTimeKind.Unspecified).AddTicks(5528), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 2, 47, 0, 994, DateTimeKind.Unspecified).AddTicks(5528), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("3c78d7af-5305-4138-9038-be7425fcecb2"), "La Crosse Center Board", "root" },
                    { new Guid("e6807242-0442-4d83-979d-cb88575b2275"), new DateTimeOffset(new DateTime(2025, 5, 26, 2, 46, 32, 440, DateTimeKind.Unspecified).AddTicks(121), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 2, 46, 32, 440, DateTimeKind.Unspecified).AddTicks(121), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("3c78d7af-5305-4138-9038-be7425fcecb2"), "Economic Development Commission", "root" },
                    { new Guid("e6917750-4d58-48f7-beb1-3b9fcd470c0c"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 12, 59, 602, DateTimeKind.Unspecified).AddTicks(8047), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 12, 59, 602, DateTimeKind.Unspecified).AddTicks(8047), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "HOUSING REHABILITATION (Fund 2010)", "root" },
                    { new Guid("e6c00129-5326-4963-aab3-45a86106d368"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 59, 29, 840, DateTimeKind.Unspecified).AddTicks(5721), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 59, 29, 840, DateTimeKind.Unspecified).AddTicks(5721), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"), "Public Buildings - Other Buildings", "root" },
                    { new Guid("e76b426a-1cb1-4e75-a669-38b2bbd62638"), new DateTimeOffset(new DateTime(2025, 5, 26, 2, 55, 33, 684, DateTimeKind.Unspecified).AddTicks(5958), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 2, 55, 33, 684, DateTimeKind.Unspecified).AddTicks(5958), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("00316b5b-16ab-480a-8974-50f0f6dd97fe"), "Plan and Dev - Housing", "root" },
                    { new Guid("e8607c94-012b-4c7b-82fd-21d24111fbd5"), new DateTimeOffset(new DateTime(2025, 5, 26, 2, 46, 42, 187, DateTimeKind.Unspecified).AddTicks(2498), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 2, 46, 42, 187, DateTimeKind.Unspecified).AddTicks(2498), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("3c78d7af-5305-4138-9038-be7425fcecb2"), "Finance & Personnel Committee", "root" },
                    { new Guid("e8adfecd-31f8-4171-9201-c58b423f6b70"), new DateTimeOffset(new DateTime(2025, 5, 22, 1, 20, 15, 777, DateTimeKind.Unspecified).AddTicks(4996), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 1, 20, 15, 777, DateTimeKind.Unspecified).AddTicks(4996), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("cf4a4d66-6ced-43f2-959d-613c2fa2110d"), "Sustainable La Crosse Commission", "root" },
                    { new Guid("e8fa6365-fdef-4e04-aabd-3bef751f3755"), new DateTimeOffset(new DateTime(2025, 5, 26, 2, 50, 56, 293, DateTimeKind.Unspecified).AddTicks(618), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 2, 50, 56, 293, DateTimeKind.Unspecified).AddTicks(618), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("00316b5b-16ab-480a-8974-50f0f6dd97fe"), "B and G - Library", "root" },
                    { new Guid("e91fa235-a18d-47dc-8c9b-261f9212eba4"), new DateTimeOffset(new DateTime(2025, 5, 22, 17, 13, 1, 125, DateTimeKind.Unspecified).AddTicks(1176), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 17, 13, 1, 125, DateTimeKind.Unspecified).AddTicks(1176), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("0f4e03dc-0ead-41ad-93a9-26b0b6a0af3a"), "Funding Moved Up", "root" },
                    { new Guid("e939c5c2-fbeb-4c47-b0cc-f6fd78778480"), new DateTimeOffset(new DateTime(2025, 5, 26, 5, 49, 55, 862, DateTimeKind.Unspecified).AddTicks(4720), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 5, 49, 55, 862, DateTimeKind.Unspecified).AddTicks(4720), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("e0dd3254-0249-4f71-8c70-36063346ad72"), "TIF Bonds/Notes: 13 - Kwik Trip", "root" },
                    { new Guid("ea027f1a-0a20-446d-aa3d-36b46660e00f"), new DateTimeOffset(new DateTime(2025, 2, 20, 6, 36, 4, 325, DateTimeKind.Unspecified).AddTicks(9407), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 20, 6, 36, 4, 325, DateTimeKind.Unspecified).AddTicks(9407), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("5516c30d-7a89-419e-be1b-0e5cb64f01ea"), "17 - Lot C Downtown", "root" },
                    { new Guid("eb2174e8-80a7-4425-bca2-0d00813ea546"), new DateTimeOffset(new DateTime(2025, 2, 13, 6, 35, 8, 50, DateTimeKind.Unspecified).AddTicks(6840), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 13, 6, 35, 8, 50, DateTimeKind.Unspecified).AddTicks(6840), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("0224d7e1-5841-49c4-8dd1-1cb4791bc028"), "Group Second", "root" },
                    { new Guid("eb37fc7f-4447-443e-b060-214a702131ca"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 8, 36, 507, DateTimeKind.Unspecified).AddTicks(5532), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 8, 36, 507, DateTimeKind.Unspecified).AddTicks(5532), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "ADULT SPORTS NON-RESIDENT (Fund 510)", "root" },
                    { new Guid("eb879eb0-c554-4d0a-842d-32d04287293e"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 12, 26, 896, DateTimeKind.Unspecified).AddTicks(7689), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 12, 26, 896, DateTimeKind.Unspecified).AddTicks(7689), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "GREEN ISLAND LAND (Fund 240)", "root" },
                    { new Guid("ed9699e9-954b-458b-b875-87279bf0581e"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 4, 56, 380, DateTimeKind.Unspecified).AddTicks(1778), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 4, 56, 380, DateTimeKind.Unspecified).AddTicks(1778), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("1881c517-32e2-4c09-8bd2-09e2efe7dc61"), "TID Increment: 14 - Gundersen Lutheran", "root" },
                    { new Guid("ef0487ca-b7c9-4d3d-9e25-cfcae2a33c91"), new DateTimeOffset(new DateTime(2025, 5, 26, 2, 59, 27, 558, DateTimeKind.Unspecified).AddTicks(9614), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 2, 59, 27, 558, DateTimeKind.Unspecified).AddTicks(9614), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("c4121504-a142-4624-9c71-8764661893aa"), "Cancelled", "root" },
                    { new Guid("ef1abf7d-4624-42ac-810c-610d571e8cff"), new DateTimeOffset(new DateTime(2025, 5, 26, 5, 57, 30, 170, DateTimeKind.Unspecified).AddTicks(3808), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 5, 57, 30, 170, DateTimeKind.Unspecified).AddTicks(3808), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("2fbf3c72-e26f-4db8-a5de-180bc862d79e"), "Enterprise - La Crosse Center Operating Funds (Fund 101)", "root" },
                    { new Guid("f0037981-993b-4a56-a3e9-90bc8104cc56"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 0, 4, 289, DateTimeKind.Unspecified).AddTicks(6782), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 0, 4, 289, DateTimeKind.Unspecified).AddTicks(6782), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("2fbf3c72-e26f-4db8-a5de-180bc862d79e"), "General - Planning Operating Budget (Dept 820)", "root" },
                    { new Guid("f00cd64f-554a-4709-bd97-d8e12d0709db"), new DateTimeOffset(new DateTime(2025, 5, 26, 2, 57, 23, 850, DateTimeKind.Unspecified).AddTicks(1172), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 2, 57, 23, 850, DateTimeKind.Unspecified).AddTicks(1172), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("00316b5b-16ab-480a-8974-50f0f6dd97fe"), "Trans and Utils - Streetscaping and Lighting", "root" },
                    { new Guid("f03cef71-a09d-482b-9b56-03cc36a3860e"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 18, 25, 413, DateTimeKind.Unspecified).AddTicks(3068), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 18, 25, 413, DateTimeKind.Unspecified).AddTicks(3068), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "SMALL BUSINESS DEVELOPMNT LOAN (Fund 2030)", "root" },
                    { new Guid("f11b7b36-2b5c-49a4-b92b-2dc2e99c2a96"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 59, 48, 253, DateTimeKind.Unspecified).AddTicks(7365), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 59, 48, 253, DateTimeKind.Unspecified).AddTicks(7365), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"), "Sanitary Sewer/Wastewater - Other", "root" },
                    { new Guid("f12cf824-9c78-43b1-a479-62756710e323"), new DateTimeOffset(new DateTime(2025, 2, 28, 11, 10, 24, 711, DateTimeKind.Unspecified).AddTicks(8565), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 28, 11, 10, 24, 711, DateTimeKind.Unspecified).AddTicks(8565), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("69ce8d13-2884-4108-8a93-e7e05650a669"), "Test Past Funding", "root" },
                    { new Guid("f18e3444-409a-4c02-b0d4-612625afbee4"), new DateTimeOffset(new DateTime(2025, 5, 26, 2, 46, 9, 495, DateTimeKind.Unspecified).AddTicks(1023), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 2, 46, 9, 495, DateTimeKind.Unspecified).AddTicks(1023), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("3c78d7af-5305-4138-9038-be7425fcecb2"), "Common Council", "root" },
                    { new Guid("f19bf382-85d4-4f87-a80b-a1a141366ffd"), new DateTimeOffset(new DateTime(2025, 5, 26, 5, 59, 22, 34, DateTimeKind.Unspecified).AddTicks(4942), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 5, 59, 22, 34, DateTimeKind.Unspecified).AddTicks(4942), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("2fbf3c72-e26f-4db8-a5de-180bc862d79e"), "General - Insurance Operating Budget (Dept 460)", "root" },
                    { new Guid("f1fcf4b6-7467-474e-b696-3fb056b682ce"), new DateTimeOffset(new DateTime(2025, 2, 19, 7, 33, 16, 778, DateTimeKind.Unspecified).AddTicks(6294), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 19, 7, 34, 10, 782, DateTimeKind.Unspecified).AddTicks(7867), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("5baad37a-5ba1-4ec1-aaa3-992fa352a887"), "Complete", "root" },
                    { new Guid("f20a88ff-294b-45cd-bf87-2dbaafe02d21"), new DateTimeOffset(new DateTime(2025, 2, 6, 6, 49, 44, 606, DateTimeKind.Unspecified).AddTicks(6667), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 6, 6, 49, 44, 606, DateTimeKind.Unspecified).AddTicks(6667), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("b4fe9e53-b0cc-4a8b-89d7-712bfc97ac24"), "Scheduled Replacement", "root" },
                    { new Guid("f23e5a2a-ebf1-41cb-8936-0544a34248d9"), new DateTimeOffset(new DateTime(2025, 2, 6, 6, 50, 39, 446, DateTimeKind.Unspecified).AddTicks(6667), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 6, 6, 50, 39, 446, DateTimeKind.Unspecified).AddTicks(6667), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("42aa7e76-c0e4-49da-a5b8-0ad3f7163673"), "Existing Bond Funds", "root" },
                    { new Guid("f254701c-007d-4fa3-80bc-3cd44a537acf"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 4, 16, 779, DateTimeKind.Unspecified).AddTicks(4231), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 4, 16, 779, DateTimeKind.Unspecified).AddTicks(4231), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("1881c517-32e2-4c09-8bd2-09e2efe7dc61"), "Special Assessments", "root" },
                    { new Guid("f2b43ce1-0053-436e-bd47-cad1c9894d3a"), new DateTimeOffset(new DateTime(2025, 5, 26, 5, 53, 43, 70, DateTimeKind.Unspecified).AddTicks(6191), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 5, 53, 43, 70, DateTimeKind.Unspecified).AddTicks(6191), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("2c4caa8d-544b-4393-82be-9a5b7c221117"), "TIF Bonds/Notes: 17 - Lot C Downtown", "root" },
                    { new Guid("f2ee26f4-00ae-43b6-b749-94d708386d5e"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 8, 4, 996, DateTimeKind.Unspecified).AddTicks(1282), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 8, 4, 996, DateTimeKind.Unspecified).AddTicks(1282), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "2017 CDBG (Fund 2260)", "root" },
                    { new Guid("f3a012e9-8801-480e-9593-061e44d1d689"), new DateTimeOffset(new DateTime(2025, 5, 22, 17, 14, 33, 790, DateTimeKind.Unspecified).AddTicks(8073), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 17, 14, 33, 790, DateTimeKind.Unspecified).AddTicks(8073), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("0f4e03dc-0ead-41ad-93a9-26b0b6a0af3a"), "Funding Increased", "root" },
                    { new Guid("f496d324-30d3-41e4-8072-6fd1e7034b82"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 17, 32, 262, DateTimeKind.Unspecified).AddTicks(1708), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 17, 32, 262, DateTimeKind.Unspecified).AddTicks(1708), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "POLICE TRAINING FUNDS (Fund 531)", "root" },
                    { new Guid("f4aaedc9-e457-4008-9e54-a6e0742dae79"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 11, 44, 886, DateTimeKind.Unspecified).AddTicks(1808), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 11, 44, 886, DateTimeKind.Unspecified).AddTicks(1808), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "FIRE SMOKEHOUSE (Fund 222)", "root" },
                    { new Guid("f4c55e76-fafc-4a20-9bef-25a2db55ae4f"), new DateTimeOffset(new DateTime(2025, 5, 22, 17, 12, 28, 704, DateTimeKind.Unspecified).AddTicks(748), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 2, 47, 49, 915, DateTimeKind.Unspecified).AddTicks(1136), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("3c78d7af-5305-4138-9038-be7425fcecb2"), "Police and Fire Commission", "root" },
                    { new Guid("f59eeb5e-c1b5-4e9c-9ca4-c744b19ec03e"), new DateTimeOffset(new DateTime(2025, 5, 21, 22, 57, 36, 60, DateTimeKind.Unspecified).AddTicks(6479), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 21, 22, 57, 36, 60, DateTimeKind.Unspecified).AddTicks(6479), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("18b298cd-91de-4b10-ae36-3bafd0ec02e8"), "Engineering", "root" },
                    { new Guid("f5a9a664-ecea-44d9-afd0-a799778928cf"), new DateTimeOffset(new DateTime(2025, 5, 22, 6, 47, 51, 818, DateTimeKind.Unspecified).AddTicks(7990), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 6, 47, 51, 818, DateTimeKind.Unspecified).AddTicks(7990), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("b44e86cb-1388-4c3f-ae4c-94d3df4f662b"), "General - Streets Operating Budget (Dept 883)", "root" },
                    { new Guid("f644d9a0-ffbf-4df1-9f5e-1de61b7c5f2f"), new DateTimeOffset(new DateTime(2025, 5, 22, 1, 19, 49, 199, DateTimeKind.Unspecified).AddTicks(1790), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 1, 19, 49, 199, DateTimeKind.Unspecified).AddTicks(1790), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("cf4a4d66-6ced-43f2-959d-613c2fa2110d"), "Neighborhood Revitalization Commission", "root" },
                    { new Guid("f66b926b-6099-461a-80e6-cfec02e95b66"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 10, 43, 560, DateTimeKind.Unspecified).AddTicks(1712), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 10, 43, 560, DateTimeKind.Unspecified).AddTicks(1712), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "COMMUNITY POLICING FUNDS (Fund 518)", "root" },
                    { new Guid("f696f51b-6c8e-4492-9e7a-e2c2a1bd15d0"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 7, 30, 98, DateTimeKind.Unspecified).AddTicks(5190), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 7, 30, 98, DateTimeKind.Unspecified).AddTicks(5190), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "2014 CDBG (Fund 2257)", "root" },
                    { new Guid("f6b9ddbd-5a73-4297-9a72-66508cfce09d"), new DateTimeOffset(new DateTime(2025, 5, 22, 1, 18, 25, 324, DateTimeKind.Unspecified).AddTicks(6820), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 1, 18, 25, 324, DateTimeKind.Unspecified).AddTicks(6820), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("cf4a4d66-6ced-43f2-959d-613c2fa2110d"), "Finance & Personnel Committee", "root" },
                    { new Guid("f6d38c50-31b9-4cf0-93e0-8174abb09412"), new DateTimeOffset(new DateTime(2025, 5, 26, 2, 50, 47, 975, DateTimeKind.Unspecified).AddTicks(1640), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 2, 50, 47, 975, DateTimeKind.Unspecified).AddTicks(1640), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("00316b5b-16ab-480a-8974-50f0f6dd97fe"), "B and G - Others", "root" },
                    { new Guid("f6ea2538-d22a-41f2-b697-42c3064ca14f"), new DateTimeOffset(new DateTime(2025, 2, 6, 6, 50, 39, 453, DateTimeKind.Unspecified).AddTicks(3333), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 6, 6, 50, 39, 453, DateTimeKind.Unspecified).AddTicks(3333), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("42aa7e76-c0e4-49da-a5b8-0ad3f7163673"), "La Crosse Center Room Tax", "root" },
                    { new Guid("f6f8e02e-ad30-48b5-9857-48389481d7f8"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 57, 46, 167, DateTimeKind.Unspecified).AddTicks(723), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 57, 46, 167, DateTimeKind.Unspecified).AddTicks(723), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"), "Parks - Boat Docks", "root" },
                    { new Guid("f766380b-4988-4b63-9a2c-7443a8f8b71f"), new DateTimeOffset(new DateTime(2025, 6, 11, 6, 19, 42, 291, DateTimeKind.Unspecified).AddTicks(2996), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 6, 11, 6, 19, 42, 291, DateTimeKind.Unspecified).AddTicks(2996), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("08b0863c-ba0c-48f8-8702-06bbe6578170"), "Turner, Ian", "root" },
                    { new Guid("f782e506-a616-43fb-86b4-4d520f103f2d"), new DateTimeOffset(new DateTime(2025, 2, 19, 12, 17, 29, 512, DateTimeKind.Unspecified).AddTicks(27), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 2, 44, 46, 584, DateTimeKind.Unspecified).AddTicks(6613), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("3c78d7af-5305-4138-9038-be7425fcecb2"), "Arts Board", "root" },
                    { new Guid("f7d95b32-784e-4c7d-af80-1478492b97dd"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 12, 8, 997, DateTimeKind.Unspecified).AddTicks(4063), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 12, 8, 997, DateTimeKind.Unspecified).AddTicks(4063), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "GIDEON HIXON SCULPTURE (Fund 572)", "root" },
                    { new Guid("f8f94bd0-d0a4-49b1-9a88-a37539569f61"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 59, 23, 21, DateTimeKind.Unspecified).AddTicks(6401), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 59, 23, 21, DateTimeKind.Unspecified).AddTicks(6401), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"), "Public Buildings - Municipal Service Center", "root" },
                    { new Guid("f8fc2115-8f20-4f83-a92e-6d6b519f672b"), new DateTimeOffset(new DateTime(2025, 2, 19, 12, 16, 21, 126, DateTimeKind.Unspecified).AddTicks(6594), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 19, 12, 16, 21, 126, DateTimeKind.Unspecified).AddTicks(6594), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("ea188a54-8da6-4c4c-bedf-89a079480790"), "Francis Coyoca", "root" },
                    { new Guid("f9312f00-f78a-4835-bbb3-b8702bc1da86"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 8, 11, 67, DateTimeKind.Unspecified).AddTicks(1190), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 8, 11, 67, DateTimeKind.Unspecified).AddTicks(1190), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "2017 HOME (Fund 2730 )", "root" },
                    { new Guid("f96b7101-0a16-4451-b4dc-6603f2dbfd84"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 17, 38, 835, DateTimeKind.Unspecified).AddTicks(2711), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 17, 38, 835, DateTimeKind.Unspecified).AddTicks(2711), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "POLICE VEST CONTRIBUTIONS (Fund 532)", "root" },
                    { new Guid("f99a9ccc-e2a9-4f91-a54d-e24ea2bc0dd4"), new DateTimeOffset(new DateTime(2025, 5, 22, 17, 13, 58, 579, DateTimeKind.Unspecified).AddTicks(9134), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 17, 13, 58, 579, DateTimeKind.Unspecified).AddTicks(9134), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("0f4e03dc-0ead-41ad-93a9-26b0b6a0af3a"), "Request Amended", "root" },
                    { new Guid("f9b851c3-236c-43d6-966d-ec919c0dd230"), new DateTimeOffset(new DateTime(2025, 5, 21, 23, 8, 0, 834, DateTimeKind.Unspecified).AddTicks(1919), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 21, 23, 8, 0, 834, DateTimeKind.Unspecified).AddTicks(1919), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("18b298cd-91de-4b10-ae36-3bafd0ec02e8"), "Stormwater Utility", "root" },
                    { new Guid("fa341e3f-e4e3-459d-989b-fa889b2036bd"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 56, 32, 684, DateTimeKind.Unspecified).AddTicks(4764), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 56, 32, 684, DateTimeKind.Unspecified).AddTicks(4764), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"), "Equipment", "root" },
                    { new Guid("fa61555a-bc5e-4d4d-811b-68c88f46c810"), new DateTimeOffset(new DateTime(2025, 5, 21, 5, 34, 4, 566, DateTimeKind.Unspecified).AddTicks(7278), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 21, 5, 34, 4, 566, DateTimeKind.Unspecified).AddTicks(7278), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("f0770a04-79f8-488e-b674-d1dde98e8079"), "Local", "root" },
                    { new Guid("fa7987d5-7dcf-44c2-b33c-af8ac86c3c64"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 15, 54, 338, DateTimeKind.Unspecified).AddTicks(4178), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 15, 54, 338, DateTimeKind.Unspecified).AddTicks(4178), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "POLICE BOAT PATROL PROGRAM (Fund 539)", "root" },
                    { new Guid("fa80304e-7e04-4a8f-b1da-c24a28c2357d"), new DateTimeOffset(new DateTime(2025, 2, 25, 2, 7, 12, 389, DateTimeKind.Unspecified).AddTicks(5027), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 25, 2, 7, 12, 389, DateTimeKind.Unspecified).AddTicks(5027), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("d2b40805-4186-4088-ac14-16be43330171"), "Sub Detail 1", "root" },
                    { new Guid("fb10b885-1c6e-4fd3-9bda-9cc9006c7bff"), new DateTimeOffset(new DateTime(2025, 5, 22, 17, 26, 15, 466, DateTimeKind.Unspecified).AddTicks(5337), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 17, 26, 15, 466, DateTimeKind.Unspecified).AddTicks(5337), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("c1353eb7-87ca-4cca-9d5c-f87bd4ae97c8"), "Planning & Development", "root" },
                    { new Guid("fb27cb61-0d4d-49e4-aff1-ca9bddd1627f"), new DateTimeOffset(new DateTime(2025, 2, 28, 5, 33, 21, 86, DateTimeKind.Unspecified).AddTicks(5282), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 3, 20, 898, DateTimeKind.Unspecified).AddTicks(8835), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("1881c517-32e2-4c09-8bd2-09e2efe7dc61"), "Existing Bond Funds", "root" },
                    { new Guid("fbe65377-2681-4a7b-bfbb-e9d8974312c0"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 16, 35, 716, DateTimeKind.Unspecified).AddTicks(7959), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 16, 35, 716, DateTimeKind.Unspecified).AddTicks(7959), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "POLICE EQUINE PATROL (Fund 525)", "root" },
                    { new Guid("fc166347-528d-4512-90fe-043b6466baa7"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 13, 44, 882, DateTimeKind.Unspecified).AddTicks(2895), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 13, 44, 882, DateTimeKind.Unspecified).AddTicks(2895), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "LAX CTR ROOM TAX SURPLUS (Fund 294)", "root" },
                    { new Guid("fc274da2-2fa5-4c74-aef8-95b82ed7628d"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 0, 18, 503, DateTimeKind.Unspecified).AddTicks(4984), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 0, 18, 503, DateTimeKind.Unspecified).AddTicks(4984), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("2fbf3c72-e26f-4db8-a5de-180bc862d79e"), "General - Police/Fire Operating Budget (Dept 422)", "root" },
                    { new Guid("fc79cc01-bb88-4fe0-890b-0aa26002fa67"), new DateTimeOffset(new DateTime(2025, 5, 26, 2, 46, 19, 632, DateTimeKind.Unspecified).AddTicks(3103), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 2, 46, 19, 632, DateTimeKind.Unspecified).AddTicks(3103), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("3c78d7af-5305-4138-9038-be7425fcecb2"), "Community Development Committee", "root" },
                    { new Guid("fc84b3d2-4502-4c17-9182-037cc2642424"), new DateTimeOffset(new DateTime(2025, 5, 22, 17, 15, 51, 749, DateTimeKind.Unspecified).AddTicks(2423), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 22, 17, 15, 51, 749, DateTimeKind.Unspecified).AddTicks(2423), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("95f8e0c2-b1dd-44b4-aa66-09f63efddc48"), "2025 CPC Draft", "root" },
                    { new Guid("fcdfbc2f-50ae-488f-8451-54e66c105ac4"), new DateTimeOffset(new DateTime(2025, 3, 19, 13, 28, 51, 118, DateTimeKind.Unspecified).AddTicks(9439), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 3, 19, 13, 28, 51, 118, DateTimeKind.Unspecified).AddTicks(9439), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("93985952-4e53-4b3d-a897-8bec835d8d42"), "Unfunded Request", "root" },
                    { new Guid("fd14706f-93f2-44fc-82b3-59f73c784ad1"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 4, 3, 214, DateTimeKind.Unspecified).AddTicks(5510), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 4, 3, 214, DateTimeKind.Unspecified).AddTicks(5510), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("1881c517-32e2-4c09-8bd2-09e2efe7dc61"), "Reserve Fund", "root" },
                    { new Guid("fd789e9d-5ff5-416f-9f51-1789a022fd1b"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 14, 24, 868, DateTimeKind.Unspecified).AddTicks(242), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 14, 24, 868, DateTimeKind.Unspecified).AddTicks(242), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "MISCELLANEOUS GRANTS (Fund 571)", "root" },
                    { new Guid("fd857536-7d01-42ed-8a16-429d9c59cc48"), new DateTimeOffset(new DateTime(2025, 5, 21, 22, 58, 38, 753, DateTimeKind.Unspecified).AddTicks(404), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 21, 22, 58, 38, 753, DateTimeKind.Unspecified).AddTicks(404), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("18b298cd-91de-4b10-ae36-3bafd0ec02e8"), "La Crosse Center", "root" },
                    { new Guid("fe3317c7-0dc4-45a9-91b4-0e86f3404009"), new DateTimeOffset(new DateTime(2025, 2, 19, 7, 2, 46, 718, DateTimeKind.Unspecified).AddTicks(6180), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 19, 7, 2, 46, 718, DateTimeKind.Unspecified).AddTicks(6180), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"), "Bridges", "root" },
                    { new Guid("fe891a6c-be70-42b1-a0e0-f56a26d1d33e"), new DateTimeOffset(new DateTime(2025, 5, 26, 6, 15, 48, 521, DateTimeKind.Unspecified).AddTicks(383), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 26, 6, 15, 48, 521, DateTimeKind.Unspecified).AddTicks(383), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), "POL REVOLVING RESTITUTION (Fund 538)", "root" },
                    { new Guid("feb77b35-b2ae-4b29-82e2-814cad1113ae"), new DateTimeOffset(new DateTime(2025, 5, 21, 5, 35, 28, 766, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 21, 5, 35, 28, 766, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("b44e86cb-1388-4c3f-ae4c-94d3df4f662b"), "General - Attorney Operating Budget (Dept 140)", "root" },
                    { new Guid("febd66e6-6c73-4a52-ad0c-e296e10e181f"), new DateTimeOffset(new DateTime(2025, 2, 19, 7, 38, 7, 662, DateTimeKind.Unspecified).AddTicks(1328), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 2, 19, 7, 38, 7, 662, DateTimeKind.Unspecified).AddTicks(1328), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("bd4dd1db-1f4d-455c-846b-4e0b620dfb1d"), "Street Lighting", "root" },
                    { new Guid("ff6edb2e-18d5-443b-b3e2-0823beeb9875"), new DateTimeOffset(new DateTime(2025, 2, 6, 6, 50, 19, 830, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), null, null, true, new DateTimeOffset(new DateTime(2025, 5, 21, 5, 34, 41, 368, DateTimeKind.Unspecified).AddTicks(8355), new TimeSpan(0, 0, 0, 0, 0)), new Guid("638c53dc-5995-4552-b7ac-1edc48df9e74"), new Guid("b44e86cb-1388-4c3f-ae4c-94d3df4f662b"), "Enterprise - Airport Operating Funds (Fund 600)", "root" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("01ed4386-e34e-4231-8f54-a5d321e22e2e"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("0292e932-f7b8-4d83-90fd-6c974cb5fe68"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("029e7e7c-f42d-436a-9d5a-00cdfd7afa13"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("02aba20a-3f80-4754-a27e-afbfb911db86"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("02bf93bf-7aff-4508-8961-3c23427e592d"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("0475db20-6ee5-4c72-af8a-70c5e3ac8877"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("05112108-8ed8-4525-b05b-67d0c5b27342"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("0574e943-adb4-42bc-b6e2-9553796dddc2"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("05b8205f-abe9-47aa-a0eb-82532b75e145"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("05c5e2f1-9987-487d-b92e-5ed2b06912e8"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("0647e23d-3216-454d-a065-2e00da633ac9"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("06a72058-6842-4728-b175-683aecdfe924"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("06ec47a6-edcd-4919-a81f-6209b63ea418"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("06fb60fd-8754-4fa3-9a95-5fb2364d9eb3"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("073fad94-7a7a-4df3-a7a6-a51aefa7c2c5"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("07b3502a-690f-4d52-9e49-109666cd0c91"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("07ded818-cbba-4adf-912f-2e192c2d653a"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("08662cba-f8a1-447b-8418-18602cf49415"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("08903189-9966-4262-b2c1-1e0fc249a91e"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("08d4017f-136b-4830-848a-e4d10645c8c2"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("094da7d1-3458-4d39-b9d5-3f3035b4b8d0"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("09d09cd2-98d8-49b3-8b70-b130f0a8cc42"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("0a8bbee9-f548-4229-83c9-78cebf603ba4"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("0cb142e3-e533-4ae3-83ef-ad5d8d6c4a7b"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("0cd00c57-e497-45c9-8d19-3cdb5821fcd9"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("0d3b1e88-d210-4199-9374-d649a49e2140"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("0d59136b-b196-44a2-8e0b-ff82e24e7a6c"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("0dadfa71-ef6c-4b5b-a785-af51ef365659"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("0e0e4e33-5203-4970-8db1-44fdca7e2e70"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("0e2c8070-66d2-4255-adfa-0e99cc1bf89c"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("0e6abb22-13da-452c-a8da-ee62bd0293db"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("0eee03d6-77d0-44fa-9dd1-8777b5b2f1f9"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("0eee7673-2a8f-4be2-b7ac-71c09eceeeb8"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("1094fb08-dfdf-4157-abd3-94c062effc13"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("10b264e8-5f58-4055-9a02-ae0d763b9c63"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("1286cd4f-d154-4e33-b033-e323af39f0ec"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("12a47836-5007-4ea4-964a-66e5cb630c07"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("12c94843-4f73-4381-8714-a49047ac586c"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("13b37571-c157-40f0-9482-92083efc6884"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("144cefe8-e8ae-4285-b0f7-19af4221215c"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("146af0b5-0594-47e2-b9e7-8fb4b35d355d"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("149ee3be-2113-40ee-b7e7-2ba8a2068192"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("14aa9088-d3cc-4dbd-ab87-73d03f570cfc"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("14b4ed11-6fdd-4359-aa31-b58575c42e92"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("1555bc34-8ac4-49fc-bcec-64efc5b92db7"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("1690d44c-fe68-4d3b-97e8-5f2c7bb5dddb"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("16c1abde-1120-4a6e-bbe6-8399f02e32cf"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("16dab5ee-5b4d-4277-a11d-419b0e746442"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("16f40604-4809-48ef-a2a3-c2ace7f55c0d"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("172fa433-d257-4d55-ba44-05794ecf6e29"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("1737baba-3402-4d11-83bd-b3e38ea20649"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("175d84dd-ecdc-4daa-8d08-230b9edd329c"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("17ad5030-24f1-4507-aeba-7c3ebc4201f5"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("180b5930-9bfe-4bdf-b00a-574066ca164e"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("18af88a7-a294-432c-bd84-54db919bf5c3"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("1967eb57-4c09-4684-bb1d-7b9a0b303455"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("1ab1207b-0963-49e0-ae74-5806b617e67a"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("1b71e6fb-4645-484e-b7d1-b1b6563a2256"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("1b9c7555-d145-4020-bb54-0d87410ed50f"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("1bd665d0-0430-45ff-9459-cf0f02080850"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("1c767135-83af-4f9b-8b08-a07105a55dd8"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("1c7693c7-5a87-446a-91bc-961549a51e31"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("1c83e967-8d79-49b3-ad80-55b5ece6b17a"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("1c98551c-70d4-4e0b-b82a-5b0449485878"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("1caf9421-f1cc-4bf7-85ab-d55eb249db38"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("1d08fb75-b304-465a-943c-1b481e7dedeb"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("1d1ab47f-02e8-4d04-a4d2-eea013254ac0"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("1d468275-63e0-462c-b0ef-7a084cb927ba"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("1e5f6332-e41d-44ed-8bf2-cd10c919cc3b"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("1fb8c160-e938-46e7-983d-36ef39c72bbf"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("1fed6bee-da44-4e33-a1b4-823ec3a67827"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("201e1eff-5acf-47f3-a4fa-e2d551f15d86"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("2020161c-89d1-4f9f-8bc5-2a7193494b88"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("20244247-ca45-48fe-b2d5-b987a3563d3d"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("20c22846-e389-4596-b140-6b99927eaf52"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("2230ad55-b7ef-463a-bd3f-3ada90798e77"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("224f1993-257d-47ca-b3d6-be8a016f1df0"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("229bae8d-4e97-427f-9625-c11d86ed25f7"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("22bc6809-68c9-4493-b4c9-1a271106475e"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("2502aad0-ce2c-48ca-b068-f0cd19182739"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("2600c3d0-e7e8-432b-8765-f360f3b639f5"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("2885db15-fde1-405b-aeab-0a266fb5dc7b"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("2887f6fa-b983-44c7-a651-e35f9b58240b"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("28bf110a-f8b7-46f4-a1fb-19e8db1077e0"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("28ff616c-19ac-47b3-9183-641502ef7cf2"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("29062e38-2192-448a-a947-ecdbe4e91d29"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("29251245-a159-4a9d-a75a-04aec242699c"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("2936f712-eebd-4453-aca4-d857e1358196"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("2a7adaab-e175-454b-83be-f16a29a19445"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("2a9eb309-e354-4f96-a12e-af6fd0fb265b"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("2aba7026-d9b6-443b-b77e-f1548a14b8be"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("2ad079ec-3fbe-4c53-b950-c1801f03ec98"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("2b729536-38c1-4750-af80-560440b09017"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("2c3c8380-2591-4c59-96c7-3b82d2ae145b"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("2c77a980-7eb3-4a17-a92e-629ad4c2302a"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("2ca367ac-cc3a-4133-b9c2-51c6bb6069ef"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("2d2e4195-d283-4cdd-8eb3-54db98aefd35"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("2d4674f6-b2fd-4515-a0b5-1b8f89b5895c"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("2d8b9626-1eec-4ad3-8770-85030d52a93c"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("2e0cb8ec-056c-4a69-b8a6-878854cfd678"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("2e36ce16-a881-4c22-8333-356629a7f8d4"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("2f169734-910b-4bc4-a1bc-d63cd85faf24"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("2f7cee83-1d27-4c44-8303-1bbbfaf51872"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("3166b9f7-d9bb-45c9-805f-7978bb06011c"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("320a4663-595d-486e-a710-9c2d7965491e"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("3320de24-723f-4f16-881a-333d2a4ddac0"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("332dc9b4-695f-4ad3-ac2a-16bd03e27122"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("356726e6-1968-494c-91ff-ad3d67ab9cbc"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("3575e95f-253b-4cf4-a86b-2f529b880bf2"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("35f8ffdd-5920-4143-a3c6-f9c469cf1244"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("36093421-1d0d-48e3-84be-337bede2a5b2"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("363e8dea-53fd-43e7-b502-64080bb1386c"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("3656e5f9-4721-4a64-b031-94866a724005"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("3699325f-4d84-4e96-936b-e83312047940"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("379e4563-c28f-452f-9067-07f1a100e022"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("37cf055b-99d9-46bc-978d-80e022a9fb3d"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("3a6c2698-96fd-4db5-9a6c-9be55b00223a"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("3b41552d-cb8e-4e2d-bf50-6e68ba203d53"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("3b6710d1-b5c4-41ed-b70a-49797a089f56"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("3b6b8952-6c60-492d-b1b8-d8873df684b4"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("3c01a9dd-2f80-4039-92e4-f1512dfcc4e5"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("3c9d382f-6848-4117-9411-d0be3b4800d2"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("3cefaa9f-e413-40e0-94ba-58ed5e57ee12"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("3d51ec28-15eb-46c4-8d71-5bc4e0912a1f"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("3e7bebcc-1548-4de7-b4b3-e63b7951161d"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("3f0fb3b7-84e9-4dd6-a67d-9b9975574715"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("3f57473d-4476-48f0-bf86-efad6cc5fca4"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("3fb83c02-a74e-4b67-b08e-465413419f0f"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("41619839-9c72-4dc8-aa68-da1feaf1c31a"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("41a4e66e-6556-4e57-968f-b47e7f67940d"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("41e5abd7-4a60-4f6b-b90f-268ff3e49592"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("4212182c-5e43-4c0e-9b1f-ddd9587b2516"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("42de20af-58e7-4349-8452-231b6933f829"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("42e1165e-58c4-4cb6-881a-38634e730505"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("4319ff74-168f-4dd6-918c-b9680d0ddb30"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("4419a1cb-69ac-4712-96ef-85ac9ec0bce9"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("441ab957-ca07-441c-a2ca-0586f3ceb6f8"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("4566301d-7346-4a70-84d8-5cf403f23dd1"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("4609f8ee-21ec-4d5e-9474-762531508deb"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("46183932-e00a-4e07-9287-0b2482ae42fd"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("475f2755-3a21-428d-a0fe-e754f1e160d5"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("478881fa-94fa-4133-9d35-2883993a400e"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("47fc7aee-87f5-4832-acbc-92a360ad2c03"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("485c2dcd-b430-4b62-b0b2-e0ee5bafe80d"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("48d2a343-2956-4785-9f39-9e6b65248f62"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("48e6626a-2e62-47d8-a6d5-2a6b1838e4f8"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("48f2f630-e2cc-4f9b-a27b-742fee8ed7dd"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("4928d6b9-e054-4380-b75e-b12b17c49344"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("4960c3e8-d82b-46c7-a723-ba068f4d43e4"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("4a1796a4-1886-437f-a5ec-073701c39f1b"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("4a31b68f-fe8e-45fc-88c5-b8b081da8a3b"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("4a7859c6-76e8-47a3-af85-9a97fc6b411e"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("4b8d28ce-1bf3-46de-b999-19efd918cb9a"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("4c3f0f8a-ab30-4d7d-a975-b1efbeb87e25"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("4c6578f5-c58b-4f12-a2e4-4de8a65e7636"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("4cdfcffb-7db1-4620-b33c-6dc228205491"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("4d0dae76-7e27-4c6c-8335-5d34bc817d88"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("4d65147f-9dab-42a2-9a76-de80b52fe622"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("4d77766d-26dc-40f4-b722-dc222ca1b318"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("4d7d40e1-cdf1-4e52-bc47-1a7e5928e3bf"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("4dbeebce-7455-42cc-8791-029be7309883"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("4dd6e9fd-af74-4c1f-9bea-917f4c625a14"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("4de0eb76-d5bf-40d1-acb1-3dbfce2b4389"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("4dfdf388-c842-45ef-b689-11fd7a7de42f"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("4e0c0aee-57ba-41b9-a758-78c82790fdb6"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("4e25f5f7-02d5-4172-882c-cf4af92bab5e"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("4ea341b1-289e-4b59-b5f6-66c401157e39"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("4f13b518-5c74-40bd-9d93-842f8164f2a4"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("4f359e2b-9950-407f-917a-94c8a447e2eb"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("4f549198-cf6d-418b-b3fd-5774877bba9c"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("4f791c6e-512d-46a8-8ea9-c58953fb0b41"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("5173dd01-4bc8-4e6e-9eb6-69d3c2a41919"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("5180f348-5b81-4392-8923-5585b78d09da"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("51af579c-c6f9-4dd4-8411-4a5ca7f98cb1"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("52b1af58-6f1c-4ea9-bcb4-ba8e068a876f"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("53109d06-056c-40e0-b421-023db5651201"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("53c4a2a0-1a02-4b03-9d93-a05d01c4688d"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("53e13160-97ec-4437-a7c7-5aafcff89f77"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("542695af-fde3-4d2d-8bb4-6b04de85832a"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("545e1110-5274-4fa0-af38-f118687f4a12"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("546d28fb-1784-43cf-b8e9-ee34e5b8414a"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("56f80fdb-c079-4128-b301-e93a51463cb5"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("574166fe-1c6a-404c-a3ce-ed4e30eeab48"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("5750c3ec-7a87-4b51-9b2f-ade8dd2d337e"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("57f35fba-2d07-4197-94bb-07bf8d5bf4a9"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("59a217a3-f411-4a93-899f-26f19d18f966"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("59a708f6-b024-4ce3-835c-a7016d42bc2f"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("5a28c441-acb2-4b31-acb8-a2659cc33e67"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("5a4f79da-9a76-4b4a-872f-3b452e0aaa31"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("5b0b8808-b722-47bf-98a5-effe24a353f6"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("5b45eeeb-6d3c-4682-83a4-a28753a3570f"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("5b9850bc-8abc-440b-896a-7368d5dbcadb"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("5c2086a3-26d9-4b66-bacc-de0d0efb72c2"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("5c3cbe43-7742-455c-a390-30145d974d0a"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("5c457d7b-5067-438d-bb2d-8220f63337a2"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("5c45f11d-e76f-45f8-ac0f-411c28cf6839"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("5d25246d-ed63-4149-a7a8-de320af10b54"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("5e5b211c-93a4-45ca-84fb-9f5d177acd44"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("5e791233-7539-4271-9a98-84d906dc412b"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("5e7c54c5-b9de-4d83-ac0a-d4ffd0e98448"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("5e95db11-08b3-4517-b367-0a488ddeee9b"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("5ee122a6-7faf-42bf-910e-7f1d496773da"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("5f4209d7-9703-46e4-8230-364cf32ae470"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("5fbb5f6b-0cb9-459d-b1ca-a9558d630bcb"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("5fde2bbd-6fb7-4d6b-b63c-faec780f5031"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("5fe61493-b4d3-4927-99c9-455ec535d3db"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("60896384-1b49-4777-a210-1504a525b2c2"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("60b6d3c6-528f-4990-89ed-2d453ee171f7"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("6213fe1c-8a7d-4129-9d99-dd3748326f6f"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("62626ce1-957e-47e9-ade7-554420f27d06"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("6265803a-eac9-4ca4-b0f3-dc9418952754"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("62ba9a19-bd80-4ca6-91d2-8928a60984fa"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("62dee8f6-4289-498e-87d4-d0ebb545fb9c"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("63114c92-bf9c-4f63-910f-3d31e518c90d"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("635be736-ca46-47c3-a6f8-cc1ca0914179"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("640356b8-ba9f-43a2-bea6-4f3d0d283c42"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("640f9351-c3ea-4fa2-8a6b-6e5909808e68"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("646a13fa-1e68-49ba-841c-03486759cdaf"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("6484910f-09ef-423b-b96e-fce8c6f0362c"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("653317bb-9339-48e0-ada4-e18b5fe8b2bd"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("6760722c-46d1-4c6b-90bd-5bc544a78bc7"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("676b5e58-aa0a-47b8-b8a2-1ab1b3b57f03"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("67c7473d-3071-42f0-ac52-da3721223389"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("68c03bcf-929d-4bd0-98be-e2409de526e0"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("68c2bcd8-10f2-4afe-b837-f00294bc39a1"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("696c523e-7c0d-4833-bf52-7a535f3c0698"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("69d9670a-6395-4b4d-a633-47c3c6395b96"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("6a1083a3-6f8b-4723-bd91-05cadfa9a8b7"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("6a1d4fb3-39bb-4245-bb2c-e030b440a636"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("6a9742df-5b46-4757-927d-706d0cee554c"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("6acfa308-89fb-4a06-a181-1b3f6dc4e984"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("6ae74ffe-54e4-4af6-828c-21f4ed24d9b4"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("6b49150f-ba9c-40b1-8f07-7a34e4f1d243"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("6e0b5321-1356-4919-b19e-db5621b3ad01"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("6ea100f5-4f72-42e7-b663-712c568bb0ee"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("6efa5e41-8b70-4587-98ec-035ccabf0af3"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("7018bbf4-98a9-46eb-b93f-fbe43d9c8644"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("7092ff7a-955b-4e64-97d9-edfa1e10e4a1"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("70dc2871-45af-4f39-ae5a-11249395d0ee"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("7117ad7b-fe19-42ea-8bff-3096d8a13e2e"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("712966c9-c55d-490b-ba63-a72fd33c27a2"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("713ec569-9421-4ae3-b6a9-4a3be1606562"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("716c7ab5-fa5d-4a46-b6c1-0a06172d30a2"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("723dd3de-8a09-4939-82e9-22c27b872cc7"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("72583ddf-2de8-4d2f-8ed4-41af542b5fa0"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("72b2781b-a087-4929-82a3-9348e76174fb"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("73457654-b4ea-4101-a3cf-dec59a535da8"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("74a24f2e-fa9d-4d64-accb-ac36964293d7"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("750bf786-a886-4bb9-8fb5-2071d327d746"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("75691d23-ac0a-43ee-9ee0-78563c5f6fcd"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("75b7158f-56f1-4873-a5b3-8e29c3565945"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("762129a9-181a-4957-ad86-0b0f582343c1"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("767aae96-b6a4-4fb8-8fe3-c203e090ab4e"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("7729ad84-0917-49b3-a52d-bfe34f14b06f"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("77c767e7-37db-4339-b0f0-5221f05e9925"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("77cc2141-c6da-4c34-822b-cafe537bb2f6"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("785f8599-9650-40b5-834f-ad750cf260a6"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("78703599-6c34-48de-92bf-5a312228621d"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("7889017e-7301-4d75-95e8-49d5ed83ebd6"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("78c6a068-9f45-43bb-a59c-bb372ed9e15c"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("7914ce74-8f62-4734-a6c7-e6dedb569f15"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("79a1bc4d-ee3a-4b49-9d9d-482f5e6fb56c"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("79c3f898-9f84-46e2-b250-00f18e03060f"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("7a5c35bf-6762-443e-ac1d-7c9d74ceda3f"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("7abfc6b9-0efc-4aba-bec7-9b3c1899269c"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("7b75bb54-bf53-4bd0-8085-a0c4494e65d7"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("7b7bea58-bb80-455a-b890-7ac655ca2693"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("7bc23531-8799-474d-9556-45b1c19f5ab3"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("7c724313-8c93-410e-944b-05a81b6c1b78"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("7cc437a2-5fda-4a9b-ada4-47a23dc2bfb0"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("7e42ed08-08bd-4c75-8443-372c80ece999"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("7e65e830-74bb-4c21-8dea-f94e057f29f5"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("7e67eb2d-e8fe-4342-92a0-cc0a6361d435"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("7f09a62d-e810-4bc9-b6b1-fb04b24947bf"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("7f4e75a1-ab7d-4190-8ca6-6b77fa4cf432"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("80e694cd-a657-47f5-8089-e871e53a9a4a"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("80eb4a58-1173-4a69-9de8-4f8aca2ea777"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("8187e3c4-a3bd-42d5-bdf5-7991c9bc720d"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("81fba826-48c7-402f-bbf6-3347aaa9530f"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("8253aa37-6e01-4f67-b9a8-18efd3fe9e06"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("825ad848-535d-4bf3-a638-55679a14c68a"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("84573742-0ed5-4fb7-a0e5-c280a71452ef"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("84a72325-bdad-4a47-b5b0-8dec733f0f5a"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("85e267a0-a4dc-439d-8895-f0083cbd8d01"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("86d92cd6-ad63-4d8c-b283-4e1e01c8186b"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("870cf565-d498-4d15-89a7-71f29aaedacd"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("8767103b-e15f-4015-bed9-5c1d303cbcf0"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("87c33308-18f1-43c3-a2f4-a8ee0ae83a6c"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("886758d2-4624-4cd0-bcd9-5a1636497bec"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("8910c16f-8f87-411c-b2f8-45ab52e4307e"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("894c5acf-eb82-4286-b7cc-018c7db7731a"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("89dde96e-1acf-4ae2-8541-7a51c1f6a4ee"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("89f91d8d-0afd-495d-a920-eb47323980b6"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("8a0261b2-a7b9-451d-960b-a3f5c40590bd"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("8a58750f-d1a1-4e8a-a0d5-e9f0ec1cb5a8"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("8ae0bb3e-5c2d-4ccf-9351-e8aaddd3d528"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("8bb68ec9-48f1-4cd4-8825-0a4074aa5d20"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("8c0fe778-ba0c-4b14-af97-cdff2319e29d"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("8c3daad9-f8ee-43f1-9edf-7b5079c93cba"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("8da7deb3-2171-40d8-baf4-676572d10085"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("8f9e1cf6-9420-4451-939c-ae01b72ba943"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("908e4dda-3536-4095-b58e-a408d36ca6e0"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("90f46a55-8f73-4718-93b2-fb5704b0f71b"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("9179d50e-9fa0-495f-8b82-b773d23b3b02"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("91c3944d-ac19-4fb2-b340-21f640630065"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("92c48777-180f-47bc-b762-812da9a3d311"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("930b2160-0eb3-4c81-80c4-d9f6794a511f"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("933f9a7e-4ca3-472a-8ef3-4fb4ac07bb59"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("9409e34f-a2dd-4334-97f4-48507864b1f1"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("94e8a8ea-96e9-4756-bff2-b70a819310d1"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("95581d66-8687-4a75-bf39-e711af9955c5"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("9592ac30-88bb-4451-88e5-478685d45fbb"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("95a118a2-154b-4a2f-acc2-92865494f5a1"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("961dc7a6-60e2-41a8-9827-a22185e9dbb9"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("9625b0bf-a0ab-4a72-9c13-1265984c819f"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("967902e0-6ea3-40f4-97e7-7d02d681b238"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("98d9a98b-64d8-4ada-89b3-77910ce41c0a"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("99859e55-a855-4754-8c02-2fdae538a8a5"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("99ad0e07-8288-453b-b693-ac673a9335be"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("99e267e8-48c6-4fe3-999f-9e8599717b22"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("9a776989-8997-4644-be82-ad6055bb83c5"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("9a78b288-1880-44c9-af24-ba26abb1c339"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("9a91d388-d3dd-4614-846b-4b79a68538f5"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("9ac2f7c8-dfc8-4b34-92d7-3a060b4099c3"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("9b1638a0-115d-4267-9c2e-9d111758a89a"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("9c057e97-e9dd-465b-94a3-55032419e168"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("9c6342d4-8721-4bec-bc5d-0d57c4bfb52f"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("9cdfbffd-2693-4a1a-81e3-f2bad59e7c54"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("9d3d9753-c75d-4d2d-a714-b9496b6bfc90"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("9e05b1b3-f7c7-490d-a832-8ab1a3789797"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("9e56af7b-971b-4f27-9d4c-ad6e70d7e3bb"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("9e9d7fd2-1878-45c3-8719-2761d68421a4"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("a09472e6-e8ce-4b43-aded-b939f77c6d7c"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("a0ff5f63-b7dd-4841-ac44-d6ca5756e6ad"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("a104fc5c-a458-4845-aba4-10984a7698b3"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("a15af204-9184-448c-aa37-d01a95861696"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("a2377ed7-e86b-46d2-8ef8-a0b4e534f936"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("a2411943-1d1e-4c45-a481-06084c50cc7a"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("a2778e7a-22bb-4f58-a1b7-69d75d4e1297"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("a3156d0f-f884-44d4-b635-1e22700d6b6d"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("a3faa5e4-dc96-4485-b52f-c75b57d885b5"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("a4d141a6-9b6c-4a04-97e7-13660c8c04b6"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("a5dd86fb-7b65-4f5e-85b5-59d3688bb428"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("a6c2f440-5305-4181-88f8-ceba034d2932"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("a6d06abc-9184-4af4-8ecf-adfced498680"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("a77e9ec5-c7a8-43d7-8484-478f5abf6c1d"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("a7a4219d-e994-4de9-942c-a45f29175d47"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("a7a9428c-7db7-427c-aa78-4e21e5accfa2"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("a7aadc3b-f8bd-48be-8590-897b991bb54e"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("a86bd8a2-c386-45a9-af33-0a4805a4c813"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("a88e3137-f923-4c93-8151-b8a1d6141943"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("aa33fcb6-3725-4ee5-a12e-1054b15e8cd0"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("aa75b19d-d635-4f1e-aa7c-a309e6abc669"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("aa83a537-d4b8-45ae-948d-4120b5793cb2"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("aa9b7c05-1750-4187-a183-282c393c21df"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("aac3d084-98a2-43cb-a7dc-177be6e1102c"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("aaecf3c9-5fcd-4190-a1c7-c9ad93d3aec4"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("ab16b4f6-68a3-4324-994b-3af1986c4989"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("abc2ec60-4c08-413a-b6a7-02dde63108be"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("ac24f415-d398-4371-8be1-9c5f9ac3d9d9"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("ac541d16-4247-4ee9-b268-13841d66857d"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("ac8946a4-4794-4bdd-9e36-b424a019d2b1"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("acc71dcc-922a-4e69-a4a2-fdcd374ec58b"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("ad41d752-558b-4952-9629-10d219f62df2"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("ad489041-62e0-4317-b9c8-4798e1eeb70d"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("ad6a4186-0d6e-4fdb-a5f2-1d78756a2f91"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("ae24dd4d-c5a1-4e17-b649-5dc231ed508a"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("ae7a4657-f92e-4dd2-9617-4bc369dde239"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("aeae193f-6ee4-441c-abe1-0f7281fef36b"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("aeccecae-c036-4268-9709-6c2aaf32e859"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("af3c5e84-4b67-4268-a99a-c4817e5a0936"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("af46d003-cd67-46b7-a3bb-02ea968cf6d8"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("af629b26-f793-4859-b474-b17ddc8519c9"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("b124d5f8-2160-46b7-8a83-6ae83500e314"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("b2193b96-593f-4628-89af-3261df5d82ab"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("b2373446-0fb5-427d-a2b1-f05077e8ff74"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("b2a953c6-1d94-44d3-b0a0-abf0da366b5c"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("b2cbe997-8d47-4892-846e-e12a2ca06863"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("b2d39a9d-6eaf-4b6a-a438-5a9b5f299480"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("b37f08fc-5977-4f41-adb4-5717a0a271e4"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("b40f76f3-ff28-4806-ae7b-ff6cb211e2d9"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("b560cbfd-171e-4dda-b189-f9b2a8d0ab88"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("b597dad4-e94a-4acf-8ecf-3436cf5e96b9"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("b6cacdd0-7813-49ad-ac7b-41f1705c53f7"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("b6d091b6-22b8-42a1-b6d0-3f022fc1df3e"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("b755d8be-e91c-4b73-9b25-2f961ad186b0"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("b762e092-2e35-4eb9-aaf4-59c9a3996d31"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("b7d057b1-c45e-46da-b759-86583d276795"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("b87c6e65-a210-4b5f-8919-1006947bec22"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("b8b96d7d-4918-428f-ba65-cd118bf7d63b"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("b8e8cbc4-6b74-4c50-a098-1046a9ba00be"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("b9023a7d-6e41-4b04-8867-ad0ce39f763e"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("ba336f14-cef5-40c1-852e-05ca301b4cae"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("bb1bf163-f14c-4eef-9d0c-96a5ed9640cc"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("bb81a609-e0e8-4334-a904-ecdd493c24f4"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("bba146f3-f1df-4cab-8f8c-f59f43fe855d"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("bbfe42e4-5e7e-4aae-805f-aaa3bedae890"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("bc0601a6-fb89-4575-bb24-4510bb9e853f"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("bc7ddfed-45f6-45e2-a227-8f0d74bb10ec"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("bd09f22b-676e-4864-8fb3-f64c348194ac"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("bd8fb4fb-6550-4a54-acd6-973387859d0a"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("bdaa6217-cac1-4926-86c3-a696ea3fec28"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("bea45c1e-2488-4f86-b99a-e52c73709815"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("bef6f460-9964-495b-bd77-581cb0c39e6d"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("bf06be8a-b314-4c20-875f-ff917751f9b6"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("bf4d0de5-b5ee-4bbf-9bc0-f23df6d5965b"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("c0b5063d-44bf-42e9-8dde-4ebadbe79391"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("c148a4af-fdc0-4e0e-a1c9-e5f97a137755"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("c1739a03-f189-47c1-ab15-b9b23255fe5b"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("c1b908c3-f68c-412d-b1ad-218ad84352c8"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("c29b655c-8ebe-4cc0-abab-1e304c3d6471"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("c36239b5-adfa-4600-931b-0ec805e638a3"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("c47da043-47d4-40d9-97b4-72349b3f07e9"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("c51b7da1-eb46-4503-ae59-ab54f491024a"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("c540b166-5e6d-4223-86a2-f2aa676ad022"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("c5830631-95bd-48bb-b493-7a71bacfcb79"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("c591ab48-c851-4bf5-8efc-9961d24741bb"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("c5b89a28-8659-4bda-9d63-580200f55d32"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("c646d35d-2549-4356-b3ed-3e38122becd8"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("c670e351-520f-40e0-a0fc-22bdd4bc364a"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("c6dc63b7-0fc4-4c13-896f-26a95a367ebf"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("c7436917-afea-42ba-9723-e2e143a2ff91"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("c7baa91b-0bfa-4313-8aeb-d608d6dc3ce0"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("c7f0e84d-ac32-42f8-99a6-eefe624687db"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("c8286cc1-4863-4459-986a-4fce8f0af9a1"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("c85b7ec0-09ac-49bd-81bb-ecea97e782a8"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("c872f859-dc0e-4df4-91e4-53388687a349"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("c8add5b3-ee01-49d0-b903-fcae3b460aa2"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("c8d68beb-771f-4bd2-885e-5b3a0ac4ed66"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("c90134c5-8afb-41ca-9a57-781a066c3ea2"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("c912687d-ef31-4ed9-843d-f9b7050f7d42"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("c9319d11-55f9-4877-9db0-f582c5d60e43"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("ca978126-4a2f-4541-a78e-56a59b35d07a"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("caed32da-ff03-4a32-bad1-b9484088729d"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("cb0dd839-c113-4324-8145-c1b67807815a"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("cb152177-58e4-472e-bf4a-05980411f382"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("cb75452b-0a64-4748-a89f-e19f474cd4f1"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("cbb5d9d3-f018-4a9d-b8bb-aeca741bb4ca"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("cbb8d039-5643-4fc4-b287-8627068c52b0"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("cbcd5af8-7cce-464b-a352-a6fe5730463e"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("cbe99014-230e-44d8-8f73-3ed3e9d9621e"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("cbfe409b-c838-4264-916a-cba1b894f9fd"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("cca5fb20-2c38-4955-b3d5-bb7a408a35fc"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("ccd6df9a-7592-4f0a-a247-ceab980799f9"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("ccda628e-8435-41e1-a300-84559fac17dc"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("ccf40f54-60b9-4244-a678-1ff27b172f50"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("cd049916-d292-4380-975a-c8cbe02374e5"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("cd7f7b93-f325-45f4-87bf-a54ae215de18"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("ce2b6d47-7e23-4c9a-ab7b-65328b112a67"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("ce330a1c-43fc-4d78-ae42-8ad075b2afcd"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("cecb3cbf-e6ed-4c4f-9dda-4b2b5ed06ebc"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("cfe6d9f0-e3ae-4db5-a75f-8a651ba6c420"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("d010102d-b0bc-4b8a-99d7-8cdaa8cf6815"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("d0c62b2b-da03-46f6-9233-837b1dbe260c"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("d13c8830-8c8b-4594-9b40-225dcf20b6f3"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("d1ded914-5537-44fe-8060-edf929d5fa8a"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("d307f507-ac73-4ab4-a078-34a75f5d28ed"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("d3ae36c1-f060-4706-9872-cc000dd28e0e"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("d3bbdb33-2ffd-4892-8d86-4748d996e07a"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("d4044db2-3e76-4607-ac7c-11157f6d88ae"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("d46f8771-7734-41a7-a37a-7aa14da4a711"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("d4b3f515-0a2a-428a-be37-b95301eb48d3"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("d53964be-851f-4cb1-be85-7dc051104c4f"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("d53c5987-0225-4433-a019-0710d27074d3"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("d5624254-dcad-45bd-ad70-f1897e257d53"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("d69598eb-dd86-4068-a79e-4b1abe1c6234"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("d6a35e05-dc95-469b-8c71-ed35f78737b5"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("d75bc862-369b-4102-87f6-15887ca77cca"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("d7e40cc8-af1e-49ed-aedb-84859960f879"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("d88c4739-3b34-4ea7-9e5b-eda997ff8b06"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("d9a9568f-035c-4b12-a2f6-2388c95fae1c"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("da0a06f7-596f-446f-8f1c-57cb8d48195a"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("da872400-f047-4b46-b6a4-c52f78a94752"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("da8c313f-942c-4165-9040-e2c066794427"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("db472c58-414b-45d4-8010-1b40953b69fb"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("db5d6f13-be66-4791-a30b-239f06c23f56"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("dc7b7096-68a4-42c8-80a4-c8699eb4ecb9"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("dd544e13-d22a-4b07-bb58-4ca068674230"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("ddef33fc-55ab-4639-bbb0-001848e58400"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("ded616df-779b-4144-8aa6-27f5ab28846d"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("df295673-f749-464b-b862-90ef8573b339"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("e06e61d5-ebc1-4dc1-8696-4e98affee785"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("e07824af-9be1-4416-bab8-3fd15591ff8e"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("e0bac29c-0707-4dc7-8329-a7c26cfaab5d"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("e13c26b4-4d8e-489b-9b41-5158ef958bc3"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("e13f0afb-8fa5-49dc-ae3c-a894bfbe8301"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("e20f6181-e7ea-4e6f-8d60-9199e17c56a1"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("e296ed8c-a424-4f90-b77c-e169e6b7407b"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("e2d2c5d6-c47b-4737-ab4c-9e855eef1db8"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("e360290b-3578-4b1a-b9c7-ea83432c2b5c"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("e3752f57-199d-457e-97d5-39e0a6b48ea7"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("e4c3d301-7bc7-4162-b299-1799bd2177cd"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("e53f00a8-8909-4831-b80f-ace0e5fb5fed"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("e58b113a-af81-4e14-9255-ee8ffb58f517"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("e664d54c-0a08-4963-b774-267f96e44b58"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("e6807242-0442-4d83-979d-cb88575b2275"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("e6917750-4d58-48f7-beb1-3b9fcd470c0c"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("e6c00129-5326-4963-aab3-45a86106d368"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("e76b426a-1cb1-4e75-a669-38b2bbd62638"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("e8607c94-012b-4c7b-82fd-21d24111fbd5"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("e8adfecd-31f8-4171-9201-c58b423f6b70"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("e8fa6365-fdef-4e04-aabd-3bef751f3755"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("e91fa235-a18d-47dc-8c9b-261f9212eba4"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("e939c5c2-fbeb-4c47-b0cc-f6fd78778480"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("ea027f1a-0a20-446d-aa3d-36b46660e00f"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("eb2174e8-80a7-4425-bca2-0d00813ea546"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("eb37fc7f-4447-443e-b060-214a702131ca"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("eb879eb0-c554-4d0a-842d-32d04287293e"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("ed9699e9-954b-458b-b875-87279bf0581e"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("ef0487ca-b7c9-4d3d-9e25-cfcae2a33c91"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("ef1abf7d-4624-42ac-810c-610d571e8cff"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("f0037981-993b-4a56-a3e9-90bc8104cc56"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("f00cd64f-554a-4709-bd97-d8e12d0709db"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("f03cef71-a09d-482b-9b56-03cc36a3860e"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("f11b7b36-2b5c-49a4-b92b-2dc2e99c2a96"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("f12cf824-9c78-43b1-a479-62756710e323"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("f18e3444-409a-4c02-b0d4-612625afbee4"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("f19bf382-85d4-4f87-a80b-a1a141366ffd"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("f1fcf4b6-7467-474e-b696-3fb056b682ce"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("f20a88ff-294b-45cd-bf87-2dbaafe02d21"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("f23e5a2a-ebf1-41cb-8936-0544a34248d9"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("f254701c-007d-4fa3-80bc-3cd44a537acf"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("f2b43ce1-0053-436e-bd47-cad1c9894d3a"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("f2ee26f4-00ae-43b6-b749-94d708386d5e"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("f3a012e9-8801-480e-9593-061e44d1d689"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("f496d324-30d3-41e4-8072-6fd1e7034b82"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("f4aaedc9-e457-4008-9e54-a6e0742dae79"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("f4c55e76-fafc-4a20-9bef-25a2db55ae4f"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("f59eeb5e-c1b5-4e9c-9ca4-c744b19ec03e"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("f5a9a664-ecea-44d9-afd0-a799778928cf"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("f644d9a0-ffbf-4df1-9f5e-1de61b7c5f2f"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("f66b926b-6099-461a-80e6-cfec02e95b66"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("f696f51b-6c8e-4492-9e7a-e2c2a1bd15d0"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("f6b9ddbd-5a73-4297-9a72-66508cfce09d"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("f6d38c50-31b9-4cf0-93e0-8174abb09412"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("f6ea2538-d22a-41f2-b697-42c3064ca14f"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("f6f8e02e-ad30-48b5-9857-48389481d7f8"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("f766380b-4988-4b63-9a2c-7443a8f8b71f"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("f782e506-a616-43fb-86b4-4d520f103f2d"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("f7d95b32-784e-4c7d-af80-1478492b97dd"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("f8f94bd0-d0a4-49b1-9a88-a37539569f61"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("f8fc2115-8f20-4f83-a92e-6d6b519f672b"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("f9312f00-f78a-4835-bbb3-b8702bc1da86"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("f96b7101-0a16-4451-b4dc-6603f2dbfd84"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("f99a9ccc-e2a9-4f91-a54d-e24ea2bc0dd4"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("f9b851c3-236c-43d6-966d-ec919c0dd230"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("fa341e3f-e4e3-459d-989b-fa889b2036bd"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("fa61555a-bc5e-4d4d-811b-68c88f46c810"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("fa7987d5-7dcf-44c2-b33c-af8ac86c3c64"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("fa80304e-7e04-4a8f-b1da-c24a28c2357d"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("fb10b885-1c6e-4fd3-9bda-9cc9006c7bff"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("fb27cb61-0d4d-49e4-aff1-ca9bddd1627f"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("fbe65377-2681-4a7b-bfbb-e9d8974312c0"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("fc166347-528d-4512-90fe-043b6466baa7"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("fc274da2-2fa5-4c74-aef8-95b82ed7628d"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("fc79cc01-bb88-4fe0-890b-0aa26002fa67"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("fc84b3d2-4502-4c17-9182-037cc2642424"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("fcdfbc2f-50ae-488f-8451-54e66c105ac4"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("fd14706f-93f2-44fc-82b3-59f73c784ad1"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("fd789e9d-5ff5-416f-9f51-1789a022fd1b"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("fd857536-7d01-42ed-8a16-429d9c59cc48"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("fe3317c7-0dc4-45a9-91b4-0e86f3404009"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("fe891a6c-be70-42b1-a0e0-f56a26d1d33e"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("feb77b35-b2ae-4b29-82e2-814cad1113ae"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("febd66e6-6c73-4a52-ad0c-e296e10e181f"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: new Guid("ff6edb2e-18d5-443b-b3e2-0823beeb9875"));
        }
    }
}
