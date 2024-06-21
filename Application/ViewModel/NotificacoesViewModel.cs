using ColaboreApi.Domain.Enum;

namespace ColaboreApi.Application.ViewModel;

public class NotificacoesViewModel
{
    public Guid NotificacoesId { get; set; }
    public string Conteudo { get; set; }
    public ConfirmacaoDeLeitura ConfirmacaoDeLeitura { get; set; }
    public DateTime DataDeCriacao { get; set; }
    public Guid UsuarioId { get; set; }
    public UsuariosViewModel Usuario { get; set; }
}