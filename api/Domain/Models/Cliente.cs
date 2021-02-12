using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models.Entities
{
    [Table("Clientes")]
    public class Cliente : PessoaAbstract
    {

        public string Cpf { get; set; }

        public string Senha { get; set; }

        public EnumTipoDeUsuario TipoDeUsuario { get; set; }
    }
}
