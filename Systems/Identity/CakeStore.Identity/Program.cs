using CakeStore.Identity;
using CakeStore.Identity.Configuration;
using CakeStore.Context;
using CakeStore.Services.Settings;
using CakeStore.Settings;

var logSettings = Settings.Load<LogSettings>("Log");

var builder = WebApplication.CreateBuilder(args);

builder.AddAppLogger(logSettings);

// Configure services
var services = builder.Services;

services.AddAppCors();

services.AddHttpContextAccessor();

services.AddAppDbContext(builder.Configuration);

services.AddAppHealthChecks();

services.RegisterAppServices();

services.AddIS4();


// Configure the HTTP request pipeline.

var app = builder.Build();

app.UseAppCors();

app.UseAppHealthChecks();

app.UseIS4();


// Run app

app.Run();
