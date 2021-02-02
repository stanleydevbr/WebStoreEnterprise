using Microsoft.Extensions.DependencyInjection;
using WSE.Catalogo.API.Data;
using WSE.Catalogo.API.Data.Repository;
using WSE.Catalogo.API.Models;

namespace WSE.Catalogo.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<CatalogoContext>();
        }
    }
}
