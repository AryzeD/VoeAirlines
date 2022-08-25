namespace VoeAirlines.Entities
{
    public class Cancelamento
    {
        public Cancelamento(int id, string motivo, int vooId)
        {
            Id = id;
            Motivo = motivo;
            VooId = vooId;
        }

        public int Id { get; set; }
        public string Motivo { get; set; }
        public DateTime DataHoraNotificacao { get; set; }
        public int VooId { get; set; }
        
        public Voo? Voo { get; set; }
    }
}