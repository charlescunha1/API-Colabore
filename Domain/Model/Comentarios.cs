namespace ColaboreApi.Domain.Model;

public class Comentarios
{
    public Guid ComentarioId { get; set; }
    public string Conteudo { get; set; }
    public DateTime DataDeCriacao { get; set; }
    public Guid TarefaId { get; set; }
    public Tarefas Tarefa { get; set; }
    public Guid UsuarioId { get; set; }
    public Usuarios Usuario { get; set; }
}
