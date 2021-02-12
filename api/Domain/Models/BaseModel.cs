
using System.ComponentModel.DataAnnotations;

namespace api.Models.Entities
{
    public class BaseModel
    {
        [Key]
        public int Id { get; set; }

    }
}
