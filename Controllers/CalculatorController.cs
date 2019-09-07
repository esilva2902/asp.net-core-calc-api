using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

using calcApi.Services;

namespace calcApi.Controllers 
{
  [Route("api")]
  [ApiController]
  public class CalculatorController : ControllerBase 
  {
    private readonly CalculatorService calculatorService;
  
    public CalculatorController(CalculatorService calcService) 
    {
      this.calculatorService = calcService;
    }

    [HttpGet("add")]
    public ActionResult<int> add([FromBody] Numbers n) {
      return this.calculatorService.add(n.a, n.b);
    }

    [HttpGet("subtract")]
    public ActionResult<int> subtract([FromBody] Numbers n) {
      return this.calculatorService.subtract(n.a, n.b);
    }

    [HttpGet("multiply")]
    public ActionResult<int> multiply([FromBody] Numbers n) {
      return this.calculatorService.multiply(n.a, n.b);
    }

    [HttpGet("divide")]
    public ActionResult<int> divide([FromBody] Numbers n) {
      return this.calculatorService.divide(n.a, n.b);
    }

    public class Numbers
    {
      public int a {get; set;}

      public int b {get; set;}
    }
  }
}