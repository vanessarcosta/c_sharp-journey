namespace Course7.Entities
{
    class CarrRental
    {
        public DateTime Start { get; set; }

        public DateTime Finish { get; set; }
        
        public Vehicle Vehicle { get; set; }

        public Invoice Invoice { get; set; }

        public CarrRental(DateTime start, DateTime finish, Vehicle vehicle)
        {
            Start = start;
            Finish = finish;
            Vehicle = vehicle;
            Invoice = null;
        }
    }
}
