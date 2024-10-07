using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PM.Core.Infrastructure;
using PM.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace PM.Services
{
    public class ServicesConfiguration : IPmStartup
    {
        /// <summary>
        ///  Add and configure any of the middleware
        /// </summary>
        /// <param name = "services" ></ param >
        /// < param name="connectionString"></param>
        //public static void ConfigureServices(IServiceCollection services, string connectionString)
        //{
        //    services.AddDbContext<DatabaseDbContext>(options => options.UseSqlServer(connectionString));

        //    //Category
        //    services.AddTransient<ICategoryManager, CategoryManager>();
        //    services.AddTransient<ICategoryRepository, CategoryRepository>();
        //    //product
        //    services.AddTransient<IProductManager, ProductManager>();
        //    services.AddTransient<IProductRepository, ProductRepository>();
        //    //stock
        //    services.AddTransient<IStockManager, StockManager>();
        //    services.AddTransient<IStockRepository, StockRepository>();
        //    DbContext
        //    services.AddTransient<DbContext, DatabaseDbContext>();
        //    services.AddTransient<DatabaseDbContext>();
        //}

        /// <summary>
        /// Add and configure any of the middleware
        /// </summary>
        /// <param name="services">Collection of service descriptors</param>
        /// <param name="configuration">Configuration of the application</param>
        public virtual void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DatabaseDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            //DbContext
            services.AddTransient<DbContext, DatabaseDbContext>();
            services.AddTransient<DatabaseDbContext>();
        }

        /// <summary>
        /// Configure the using of added middleware
        /// </summary>
        /// <param name="application">Builder for configuring an application's request pipeline</param>
        public void Configure(IApplicationBuilder application)
        {
        }

        /// <summary>
        /// Gets order of this startup configuration implementation
        /// </summary>
        public int Order => 10;
    }
}
