using DOTNETAPI.MODELS;
using Microsoft.AspNetCore.Mvc;

namespace DOTNETAPI.Controllers;
[ApiController]
[Route("sum")]
public class SumController : ControllerBase
{
  private readonly ILogger<SumController> _logger;
  private readonly ISumService _sumService;
  public SumController(ILogger<SumController> logger, ISumService sumService){
    this._logger = logger;
    this._sumService = sumService;
  }

  [HttpGet]
  public IActionResult Sum([FromQuery] int a, [FromQuery] int b){
    _logger.LogInformation("SumController.Sum() called");

    try {
      var sum = this._sumService.sum(a,b);
      return Ok(sum);
    }catch{
      return BadRequest();
    }
  }
}