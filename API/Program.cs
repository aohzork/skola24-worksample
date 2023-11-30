using API.Data;
using API.Services;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System;

var builder = WebApplication.CreateBuilder(args);

//Add different connectionstrings if development or production
var environment = builder.Configuration.GetSection("Environment").Value ?? "Development";

var appSettingsFileName = $"appsettings.{environment}.json";
var configuration = new ConfigurationBuilder()
    .SetBasePath(builder.Environment.ContentRootPath)
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddJsonFile(appSettingsFileName, optional: true, reloadOnChange: true)
    .Build();

var connectionStrings = new ConnectionStrings();
configuration.GetSection("ConnectionStrings").Bind(connectionStrings);

builder.Services.AddDbContext<Skola24Context>(options =>
{
    options.UseSqlServer(environment.Equals("Development", StringComparison.OrdinalIgnoreCase) 
                                                            ? connectionStrings.Development 
                                                            : connectionStrings.Production);
});


// Add services to the container.
builder.Services.AddScoped<IAbsenceService, AbsenceService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Add CORS
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.WithOrigins("http://localhost:5173")
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseCors();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
