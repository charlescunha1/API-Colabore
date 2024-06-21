using ColaboreApi.Domain.Enum;

namespace ColaboreApi.Domain.Model;

public class ProjetosUsuarios
{
    public Guid UsuarioId { get; set; }
    public Usuarios Usuario { get; set; }
    public Guid ProjetoId { get; set; }
    public ProjetosUsuarios Projeto { get; set; }
    public Role Role { get; set; }
}
