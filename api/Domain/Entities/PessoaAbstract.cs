using System;

namespace api.Domain.Entities
{
    public abstract class PessoaAbstract : BaseModel
    {
        public string Nome { get; set; }

        public DateTime DiaDeNascimento { get; set; }

        public Endereco Endereco { get; set; }
    }
}
