using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTutorialCSharp
{
    class Human
    {
        //member variable
        //if no public, this is protected
        //public string firstName;
        //public string lastName="Smiths";
        private string  firstName;
        private string  lastName;
        private string  eyeColor;
        private int     age;


        //contructor
        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }

        public Human(string firstName, string lastName, string eyeColor)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
        }

        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Human(string firstName)
        {
            this.firstName = firstName;
        }

        public Human()
        {
            Console.WriteLine("Human Created");
        }

        //member method
        public void IntroduceMyself()
        {
            Console.Write("Hi I'm " + firstName);

            if ((lastName != null))
                Console.Write(" " + lastName + ".");

            if (age != 1 && age != 0)
                Console.Write(" I'm " + age + " years old.");
            if (age == 1 && age != 0)
                Console.Write(" I'm " + age + " year old.");

            if ((eyeColor != null))
                Console.Write(" My eye color is " + eyeColor + ".");

            Console.WriteLine();

            

        }
    }
}
