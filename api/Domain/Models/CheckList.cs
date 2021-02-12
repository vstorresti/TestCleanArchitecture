using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models.Entities
{
    [Table("CheckLists")]
    public class CheckList : BaseModel
    {
        public bool EstaLimpo { get; set; }

        public bool EstaComTanqueCheio { get; set; }

        public bool EstaSemAmassados { get; set; }

        public bool EstaSemArranhoes { get; set; }
    }
}
