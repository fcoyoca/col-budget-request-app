var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Server>("webapi")
       .WithExternalHttpEndpoints()
       .WithEnvironment("ASPNETCORE_ENVIRONMENT", builder.Environment.EnvironmentName);

using var app = builder.Build();

await app.RunAsync();
