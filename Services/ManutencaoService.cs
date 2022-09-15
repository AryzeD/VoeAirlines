using VoeAirlines.Context;
using VoeAirlines.Entities;
using VoeAirlines.ViewModels;

namespace VoeAirlines.Services
{
    public class ManutencaoService
    {
        private readonly VoeAirlinesContext _context;

        public ManutencaoService(VoeAirlinesContext context)
        {
            _context = context;
        }

        public DetalhesManutencaoViewModel AdicionarManutencao(AdicionarManutencaoViewModel dados)
        {
            var manutencao = new Manutencao(dados.DataHora, dados.Tipo, dados.AeronaveId, dados.Observacao);

            _context.Add(manutencao);
            _context.SaveChanges();
            
            return new DetalhesManutencaoViewModel
            (
                manutencao.Id,
                manutencao.DataHora,
                manutencao.Tipo,
                manutencao.AeronaveId,
                manutencao.Observacao
            );
        }

        public IEnumerable<DetalhesManutencaoViewModel> DetalhesManutencoes(int aeronaveId)
        {
            return _context.Manutencoes.Where(m=>m.AeronaveId == aeronaveId)
                                        .Select(m=> new DetalhesManutencaoViewModel
                                        (
                                            m.Id,
                                            m.DataHora,
                                            m.Tipo,
                                            m.AeronaveId,
                                            m.Observacao
                                        )); 
        }
    }
}