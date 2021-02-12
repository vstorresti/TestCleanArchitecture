using System.Threading.Tasks;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using api.Controllers;
using Application.ViewModel.Clientes;
using api.Models.Entities;

namespace Controllers
{
    public class ClienteController : BaseApiController
    {
        private IClienteService _service;

        public ClienteController(
            ILogger<ClienteController> logger,
            IClienteService service
        ) :
            base(logger)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<ClienteViewModel>> GetAll()
        {
            return await _service.GetClientes();
        }

        [HttpGet("cliente/{id}")]
        public async Task<ClienteVm> GetById(int id)
        {
            return await _service.GetById(id);
        }

        [HttpPost]
        public async Task Save([FromBody] Cliente cliente)
        {
            await _service.Save(cliente);
        }

        [HttpPut]
        public async Task Update([FromBody] Cliente cliente)
        {
            await _service.Update(cliente);
        }

        [HttpDelete]
        public async Task Delete([FromBody] Cliente cliente)
        {
            await _service.Delete(cliente);
        }

        
    }
}
