using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionMakingCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                        What2Wear();
                        Wheather();
                        NestedIfs();
                        ChallengeRegistration();

                        CanIGoToClub();
            */

            EnhancedIfStatement();
            Console.Read();

        }

        public static void What2Wear() {

            Console.WriteLine("Write the tempeture in Celcius degree");
            string temperatureString = Console.ReadLine();

            double temperature = Double.Parse(temperatureString);

            if (temperature < 10)
            {
                Console.WriteLine("Take the coat and more warm clothes");
            }

            if (temperature == 10)
            {
                Console.WriteLine("It's 10 C degree, medium temperature");
            }

            if (temperature > 10)
            {
                Console.WriteLine("Spring and summer clothes");
            }

        }

        public static void Wheather()
        {

            Console.WriteLine("Write the tempeture in Celcius degree");
            string temperatureString = Console.ReadLine();

            double temperature = 0D; //= Double.Parse(temperatureString);
            double temperatureTemp;

            if (Double.TryParse(temperatureString, out temperatureTemp))
            {
                temperature = temperatureTemp;
            }
            else
            {
                Console.WriteLine("Entered value isn't a number!");
                temperature = 0D;
                return;
            }

            if (temperature < 10)
            {
                Console.WriteLine("It's cold");
            }
            else if (temperature == 10)
            {
                Console.WriteLine("It's 10 C degree, medium temperature");
            }
            else if (temperature > 27)
            {
                Console.WriteLine("It's HOT!!!");
            }
            else
            {
                Console.WriteLine("Spring and summer");
            }

            return;

        }

        public static void NestedIfs() {

            bool isAdmin = false;
            bool isRegistered = true;
            string userName;// = "Kenobi";
            Console.WriteLine("Enter the user name");
            userName = Console.ReadLine();

            if (isRegistered && userName != "") {
                Console.WriteLine("Hi, registered user!");
                Console.WriteLine("Hello there");
                if (userName.ToUpper().Equals("KENOBI")) { //to upper to be invariant to lower and upper cases
                    Console.WriteLine("General " + userName);
                }
                else {
                    Console.WriteLine("Hello  there," + userName);
                }
                if (isAdmin || isRegistered) {
                    Console.WriteLine("You are logged in");
                }

            }

        }

        public static void ChallengeRegistration() {

            Console.WriteLine("Registration \n");

            Console.WriteLine("Enter the user name");
            string userNameRegistration = Console.ReadLine();

            Console.WriteLine("Enter the password");
            string passwordRegistration = Console.ReadLine();

            Console.WriteLine("Sign up \n");

            Console.WriteLine("Enter the user name");
            string userNameSignUp = Console.ReadLine();

            Console.WriteLine("Enter the password");
            string passwordSignUp = Console.ReadLine();

            if (userNameRegistration != userNameSignUp || passwordRegistration != passwordSignUp)
            {
                Console.WriteLine("Bad user name of password");
            }
            else
            {
                Console.WriteLine("Welcome " + userNameRegistration);
            }


        }

        public static void CanIGoToClubUnpolite() {
            Console.WriteLine("Enter your age");
            string ageString = Console.ReadLine();
            if (!(int.TryParse(ageString, out int age)))
            {
                Console.WriteLine("entered age wasn't a number");
                return;
            }

            //hard switch case way :D, it's easier to use ifs or c#7!!!
            const int legalAge = 15;
            int range = (age - 1) / (legalAge-1);
            switch (range)
            {
                case 0:
                    Console.WriteLine("You are "+ age + "! You are to young");
                    break;
                case 1: //1:28
                    Console.WriteLine("You are to young can go");
                    Console.WriteLine("Have Fun :D");
                    break;

                default:
                    Console.WriteLine("Seriously?");
                    Console.WriteLine("You are "+ age+ " ?");

                  //  Console.WriteLine("You are " + age);
                    break;
            }
        }

        public static void CanIGoToClub()
        {
            Console.WriteLine("Enter your age");
            string ageString = Console.ReadLine();
            if (!(int.TryParse(ageString, out int age)))
            {
                Console.WriteLine("entered age wasn't a number");
                return;
            }

            //hard switch case way :D, it's easier to use ifs or c#7!!!
            const int legalAge = 15;
            switch (age)
            {
                case var x when (age < legalAge && age > 0):
                    Console.WriteLine("You are " + age + "! You are to young");
                    break;
                case var x when (age >= legalAge):
                    Console.WriteLine("You are to young can go");
                    Console.WriteLine("Have Fun :D");
                    break;
                default:
                    Console.WriteLine("Seriously?");
                    Console.WriteLine("You are " + age + " ?");
                    break;
            }
        }

        public static void EnhancedIfStatement()
        {
            //[condition] ? [first expression] : [second expression]
            //condition has to be either true or false

            //The conditional Operator is right-associative
            //That means, that a ? b : c ? d : e
            // is evaluated as a ? b : (c ? d : e)

            //The conditional Operator cannot be overloaded.


            int temperature = -5; //Celcius
            string stateOfMeter = temperature < 0 ? "solid" : "liquid";
            /*
            if (temperature<0)
            {
                stateOfMeter = "solid";
            }
            else
            {
                stateOfMeter = "liquid";
            }
            */
            Console.WriteLine("State of meter is {0}", stateOfMeter);
            
            temperature = 20;
            stateOfMeter = temperature > 100 ? "gas" : (temperature < 0 ? "solid" : "liquid");
            Console.WriteLine("State of meter is {0}", stateOfMeter);

            temperature = 101;
            stateOfMeter = temperature > 100 ? "gas" : (temperature < 0 ? "solid" : "liquid");
            Console.WriteLine("State of meter is {0}", stateOfMeter);


        }
    }
}
