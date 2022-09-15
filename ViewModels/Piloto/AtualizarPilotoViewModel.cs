namespace VoeAirlines.ViewModels
{
    public class AtualizarPilotoViewModel
    {
        public AtualizarPilotoViewModel(string nome, string matricula, int id)
        {
            Id = id;
            Nome = nome;
            Matricula = matricula;
        }
        public int Id { get; set; }

        public string Nome { get; set; }
        public string Matricula { get; set; }
    }
}