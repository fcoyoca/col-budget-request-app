var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Server>("webapi")
       .WithExternalHttpEndpoints();

using var app = builder.Build();

await app.RunAsync();
