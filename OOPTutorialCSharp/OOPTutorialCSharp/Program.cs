using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTutorialCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Introduce();
            Boxing();
            MembersTutorial();
            Console.Read();
        }//Finalazers here

        public static void Introduce()
        {
            //create object of class, instance of class
            Human marek = new Human("Marek","C","brown",25);
            marek.IntroduceMyself();

            Human michal = new Human("Mikkel","Cocol","gray");
            michal.IntroduceMyself();

            Human rick = new Human("Rick", "Sanchez");
            rick.IntroduceMyself();

            Human steve = new Human("Steve");
            steve.IntroduceMyself();


        }

        public static void Boxing()
        {
            Box box = new Box(5, 4, 3);
            box.DisplayInfo();
            box.FrontSurfaceInfo();
        }


        public static void MembersTutorial()
        {
            Members member = new Members("Tony", "Web Developer", 30, 1000);
            member.Introducing(true);
        }
    }
}
