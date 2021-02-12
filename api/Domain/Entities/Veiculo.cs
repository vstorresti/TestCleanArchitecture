using System;

namespace api.Domain.Entities
{
    public class Veiculo : BaseModel
    {
        public string Placa { get; set; }

        public DateTime Ano { get; set; }

        public double ValorHora { get; set; }

        public int LimitePortaMalas { get; set; }

        public EnumTipoDeCombustivel TipoDeCombustivel { get; set; }

        public EnumTipoDeVeiculo TipoDeVeiculo { get; set; }

        public Modelo Modelo { get; set; }

        public int Kilometragem { get; set; }
    }
}
