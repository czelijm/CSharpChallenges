using System;

namespace Anita1
{
    class Program
    {
        static void Main(string[] args)
        {
            anitaFun1();
        }

        static void anitaFun1() {
            const double dblPodatek = 1.23D;
            double dblWynagrodzenie;

            Console.WriteLine("Wrowadź sumę");

            Double.TryParse(Console.ReadLine(),out dblWynagrodzenie);
            dblWynagrodzenie -= dblPodatek;
            Console.WriteLine("Wynagrodzenie "+ dblWynagrodzenie);

            wyswietl("Anita", dblWynagrodzenie);

            Console.WriteLine("Wyplacaj " + wyplacaj(dblWynagrodzenie));

            Console.WriteLine("Premia 1 " + obliczPremia(dblWynagrodzenie));
            Console.WriteLine("Premia 2 " + obliczPremia(dblWynagrodzenie, 0.2, 10));

            int a = 10;
            Console.WriteLine("a = "+ a);

            int b = anitaFunc2(ref a,2,3);
            Console.WriteLine("b = " + b);


            return;
        }

        static void wyswietl(string msg, double dblWynagrodzenie) {
            Console.WriteLine(msg+" "+ dblWynagrodzenie);
        }

        static double wyplacaj(double wynagrodzenie) {
            const double podatek = 0.23D;
            return podatek * wynagrodzenie;
        }

        static double obliczPremia(double wynagrodzenie, double premia = 0.1D, double bonus=0.0D) {
              
            return wynagrodzenie+(wynagrodzenie*premia)+bonus;
        }

        static int anitaFunc2(ref int a, int b, int c ) {
            Console.WriteLine("A przed modyfikacją "+ a);
            a = a + b + c;
            Console.WriteLine("A po modyfikacji" + a);
            return a;
        }
    }
}
