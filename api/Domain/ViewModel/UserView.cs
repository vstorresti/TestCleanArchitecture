using System;
using api.Domain.Entities;

namespace api.Domain.ViewModel
{
    public record UserView
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public EnumTipoDeUsuario TipoDeUsuario { get; set; }
    }
}