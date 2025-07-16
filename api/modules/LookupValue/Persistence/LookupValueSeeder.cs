using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using budget_request_app.WebApi.LookupValue.Domain;
using Finbuckle.MultiTenant;
using Finbuckle.MultiTenant.Abstractions;
using FSH.Framework.Infrastructure.Tenant;

namespace budget_request_app.WebApi.LookupValue.Persistence;

public class LookupValueItemNew
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public Guid LookupCategoryId { get; set; }
    public string? TenantId { get; set; }
    public DateTimeOffset Created { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTimeOffset LastModified { get; set; }
    public Guid LastModifiedBy { get; set; }
    public bool? IsActive { get; set; }
}
public static class LookupValueSeeder
{
    public static IEnumerable<object> GetSeedData() => new object[]
    {
    new LookupValueItemNew
{
    Id = Guid.Parse("ddef33fc-55ab-4639-bbb0-001848e58400"),
    Name = @"Parks, Recreation & Forestry",
    LookupCategoryId = Guid.Parse("c1353eb7-87ca-4cca-9d5c-f87bd4ae97c8"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T17:26:03.3511220+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T17:26:03.3511220+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("029e7e7c-f42d-436a-9d5a-00cdfd7afa13"),
    Name = @"Utility - Sanitary Sewer Utility Funds (Fund 630)",
    LookupCategoryId = Guid.Parse("2fbf3c72-e26f-4db8-a5de-180bc862d79e"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:01:20.0697978+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:01:20.0697978+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("79c3f898-9f84-46e2-b250-00f18e03060f"),
    Name = @"LA CROSSE CTR FOOD AND BEVERAG (Fund 579)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:13:37.8846091+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:13:37.8846091+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("894c5acf-eb82-4286-b7cc-018c7db7731a"),
    Name = @"VICTIMS OF CRIME GRANT (VOCA) (Fund 546)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:19:27.7278492+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:19:27.7278492+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("53109d06-056c-40e0-b421-023db5651201"),
    Name = @"ALTERNATIVE FUEL (Fund 540)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:08:43.1370878+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:08:43.1370878+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("4dbeebce-7455-42cc-8791-029be7309883"),
    Name = @"K-9 UNIT (Fund 578)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:13:23.1663793+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:13:23.1663793+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("abc2ec60-4c08-413a-b6a7-02dde63108be"),
    Name = @"General - Special Appropriations Operating Budget (Dept 423)",
    LookupCategoryId = Guid.Parse("2fbf3c72-e26f-4db8-a5de-180bc862d79e"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:00:38.6548160+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:00:38.6548160+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("af46d003-cd67-46b7-a3bb-02ea968cf6d8"),
    Name = @"General - Mayor Operating Budget (Dept 550)",
    LookupCategoryId = Guid.Parse("b44e86cb-1388-4c3f-ae4c-94d3df4f662b"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T06:50:55.0937380+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T06:50:55.0937380+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("646a13fa-1e68-49ba-841c-03486759cdaf"),
    Name = @"Fiber",
    LookupCategoryId = Guid.Parse("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:56:45.0171282+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:56:45.0171282+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("6efa5e41-8b70-4587-98ec-035ccabf0af3"),
    Name = @"11 - Gateway Redevelpment",
    LookupCategoryId = Guid.Parse("5516c30d-7a89-419e-be1b-0e5cb64f01ea"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-20T05:06:51.9852155+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-20T05:06:51.9852155+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("fc84b3d2-4502-4c17-9182-037cc2642424"),
    Name = @"2025 CPC Draft",
    LookupCategoryId = Guid.Parse("95f8e0c2-b1dd-44b4-aa66-09f63efddc48"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T17:15:51.7492423+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T17:15:51.7492423+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("f03cef71-a09d-482b-9b56-03cc36a3860e"),
    Name = @"SMALL BUSINESS DEVELOPMNT LOAN (Fund 2030)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:18:25.4133068+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:18:25.4133068+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("fc166347-528d-4512-90fe-043b6466baa7"),
    Name = @"LAX CTR ROOM TAX SURPLUS (Fund 294)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:13:44.8822895+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:13:44.8822895+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("29251245-a159-4a9d-a75a-04aec242699c"),
    Name = @"Land Acquisition",
    LookupCategoryId = Guid.Parse("db09f0d8-49fe-41af-99a3-01c0d498d8de"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T17:47:51.0114680+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T17:47:51.0114680+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("f23e5a2a-ebf1-41cb-8936-0544a34248d9"),
    Name = @"Existing Bond Funds",
    LookupCategoryId = Guid.Parse("42aa7e76-c0e4-49da-a5b8-0ad3f7163673"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-06T06:50:39.4466667+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-06T06:50:39.4466667+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("172fa433-d257-4d55-ba44-05794ecf6e29"),
    Name = @"Sanitary Sewer/Wastewater - Sanitary Sewer Mains",
    LookupCategoryId = Guid.Parse("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:59:53.7446868+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:59:53.7446868+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("441ab957-ca07-441c-a2ca-0586f3ceb6f8"),
    Name = @"AMTRAK DEPOT (Fund 205)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:08:49.0855656+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:08:49.0855656+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("cb152177-58e4-472e-bf4a-05980411f382"),
    Name = @"TIF Bonds/Notes: 11 - Gateway Redevelopment",
    LookupCategoryId = Guid.Parse("2c4caa8d-544b-4393-82be-9a5b7c221117"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T05:52:55.6742980+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T05:52:55.6742980+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("7c724313-8c93-410e-944b-05a81b6c1b78"),
    Name = @"Fair",
    LookupCategoryId = Guid.Parse("49921477-b361-4299-8fcb-5ec327ddf57c"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-19T07:35:13.1129974+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-19T07:35:13.1129974+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("ba336f14-cef5-40c1-852e-05ca301b4cae"),
    Name = @"FIRE DEPT EMS SERVICES (Fund 242)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:11:12.3160927+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:11:12.3160927+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("6a1083a3-6f8b-4723-bd91-05cadfa9a8b7"),
    Name = @"TIF Bonds/Notes: 16 - LIPCO/Trane Plant 6",
    LookupCategoryId = Guid.Parse("e0dd3254-0249-4f71-8c70-36063346ad72"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T05:50:26.7636917+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T05:50:26.7636917+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("a2411943-1d1e-4c45-a481-06084c50cc7a"),
    Name = @"101 - LA CROSSE CENTER",
    LookupCategoryId = Guid.Parse("449aa104-a5aa-43c4-8552-5aa69aa69960"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-18T01:37:47.0839667+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-18T01:37:47.0839667+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("f3a012e9-8801-480e-9593-061e44d1d689"),
    Name = @"Funding Increased",
    LookupCategoryId = Guid.Parse("0f4e03dc-0ead-41ad-93a9-26b0b6a0af3a"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T17:14:33.7908073+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T17:14:33.7908073+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("d53c5987-0225-4433-a019-0710d27074d3"),
    Name = @"POLICE DRUG INVESTIGATION (Fund 524)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:16:22.4923705+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:16:22.4923705+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("4a1796a4-1886-437f-a5ec-073701c39f1b"),
    Name = @"BICYCLE TRAIL (Fund 208)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:09:08.6132390+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:09:08.6132390+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("57f35fba-2d07-4197-94bb-07bf8d5bf4a9"),
    Name = @"Sanitary Sewer/Wastewater - Wastewater Treatment Plant",
    LookupCategoryId = Guid.Parse("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T07:00:00.7334144+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T07:00:00.7334144+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("379e4563-c28f-452f-9067-07f1a100e022"),
    Name = @"Project",
    LookupCategoryId = Guid.Parse("76854444-444f-4524-8a61-9fcb24e1c9b1"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-03-27T05:37:47.0945194+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-03-27T05:37:47.0945194+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("ff6edb2e-18d5-443b-b3e2-0823beeb9875"),
    Name = @"Enterprise - Airport Operating Funds (Fund 600)",
    LookupCategoryId = Guid.Parse("b44e86cb-1388-4c3f-ae4c-94d3df4f662b"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-06T06:50:19.8300000+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-21T05:34:41.3688355+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("716c7ab5-fa5d-4a46-b6c1-0a06172d30a2"),
    Name = @"GRIEVANCE PROCEDURE FUND (Fund 217)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:12:35.6711896+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:12:35.6711896+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("2885db15-fde1-405b-aeab-0a266fb5dc7b"),
    Name = @"Water - Wells, Pumphouses and Reservoir",
    LookupCategoryId = Guid.Parse("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T07:01:43.8629888+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T07:01:43.8629888+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("8bb68ec9-48f1-4cd4-8825-0a4074aa5d20"),
    Name = @"Board of Public Works",
    LookupCategoryId = Guid.Parse("cf4a4d66-6ced-43f2-959d-613c2fa2110d"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T01:17:41.9877124+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T01:17:41.9877124+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("a86bd8a2-c386-45a9-af33-0a4805a4c813"),
    Name = @"Unknown",
    LookupCategoryId = Guid.Parse("f0770a04-79f8-488e-b674-d1dde98e8079"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-21T05:34:15.9583314+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-21T05:34:15.9583314+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("5e95db11-08b3-4517-b367-0a488ddeee9b"),
    Name = @"TUITION REIMBURSEMENT (Fund 576)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:19:03.4234427+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:19:03.4234427+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("fc79cc01-bb88-4fe0-890b-0aa26002fa67"),
    Name = @"Community Development Committee",
    LookupCategoryId = Guid.Parse("3c78d7af-5305-4138-9038-be7425fcecb2"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T02:46:19.6323103+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T02:46:19.6323103+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("762129a9-181a-4957-ad86-0b0f582343c1"),
    Name = @"Board of Park Commissioners",
    LookupCategoryId = Guid.Parse("3c78d7af-5305-4138-9038-be7425fcecb2"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T17:12:15.2758483+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T17:12:15.2758483+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("46183932-e00a-4e07-9287-0b2482ae42fd"),
    Name = @"Streets - DOT Projects",
    LookupCategoryId = Guid.Parse("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T07:00:31.7085473+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T07:00:31.7085473+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("eb2174e8-80a7-4425-bca2-0d00813ea546"),
    Name = @"Group Second",
    LookupCategoryId = Guid.Parse("0224d7e1-5841-49c4-8dd1-1cb4791bc028"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-13T06:35:08.0506840+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-13T06:35:08.0506840+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("9c6342d4-8721-4bec-bc5d-0d57c4bfb52f"),
    Name = @"Flottmeyer, James",
    LookupCategoryId = Guid.Parse("76fc224c-bc0a-4458-bf43-bfd8db3a0b83"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T17:31:12.5564740+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T17:31:12.5564740+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("1b9c7555-d145-4020-bb54-0d87410ed50f"),
    Name = @"Public Safety - Municipal Court",
    LookupCategoryId = Guid.Parse("00316b5b-16ab-480a-8974-50f0f6dd97fe"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T02:56:43.1258568+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T02:56:43.1258568+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("fe3317c7-0dc4-45a9-91b4-0e86f3404009"),
    Name = @"Bridges",
    LookupCategoryId = Guid.Parse("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-19T07:02:46.7186180+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-19T07:02:46.7186180+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("0e2c8070-66d2-4255-adfa-0e99cc1bf89c"),
    Name = @"18 - River Point District",
    LookupCategoryId = Guid.Parse("5516c30d-7a89-419e-be1b-0e5cb64f01ea"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-26T12:59:43.4780982+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-26T12:59:43.4780982+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("c36239b5-adfa-4600-931b-0ec805e638a3"),
    Name = @"Water - Watermains",
    LookupCategoryId = Guid.Parse("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T07:01:37.0673903+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T07:01:37.0673903+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("aeae193f-6ee4-441c-abe1-0f7281fef36b"),
    Name = @"Equipment and Tools",
    LookupCategoryId = Guid.Parse("910fb5e3-80a0-4a46-b616-8cb94f56e86f"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-06T06:49:39.8700000+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-06T06:49:39.8700000+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("b87c6e65-a210-4b5f-8919-1006947bec22"),
    Name = @"Entered by Department",
    LookupCategoryId = Guid.Parse("7590f78d-2412-47a6-81b3-4c3acc462b14"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-18T05:59:17.7551449+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T02:48:19.1919003+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("b8e8cbc4-6b74-4c50-a098-1046a9ba00be"),
    Name = @"Other",
    LookupCategoryId = Guid.Parse("db09f0d8-49fe-41af-99a3-01c0d498d8de"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T17:48:53.6479088+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T17:48:53.6479088+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("aa33fcb6-3725-4ee5-a12e-1054b15e8cd0"),
    Name = @"Streets",
    LookupCategoryId = Guid.Parse("18b298cd-91de-4b10-ae36-3bafd0ec02e8"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-21T23:08:09.4057465+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-21T23:08:09.4057465+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("07b3502a-690f-4d52-9e49-109666cd0c91"),
    Name = @"General - Fire Operating Budget (Dept 370)",
    LookupCategoryId = Guid.Parse("2fbf3c72-e26f-4db8-a5de-180bc862d79e"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T05:58:40.2224190+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T05:58:40.2224190+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("a104fc5c-a458-4845-aba4-10984a7698b3"),
    Name = @"Planning/Design",
    LookupCategoryId = Guid.Parse("db09f0d8-49fe-41af-99a3-01c0d498d8de"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T17:47:39.3212889+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T17:47:39.3212889+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("ad41d752-558b-4952-9629-10d219f62df2"),
    Name = @"Enlargement",
    LookupCategoryId = Guid.Parse("26b6536f-76d3-47db-b395-2a758802bd13"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-19T07:36:19.5391180+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-19T07:36:19.5391180+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("d4044db2-3e76-4607-ac7c-11157f6d88ae"),
    Name = @"Reserve Fund Reduction",
    LookupCategoryId = Guid.Parse("1881c517-32e2-4c09-8bd2-09e2efe7dc61"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:04:10.1179822+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:04:10.1179822+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("70dc2871-45af-4f39-ae5a-11249395d0ee"),
    Name = @"Streets - Traffic Signals",
    LookupCategoryId = Guid.Parse("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T07:00:51.1054594+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T07:00:51.1054594+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("4dfdf388-c842-45ef-b689-11fd7a7de42f"),
    Name = @"Plan and Dev - Economic Development",
    LookupCategoryId = Guid.Parse("00316b5b-16ab-480a-8974-50f0f6dd97fe"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T02:55:24.6488903+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T02:55:24.6488903+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("9625b0bf-a0ab-4a72-9c13-1265984c819f"),
    Name = @"TIF Bonds/Notes: 6 - City Vision Downtown",
    LookupCategoryId = Guid.Parse("e0dd3254-0249-4f71-8c70-36063346ad72"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T05:51:01.1814401+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T05:51:01.1814401+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("a4d141a6-9b6c-4a04-97e7-13660c8c04b6"),
    Name = @"General - Parks, Recreation and Forestry Operating Budget (Dept 761)",
    LookupCategoryId = Guid.Parse("b44e86cb-1388-4c3f-ae4c-94d3df4f662b"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T06:50:26.9750875+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T06:50:26.9750875+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("ac541d16-4247-4ee9-b268-13841d66857d"),
    Name = @"Judiciary & Administration Committee",
    LookupCategoryId = Guid.Parse("cf4a4d66-6ced-43f2-959d-613c2fa2110d"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T01:18:51.6843685+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T01:18:51.6843685+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("f7d95b32-784e-4c7d-af80-1478492b97dd"),
    Name = @"GIDEON HIXON SCULPTURE (Fund 572)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:12:08.9974063+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:12:08.9974063+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("60896384-1b49-4777-a210-1504a525b2c2"),
    Name = @"General - Room Tax Operating Budget (Dept 791)",
    LookupCategoryId = Guid.Parse("2fbf3c72-e26f-4db8-a5de-180bc862d79e"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:00:32.7260540+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:00:32.7260540+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("d75bc862-369b-4102-87f6-15887ca77cca"),
    Name = @"Parks - Aquatics Facilities",
    LookupCategoryId = Guid.Parse("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:57:30.7554531+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:57:30.7554531+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("332dc9b4-695f-4ad3-ac2a-16bd03e27122"),
    Name = @"Aviation Board",
    LookupCategoryId = Guid.Parse("3c78d7af-5305-4138-9038-be7425fcecb2"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T02:45:02.7069238+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T02:45:02.7069238+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("aac3d084-98a2-43cb-a7dc-177be6e1102c"),
    Name = @"Community Development and Housing",
    LookupCategoryId = Guid.Parse("c1353eb7-87ca-4cca-9d5c-f87bd4ae97c8"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T17:19:33.1083941+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T17:19:33.1083941+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("fd789e9d-5ff5-416f-9f51-1789a022fd1b"),
    Name = @"MISCELLANEOUS GRANTS (Fund 571)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:14:24.8680242+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:14:24.8680242+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("e4c3d301-7bc7-4162-b299-1799bd2177cd"),
    Name = @"Flood Control - Floodplain Control and Relief",
    LookupCategoryId = Guid.Parse("00316b5b-16ab-480a-8974-50f0f6dd97fe"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T02:54:00.1794672+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T02:54:00.1794672+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("08662cba-f8a1-447b-8418-18602cf49415"),
    Name = @"General - Police Operating Budget (Dept 850)",
    LookupCategoryId = Guid.Parse("2fbf3c72-e26f-4db8-a5de-180bc862d79e"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:00:10.3286242+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:00:10.3286242+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("8253aa37-6e01-4f67-b9a8-18efd3fe9e06"),
    Name = @"CDBG RECOVERY FUNDS (Fund 2070)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:10:13.1704542+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:10:13.1704542+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("144cefe8-e8ae-4285-b0f7-19af4221215c"),
    Name = @"CITY WIDE HSNG RENEW PROGRAM (Fund 582)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:10:19.0393992+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:10:19.0393992+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("28bf110a-f8b7-46f4-a1fb-19e8db1077e0"),
    Name = @"Approved by Finance",
    LookupCategoryId = Guid.Parse("7590f78d-2412-47a6-81b3-4c3acc462b14"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T02:48:46.7647274+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T02:48:46.7647274+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("4b8d28ce-1bf3-46de-b999-19efd918cb9a"),
    Name = @"City Plan Commission",
    LookupCategoryId = Guid.Parse("cf4a4d66-6ced-43f2-959d-613c2fa2110d"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T01:17:51.6147024+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T01:17:51.6147024+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("22bc6809-68c9-4493-b4c9-1a271106475e"),
    Name = @"Rejected by Finance",
    LookupCategoryId = Guid.Parse("7590f78d-2412-47a6-81b3-4c3acc462b14"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T02:48:36.5809251+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T02:48:36.5809251+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("4d7d40e1-cdf1-4e52-bc47-1a7e5928e3bf"),
    Name = @"Library",
    LookupCategoryId = Guid.Parse("c1353eb7-87ca-4cca-9d5c-f87bd4ae97c8"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T17:24:46.9538035+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T17:24:46.9538035+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("676b5e58-aa0a-47b8-b8a2-1ab1b3b57f03"),
    Name = @"Fire Stations",
    LookupCategoryId = Guid.Parse("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:56:51.1501121+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:56:51.1501121+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("6acfa308-89fb-4a06-a181-1b3f6dc4e984"),
    Name = @"Parks - General Improvements",
    LookupCategoryId = Guid.Parse("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:57:56.4182676+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:57:56.4182676+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("db472c58-414b-45d4-8010-1b40953b69fb"),
    Name = @"Storm Sewer/Stormwater - Lift Stations",
    LookupCategoryId = Guid.Parse("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T07:00:06.3437221+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T07:00:06.3437221+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("1d08fb75-b304-465a-943c-1b481e7dedeb"),
    Name = @"La Crosse Center Board",
    LookupCategoryId = Guid.Parse("cf4a4d66-6ced-43f2-959d-613c2fa2110d"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T01:19:28.5855050+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T01:19:28.5855050+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("2d4674f6-b2fd-4515-a0b5-1b8f89b5895c"),
    Name = @"Greschner, Jacky",
    LookupCategoryId = Guid.Parse("08b0863c-ba0c-48f8-8702-06bbe6578170"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-03-19T05:33:39.8700876+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-27T01:26:57.0997428+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("2f7cee83-1d27-4c44-8303-1bbbfaf51872"),
    Name = @"PASSENGER FACILITY CHARGE (Fund 2002)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:15:19.2247260+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:15:19.2247260+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("ad6a4186-0d6e-4fdb-a5f2-1d78756a2f91"),
    Name = @"Mayor",
    LookupCategoryId = Guid.Parse("18b298cd-91de-4b10-ae36-3bafd0ec02e8"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-21T23:04:34.0371742+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-21T23:04:34.0371742+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("f644d9a0-ffbf-4df1-9f5e-1de61b7c5f2f"),
    Name = @"Neighborhood Revitalization Commission",
    LookupCategoryId = Guid.Parse("cf4a4d66-6ced-43f2-959d-613c2fa2110d"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T01:19:49.1991790+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T01:19:49.1991790+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("08903189-9966-4262-b2c1-1e0fc249a91e"),
    Name = @"TIF Bonds/Notes: 14 - Gundersen Lutheran",
    LookupCategoryId = Guid.Parse("2c4caa8d-544b-4393-82be-9a5b7c221117"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T05:53:17.6023629+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T05:53:17.6023629+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("a3156d0f-f884-44d4-b635-1e22700d6b6d"),
    Name = @"0",
    LookupCategoryId = Guid.Parse("e2bc2f40-b296-48b6-bfaa-faf91bd5539e"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-19T06:50:03.7853192+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-19T06:50:03.7853192+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("c29b655c-8ebe-4cc0-abab-1e304c3d6471"),
    Name = @"Airport - Terminal",
    LookupCategoryId = Guid.Parse("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:55:19.0740039+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:55:19.0740039+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("ccf40f54-60b9-4244-a678-1ff27b172f50"),
    Name = @"Municipal Transit Utility Board",
    LookupCategoryId = Guid.Parse("3c78d7af-5305-4138-9038-be7425fcecb2"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T02:47:18.8100225+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T02:47:18.8100225+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("750bf786-a886-4bb9-8fb5-2071d327d746"),
    Name = @"General - IT Operating Budget (Dept 580)",
    LookupCategoryId = Guid.Parse("2fbf3c72-e26f-4db8-a5de-180bc862d79e"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T05:59:28.0880786+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T05:59:28.0880786+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("eb37fc7f-4447-443e-b060-214a702131ca"),
    Name = @"ADULT SPORTS NON-RESIDENT (Fund 510)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:08:36.5075532+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:08:36.5075532+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("c1b908c3-f68c-412d-b1ad-218ad84352c8"),
    Name = @"State",
    LookupCategoryId = Guid.Parse("eb07f930-9e73-4cda-a9eb-98c4ec2a2afc"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T05:55:05.3003546+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T05:55:05.3003546+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("e8607c94-012b-4c7b-82fd-21d24111fbd5"),
    Name = @"Finance & Personnel Committee",
    LookupCategoryId = Guid.Parse("3c78d7af-5305-4138-9038-be7425fcecb2"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T02:46:42.1872498+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T02:46:42.1872498+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("6ae74ffe-54e4-4af6-828c-21f4ed24d9b4"),
    Name = @"General - Fire Prevention and Building Safety Operating Budget (Dept 889)",
    LookupCategoryId = Guid.Parse("2fbf3c72-e26f-4db8-a5de-180bc862d79e"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T05:58:46.8732164+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T05:58:46.8732164+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("91c3944d-ac19-4fb2-b340-21f640630065"),
    Name = @"Grounds and Buildings",
    LookupCategoryId = Guid.Parse("18b298cd-91de-4b10-ae36-3bafd0ec02e8"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-21T22:58:01.1336201+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-21T22:58:01.1336201+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("d13c8830-8c8b-4594-9b40-225dcf20b6f3"),
    Name = @"TID Increment: 13 - Kwik Trip",
    LookupCategoryId = Guid.Parse("1881c517-32e2-4c09-8bd2-09e2efe7dc61"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:04:50.3313703+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:04:50.3313703+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("c670e351-520f-40e0-a0fc-22bdd4bc364a"),
    Name = @"La Crosse Center",
    LookupCategoryId = Guid.Parse("00316b5b-16ab-480a-8974-50f0f6dd97fe"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T02:55:07.9674839+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T02:55:07.9674839+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("723dd3de-8a09-4939-82e9-22c27b872cc7"),
    Name = @"Utility - Parking Utility Funds (Fund 610)",
    LookupCategoryId = Guid.Parse("2fbf3c72-e26f-4db8-a5de-180bc862d79e"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:01:03.0122505+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:01:03.0122505+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("175d84dd-ecdc-4daa-8d08-230b9edd329c"),
    Name = @"Human Resources",
    LookupCategoryId = Guid.Parse("18b298cd-91de-4b10-ae36-3bafd0ec02e8"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-21T22:58:14.8572699+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-21T22:58:14.8572699+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("42de20af-58e7-4349-8452-231b6933f829"),
    Name = @"Construction/Maintenance",
    LookupCategoryId = Guid.Parse("db09f0d8-49fe-41af-99a3-01c0d498d8de"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T17:48:05.4921633+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T17:48:05.4921633+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("d9a9568f-035c-4b12-a2f6-2388c95fae1c"),
    Name = @"General - Municipal Court Operating Budget (Dept 670)",
    LookupCategoryId = Guid.Parse("b44e86cb-1388-4c3f-ae4c-94d3df4f662b"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T06:50:41.4821094+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T06:50:41.4821094+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("db5d6f13-be66-4791-a30b-239f06c23f56"),
    Name = @"Utility - Storm Water Utility Funds (Fund 650)",
    LookupCategoryId = Guid.Parse("b44e86cb-1388-4c3f-ae4c-94d3df4f662b"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-06-17T00:42:37.4653580+00:00"),
    CreatedBy = Guid.Parse("69694165-d62e-4fba-9262-814877732f5e"),
    LastModified = DateTimeOffset.Parse("2025-06-17T00:42:37.4653580+00:00"),
    LastModifiedBy = Guid.Parse("69694165-d62e-4fba-9262-814877732f5e"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("f4c55e76-fafc-4a20-9bef-25a2db55ae4f"),
    Name = @"Police and Fire Commission",
    LookupCategoryId = Guid.Parse("3c78d7af-5305-4138-9038-be7425fcecb2"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T17:12:28.7040748+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T02:47:49.9151136+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("e91fa235-a18d-47dc-8c9b-261f9212eba4"),
    Name = @"Funding Moved Up",
    LookupCategoryId = Guid.Parse("0f4e03dc-0ead-41ad-93a9-26b0b6a0af3a"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T17:13:01.1251176+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T17:13:01.1251176+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("e664d54c-0a08-4963-b774-267f96e44b58"),
    Name = @"La Crosse Center Board",
    LookupCategoryId = Guid.Parse("3c78d7af-5305-4138-9038-be7425fcecb2"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T02:47:00.9945528+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T02:47:00.9945528+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("41e5abd7-4a60-4f6b-b90f-268ff3e49592"),
    Name = @"LIBRARY SPECIAL (Fund 293)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:14:02.1704777+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:14:02.1704777+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("c6dc63b7-0fc4-4c13-896f-26a95a367ebf"),
    Name = @"Test Spending Purpose",
    LookupCategoryId = Guid.Parse("db09f0d8-49fe-41af-99a3-01c0d498d8de"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-28T05:42:39.8358683+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-28T05:42:39.8358683+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("59a217a3-f411-4a93-899f-26f19d18f966"),
    Name = @"Expand service",
    LookupCategoryId = Guid.Parse("b4fe9e53-b0cc-4a8b-89d7-712bfc97ac24"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T01:05:33.2391566+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T01:05:33.2391566+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("9e9d7fd2-1878-45c3-8719-2761d68421a4"),
    Name = @"200 - GOLF COURSE",
    LookupCategoryId = Guid.Parse("449aa104-a5aa-43c4-8552-5aa69aa69960"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-26T12:47:37.3963627+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-26T12:47:55.6397901+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("ded616df-779b-4144-8aa6-27f5ab28846d"),
    Name = @"General - Parks, Recreation and Forestry Operating Budget (Dept 761)",
    LookupCategoryId = Guid.Parse("2fbf3c72-e26f-4db8-a5de-180bc862d79e"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T05:59:55.8486550+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T05:59:55.8486550+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("aa9b7c05-1750-4187-a183-282c393c21df"),
    Name = @"Infill",
    LookupCategoryId = Guid.Parse("720119db-c9f6-442b-abd4-6dc1271e7ee1"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-19T07:37:33.0057772+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-19T07:37:33.0057772+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("478881fa-94fa-4133-9d35-2883993a400e"),
    Name = @"Technology Hardware and Software",
    LookupCategoryId = Guid.Parse("910fb5e3-80a0-4a46-b616-8cb94f56e86f"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-06T06:49:39.8766667+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T08:33:48.3949261+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("48e6626a-2e62-47d8-a6d5-2a6b1838e4f8"),
    Name = @"La Crosse Center",
    LookupCategoryId = Guid.Parse("c1353eb7-87ca-4cca-9d5c-f87bd4ae97c8"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T17:24:27.4824974+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T17:24:27.4824974+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("2020161c-89d1-4f9f-8bc5-2a7193494b88"),
    Name = @"TID Increment: 10 - Park Plaza",
    LookupCategoryId = Guid.Parse("1881c517-32e2-4c09-8bd2-09e2efe7dc61"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:04:25.5564422+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:04:25.5564422+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("149ee3be-2113-40ee-b7e7-2ba8a2068192"),
    Name = @"GOLF COURSE (Fund 200)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:12:14.4992854+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:12:14.4992854+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("60b6d3c6-528f-4990-89ed-2d453ee171f7"),
    Name = @"HUMAN RIGHTS AND ETHICS INVSTGTN (Fund 585)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:13:06.1922831+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:13:06.1922831+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("f20a88ff-294b-45cd-bf87-2dbaafe02d21"),
    Name = @"Scheduled Replacement",
    LookupCategoryId = Guid.Parse("b4fe9e53-b0cc-4a8b-89d7-712bfc97ac24"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-06T06:49:44.6066667+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-06T06:49:44.6066667+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("f11b7b36-2b5c-49a4-b92b-2dc2e99c2a96"),
    Name = @"Sanitary Sewer/Wastewater - Other",
    LookupCategoryId = Guid.Parse("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:59:48.2537365+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:59:48.2537365+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("0647e23d-3216-454d-a065-2e00da633ac9"),
    Name = @"Assessor's Office",
    LookupCategoryId = Guid.Parse("c1353eb7-87ca-4cca-9d5c-f87bd4ae97c8"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-18T01:37:06.3305950+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-18T01:37:06.3305950+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("07ded818-cbba-4adf-912f-2e192c2d653a"),
    Name = @"2025-Initial Changes",
    LookupCategoryId = Guid.Parse("95f8e0c2-b1dd-44b4-aa66-09f63efddc48"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T17:10:52.6344572+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T17:10:52.6344572+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("3575e95f-253b-4cf4-a86b-2f529b880bf2"),
    Name = @"NEIGHBR RENOVATION RESTORATION (Fund 298)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:14:54.3862939+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:14:54.3862939+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("b755d8be-e91c-4b73-9b25-2f961ad186b0"),
    Name = @"RIVERSIDE REDEVELOPMENT (Fund 2040)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:18:03.7924453+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:18:03.7924453+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("99859e55-a855-4754-8c02-2fdae538a8a5"),
    Name = @"Planning and Community Development - Neighborhoods",
    LookupCategoryId = Guid.Parse("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:58:27.6759014+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:58:27.6759014+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("5c3cbe43-7742-455c-a390-30145d974d0a"),
    Name = @"Revenue Bonds/Notes: Parking Utility",
    LookupCategoryId = Guid.Parse("e0dd3254-0249-4f71-8c70-36063346ad72"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-06T06:50:14.6966667+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-21T01:42:21.4487538+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("7117ad7b-fe19-42ea-8bff-3096d8a13e2e"),
    Name = @"General - Insurance Operating Budget (Dept 460)",
    LookupCategoryId = Guid.Parse("b44e86cb-1388-4c3f-ae4c-94d3df4f662b"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T06:51:35.3561215+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T06:51:35.3561215+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("b2193b96-593f-4628-89af-3261df5d82ab"),
    Name = @"Archived",
    LookupCategoryId = Guid.Parse("93985952-4e53-4b3d-a897-8bec835d8d42"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-03-19T13:28:09.8072860+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-03-19T13:28:09.8072860+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("eb879eb0-c554-4d0a-842d-32d04287293e"),
    Name = @"GREEN ISLAND LAND (Fund 240)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:12:26.8967689+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:12:26.8967689+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("3320de24-723f-4f16-881a-333d2a4ddac0"),
    Name = @"PETTIBONE BATHHOUSE MURAL (Fund 552)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:15:31.0522608+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:15:31.0522608+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("81fba826-48c7-402f-bbf6-3347aaa9530f"),
    Name = @"Trans and Utils - Streets",
    LookupCategoryId = Guid.Parse("00316b5b-16ab-480a-8974-50f0f6dd97fe"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T02:57:12.3919253+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T02:57:12.3919253+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("36093421-1d0d-48e3-84be-337bede2a5b2"),
    Name = @"LIBRARY SANDY GORDON (Fund 226)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:13:56.9163214+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:13:56.9163214+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("b597dad4-e94a-4acf-8ecf-3436cf5e96b9"),
    Name = @"PARK TREE MEMORIALS (Fund 511)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:15:12.2471305+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:15:12.2471305+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("d307f507-ac73-4ab4-a078-34a75f5d28ed"),
    Name = @"2",
    LookupCategoryId = Guid.Parse("e2bc2f40-b296-48b6-bfaa-faf91bd5539e"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-19T06:50:12.6083836+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-19T06:50:12.6083836+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("2e36ce16-a881-4c22-8333-356629a7f8d4"),
    Name = @"POLICE RESERVE PROGRAM (Fund 545)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:17:08.9152879+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:17:08.9152879+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("5f4209d7-9703-46e4-8230-364cf32ae470"),
    Name = @"B and G - Municipal Service Center",
    LookupCategoryId = Guid.Parse("00316b5b-16ab-480a-8974-50f0f6dd97fe"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T02:50:38.8546135+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T02:50:38.8546135+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("ea027f1a-0a20-446d-aa3d-36b46660e00f"),
    Name = @"17 - Lot C Downtown",
    LookupCategoryId = Guid.Parse("5516c30d-7a89-419e-be1b-0e5cb64f01ea"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-20T06:36:04.3259407+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-20T06:36:04.3259407+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("1fb8c160-e938-46e7-983d-36ef39c72bbf"),
    Name = @"POLICE CHAPLAIN PROGRAM (Fund 535)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:15:59.5372305+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:15:59.5372305+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("7e42ed08-08bd-4c75-8443-372c80ece999"),
    Name = @"Citywide",
    LookupCategoryId = Guid.Parse("18b298cd-91de-4b10-ae36-3bafd0ec02e8"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-21T22:57:11.4003388+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-21T22:57:11.4003388+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("42e1165e-58c4-4cb6-881a-38634e730505"),
    Name = @"TIF Bonds/Notes: 18 - River Point District",
    LookupCategoryId = Guid.Parse("2c4caa8d-544b-4393-82be-9a5b7c221117"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T05:53:50.8532191+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T05:53:50.8532191+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("e76b426a-1cb1-4e75-a669-38b2bbd62638"),
    Name = @"Plan and Dev - Housing",
    LookupCategoryId = Guid.Parse("00316b5b-16ab-480a-8974-50f0f6dd97fe"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T02:55:33.6845958+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T02:55:33.6845958+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("e3752f57-199d-457e-97d5-39e0a6b48ea7"),
    Name = @"Harbor Tenant Fees",
    LookupCategoryId = Guid.Parse("1881c517-32e2-4c09-8bd2-09e2efe7dc61"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:03:37.0167900+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:03:37.0167900+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("9ac2f7c8-dfc8-4b34-92d7-3a060b4099c3"),
    Name = @"Airport - Runways and Taxiways",
    LookupCategoryId = Guid.Parse("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-19T07:02:04.7295360+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:55:06.4585658+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("2230ad55-b7ef-463a-bd3f-3ada90798e77"),
    Name = @"Vehicles and Attachments",
    LookupCategoryId = Guid.Parse("910fb5e3-80a0-4a46-b616-8cb94f56e86f"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-14T13:31:44.1032319+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-14T13:31:44.1032319+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("ab16b4f6-68a3-4324-994b-3af1986c4989"),
    Name = @"Police Stations",
    LookupCategoryId = Guid.Parse("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:58:33.3547507+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:58:33.3547507+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("5a4f79da-9a76-4b4a-872f-3b452e0aaa31"),
    Name = @"General - Clerks Operating Budget (Dept 220)",
    LookupCategoryId = Guid.Parse("b44e86cb-1388-4c3f-ae4c-94d3df4f662b"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-21T05:35:33.7712265+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-21T05:35:33.7712265+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("2c3c8380-2591-4c59-96c7-3b82d2ae145b"),
    Name = @"General - Room Tax Operating Budget (Dept 791)",
    LookupCategoryId = Guid.Parse("b44e86cb-1388-4c3f-ae4c-94d3df4f662b"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T06:48:57.6686401+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T06:48:57.6686401+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("e6917750-4d58-48f7-beb1-3b9fcd470c0c"),
    Name = @"HOUSING REHABILITATION (Fund 2010)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:12:59.6028047+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:12:59.6028047+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("e8fa6365-fdef-4e04-aabd-3bef751f3755"),
    Name = @"B and G - Library",
    LookupCategoryId = Guid.Parse("00316b5b-16ab-480a-8974-50f0f6dd97fe"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T02:50:56.2930618+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T02:50:56.2930618+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("02bf93bf-7aff-4508-8961-3c23427e592d"),
    Name = @"TIF Bonds/Notes: 10 - Park Plaza",
    LookupCategoryId = Guid.Parse("e0dd3254-0249-4f71-8c70-36063346ad72"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T05:49:10.5990847+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T05:49:10.5990847+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("f254701c-007d-4fa3-80bc-3cd44a537acf"),
    Name = @"Special Assessments",
    LookupCategoryId = Guid.Parse("1881c517-32e2-4c09-8bd2-09e2efe7dc61"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:04:16.7794231+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:04:16.7794231+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("0cd00c57-e497-45c9-8d19-3cdb5821fcd9"),
    Name = @"Detail 2",
    LookupCategoryId = Guid.Parse("c72a2551-f9d5-4b61-bfe7-0cb74bd53de4"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-25T02:05:20.5537100+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-25T02:05:20.5537100+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("63114c92-bf9c-4f63-910f-3d31e518c90d"),
    Name = @"General - Library Operating Budget (Dept 520)",
    LookupCategoryId = Guid.Parse("b44e86cb-1388-4c3f-ae4c-94d3df4f662b"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T06:51:09.4102968+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T06:51:09.4102968+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("4de0eb76-d5bf-40d1-acb1-3dbfce2b4389"),
    Name = @"FIRE HAZMAT TRAILER (Fund 223)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:11:18.0702880+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:11:18.0702880+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("c646d35d-2549-4356-b3ed-3e38122becd8"),
    Name = @"3",
    LookupCategoryId = Guid.Parse("e2bc2f40-b296-48b6-bfaa-faf91bd5539e"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-19T06:50:16.6358239+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-19T06:50:16.6358239+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("cbe99014-230e-44d8-8f73-3ed3e9d9621e"),
    Name = @"Parks - Recreation Facilities",
    LookupCategoryId = Guid.Parse("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:58:03.3613592+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:58:03.3613592+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("b6d091b6-22b8-42a1-b6d0-3f022fc1df3e"),
    Name = @"Sub Detail 2",
    LookupCategoryId = Guid.Parse("d2b40805-4186-4088-ac14-16be43330171"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-25T02:07:19.7099066+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-25T02:07:19.7099066+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("094da7d1-3458-4d39-b9d5-3f3035b4b8d0"),
    Name = @"La Crosse Center Room Tax",
    LookupCategoryId = Guid.Parse("1881c517-32e2-4c09-8bd2-09e2efe7dc61"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:03:43.1598479+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:03:43.1598479+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("f1fcf4b6-7467-474e-b696-3fb056b682ce"),
    Name = @"Complete",
    LookupCategoryId = Guid.Parse("5baad37a-5ba1-4ec1-aaa3-992fa352a887"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-19T07:33:16.7786294+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-19T07:34:10.7827867+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("e07824af-9be1-4416-bab8-3fd15591ff8e"),
    Name = @"TIF Bonds/Notes: 15 - Chart",
    LookupCategoryId = Guid.Parse("e0dd3254-0249-4f71-8c70-36063346ad72"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T05:50:18.7659617+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T05:50:18.7659617+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("5c45f11d-e76f-45f8-ac0f-411c28cf6839"),
    Name = @"16 - LIPCO/Trane Plant 6",
    LookupCategoryId = Guid.Parse("5516c30d-7a89-419e-be1b-0e5cb64f01ea"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-20T06:35:52.4398875+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-20T06:35:52.4398875+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("aa83a537-d4b8-45ae-948d-4120b5793cb2"),
    Name = @"Greschner, Jacky",
    LookupCategoryId = Guid.Parse("76fc224c-bc0a-4458-bf43-bfd8db3a0b83"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T17:28:29.4664291+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T17:28:29.4664291+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("16dab5ee-5b4d-4277-a11d-419b0e746442"),
    Name = @"HAMMES PROPERTY (Fund 241)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:12:41.2533689+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:12:41.2533689+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("72583ddf-2de8-4d2f-8ed4-41af542b5fa0"),
    Name = @"Unknown",
    LookupCategoryId = Guid.Parse("eb07f930-9e73-4cda-a9eb-98c4ec2a2afc"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T05:55:19.4372702+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T05:55:19.4372702+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("b6cacdd0-7813-49ad-ac7b-41f1705c53f7"),
    Name = @"Parking Utility",
    LookupCategoryId = Guid.Parse("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:57:24.1496846+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:57:24.1496846+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("fd857536-7d01-42ed-8a16-429d9c59cc48"),
    Name = @"La Crosse Center",
    LookupCategoryId = Guid.Parse("18b298cd-91de-4b10-ae36-3bafd0ec02e8"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-21T22:58:38.7530404+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-21T22:58:38.7530404+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("f6ea2538-d22a-41f2-b697-42c3064ca14f"),
    Name = @"La Crosse Center Room Tax",
    LookupCategoryId = Guid.Parse("42aa7e76-c0e4-49da-a5b8-0ad3f7163673"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-06T06:50:39.4533333+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-06T06:50:39.4533333+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("0e0e4e33-5203-4970-8db1-44fdca7e2e70"),
    Name = @"Dan Trussoni",
    LookupCategoryId = Guid.Parse("ea188a54-8da6-4c4c-bedf-89a079480790"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-26T12:35:38.8628298+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-26T12:35:38.8628298+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("bc0601a6-fb89-4575-bb24-4510bb9e853f"),
    Name = @"General - Grounds and Building Operating Budget (Dept 882)",
    LookupCategoryId = Guid.Parse("b44e86cb-1388-4c3f-ae4c-94d3df4f662b"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T06:52:05.8880560+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T06:52:05.8880560+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("5fe61493-b4d3-4927-99c9-455ec535d3db"),
    Name = @"PETTIBONE PARK IMPROVEMENTS (Fund 515)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:15:36.8517619+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:15:36.8517619+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("e6c00129-5326-4963-aab3-45a86106d368"),
    Name = @"Public Buildings - Other Buildings",
    LookupCategoryId = Guid.Parse("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:59:29.8405721+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:59:29.8405721+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("8910c16f-8f87-411c-b2f8-45ab52e4307e"),
    Name = @"TIF Bonds/Notes: 9 - International Business Park",
    LookupCategoryId = Guid.Parse("2c4caa8d-544b-4393-82be-9a5b7c221117"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T05:54:17.9406707+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T05:54:17.9406707+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("7bc23531-8799-474d-9556-45b1c19f5ab3"),
    Name = @"POLICE DARE (Fund 522)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:16:10.1383186+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:16:10.1383186+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("3fb83c02-a74e-4b67-b08e-465413419f0f"),
    Name = @"SUBDIVISION FEES PARK PURPOSES (Fund 562)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:18:43.0624741+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:18:43.0624741+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("d3bbdb33-2ffd-4892-8d86-4748d996e07a"),
    Name = @"TID APPLICATION FEES (Fund 583)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:18:49.6700845+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:18:49.6700845+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("9592ac30-88bb-4451-88e5-478685d45fbb"),
    Name = @"TIF Bonds/Notes: 11 - Gateway Redevelopment",
    LookupCategoryId = Guid.Parse("e0dd3254-0249-4f71-8c70-36063346ad72"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T05:49:23.9881401+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T05:49:23.9881401+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("a77e9ec5-c7a8-43d7-8484-478f5abf6c1d"),
    Name = @"Redevelopment Authority",
    LookupCategoryId = Guid.Parse("3c78d7af-5305-4138-9038-be7425fcecb2"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T02:47:38.9251307+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T02:47:38.9251307+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("ad489041-62e0-4317-b9c8-4798e1eeb70d"),
    Name = @"Utility - Sanitary Sewer Utility Funds (Fund 630)",
    LookupCategoryId = Guid.Parse("b44e86cb-1388-4c3f-ae4c-94d3df4f662b"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-06-17T00:43:24.0058745+00:00"),
    CreatedBy = Guid.Parse("69694165-d62e-4fba-9262-814877732f5e"),
    LastModified = DateTimeOffset.Parse("2025-06-17T00:43:24.0058745+00:00"),
    LastModifiedBy = Guid.Parse("69694165-d62e-4fba-9262-814877732f5e"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("7cc437a2-5fda-4a9b-ada4-47a23dc2bfb0"),
    Name = @"Library",
    LookupCategoryId = Guid.Parse("18b298cd-91de-4b10-ae36-3bafd0ec02e8"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-21T22:59:02.4322339+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-21T22:59:02.4322339+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("69d9670a-6395-4b4d-a633-47c3c6395b96"),
    Name = @"Fire",
    LookupCategoryId = Guid.Parse("18b298cd-91de-4b10-ae36-3bafd0ec02e8"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-12T14:33:20.3563791+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-12T14:33:20.3563791+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("79a1bc4d-ee3a-4b49-9d9d-482f5e6fb56c"),
    Name = @"General - Council Operating Budget (Dept 280)",
    LookupCategoryId = Guid.Parse("2fbf3c72-e26f-4db8-a5de-180bc862d79e"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T05:58:09.6995123+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T05:58:09.6995123+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("f6f8e02e-ad30-48b5-9857-48389481d7f8"),
    Name = @"Parks - Boat Docks",
    LookupCategoryId = Guid.Parse("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:57:46.1670723+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:57:46.1670723+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("9409e34f-a2dd-4334-97f4-48507864b1f1"),
    Name = @"12 - Three Rivers Plaza",
    LookupCategoryId = Guid.Parse("5516c30d-7a89-419e-be1b-0e5cb64f01ea"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-20T05:07:03.8085727+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-20T05:07:13.5570400+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("3b6710d1-b5c4-41ed-b70a-49797a089f56"),
    Name = @"RENEW (Fund 549)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:17:44.6874726+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:17:44.6874726+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("7889017e-7301-4d75-95e8-49d5ed83ebd6"),
    Name = @"(None)",
    LookupCategoryId = Guid.Parse("cf4a4d66-6ced-43f2-959d-613c2fa2110d"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-14T13:06:52.6851950+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-17T06:14:10.3792341+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("713ec569-9421-4ae3-b6a9-4a3be1606562"),
    Name = @"6",
    LookupCategoryId = Guid.Parse("e2bc2f40-b296-48b6-bfaa-faf91bd5539e"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-19T06:50:28.5699679+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-19T06:50:28.5699679+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("51af579c-c6f9-4dd4-8411-4a5ca7f98cb1"),
    Name = @"Unknown",
    LookupCategoryId = Guid.Parse("2fbf3c72-e26f-4db8-a5de-180bc862d79e"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:00:54.2872723+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:00:54.2872723+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("d69598eb-dd86-4068-a79e-4b1abe1c6234"),
    Name = @"City Clerk",
    LookupCategoryId = Guid.Parse("c1353eb7-87ca-4cca-9d5c-f87bd4ae97c8"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T17:19:17.3949171+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T17:19:17.3949171+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("cecb3cbf-e6ed-4c4f-9dda-4b2b5ed06ebc"),
    Name = @"BIKE RODEO (Fund 520)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:09:15.7840852+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:09:15.7840852+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("9a91d388-d3dd-4614-846b-4b79a68538f5"),
    Name = @"La Crosse Center Surplus Funds",
    LookupCategoryId = Guid.Parse("1881c517-32e2-4c09-8bd2-09e2efe7dc61"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:03:49.6126028+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:03:49.6126028+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("ae7a4657-f92e-4dd2-9617-4bc369dde239"),
    Name = @"Neighborhood Revitalization Commission",
    LookupCategoryId = Guid.Parse("3c78d7af-5305-4138-9038-be7425fcecb2"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T02:47:26.4604067+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T02:47:26.4604067+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("dd544e13-d22a-4b07-bb58-4ca068674230"),
    Name = @"Municipal Court",
    LookupCategoryId = Guid.Parse("c1353eb7-87ca-4cca-9d5c-f87bd4ae97c8"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T17:25:09.1055363+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T17:25:09.1055363+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("f782e506-a616-43fb-86b4-4d520f103f2d"),
    Name = @"Arts Board",
    LookupCategoryId = Guid.Parse("3c78d7af-5305-4138-9038-be7425fcecb2"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-19T12:17:29.5120027+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T02:44:46.5846613+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("4c6578f5-c58b-4f12-a2e4-4de8a65e7636"),
    Name = @"Grants/Loans",
    LookupCategoryId = Guid.Parse("db09f0d8-49fe-41af-99a3-01c0d498d8de"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T17:49:19.5631448+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T17:49:19.5631448+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("86d92cd6-ad63-4d8c-b283-4e1e01c8186b"),
    Name = @"Sanitary Sewer Utility",
    LookupCategoryId = Guid.Parse("18b298cd-91de-4b10-ae36-3bafd0ec02e8"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-21T23:07:52.4647269+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-21T23:07:52.4647269+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("a7a9428c-7db7-427c-aa78-4e21e5accfa2"),
    Name = @"General - Special Appropriations Operating Budget (Dept 423)",
    LookupCategoryId = Guid.Parse("b44e86cb-1388-4c3f-ae4c-94d3df4f662b"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T06:48:37.8135816+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T06:48:37.8135816+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("e06e61d5-ebc1-4dc1-8696-4e98affee785"),
    Name = @"Streetscaping - Streetscaping",
    LookupCategoryId = Guid.Parse("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T07:01:10.7719623+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T07:01:10.7719623+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("c0b5063d-44bf-42e9-8dde-4ebadbe79391"),
    Name = @"Housing Rehabilitation",
    LookupCategoryId = Guid.Parse("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:57:11.4089783+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:57:11.4089783+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("640356b8-ba9f-43a2-bea6-4f3d0d283c42"),
    Name = @"Present Equipment Obsolete",
    LookupCategoryId = Guid.Parse("b4fe9e53-b0cc-4a8b-89d7-712bfc97ac24"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-06T06:49:44.6100000+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-06T06:49:44.6100000+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("80eb4a58-1173-4a69-9de8-4f8aca2ea777"),
    Name = @"TRAIL IMPROVEMENTS (Fund 232)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:18:55.7746336+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:18:55.7746336+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("933f9a7e-4ca3-472a-8ef3-4fb4ac07bb59"),
    Name = @"Assesor's Office",
    LookupCategoryId = Guid.Parse("18b298cd-91de-4b10-ae36-3bafd0ec02e8"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-06T06:50:04.2100000+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-06T06:50:04.2100000+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("c8286cc1-4863-4459-986a-4fce8f0af9a1"),
    Name = @"General - Streets Operating Budget (Dept 883)",
    LookupCategoryId = Guid.Parse("2fbf3c72-e26f-4db8-a5de-180bc862d79e"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:00:47.2883089+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:00:47.2883089+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("e13c26b4-4d8e-489b-9b41-5158ef958bc3"),
    Name = @"Equipment/Vehicles/Furnishings",
    LookupCategoryId = Guid.Parse("db09f0d8-49fe-41af-99a3-01c0d498d8de"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T17:49:11.0550337+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T17:49:11.0550337+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("2ca367ac-cc3a-4133-b9c2-51c6bb6069ef"),
    Name = @"Water Mains",
    LookupCategoryId = Guid.Parse("7b667e0f-6875-4180-b774-92136e36924b"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-19T07:39:14.8437409+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-19T07:39:14.8437409+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("77c767e7-37db-4339-b0f0-5221f05e9925"),
    Name = @"Engineering",
    LookupCategoryId = Guid.Parse("c1353eb7-87ca-4cca-9d5c-f87bd4ae97c8"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T17:19:44.3269133+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T17:19:44.3269133+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("c872f859-dc0e-4df4-91e4-53388687a349"),
    Name = @"9",
    LookupCategoryId = Guid.Parse("e2bc2f40-b296-48b6-bfaa-faf91bd5539e"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-19T06:50:40.1767264+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-19T06:50:40.1767264+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("18af88a7-a294-432c-bd84-54db919bf5c3"),
    Name = @"Public Buildings - City Hall",
    LookupCategoryId = Guid.Parse("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T17:51:35.4995425+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T17:51:35.4995425+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("2d2e4195-d283-4cdd-8eb3-54db98aefd35"),
    Name = @"Trans and Utils - Utilities",
    LookupCategoryId = Guid.Parse("00316b5b-16ab-480a-8974-50f0f6dd97fe"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T02:57:44.6614157+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T02:57:44.6614157+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("fcdfbc2f-50ae-488f-8451-54e66c105ac4"),
    Name = @"Unfunded Request",
    LookupCategoryId = Guid.Parse("93985952-4e53-4b3d-a897-8bec835d8d42"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-03-19T13:28:51.1189439+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-03-19T13:28:51.1189439+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("9c057e97-e9dd-465b-94a3-55032419e168"),
    Name = @"Airport",
    LookupCategoryId = Guid.Parse("c1353eb7-87ca-4cca-9d5c-f87bd4ae97c8"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-18T01:36:43.2142293+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-18T01:36:43.2142293+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("62626ce1-957e-47e9-ade7-554420f27d06"),
    Name = @"Program",
    LookupCategoryId = Guid.Parse("761adb91-60e3-43bc-bbdf-bdf1b586d4f1"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-13T06:24:47.7208837+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-13T06:24:47.7208837+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("825ad848-535d-4bf3-a638-55679a14c68a"),
    Name = @"Enterprise - Airport Operating Funds (Fund 600)",
    LookupCategoryId = Guid.Parse("2fbf3c72-e26f-4db8-a5de-180bc862d79e"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-28T11:11:14.6436766+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T05:57:15.6897054+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("5180f348-5b81-4392-8923-5585b78d09da"),
    Name = @"FITNESS FESTIVAL (Fund 218)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:11:57.4131140+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:11:57.4131140+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("1c83e967-8d79-49b3-ad80-55b5ece6b17a"),
    Name = @"Judiciary & Administration Committee",
    LookupCategoryId = Guid.Parse("3c78d7af-5305-4138-9038-be7425fcecb2"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T02:46:51.3143207+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T02:46:51.3143207+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("2b729536-38c1-4750-af80-560440b09017"),
    Name = @"SPECIAL RECREATION (Fund 568)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:18:36.8474752+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:18:36.8474752+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("ca978126-4a2f-4541-a78e-56a59b35d07a"),
    Name = @"Trans and Utils - Transit",
    LookupCategoryId = Guid.Parse("00316b5b-16ab-480a-8974-50f0f6dd97fe"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T02:57:34.8630536+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T02:57:34.8630536+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("b37f08fc-5977-4f41-adb4-5717a0a271e4"),
    Name = @"General - Mayor Operating Budget (Dept 550)",
    LookupCategoryId = Guid.Parse("2fbf3c72-e26f-4db8-a5de-180bc862d79e"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T05:59:41.8641845+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T05:59:41.8641845+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("180b5930-9bfe-4bdf-b00a-574066ca164e"),
    Name = @"Bike Safety",
    LookupCategoryId = Guid.Parse("c641a57f-5f5e-4458-b940-4c9e562ff653"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-19T07:37:04.8229976+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-19T07:37:04.8229976+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("4f549198-cf6d-418b-b3fd-5774877bba9c"),
    Name = @"2020-Mayor's Changes - 6/17/2020",
    LookupCategoryId = Guid.Parse("95f8e0c2-b1dd-44b4-aa66-09f63efddc48"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T17:10:02.0492960+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T17:10:02.0492960+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("da0a06f7-596f-446f-8f1c-57cb8d48195a"),
    Name = @"Public Buildings - Library",
    LookupCategoryId = Guid.Parse("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:59:15.8824062+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:59:15.8824062+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("c5b89a28-8659-4bda-9d63-580200f55d32"),
    Name = @"Information Technology",
    LookupCategoryId = Guid.Parse("18b298cd-91de-4b10-ae36-3bafd0ec02e8"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-21T22:58:27.3499818+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-21T22:58:27.3499818+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("1ab1207b-0963-49e0-ae74-5806b617e67a"),
    Name = @"Equipment and Tools",
    LookupCategoryId = Guid.Parse("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:56:38.8297737+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:56:38.8297737+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("bef6f460-9964-495b-bd77-581cb0c39e6d"),
    Name = @"Arts Board",
    LookupCategoryId = Guid.Parse("cf4a4d66-6ced-43f2-959d-613c2fa2110d"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-06T06:50:09.3766667+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T01:17:21.1883269+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("3cefaa9f-e413-40e0-94ba-58ed5e57ee12"),
    Name = @"2018 CDBG (Fund 2261)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:08:16.9567643+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:08:16.9567643+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("b762e092-2e35-4eb9-aaf4-59c9a3996d31"),
    Name = @"General Obligation Bonds/Notes",
    LookupCategoryId = Guid.Parse("2c4caa8d-544b-4393-82be-9a5b7c221117"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-28T11:11:48.9552637+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T05:51:53.0228561+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("a5dd86fb-7b65-4f5e-85b5-59d3688bb428"),
    Name = @"Library Board",
    LookupCategoryId = Guid.Parse("3c78d7af-5305-4138-9038-be7425fcecb2"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T02:47:09.5641080+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T02:47:09.5641080+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("fd14706f-93f2-44fc-82b3-59f73c784ad1"),
    Name = @"Reserve Fund",
    LookupCategoryId = Guid.Parse("1881c517-32e2-4c09-8bd2-09e2efe7dc61"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:04:03.2145510+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:04:03.2145510+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("886758d2-4624-4cd0-bcd9-5a1636497bec"),
    Name = @"General - Library Operating Budget (Dept 520)",
    LookupCategoryId = Guid.Parse("2fbf3c72-e26f-4db8-a5de-180bc862d79e"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T05:59:34.4072635+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T05:59:34.4072635+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("78703599-6c34-48de-92bf-5a312228621d"),
    Name = @"FIRE IRIS (Fund 221)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:11:25.7411598+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:11:25.7411598+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("b2d39a9d-6eaf-4b6a-a438-5a9b5f299480"),
    Name = @"Flood Control - Harbors and Waterfront",
    LookupCategoryId = Guid.Parse("00316b5b-16ab-480a-8974-50f0f6dd97fe"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T02:54:12.4169510+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T02:54:12.4169510+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("53e13160-97ec-4437-a7c7-5aafcff89f77"),
    Name = @"Enterprise - Car Rental Facility Charges",
    LookupCategoryId = Guid.Parse("b44e86cb-1388-4c3f-ae4c-94d3df4f662b"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-21T05:34:47.8165261+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-21T05:34:47.8165261+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("1c98551c-70d4-4e0b-b82a-5b0449485878"),
    Name = @"Community Development and Housing",
    LookupCategoryId = Guid.Parse("18b298cd-91de-4b10-ae36-3bafd0ec02e8"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-21T22:57:23.9875799+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-21T22:57:23.9875799+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("c8d68beb-771f-4bd2-885e-5b3a0ac4ed66"),
    Name = @"10 - Park Plaza",
    LookupCategoryId = Guid.Parse("5516c30d-7a89-419e-be1b-0e5cb64f01ea"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-20T05:06:27.1539557+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-20T05:06:27.1539557+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("3d51ec28-15eb-46c4-8d71-5bc4e0912a1f"),
    Name = @"Approved (Not Started)",
    LookupCategoryId = Guid.Parse("c4121504-a142-4624-9c71-8764661893aa"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T02:59:08.9837580+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T02:59:08.9837580+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("6760722c-46d1-4c6b-90bd-5bc544a78bc7"),
    Name = @"Enterprise - Passenger Facility Charges",
    LookupCategoryId = Guid.Parse("2fbf3c72-e26f-4db8-a5de-180bc862d79e"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T05:57:36.9372470+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T05:57:36.9372470+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("8767103b-e15f-4015-bed9-5c1d303cbcf0"),
    Name = @"New",
    LookupCategoryId = Guid.Parse("720119db-c9f6-442b-abd4-6dc1271e7ee1"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-19T07:37:39.8430148+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-19T07:37:39.8430148+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("4566301d-7346-4a70-84d8-5cf403f23dd1"),
    Name = @"General - Fire O perating Budget (Dept 370)",
    LookupCategoryId = Guid.Parse("b44e86cb-1388-4c3f-ae4c-94d3df4f662b"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T06:52:43.3416262+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T06:52:43.3416262+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("4d0dae76-7e27-4c6c-8335-5d34bc817d88"),
    Name = @"VENDING MACHINES (Fund 566)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:19:21.1843295+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:19:21.1843295+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("ae24dd4d-c5a1-4e17-b649-5dc231ed508a"),
    Name = @"CAPITAL PROJ REIMB FOR DEBT (Fund 215)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:09:59.0933956+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:09:59.0933956+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("05c5e2f1-9987-487d-b92e-5ed2b06912e8"),
    Name = @"TIF Bonds/Notes: 14 - Gundersen Lutheran",
    LookupCategoryId = Guid.Parse("e0dd3254-0249-4f71-8c70-36063346ad72"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T05:50:09.2245454+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T05:50:09.2245454+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("1690d44c-fe68-4d3b-97e8-5f2c7bb5dddb"),
    Name = @"Utilty - Storm Water Utility Funds (Fund 650)",
    LookupCategoryId = Guid.Parse("2fbf3c72-e26f-4db8-a5de-180bc862d79e"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:02:07.3096594+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:02:07.3096594+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("06fb60fd-8754-4fa3-9a95-5fb2364d9eb3"),
    Name = @"Withdrawn by Department",
    LookupCategoryId = Guid.Parse("93985952-4e53-4b3d-a897-8bec835d8d42"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-03-19T13:27:50.4314505+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-03-19T13:27:50.4314505+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("ef1abf7d-4624-42ac-810c-610d571e8cff"),
    Name = @"Enterprise - La Crosse Center Operating Funds (Fund 101)",
    LookupCategoryId = Guid.Parse("2fbf3c72-e26f-4db8-a5de-180bc862d79e"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T05:57:30.1703808+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T05:57:30.1703808+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("f18e3444-409a-4c02-b0d4-612625afbee4"),
    Name = @"Common Council",
    LookupCategoryId = Guid.Parse("3c78d7af-5305-4138-9038-be7425fcecb2"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T02:46:09.4951023+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T02:46:09.4951023+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("06ec47a6-edcd-4919-a81f-6209b63ea418"),
    Name = @"POLICE GRANTS (Fund 526)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:16:54.0766832+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:16:54.0766832+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("f12cf824-9c78-43b1-a479-62756710e323"),
    Name = @"Test Past Funding",
    LookupCategoryId = Guid.Parse("69ce8d13-2884-4108-8a93-e7e05650a669"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-28T11:10:24.7118565+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-28T11:10:24.7118565+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("2c77a980-7eb3-4a17-a92e-629ad4c2302a"),
    Name = @"Good",
    LookupCategoryId = Guid.Parse("49921477-b361-4299-8fcb-5ec327ddf57c"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-19T07:35:09.0247821+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-19T07:35:09.0247821+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("363e8dea-53fd-43e7-b502-64080bb1386c"),
    Name = @"TIF Bonds/Notes: 13 - Kwik Trip",
    LookupCategoryId = Guid.Parse("2c4caa8d-544b-4393-82be-9a5b7c221117"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T05:53:10.3111452+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T05:53:10.3111452+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("28ff616c-19ac-47b3-9183-641502ef7cf2"),
    Name = @"SIGNS (NO PARKNG PRIVATE WALK) (Fund 560)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:18:17.8435064+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:18:17.8435064+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("1555bc34-8ac4-49fc-bcec-64efc5b92db7"),
    Name = @"TIF Bonds/Notes: 16 - LIPCO/Trane Plant 6",
    LookupCategoryId = Guid.Parse("2c4caa8d-544b-4393-82be-9a5b7c221117"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T05:53:35.3933472+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T05:53:35.3933472+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("ce2b6d47-7e23-4c9a-ab7b-65328b112a67"),
    Name = @"Water Utility",
    LookupCategoryId = Guid.Parse("c1353eb7-87ca-4cca-9d5c-f87bd4ae97c8"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T17:27:41.3981194+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T17:27:41.3981194+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("f96b7101-0a16-4451-b4dc-6603f2dbfd84"),
    Name = @"POLICE VEST CONTRIBUTIONS (Fund 532)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:17:38.8352711+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:17:38.8352711+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("f6b9ddbd-5a73-4297-9a72-66508cfce09d"),
    Name = @"Finance & Personnel Committee",
    LookupCategoryId = Guid.Parse("cf4a4d66-6ced-43f2-959d-613c2fa2110d"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T01:18:25.3246820+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T01:18:25.3246820+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("4ea341b1-289e-4b59-b5f6-66c401157e39"),
    Name = @"Streets - Street Improvements",
    LookupCategoryId = Guid.Parse("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T07:00:39.2036000+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T07:00:39.2036000+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("12a47836-5007-4ea4-964a-66e5cb630c07"),
    Name = @"NEIGHBORHOOD STAB PROG GRT (Fund 564)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:14:47.2807981+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:14:47.2807981+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("8da7deb3-2171-40d8-baf4-676572d10085"),
    Name = @"Information Technology",
    LookupCategoryId = Guid.Parse("c1353eb7-87ca-4cca-9d5c-f87bd4ae97c8"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T17:24:16.8267187+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T17:24:16.8267187+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("05112108-8ed8-4525-b05b-67d0c5b27342"),
    Name = @"Sanitary Sewer Utility",
    LookupCategoryId = Guid.Parse("c1353eb7-87ca-4cca-9d5c-f87bd4ae97c8"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T17:27:03.8279510+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T17:27:03.8279510+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("06a72058-6842-4728-b175-683aecdfe924"),
    Name = @"No Curb",
    LookupCategoryId = Guid.Parse("49921477-b361-4299-8fcb-5ec327ddf57c"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-19T07:35:04.1195350+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-19T07:35:04.1195350+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("fa61555a-bc5e-4d4d-811b-68c88f46c810"),
    Name = @"Local",
    LookupCategoryId = Guid.Parse("f0770a04-79f8-488e-b674-d1dde98e8079"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-21T05:34:04.5667278+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-21T05:34:04.5667278+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("5173dd01-4bc8-4e6e-9eb6-69d3c2a41919"),
    Name = @"Police",
    LookupCategoryId = Guid.Parse("c1353eb7-87ca-4cca-9d5c-f87bd4ae97c8"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T17:26:35.5016478+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T17:26:35.5016478+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("a2778e7a-22bb-4f58-a1b7-69d75d4e1297"),
    Name = @"High",
    LookupCategoryId = Guid.Parse("41e3334c-a1be-4c55-a21c-8540053b458e"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-06T06:49:50.6500000+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-06T06:49:50.6500000+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("b124d5f8-2160-46b7-8a83-6ae83500e314"),
    Name = @"TID Increment: 9 - International Business Park",
    LookupCategoryId = Guid.Parse("1881c517-32e2-4c09-8bd2-09e2efe7dc61"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:05:46.5095638+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:05:46.5095638+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("542695af-fde3-4d2d-8bb4-6b04de85832a"),
    Name = @"Improve procedures, records, etc...",
    LookupCategoryId = Guid.Parse("b4fe9e53-b0cc-4a8b-89d7-712bfc97ac24"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T01:06:15.8129384+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T01:06:15.8129384+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("7f4e75a1-ab7d-4190-8ca6-6b77fa4cf432"),
    Name = @"Library Board",
    LookupCategoryId = Guid.Parse("cf4a4d66-6ced-43f2-959d-613c2fa2110d"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T01:19:35.8207071+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T01:19:35.8207071+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("20c22846-e389-4596-b140-6b99927eaf52"),
    Name = @"PLANNING GRANTS (Fund 504)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:15:42.5287080+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:15:42.5287080+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("aeccecae-c036-4268-9709-6c2aaf32e859"),
    Name = @"TIF Bonds/Notes: 15 - Chart",
    LookupCategoryId = Guid.Parse("2c4caa8d-544b-4393-82be-9a5b7c221117"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T05:53:26.7734953+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T05:53:26.7734953+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("0292e932-f7b8-4d83-90fd-6c974cb5fe68"),
    Name = @"General - Municipal Court Operating Budget (Dept 670)",
    LookupCategoryId = Guid.Parse("2fbf3c72-e26f-4db8-a5de-180bc862d79e"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T05:59:50.5716277+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T05:59:50.5716277+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("f8fc2115-8f20-4f83-a92e-6d6b519f672b"),
    Name = @"Francis Coyoca",
    LookupCategoryId = Guid.Parse("ea188a54-8da6-4c4c-bedf-89a079480790"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-19T12:16:21.1266594+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-19T12:16:21.1266594+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("4cdfcffb-7db1-4620-b33c-6dc228205491"),
    Name = @"Sustainable La Crosse Commission",
    LookupCategoryId = Guid.Parse("3c78d7af-5305-4138-9038-be7425fcecb2"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T02:47:59.8441907+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T02:47:59.8441907+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("640f9351-c3ea-4fa2-8a6b-6e5909808e68"),
    Name = @"General - General Expens e Operating Budget (Dept 420)",
    LookupCategoryId = Guid.Parse("2fbf3c72-e26f-4db8-a5de-180bc862d79e"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T05:58:57.3782207+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T05:58:57.3782207+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("3b41552d-cb8e-4e2d-bf50-6e68ba203d53"),
    Name = @"General - Assessor Operating Budget (Dept 130)",
    LookupCategoryId = Guid.Parse("2fbf3c72-e26f-4db8-a5de-180bc862d79e"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T05:57:43.7258488+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T05:57:43.7258488+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("f496d324-30d3-41e4-8072-6fd1e7034b82"),
    Name = @"POLICE TRAINING FUNDS (Fund 531)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:17:32.2621708+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:17:32.2621708+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("6a9742df-5b46-4757-927d-706d0cee554c"),
    Name = @"General - Finance Operating Budget (Dept 340)",
    LookupCategoryId = Guid.Parse("2fbf3c72-e26f-4db8-a5de-180bc862d79e"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T05:58:33.4432983+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T05:58:33.4432983+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("0475db20-6ee5-4c72-af8a-70c5e3ac8877"),
    Name = @"TIF Bonds/Notes: 12 - Three Rivers Plaza",
    LookupCategoryId = Guid.Parse("e0dd3254-0249-4f71-8c70-36063346ad72"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T05:49:45.4009785+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T05:49:45.4009785+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("6ea100f5-4f72-42e7-b663-712c568bb0ee"),
    Name = @"Public Buildings - La Crosse Center",
    LookupCategoryId = Guid.Parse("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:58:38.5487601+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:59:01.5052391+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("0eee7673-2a8f-4be2-b7ac-71c09eceeeb8"),
    Name = @"PASSENGER FACILITY CHG-R (Fund 2003)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:15:25.2202630+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:15:25.2202630+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("870cf565-d498-4d15-89a7-71f29aaedacd"),
    Name = @"Sent to Finance",
    LookupCategoryId = Guid.Parse("7590f78d-2412-47a6-81b3-4c3acc462b14"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-18T05:59:27.2965294+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T02:48:29.1146895+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("c47da043-47d4-40d9-97b4-72349b3f07e9"),
    Name = @"General - Engineering Operating Budget (Dept 881)",
    LookupCategoryId = Guid.Parse("2fbf3c72-e26f-4db8-a5de-180bc862d79e"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T05:58:25.7798796+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T05:58:25.7798796+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("5b9850bc-8abc-440b-896a-7368d5dbcadb"),
    Name = @"Municipal Transit Utility",
    LookupCategoryId = Guid.Parse("c1353eb7-87ca-4cca-9d5c-f87bd4ae97c8"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T17:25:24.3418360+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T17:25:24.3418360+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("14aa9088-d3cc-4dbd-ab87-73d03f570cfc"),
    Name = @"Federal",
    LookupCategoryId = Guid.Parse("eb07f930-9e73-4cda-a9eb-98c4ec2a2afc"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-28T11:12:47.5447041+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T05:54:50.0092812+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("48f2f630-e2cc-4f9b-a27b-742fee8ed7dd"),
    Name = @"MEG LOCAL (Fund 502)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:14:13.4923051+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:14:13.4923051+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("f766380b-4988-4b63-9a2c-7443a8f8b71f"),
    Name = @"Turner, Ian",
    LookupCategoryId = Guid.Parse("08b0863c-ba0c-48f8-8702-06bbe6578170"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-06-11T06:19:42.2912996+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-06-11T06:19:42.2912996+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("4609f8ee-21ec-4d5e-9474-762531508deb"),
    Name = @"Economic Development - Riverside North",
    LookupCategoryId = Guid.Parse("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:56:26.3254467+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:56:26.3254467+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("98d9a98b-64d8-4ada-89b3-77910ce41c0a"),
    Name = @"2025-Finance CPC Draft",
    LookupCategoryId = Guid.Parse("95f8e0c2-b1dd-44b4-aa66-09f63efddc48"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T17:10:17.5050774+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T17:16:45.2427884+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("c90134c5-8afb-41ca-9a57-781a066c3ea2"),
    Name = @"MUNICIPAL COURT TRUST (Fund 506)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:14:30.9743100+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:14:30.9743100+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("75691d23-ac0a-43ee-9ee0-78563c5f6fcd"),
    Name = @"TID Increment: 16 - LIPCO/Trane Plant 6",
    LookupCategoryId = Guid.Parse("1881c517-32e2-4c09-8bd2-09e2efe7dc61"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:05:10.5198499+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:05:10.5198499+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("4e0c0aee-57ba-41b9-a758-78c82790fdb6"),
    Name = @"Aviation Board",
    LookupCategoryId = Guid.Parse("cf4a4d66-6ced-43f2-959d-613c2fa2110d"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-14T13:07:04.9345387+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-17T04:06:28.2969120+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("0a8bbee9-f548-4229-83c9-78cebf603ba4"),
    Name = @"TID Increment: 11 - Gateway Redevelopment",
    LookupCategoryId = Guid.Parse("1881c517-32e2-4c09-8bd2-09e2efe7dc61"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:04:32.0795592+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:04:32.0795592+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("3166b9f7-d9bb-45c9-805f-7978bb06011c"),
    Name = @"Federal",
    LookupCategoryId = Guid.Parse("f0770a04-79f8-488e-b674-d1dde98e8079"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-06T06:50:24.6766667+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-06T06:50:24.6766667+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("8187e3c4-a3bd-42d5-bdf5-7991c9bc720d"),
    Name = @"2013 CDBG (Fund 2256)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:07:15.7625791+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:07:15.7625791+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("1d468275-63e0-462c-b0ef-7a084cb927ba"),
    Name = @"Airport - Other Buildings",
    LookupCategoryId = Guid.Parse("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-19T07:02:35.2164864+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:54:49.3494049+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("6b49150f-ba9c-40b1-8f07-7a34e4f1d243"),
    Name = @"Loan: State Trust Fund",
    LookupCategoryId = Guid.Parse("e0dd3254-0249-4f71-8c70-36063346ad72"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-21T01:42:30.2782947+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-21T01:42:30.2782947+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("89dde96e-1acf-4ae2-8541-7a51c1f6a4ee"),
    Name = @"8",
    LookupCategoryId = Guid.Parse("e2bc2f40-b296-48b6-bfaa-faf91bd5539e"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-19T06:50:36.3317237+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-19T06:50:36.3317237+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("696c523e-7c0d-4833-bf52-7a535f3c0698"),
    Name = @"Redevelopment Authority",
    LookupCategoryId = Guid.Parse("cf4a4d66-6ced-43f2-959d-613c2fa2110d"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T01:20:07.3903726+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T01:20:07.3903726+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("c5830631-95bd-48bb-b493-7a71bacfcb79"),
    Name = @"GREEN ISLAND ICE ARENA IMPROVE (Fund 239)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:12:21.2897226+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:12:21.2897226+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("d46f8771-7734-41a7-a37a-7aa14da4a711"),
    Name = @"PARK IMPROVEMENT (Fund 509)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:15:06.9035193+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:15:06.9035193+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("7b7bea58-bb80-455a-b890-7ac655ca2693"),
    Name = @"Test Change Set",
    LookupCategoryId = Guid.Parse("95f8e0c2-b1dd-44b4-aa66-09f63efddc48"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-28T05:48:10.5695058+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-28T05:48:10.5695058+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("8c3daad9-f8ee-43f1-9edf-7b5079c93cba"),
    Name = @"TID Increment: 17 - Lot C Downtown",
    LookupCategoryId = Guid.Parse("1881c517-32e2-4c09-8bd2-09e2efe7dc61"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:05:17.5659516+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:05:17.5659516+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("1967eb57-4c09-4684-bb1d-7b9a0b303455"),
    Name = @"Enterprise - Passenger Facility Charges",
    LookupCategoryId = Guid.Parse("b44e86cb-1388-4c3f-ae4c-94d3df4f662b"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-21T05:35:09.7520058+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-21T05:35:09.7520058+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("17ad5030-24f1-4507-aeba-7c3ebc4201f5"),
    Name = @"General - Employee Benefit Operating Budget (Dept 421)",
    LookupCategoryId = Guid.Parse("b44e86cb-1388-4c3f-ae4c-94d3df4f662b"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-21T05:36:13.0554918+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-21T05:36:13.0554918+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("7a5c35bf-6762-443e-ac1d-7c9d74ceda3f"),
    Name = @"Requires Department Review",
    LookupCategoryId = Guid.Parse("93985952-4e53-4b3d-a897-8bec835d8d42"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-03-19T13:28:31.4183127+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-03-19T13:28:31.4183127+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("967902e0-6ea3-40f4-97e7-7d02d681b238"),
    Name = @"General - Human Resources Operating Budget (Dept 790)",
    LookupCategoryId = Guid.Parse("b44e86cb-1388-4c3f-ae4c-94d3df4f662b"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T06:51:49.6639703+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T06:51:49.6639703+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("d53964be-851f-4cb1-be85-7dc051104c4f"),
    Name = @"Flottmeyer, James",
    LookupCategoryId = Guid.Parse("08b0863c-ba0c-48f8-8702-06bbe6578170"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-10T05:33:32.4333333+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-27T01:25:58.5623123+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("5ee122a6-7faf-42bf-910e-7f1d496773da"),
    Name = @"Group First",
    LookupCategoryId = Guid.Parse("0224d7e1-5841-49c4-8dd1-1cb4791bc028"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-13T06:35:00.7420232+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-13T06:35:00.7420232+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("37cf055b-99d9-46bc-978d-80e022a9fb3d"),
    Name = @"Trans and Utils - Alleys",
    LookupCategoryId = Guid.Parse("00316b5b-16ab-480a-8974-50f0f6dd97fe"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T02:56:50.8587594+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T02:56:50.8587594+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("92c48777-180f-47bc-b762-812da9a3d311"),
    Name = @"Board of Public Works",
    LookupCategoryId = Guid.Parse("3c78d7af-5305-4138-9038-be7425fcecb2"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T17:11:32.4057642+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T17:11:32.4057642+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("feb77b35-b2ae-4b29-82e2-814cad1113ae"),
    Name = @"General - Attorney Operating Budget (Dept 140)",
    LookupCategoryId = Guid.Parse("b44e86cb-1388-4c3f-ae4c-94d3df4f662b"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-21T05:35:28.7665613+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-21T05:35:28.7665613+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("f6d38c50-31b9-4cf0-93e0-8174abb09412"),
    Name = @"B and G - Others",
    LookupCategoryId = Guid.Parse("00316b5b-16ab-480a-8974-50f0f6dd97fe"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T02:50:47.9751640+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T02:50:47.9751640+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("5c457d7b-5067-438d-bb2d-8220f63337a2"),
    Name = @"LIBRARY SPECIAL CHECKING (Fund 289)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:14:08.0131493+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:14:08.0131493+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("1fed6bee-da44-4e33-a1b4-823ec3a67827"),
    Name = @"ABANDONED VEHICLE AND TOWING (Fund 542)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:08:30.2409221+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:08:30.2409221+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("05b8205f-abe9-47aa-a0eb-82532b75e145"),
    Name = @"2015 CDBG (Fund 2258)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:07:36.5933349+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:07:36.5933349+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("d0c62b2b-da03-46f6-9233-837b1dbe260c"),
    Name = @"2013 HOME (Fund 2726)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:07:22.3858079+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:07:22.3858079+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("16c1abde-1120-4a6e-bbe6-8399f02e32cf"),
    Name = @"Plan and Dev - Plans and Studies",
    LookupCategoryId = Guid.Parse("00316b5b-16ab-480a-8974-50f0f6dd97fe"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T02:55:59.4452603+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T02:55:59.4452603+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("4f13b518-5c74-40bd-9d93-842f8164f2a4"),
    Name = @"TIF Bonds/Notes: 7 - Amtrak Depot",
    LookupCategoryId = Guid.Parse("2c4caa8d-544b-4393-82be-9a5b7c221117"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T05:54:09.8013567+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T05:54:09.8013567+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("ccda628e-8435-41e1-a300-84559fac17dc"),
    Name = @"Request Removed",
    LookupCategoryId = Guid.Parse("0f4e03dc-0ead-41ad-93a9-26b0b6a0af3a"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T17:14:21.3260672+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T17:14:21.3260672+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("d7e40cc8-af1e-49ed-aedb-84859960f879"),
    Name = @"General - Engineering Operating Budget (Dept 881)",
    LookupCategoryId = Guid.Parse("b44e86cb-1388-4c3f-ae4c-94d3df4f662b"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-21T05:36:18.6655494+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-21T05:36:18.6655494+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("5e791233-7539-4271-9a98-84d906dc412b"),
    Name = @"General - Grounds and Building Operating Budget (Dept 882)",
    LookupCategoryId = Guid.Parse("2fbf3c72-e26f-4db8-a5de-180bc862d79e"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T05:59:06.5223261+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T05:59:06.5223261+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("2d8b9626-1eec-4ad3-8770-85030d52a93c"),
    Name = @"CAMERON PARK CONSTRUCTION (Fund 247)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:09:51.7961704+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:09:51.7961704+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("4419a1cb-69ac-4712-96ef-85ac9ec0bce9"),
    Name = @"Local",
    LookupCategoryId = Guid.Parse("eb07f930-9e73-4cda-a9eb-98c4ec2a2afc"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T05:54:57.4028750+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T05:54:57.4028750+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("cbb8d039-5643-4fc4-b287-8627068c52b0"),
    Name = @"Funding Adjusted",
    LookupCategoryId = Guid.Parse("0f4e03dc-0ead-41ad-93a9-26b0b6a0af3a"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T17:13:31.8704753+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T17:13:31.8704753+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("b7d057b1-c45e-46da-b759-86583d276795"),
    Name = @"General - IT Operating Budget (Dept 580)",
    LookupCategoryId = Guid.Parse("b44e86cb-1388-4c3f-ae4c-94d3df4f662b"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T06:51:21.7981450+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T06:51:21.7981450+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("ed9699e9-954b-458b-b875-87279bf0581e"),
    Name = @"TID Increment: 14 - Gundersen Lutheran",
    LookupCategoryId = Guid.Parse("1881c517-32e2-4c09-8bd2-09e2efe7dc61"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:04:56.3801778+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:04:56.3801778+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("0eee03d6-77d0-44fa-9dd1-8777b5b2f1f9"),
    Name = @"Gallager, Matthew",
    LookupCategoryId = Guid.Parse("76fc224c-bc0a-4458-bf43-bfd8db3a0b83"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T17:28:44.4612035+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T17:29:06.0021076+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("2e0cb8ec-056c-4a69-b8a6-878854cfd678"),
    Name = @"Test Funding Type",
    LookupCategoryId = Guid.Parse("578eae04-ecae-421b-b6e3-722eaee8fc0e"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-28T01:43:19.9373370+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-28T01:43:19.9373370+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("62ba9a19-bd80-4ca6-91d2-8928a60984fa"),
    Name = @"General - Police Operating Budget (Dept 850)",
    LookupCategoryId = Guid.Parse("b44e86cb-1388-4c3f-ae4c-94d3df4f662b"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T06:49:53.6044925+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T06:49:53.6044925+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("a7aadc3b-f8bd-48be-8590-897b991bb54e"),
    Name = @"Streets - Total Street Reconstruction",
    LookupCategoryId = Guid.Parse("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T07:00:45.6493355+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T07:00:45.6493355+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("cfe6d9f0-e3ae-4db5-a75f-8a651ba6c420"),
    Name = @"Common Council",
    LookupCategoryId = Guid.Parse("cf4a4d66-6ced-43f2-959d-613c2fa2110d"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T01:18:00.8857554+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T01:18:00.8857554+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("9e05b1b3-f7c7-490d-a832-8ab1a3789797"),
    Name = @"Technology Hardware and Software",
    LookupCategoryId = Guid.Parse("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T07:01:16.7315012+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T07:01:16.7315012+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("ce330a1c-43fc-4d78-ae42-8ad075b2afcd"),
    Name = @"Poor",
    LookupCategoryId = Guid.Parse("49921477-b361-4299-8fcb-5ec327ddf57c"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-19T07:35:18.1012427+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-19T07:35:18.1012427+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("d010102d-b0bc-4b8a-99d7-8cdaa8cf6815"),
    Name = @"FIRE JUVENILE FIRESETTERS (Fund 224)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:11:32.5833398+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:11:32.5833398+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("84a72325-bdad-4a47-b5b0-8dec733f0f5a"),
    Name = @"INDUSTRIAL PARK SINKING (Fund 290)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:13:11.3872231+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:13:11.3872231+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("75b7158f-56f1-4873-a5b3-8e29c3565945"),
    Name = @"Funding Moved Out",
    LookupCategoryId = Guid.Parse("0f4e03dc-0ead-41ad-93a9-26b0b6a0af3a"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T17:13:11.5011507+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T17:13:11.5011507+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("bc7ddfed-45f6-45e2-a227-8f0d74bb10ec"),
    Name = @"Entered by Department",
    LookupCategoryId = Guid.Parse("93985952-4e53-4b3d-a897-8bec835d8d42"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-06T06:53:39.9733333+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-06T06:53:39.9733333+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("146af0b5-0594-47e2-b9e7-8fb4b35d355d"),
    Name = @"SPECIAL OLYMPICS (Fund 569)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:18:31.1194100+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:18:31.1194100+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("f0037981-993b-4a56-a3e9-90bc8104cc56"),
    Name = @"General - Planning Operating Budget (Dept 820)",
    LookupCategoryId = Guid.Parse("2fbf3c72-e26f-4db8-a5de-180bc862d79e"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:00:04.2896782+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:00:04.2896782+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("df295673-f749-464b-b862-90ef8573b339"),
    Name = @"Streets",
    LookupCategoryId = Guid.Parse("c1353eb7-87ca-4cca-9d5c-f87bd4ae97c8"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T17:27:26.0877344+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T17:27:26.0877344+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("4dd6e9fd-af74-4c1f-9bea-917f4c625a14"),
    Name = @"TID Increment: 12 - Three Rivers Plaza",
    LookupCategoryId = Guid.Parse("1881c517-32e2-4c09-8bd2-09e2efe7dc61"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:04:42.2345970+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:04:42.2345970+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("e20f6181-e7ea-4e6f-8d60-9199e17c56a1"),
    Name = @"B and G - City Hall",
    LookupCategoryId = Guid.Parse("00316b5b-16ab-480a-8974-50f0f6dd97fe"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T02:50:30.6867047+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T02:50:30.6867047+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("13b37571-c157-40f0-9482-92083efc6884"),
    Name = @"Board of Park Commissioners",
    LookupCategoryId = Guid.Parse("cf4a4d66-6ced-43f2-959d-613c2fa2110d"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-06T06:50:09.3800000+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-17T08:46:59.0632984+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("95a118a2-154b-4a2f-acc2-92865494f5a1"),
    Name = @"General - Finance Operating Budget (Dept 340)",
    LookupCategoryId = Guid.Parse("b44e86cb-1388-4c3f-ae4c-94d3df4f662b"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T06:52:56.5304917+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T06:52:56.5304917+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("47fc7aee-87f5-4832-acbc-92a360ad2c03"),
    Name = @"Vehicles and Attachments",
    LookupCategoryId = Guid.Parse("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T07:01:23.2498218+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T07:01:23.2498218+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("72b2781b-a087-4929-82a3-9348e76174fb"),
    Name = @"Parks and Recreation",
    LookupCategoryId = Guid.Parse("18b298cd-91de-4b10-ae36-3bafd0ec02e8"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-21T23:07:09.6292988+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-21T23:07:09.6292988+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("3656e5f9-4721-4a64-b031-94866a724005"),
    Name = @"Enterprise - La Crosse Center Operating Funds (Fund 101)",
    LookupCategoryId = Guid.Parse("b44e86cb-1388-4c3f-ae4c-94d3df4f662b"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-06T06:50:19.8333333+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-21T05:35:01.4711371+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("1094fb08-dfdf-4157-abd3-94c062effc13"),
    Name = @"Legal",
    LookupCategoryId = Guid.Parse("c1353eb7-87ca-4cca-9d5c-f87bd4ae97c8"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T17:24:40.1718636+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T17:24:40.1718636+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("4f359e2b-9950-407f-917a-94c8a447e2eb"),
    Name = @"CL0SED MILLENNIUM CELEBRATION (Fund 573)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:10:24.8313407+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:10:24.8313407+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("f2ee26f4-00ae-43b6-b749-94d708386d5e"),
    Name = @"2017 CDBG (Fund 2260)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:08:04.9961282+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:08:04.9961282+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("0574e943-adb4-42bc-b6e2-9553796dddc2"),
    Name = @"Partial",
    LookupCategoryId = Guid.Parse("5baad37a-5ba1-4ec1-aaa3-992fa352a887"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-19T07:33:11.0836986+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-19T07:34:21.6298832+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("fc274da2-2fa5-4c74-aef8-95b82ed7628d"),
    Name = @"General - Police/Fire Operating Budget (Dept 422)",
    LookupCategoryId = Guid.Parse("2fbf3c72-e26f-4db8-a5de-180bc862d79e"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:00:18.5034984+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:00:18.5034984+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("1c7693c7-5a87-446a-91bc-961549a51e31"),
    Name = @"New Operation",
    LookupCategoryId = Guid.Parse("b4fe9e53-b0cc-4a8b-89d7-712bfc97ac24"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T01:05:46.8585664+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T01:05:46.8585664+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("bb1bf163-f14c-4eef-9d0c-96a5ed9640cc"),
    Name = @"Test Change Type",
    LookupCategoryId = Guid.Parse("0f4e03dc-0ead-41ad-93a9-26b0b6a0af3a"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-19T14:33:50.6459401+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-28T10:55:04.2875651+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("bd8fb4fb-6550-4a54-acd6-973387859d0a"),
    Name = @"Test 2 Change Set",
    LookupCategoryId = Guid.Parse("95f8e0c2-b1dd-44b4-aa66-09f63efddc48"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-28T05:49:43.4145366+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-28T05:49:43.4145366+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("c591ab48-c851-4bf5-8efc-9961d24741bb"),
    Name = @"SCULPTURE (Fund 559)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:18:12.3111995+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:18:12.3111995+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("4a7859c6-76e8-47a3-af85-9a97fc6b411e"),
    Name = @"RIVERSIDE PARK IMPROVEMENTS (Fund 550)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:17:57.3063630+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:17:57.3063630+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("7abfc6b9-0efc-4aba-bec7-9b3c1899269c"),
    Name = @"Replace worn-out equipment",
    LookupCategoryId = Guid.Parse("b4fe9e53-b0cc-4a8b-89d7-712bfc97ac24"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T01:04:53.4768760+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T01:04:53.4768760+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("3f0fb3b7-84e9-4dd6-a67d-9b9975574715"),
    Name = @"TID Increment: 15 - Chart",
    LookupCategoryId = Guid.Parse("1881c517-32e2-4c09-8bd2-09e2efe7dc61"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:05:02.4317238+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:05:02.4317238+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("3a6c2698-96fd-4db5-9a6c-9be55b00223a"),
    Name = @"POLICE CRIME STOPPERS (Fund 521)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:16:04.8193077+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:16:04.8193077+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("320a4663-595d-486e-a710-9c2d7965491e"),
    Name = @"Project",
    LookupCategoryId = Guid.Parse("761adb91-60e3-43bc-bbdf-bdf1b586d4f1"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-13T06:24:42.8740928+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-13T06:24:42.8740928+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("ac24f415-d398-4371-8be1-9c5f9ac3d9d9"),
    Name = @"General - Refuse and Recycling Operating Budget (Dept 886)",
    LookupCategoryId = Guid.Parse("2fbf3c72-e26f-4db8-a5de-180bc862d79e"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:00:26.4415680+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:00:26.4415680+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("fb10b885-1c6e-4fd3-9bda-9cc9006c7bff"),
    Name = @"Planning & Development",
    LookupCategoryId = Guid.Parse("c1353eb7-87ca-4cca-9d5c-f87bd4ae97c8"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T17:26:15.4665337+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T17:26:15.4665337+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("9b1638a0-115d-4267-9c2e-9d111758a89a"),
    Name = @"Trans and Utils - Joint Projects",
    LookupCategoryId = Guid.Parse("00316b5b-16ab-480a-8974-50f0f6dd97fe"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T02:56:59.6966459+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T02:56:59.6966459+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("48d2a343-2956-4785-9f39-9e6b65248f62"),
    Name = @"Pedestrian Safety",
    LookupCategoryId = Guid.Parse("c641a57f-5f5e-4458-b940-4c9e562ff653"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-19T07:37:16.7700368+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-19T07:37:16.7700368+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("e2d2c5d6-c47b-4737-ab4c-9e855eef1db8"),
    Name = @"EDWIN ERICKSON PARK (Fund 225)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:11:01.5563460+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:11:01.5563460+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("99e267e8-48c6-4fe3-999f-9e8599717b22"),
    Name = @"Sent to Finance",
    LookupCategoryId = Guid.Parse("93985952-4e53-4b3d-a897-8bec835d8d42"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-06T06:49:30.5633333+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-18T06:41:48.4110726+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("5e5b211c-93a4-45ca-84fb-9f5d177acd44"),
    Name = @"Plan and Dev - Neighborhoods",
    LookupCategoryId = Guid.Parse("00316b5b-16ab-480a-8974-50f0f6dd97fe"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T02:55:49.3194693+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T02:55:49.3194693+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("53c4a2a0-1a02-4b03-9d93-a05d01c4688d"),
    Name = @"Municipal Court",
    LookupCategoryId = Guid.Parse("18b298cd-91de-4b10-ae36-3bafd0ec02e8"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-21T23:06:19.6904763+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-21T23:06:19.6904763+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("1c767135-83af-4f9b-8b08-a07105a55dd8"),
    Name = @"Public Safety - Fire",
    LookupCategoryId = Guid.Parse("00316b5b-16ab-480a-8974-50f0f6dd97fe"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T02:56:19.8758357+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T02:56:19.8758357+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("a2377ed7-e86b-46d2-8ef8-a0b4e534f936"),
    Name = @"Revenue Bonds/Notes: Water Utility",
    LookupCategoryId = Guid.Parse("e0dd3254-0249-4f71-8c70-36063346ad72"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-21T01:43:02.7908820+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-21T01:43:02.7908820+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("7b75bb54-bf53-4bd0-8085-a0c4494e65d7"),
    Name = @"POLICE EXPLORER POST PROGRAM (Fund 547)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:16:41.5725133+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:16:41.5725133+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("f19bf382-85d4-4f87-a80b-a1a141366ffd"),
    Name = @"General - Insurance Operating Budget (Dept 460)",
    LookupCategoryId = Guid.Parse("2fbf3c72-e26f-4db8-a5de-180bc862d79e"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T05:59:22.0344942+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T05:59:22.0344942+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("961dc7a6-60e2-41a8-9827-a22185e9dbb9"),
    Name = @"Archived",
    LookupCategoryId = Guid.Parse("7590f78d-2412-47a6-81b3-4c3acc462b14"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T02:49:03.4132370+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T02:49:03.4132370+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("5a28c441-acb2-4b31-acb8-a2659cc33e67"),
    Name = @"Grounds and Buildings",
    LookupCategoryId = Guid.Parse("c1353eb7-87ca-4cca-9d5c-f87bd4ae97c8"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T17:20:09.6331051+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T17:20:09.6331051+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("5b45eeeb-6d3c-4682-83a4-a28753a3570f"),
    Name = @"General - Contingency Operating Budget (Dept 250)",
    LookupCategoryId = Guid.Parse("2fbf3c72-e26f-4db8-a5de-180bc862d79e"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T05:58:02.9681608+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T05:58:02.9681608+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("aa75b19d-d635-4f1e-aa7c-a309e6abc669"),
    Name = @"Not Applicable",
    LookupCategoryId = Guid.Parse("41e3334c-a1be-4c55-a21c-8540053b458e"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-06T06:49:50.6533333+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-06T06:49:50.6533333+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("f8f94bd0-d0a4-49b1-9a88-a37539569f61"),
    Name = @"Public Buildings - Municipal Service Center",
    LookupCategoryId = Guid.Parse("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:59:23.0216401+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:59:23.0216401+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("8a0261b2-a7b9-451d-960b-a3f5c40590bd"),
    Name = @"Fire",
    LookupCategoryId = Guid.Parse("c1353eb7-87ca-4cca-9d5c-f87bd4ae97c8"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T17:19:53.7279365+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T17:19:53.7279365+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("908e4dda-3536-4095-b58e-a408d36ca6e0"),
    Name = @"Rejected by Finance",
    LookupCategoryId = Guid.Parse("93985952-4e53-4b3d-a897-8bec835d8d42"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-03-19T13:27:02.4287173+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-03-19T13:27:02.4287173+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("a7a4219d-e994-4de9-942c-a45f29175d47"),
    Name = @"4",
    LookupCategoryId = Guid.Parse("e2bc2f40-b296-48b6-bfaa-faf91bd5539e"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-19T06:50:20.5596340+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-19T06:50:20.5596340+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("12c94843-4f73-4381-8714-a49047ac586c"),
    Name = @"BUDGET CARRYOVER (Fund 299)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:09:45.9037452+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:09:45.9037452+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("073fad94-7a7a-4df3-a7a6-a51aefa7c2c5"),
    Name = @"Low",
    LookupCategoryId = Guid.Parse("41e3334c-a1be-4c55-a21c-8540053b458e"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-06T06:49:50.6366667+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-06T06:49:50.6366667+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("cd7f7b93-f325-45f4-87bf-a54ae215de18"),
    Name = @"Housing Rehabilitation Committee",
    LookupCategoryId = Guid.Parse("cf4a4d66-6ced-43f2-959d-613c2fa2110d"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T01:18:43.4181257+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T01:18:43.4181257+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("01ed4386-e34e-4231-8f54-a5d321e22e2e"),
    Name = @"2018 HOME (Fund 2731)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:08:22.5505921+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:08:22.5505921+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("bdaa6217-cac1-4926-86c3-a696ea3fec28"),
    Name = @"Enterprise - Car Rental Facility Charges",
    LookupCategoryId = Guid.Parse("2fbf3c72-e26f-4db8-a5de-180bc862d79e"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T05:57:22.5153053+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T05:57:22.5153053+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("f4aaedc9-e457-4008-9e54-a6e0742dae79"),
    Name = @"FIRE SMOKEHOUSE (Fund 222)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:11:44.8861808+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:11:44.8861808+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("cbcd5af8-7cce-464b-a352-a6fe5730463e"),
    Name = @"General - Human Resources Operating Budget (Dept 790)",
    LookupCategoryId = Guid.Parse("2fbf3c72-e26f-4db8-a5de-180bc862d79e"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T05:59:15.1643157+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T05:59:15.1643157+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("59a708f6-b024-4ce3-835c-a7016d42bc2f"),
    Name = @"Funding Decreased",
    LookupCategoryId = Guid.Parse("0f4e03dc-0ead-41ad-93a9-26b0b6a0af3a"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T17:14:42.7561390+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T17:14:42.7561390+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("712966c9-c55d-490b-ba63-a72fd33c27a2"),
    Name = @"TIF Bonds/Notes: 6 - City Vision Downtown",
    LookupCategoryId = Guid.Parse("2c4caa8d-544b-4393-82be-9a5b7c221117"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T05:54:01.5164369+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T05:54:01.5164369+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("f5a9a664-ecea-44d9-afd0-a799778928cf"),
    Name = @"General - Streets Operating Budget (Dept 883)",
    LookupCategoryId = Guid.Parse("b44e86cb-1388-4c3f-ae4c-94d3df4f662b"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T06:47:51.8187990+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T06:47:51.8187990+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("e0bac29c-0707-4dc7-8329-a7c26cfaab5d"),
    Name = @"Human Resources",
    LookupCategoryId = Guid.Parse("c1353eb7-87ca-4cca-9d5c-f87bd4ae97c8"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T17:20:26.3129132+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T17:20:26.3129132+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("e13f0afb-8fa5-49dc-ae3c-a894bfbe8301"),
    Name = @"FIRE MISC GRANTS AND CONTRIB (Fund 287)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:11:38.9674754+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:11:38.9674754+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("87c33308-18f1-43c3-a2f4-a8ee0ae83a6c"),
    Name = @"6 - City Vision Downtown",
    LookupCategoryId = Guid.Parse("5516c30d-7a89-419e-be1b-0e5cb64f01ea"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T23:58:43.4700233+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T23:58:43.4700233+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("5fbb5f6b-0cb9-459d-b1ca-a9558d630bcb"),
    Name = @"Reve nue Bonds/Notes: Water Utility",
    LookupCategoryId = Guid.Parse("2c4caa8d-544b-4393-82be-9a5b7c221117"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T05:52:39.9954211+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T05:52:39.9954211+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("bbfe42e4-5e7e-4aae-805f-aaa3bedae890"),
    Name = @"2016 CDBG (Fund 2259)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:07:51.4671081+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:07:51.4671081+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("c51b7da1-eb46-4503-ae59-ab54f491024a"),
    Name = @"Withdrawn by Department",
    LookupCategoryId = Guid.Parse("7590f78d-2412-47a6-81b3-4c3acc462b14"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T02:48:54.5413017+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T02:48:54.5413017+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("b2a953c6-1d94-44d3-b0a0-abf0da366b5c"),
    Name = @"Street Department",
    LookupCategoryId = Guid.Parse("13b9f0c2-c3b3-4b76-b238-1582ecfc81e8"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-19T07:35:51.3230164+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-19T07:35:51.3230164+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("74a24f2e-fa9d-4d64-accb-ac36964293d7"),
    Name = @"POLICE RESERVE PROGRAM (Fund 545)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:17:08.9185176+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:17:08.9185176+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("99ad0e07-8288-453b-b693-ac673a9335be"),
    Name = @"Revenue Bonds/Notes: Sanitary Sewer Utility",
    LookupCategoryId = Guid.Parse("e0dd3254-0249-4f71-8c70-36063346ad72"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-21T01:42:46.9581632+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-21T01:42:46.9581632+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("e53f00a8-8909-4831-b80f-ace0e5fb5fed"),
    Name = @"Unfunded Request",
    LookupCategoryId = Guid.Parse("7590f78d-2412-47a6-81b3-4c3acc462b14"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T02:49:19.4385161+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T02:49:19.4385161+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("b9023a7d-6e41-4b04-8867-ad0ce39f763e"),
    Name = @"Police and Fire Commission",
    LookupCategoryId = Guid.Parse("cf4a4d66-6ced-43f2-959d-613c2fa2110d"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T01:19:57.8428248+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T01:19:57.8428248+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("356726e6-1968-494c-91ff-ad3d67ab9cbc"),
    Name = @"FLOODPLAIN HSNG REPLACEMENT (Fund 584)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:12:03.7035398+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:12:03.7035398+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("0cb142e3-e533-4ae3-83ef-ad5d8d6c4a7b"),
    Name = @"Utility - Sanitary Sewer Equipment Replacement Funds (Fund 632)",
    LookupCategoryId = Guid.Parse("2fbf3c72-e26f-4db8-a5de-180bc862d79e"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:01:13.1593590+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:01:13.1593590+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("9a776989-8997-4644-be82-ad6055bb83c5"),
    Name = @"LA CROSSE CENTER (Fund 201)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:13:30.4852906+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:13:30.4852906+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("9e56af7b-971b-4f27-9d4c-ad6e70d7e3bb"),
    Name = @"CDBG PROGRAM AND OTHER INCOME (Fund 2060)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:10:05.2911508+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:10:05.2911508+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("785f8599-9650-40b5-834f-ad750cf260a6"),
    Name = @"TIF Bonds/Notes: 18 - River Point District",
    LookupCategoryId = Guid.Parse("e0dd3254-0249-4f71-8c70-36063346ad72"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T05:50:52.2223137+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T05:50:52.2223137+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("5750c3ec-7a87-4b51-9b2f-ade8dd2d337e"),
    Name = @"City Plan Commission",
    LookupCategoryId = Guid.Parse("3c78d7af-5305-4138-9038-be7425fcecb2"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T02:46:00.0483711+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T02:46:00.0483711+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("a6d06abc-9184-4af4-8ecf-adfced498680"),
    Name = @"Public Safety - Police",
    LookupCategoryId = Guid.Parse("00316b5b-16ab-480a-8974-50f0f6dd97fe"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T02:56:29.7530147+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T02:56:29.7530147+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("8f9e1cf6-9420-4451-939c-ae01b72ba943"),
    Name = @"COPELAND PARK IMPROVEMENT (Fund 212)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:10:50.7232325+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:10:50.7232325+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("10b264e8-5f58-4055-9a02-ae0d763b9c63"),
    Name = @"Revenue Bonds/Notes: Storm Water Utility",
    LookupCategoryId = Guid.Parse("2c4caa8d-544b-4393-82be-9a5b7c221117"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T05:52:28.7143794+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T05:52:28.7143794+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("cbb5d9d3-f018-4a9d-b8bb-aeca741bb4ca"),
    Name = @"Trans and Utils - Bridges",
    LookupCategoryId = Guid.Parse("00316b5b-16ab-480a-8974-50f0f6dd97fe"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T02:58:01.4927514+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T02:58:01.4927514+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("0dadfa71-ef6c-4b5b-a785-af51ef365659"),
    Name = @"Sanitary Sewers",
    LookupCategoryId = Guid.Parse("7b667e0f-6875-4180-b774-92136e36924b"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-19T07:39:37.6636872+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-19T07:39:37.6636872+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("2a9eb309-e354-4f96-a12e-af6fd0fb265b"),
    Name = @"Funding Sources Changed",
    LookupCategoryId = Guid.Parse("0f4e03dc-0ead-41ad-93a9-26b0b6a0af3a"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T17:14:56.6126436+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T17:14:56.6126436+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("fa7987d5-7dcf-44c2-b33c-af8ac86c3c64"),
    Name = @"POLICE BOAT PATROL PROGRAM (Fund 539)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:15:54.3384178+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:15:54.3384178+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("02aba20a-3f80-4754-a27e-afbfb911db86"),
    Name = @"REPLACEMENT HOUSING (Fund 2020)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:17:50.4692865+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:17:50.4692865+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("4928d6b9-e054-4380-b75e-b12b17c49344"),
    Name = @"FIRE TRAINING (Fund 246)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:11:50.6111846+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:11:50.6111846+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("09d09cd2-98d8-49b3-8b70-b130f0a8cc42"),
    Name = @"Municipal Transit Utility Board",
    LookupCategoryId = Guid.Parse("cf4a4d66-6ced-43f2-959d-613c2fa2110d"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T01:19:42.9041570+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T01:19:42.9041570+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("af629b26-f793-4859-b474-b17ddc8519c9"),
    Name = @"Test Funding Changes",
    LookupCategoryId = Guid.Parse("aef1cf33-b160-4229-a360-691194d2336b"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-28T11:13:11.9210472+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-28T11:13:11.9210472+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("1b71e6fb-4645-484e-b7d1-b1b6563a2256"),
    Name = @"Airport",
    LookupCategoryId = Guid.Parse("18b298cd-91de-4b10-ae36-3bafd0ec02e8"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-06T06:50:04.2033333+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-17T00:15:58.3312222+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("4c3f0f8a-ab30-4d7d-a975-b1efbeb87e25"),
    Name = @"TIF Bonds/Notes: 12 - Three Rivers Plaza",
    LookupCategoryId = Guid.Parse("2c4caa8d-544b-4393-82be-9a5b7c221117"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T05:53:03.5081357+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T05:53:03.5081357+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("1737baba-3402-4d11-83bd-b3e38ea20649"),
    Name = @"Flood Control - Docks and Levees",
    LookupCategoryId = Guid.Parse("00316b5b-16ab-480a-8974-50f0f6dd97fe"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T02:51:06.9070808+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T02:51:06.9070808+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("ac8946a4-4794-4bdd-9e36-b424a019d2b1"),
    Name = @"Alleys",
    LookupCategoryId = Guid.Parse("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:55:26.6986021+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:55:26.6986021+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("41a4e66e-6556-4e57-968f-b47e7f67940d"),
    Name = @"Parking Utility",
    LookupCategoryId = Guid.Parse("18b298cd-91de-4b10-ae36-3bafd0ec02e8"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-21T23:06:52.4056130+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-21T23:06:52.4056130+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("14b4ed11-6fdd-4359-aa31-b58575c42e92"),
    Name = @"Finance",
    LookupCategoryId = Guid.Parse("c1353eb7-87ca-4cca-9d5c-f87bd4ae97c8"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-19T13:50:22.2264370+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-19T13:50:22.2264370+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("94e8a8ea-96e9-4756-bff2-b70a819310d1"),
    Name = @"Loan: State Trust Fund",
    LookupCategoryId = Guid.Parse("2c4caa8d-544b-4393-82be-9a5b7c221117"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-06-13T02:12:11.6454113+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-06-13T02:12:11.6454113+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("9179d50e-9fa0-495f-8b82-b773d23b3b02"),
    Name = @"In Kind/Grant",
    LookupCategoryId = Guid.Parse("b4fe9e53-b0cc-4a8b-89d7-712bfc97ac24"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T01:06:26.6627710+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T01:06:26.6627710+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("f9312f00-f78a-4835-bbb3-b8702bc1da86"),
    Name = @"2017 HOME (Fund 2730 )",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:08:11.0671190+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:08:11.0671190+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("a88e3137-f923-4c93-8151-b8a1d6141943"),
    Name = @"UPPER FLOOR RENOVATION (Fund 577)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:19:09.7136363+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:19:09.7136363+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("4a31b68f-fe8e-45fc-88c5-b8b081da8a3b"),
    Name = @"TID Increment: 7 - Amtrak Depot",
    LookupCategoryId = Guid.Parse("1881c517-32e2-4c09-8bd2-09e2efe7dc61"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:05:37.4683688+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:05:37.4683688+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("a09472e6-e8ce-4b43-aded-b939f77c6d7c"),
    Name = @"Under Review",
    LookupCategoryId = Guid.Parse("c4121504-a142-4624-9c71-8764661893aa"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-25T05:03:46.5611726+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-25T05:03:46.5611726+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("caed32da-ff03-4a32-bad1-b9484088729d"),
    Name = @"Trussoni, Dan",
    LookupCategoryId = Guid.Parse("76fc224c-bc0a-4458-bf43-bfd8db3a0b83"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T17:30:40.5626367+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T17:30:40.5626367+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("9d3d9753-c75d-4d2d-a714-b9496b6bfc90"),
    Name = @"General - Attorney Operating Budget (Dept 140)",
    LookupCategoryId = Guid.Parse("2fbf3c72-e26f-4db8-a5de-180bc862d79e"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T05:57:49.8036382+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T05:57:49.8036382+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("d4b3f515-0a2a-428a-be37-b95301eb48d3"),
    Name = @"General - Police/Fire Operating Budget (Dept 422)",
    LookupCategoryId = Guid.Parse("b44e86cb-1388-4c3f-ae4c-94d3df4f662b"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T06:49:34.4593122+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T06:49:34.4593122+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("4319ff74-168f-4dd6-918c-b9680d0ddb30"),
    Name = @"Reduce personnel time",
    LookupCategoryId = Guid.Parse("b4fe9e53-b0cc-4a8b-89d7-712bfc97ac24"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T01:05:20.9346915+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T01:05:20.9346915+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("20244247-ca45-48fe-b2d5-b987a3563d3d"),
    Name = @"MISCELLANEOUS CONTRIBUTIONS (Fund 288)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:14:19.1474306+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:14:19.1474306+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("c1739a03-f189-47c1-ab15-b9b23255fe5b"),
    Name = @"Requires Department Review",
    LookupCategoryId = Guid.Parse("7590f78d-2412-47a6-81b3-4c3acc462b14"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T02:49:11.1054758+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T02:49:11.1054758+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("4960c3e8-d82b-46c7-a723-ba068f4d43e4"),
    Name = @"TIF Bonds/Notes: 17 - Lot C Downtown",
    LookupCategoryId = Guid.Parse("e0dd3254-0249-4f71-8c70-36063346ad72"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T05:50:41.9843332+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T05:50:41.9843332+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("9a78b288-1880-44c9-af24-ba26abb1c339"),
    Name = @"Streetscaping - Boulevard Trees",
    LookupCategoryId = Guid.Parse("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T07:00:58.3409264+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T07:00:58.3409264+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("52b1af58-6f1c-4ea9-bcb4-ba8e068a876f"),
    Name = @"Sanitary Sewer/Wastewater - Lift Stations",
    LookupCategoryId = Guid.Parse("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:59:42.8925004+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:59:42.8925004+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("78c6a068-9f45-43bb-a59c-bb372ed9e15c"),
    Name = @"Unknown",
    LookupCategoryId = Guid.Parse("1881c517-32e2-4c09-8bd2-09e2efe7dc61"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:06:06.2894339+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:06:06.2894339+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("cca5fb20-2c38-4955-b3d5-bb7a408a35fc"),
    Name = @"Parks - Trails",
    LookupCategoryId = Guid.Parse("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:58:16.1071452+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:58:16.1071452+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("224f1993-257d-47ca-b3d6-be8a016f1df0"),
    Name = @"Gallager, Matthew",
    LookupCategoryId = Guid.Parse("08b0863c-ba0c-48f8-8702-06bbe6578170"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-10T05:33:32.4400000+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-27T01:26:27.6555450+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("7729ad84-0917-49b3-a52d-bfe34f14b06f"),
    Name = @"Parks - Blufflands",
    LookupCategoryId = Guid.Parse("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:57:37.0963397+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:57:37.0963397+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("229bae8d-4e97-427f-9625-c11d86ed25f7"),
    Name = @"Revenue Bonds/Notes: Sanitary Sewer Utility",
    LookupCategoryId = Guid.Parse("2c4caa8d-544b-4393-82be-9a5b7c221117"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T05:52:19.9611787+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T05:52:19.9611787+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("2ad079ec-3fbe-4c53-b950-c1801f03ec98"),
    Name = @"Traffic Safety",
    LookupCategoryId = Guid.Parse("c641a57f-5f5e-4458-b940-4c9e562ff653"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-19T07:36:57.0497778+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-19T07:36:57.0497778+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("cb0dd839-c113-4324-8145-c1b67807815a"),
    Name = @"Jack",
    LookupCategoryId = Guid.Parse("76fc224c-bc0a-4458-bf43-bfd8db3a0b83"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-19T14:38:56.9262955+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-19T14:38:56.9262955+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("767aae96-b6a4-4fb8-8fe3-c203e090ab4e"),
    Name = @"HARBOR SINKING FUND (Fund 507)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:12:47.7532432+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:12:47.7532432+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("fa80304e-7e04-4a8f-b1da-c24a28c2357d"),
    Name = @"Sub Detail 1",
    LookupCategoryId = Guid.Parse("d2b40805-4186-4088-ac14-16be43330171"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-25T02:07:12.3895027+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-25T02:07:12.3895027+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("84573742-0ed5-4fb7-a0e5-c280a71452ef"),
    Name = @"Utility - Water Utility Funds (Fund 645)",
    LookupCategoryId = Guid.Parse("2fbf3c72-e26f-4db8-a5de-180bc862d79e"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:01:35.0185233+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:01:35.0185233+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("16f40604-4809-48ef-a2a3-c2ace7f55c0d"),
    Name = @"Storm Sewer/Stormwater - Other",
    LookupCategoryId = Guid.Parse("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T07:00:11.8723523+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T07:00:11.8723523+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("af3c5e84-4b67-4268-a99a-c4817e5a0936"),
    Name = @"5",
    LookupCategoryId = Guid.Parse("e2bc2f40-b296-48b6-bfaa-faf91bd5539e"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-19T06:50:24.4581089+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-19T06:50:24.4581089+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("da872400-f047-4b46-b6a4-c52f78a94752"),
    Name = @"HOME PROGRAM INCOME (Fund 2050)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:12:53.9313118+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:12:53.9313118+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("4f791c6e-512d-46a8-8ea9-c58953fb0b41"),
    Name = @"100 - GENERAL FUND",
    LookupCategoryId = Guid.Parse("449aa104-a5aa-43c4-8552-5aa69aa69960"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-18T01:37:33.8302174+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-18T01:37:33.8302174+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("e8adfecd-31f8-4171-9201-c58b423f6b70"),
    Name = @"Sustainable La Crosse Commission",
    LookupCategoryId = Guid.Parse("cf4a4d66-6ced-43f2-959d-613c2fa2110d"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T01:20:15.7774996+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T01:20:15.7774996+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("f59eeb5e-c1b5-4e9c-9ca4-c744b19ec03e"),
    Name = @"Engineering",
    LookupCategoryId = Guid.Parse("18b298cd-91de-4b10-ae36-3bafd0ec02e8"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-21T22:57:36.0606479+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-21T22:57:36.0606479+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("a3faa5e4-dc96-4485-b52f-c75b57d885b5"),
    Name = @"15 - Chart",
    LookupCategoryId = Guid.Parse("5516c30d-7a89-419e-be1b-0e5cb64f01ea"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-20T06:35:19.6124191+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-20T06:35:19.6124191+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("dc7b7096-68a4-42c8-80a4-c8699eb4ecb9"),
    Name = @"2011 CBDG (Fund 2254)",
    LookupCategoryId = Guid.Parse("93a30161-93b4-4b47-81f4-021f3f27bb66"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-06T06:50:34.3400000+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-06T06:50:34.3400000+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("cd049916-d292-4380-975a-c8cbe02374e5"),
    Name = @"2016 HOME (Fund 2729)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:07:57.4061354+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:07:57.4061354+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("aaecf3c9-5fcd-4190-a1c7-c9ad93d3aec4"),
    Name = @"POLICE EMERGENCY RESPONSE TEAM (Fund 528)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:16:27.8974216+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:16:27.8974216+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("fb27cb61-0d4d-49e4-aff1-ca9bddd1627f"),
    Name = @"Existing Bond Funds",
    LookupCategoryId = Guid.Parse("1881c517-32e2-4c09-8bd2-09e2efe7dc61"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-28T05:33:21.0865282+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:03:20.8988835+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("f2b43ce1-0053-436e-bd47-cad1c9894d3a"),
    Name = @"TIF Bonds/Notes: 17 - Lot C Downtown",
    LookupCategoryId = Guid.Parse("2c4caa8d-544b-4393-82be-9a5b7c221117"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T05:53:43.0706191+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T05:53:43.0706191+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("77cc2141-c6da-4c34-822b-cafe537bb2f6"),
    Name = @"Planning and Community Development - Miscellaneous",
    LookupCategoryId = Guid.Parse("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:58:22.3174518+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:58:22.3174518+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("e6807242-0442-4d83-979d-cb88575b2275"),
    Name = @"Economic Development Commission",
    LookupCategoryId = Guid.Parse("3c78d7af-5305-4138-9038-be7425fcecb2"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T02:46:32.4400121+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T02:46:32.4400121+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("cbfe409b-c838-4264-916a-cba1b894f9fd"),
    Name = @"Arts",
    LookupCategoryId = Guid.Parse("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-19T07:02:04.7265378+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:55:42.7270188+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("d3ae36c1-f060-4706-9872-cc000dd28e0e"),
    Name = @"BOAT HOUSE (Fund 209)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:09:32.7561706+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:09:32.7561706+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("7e67eb2d-e8fe-4342-92a0-cc0a6361d435"),
    Name = @"INT'L CITY GARDEN FUND (Fund 296)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:13:17.3946489+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:13:17.3946489+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("635be736-ca46-47c3-a6f8-cc1ca0914179"),
    Name = @"Public Buildings - Green Island",
    LookupCategoryId = Guid.Parse("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:58:49.7646882+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:58:49.7646882+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("1e5f6332-e41d-44ed-8bf2-cd10c919cc3b"),
    Name = @"Other",
    LookupCategoryId = Guid.Parse("f0770a04-79f8-488e-b674-d1dde98e8079"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-21T05:34:24.5669962+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-21T05:34:24.5669962+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("b8b96d7d-4918-428f-ba65-cd118bf7d63b"),
    Name = @"Utility - Storm Water Utility Funds (Fund 650)",
    LookupCategoryId = Guid.Parse("2fbf3c72-e26f-4db8-a5de-180bc862d79e"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:01:26.6492686+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:01:26.6492686+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("8c0fe778-ba0c-4b14-af97-cdff2319e29d"),
    Name = @"TIF Bonds/Notes: 10 - Park Plaza",
    LookupCategoryId = Guid.Parse("2c4caa8d-544b-4393-82be-9a5b7c221117"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T05:52:48.2922337+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T05:52:48.2922337+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("ccd6df9a-7592-4f0a-a247-ceab980799f9"),
    Name = @"COUNTY CONTRIBUTIONS FOR AIRPT (Fund 219)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:10:56.5809760+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:10:56.5809760+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("a6c2f440-5305-4181-88f8-ceba034d2932"),
    Name = @"General - Clerks Operating Budget (Dept 220)",
    LookupCategoryId = Guid.Parse("2fbf3c72-e26f-4db8-a5de-180bc862d79e"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T05:57:56.8164665+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T05:57:56.8164665+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("1bd665d0-0430-45ff-9459-cf0f02080850"),
    Name = @"City Clerk",
    LookupCategoryId = Guid.Parse("18b298cd-91de-4b10-ae36-3bafd0ec02e8"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-21T22:57:02.7311740+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-21T22:57:02.7311740+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("4e25f5f7-02d5-4172-882c-cf4af92bab5e"),
    Name = @"Revenue Bonds/Notes: Storm Water Utility",
    LookupCategoryId = Guid.Parse("e0dd3254-0249-4f71-8c70-36063346ad72"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-21T01:42:55.3371865+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-21T01:42:55.3371865+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("ef0487ca-b7c9-4d3d-9e25-cfcae2a33c91"),
    Name = @"Cancelled",
    LookupCategoryId = Guid.Parse("c4121504-a142-4624-9c71-8764661893aa"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T02:59:27.5589614+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T02:59:27.5589614+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("f66b926b-6099-461a-80e6-cfec02e95b66"),
    Name = @"COMMUNITY POLICING FUNDS (Fund 518)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:10:43.5601712+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:10:43.5601712+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("a15af204-9184-448c-aa37-d01a95861696"),
    Name = @"City Council",
    LookupCategoryId = Guid.Parse("c1353eb7-87ca-4cca-9d5c-f87bd4ae97c8"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T17:27:53.0032302+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T17:27:53.0032302+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("3c9d382f-6848-4117-9411-d0be3b4800d2"),
    Name = @"Streets - Bicycle and Pedestrian Improvements",
    LookupCategoryId = Guid.Parse("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T07:00:25.4503220+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T07:00:25.4503220+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("62dee8f6-4289-498e-87d4-d0ebb545fb9c"),
    Name = @"Trees/Plants",
    LookupCategoryId = Guid.Parse("bd4dd1db-1f4d-455c-846b-4e0b620dfb1d"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-19T07:38:25.3298453+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-19T07:38:25.3298453+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("5e7c54c5-b9de-4d83-ac0a-d4ffd0e98448"),
    Name = @"POLICE GREAT LOCAL (Fund 527)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:17:00.4453659+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:17:00.4453659+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("1caf9421-f1cc-4bf7-85ab-d55eb249db38"),
    Name = @"Harbors, Docks and Waterways",
    LookupCategoryId = Guid.Parse("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:57:04.2162661+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:57:04.2162661+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("c7baa91b-0bfa-4313-8aeb-d608d6dc3ce0"),
    Name = @"Mayor",
    LookupCategoryId = Guid.Parse("c1353eb7-87ca-4cca-9d5c-f87bd4ae97c8"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T17:24:56.3077472+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T17:24:56.3077472+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("2f169734-910b-4bc4-a1bc-d63cd85faf24"),
    Name = @"TID Increment: 18 - River Point District",
    LookupCategoryId = Guid.Parse("1881c517-32e2-4c09-8bd2-09e2efe7dc61"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:05:24.6755157+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:05:24.6755157+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("0d3b1e88-d210-4199-9374-d649a49e2140"),
    Name = @"Refuse & Recycling",
    LookupCategoryId = Guid.Parse("c1353eb7-87ca-4cca-9d5c-f87bd4ae97c8"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T17:26:48.3002805+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T17:26:48.3002805+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("a0ff5f63-b7dd-4841-ac44-d6ca5756e6ad"),
    Name = @"COMMUNITY POL PLAN (FGRTLCL) (Fund 519)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:10:32.2200918+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:10:32.2200918+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("2936f712-eebd-4453-aca4-d857e1358196"),
    Name = @"7",
    LookupCategoryId = Guid.Parse("e2bc2f40-b296-48b6-bfaa-faf91bd5539e"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-19T06:50:32.3217444+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-19T06:50:32.3217444+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("3b6b8952-6c60-492d-b1b8-d8873df684b4"),
    Name = @"Legal",
    LookupCategoryId = Guid.Parse("18b298cd-91de-4b10-ae36-3bafd0ec02e8"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-21T22:58:46.8337602+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-21T22:58:46.8337602+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("f00cd64f-554a-4709-bd97-d8e12d0709db"),
    Name = @"Trans and Utils - Streetscaping and Lighting",
    LookupCategoryId = Guid.Parse("00316b5b-16ab-480a-8974-50f0f6dd97fe"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T02:57:23.8501172+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T02:57:23.8501172+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("930b2160-0eb3-4c81-80c4-d9f6794a511f"),
    Name = @"BOAT LANDING IMPROVEMENTS (Fund 514)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:09:40.0607184+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:09:40.0607184+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("41619839-9c72-4dc8-aa68-da1feaf1c31a"),
    Name = @"Request Added",
    LookupCategoryId = Guid.Parse("0f4e03dc-0ead-41ad-93a9-26b0b6a0af3a"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T17:14:10.9492183+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T17:14:10.9492183+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("67c7473d-3071-42f0-ac52-da3721223389"),
    Name = @"Approved by Finance",
    LookupCategoryId = Guid.Parse("93985952-4e53-4b3d-a897-8bec835d8d42"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-03-19T13:27:18.2668369+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-03-19T13:27:18.2668369+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("6e0b5321-1356-4919-b19e-db5621b3ad01"),
    Name = @"Detail 1",
    LookupCategoryId = Guid.Parse("c72a2551-f9d5-4b61-bfe7-0cb74bd53de4"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-25T02:05:13.8008803+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-25T02:05:13.8008803+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("4d77766d-26dc-40f4-b722-dc222ca1b318"),
    Name = @"Francis",
    LookupCategoryId = Guid.Parse("76fc224c-bc0a-4458-bf43-bfd8db3a0b83"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-18T05:59:55.6906850+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-18T05:59:55.6906850+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("6265803a-eac9-4ca4-b0f3-dc9418952754"),
    Name = @"Parks, Recreation and Forestry",
    LookupCategoryId = Guid.Parse("00316b5b-16ab-480a-8974-50f0f6dd97fe"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T02:55:16.3446950+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T02:55:16.3446950+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("6213fe1c-8a7d-4129-9d99-dd3748326f6f"),
    Name = @"POLICE DART (Fund 523)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:16:15.8105746+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:16:15.8105746+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("4212182c-5e43-4c0e-9b1f-ddd9587b2516"),
    Name = @"Bicycle and Pedestrian Advisory Committee",
    LookupCategoryId = Guid.Parse("3c78d7af-5305-4138-9038-be7425fcecb2"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T02:45:14.7867331+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T02:45:14.7867331+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("5c2086a3-26d9-4b66-bacc-de0d0efb72c2"),
    Name = @"2010 CDBG (Fund 2253)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-28T05:30:52.6846273+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:06:55.6257656+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("5d25246d-ed63-4149-a7a8-de320af10b54"),
    Name = @"Water - Other",
    LookupCategoryId = Guid.Parse("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T07:01:30.4188274+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T07:01:30.4188274+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("4d65147f-9dab-42a2-9a76-de80b52fe622"),
    Name = @"Contract",
    LookupCategoryId = Guid.Parse("13b9f0c2-c3b3-4b76-b238-1582ecfc81e8"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-19T07:35:41.2206662+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-19T07:35:41.2206662+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("73457654-b4ea-4101-a3cf-dec59a535da8"),
    Name = @"10",
    LookupCategoryId = Guid.Parse("e2bc2f40-b296-48b6-bfaa-faf91bd5539e"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-19T06:50:48.2031923+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-19T06:50:48.2031923+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("6a1d4fb3-39bb-4245-bb2c-e030b440a636"),
    Name = @"Trans and Utils - Airport",
    LookupCategoryId = Guid.Parse("00316b5b-16ab-480a-8974-50f0f6dd97fe"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T02:57:52.6396164+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T02:57:52.6396164+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("485c2dcd-b430-4b62-b0b2-e0ee5bafe80d"),
    Name = @"Economic Development - Facade Rennovation",
    LookupCategoryId = Guid.Parse("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:55:49.9540806+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:55:59.1166919+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("b2cbe997-8d47-4892-846e-e12a2ca06863"),
    Name = @"Floodplain Improvements",
    LookupCategoryId = Guid.Parse("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:56:57.5946392+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:56:57.5946392+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("e296ed8c-a424-4f90-b77c-e169e6b7407b"),
    Name = @"ANIMAL LICENSE (Fund 235)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:09:02.3821519+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:09:02.3821519+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("653317bb-9339-48e0-ada4-e18b5fe8b2bd"),
    Name = @"Completed",
    LookupCategoryId = Guid.Parse("c4121504-a142-4624-9c71-8764661893aa"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T02:59:17.0999684+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T02:59:17.0999684+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("cb75452b-0a64-4748-a89f-e19f474cd4f1"),
    Name = @"General - Council Operating Budget (Dept 280)",
    LookupCategoryId = Guid.Parse("b44e86cb-1388-4c3f-ae4c-94d3df4f662b"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T06:53:24.9928480+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T06:53:24.9928480+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("68c03bcf-929d-4bd0-98be-e2409de526e0"),
    Name = @"VACANT BLDG REGISTRATION PROG (Fund 286)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:19:15.0193024+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:19:15.0193024+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("f99a9ccc-e2a9-4f91-a54d-e24ea2bc0dd4"),
    Name = @"Request Amended",
    LookupCategoryId = Guid.Parse("0f4e03dc-0ead-41ad-93a9-26b0b6a0af3a"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T17:13:58.5799134+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T17:13:58.5799134+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("febd66e6-6c73-4a52-ad0c-e296e10e181f"),
    Name = @"Street Lighting",
    LookupCategoryId = Guid.Parse("bd4dd1db-1f4d-455c-846b-4e0b620dfb1d"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-19T07:38:07.6621328+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-19T07:38:07.6621328+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("da8c313f-942c-4165-9040-e2c066794427"),
    Name = @"WI HAZMAT REGIONAL RESPONSE (Fund 234)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:19:33.5213930+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:19:33.5213930+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("f696f51b-6c8e-4492-9e7a-e2c2a1bd15d0"),
    Name = @"2014 CDBG (Fund 2257)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:07:30.0985190+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:07:30.0985190+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("201e1eff-5acf-47f3-a4fa-e2d551f15d86"),
    Name = @"Medium",
    LookupCategoryId = Guid.Parse("41e3334c-a1be-4c55-a21c-8540053b458e"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-06T06:49:50.6433333+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-12T13:08:42.8149740+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("c7436917-afea-42ba-9723-e2e143a2ff91"),
    Name = @"General - Refuse and Recycling Operating Budget (Dept 886)",
    LookupCategoryId = Guid.Parse("b44e86cb-1388-4c3f-ae4c-94d3df4f662b"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T06:49:18.4132419+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T06:49:18.4132419+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("1286cd4f-d154-4e33-b033-e323af39f0ec"),
    Name = @"Streetscaping - Street Lighting",
    LookupCategoryId = Guid.Parse("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T07:01:04.3163517+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T07:01:04.3163517+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("2887f6fa-b983-44c7-a651-e35f9b58240b"),
    Name = @"2015 HOME (Fund 2728)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:07:43.7293611+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:07:43.7293611+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("08d4017f-136b-4830-848a-e4d10645c8c2"),
    Name = @"YOUTH ENRICHMENT ASSN (Fund 567)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:19:39.7768779+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:19:39.7768779+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("bea45c1e-2488-4f86-b99a-e52c73709815"),
    Name = @"Water Utility",
    LookupCategoryId = Guid.Parse("18b298cd-91de-4b10-ae36-3bafd0ec02e8"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-17T00:54:02.9411654+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-21T14:33:11.4710434+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("c148a4af-fdc0-4e0e-a1c9-e5f97a137755"),
    Name = @"Stormwater Utility",
    LookupCategoryId = Guid.Parse("c1353eb7-87ca-4cca-9d5c-f87bd4ae97c8"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T17:27:16.9037744+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T17:27:16.9037744+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("3e7bebcc-1548-4de7-b4b3-e63b7951161d"),
    Name = @"NORTHSIDE DOCK IMPROVEMENTS (Fund 508)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:15:00.6548600+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:15:00.6548600+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("7914ce74-8f62-4734-a6c7-e6dedb569f15"),
    Name = @"Program",
    LookupCategoryId = Guid.Parse("76854444-444f-4524-8a61-9fcb24e1c9b1"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-03-27T05:37:58.1951772+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-03-27T05:37:58.1951772+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("95581d66-8687-4a75-bf39-e711af9955c5"),
    Name = @"Finance",
    LookupCategoryId = Guid.Parse("18b298cd-91de-4b10-ae36-3bafd0ec02e8"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-21T22:57:46.6207853+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-21T22:57:46.6207853+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("475f2755-3a21-428d-a0fe-e754f1e160d5"),
    Name = @"9 - International Business Park",
    LookupCategoryId = Guid.Parse("5516c30d-7a89-419e-be1b-0e5cb64f01ea"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T23:58:53.5421206+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T23:58:53.5421206+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("3699325f-4d84-4e96-936b-e83312047940"),
    Name = @"FIRE DEFIBRILLATORS (Fund 220)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:11:06.8472305+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:11:06.8472305+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("80e694cd-a657-47f5-8089-e871e53a9a4a"),
    Name = @"1",
    LookupCategoryId = Guid.Parse("e2bc2f40-b296-48b6-bfaa-faf91bd5539e"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-19T06:50:07.1686756+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-19T06:50:07.1686756+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("8ae0bb3e-5c2d-4ccf-9351-e8aaddd3d528"),
    Name = @"Plan and Dev - Public Art",
    LookupCategoryId = Guid.Parse("00316b5b-16ab-480a-8974-50f0f6dd97fe"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T02:56:09.3086312+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T02:56:09.3086312+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("56f80fdb-c079-4128-b301-e93a51463cb5"),
    Name = @"Municipal Transit Utility",
    LookupCategoryId = Guid.Parse("18b298cd-91de-4b10-ae36-3bafd0ec02e8"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-21T23:06:40.4348939+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-21T23:06:40.4348939+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("fbe65377-2681-4a7b-bfbb-e9d8974312c0"),
    Name = @"POLICE EQUINE PATROL (Fund 525)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:16:35.7167959+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:16:35.7167959+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("8a58750f-d1a1-4e8a-a0d5-e9f0ec1cb5a8"),
    Name = @"Route Changes",
    LookupCategoryId = Guid.Parse("26b6536f-76d3-47db-b395-2a758802bd13"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-19T07:36:27.6848395+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-19T07:36:33.0493775+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("e360290b-3578-4b1a-b9c7-ea83432c2b5c"),
    Name = @"GENA Funds",
    LookupCategoryId = Guid.Parse("1881c517-32e2-4c09-8bd2-09e2efe7dc61"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:03:28.3024990+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:03:28.3024990+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("89f91d8d-0afd-495d-a920-eb47323980b6"),
    Name = @"Increased Safety",
    LookupCategoryId = Guid.Parse("b4fe9e53-b0cc-4a8b-89d7-712bfc97ac24"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T01:06:07.4221853+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T01:06:07.4221853+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("f9b851c3-236c-43d6-966d-ec919c0dd230"),
    Name = @"Stormwater Utility",
    LookupCategoryId = Guid.Parse("18b298cd-91de-4b10-ae36-3bafd0ec02e8"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-21T23:08:00.8341919+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-21T23:08:00.8341919+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("29062e38-2192-448a-a947-ecdbe4e91d29"),
    Name = @"Decorative Paving/Makers",
    LookupCategoryId = Guid.Parse("bd4dd1db-1f4d-455c-846b-4e0b620dfb1d"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-19T07:38:55.3951654+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-19T07:38:55.3951654+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("bb81a609-e0e8-4334-a904-ecdd493c24f4"),
    Name = @"General - Assessor Operating Budget (Dept 130)",
    LookupCategoryId = Guid.Parse("b44e86cb-1388-4c3f-ae4c-94d3df4f662b"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-21T05:35:22.4867286+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-21T05:35:22.4867286+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("c85b7ec0-09ac-49bd-81bb-ecea97e782a8"),
    Name = @"Public Buildings - Pump House",
    LookupCategoryId = Guid.Parse("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:59:36.2035242+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:59:36.2035242+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("d6a35e05-dc95-469b-8c71-ed35f78737b5"),
    Name = @"General - Fire Prevention and Building Safety Operating Budget (Dept 889)",
    LookupCategoryId = Guid.Parse("b44e86cb-1388-4c3f-ae4c-94d3df4f662b"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T06:52:34.0544539+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T06:52:34.0544539+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("574166fe-1c6a-404c-a3ce-ed4e30eeab48"),
    Name = @"Parks - Sports Facilities",
    LookupCategoryId = Guid.Parse("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:58:09.3076153+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:58:09.3076153+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("d88c4739-3b34-4ea7-9e5b-eda997ff8b06"),
    Name = @"Unknown",
    LookupCategoryId = Guid.Parse("b44e86cb-1388-4c3f-ae4c-94d3df4f662b"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T06:48:15.7696678+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T06:48:15.7696678+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("d1ded914-5537-44fe-8060-edf929d5fa8a"),
    Name = @"Needs Status",
    LookupCategoryId = Guid.Parse("c4121504-a142-4624-9c71-8764661893aa"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T02:59:43.6410779+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T02:59:43.6410779+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("7092ff7a-955b-4e64-97d9-edfa1e10e4a1"),
    Name = @"Parking Utility",
    LookupCategoryId = Guid.Parse("c1353eb7-87ca-4cca-9d5c-f87bd4ae97c8"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T17:25:40.8492405+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T17:25:40.8492405+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("546d28fb-1784-43cf-b8e9-ee34e5b8414a"),
    Name = @"TID Increment: 6 - City Vision Downtown",
    LookupCategoryId = Guid.Parse("1881c517-32e2-4c09-8bd2-09e2efe7dc61"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:05:30.7688771+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:05:30.7688771+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("0e6abb22-13da-452c-a8da-ee62bd0293db"),
    Name = @"Refuse and Recycling",
    LookupCategoryId = Guid.Parse("18b298cd-91de-4b10-ae36-3bafd0ec02e8"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-21T23:07:44.0063211+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-21T23:07:44.0063211+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("e58b113a-af81-4e14-9255-ee8ffb58f517"),
    Name = @"2023-Department Submitted",
    LookupCategoryId = Guid.Parse("95f8e0c2-b1dd-44b4-aa66-09f63efddc48"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T17:10:38.9120884+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T17:16:34.4256711+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("1d1ab47f-02e8-4d04-a4d2-eea013254ac0"),
    Name = @"2011 CDBG (Fund 2254)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:07:02.2481547+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:07:02.2481547+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("c7f0e84d-ac32-42f8-99a6-eefe624687db"),
    Name = @"Utilty - Sanitary Sewer Utility Funds (Fund 630)",
    LookupCategoryId = Guid.Parse("2fbf3c72-e26f-4db8-a5de-180bc862d79e"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:01:41.6217275+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:01:41.6217275+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("3f57473d-4476-48f0-bf86-efad6cc5fca4"),
    Name = @"COMMUNITY POLICING CENTER (Fund 529)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:10:37.6326688+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:10:37.6326688+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("5b0b8808-b722-47bf-98a5-effe24a353f6"),
    Name = @"Withdrawn",
    LookupCategoryId = Guid.Parse("c4121504-a142-4624-9c71-8764661893aa"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T02:59:35.8126222+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T02:59:35.8126222+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("68c2bcd8-10f2-4afe-b837-f00294bc39a1"),
    Name = @"Storm Sewers",
    LookupCategoryId = Guid.Parse("7b667e0f-6875-4180-b774-92136e36924b"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-19T07:39:22.1680787+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-19T07:39:22.1680787+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("85e267a0-a4dc-439d-8895-f0083cbd8d01"),
    Name = @"State",
    LookupCategoryId = Guid.Parse("f0770a04-79f8-488e-b674-d1dde98e8079"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-06T06:50:24.6833333+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-06T06:50:24.6833333+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("b2373446-0fb5-427d-a2b1-f05077e8ff74"),
    Name = @"Developer Capital Contributions",
    LookupCategoryId = Guid.Parse("ecc83d3f-910a-4d5c-a8fe-25014b9544d6"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-06T06:55:29.6733333+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-06T06:55:29.6733333+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("2502aad0-ce2c-48ca-b068-f0cd19182739"),
    Name = @"General - General Expense Operating Budget (Dept 420)",
    LookupCategoryId = Guid.Parse("b44e86cb-1388-4c3f-ae4c-94d3df4f662b"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T06:52:16.7513509+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T06:52:16.7513509+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("545e1110-5274-4fa0-af38-f118687f4a12"),
    Name = @"Revenue Bonds/Notes: Parking Utility",
    LookupCategoryId = Guid.Parse("2c4caa8d-544b-4393-82be-9a5b7c221117"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T05:52:11.8863109+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-06-13T02:11:33.7129594+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("3c01a9dd-2f80-4039-92e4-f1512dfcc4e5"),
    Name = @"LIBRARY GERTRUDE GORDON (Fund 227)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:13:50.9914405+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:13:50.9914405+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("2aba7026-d9b6-443b-b77e-f1548a14b8be"),
    Name = @"Storm Sewer/Stormwater - Storm Sewer Mains",
    LookupCategoryId = Guid.Parse("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T07:00:18.0353585+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T07:00:18.0353585+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("2a7adaab-e175-454b-83be-f16a29a19445"),
    Name = @"MYRICK PARK IMPROVEMENT (Fund 207)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:14:36.5045960+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:14:36.5045960+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("d5624254-dcad-45bd-ad70-f1897e257d53"),
    Name = @"In Progress",
    LookupCategoryId = Guid.Parse("c4121504-a142-4624-9c71-8764661893aa"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-19T13:12:33.7401273+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-19T13:12:33.7401273+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("bf4d0de5-b5ee-4bbf-9bc0-f23df6d5965b"),
    Name = @"Police",
    LookupCategoryId = Guid.Parse("18b298cd-91de-4b10-ae36-3bafd0ec02e8"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-21T23:07:32.7230027+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-21T23:07:32.7230027+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("c540b166-5e6d-4223-86a2-f2aa676ad022"),
    Name = @"General - Contingency Operating Budget (Dept 250)",
    LookupCategoryId = Guid.Parse("b44e86cb-1388-4c3f-ae4c-94d3df4f662b"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-21T05:35:39.8335354+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-21T05:35:39.8335354+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("9cdfbffd-2693-4a1a-81e3-f2bad59e7c54"),
    Name = @"General Obligation Bonds/Notes",
    LookupCategoryId = Guid.Parse("e0dd3254-0249-4f71-8c70-36063346ad72"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-06T06:50:14.6933333+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T05:47:43.7156835+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("2600c3d0-e7e8-432b-8765-f360f3b639f5"),
    Name = @"NAVAL RESERVE (Fund 291)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:14:41.9481399+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:14:41.9481399+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("fe891a6c-be70-42b1-a0e0-f56a26d1d33e"),
    Name = @"POL REVOLVING RESTITUTION (Fund 538)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:15:48.5210383+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:15:48.5210383+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("c9319d11-55f9-4877-9db0-f582c5d60e43"),
    Name = @"General - Planning Operating Budget (Dept 820)",
    LookupCategoryId = Guid.Parse("b44e86cb-1388-4c3f-ae4c-94d3df4f662b"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T06:50:10.6365396+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T06:50:10.6365396+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("bba146f3-f1df-4cab-8f8c-f59f43fe855d"),
    Name = @"POLICE SECURITY (Fund 530)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:17:24.6914542+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:17:24.6914542+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("bd09f22b-676e-4864-8fb3-f64c348194ac"),
    Name = @"TIF Bonds/Notes: 7 - Amtrak Depot",
    LookupCategoryId = Guid.Parse("e0dd3254-0249-4f71-8c70-36063346ad72"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T05:51:15.9121523+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T05:51:15.9121523+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("e939c5c2-fbeb-4c47-b0cc-f6fd78778480"),
    Name = @"TIF Bonds/Notes: 13 - Kwik Trip",
    LookupCategoryId = Guid.Parse("e0dd3254-0249-4f71-8c70-36063346ad72"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T05:49:55.8624720+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T05:49:55.8624720+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("7e65e830-74bb-4c21-8dea-f94e057f29f5"),
    Name = @"POLICE FINGERPRINTING (Fund 543)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:16:48.0852680+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:16:48.0852680+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("b560cbfd-171e-4dda-b189-f9b2a8d0ab88"),
    Name = @"Economic Development - Other",
    LookupCategoryId = Guid.Parse("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:56:09.3842025+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:56:09.3842025+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("c912687d-ef31-4ed9-843d-f9b7050f7d42"),
    Name = @"(None)",
    LookupCategoryId = Guid.Parse("3c78d7af-5305-4138-9038-be7425fcecb2"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-19T12:17:21.2538917+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T02:44:34.3126154+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("35f8ffdd-5920-4143-a3c6-f9c469cf1244"),
    Name = @"2012 CDBG (Fund 2255)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:07:08.2885274+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:07:08.2885274+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("fa341e3f-e4e3-459d-989b-fa889b2036bd"),
    Name = @"Equipment",
    LookupCategoryId = Guid.Parse("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:56:32.6844764+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:56:32.6844764+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("5fde2bbd-6fb7-4d6b-b63c-faec780f5031"),
    Name = @"TIF Bonds/Notes: 9 - International Business Park",
    LookupCategoryId = Guid.Parse("e0dd3254-0249-4f71-8c70-36063346ad72"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T05:51:27.0590325+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T05:51:27.0590325+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("7f09a62d-e810-4bc9-b6b1-fb04b24947bf"),
    Name = @"General - Employee Benefit Operating Budget (Dept 421)",
    LookupCategoryId = Guid.Parse("2fbf3c72-e26f-4db8-a5de-180bc862d79e"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T05:58:16.3254316+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T05:58:16.3254316+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("90f46a55-8f73-4718-93b2-fb5704b0f71b"),
    Name = @"7 - Amtrak Depot",
    LookupCategoryId = Guid.Parse("5516c30d-7a89-419e-be1b-0e5cb64f01ea"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T23:58:48.1369514+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T23:58:48.1369514+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("7018bbf4-98a9-46eb-b93f-fbe43d9c8644"),
    Name = @"ANDERSON MEMORIAL (Fund 236)",
    LookupCategoryId = Guid.Parse("6f8d4db4-4d44-4445-90c4-37427636d4c0"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:08:56.1892128+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:08:56.1892128+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("c8add5b3-ee01-49d0-b903-fcae3b460aa2"),
    Name = @"Economic Development Commission",
    LookupCategoryId = Guid.Parse("cf4a4d66-6ced-43f2-959d-613c2fa2110d"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-22T01:18:11.7567134+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-22T01:18:11.7567134+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("6484910f-09ef-423b-b96e-fce8c6f0362c"),
    Name = @"Planning and Development",
    LookupCategoryId = Guid.Parse("18b298cd-91de-4b10-ae36-3bafd0ec02e8"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-21T23:07:18.8486374+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-21T23:07:18.8486374+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("acc71dcc-922a-4e69-a4a2-fdcd374ec58b"),
    Name = @"Library Trustee Funds",
    LookupCategoryId = Guid.Parse("1881c517-32e2-4c09-8bd2-09e2efe7dc61"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:03:56.3013226+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:03:56.3013226+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("b40f76f3-ff28-4806-ae7b-ff6cb211e2d9"),
    Name = @"Infrastructure - Special Projects",
    LookupCategoryId = Guid.Parse("96bfc5c5-5fcf-4631-9c17-ed3dfbe5fe06"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-05-26T06:57:17.8563765+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-05-26T06:57:17.8563765+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("0d59136b-b196-44a2-8e0b-ff82e24e7a6c"),
    Name = @"Miscellaneous",
    LookupCategoryId = Guid.Parse("5baad37a-5ba1-4ec1-aaa3-992fa352a887"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-19T07:33:01.9709048+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-19T07:34:48.7069500+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
},
new LookupValueItemNew
{
    Id = Guid.Parse("bf06be8a-b314-4c20-875f-ff917751f9b6"),
    Name = @"Donations",
    LookupCategoryId = Guid.Parse("ecc83d3f-910a-4d5c-a8fe-25014b9544d6"),
    TenantId = @"root",
    Created = DateTimeOffset.Parse("2025-02-06T06:55:29.6700000+00:00"),
    CreatedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    LastModified = DateTimeOffset.Parse("2025-02-06T06:55:29.6700000+00:00"),
    LastModifiedBy = Guid.Parse("638c53dc-5995-4552-b7ac-1edc48df9e74"),
    IsActive = true
}
    };
}
