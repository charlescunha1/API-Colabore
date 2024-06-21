using System.ComponentModel.DataAnnotations;

namespace ColaboreApi.Application.ViewModel;

public class ProjetosViewModel
{
    public Guid ProjetoId { get; set; }
    [MinLength(4), MaxLength(20)]
    public string NomeDoProjeto { get; set; }
    [MaxLength(20)]
    public string Descricao { get; set; }
    public DateTime InicioDoProjeto { get; set; }
    public DateTime FimDoProjeto { get; set; }
    public ICollection<ProjetoUsuariosViewModel> ProjetoUsuarios { get; set; }
    public ICollection<TarefasViewModel> Tarefas { get; set; }
}
