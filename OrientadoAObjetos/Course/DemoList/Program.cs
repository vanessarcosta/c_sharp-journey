using System;
using System.Collections;
using System.Collections.Generic;

namespace DemoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            //o add adiciona ao final da lista
            list.Add("Maria"); 
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Add("João");
            list.Add("Clara");
            list.Add("Lucas");
            list.Add("Suzana");

            //o insert defini a posição
            list.Insert(2, "Marco");
            list.Insert(1, "Pedro");
            

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            //list.Count tamanho da lista
            Console.WriteLine("List count: " + list.Count);

            ///Encontrar primeiro ou último elementos da lista que satisfaça um predicado,ex primeiro nome que começa com a letra A
            //primeiro usando a função Test
            //string s1 = list.Find(Test);

            //trocando a função Test por uma expressão lambida
            string s1 = list.Find(x => x[0] == 'A');

            Console.WriteLine("First 'A': " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');

            Console.WriteLine("Last 'A': " + s2);


            ///Encontrar primeira ou última posição de elemento da lista que satisfaça umn predicado:
            
            int posicao1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + posicao1);

            int posicao2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position 'A': " + posicao2);

            ///Filtrar a lista com base em um predicado (criar uma nova lista contendo os elementos que satisfaçam o predicado)
            List<string> list2 =  list.FindAll(x => x.Length == 5);
            Console.WriteLine("------------------------------");
            foreach(string obj in list2)
            {
                Console.WriteLine(obj);
            }

            ///Remover elementos da lista:
            // o objeto remove se não encontar o objeto informado ele não faz nada ex 'Alexx'

            list.Remove("Alex");
            Console.WriteLine("------------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("------------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            //remover um elemento pela posição dele
            list.RemoveAt(1);
            Console.WriteLine("------------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            //remover elementos de uma faixa (a partir de uma posição, remove tantos elementos)
            list.RemoveRange(2,2);
            Console.WriteLine("------------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
        }
        //private static bool Test(string s)
        //{
        //    return s[0] == 'A';
        //}
    }
}
