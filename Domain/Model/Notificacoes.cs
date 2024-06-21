using ColaboreApi.Domain.Enum;

namespace ColaboreApi.Domain.Model;

public class Notificacoes
{
    public Guid NotificacoesId { get; set; }
    public string Conteudo { get; set; }
    public ConfirmacaoDeLeitura ConfirmacaoDeLeitura { get; set; }
    public DateTime DataDeCriacao { get; set; }
    public Guid UsuarioId { get; set; }
    public Usuarios Usuario { get; set; }
}
