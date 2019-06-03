using DotNetCore.AspNetCore;
using DotNetCore.IoC;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DotNetCoreArchitecture.Web
{
    public class Startup
    {
        public Startup(IHostingEnvironment environment)
        {
            Environment = environment;
            Configuration = environment.Configuration();
        }

        private IConfiguration Configuration { get; }

        private IHostingEnvironment Environment { get; }

        public void Configure(IApplicationBuilder application)
        {
            application.UseExceptionMiddleware(Environment);
            application.UseCorsAllowAny();
            application.UseHttps();
            application.UseAuthentication();
            application.UseResponseCompression();
            application.UseResponseCaching();
            application.UseStaticFiles();
            application.UseMvcWithDefaultRoute();
            application.UseHealthChecks();
            application.UseSwaggerDefault();
            application.UseSpa(Environment);
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddLogger(Configuration);
            services.AddCors();
            services.AddJsonWebToken();
            services.AddHash();
            services.AddAuthenticationJwtBearer();
            services.AddResponseCompression();
            services.AddResponseCaching();
            services.AddMvcDefault();
            services.AddHealthChecks();
            services.AddSwaggerDefault();
            services.AddSpa();
            services.AddFileService();
            services.AddApplicationServices();
            services.AddDomainServices();
            services.AddDatabaseServices();
            services.AddDatabaseContext(Configuration);
        }
    }
}
