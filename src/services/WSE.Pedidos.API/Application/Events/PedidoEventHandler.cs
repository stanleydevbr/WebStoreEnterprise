﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using WSE.Core.Messages.Integration;
using WSE.MessageBus;

namespace WSE.Pedidos.API.Application.Events
{
    public class PedidoEventHandler : INotificationHandler<PedidoRealizadoEvent>
    {
        private readonly IMessageBus _bus;

        public PedidoEventHandler(IMessageBus bus)
        {
            _bus = bus;
        }

        public async Task Handle(PedidoRealizadoEvent message, CancellationToken cancellationToken)
        {
            await _bus.PublishAsync(new PedidoRealizadoIntegrationEvent(message.ClienteId));
        }
    }
}
