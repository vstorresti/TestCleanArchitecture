
using System.ComponentModel.DataAnnotations;

namespace api.Domain.Entities
{
    public class BaseModel
    {
        [Key]
        public int Id { get; set; }

    }
}
