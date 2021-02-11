using api.Domain.Entities;
using System;

namespace api.Domain.ViewModel
{
    public record UserView
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public EnumTipoDeUsuario TipoDeUsuario { get; set; }
    }
}