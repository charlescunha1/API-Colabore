using ColaboreApi.Domain.Enum;

namespace ColaboreApi.Application.ViewModel;

public class SubTarefasViewModel
{
    public Guid SubTarefaId { get; set; }
    public string NomeSubTarefa { get; set; }
    public string Descricao { get; set; }
    public Status Status { get; set; }
    public Guid UsuarioAtribuidoId { get; set; }
    public UsuariosViewModel Usuario { get; set; }
    public DateTime DataDeVencimento { get; set; }
    public Guid TarefaId { get; set; }
    public TarefasViewModel Tarefa { get; set; }

}