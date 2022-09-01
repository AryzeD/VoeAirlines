using VoeAirlines.Entities.Enums;

namespace VoeAirlines.Entities
{
    public class Aeronave
    {
        public Aeronave(string fabricante, string modelo, string codigo, string jatinho, TipoAeronave tipo)
        {
            Fabricante = fabricante;
            Modelo = modelo;
            Codigo = codigo;
            Jatinho = jatinho;
            Tipo = tipo;
        }

        public int Id { get; set; }
        public string Fabricante { get; set; }
        public string Modelo { get; set; }
        public string Codigo { get; set; }
        public string Jatinho { get; set; }
        public TipoAeronave Tipo { get; set; }
        public ICollection<Manutencao> Manutencoes { get; set; }=null!;
        public ICollection<Voo>? Voos { get; set; }
    }
}