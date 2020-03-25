using System;
using System.Collections.Generic;

namespace AnitaBezPrzypau3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            zad4("Lexus",5,0.1D);
            zad5();
            zad6();
            zad7();
        }

        public static void zad4(string markaPojazdu, double kilometery=0.0D, double wyemitowaneCO2=0.0D) {
            if (kilometery <= 0)
            {
                Console.WriteLine("Twój pojazd " + markaPojazdu + " nie porusza się.");
                return;
            }
            Console.WriteLine("Twój pojazd "+markaPojazdu+" emituje CO w ilości "+wyemitowaneCO2/kilometery +" g/km");

            if (wyemitowaneCO2 <= 1.0D && wyemitowaneCO2 >= 0.0)
            {
                Console.WriteLine("Twój samochód spełnia normę EURO2");
            }

            return;
        }

        public static void zad5()
        {
            bool continueTask = true;

            string numberString = "";
            int number;

            IList<int> intList = new List<int>();



            while (continueTask)
            {
                Console.WriteLine("Aby wyjść wpisz q");
                Console.WriteLine("Wpisz liczę całkowitą");

                numberString = Console.ReadLine();

                if (numberString.Equals("q"))
                {
                    //Console.WriteLine("");
                    break;
                }

                if (!Int32.TryParse(numberString, out number)) {
                    //Console.WriteLine("");
                    continue;
                }

                bool isUnique = true;
                for (int i = 0; i < intList.Count; i++) {
                    if (intList[i] == number) {
                        isUnique = false;
                        Console.WriteLine("Liczba istnieje");
                        break;
                    }
                }

                if (isUnique)
                {
                    intList.Add(number);
                    Console.WriteLine("Liczba "+number+" dodana");
                }

                //Console.Clear();
            }
        }

        public static void zad6() {
            bool continueTask = true;

            string numberString = "";
            int number;
            int numberPlus = 0;
            int numberMinus = 0;

            while (continueTask)
            {
                Console.WriteLine("Aby wyjść wpisz q");
                Console.WriteLine("Wpisz liczę całkowitą");

                numberString = Console.ReadLine();

                if (numberString.Equals("q"))
                {
                    //Console.WriteLine("");
                    break;
                }

                if (!Int32.TryParse(numberString, out number))
                {
                    //Console.WriteLine("");
                    continue;
                }

                if (number > 0)
                {
                    numberPlus += number;
                }
                else
                {
                    numberMinus += number;
                }

                Console.WriteLine("Wpisana liczba " + number);
                Console.WriteLine("Suma liczb dodatnich" + numberPlus);
                Console.WriteLine("Suma liczb ujemnych" + numberMinus);

            }
        }

        public static void zad7() {

            Wolumin ksiazka1 = new Wolumin
            {
                Autor = "Queen Cara",
                Tytul = "Porwana przez jokera",
                DataWypozyczenia = "2019-10-24_17:17"
            };

            Console.WriteLine(ksiazka1.Autor+" "+ksiazka1.Tytul + " " + ksiazka1.DataWypozyczenia);

            Wolumin ksiazka2 = new Wolumin();
            ksiazka2.Autor = "Darren Shan";
            ksiazka2.Tytul = "Asysten wampira";
            ksiazka2.DataWypozyczenia = "2019-10-24_18:18";

            Console.WriteLine(ksiazka2.Autor + " " + ksiazka2.Tytul + " " + ksiazka2.DataWypozyczenia);
        }

    }

    public class Wolumin {

        public string Tytul { get; set; }
        public string Autor { get; set; }
        public string DataWypozyczenia { get; set; }

    }


}
