using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;

namespace api.Domain.Entities
{
    [Table("Operador")]
    public class Operador : PessoaAbstract, IOperador
    {
        [Key]
        public Guid Id { get; set; }

        public string Matricula { get; set; }

        public string Senha { get; set; }

        public EnumTipoDeUsuario TipoDeUsuario { get; set; }
    }
}
