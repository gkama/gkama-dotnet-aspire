using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = DistributedApplication.CreateBuilder(args);

var databaseBuilder = builder.AddPostgres("Database");

var database = databaseBuilder.AddDatabase("financialhelper");

var cacheBuilder = builder.AddRedis("Cache")
                   .WithRedisInsight();

var hostEnvironment = builder.Services.BuildServiceProvider().GetRequiredService<IHostEnvironment>();

if (hostEnvironment.IsDevelopment())
{
    databaseBuilder.WithPgAdmin(pgAdmin => pgAdmin.WithHostPort(5050));
}

var apiService = builder.AddProject<Projects.FinancialHelper_ApiService>("Microservice1")
    .WithReference(database)
    .WaitFor(database)
    .WithReference(cacheBuilder)
    .WaitFor(cacheBuilder);

builder.AddProject<Projects.FinancialHelper_Web>("UI")
    .WithExternalHttpEndpoints()
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
