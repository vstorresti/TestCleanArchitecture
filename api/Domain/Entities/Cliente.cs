using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Domain.Entities
{
    [Table("Cliente")]
    public class Cliente : PessoaAbstract, ICliente
    {
        [Key]
        public Guid Id { get; set; }

        public string Cpf { get; set; }

        public string Senha { get; set; }

        public EnumTipoDeUsuario TipoDeUsuario { get; set; }
    }
}
