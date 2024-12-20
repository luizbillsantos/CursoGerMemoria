using System.Diagnostics;

namespace UsuarioLib;

public class Usuario
{

    public Usuario(string nome, string email, List<string> telefone)
    {
        Nome = nome;
        Email = email;
        Telefones = telefone;
        ChavesDeAcesso = new List<Guid>(new Guid[10]);
        Stopwatch stopwatch = new();
        stopwatch.Start();
        for (int i = 0; i < 1000000; i++)
        {
            ChavesDeAcesso.Insert(1, Guid.NewGuid());
        }
        stopwatch.Stop();
        Console.WriteLine($"Tempo de execução: {stopwatch.Elapsed.TotalMilliseconds} ms");

        ChavesDeAcessoLinkedList = new LinkedList<Guid>();
        Stopwatch stopwatchLinkedList = new();
        ChavesDeAcessoLinkedList.AddFirst(Guid.NewGuid());
        stopwatchLinkedList.Start();
        for (int i = 0; i < 1000000; i++)
        {
            ChavesDeAcessoLinkedList.AddAfter(ChavesDeAcessoLinkedList.First,Guid.NewGuid());
        }
        stopwatchLinkedList.Stop();
        Console.WriteLine($"Tempo de execução linkedlist: {stopwatchLinkedList.Elapsed.TotalMilliseconds} ms");

    }

    public int Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public List<string> Telefones { get; set; }
    public List<Guid> ChavesDeAcesso { get; set; }
    public LinkedList<Guid> ChavesDeAcessoLinkedList { get; set; }

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
