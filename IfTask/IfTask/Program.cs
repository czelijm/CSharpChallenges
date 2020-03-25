using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfTask
{
    class Program
    {
        static int highscore = 0;
        static string highscorePlayer = "";

        static void Main(string[] args)
        {
            highscoreUpdate(1000, "Parsival");
            highscoreUpdate(500, "AnalDestroyer69");
            highscoreUpdate(1111, "Art3mis");

            Console.Read();
        }

        public static void highscoreUpdate(int score, string playerName)
        {
            if (score > highscore)
            {
                highscore = score;
                highscorePlayer = playerName;
                Console.WriteLine("New highscore is " + score);
                Console.WriteLine("New highscore holder is " + playerName);
            }
            else
            {
                Console.WriteLine("The old highscore of " + highscore + " could not be broken and is still held by " + highscorePlayer);
            }
        }
    }
}
