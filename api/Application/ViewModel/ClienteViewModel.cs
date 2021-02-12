using System.Collections.Generic;
using api.Models.Entities;

namespace Application.ViewModel
{
    public class ClienteViewModel
    {
        public IEnumerable<Cliente> Clientes {get; set;}
    }
}