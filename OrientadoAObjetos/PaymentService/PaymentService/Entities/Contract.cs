namespace PaymentService.Entities
{
    class Contract
    {
        public int Number { get; set; }

        public DateTime Date { get; set; }

        public double TotalValue { get; set; }

        public Installment Installment { get; set; }
    }
}
