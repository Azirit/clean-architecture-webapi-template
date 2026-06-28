using Capi.Api;
using Capi.Application;
using Capi.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddApiServices(builder.Configuration)
    .AddApplicationServices(builder.Configuration)
    .AddInfrastructureServices(builder.Configuration);

var app = builder.Build();

app.UseApiServices();

app.Run();
