using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models.Entities
{
    [Table("Operadores")]
    public class Operador : PessoaAbstract
    {
        public string Matricula { get; set; }

        public string Senha { get; set; }

        public EnumTipoDeUsuario TipoDeUsuario { get; set; }
    }
}
