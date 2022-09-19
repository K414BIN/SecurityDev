using CardStorageService.Data;
using Microsoft.EntityFrameworkCore;
using System;

namespace CardStorageService
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

      
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<CardStorageServiceDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"),
            x => x.MigrationsAssembly("CardStorageService")));

        }
    }
}
