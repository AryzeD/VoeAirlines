using VoeAirlines.Entities.Enums;

namespace VoeAirlines.ViewModels
{
    public class AdicionarManutencaoViewModel
    {
        public AdicionarManutencaoViewModel(DateTime dataHora, string? observacao, TipoManutencao tipo, int aeronaveId)
        {
            DataHora = dataHora;
            Observacao = observacao;
            Tipo = tipo;
            AeronaveId = aeronaveId;
        }

        public DateTime DataHora { get; set; }
        public string? Observacao { get; set; }
        public TipoManutencao Tipo { get; set; }
        public int AeronaveId { get; set; }
    }
}