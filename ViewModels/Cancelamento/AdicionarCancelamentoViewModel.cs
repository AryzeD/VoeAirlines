namespace VoeAirlines.ViewModels
{
    public class AdicionarCancelamentoViewModel
    {
        public AdicionarCancelamentoViewModel(int vooId, string motivo, DateTime dataHoraNotificacao)
        {
            VooId = vooId;
            Motivo = motivo;
            DataHoraNotificacao = dataHoraNotificacao;
        }

        public int VooId { get; set; }
        public string Motivo { get; set; }
        public DateTime DataHoraNotificacao { get; set; }
    }
}