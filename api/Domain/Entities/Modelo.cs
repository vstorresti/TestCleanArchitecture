namespace api.Domain.Entities
{
    public class Modelo : BaseModel
    {
        public string Name { get; set; }

        public Marca Marca { get; set; }
    }
}
