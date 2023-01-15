using System;

namespace lab4ex2supliment
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Scrie un program care afiseaza numerele de la 1 la N. Daca numarul este
            multiplu de 3, sa se afiseze Fizz, daca este multiplu de 5 sa se afiseze Buzz,
            daca e multiplu si de 3 si de 5 (ex: 15) sa se afiseze FizzBuzz, in restul
            cazurilor sa se afiseze numarul. */

            int N = int.Parse(Console.ReadLine());

            for(int i = 1; i <= N; i++)
            {
                int x = 0;
                if(i % 3 == 0 && i % 5 != 0)
                {
                    Console.Write("Fizz ");
                    x++;
                }
                if(i % 5 == 0 && i % 3 != 0)
                {
                    Console.Write("Buzz ");
                    x++;
                }
                if (i % 5 == 0 && i % 3 == 0)
                {
                    Console.Write("FizzBuzz ");
                    x++;
                }
                if(x == 0)
                {
                    Console.Write(i + " ");
                }

            }
        }

    }
}
