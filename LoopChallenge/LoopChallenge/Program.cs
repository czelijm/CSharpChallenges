using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            AvergeChallengeMySolution();
            Console.WriteLine("Press enter to quit program");
            Console.Read();
        }

        public static void AvergeChallengeMySolution()
        {
            string enteredString="";
            int enteredInt = 0;
            int finalSum = 0;
            int numberOfStudents = 0;
            Console.WriteLine("Enter -1 to calculate the averge");

            while (true)
            {
                Console.WriteLine("Enter student's score");
                enteredString = Console.ReadLine();
                if (!(Int32.TryParse(enteredString, out enteredInt)))
                {
                    Console.WriteLine("Entered number wasn't a number");
                    continue;
                }
                if (enteredInt==(-1))
                {
                    try
                    {
                        double finalScore = (double)finalSum / (double)numberOfStudents;

                        Console.WriteLine("Averge score of {0} students is {1}",numberOfStudents,finalScore);

                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Divided by zero, you haven't enter any students score");
                       // throw;
                    }

                    break;
                }

                if (enteredInt < 0 || enteredInt > 20)
                {
                    Console.WriteLine("Entered number is too low of too high, enter number beetwen 0:20");
                    continue;
                }

                numberOfStudents++;
                finalSum += enteredInt;
                Console.WriteLine("Student's score entered");

            }//end of while
        }//end of method


        public static void AvergeChallenge()
        {
            string input = "0";
            int count = 0;
            int total = 0;
            int currentNumber = 0;

            while (input != "-1")
            {
                Console.WriteLine("Last number was {0}", currentNumber);
                Console.WriteLine("Please enter the next score");
                Console.WriteLine("Current amount of entries {0}", count);
                Console.WriteLine("Please enter -1 once you are ready to calculate the average");

                input = Console.ReadLine();
                if (input.Equals("-1"))
                {
                    Console.WriteLine("--------------------------------------------");
                    double average = (double)total / (double)count;
                    Console.WriteLine("The average score of your students is {0}", average);
                }
                if (int.TryParse(input, out currentNumber) && currentNumber > 0 && currentNumber < 21)
                {
                    total += currentNumber;
                }
                else
                {
                    if (!(input.Equals("-1")))
                    {
                        Console.WriteLine("Please enter a value between 1 and 20!");
                    }
                    continue;
                }

                count++;

            }

        }
    }
}
