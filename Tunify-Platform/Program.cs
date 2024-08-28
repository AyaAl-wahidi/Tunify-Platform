using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Tunify_Platform.Data;
using Tunify_Platform.Models;
using Tunify_Platform.Repositories.Interfaces;
using Tunify_Platform.Repositories.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.CodeAnalysis.Options;
using Microsoft.OpenApi.Models;

namespace Tunify_Platform
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();

            // Get the connection string settings
            string ConnectionStringVar = builder.Configuration.GetConnectionString("DefaultConnection");

            builder.Services.AddDbContext<TunifyDbContext>(op => op.UseSqlServer(ConnectionStringVar));

            // Add Identity Service
            builder.Services.AddIdentity<Account, IdentityRole>()
                .AddEntityFrameworkStores<TunifyDbContext>();

            builder.Services.AddHttpContextAccessor();

            //Add The Services & Interfaces Access
            builder.Services.AddScoped<IUser, UserService>();
            builder.Services.AddScoped<IArtist, ArtistService>();
            builder.Services.AddScoped<IPlaylist, PlaylistServise>();
            builder.Services.AddScoped<ISong, SongService>();
            builder.Services.AddScoped<IAccount, IdentityAccountService>();
            builder.Services.AddScoped<JwtTokenService>();

            // add auth service to the app using jwt
            builder.Services.AddAuthentication(
                options =>
                {
                    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                }
                ).AddJwtBearer(
                options =>
                {
                    options.TokenValidationParameters = JwtTokenService.ValidateToken(builder.Configuration);
                });

            // Add Policy Authorization
            builder.Services.AddAuthorization(options =>
            {
                //options.AddPolicy("RequireAdminRole", policy => policy.RequireRole("Admin"));
                options.AddPolicy("full_access", policy => policy.RequireClaim("permission", "full_access"));
                options.AddPolicy("create", policy => policy.RequireClaim("createPermission", "create"));
            });

            // Swagger Configration
            builder.Services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("tunifyApi", new Microsoft.OpenApi.Models.OpenApiInfo()
                {
                    Title = "Tunify API",
                    Version = "v1",
                    Description = "This API developed as part of the Tunify Platform project, is designed to manage various entities related to music, such as artists, songs, and playlists. The API allows users to perform CRUD (Create, Read, Update, Delete) operations on these entities, making it possible to build, organize, and manage a music library."
                });

                options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.Http,
                    Scheme = "bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Description = "Please enter user token below."
                });

                options.AddSecurityRequirement(new OpenApiSecurityRequirement
                    {
                        {
                            new OpenApiSecurityScheme
                            {
                                Reference = new OpenApiReference
                                {
                                    Type = ReferenceType.SecurityScheme,
                                    Id = "Bearer"
                                }
                            },
                            Array.Empty<string>()
                        }
                    });
            });

            var app = builder.Build();

            app.UseAuthentication();
            app.UseAuthorization();

            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Call Swagger Service
            app.UseSwagger(options =>
            {
                options.RouteTemplate = "api/{documentName}/swagger.json";
            });

            // Call Swagger UI
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/api/tunifyApi/swagger.json", "Tunify API v1");
                options.RoutePrefix = "";
            });

            app.MapControllers();
            app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}