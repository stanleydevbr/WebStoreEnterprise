using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using WSE.Pagamentos.API.Data;
using WSE.Pagamentos.API.Data.Repository;
using WSE.Pagamentos.API.Facade;
using WSE.Pagamentos.API.Models;
using WSE.Pagamentos.API.Services;
using WSE.WebAPI.Core.Usuario;

namespace WSE.Pagamentos.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IAspNetUser, AspNetUser>();

            services.AddScoped<IPagamentoService, PagamentoService>();
            services.AddScoped<IPagamentoFacade, PagamentoCartaoCreditoFacade>();

            services.AddScoped<IPagamentoRepository, PagamentoRepository>();
            services.AddScoped<PagamentosContext>();
        }
    }
}
