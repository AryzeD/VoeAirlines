namespace VoeAirlines.ViewModels
{
    public class DetalhesCancelamentoViewModel
    {
        public DetalhesCancelamentoViewModel(int vooId, int id, string motivo, DateTime dataHoraNotificacao)
        {
            VooId = vooId;
            Id = id;
            Motivo = motivo;
            DataHoraNotificacao = dataHoraNotificacao;
        }

        public int VooId { get; set; }
        public int Id { get; set; }
        public string Motivo { get; set; }
        public DateTime DataHoraNotificacao { get; set; }
    }
}