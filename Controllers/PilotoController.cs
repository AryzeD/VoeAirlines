using Microsoft.AspNetCore.Mvc;
using VoeAirlines.Services;
using VoeAirlines.ViewModels;

[Route("api/pilotos")]
[ApiController]
public class PilotoController : ControllerBase
{
    private readonly PilotoService _pilotoService;

    public PilotoController(PilotoService pilotoService)
    {
        _pilotoService = pilotoService;
    }
    [HttpPost]
    public IActionResult AdicionarPiloto(AdicionarPilotoViewModel dados)
    {
        var piloto = _pilotoService.AdicioncarPiloto(dados);
        return Ok(piloto);
    }
    [HttpGet]
    public IActionResult ListarPilotos() 
    {
        return Ok(_pilotoService.ListarPilotos());
    }
}