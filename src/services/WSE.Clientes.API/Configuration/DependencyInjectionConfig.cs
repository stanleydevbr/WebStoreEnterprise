using FluentValidation.Results;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using WSE.Clientes.API.Application.Commands;
using WSE.Clientes.API.Application.Events;
using WSE.Clientes.API.Data;
using WSE.Clientes.API.Data.Repository;
using WSE.Clientes.API.Models;
using WSE.Core.Mediator;

namespace WSE.Clientes.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IMediatorHandler, MediatorHandler>();
            services.AddScoped<IRequestHandler<RegistrarClienteCommand, ValidationResult>, ClienteCommandHandler>();

            services.AddScoped<INotificationHandler<ClienteRegistradoEvent>, ClienteEventHandler>();

            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<ClientesContext>();

        }
    }
}
