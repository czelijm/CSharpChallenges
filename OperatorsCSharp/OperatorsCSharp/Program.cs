using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 3;
            int num3;

            num3 = -num1;
            Console.WriteLine("num3 is {0}", num3);

            bool isSunny = true;
            Console.WriteLine("Is sunny? {0}", !isSunny);

            int num = 0;

            //Increment operator
            num++;
            Console.WriteLine("num value {0}", num);
            Console.WriteLine("num value {0}", num++);
            Console.WriteLine("num value {0}", num);
            Console.WriteLine("num value {0}", ++num);

            //Decrement operator
            Console.WriteLine("num value {0}", num);
            Console.WriteLine("num value {0}", num--);
            Console.WriteLine("num value {0}", num);
            Console.WriteLine("num value {0}", --num);


            //modulo
            int result = num1 % num2;
            Console.WriteLine("result of num1 mod num2 is {0}", result);

            //relational and type operators
            bool isLower = num1 < num2;
            Console.WriteLine("result of num1 < num2 is {0}", isLower);

            bool isEqual = num1 == num2;
            Console.WriteLine("result of num1 == num2 is {0}", isEqual);
            isEqual = num1 != num2;
            Console.WriteLine("result of num1 != num2 is {0}", isEqual);

            bool isLowerAndSunny = isLower && isSunny;
            Console.WriteLine("result of isLower && isSunny is {0}", isLowerAndSunny);

            bool isLowerOrSunny = isLower || isSunny;
            Console.WriteLine("result of isLower || isSunny is {0}", isLowerOrSunny);


            Console.ReadKey();
            //unary operators

        }
    }
}
