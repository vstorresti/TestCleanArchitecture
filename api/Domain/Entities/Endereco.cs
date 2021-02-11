namespace api.Domain.Entities
{
    public class Endereco : BaseModel
    {

        public string Cep { get; set; }

        public string Logradouro { get; set; }

        public int Numero { get; set; }

        public int Complemento { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }
    }
}
