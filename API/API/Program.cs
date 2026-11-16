
using API.API.BLL;
using API.API.BLL.Services;
using API.API.DAL.Repositories;
using API.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.JSInterop.Infrastructure;

namespace API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            DotNetEnv.Env.Load();
            builder.Services.AddControllers();
            builder.Services.AddScoped<AssignmentService>();
            builder.Services.AddScoped<AssignmentRepository>();
            builder.Services.AddScoped<ChoreService>();
            builder.Services.AddScoped<ChoreRepository>();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();
            var ConnectionString = Environment.GetEnvironmentVariable("DB_CONNECTION");
            builder.Services.AddAutoMapper(cfg => { }, typeof(Mappings));
            builder.Services.AddDbContext<HousingDbContext>(options =>
            options.UseMySql(
                ConnectionString, ServerVersion.AutoDetect(ConnectionString))
            );
            var app = builder.Build();

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
            

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
