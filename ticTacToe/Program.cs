using System;
using System.Threading;


namespace ticTacToe
{
    class Program
    {
        static char[] array = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1;
        static int choice = 1;
        static int winner = 0;

        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Player one gets X and player two gets O");
                Console.WriteLine("\n");
                if (player % 2 == 0)
                {
                    Console.WriteLine("Player twos turn");
                }
                else
                {
                    Console.WriteLine("Player ones turn");
                }

                Board();

                choice = int.Parse(Console.ReadLine());

                if (array[choice] != 'X' && array[choice] != 'Y')
                {
                    if (player % 2 == 0)
                    {
                        array[choice] = 'O';
                        player++;
                    }
                    else
                    {
                        array[choice] = 'X';
                        player++;
                    }

                }
                else
                {
                    Console.WriteLine("{0} is alredy taken pleas try again");

                }

                winner = CheckWin();
            }
            while (winner != 1 && winner != -1);

            Console.Clear();
            Board();

            if(winner == 1)
            {
                Console.WriteLine("Player {0} is the winner", (player % 2)+1);
            }
            else
            {
                Console.WriteLine("You ar both loosers!");
            }
            Console.ReadLine();

            //Console.WriteLine("Wanna play again?(y/n)");
            //reamtch = Console.ReadLine();

            //if (reamtch = "y")
            //{

            //}
            //else if(reamtch = "n")
            //{
            //    Console.WriteLine("Bye bye");
            //}
            //else
            //{
            //    Console.WriteLine("Try again!");
            //}

        }

        private static void Board()
        {
            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", array[1], array[2], array[3]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", array[4], array[5], array[6]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", array[7], array[8], array[9]);

            Console.WriteLine("     |     |      ");
        }



        private static int CheckWin()

        {
            // If win First/Secund/Third row   
            if (array[1] == array[2] && array[2] == array[3])
            {
                return 1;
            }
            else if (array[4] == array[5] && array[5] == array[6])
            {
                return 1;
            }
            else if (array[6] == array[7] && array[7] == array[8])
            {
                return 1;
            }

            //If Win First/Second/Third column       
            else if (array[1] == array[4] && array[4] == array[7])
            {
                return 1;
            }
            else if (array[2] == array[5] && array[5] == array[8])
            {
                return 1;
            }
            else if (array[3] == array[6] && array[6] == array[9])
            {
                return 1;
            }

            //If Winn kross 
            else if (array[1] == array[5] && array[5] == array[9])
            {
                return 1;
            }
            else if (array[3] == array[5] && array[5] == array[7])
            {
                return 1;
            }

            // If draw  
            else if (array[1] != '1' && array[2] != '2' && array[3] != '3' && array[4] != '4' && array[5] != '5' && array[6] != '6' && array[7] != '7' && array[8] != '8' && array[9] != '9')

            {
                return -1;
            }
            else
            {
                return 0;
            }

        }

        
    }
}
