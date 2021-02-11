using api.Domain.Entities;
using api.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace api.Controllers
{
    public class ClienteController : BaseApiController
    {
        private readonly ILogger<ClienteController> _logger;

        private readonly ClienteService _clienteService;

        public ClienteController(
            ILogger<ClienteController> logger,
            ClienteService clienteService
        ) :
            base(logger)
        {
            _logger = logger;
            _clienteService = clienteService;
        }


        [HttpGet]
        [Route("/cliente")]
        public async Task<ICollection<Cliente>> ListAll()
        {
            return await _clienteService.All();
        }

    }
}
