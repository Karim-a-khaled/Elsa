using Elsa.API.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAPPServices(builder.Configuration);

var app = builder.Build();

app.AddUsings();
app.Run();