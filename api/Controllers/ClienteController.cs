using System.Threading.Tasks;
using api.Controllers;
using Application.Interfaces;
using Application.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Controllers
{
    public class ClienteController : BaseApiController
    {
        private IClienteService _service;

        public ClienteController(ILogger<ClienteController> logger, IClienteService service) : base(logger)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<ClienteViewModel>> GetAll()
        {
            return await _service.GetClientes();
        }
        
    }
}