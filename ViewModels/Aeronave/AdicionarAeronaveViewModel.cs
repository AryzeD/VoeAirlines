using VoeAirlines.Entities.Enums;

namespace VoeAirlines.ViewModels
{
    public class AdicionarAeronaveViewModel
    {
        public AdicionarAeronaveViewModel(string fabricante, string modelo, string codigo, string jatinho, TipoAeronave
         tipo)
        {
            Fabricante = fabricante;
            Modelo = modelo;
            Codigo = codigo;
            Jatinho = jatinho;
            Tipo = tipo;
        }

        public string Fabricante { get; set; }
        public string Modelo { get; set; }
        public string Codigo { get; set; }
        public string Jatinho { get; set; }
        public TipoAeronave Tipo { get; set; }
    }
}