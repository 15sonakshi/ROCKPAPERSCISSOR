using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ROCKPAPERSESSIOR
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputplayer, inputCpu;
            int randomInt;

            bool playagain = true;

            while (playagain)
            {
                int scorePlayer = 0;
                int scoreCpu = 0;


                while (scorePlayer < 3 && scoreCpu < 3)
                {

                    Console.Write("Choose between Rock , Paper and Scissor : ");
                    inputplayer = Console.ReadLine();
                    inputplayer = inputplayer.ToUpper();


                    Random rnd = new Random();

                    randomInt = rnd.Next(1, 4);

                    switch (randomInt)
                    {

                        case 1:
                            inputCpu = "Rock";
                            Console.Write("Computer Chose Rock");
                            if (inputplayer == "Rock")
                            {
                                Console.WriteLine("Draw!!\n\n");
                            }
                            else if (inputplayer == "Paper")
                            {
                                Console.WriteLine("Player Wins!!\n\n");
                                scorePlayer++;
                            }
                            else if (inputplayer == "Scissor")
                            {
                                Console.WriteLine("Cpu Wins!!\n\n");
                                scoreCpu++;
                            }
                            break;

                        case 2:
                            inputCpu = "Paper";
                            Console.Write("Computer Chose Paper");
                            if (inputplayer == "Paper")
                            {
                                Console.WriteLine("Draw!!\n\n");
                            }
                            else if (inputplayer == "Rock")
                            {
                                Console.WriteLine("Cpu Wins!!\n\n");
                                scoreCpu++;
                            }
                            else if (inputplayer == "Scissor")
                            {
                                Console.WriteLine("Player Wins!!\n\n");
                                scorePlayer++;
                            }
                            break;

                        case 3:
                            inputCpu = "Scissor";
                            Console.WriteLine("Computer Chose Scissor");
                            if (inputplayer == "Scissor")
                            {
                                Console.WriteLine("Draw!!\n\n");
                            }
                            else if (inputplayer == "Rock")
                            {
                                Console.WriteLine("Player Wins!!\n\n");
                                scorePlayer++;
                            }
                            else if (inputplayer == "Paper")
                            {
                                Console.WriteLine("Cpu Wins!!\n\n");
                                scoreCpu++;
                            }
                            break;

                        default:
                            Console.Write("Invalid Entry");
                            break;
                    }
                    Console.WriteLine("\n\nScores:\tPlayer:\t(0)\tCpu:\t(1)", scoreCpu, scorePlayer);

                }
                if (scorePlayer == 3)
                {
                    Console.WriteLine("Player Won");
                }
                else if (scoreCpu == 3)
                {
                    Console.WriteLine("Cpu Won");
                }

                            

                
             

            }

            Console.WriteLine("Do you want to play again?(y/n)");
            string loop = Console.ReadLine();
            if (loop == "y")
            {
                playagain = true;
                Console.Clear();
            }
            else if (loop == "n")
            {
                playagain = false;
            }
        }

    }
}


