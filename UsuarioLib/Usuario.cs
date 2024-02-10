using System.Diagnostics;

namespace UsuarioLib;

public class Usuario
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public string? Email { get; set; }
    public List<string> Telefones { get; set; } = new List<string>();
    public IList<Guid> ChaveDeAcesso { get; set; } = new List<Guid>();

    public Usuario(string nome, string email, List<string> telefone)
    {
        Nome = nome;
        Email = email;
        Telefones = telefone;

        Stopwatch sw = new Stopwatch();
        sw.Start();
        for (int i = 0; i < 10; i++)
        {
            ChaveDeAcesso.Insert(i, Guid.NewGuid());
        }
        sw.Stop();
        System.Console.WriteLine($"Elapse time {sw.Elapsed.TotalMilliseconds}");
    }

    public void PadronizaTelefones()
    {
        Telefones = Telefones.Select(telefone =>
            telefone.Length == 8 ?
            telefone = "9" + telefone :
            telefone
        ).ToList();
    }

    public void ExibeTelefones()
    {
        Telefones.ForEach(telefone => Console.WriteLine(telefone));
    }
}
