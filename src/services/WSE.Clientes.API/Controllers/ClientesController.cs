using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using WSE.Clientes.API.Application.Commands;
using WSE.Core.Mediator;
using WSE.WebAPI.Core.Controllers;

namespace WSE.Clientes.API.Controllers
{
    public class ClientesController : MainController
    {
        private readonly IMediatorHandler _mediatorHandler;

        public ClientesController(IMediatorHandler mediatorHandler)
        {
            _mediatorHandler = mediatorHandler;
        }

        [HttpGet("clientes")]
        public async Task<IActionResult> Index()
        {
            var resultado = await _mediatorHandler.EnviarComando(
                new RegistrarClienteCommand(Guid.NewGuid(), "Stanley", "stanley.dias.paulo@gmail.com", "81580584187"));

            return CustomResponse(resultado);
        }
    }
}
