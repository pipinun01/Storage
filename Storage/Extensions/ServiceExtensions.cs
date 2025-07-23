using Microsoft.EntityFrameworkCore;
using Repository;
using RepositoryContract;
using Service;
using ServiceContract;

namespace Storage.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration) => services.AddDbContext<StorageContext>(opts => opts.UseSqlServer(configuration.GetConnectionString("sqlConnection")));
        public static void ConfigureRepositoryManager(this IServiceCollection services) => services.AddScoped<IAddProduct, AddProduct>();

        public static void ConfigureServiceManager(this IServiceCollection services) => services.AddScoped<IAddProductUseCase, AddProductUseCase>();
    }
}
