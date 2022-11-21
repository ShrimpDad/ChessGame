using System;

namespace Chess
{
    internal class ChessGame
    {
        internal static void Greet()
        {
            Console.WriteLine("Welcome to Nightmare Chess where the code is sustained soley by horrifyingly flaky and inefficient methods");
            Console.WriteLine("");
            System.Threading.Thread.Sleep(5000);
            Console.Clear();
        }

        internal static void RunGame()
        {
            //Variables
            String edge = Environment.NewLine;
            String v = "|";
            String h = "_";
            String g = " ";
            String f = "_";
            String move = "";
            String turn = "lowercase";
            String lastTurn = "lowercase";
            int xFrom = 0;
            int yFrom = 0;
            int xyFrom = 0;
            int xTo = 0;
            int yTo = 0;
            int xyTo = 0;

            String[] sqr = { "r", "h", "b", "q", "k", "b", "h", "r", "p", "p", "p", "p", "p", "p", "p", "p", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "P", "P", "P", "P", "P", "P", "P", "P", "R", "H", "B", "Q", "K", "B", "H", "R" };
            


            //initialise starting board array
            string[,] sq = new string[8, 8]
            {
                {"r", "h", "b", "q", "k", "b", "h", "r"},
                {"p", "p", "p", "p", "p", "p", "p", "p"},
                {" ", " ", " ", " ", " ", " ", " ", " "},
                {" ", " ", " ", " ", " ", " ", " ", " "},
                {" ", " ", " ", " ", " ", " ", " ", " "},
                {" ", " ", " ", " ", " ", " ", " ", " "},
                {"P", "P", "P", "P", "P", "P", "P", "P"},
                {"R", "H", "B", "Q", "K", "B", "H", "R"}
            };

            while (move != "stop")
            {
                //PrintBoard
                Console.WriteLine("   A B C D E F G H");
                Console.WriteLine("   _ _ _ _ _ _ _ _");
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("8 " + v + sq[0, 0] + v + sq[0, 1] + v + sq[0, 2] + v + sq[0, 3] + v + sq[0, 4] + v + sq[0, 5] + v + sq[0, 6] + v + sq[0, 7] + v);
                Console.WriteLine("7 " + v + sq[1, 0] + v + sq[1, 1] + v + sq[1, 2] + v + sq[1, 3] + v + sq[1, 4] + v + sq[1, 5] + v + sq[1, 6] + v + sq[1, 7] + v);
                Console.WriteLine("6 " + v + sq[2, 0] + v + sq[2, 1] + v + sq[2, 2] + v + sq[2, 3] + v + sq[2, 4] + v + sq[2, 5] + v + sq[2, 6] + v + sq[2, 7] + v);
                Console.WriteLine("5 " + v + sq[3, 0] + v + sq[3, 1] + v + sq[3, 2] + v + sq[3, 3] + v + sq[3, 4] + v + sq[3, 5] + v + sq[3, 6] + v + sq[3, 7] + v);
                Console.WriteLine("4 " + v + sq[4, 0] + v + sq[4, 1] + v + sq[4, 2] + v + sq[4, 3] + v + sq[4, 4] + v + sq[4, 5] + v + sq[4, 6] + v + sq[4, 7] + v);
                Console.WriteLine("3 " + v + sq[5, 0] + v + sq[5, 1] + v + sq[5, 2] + v + sq[5, 3] + v + sq[5, 4] + v + sq[5, 5] + v + sq[5, 6] + v + sq[5, 7] + v);
                Console.WriteLine("2 " + v + sq[6, 0] + v + sq[6, 1] + v + sq[6, 2] + v + sq[6, 3] + v + sq[6, 4] + v + sq[6, 5] + v + sq[6, 6] + v + sq[6, 7] + v);
                Console.WriteLine("1 " + v + sq[7, 0] + v + sq[7, 1] + v + sq[7, 2] + v + sq[7, 3] + v + sq[7, 4] + v + sq[7, 5] + v + sq[7, 6] + v + sq[7, 7] + v);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("");


                //Declare movement
                Console.WriteLine($"It is now " + turn + " to move");
                Console.WriteLine("Declare move in format (A# to A#):");
                move = Console.ReadLine();


                //update turn
                if (turn == "lowercase")
                {
                    turn = "UPPERCASE";
                }
                else
                {
                    turn = "lowercase";
                }


                //Find array pos for from move[0] for column factor
                if (move[0] == 'A')
                {
                    xFrom = 0;
                }
                if (move[0] == 'B')
                {
                    xFrom = 1;
                }
                if (move[0] == 'C')
                {
                    xFrom = 2;
                }
                if (move[0] == 'D')
                {
                    xFrom = 3;
                }
                if (move[0] == 'E')
                {
                    xFrom = 4;
                }
                if (move[0] == 'F')
                {
                    xFrom = 5;
                }
                if (move[0] == 'G')
                {
                    xFrom = 6;
                }
                if (move[0] == 'H')
                {
                    xFrom = 7;
                }
                //Find array pos for from move[1] for row factor, converting the Char to Int before calculating to grid
                int yFromConv = Convert.ToInt32(new string(move[1], 1));
                yFrom = (8 - yFromConv);


                //Calculate array position for P2
                //Find array pos for from move[0] for column factor
                if (move[6] == 'A')
                {
                    xTo = 0;
                }
                if (move[6] == 'B')
                {
                    xTo = 1;
                }
                if (move[6] == 'C')
                {
                    xTo = 2;
                }
                if (move[6] == 'D')
                {
                    xTo = 3;
                }
                if (move[6] == 'E')
                {
                    xTo = 4;
                }
                if (move[6] == 'F')
                {
                    xTo = 5;
                }
                if (move[6] == 'G')
                {
                    xTo = 6;
                }
                if (move[6] == 'H')
                {
                    xTo = 7;
                }

                //Find array pos for from move[1] for row factor, converting the Char to Int before calculating to grid
                int yToConv = Convert.ToInt32(new string(move[7], 1));
                yTo = (8 - yToConv);

                //Switch the pieces
                sq[yTo, xTo] = sq[yFrom, xFrom];
                sq[yFrom, xFrom] = " ";

                Console.Clear();
            }
        }
    }
}