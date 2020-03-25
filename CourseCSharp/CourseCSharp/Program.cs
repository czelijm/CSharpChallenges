using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCSharp
{
    class Program
    {
        //constant fields
        const double PI = 3.14159;
        const string birthDate = "29.03.1993";

        static void Main(string[] args)
        {

            Console.WriteLine("My birthday is {0}\n",birthDate);

            int num1 = 5;
            int num2 = 7;
            Console.WriteLine("The sum of " + num1 + " and " + num2 + " is " + (num1+num2));
            Console.WriteLine(num1 + " and " + num2 + " is " + num1 + num2);

            double d1 = 3.5D;
            double d2 = 3.7D;
            double d3 = d1 + d2;
            Console.WriteLine("double sum "+ d3);
            Console.WriteLine("double devide " + (d1/d2));
            float f1 = 1.33F;


            //Casting cover double to int
            //cast double 2 int
            //explicit
            double myDouble = 12.333D;
            int myInt=(int)myDouble;
            Console.WriteLine(" ");
            Console.WriteLine(myInt+" "+myDouble);

            //implicit
            int nu = 123456789;
            long bigNu = nu;

            float myFloat = 12.4F;
            myDouble = myFloat;

            //typeConversion
            string myString = myDouble.ToString();
            Console.WriteLine(myString);

            bool condition1 = false;
            Console.WriteLine(condition1);

            //String
            Console.WriteLine(" ");
            string myName = "Marek";
            string myMessage = "our your base are belong to us";
            myMessage += " " + myName;
            //Console.WriteLine(myName+" "+myMessage);
            string capsMessage = myMessage.ToUpper();
            Console.WriteLine(myMessage);
            Console.WriteLine(capsMessage);
            Console.WriteLine(capsMessage.ToLower());
            //parse string 2 integer
            string stringNumber1 = "5";
            string stringNumber2 = "15";
            int num3 = Int32.Parse(stringNumber1);
            int num4 = Int32.Parse(stringNumber2);
            int result = num3 + num4;
            Console.WriteLine(result);

            //accersModifier static returnType methodName (argument1,argument2)
            WriteSomething();
            WriteSomethingSpecific("Hi I'm method with your message :)");

            //
            Console.WriteLine(Add(5,5));
            WriteSomethingSpecific(Add(11, 1).ToString());
            Console.WriteLine(Multiply(1, 2));

            
            GreetFriend("Anita");
            GreetFriend("Michał");
            GreetFriend("Adam");
            GreetFriend("Kamil");


            Console.WriteLine("Wpisz wiadomość:");
            string myInput = Console.ReadLine();
            Console.WriteLine(myInput);


            InteractiveAdd();
            Console.WriteLine(CalculateInteractiveAdd());
            
            Console.Read();
            Console.Read();
        }

        public static void WriteSomething() {


            Console.WriteLine("I'm called from method!!!");
           // Console.WriteLine("press enter to continue...");

           // Console.Read();
        }

        public static void WriteSomethingSpecific(string myMessage) {
            Console.WriteLine(myMessage);
            //Console.WriteLine("press enter to continue...");

            //
            //Console.Read();

        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static double Devide(double a, double b)
        {
            return a / b;
        }

        public static void GreetFriend(string friendName) {

            Console.WriteLine("Hi "+ friendName + ", my friend!");
           // Console.Read();
            return;
        }

        public static void InteractiveAdd() {

            Console.WriteLine("Pisz pierwszą liczę do dodawania");
            string a = Console.ReadLine();

            Console.WriteLine("Pisz drugą liczę do dodawania");
            string b = Console.ReadLine();


            Console.WriteLine( "wynik dodawania to " + ( Int32.Parse(a) + Int32.Parse(b) )  );

            return;

        }

        public static int CalculateInteractiveAdd() {

            Console.WriteLine("Pisz pierwszą całkowitą liczę do dodawania");
            string a = Console.ReadLine();

            Console.WriteLine("Pisz drugą całkowitą liczę do dodawania");
            string b = Console.ReadLine();

            return (Int32.Parse(a) + Int32.Parse(b));

        }


    }
}
