using RestMatch.API.Infrastructure.Extensions;
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

builder.Services.ConfigureAutoMapper();
builder.Services.ConfigureServices();
builder.Services.ConfigureRepositories();

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

app.UseCors("AllowAnyOrigins");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
