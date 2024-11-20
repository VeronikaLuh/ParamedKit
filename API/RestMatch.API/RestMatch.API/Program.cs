using RestMatch.API.Application.Interfaces;
using RestMatch.API.Application.Services;
using RestMatch.API.Domain.Interfaces;
using RestMatch.API.Infrastructure.Data;
using RestMatch.API.Infrastructure.Extensions;
using RestMatch.API.Infrastructure.Repositories;
using NSwag.Generation.Processors.Security;
using NSwag;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(policy =>
{
    policy.AddPolicy("AllowAnyOrigins", _ =>
    {
        _.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
    });
});

builder.Services.AddControllers();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddScoped<IRestaurantRepository, RestaurantRepository>();
builder.Services.AddScoped<IRestaurantService, RestaurantService>();
builder.Services.AddScoped<ICuisineTypeRepository, CuisineTypeRepository>();
builder.Services.AddScoped<ICuisineTypeService, CuisineTypeService>();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddOpenApiDocument(config =>
{
    config.Title = "RestMatch API";

    config.DocumentProcessors.Add(new SecurityDefinitionAppender("Bearer",
        new OpenApiSecurityScheme
        {
            Type = OpenApiSecuritySchemeType.ApiKey,
            Name = "Authorization",
            Description = "Copy 'Bearer ' + valid JWT token",
            In = OpenApiSecurityApiKeyLocation.Header
        }));
});

builder.Services.ConfigureDbContext(builder.Configuration);

var app = builder.Build();

app.UseOpenApi();
app.UseSwaggerUi();

if (app.Environment.IsDevelopment())
{
    using var scope = app.Services.CreateScope();
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<ApplicationDbContext>();
    SeedExtensions.Initialize(services, context);
}

app.UseCors("AllowAnyOrigins");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
