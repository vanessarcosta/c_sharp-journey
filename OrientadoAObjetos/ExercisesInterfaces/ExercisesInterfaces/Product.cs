namespace ExercisesInterfaces
{
    public abstract class Product
    {
        public string Description { get; set; }

        public int Id { get; set; }

        public double Price { get; set; }

        public double Tax { get; set; }

        public override string ToString()
        {
            return $"Description:{Description}, Id: {Id}, Price: {Price}, Tax: {Tax}";
        }
    }
}
