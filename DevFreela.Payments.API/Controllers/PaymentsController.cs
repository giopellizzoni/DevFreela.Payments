using DevFreela.Payments.API.Models;
using DevFreela.Payments.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.Payments.API.Controllers
{
    [Route("api/payments")]
    public class PaymentsController(IPaymentService paymentService) : ControllerBase
    {
        
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] PaymentInfoInputModel paymentInfoInputModel)
        {
            var result = await paymentService.Process(paymentInfoInputModel);
            if (!result)
            {
                return BadRequest();
            }

            return NoContent();
        }

    }
}
