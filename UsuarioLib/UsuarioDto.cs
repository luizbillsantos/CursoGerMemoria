namespace UsuarioLib;

public record UsuarioDto
{
    public string Nome { get; set; }
    public string Email { get; set; }
    public List<string> Telefones { get; set; }

    public virtual bool Equals(UsuarioDto? other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return Nome == other.Nome && Email == other.Email && Telefones.SequenceEqual(other.Telefones);
    }
}