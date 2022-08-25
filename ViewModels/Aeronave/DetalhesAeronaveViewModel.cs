namespace VoeAirlines.ViewModels 
{
    public class DetalhesAeronaveViewModel
    {
        public DetalhesAeronaveViewModel(int id, string fabricante, string modelo, string codigo, string jatinho)
        {
            Id = id;
            Fabricante = fabricante;
            Modelo = modelo;
            Codigo = codigo;
            Jatinho = jatinho;
        }

        public int Id { get; set; }
        public string Fabricante { get; set; }
        public string Modelo { get; set; }
        public string Codigo { get; set; }
        public string Jatinho { get; set; }
    }
}