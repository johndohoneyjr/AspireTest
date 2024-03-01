var builder = DistributedApplication.CreateBuilder(args);

var redis = builder.AddRedis("cache");

var apiService = builder.AddProject<Projects.AspireApp1_ApiService>("apiservice");

builder.AddProject<Projects.AspireApp1_Web>("webfrontend")
    .WithReference(apiService)
    .WithReference(redis);

builder.Build().Run();
