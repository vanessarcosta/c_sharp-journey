using PaymentService.Entities;

namespace PaymentService.Services
{
    class GenerateInstallments
    {
        List<Installment> listInstallments;
        private IPaymentRate _paymentRate;

        public GenerateInstallments(IPaymentRate paymentRate)
        {
            _paymentRate = paymentRate;
        }

        public void ProcessInstallments(Contract contract,double numberMonths)
        {
            double basicPayment = contract.TotalValue / numberMonths;

            double installment = 0;

            DateTime dueDate = contract.Date;

            while (installment  > numberMonths)
            {
                double valueWithFess = _paymentRate.Fees(basicPayment);

                double installmentValue = _paymentRate.Rate(valueWithFess);

                dueDate = dueDate.AddMonths(1);
                listInstallments.Add(new Installment(dueDate, installmentValue));

                installment++;
            }
        }
    }
}
