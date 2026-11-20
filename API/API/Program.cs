
using API.API.BLL;
using API.API.BLL.Services;
using API.API.DAL.Repositories;
using API.Repository;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.EntityFrameworkCore;
using Microsoft.JSInterop.Infrastructure;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DotNetEnv.Env.Load();
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddScoped<AssignmentService>();
            builder.Services.AddScoped<AssignmentRepository>();
            builder.Services.AddScoped<ChoreService>();
            builder.Services.AddScoped<ChoreRepository>();

            builder.Services.AddScoped<HouseService>();
            builder.Services.AddScoped<HouseRepository>();
            builder.Services.AddScoped<LocationService>();
            builder.Services.AddScoped<LocationRepository>();
            builder.Services.AddScoped<RoomService>();
            builder.Services.AddScoped<RoomRepository>();
            builder.Services.AddScoped<ScoreService>();
            builder.Services.AddScoped<ScoreRepository>();
            builder.Services.AddScoped<StudentService>();
            builder.Services.AddScoped<StudentRepository>();
            builder.Services.AddScoped<AuthenticationService>();
            builder.Services.AddScoped<Client>();

            builder.Services.AddCors(options =>
            {
                options.AddPolicy("Frontend", policy =>
                {
                    policy.WithOrigins(
                        "http://localhost:5173",
                        "http://frontend.satoriservices.nl"
                    )
                    .AllowAnyHeader()
                    .AllowAnyMethod();
                });
            });
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi

            builder.Services.AddOpenApi(options =>
            {
                options.AddDocumentTransformer((document, context, cancellationToken) =>
                {
                    document.Servers = new List<OpenApiServer>
        {
            new OpenApiServer
            {
                Url = "https://api.satoriservices.nl"
            }
        };

                    return Task.CompletedTask;
                });
            });
            var ConnectionString = Environment.GetEnvironmentVariable("DB_CONNECTION");
            var jwtkey = Environment.GetEnvironmentVariable("JWT_KEY");
            builder.Services.AddAutoMapper(cfg => { }, typeof(Mappings));
            builder.Services.AddAuthorization();
            builder.Services.AddDbContext<HousingDbContext>(options =>
            options.UseMySql(
                ConnectionString, ServerVersion.AutoDetect(ConnectionString))
            );

            builder.Services
                .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,

                        ValidIssuer = "StudentHousingAPI",
                        ValidAudience = "StudentHousingFrontend",

                        IssuerSigningKey = new SymmetricSecurityKey(
                        Encoding.UTF8.GetBytes(jwtkey))
                    };
                });

            builder.Services.Configure<ForwardedHeadersOptions>(options =>
            {
                options.ForwardedHeaders =
                    ForwardedHeaders.XForwardedFor |
                    ForwardedHeaders.XForwardedProto;

            });
            var app = builder.Build();
            app.UseForwardedHeaders();
            app.UseDefaultFiles();
            app.UseStaticFiles();

            // `dotnet API.dll --migrate` applies pending EF Core migrations and exits
            // (used by the "migrate" service in docker-compose.yml).
            if (args.Contains("--migrate"))
            {
                using var scope = app.Services.CreateScope();
                var db = scope.ServiceProvider.GetRequiredService<HousingDbContext>();
                db.Database.Migrate();
                Console.WriteLine("Database migrations applied.");
                return;
            }

            // Configure the HTTP request pipeline.
            
                app.MapOpenApi();
                app.UseSwaggerUI(options =>
                {
                    options.SwaggerEndpoint("/openapi/v1.json", "API v1");
                });


            app.UseAuthentication();
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
