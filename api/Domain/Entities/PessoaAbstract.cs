using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Domain.Entities
{
    public abstract class PessoaAbstract : BaseModel
    {
        public string Nome { get; set; }

        public DateTime DiaDeNascimento { get; set; }

        [ForeignKey("Endereco")]
        public int EndereçoId { get; set; }
        public Endereco Endereco { get; set; }
    }
}
