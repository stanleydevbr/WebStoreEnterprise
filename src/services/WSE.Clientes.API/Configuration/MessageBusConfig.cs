using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WSE.Clientes.API.Services;
using WSE.Core.Utils;
using WSE.MessageBus;

namespace WSE.Clientes.API.Configuration
{

    public static class MessageBusConfig
    {
        public static void AddMessageBusConfiguration(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddMessageBus(configuration.GetMessageQueueConnection("MessageBus"))
                .AddHostedService<RegistroClienteIntegrationHandler>();
        }
    }
}
