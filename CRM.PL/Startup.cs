using CRM.BL.Interfaces;
using CRM.BL.Services;
using CRM.DA.EFContext;
using CRM.DA.Interfaces;
using CRM.DA.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using JavaScriptEngineSwitcher.Extensions.MsDependencyInjection;
using JavaScriptEngineSwitcher.ChakraCore;
using CRM.DA.Entities.Auth;
using Microsoft.AspNetCore.Identity;
using CRM.PL.JwtModel;
using CRM.DA.UnitOfWork;
using CRM.PL.Extensions;

namespace CRM.PL
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            var jwtSettings = Configuration.GetSection("Jwt").Get<JwtSettings>();
            services.AddDbContext<DBContext>(options => options.UseSqlServer(Configuration["DefaultConnection"]));
            services.AddIdentity<CrmUser, CrmRole>().AddEntityFrameworkStores<DBContext>().AddDefaultTokenProviders();
            services.Configure<JwtSettings>(Configuration.GetSection("Jwt"));
            services.AddAuth(jwtSettings);
            services.AddControllers().AddNewtonsoftJson();
            services.AddAutoMapper(typeof(Startup));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IPersonRepository, PersonRepository>();
            services.AddScoped<IProjectRepository, ProjectRepository>();
            services.AddScoped<IStageRepository, StageRepository>();
            services.AddTransient<IPersonService, PersonService>();
            services.AddTransient<IProjectService, ProjectService>();
            services.AddTransient<IStageService, StageService>();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "CRM.PL", Version = "v1" });
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = "JWT containing userid claim",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey,
                }); 
                var security = new OpenApiSecurityRequirement 
                {
                    { 
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Id = "Bearer",
                                Type = ReferenceType.SecurityScheme
                            },
                            UnresolvedReference = true
                        },
                        new List<string>()
                    }
                }; 
                c.AddSecurityRequirement(security);
            });
            services.AddMemoryCache();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddJsEngineSwitcher(options => options.DefaultEngineName = ChakraCoreJsEngine.EngineName).AddChakraCore();
            services.AddCors();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CRM.PL v1"));
            }
            
            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseRouting();

            app.UseAuthorization();
            app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            app.UseAuth();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
