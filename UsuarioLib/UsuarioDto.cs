namespace UsuarioLib;

public class UsuarioDto
{
    public string Nome { get; set; } = string.Empty;
    public string Email { get; set; } = "";
    public List<string> Telefones { get; set; } = new List<string>();
}