using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WSE.Core.Utils;
using WSE.MessageBus;
using WSE.Pedidos.API.Services;

namespace WSE.Pedidos.API.Configuration
{
    public static class MessageBusConfig
    {
        public static void AddMessageBusConfiguration(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddMessageBus(configuration.GetMessageQueueConnection("MessageBus"))
                            .AddHostedService<PedidoOrquestradorIntegrationHandler>()
                            .AddHostedService<PedidoIntegrationHandler>();
        }
    }
}
