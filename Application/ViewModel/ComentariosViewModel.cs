namespace ColaboreApi.Application.ViewModel;

public class ComentariosViewModel
{
    public Guid ComentarioId { get; set; }
    public string Conteudo { get; set; }
    public DateTime DataDeCriacao { get; set; }
    public Guid TarefaId { get; set; }
    public TarefasViewModel Tarefa { get; set; }
    public Guid UsuarioId { get; set; }
    public UsuariosViewModel Usuario { get; set; }
}
