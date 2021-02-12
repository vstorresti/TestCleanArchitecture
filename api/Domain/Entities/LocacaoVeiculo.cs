using System;

namespace api.Domain.Entities
{
    public class LocacaoVeiculo : BaseModel
    {
        public int TotalHoras { get; set; }

        public Veiculo Veiculo { get; set; }

        public Cliente Cliente { get; set; }

        public DateTime DataLocacao { get; set; }

        public DateTime DataDevolucao { get; set; }

        public bool EstaLocado { get; set; }

        public CheckList CheckList { get; set; }
    }
}
