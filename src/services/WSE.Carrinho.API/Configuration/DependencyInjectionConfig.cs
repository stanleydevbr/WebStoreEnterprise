using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using WSE.Carrinho.API.Data;
using WSE.WebAPI.Core.Usuario;

namespace WSE.Carrinho.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IAspNetUser, AspNetUser>();
            services.AddScoped<CarrinhoContext>();
        }
    }
}
