using VoeAirlines.Services;
using VoeAirlines.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace VoeAirlines.Controllers
{
    [Route("api/manutencoes")]
    [ApiController]

    public  class ManutencaoController : ControllerBase
    {
        private readonly ManutencaoService _manutencaoService;
        public ManutencaoController(ManutencaoService manutencaoService)
        {
        _manutencaoService = manutencaoService;
        }

        [HttpPost]
        public IActionResult AdicionarManutencao(AdicionarManutencaoViewModel dados)
        {
            var manutencao = _manutencaoService.AdicionarManutencao(dados);
            return Ok(manutencao);
        }

        [HttpGet]
        public IActionResult ListarManutencoes(int aeronaveId)
        {
            return Ok(_manutencaoService.DetalhesManutencoes(aeronaveId));
        }
    }    
}
