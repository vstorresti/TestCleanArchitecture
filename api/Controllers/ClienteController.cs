using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using api.Domain.ViewModel;
using api.Infra.Database;

namespace api.Controllers
{
    public class ClienteController : BaseApiController
    {
        private readonly ILogger<ClienteController> _logger;

        private readonly EntityContext _context;

        public ClienteController(
            ILogger<ClienteController> logger,
            EntityContext context
        ) :
            base(logger)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        [Route("/cliente")]
        public async Task<ActionResult<UserView>> ListAll()
        {
            var clientes = await _context.Clientes.All();
            return clientes;
        }
    }
}
