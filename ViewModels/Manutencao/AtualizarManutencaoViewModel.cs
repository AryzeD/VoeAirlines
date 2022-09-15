using VoeAirlines.Entities.Enums;

namespace VoeAirlines.ViewModels
{
    public class AtualizarManutencaoViewModel
    {
        public AtualizarManutencaoViewModel(int id, DateTime dataHora, string? observacao, TipoManutencao tipo, int aeronaveId)
        {
            Id = id;
            DataHora = dataHora;
            Observacao = observacao;
            Tipo = tipo;
            AeronaveId = aeronaveId;
        }

        public int Id { get; set; }
        public DateTime DataHora { get; set; }
        public string? Observacao { get; set; }
        public TipoManutencao Tipo { get; set; }
        public int AeronaveId { get; set; }
    }
}