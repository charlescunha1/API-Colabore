using ColaboreApi.Domain.Enum;
using System.Data;

namespace ColaboreApi.Application.ViewModel;

public class ProjetoUsuariosViewModel
{
    public Guid UsuarioId { get; set; }
    public UsuariosViewModel Usuario { get; set; }
    public Guid ProjetoId { get; set; }
    public ProjetoUsuariosViewModel Projeto { get; set; }
    public Role Role { get; set; }
}