using System.Collections.Generic;

namespace api.Domain.Entities
{
    public class Marca : BaseModel
    {
        public string Name { get; set; }

        public ICollection<Modelo> Modelos { get; set; }
    }
}
