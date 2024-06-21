using ColaboreApi.Domain.Enum;

namespace ColaboreApi.Domain.Model;

public class SubTarefas
{
    public Guid SubTarefaId { get; set; }
    public string NomeSubTarefa { get; set; }
    public string Descricao { get; set; }
    public Status Status { get; set; }
    public Guid UsuarioAtribuidoId { get; set; }
    public Usuarios Usuario { get; set; }
    public DateTime DataDeVencimento { get; set; }
    public Guid TarefaId { get; set; }
    public Tarefas Tarefa { get; set; }
}
