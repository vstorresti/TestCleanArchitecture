namespace api.Domain.Entities
{
    public class CheckList : BaseModel
    {
        public bool EstaLimpo { get; set; }

        public bool EstaComTanqueCheio { get; set; }

        public bool EstaSemAmassados { get; set; }

        public bool EstaSemArranhoes { get; set; }
    }
}
