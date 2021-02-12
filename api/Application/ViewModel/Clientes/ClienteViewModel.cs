using System.Collections.Generic;
using api.Models.Entities;

namespace Application.ViewModel.Clientes
{
    public class ClienteViewModel
    {
        public IEnumerable<Cliente> Clientes {get; set;}
    }
}