﻿namespace Course
{
    internal class Triangulo
    {
        public double A;
        public double B;
        public double C;

        public double Area()
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            /*  double raiz = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
              return raiz;*/
        }
    }
}
