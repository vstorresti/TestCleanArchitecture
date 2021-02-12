using System.Threading.Tasks;
using api.Controllers;
using Application.Interfaces;
using Application.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Controllers
{
    public class VeiculoController : BaseApiController
    {
        private IVeiculoService _service;

        public VeiculoController(ILogger<VeiculoController> logger, IVeiculoService service) : base(logger)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<VeiculoViewModel>> GetAll()
        {
            return await _service.GetVeiculos();
        }
        
    }
}