using VoeAirlines.Context;
using VoeAirlines.Entities;
using VoeAirlines.ViewModels;

namespace VoeAirlines.Services
{
    public class PilotoService
    {
        private readonly VoeAirlinesContext _context;

        public PilotoService(VoeAirlinesContext context)
        {
            _context = context;
        }

        public DetalhesPilotoViewModel AdicioncarPiloto(AdicionarPilotoViewModel dados)
        {
            var piloto = new Piloto(dados.Nome, dados.Matricula);

            _context.Add(piloto);
            _context.SaveChanges();

            return new DetalhesPilotoViewModel
            (
                piloto.Id,
                piloto.Nome,
                piloto.Matricula
            );
        }

        public IEnumerable<ListarPilotoViewModel> ListarPilotos()
        {
            return _context.Pilotos.Select(a=>new ListarPilotoViewModel(a.Id, a.Nome));
        }

        public DetalhesPilotoViewModel? ListarPilotoPeloId(int id)
        {
            var piloto = _context.Pilotos.Find(id);

            if (piloto != null)
            {
                return new DetalhesPilotoViewModel
                (
                    piloto.Id,
                    piloto.Nome,
                    piloto.Matricula
                );
            }

            return null;
        }
    }
}