namespace PaymentService.Services
{
    interface IPaymentRate
    {
        double Rate(double amount);

        double Fees(double amount);
    }
}
