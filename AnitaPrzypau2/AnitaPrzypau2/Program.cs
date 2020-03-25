using System;

namespace AnitaPrzypau2
{
    class Program
    {
        static void Main(string[] args)
        {

            int lenghtOfNumbers = 3;
            int[] a = {0,0,0};

            for (int i = 0; i < lenghtOfNumbers; i++)
            {
                Console.WriteLine("Podaj  liczbę " + i);
                a[i] = Int32.Parse(Console.ReadLine());
            }

            for (int i = 0; i < lenghtOfNumbers; i++)
            {
                Console.WriteLine(a[i]);
            }

        }
    }
}