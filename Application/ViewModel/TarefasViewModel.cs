using ColaboreApi.Domain.Enum;

namespace ColaboreApi.Application.ViewModel;

public class TarefasViewModel
{
    public Guid TarefaId { get; set; }
    public string NomeDaTarefa { get; set; }
    public string Descricao { get; set; }
    public Guid ProjetoId { get; set; }
    public ProjetosViewModel Projeto { get; set; }
    public Status Status { get; set; }
    public Guid UsuarioId { get; set; }
    public UsuariosViewModel UsuarioAtribuido { get; set; }
    public DateTime DataDeVencimento { get; set; }
    public ICollection<SubTarefasViewModel> SubTarefas { get; set; }
    public ICollection<ComentariosViewModel> Comentarios { get; set; }
}
