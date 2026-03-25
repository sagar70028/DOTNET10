using Microsoft.AspNetCore.Mvc;
using MyApi.Services;

namespace MyApi.Controllers
{
    [ApiController]
    [Route("api/caluclation")]
    public class CalculationController : ControllerBase
    {
        private readonly Calculation _calculation;

        public CalculationController(Calculation calculation)
        {
            _calculation = calculation;
        }


        [HttpPost()]
        public async Task<IActionResult> SendNotification([FromBody] CalculationRequest request)
        {
           int result= _calculation.Add(request.Num1, request.Num2);
            return Ok(result);
        }
    }

    //  DTO
    public class CalculationRequest
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
    }
}
