namespace ColaboreApi.Domain.Model;

public class Usuarios
{
    public Guid UsuarioId { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Ocupacao { get; set; }
    public virtual ICollection<ProjetosUsuarios> ProjetosUsuarios { get; set; }
    public virtual ICollection<Comentarios> Comentarios { get; set; }
    public virtual ICollection<Notificacoes> Notificacaoes { get; set; }
}
