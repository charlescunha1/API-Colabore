using System.ComponentModel.DataAnnotations;

namespace ColaboreApi.Application.ViewModel;

public class UsuariosViewModel
{
    public Guid UsuarioId { get; set; }
    [MinLength(3), MaxLength(20)]
    public string Nome { get; set; }
    [EmailAddress]
    public string Email { get; set; }
    [MinLength(3), MaxLength(20)]
    public string Ocupacao { get; set; }
    public virtual ICollection<ProjetoUsuariosViewModel> ProjetoUsuarios { get; set; }
    public virtual ICollection<ComentariosViewModel> Comentarios { get; set; }
    public virtual ICollection<NotificacoesViewModel> Notificacaoes { get; set; }
}
