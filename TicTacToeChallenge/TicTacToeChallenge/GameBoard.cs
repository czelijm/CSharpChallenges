using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeChallenge
{
    class GameBoard
    {
        private int boardXSize;
        private int boardYSize;

        //private string[,] boardBoxes;
        private string[] boardBoxes;
        private string[] boardBoxesArray1D;
        private string[,] boardBoxesArray2D;

        private const int numberOfplayers = 2;
        private const int keepPlaying = 2;
        private const int gameStop = 3;
        private const int gameReset = 4;

        private string[] playersSymbolArray = { "X", "O" };

        //private bool keepPlaying;

        //player1 = 0, player2 = 1
        private int playerTurn;
        private int stateOfGame;

        public int BoardXSize { get => boardYSize; set => boardXSize = value; }
        public int BoardYSize { get => boardYSize; set => boardYSize = value; }


        public int PlayerTurn { get => playerTurn; set => playerTurn = value; }
        public int StateOfGame { get => stateOfGame; set => stateOfGame = value; }

        public GameBoard()
        {
            //keepPlaying = true;
            PlayerTurn = 0;
            StateOfGame = keepPlaying;

            this.BoardXSize = 3;
            this.BoardYSize = 3;

            boardBoxes = new string[BoardXSize * BoardYSize];
            int counter = 0;
            //2d array way
            /*
            for (int i = 0; i < boardBoxes.GetLength(0); i++)
            {
                for (int j = 0; j < boardBoxes.GetLength(1); j++)
                {
                    boardBoxes[i, j] = counter.ToString();
                    counter++;
                }
            }
            */
            for (int i = 0; i < boardBoxes.Length; i++)
            {
                boardBoxes[i] = counter.ToString();
                counter++;
            }
        }

        public void DisplayBoard()
        {
            Console.Clear();

            //foreach (string s in boardBoxes)
            //{
            //    Console.Write()
            //    Console.WriteLine(s);
            //}

            for (int i = 0; i < BoardYSize; i++)
            {
                Console.WriteLine("|     |     |     |");
                for (int j = 0; j < BoardXSize; j++)
                {
                    if (!(int.TryParse(Coordinates2IdBox(j, i), out int temp)))
                    {
                        Console.Write("|  {0}  ", Coordinates2IdBox(j, i));
                    }
                    else
                    {
                        Console.Write("|  {0}  ", temp + 1);
                    }


                }
                Console.WriteLine("|\n|     |     |     |");
            }


            // Console.WriteLine(BoardXSize+" "+ BoardYSize);
            // Console.WriteLine(boardBoxes[((3-1)+((BoardYSize*(1-1))))]);
        }

        public void MakeMove(int boxID, string playerSymbol)
        {
            boardBoxes[boxID] = playerSymbol;
        }

        public bool CanYouMakeAMove(int boxID)
        {
            if (boardBoxes[boxID] == playersSymbolArray[0] ||
                boardBoxes[boxID] == playersSymbolArray[1])
            {
                return false;
            }
            return true;
        }
        //2 - nobody win, 0- player 1 win, 1 - player 2 win
        public int DidPlayerWin()
        {
            if (StateOfGame == gameStop)
                return gameStop;
            if (StateOfGame == gameReset)
                return gameReset;

            for (int iPlayer = 0; iPlayer < numberOfplayers; iPlayer++)
            {
                if (CheckRowWin(boardXSize, boardYSize, playersSymbolArray[iPlayer]))
                    return iPlayer;

                if (CheckColumnWin(boardXSize, boardYSize, playersSymbolArray[iPlayer]))
                    return iPlayer;

                if (CheckDiagonalWin(boardXSize, boardYSize, playersSymbolArray[iPlayer]))
                    return iPlayer;
            }

            return keepPlaying;
        }

        //Coordinates from 1 too N
        public string Coordinates2IdBox1ToN(int xCoordinate, int yCoordinate)
        {
            return boardBoxes[((xCoordinate - 1) + ((BoardYSize * (yCoordinate - 1))))];
        }
        //Coordinates from 0 too N-1
        public string Coordinates2IdBox(int xCoordinate, int yCoordinate)
        {
            return boardBoxes[((xCoordinate) + ((BoardYSize * (yCoordinate))))];
        }


        public bool RowWin(int rowSize, int rowNumber, string playerSymbol)
        {
            for (int i = 0; i < rowSize; i++)
            {
                // Console.WriteLine("{0} {1} {2}",i,rowNumber,Coordinates2IdBox(i,rowNumber));
                //if (Coordinates2IdBox(rowNumber,i) != playerSymbol)//column
                if (Coordinates2IdBox(i, rowNumber) != playerSymbol)//row
                {
                    return false;
                }
            }

            return true;
        }

        public bool CheckRowWin(int rowSize, int numberOfRows, string playerSymbol)
        {

            for (int i = 0; i < numberOfRows; i++)
            {
                if (RowWin(rowSize, i, playerSymbol))
                    return true;
            }

            return false;
        }

        public bool ColumnWin(int colSize, int colNumber, string playerSymbol)
        {

            for (int i = 0; i < colSize; i++)
            {
                // Console.WriteLine("{0} {1} {2}", i, colNumber, Coordinates2IdBox(colNumber, i));
                if (Coordinates2IdBox(colNumber, i) != playerSymbol)
                {
                    return false;
                }
            }

            return true;
        }

        public bool CheckColumnWin(int colSize, int numberOfColumns, string playerSymbol)
        {
            for (int i = 0; i < numberOfColumns; i++)
            {
                if (ColumnWin(colSize, i, playerSymbol))
                    return true;
            }
            return false;
        }

        public bool CheckDiagonalWinOne(int boardXSize, int boardYSize, string playerSymbol)
        {
            for (int index = 0; index < boardXSize; index++)
            {
                if (Coordinates2IdBox(index, index) != playerSymbol)
                {
                    return false;
                }

            }
            return true;
        }

        public bool CheckDiagonalWinTwo(int boardXSize, int boardYSize, string playerSymbol)
        {
            for (int index = 0; index < boardXSize; index++)
            {
                if (Coordinates2IdBox(boardXSize - 1 - index, index) != playerSymbol)
                {
                    return false;
                }

            }
            return true;
        }

        public bool CheckDiagonalWin(int boardXSize, int boardYSize, string playerSymbol)
        {
            return (CheckDiagonalWinOne(boardXSize, boardYSize, playerSymbol) || CheckDiagonalWinTwo(boardXSize, boardYSize, playerSymbol));
        }



        public bool CheckEnteredNumber(string playerChoosenBoxString, out int playerChoosenBox)
        {
            if (!(int.TryParse(playerChoosenBoxString, out playerChoosenBox)))
            {
                Console.WriteLine("Wrowadź dostępny numer wybranego pola Player {0}", PlayerTurn + 1);
                return false;
            }

            if ((playerChoosenBox > BoardXSize * BoardYSize || playerChoosenBox < 1))
            {
                Console.WriteLine("Liczba musi znajdować się w przedziale od 1 do 9");
                return false;
            }

            if (!CanYouMakeAMove(playerChoosenBox - 1))
            {
                Console.WriteLine("Pole jest zajętę");
                return false;
            }

            return true;
        }

        public int UserInterface()
        {
            string playerChoosenBoxString = "";

            bool EnteredIdIsCorrect = false;
            int playerChoosenBox = 0;
            while (!EnteredIdIsCorrect)
            {
                Console.WriteLine("Wybierz pole, Player {0}", PlayerTurn + 1);
                playerChoosenBoxString = Console.ReadLine();
                if (playerChoosenBoxString == "q" || playerChoosenBoxString == "Q")
                {
                    StateOfGame = gameStop;
                    return playerChoosenBox;
                }
                if (playerChoosenBoxString == "r" || playerChoosenBoxString == "R")
                {
                    StateOfGame = gameReset;
                    return playerChoosenBox;
                }
                EnteredIdIsCorrect = CheckEnteredNumber(playerChoosenBoxString, out playerChoosenBox);
            }

            return playerChoosenBox;
        }

        public void PlayerMakeMove(string playerSymbol)
        {
            int playerChoosenBox = UserInterface() - 1;
            if (StateOfGame == gameStop || StateOfGame == gameReset)
                return;
            // int playerChoosenBox=EnterID();
            //MakeMove(UserInterface() - 1, playerSymbol);
            MakeMove(playerChoosenBox, playerSymbol);

            if (PlayerTurn == 0)
            {
                PlayerTurn = 1;
            }
            else
            {
                PlayerTurn = 0;
            }

            return;
        }

        public bool Duel()
        {
            DisplayBoard();
            while (stateOfGame == keepPlaying)
            {
                PlayerMakeMove(playersSymbolArray[PlayerTurn]);
                DisplayBoard();
                stateOfGame = DidPlayerWin();
            }
            if (stateOfGame == gameReset)
            {
                return true;
            }
            if (stateOfGame == 0 || stateOfGame == 1)
            {
                Console.WriteLine("Player {0} WIN!!!!!", stateOfGame + 1);

            }
            return false;
        }


        /*
         * 
         * Dopisać\poprawić sprawdzanie liczby wpisanej
         * 
         * /


                //2d array way
                /*
                public void MakeMove(int xCoordinate, int yCoordinate, string playerSymbol)
                {
                    boardBoxes[xCoordinate, yCoordinate] = playerSymbol; 
                }

                public bool CanYouMakeAMove(int xCoordinate, int yCoordinate)
                {
                    if (boardBoxes[xCoordinate, yCoordinate] == playersSymbolArray[0] || 
                        boardBoxes[xCoordinate, yCoordinate] == playersSymbolArray[1])
                    {
                        return false;
                    }      
                    return true;
                }
                */


    }//end of class
}
