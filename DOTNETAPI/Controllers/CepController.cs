using Microsoft.AspNetCore.Mvc;

namespace DOTNETAPI.Controllers;

[ApiController]
[Route("cep")]
public class CepController: ControllerBase {
  private readonly ILogger<CepController> _logger;
  private readonly ICepService _cepService;

  public CepController(ILogger<CepController> logger, ICepService cepService)
  {
    _logger = logger;
    _cepService = cepService;
  }
  
  [HttpGet("{cep}")]
  public async Task<IActionResult> Get([FromRoute] string cep){
    var result = await _cepService.GetCep(cep);
    return Ok(result);
  }
}