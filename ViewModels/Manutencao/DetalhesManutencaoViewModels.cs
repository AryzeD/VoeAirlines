using VoeAirlines.Entities.Enums;

namespace VoeAirlines.ViewModels
{
    public class DetalhesManutencaoViewModel
    {
        public DetalhesManutencaoViewModel(int id, DateTime dataHora, TipoManutencao tipo, int aeronaveId, string? observacao=null)
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