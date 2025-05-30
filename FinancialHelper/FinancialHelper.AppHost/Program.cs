var builder = DistributedApplication.CreateBuilder(args);

var databaseBuilder = builder.AddPostgres("Database");

var apiService = builder.AddProject<Projects.FinancialHelper_ApiService>("Microservice1")
    .WithReference(databaseBuilder);

builder.AddProject<Projects.FinancialHelper_Web>("UI")
    .WithExternalHttpEndpoints()
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
