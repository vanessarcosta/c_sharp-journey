namespace PaymentService.Services
{
    class PayPalPaymentRate
    {
        public double Rate(double amount)
        {
            return amount * 0.02;
        }

        public double Fees(double amount)
        {
            return amount * 0.01;
        }
    }
}
