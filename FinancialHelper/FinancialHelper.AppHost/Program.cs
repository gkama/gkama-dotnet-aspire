var builder = DistributedApplication.CreateBuilder(args);

var databaseBuilder = builder.AddPostgres("Database");

var cacheBuilder = builder.AddRedis("Cache")
                   .WithRedisInsight();

var apiService = builder.AddProject<Projects.FinancialHelper_ApiService>("Microservice1")
    .WithReference(databaseBuilder)
    .WithReference(cacheBuilder);

builder.AddProject<Projects.FinancialHelper_Web>("UI")
    .WithExternalHttpEndpoints()
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
