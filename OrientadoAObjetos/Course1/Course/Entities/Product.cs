using System.Globalization;

namespace Course.Entities
{
    class Product
    ////class Product : IComparable<Product>     --implementação do IComparable *** colocar using System;
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Name + ", " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }

        ///--implementação do IComparable***
        ////public int CompareTo(Product other)
        ////{
        ////    //toupper converte para letra maiscula
        ////    return Name.ToUpper().CompareTo(other.Name.ToUpper());   //se quiser comparar o preço tenho que alterar para Price.CompareTo(other.Price);
        ////                                                             //  nesta forma a classe não está fechada para alteração ( viola o principio solid OPP)
        ////                                                             //tenho que abrir a classe sempre que o critério de comparação mudar
        ////}
    }
}
