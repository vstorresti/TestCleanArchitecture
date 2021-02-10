namespace api.Domain.Entities
{
    public interface ICliente
    {
        string Cpf { get; set; }

        string Senha { get; set; }

        EnumTipoDeUsuario TipoDeUsuario { get; set; }
    }
}
