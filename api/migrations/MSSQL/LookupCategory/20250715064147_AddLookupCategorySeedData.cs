using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace budget_request_app.WebApi.Migrations.MSSQL.LookupCategory
{
    /// <inheritdoc />
    public partial class AddLookupCategorySeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "lookup",
                table: "LookupCategories",
                columns: new[] { "Id", "Created", "CreatedBy", "Deleted", "DeletedBy", "Description", "LastModified", "LastModifiedBy", "ModuleId", "Name", "TenantId" },
                values: new object[,]
                {
                    { new Guid("00316b5b-16ab-480a-8974-50f0f6dd97fe"), new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), null, null, "Request Group", new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), 2, "request_group_project", "root" },
                    { new Guid("0224d7e1-5841-49c4-8dd1-1cb4791bc028"), new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), null, null, "Request Group", new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), 1, "request_group", "root" },
                    { new Guid("08b0863c-ba0c-48f8-8702-06bbe6578170"), new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), null, null, "Department Head/Requestor", new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), 1, "department_head", "root" },
                    { new Guid("0f4e03dc-0ead-41ad-93a9-26b0b6a0af3a"), new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), null, null, "Change Type", new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), 2, "change_type", "root" },
                    { new Guid("13b9f0c2-c3b3-4b76-b238-1582ecfc81e8"), new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), null, null, "Pave", new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), 2, "pave", "root" },
                    { new Guid("1881c517-32e2-4c09-8bd2-09e2efe7dc61"), new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), null, null, "Funding Source - Other Funding", new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), 2, "funding_source_other_project", "root" },
                    { new Guid("18b298cd-91de-4b10-ae36-3bafd0ec02e8"), new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), null, null, "Departments", new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), 1, "departments", "root" },
                    { new Guid("26b6536f-76d3-47db-b395-2a758802bd13"), new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), null, null, "RoW", new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), 2, "row", "root" },
                    { new Guid("2c4caa8d-544b-4393-82be-9a5b7c221117"), new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), null, null, "Funding Source - Borrowed", new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), 2, "funding_source_borrowed_project", "root" },
                    { new Guid("2fbf3c72-e26f-4db8-a5de-180bc862d79e"), new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), null, null, "Funding Source - Operating/Utility/Enterprise Funding", new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), 2, "funding_source_ouef_project", "root" },
                    { new Guid("3c78d7af-5305-4138-9038-be7425fcecb2"), new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), null, null, "Approving Oversight Board", new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), 2, "approving_oversight_board_project", "root" },
                    { new Guid("41e3334c-a1be-4c55-a21c-8540053b458e"), new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), null, null, "Priority Rating", new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), 1, "priority_rating", "root" },
                    { new Guid("42aa7e76-c0e4-49da-a5b8-0ad3f7163673"), new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), null, null, "Funding Source - Other Funding", new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), 1, "funding_source_other", "root" },
                    { new Guid("449aa104-a5aa-43c4-8552-5aa69aa69960"), new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), null, null, "Funding Source - Operating Budget Impact", new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), 2, "funding_source_obi", "root" },
                    { new Guid("49921477-b361-4299-8fcb-5ec327ddf57c"), new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), null, null, "C & G Rating", new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), 2, "c_g_rating", "root" },
                    { new Guid("5516c30d-7a89-419e-be1b-0e5cb64f01ea"), new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), null, null, "TIF Districts", new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), 2, "tif_district", "root" },
                    { new Guid("578eae04-ecae-421b-b6e3-722eaee8fc0e"), new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), null, null, "Funding Type", new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), 2, "funding_type", "root" },
                    { new Guid("5baad37a-5ba1-4ec1-aaa3-992fa352a887"), new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), null, null, "Curb & Gutter", new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), 2, "curb_gutter", "root" },
                    { new Guid("69ce8d13-2884-4108-8a93-e7e05650a669"), new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), null, null, "Funding Source - Past Funding", new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), 2, "funding_source_past_project", "root" },
                    { new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"), new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), null, null, "Funding Source - Special Funding", new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), 2, "funding_source_special_project", "root" },
                    { new Guid("720119db-c9f6-442b-abd4-6dc1271e7ee1"), new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), null, null, "Sidewalks", new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), 2, "sidewalks", "root" },
                    { new Guid("7590f78d-2412-47a6-81b3-4c3acc462b14"), new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), null, null, "Request Status", new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), 2, "request_status_project", "root" },
                    { new Guid("761adb91-60e3-43bc-bbdf-bdf1b586d4f1"), new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), null, null, "Request Type", new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), 1, "request_type", "root" },
                    { new Guid("76854444-444f-4524-8a61-9fcb24e1c9b1"), new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), null, null, "Request Type", new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), 2, "request_type_project", "root" },
                    { new Guid("76fc224c-bc0a-4458-bf43-bfd8db3a0b83"), new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), null, null, "Department Head/Requestor", new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), 2, "department_head_project", "root" },
                    { new Guid("7b667e0f-6875-4180-b774-92136e36924b"), new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), null, null, "Utility Work", new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), 2, "utility_work", "root" },
                    { new Guid("910fb5e3-80a0-4a46-b616-8cb94f56e86f"), new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), null, null, "Equipment Category", new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), 1, "equipment_category", "root" },
                    { new Guid("93985952-4e53-4b3d-a897-8bec835d8d42"), new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), null, null, "Request Status", new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), 1, "request_status", "root" },
                    { new Guid("93a30161-93b4-4b47-81f4-021f3f27bb66"), new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), null, null, "Funding Source - Special Funding", new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), 1, "funding_source_special", "root" },
                    { new Guid("95f8e0c2-b1dd-44b4-aa66-09f63efddc48"), new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), null, null, "Change Set", new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), 2, "change_set", "root" },
                    { new Guid("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"), new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), null, null, "Expenditure Category", new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), 2, "expenditure_category", "root" },
                    { new Guid("aef1cf33-b160-4229-a360-691194d2336b"), new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), null, null, "Funding Changes", new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), 2, "funding_changes", "root" },
                    { new Guid("b44e86cb-1388-4c3f-ae4c-94d3df4f662b"), new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), null, null, "Funding Source - Operating/Utility/Enterprise Funding", new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), 1, "funding_source_ouef", "root" },
                    { new Guid("b4fe9e53-b0cc-4a8b-89d7-712bfc97ac24"), new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), null, null, "Purpose of Expenditure", new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), 1, "expenditure_purpose", "root" },
                    { new Guid("bd4dd1db-1f4d-455c-846b-4e0b620dfb1d"), new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), null, null, "Streetscaping/Lighting", new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), 2, "streetscaping_lighting", "root" },
                    { new Guid("c1353eb7-87ca-4cca-9d5c-f87bd4ae97c8"), new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), null, null, "Departments", new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), 2, "departments_project", "root" },
                    { new Guid("c4121504-a142-4624-9c71-8764661893aa"), new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), null, null, "Project Status", new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), 2, "project_status", "root" },
                    { new Guid("c641a57f-5f5e-4458-b940-4c9e562ff653"), new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), null, null, "Safety Improvements", new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), 2, "safety_improvements", "root" },
                    { new Guid("c72a2551-f9d5-4b61-bfe7-0cb74bd53de4"), new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), null, null, "Funding Source - Past Funding", new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), 1, "funding_source_past", "root" },
                    { new Guid("cf4a4d66-6ced-43f2-959d-613c2fa2110d"), new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), null, null, "Approving Oversight Board", new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), 1, "approving_oversight_board", "root" },
                    { new Guid("d2b40805-4186-4088-ac14-16be43330171"), new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), null, null, "Funding Source - Past Funding Sub", new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), 1, "funding_source_past_sub", "root" },
                    { new Guid("db09f0d8-49fe-41af-99a3-01c0d498d8de"), new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), null, null, "Spending Purpose", new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), 2, "spending_purpose", "root" },
                    { new Guid("e0dd3254-0249-4f71-8c70-36063346ad72"), new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), null, null, "Funding Source - Borrowed", new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), 1, "funding_source_borrowed", "root" },
                    { new Guid("e2bc2f40-b296-48b6-bfaa-faf91bd5539e"), new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), null, null, "Pavement Rating", new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), 2, "pavement_rating", "root" },
                    { new Guid("ea188a54-8da6-4c4c-bedf-89a079480790"), new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), null, null, "Department Point Of Contact", new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), 2, "department_contact", "root" },
                    { new Guid("eb07f930-9e73-4cda-a9eb-98c4ec2a2afc"), new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), null, null, "Funding Source - Grant Funding", new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), 2, "funding_source_grant_project", "root" },
                    { new Guid("ecc83d3f-910a-4d5c-a8fe-25014b9544d6"), new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), null, null, "Funding Source - Donations", new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), 1, "funding_source_donation", "root" },
                    { new Guid("f0770a04-79f8-488e-b674-d1dde98e8079"), new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), null, null, "Funding Source - Grant Funding", new DateTimeOffset(new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000001"), 1, "funding_source_grant", "root" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupCategories",
                keyColumn: "Id",
                keyValue: new Guid("00316b5b-16ab-480a-8974-50f0f6dd97fe"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupCategories",
                keyColumn: "Id",
                keyValue: new Guid("0224d7e1-5841-49c4-8dd1-1cb4791bc028"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupCategories",
                keyColumn: "Id",
                keyValue: new Guid("08b0863c-ba0c-48f8-8702-06bbe6578170"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupCategories",
                keyColumn: "Id",
                keyValue: new Guid("0f4e03dc-0ead-41ad-93a9-26b0b6a0af3a"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupCategories",
                keyColumn: "Id",
                keyValue: new Guid("13b9f0c2-c3b3-4b76-b238-1582ecfc81e8"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupCategories",
                keyColumn: "Id",
                keyValue: new Guid("1881c517-32e2-4c09-8bd2-09e2efe7dc61"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupCategories",
                keyColumn: "Id",
                keyValue: new Guid("18b298cd-91de-4b10-ae36-3bafd0ec02e8"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupCategories",
                keyColumn: "Id",
                keyValue: new Guid("26b6536f-76d3-47db-b395-2a758802bd13"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupCategories",
                keyColumn: "Id",
                keyValue: new Guid("2c4caa8d-544b-4393-82be-9a5b7c221117"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupCategories",
                keyColumn: "Id",
                keyValue: new Guid("2fbf3c72-e26f-4db8-a5de-180bc862d79e"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupCategories",
                keyColumn: "Id",
                keyValue: new Guid("3c78d7af-5305-4138-9038-be7425fcecb2"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupCategories",
                keyColumn: "Id",
                keyValue: new Guid("41e3334c-a1be-4c55-a21c-8540053b458e"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupCategories",
                keyColumn: "Id",
                keyValue: new Guid("42aa7e76-c0e4-49da-a5b8-0ad3f7163673"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupCategories",
                keyColumn: "Id",
                keyValue: new Guid("449aa104-a5aa-43c4-8552-5aa69aa69960"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupCategories",
                keyColumn: "Id",
                keyValue: new Guid("49921477-b361-4299-8fcb-5ec327ddf57c"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupCategories",
                keyColumn: "Id",
                keyValue: new Guid("5516c30d-7a89-419e-be1b-0e5cb64f01ea"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupCategories",
                keyColumn: "Id",
                keyValue: new Guid("578eae04-ecae-421b-b6e3-722eaee8fc0e"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupCategories",
                keyColumn: "Id",
                keyValue: new Guid("5baad37a-5ba1-4ec1-aaa3-992fa352a887"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupCategories",
                keyColumn: "Id",
                keyValue: new Guid("69ce8d13-2884-4108-8a93-e7e05650a669"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupCategories",
                keyColumn: "Id",
                keyValue: new Guid("6f8d4db4-4d44-4445-90c4-37427636d4c0"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupCategories",
                keyColumn: "Id",
                keyValue: new Guid("720119db-c9f6-442b-abd4-6dc1271e7ee1"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupCategories",
                keyColumn: "Id",
                keyValue: new Guid("7590f78d-2412-47a6-81b3-4c3acc462b14"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupCategories",
                keyColumn: "Id",
                keyValue: new Guid("761adb91-60e3-43bc-bbdf-bdf1b586d4f1"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupCategories",
                keyColumn: "Id",
                keyValue: new Guid("76854444-444f-4524-8a61-9fcb24e1c9b1"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupCategories",
                keyColumn: "Id",
                keyValue: new Guid("76fc224c-bc0a-4458-bf43-bfd8db3a0b83"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupCategories",
                keyColumn: "Id",
                keyValue: new Guid("7b667e0f-6875-4180-b774-92136e36924b"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupCategories",
                keyColumn: "Id",
                keyValue: new Guid("910fb5e3-80a0-4a46-b616-8cb94f56e86f"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupCategories",
                keyColumn: "Id",
                keyValue: new Guid("93985952-4e53-4b3d-a897-8bec835d8d42"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupCategories",
                keyColumn: "Id",
                keyValue: new Guid("93a30161-93b4-4b47-81f4-021f3f27bb66"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupCategories",
                keyColumn: "Id",
                keyValue: new Guid("95f8e0c2-b1dd-44b4-aa66-09f63efddc48"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupCategories",
                keyColumn: "Id",
                keyValue: new Guid("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupCategories",
                keyColumn: "Id",
                keyValue: new Guid("aef1cf33-b160-4229-a360-691194d2336b"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupCategories",
                keyColumn: "Id",
                keyValue: new Guid("b44e86cb-1388-4c3f-ae4c-94d3df4f662b"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupCategories",
                keyColumn: "Id",
                keyValue: new Guid("b4fe9e53-b0cc-4a8b-89d7-712bfc97ac24"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupCategories",
                keyColumn: "Id",
                keyValue: new Guid("bd4dd1db-1f4d-455c-846b-4e0b620dfb1d"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupCategories",
                keyColumn: "Id",
                keyValue: new Guid("c1353eb7-87ca-4cca-9d5c-f87bd4ae97c8"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupCategories",
                keyColumn: "Id",
                keyValue: new Guid("c4121504-a142-4624-9c71-8764661893aa"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupCategories",
                keyColumn: "Id",
                keyValue: new Guid("c641a57f-5f5e-4458-b940-4c9e562ff653"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupCategories",
                keyColumn: "Id",
                keyValue: new Guid("c72a2551-f9d5-4b61-bfe7-0cb74bd53de4"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupCategories",
                keyColumn: "Id",
                keyValue: new Guid("cf4a4d66-6ced-43f2-959d-613c2fa2110d"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupCategories",
                keyColumn: "Id",
                keyValue: new Guid("d2b40805-4186-4088-ac14-16be43330171"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupCategories",
                keyColumn: "Id",
                keyValue: new Guid("db09f0d8-49fe-41af-99a3-01c0d498d8de"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupCategories",
                keyColumn: "Id",
                keyValue: new Guid("e0dd3254-0249-4f71-8c70-36063346ad72"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupCategories",
                keyColumn: "Id",
                keyValue: new Guid("e2bc2f40-b296-48b6-bfaa-faf91bd5539e"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupCategories",
                keyColumn: "Id",
                keyValue: new Guid("ea188a54-8da6-4c4c-bedf-89a079480790"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupCategories",
                keyColumn: "Id",
                keyValue: new Guid("eb07f930-9e73-4cda-a9eb-98c4ec2a2afc"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupCategories",
                keyColumn: "Id",
                keyValue: new Guid("ecc83d3f-910a-4d5c-a8fe-25014b9544d6"));

            migrationBuilder.DeleteData(
                schema: "lookup",
                table: "LookupCategories",
                keyColumn: "Id",
                keyValue: new Guid("f0770a04-79f8-488e-b674-d1dde98e8079"));
        }
    }
}
