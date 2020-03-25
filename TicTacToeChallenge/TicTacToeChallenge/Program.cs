using System;

namespace TicTacToeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayTicTacToe();

        }//end of main method

        public static void PlayTicTacToe()
        {
            Console.WriteLine("Gra w O i X\n");
            Console.WriteLine("Naciśnij 'q' aby wyjść");
            Console.WriteLine("Naciśnij 'r' aby zrestartować grę");
            Console.WriteLine("Naciśnij enter aby uruchomić grę");
            Console.Read();

            bool keepPlay = true;
            while (keepPlay)
            {
                GameBoard board = new GameBoard();
                keepPlay = board.Duel();
            }

            Console.WriteLine("Naciśnij enter aby kontynuować");
            Console.Read();
        }

    }
}
