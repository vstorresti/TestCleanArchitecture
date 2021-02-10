using System;

namespace api.Domain.Entities
{
    public interface IOperador
    {
        string Matricula { get; set; }

        string Senha { get; set; }

        EnumTipoDeUsuario TipoDeUsuario { get; set; }
    }
}
