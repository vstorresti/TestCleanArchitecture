using System.Threading.Tasks;
using api.Controllers;
using Application.Interfaces;
using Application.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Controllers
{
    public class OperadorController : BaseApiController
    {
        private IOperadorService _service;

        public OperadorController(ILogger<OperadorController> logger, IOperadorService service) : base(logger)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<OperadorViewModel>> GetAll()
        {
            return await _service.GetOperadores();
        }
        
    }
}