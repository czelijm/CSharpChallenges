using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopTutorialCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            LoopTestOne();
            OddNumbers0ToMaxNumber(20);
            LoopTestTwo();
            LoopTestThree();
            */
            ContinueBreak();
            Console.WriteLine("Press enter to close the program");
            Console.Read();
        }

        public static void LoopTestOne()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            for (int i = 0; i < 50; i += 5)
            {
                Console.WriteLine(i);
            }
        }

        public static void OddNumbers0ToMaxNumberSlow(int maxNumber)
        {
            for (int i = 0; i < maxNumber; i++)
            {
                if (i % 2 == 1)
                    Console.WriteLine(i);
            }
        }

        public static void OddNumbers0ToMaxNumber(int maxNumber)
        {
            for (int i = 1; i < maxNumber; i+=2)
            {
                    Console.WriteLine(i);
            }
        }

        public static void LoopTestTwo()
        {
            //int counter = 0;
            int lenghtOFText = 0;
            string wholeText = "";
            do
            {
                Console.WriteLine("Enter the name of firend");
                string nameOfFriend = Console.ReadLine();
                int currentLenght = nameOfFriend.Length;
                lenghtOFText += currentLenght;
                wholeText += nameOfFriend;
            } while (lenghtOFText < 20);
            Console.WriteLine("Thanks that was enought"+ wholeText);

        }

        public static void LoopTestThree()
        {
            int counter = 0;
            string enteredText = "";
            while (enteredText.Equals(""))
            {
                Console.WriteLine("Press enter to increment  number of pepole in the bus, actually c = {0}", counter);

                enteredText = Console.ReadLine();
                counter++;

            }
            Console.WriteLine("Final number of pepole in the bus is {0}", counter);

        }

        public static void ContinueBreak()
        {
           
            for (int i = 0; i < 10; i++)
            {
                if (i == 3)
                {
                    Console.WriteLine("Hi I'm break");
                    break;
                }
                Console.WriteLine("Hi I'm loop with break {0}",i);
            }

            for (int i = 0; i < 10; i++)
            {
                if (i == 3)
                {
                    Console.WriteLine("Hi I'm continue");
                    continue;
                }
                Console.WriteLine("Hi I'm loop with continue {0}", i);
            }

        }

    }
}
