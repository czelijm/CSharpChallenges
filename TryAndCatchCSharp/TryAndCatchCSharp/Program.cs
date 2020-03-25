using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryAndCatchCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Please write a number");
            string userNumber = Console.ReadLine();

            try
            {
                int userNumberInt = int.Parse(userNumber);
            }
            catch (FormatException)//(Exception)
            {

                Console.WriteLine("Please enter a correct number /integer/ ");
                //throw;
            }
            catch (OverflowException)//(Exception)
            {

                Console.WriteLine("Too long nuber for int32");
                //throw;
            }
            catch (ArgumentNullException)//(Exception)
            {

                Console.WriteLine("Argument Null");
                //throw;
            }
            catch (DivideByZeroException)//(Exception)
            {

                Console.WriteLine("Argument Null");
                //throw;
            }
            catch (Exception)//(Exception)
            {

                Console.WriteLine("General exception");
                //throw;
            }
            finally
            {
                //when try and catch are done then do finally
                Console.WriteLine("Finally");

            }
            
            Console.WriteLine(Divide(10,0));

            Console.Read();
        }

        public static int Divide(int a, int b) {

            int c=0;

            try
            {
                c = (a / b);//return (a / b);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("divided by zero");
                //throw;
            }

            return c;

          
        }
        

    }
}
