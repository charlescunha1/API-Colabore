using ColaboreApi.Domain.Enum;

namespace ColaboreApi.Domain.Model;

public class Tarefas
{
    public Guid TarefaId { get; set; }
    public string NomeDaTarefa { get; set; }
    public string Descricao { get; set; }
    public Status Status { get; set; }
    public Guid ProjetoId { get; set; }
    public Projetos Projeto { get; set; }
    public Guid UsuarioId { get; set; }
    public Usuarios UsuarioAtribuido { get; set; }
    public DateTime DataDeVencimento { get; set; }
    public ICollection<SubTarefas> SubTarefas { get; set; }
    public ICollection<Comentarios> Comentarios { get; set; }
}
