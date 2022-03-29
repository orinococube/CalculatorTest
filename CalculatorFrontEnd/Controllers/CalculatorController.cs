using Calculator;
using CalculatorAPI;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorAPI.Controllers
{
    [ApiController]
    [Route("api")]
    public class CalculatorController : ControllerBase
    {
        [HttpPost("Add")]
        public string Add([FromBody] Values values)
        {
            var simpleCalculator = new SimpleCalculator();
            var result = simpleCalculator.Add(values.ValueA, values.ValueB);
            return result.ToString();
        }
    }

    public class Values {
        public int ValueA;
        public int ValueB;
    }

}
