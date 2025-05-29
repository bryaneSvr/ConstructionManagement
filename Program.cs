using Microsoft.OpenApi;
using Microsoft.OpenApi.Models;
using System.Reflection;
using ConstructionManagement.SwaggerHelper; // Add this namespace for OpenApiSpecVersion

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddControllers(options => options.Conventions.Add(new GroupingByNamespaceConversion()));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();
builder.Services.AddApiVersioning(options =>
{
    options.AssumeDefaultVersionWhenUnspecified = true;
    options.DefaultApiVersion = new Asp.Versioning.ApiVersion(1, 2); // Default to version 1.0
    options.ReportApiVersions = true; // Include version information in response headers
});
builder.Services.AddSwaggerGen(options =>
{
    // Define Swagger document for version 1.0
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Construction Management API",
        Description = "API for managing construction projects (Version 1.0)"
    });

    // Define Swagger document for version 2.0
    options.SwaggerDoc("v2", new OpenApiInfo
    {
        Version = "v2",
        Title = "Construction Management API",
        Description = "API for managing construction projects (Version 2.0)"
    });

    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger(options =>
    {
        options.OpenApiVersion = OpenApiSpecVersion.OpenApi3_0;
    });
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "Construction Management API v1");
        options.SwaggerEndpoint("/swagger/v2/swagger.json", "Construction Management API v2");
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
