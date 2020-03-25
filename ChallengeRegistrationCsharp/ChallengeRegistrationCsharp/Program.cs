using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeRegistrationCsharp
{
    class Program
    {
        static string userNameRegistration;
        static string passwordRegistration;
        public bool isLogged = false;

        static void Main(string[] args)
        {
            UserCase();
        }


        public static void SignIn()
        {
            Console.WriteLine("Registration \n");

            Console.WriteLine("Enter the user name");
            userNameRegistration = Console.ReadLine();

            Console.WriteLine("Enter the password");
            passwordRegistration = Console.ReadLine();

        }

        public static void LogIn()
        {
            Console.WriteLine("Loggin in \n");

            if (VerifyUser())
            {
                Console.WriteLine("Welcome " + userNameRegistration);
            }
            else
            {
                Console.WriteLine("Bad user name of password");
            }

        }

        public static bool VerifyUser() {

            Console.WriteLine("Enter the user name");
            string userNameSignUp = Console.ReadLine();

            Console.WriteLine("Enter the password");
            string passwordSignUp = Console.ReadLine();

            return (userNameRegistration == userNameSignUp && passwordRegistration == passwordSignUp);

        }

        public static void UserCase()
        {
            SignIn();
            LogIn();
            Console.Read();
        }

    }
}
