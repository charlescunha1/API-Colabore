namespace ColaboreApi.Domain.Model;

public class Projetos
{
    public Guid ProjetoId { get; set; }
    public string NomeDoProjeto { get; set; }
    public string Descricao { get; set; }
    public DateTime InicioDoProjeto { get; set; }
    public DateTime FimDoProjeto { get; set; }
    public ICollection<ProjetosUsuarios> ProjetosUsuarios { get; set; }
    public ICollection<Tarefas> Tarefas { get; set; }
}
