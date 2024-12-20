using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using UsuarioLib;

Usuario usuario = 
    new Usuario(
        "Daniel", 
        "daniel@email.com",
        new List<string>() {"12345678"});

Usuario usuario2 =
    new Usuario(
        "Luis",
        "luis@email.com",
        new List<string>() { "87654321" });


//12345678
usuario.ExibeTelefones();

//efetuar a padronização
usuario.PadronizaTelefones();

//912345678
usuario.ExibeTelefones();

Stopwatch stopwatch = new();
stopwatch.Start();

for (int i = 0; i < 1000000000; i++)
{
    ICoordenada coordenada = new Coordenada(123.456, -123.456);
    Coordenada coordenada2 = (Coordenada)coordenada;
}

stopwatch.Stop();
Console.WriteLine($"Tempo de execução: {stopwatch.Elapsed.TotalMilliseconds} ms");


//FormularioDto dto = new FormularioDto("Daniel", "99999999999", "Cargo") { Idade = 30};
//Console.WriteLine($" Valor do nome: {dto.Nome}");


UsuarioDto dto1 = new UsuarioDto();
dto1.Nome = "Daniel";
dto1.Email = "daniel@email.com";
dto1.Telefones = new List<string>();

UsuarioDto dto2 = new UsuarioDto();
dto2.Nome = "Daniel";
dto2.Email = "daniel@email.com";
dto2.Telefones = new List<string>();

Console.WriteLine(dto1 == dto2);

Stopwatch sw = new Stopwatch();

sw.Start();

for (int i = 0; i < 1000000000; i++)
{
    FormularioDtoClass dto = new FormularioDtoClass("Daniel", "11111111111", "Programador", 100);
    dto.GetHashCode();
}

sw.Stop();

Console.WriteLine($"Tempo class: {sw.Elapsed.TotalMilliseconds}");


sw.Restart();

for (int i = 0; i < 1000000000; i++)
{
    FormularioDtoRecord dto = new FormularioDtoRecord("Daniel", "11111111111", "Programador", 100);
    dto.GetHashCode();
}

sw.Stop();

Console.WriteLine($"Tempo record: {sw.Elapsed.TotalMilliseconds}");

sw.Restart();

for (int i = 0; i < 1000000000; i++)
{
    FormularioDtoStruct dto = new FormularioDtoStruct("Daniel", "11111111111", "Programador", 100);
    dto.GetHashCode();
}

sw.Stop();

Console.WriteLine($"Tempo struct: {sw.Elapsed.TotalMilliseconds}");

sw.Restart();

for (int i = 0; i < 1000000000; i++)
{
    FormularioDtoRecordStruct dto = new FormularioDtoRecordStruct("Daniel", "11111111111", "Programador", 100);
    dto.GetHashCode();
}

sw.Stop();

Console.WriteLine($"Tempo record struct: {sw.Elapsed.TotalMilliseconds}");