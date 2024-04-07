using DevFreela.Payments.API.Models;

namespace DevFreela.Payments.API.Services
{
    public class PaymentService: IPaymentService
    {
        

        public Task<bool> Process(PaymentInfoInputModel inputModel)
        {
            return Task.FromResult(true);
        }
    }
}
