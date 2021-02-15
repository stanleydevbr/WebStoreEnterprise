using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WSE.Carrinho.API.Services;
using WSE.Core.Utils;
using WSE.MessageBus;

namespace WSE.Carrinho.API.Configuration
{
    public static class MessageBusConfig
    {
        public static void AddMessageBusConfiguration(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddMessageBus(configuration.GetMessageQueueConnection("MessageBus"))
                .AddHostedService<CarrinhoIntegrationHandler>();
        }
    }
}
